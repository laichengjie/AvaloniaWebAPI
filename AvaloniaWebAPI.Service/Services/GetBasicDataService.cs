using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using AvaloniaWebAPI.Infrastructure.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.Common;

namespace AvaloniaWebAPI.Service.Services
{
    public class GetBasicDataService : IGetBasicDataService
    {
        private readonly ILogger<GetBasicDataService> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly SDDbContext _sdDbContext;
        private readonly MCDbContext _mcDbContext;

        public GetBasicDataService( ILogger<GetBasicDataService> logger, ApplicationDbContext dbContext, SDDbContext sdDbContext, MCDbContext mcDbContext) 
        {
            _logger = logger;
            _dbContext = dbContext;
            _sdDbContext = sdDbContext;
            _mcDbContext = mcDbContext;
        }

        public async Task<PlatformBasicDataResult<T>> GetBasicDataAsync<T>(PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation($"查询{request.DataMethod}数据，ModifyDTM: {(request.ModifyDTM == null ? "null" : request.ModifyDTM.Value.ToString("yyyy-MM-dd HH:mm:ss"))}");

                var queryTime = DateTime.Now;
                var tableName = request.TableName;

                // 使用同一个连接
                using (var connection = GetConnection(request.DataMethod))
                {
                    await connection.OpenAsync();

                    // 构建 SQL
                    string sql = "";
                    if (request.DataMethod == "GetParaConfig")
                    {
                        sql = $"select a.id ,a.id as para_id, a.para_name,a.para_code,coalesce(b.para_value,a.para_value) as para_value,coalesce(b.show_value,a.show_value) as show_value from bas_para a  Left join bas_para_config b on a.id=b.para_id and b.group_id=3 and b.ou_id=9 and  b.shop_id=4953 and b.is_deleted=0 where a.para_type_id=3 and a.is_deleted=0 union all select a.id , a.id as para_id,a.para_name,a.para_code,para_value,show_value  from bas_para a  where a.is_deleted=0  and  a.para_code in(\"DS0021\",\"SD0050\",\"SD0090\",\"SC0002\",\"SD0075\",\"SD0073\",\"SD0072\",\"SD0070\",\"SD0071\",\"SD0041\",\"Sys0027\" ,\"SD0069\",\"SD0060\",\"Sys0001\",\"Sys0004\",\"Member004\",\"FP0002\",\"SD0093\",\"SD0094\",\"SD0095\",\"SD0096\" ,\"SD0101\",\"SD0103\",\"SD0106\",\"SD0110\",\"SD0045\",\"SD0126\",\"SD0128\",\"KC0022\",\"KC0042\",\"SD0132\",\"SD0136\" ,\"Sys0085\",\"EI0001\",\"SD0012\",\"SD0141\",\"Sys0011\",\"SD0157\",\"SD0158\",\"SD0161\",\"SD0164\",\"DS0007\" ,\"SD0163\",\"SD0175\",\"SD0173\",\"SD0177\",\"SD0176\",\"SD0178\",\"Member032\",\"SD0180\",\"EI0003\",\"EI0005\" ,\"SD0179\",\"EI0007\",\"Sys0082\",\"SD0182\",\"Sys0002\",\"SD0183\",\"Sys0097\",\"SD0185\",\"Sys0091\",\"SD0186\" ,\"SD0201\",\"SYS095\",\"SD0192\",\"Sys0025\" ,\"SD0150\",\"SD0193\",\"Sys0107\",\"SD0195\",\" SD0203\",\"SD0196\",\"SD0208\" ,\"SD0211\",\"Guide015\",\"Guide0151\",\"SD0190\",\"Msg0001\", \"Msg0002\", \"DS0021\", \"Sys0060\")";
                    }
                    else
                    {
                        sql = $"SELECT * FROM {tableName} WHERE 1=1";

                        if (await ColumnExistsAsync(connection, tableName, "modified_time"))
                        {
                            sql += " AND modified_time >= @ModifyDTM";
                        }

                        // 检查并添加 group_id 条件
                        if (await ColumnExistsAsync(connection, tableName, "group_id") && request.DataMethod != "GetDictItem")
                        {
                            sql += " AND group_id = 3";
                        }

                        // 检查并添加 ou_id 条件
                        if (await ColumnExistsAsync(connection, tableName, "ou_id") && request.DataMethod != "GetSku")
                        {
                            sql += " AND ou_id = 9";
                        }

                        // 检查并添加 shop_id 条件
                        if (await ColumnExistsAsync(connection, tableName, "shop_id"))
                        {
                            sql += " AND shop_id = 21023";
                        }
                        else if (await ColumnExistsAsync(connection, tableName, "shopId"))
                        {
                            sql += " AND shopId = 21023";
                        }

                        //sql += " ORDER BY modified_time DESC";
                    }

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
        /// 根据 DataMethod 获取对应的数据库连接
        /// </summary>
       
        private DbConnection GetConnection(string dataMethod)
        {
            switch (dataMethod)
            {
                case "GetYgouDiscount":
                case "GetYgouDiscountRole":
                    return _sdDbContext.Database.GetDbConnection();
                case "GetBundleAct":
                    return _mcDbContext.Database.GetDbConnection();
                default:
                    return _dbContext.Database.GetDbConnection();
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