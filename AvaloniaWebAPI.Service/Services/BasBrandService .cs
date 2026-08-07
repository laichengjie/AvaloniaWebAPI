using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Service.Services
{
    public class BasBrandService  : IBasBrandService 
    {
        private readonly IRepository<bas_brand> _materialRepository;
        private readonly ILogger<BasBrandService > _logger;

        public BasBrandService (IRepository<bas_brand> materialRepository, ILogger<BasBrandService > logger)
        {
            _materialRepository = materialRepository; 
            _logger = logger;
        }


        public async Task<PlatformBasicDataResult<bas_brand>> GetBrandsAsync(PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation($"查询品牌表数据，ModifyDTM: {(request.ModifyDTM == null ? "null" : request.ModifyDTM.Value.ToString("yyyy-MM-dd HH:mm:ss"))}");
                // 使用 IQueryable，避免把整个表拉到内存
                var query = _materialRepository.Query();
                var queryTime = DateTime.Now;

                if (request.ModifyDTM!=null) 
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {request.ModifyDTM:yyyy-MM-dd HH:mm:ss} 的品牌表数据");
                    query = query.Where(m => m.modified_time >= request.ModifyDTM);
                    
                }
                var items = await query.ToListAsync();
                return new PlatformBasicDataResult<bas_brand>
                {
                    items = items,
                    totalCount = items.Count,
                    queryTime = queryTime
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询品牌表数据失败，ModifyDTM: {request.ModifyDTM:yyyy-MM-dd HH:mm:ss}");
                throw;
            }
        }
    }
}