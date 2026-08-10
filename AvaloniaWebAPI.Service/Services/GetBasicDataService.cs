using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using AvaloniaWebAPI.Infrastructure.Data;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaWebAPI.Service.Services
{
    public class GetBasicDataService : IGetBasicDataService
    {
        private readonly ILogger<GetBasicDataService> _logger;
        private readonly ApplicationDbContext _dbContext;

        public GetBasicDataService( ILogger<GetBasicDataService> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<PlatformBasicDataResult<T>> GetBasicDataAsync<T>(PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation($"查询{request.DataMethod}数据，ModifyDTM: {(request.ModifyDTM == null ? "null" : request.ModifyDTM.Value.ToString("yyyy-MM-dd HH:mm:ss"))}");

                var queryTime = DateTime.Now;

                // 构建 SQL
                string sql = $"SELECT * FROM {request.TableName} WHERE 1=1";


                if (request.ModifyDTM != null)
                {
                    sql += " AND modified_time >= @ModifyDTM";
                }

                sql += " ORDER BY modified_time DESC";

                // 使用 Dapper
                using (var connection = _dbContext.Database.GetDbConnection())
                {
                    var items = await connection.QueryAsync<T>(sql, new
                    {
                        ModifyDTM = request.ModifyDTM
                    });

                    var result = items.ToList();

                    _logger.LogInformation($"查询{request.DataMethod}数据完成，共 {result.Count} 条记录");

                    return new PlatformBasicDataResult<T>
                    {
                        items = result,
                        totalCount = result.Count,
                        queryTime = queryTime
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询类目数据失败，ModifyDTM: {request.ModifyDTM?.ToString("yyyy-MM-dd HH:mm:ss") ?? "null"}");
                throw;
            }
        }
    }
}