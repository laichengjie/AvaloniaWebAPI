using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Core.Interfaces;
using MyWebAPI.Infrastructure.Data;
using MyWebAPI.Infrastructure.Repositories;
using MyWebAPI.Service.Services;
using System.IO.Compression;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// 添加控制器（禁用 JSON 美化以减少传输大小）
builder.Services.AddControllers()
    .AddJsonOptions(opts =>
    {
        opts.JsonSerializerOptions.WriteIndented = false;
    });

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 添加响应压缩
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<GzipCompressionProvider>();

    options.MimeTypes = ResponseCompressionDefaults.MimeTypes
        .Concat(new[]
        {
            "application/json",
            "text/json",
            "application/problem+json",
            "text/plain",
            "text/html",
            "application/javascript",
            "text/javascript",
            "text/css",
            "image/svg+xml",
            "application/xml",
            "text/xml"
        })
        .Distinct()
        .ToArray();
});

builder.Services.Configure<GzipCompressionProviderOptions>(opt =>
{
    opt.Level = CompressionLevel.Optimal;
});

// CORS 配置
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// ========== 关键修改：统一端口配置 ==========
// 开发环境和生产环境都只使用 HTTP，避免 HTTPS 问题
builder.WebHost.UseUrls("http://localhost:5000", "http://*:5000");

// 或者根据环境配置
// if (builder.Environment.IsDevelopment())
// {
//     builder.WebHost.UseUrls("http://localhost:5000");
// }
// else
// {
//     builder.WebHost.UseUrls("http://*:5000");
// }

// 数据库配置
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString, sqlOptions =>
    {
        sqlOptions.CommandTimeout(600);
        sqlOptions.EnableRetryOnFailure(5);
        sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        sqlOptions.MaxBatchSize(100);
    });

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

builder.Services.AddMemoryCache();
builder.Services.AddResponseCaching();

var app = builder.Build();

// 响应压缩（最先）
app.UseResponseCompression();

// 压缩日志中间件
app.Use(async (context, next) =>
{
    var originalBodyStream = context.Response.Body;
    await using var memoryStream = new MemoryStream();
    context.Response.Body = memoryStream;

    try
    {
        await next();

        memoryStream.Seek(0, SeekOrigin.Begin);
        var compressedSize = memoryStream.Length;

        if (context.Response.Headers.TryGetValue("Content-Encoding", out var encoding))
        {
            Console.WriteLine($"[压缩] {context.Request.Path} | 方式: {encoding} | 大小: {compressedSize / 1024.0:F2} KB");
        }

        memoryStream.Seek(0, SeekOrigin.Begin);
        await memoryStream.CopyToAsync(originalBodyStream);
    }
    finally
    {
        context.Response.Body = originalBodyStream;
    }
});

app.UseResponseCaching();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // ========== 关键修改：注释掉 HTTPS 重定向 ==========
    // app.UseHttpsRedirection();
}

app.UseCors("AllowAll");
app.MapControllers();

// 输出启动信息
Console.WriteLine($"环境: {app.Environment.EnvironmentName}");
Console.WriteLine($"启动地址: http://localhost:5000");
Console.WriteLine($"CORS: 已启用，允许所有来源");
Console.WriteLine($"响应压缩: 已启用 (Gzip)");
Console.WriteLine("");
Console.WriteLine("请使用以下地址访问 API:");
Console.WriteLine("  http://localhost:5000/api/Material/GetTest");
Console.WriteLine("  http://localhost:5000/swagger");

app.Run();