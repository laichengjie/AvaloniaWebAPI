using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Service.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository<SD_Mat_Material> _materialRepository;
        private readonly ILogger<MaterialService> _logger;

        public MaterialService(IRepository<SD_Mat_Material> materialRepository, ILogger<MaterialService> logger)
        {
            _materialRepository = materialRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetAllMaterialsAsync(string? ModifyDTM)
        {
            try
            {
                _logger.LogInformation($"查询货号数据，ModifyDTM: {ModifyDTM ?? "null"}");

                // 使用 IQueryable，避免把整个表拉到内存
                var query = _materialRepository.Query();

                if (string.IsNullOrWhiteSpace(ModifyDTM))
                {
                    _logger.LogInformation("未提供修改时间，返回所有货号数据");
                    return await query.ToListAsync();
                }

                if (DateTime.TryParse(ModifyDTM, out var modifyDateTime))
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {modifyDateTime:yyyy-MM-dd HH:mm:ss} 的货号数据");
                    query = query.Where(m => m.ModifyDTM >= modifyDateTime);
                    return await query.ToListAsync();
                }

                _logger.LogWarning($"无效的日期格式: {ModifyDTM}，返回所有货号数据");
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询货号数据失败，ModifyDTM: {ModifyDTM}");
                throw;
            }
        }

        
        

        public async Task<(IEnumerable<SD_Mat_Material> Items, int Total)> GetPagedMaterialsAsync(
            int page, int pageSize,
            string? searchKey = null,
            int? yearNo = null,
            string? seasonId = null,
            bool? proAllowUsed = null)
        {
            _logger.LogInformation($"分页查询货号: Page={page}, PageSize={pageSize}");

            var query = _materialRepository.Query();

            // 筛选条件（都在数据库端执行）
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                query = query.Where(m =>
                    (m.MaterialCode != null && m.MaterialCode.Contains(searchKey)) ||
                    (m.MaterialName != null && m.MaterialName.Contains(searchKey)) ||
                    (m.BarCode != null && m.BarCode.Contains(searchKey)));
            }

            if (yearNo.HasValue)
            {
                query = query.Where(m => m.YearNo == yearNo.Value);
            }

            if (!string.IsNullOrWhiteSpace(seasonId))
            {
                query = query.Where(m => m.SeasonID == seasonId);
            }

            if (proAllowUsed.HasValue)
            {
                query = query.Where(m => m.ProAllowUsed == proAllowUsed.Value);
            }

            query = query.OrderBy(m => m.MaterialID);

            var total = await query.CountAsync();
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            return (items, total);
        }
    }
}