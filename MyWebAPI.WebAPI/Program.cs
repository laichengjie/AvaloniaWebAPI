using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Core.Interfaces;
using MyWebAPI.Infrastructure.Data;
using MyWebAPI.Infrastructure.Repositories;
using MyWebAPI.Service.Services;
using System.IO.Compression;

var builder = WebApplication.CreateBuilder(args);

// 添加控制器
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// 添加响应压缩
// ========== 添加响应压缩（新增）==========
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = builder.Environment.IsDevelopment(); // 开发环境启用HTTPS压缩
    options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();

    // 指定需要压缩的MIME类型
    options.MimeTypes = new[]
    {
        "application/json",
        "text/json",
        "application/problem+json",
        "text/plain",
        "text/html"
    };
});

// 配置压缩级别（通过 IServiceCollection.Configure，而不是 options.Providers.Configure）
builder.Services.Configure<BrotliCompressionProviderOptions>(opt =>
{
    opt.Level = System.IO.Compression.CompressionLevel.Optimal; // Brotli 最优压缩
});
builder.Services.Configure<GzipCompressionProviderOptions>(opt =>
{
    opt.Level = System.IO.Compression.CompressionLevel.Fastest; // Gzip 速度优先
});

// ========== 添加 CORS 配置 ==========
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()      // 允许任何来源
              .AllowAnyMethod()      // 允许任何 HTTP 方法
              .AllowAnyHeader();     // 允许任何请求头
    });

    // 如果需要更安全的配置，使用下面的配置
    // options.AddPolicy("AllowSpecific", policy =>
    // {
    //     policy.WithOrigins(
    //             "http://localhost:3000",  // React
    //             "http://localhost:4200",  // Angular
    //             "http://localhost:8080",  // Vue
    //             "http://localhost:5500"   // Live Server
    //         )
    //         .AllowAnyMethod()
    //         .AllowAnyHeader()
    //         .AllowCredentials();
    // });
});

// 配置端口（根据环境）
if (builder.Environment.IsDevelopment())
{
    builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:5001");
}
else
{
    // 生产环境只使用 HTTP
    builder.WebHost.UseUrls("http://*:5000");
}

// 生产环境使用 SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString, sqlOptions =>
    {
        sqlOptions.CommandTimeout(600);
        sqlOptions.EnableRetryOnFailure(5);

        // 性能优化配置
        sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        sqlOptions.MaxBatchSize(100);
    });

    // 开发环境启用详细错误和敏感数据日志
    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
});

Console.WriteLine("使用 SQL Server 数据库");

// 依赖注入
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMaterialService, MaterialService>();

// 添加内存缓存（可选，用于提升性能）
builder.Services.AddMemoryCache();

// 添加响应缓存（可选）
builder.Services.AddResponseCaching();

var app = builder.Build();

// ========== 配置中间件顺序（重要）==========
// 1. 响应压缩（最先）
app.UseResponseCompression();

// 2. 响应缓存
app.UseResponseCaching();

// 3. Swagger（开发环境）
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
}

// 4. CORS
app.UseCors("AllowAll");

// 5. 路由和控制器
app.MapControllers();

// 输出启动信息
Console.WriteLine($"环境: {app.Environment.EnvironmentName}");
Console.WriteLine($"启动地址: http://localhost:5000");
Console.WriteLine($"CORS: 已启用，允许所有来源");
Console.WriteLine($"响应压缩: 已启用 (Gzip + Brotli");

// 可选：添加自定义压缩日志中间件
app.Use(async (context, next) =>
{
    var originalBodyStream = context.Response.Body;
    using var memoryStream = new MemoryStream();
    context.Response.Body = memoryStream;

    await next();

    // 记录压缩效果
    if (context.Response.Headers.ContainsKey("Content-Encoding"))
    {
        var encoding = context.Response.Headers["Content-Encoding"].ToString();
        var compressedSize = memoryStream.Length;
        Console.WriteLine($"[压缩] {context.Request.Path} | 方式: {encoding} | 大小: {compressedSize / 1024.0:F2} KB");
    }

    memoryStream.Seek(0, SeekOrigin.Begin);
    await memoryStream.CopyToAsync(originalBodyStream);
});

app.Run();