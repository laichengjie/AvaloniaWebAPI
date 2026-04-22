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

                // 先定义 query 为 IQueryable 类型，避免类型不兼容
                var baseQuery = _materialRepository.Query();

                // 先过滤，再 Include
                if (!string.IsNullOrWhiteSpace(ModifyDTM) && DateTime.TryParse(ModifyDTM, out var modifyDateTime))
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {modifyDateTime:yyyy-MM-dd HH:mm:ss} 的促销活动数据");
                    baseQuery = baseQuery.Where(m => m.ModifyDTM >= modifyDateTime);
                }
                else if (!string.IsNullOrWhiteSpace(ModifyDTM))
                {
                    _logger.LogWarning($"无效的日期格式: {ModifyDTM}，返回所有促销活动数据");
                }
                else
                {
                    _logger.LogInformation("未提供修改时间，返回所有促销活动数据");
                }

                // 最后 Include
                var query = baseQuery
                           .Include(p => p.PromotionShops)
                           .Include(p => p.PromotionVips)
                           .Include(p => p.PromotionMaterials)
                           .Include(p => p.PromotionSetPresendPros)
                           .Include(p => p.PromotionSetPresendTHQs)
                           .Include(p => p.PromotionSetTHQs);

                var result = await query.ToListAsync();

                // 记录主表和从表数量
                var mainCount = result.Count;
                var shopsCount = result.Sum(p => p.PromotionShops?.Count ?? 0);
                var vipsCount = result.Sum(p => p.PromotionVips?.Count ?? 0);
                var materialsCount = result.Sum(p => p.PromotionMaterials?.Count ?? 0);
                var presendProsCount = result.Sum(p => p.PromotionSetPresendPros?.Count ?? 0);
                var presendTHQsCount = result.Sum(p => p.PromotionSetPresendTHQs?.Count ?? 0);
                var setTHQsCount = result.Sum(p => p.PromotionSetTHQs?.Count ?? 0);

                var totalDetailCount = shopsCount + vipsCount + materialsCount +
                                       presendProsCount + presendTHQsCount + setTHQsCount;
                var grandTotal = mainCount + totalDetailCount;

                _logger.LogInformation(
                    $"查询完成 - 活动记录数: {mainCount}, " +
                    $"店铺数量: {shopsCount}, " +
                    $"会员数量: {vipsCount}, " +
                    $"货号数量: {materialsCount}, " +
                    $"预设优惠券数量: {presendProsCount}, " +
                    $"预设赠送优惠券数量: {presendTHQsCount}, " +
                    $"优惠券数量: {setTHQsCount}, " +
                    $"从表合计: {totalDetailCount}, " +
                    $"总计(主表+从表): {grandTotal}"
                );

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询促销活动数据失败，ModifyDTM: {ModifyDTM}");
                throw;
            }
        }


    }
}