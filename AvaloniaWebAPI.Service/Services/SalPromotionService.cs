using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Service.Services
{
    public class SalPromotionService : ISalPromotionService
    {
        private readonly IRepository<SD_Pos_SalPromotion> _materialRepository;
        private readonly ILogger<SalPromotionService> _logger;

        public SalPromotionService(IRepository<SD_Pos_SalPromotion> materialRepository, ILogger<SalPromotionService> logger)
        {
            _materialRepository = materialRepository;
            _logger = logger;
        }
        public async Task<IEnumerable<SD_Pos_SalPromotion>> GetAllSalPromotionsAsync(string? ModifyDTM)
        {
            try
            {
                _logger.LogInformation($"查询促销活动数据，ModifyDTM: {ModifyDTM ?? "null"}");
                 
                // 使用 IQueryable，避免把整个表拉到内存 
                var query = _materialRepository.Query();

                if (string.IsNullOrWhiteSpace(ModifyDTM))
                {
                    _logger.LogInformation("未提供修改时间，返回所有促销活动数据");
                    return await query.ToListAsync();
                }

                if (DateTime.TryParse(ModifyDTM, out var modifyDateTime))
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {modifyDateTime:yyyy-MM-dd HH:mm:ss} 的促销活动数据");
                    query = query.Where(m => m.ModifyDTM >= modifyDateTime);
                    return await query.ToListAsync();
                }

                _logger.LogWarning($"无效的日期格式: {ModifyDTM}，返回所有促销活动数据");
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询促销活动数据失败，ModifyDTM: {ModifyDTM}");
                throw;
            }
        }

        
    }
}