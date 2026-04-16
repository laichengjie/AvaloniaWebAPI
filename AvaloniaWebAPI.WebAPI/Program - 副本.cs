using Microsoft.EntityFrameworkCore;
using MyWebAPI.Core.Interfaces;
using MyWebAPI.Infrastructure.Data;
using MyWebAPI.Infrastructure.Repositories;
using MyWebAPI.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// 添加控制器
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    });
});
Console.WriteLine("使用 SQL Server 数据库");

// 依赖注入
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMaterialService, MaterialService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();  // 只在开发环境启用 HTTPS 重定向
}
else
{
    // 生产环境不启用 HTTPS 重定向
    // app.UseHttpsRedirection();
}

// ========== 使用 CORS（必须在 UseAuthorization 之前，MapControllers 之前） ==========
app.UseCors("AllowAll");  // 使用允许所有的策略

app.MapControllers();

// 输出启动信息
Console.WriteLine($"环境: {app.Environment.EnvironmentName}");
Console.WriteLine($"启动地址: http://localhost:5000");
Console.WriteLine($"CORS: 已启用，允许所有来源");

app.Run();