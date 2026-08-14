using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using AvaloniaWebAPI.Infrastructure.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Data;

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
                var tableName = request.TableName;

                // 使用同一个连接
                using (var connection = _dbContext.Database.GetDbConnection())
                {
                    await connection.OpenAsync();

                    // 构建 SQL
                    string sql = $"SELECT * FROM {tableName} WHERE 1=1";

                    if (request.ModifyDTM != null)
                    {
                        sql += " AND modified_time >= @ModifyDTM";
                    }

                    // 检查并添加 group_id 条件
                    if (await ColumnExistsAsync(connection, tableName, "group_id"))
                    {
                        sql += " AND group_id = 3";
                    }

                    // 检查并添加 ou_id 条件
                    if (await ColumnExistsAsync(connection, tableName, "ou_id"))
                    {
                        sql += " AND ou_id = 9";
                    }

                    // 检查并添加 shop_id 条件
                    if (await ColumnExistsAsync(connection, tableName, "shop_id"))
                    {
                        sql += " AND shop_id = 4953";
                    }
                    else if (await ColumnExistsAsync(connection, tableName, "shopId"))
                    {
                        sql += " AND shopId = 4953";
                    }

                    sql += " ORDER BY modified_time DESC";

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
                _logger.LogError(ex, $"查询数据失败 ： {ex.Message} ModifyDTM: {request.ModifyDTM?.ToString("yyyy-MM-dd HH:mm:ss") ?? "null"}");
                throw;
            }
        }

        /// <summary>
        /// 检查表中是否存在指定字段（使用已打开的连接）
        /// </summary>
        private async Task<bool> ColumnExistsAsync(IDbConnection connection, string tableName, string columnName)
        {
            try
            {
                // MySQL 查询字段是否存在
                string sql = @"
            SELECT COUNT(*) 
            FROM information_schema.COLUMNS 
            WHERE TABLE_SCHEMA = DATABASE() 
            AND TABLE_NAME = @TableName 
            AND COLUMN_NAME = @ColumnName";

                var count = await connection.ExecuteScalarAsync<int>(sql, new
                {
                    TableName = tableName,
                    ColumnName = columnName
                });

                return count > 0;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, $"检查字段是否存在失败，Table: {tableName}, Column: {columnName}");
                return false;
            }
        }
    }
}