using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Service.Services
{
    public class BasCategoryService : IBasCategoryService
    {
        private readonly IRepository<bas_category> _categoryRepository;
        private readonly ILogger<BasCategoryService> _logger;

        public BasCategoryService(IRepository<bas_category> categoryRepository, ILogger<BasCategoryService> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<PlatformBasicDataResult<bas_category>> GetAllCategoriesAsync(PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation($"查询类目数据，ModifyDTM: {(request.ModifyDTM == null ? "null" : request.ModifyDTM.Value.ToString("yyyy-MM-dd HH:mm:ss"))}");

                var query = _categoryRepository.Query();
                var queryTime = DateTime.Now;

                // 按修改时间过滤
                if (request.ModifyDTM != null)
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {request.ModifyDTM:yyyy-MM-dd HH:mm:ss} 的类目数据");
                    query = query.Where(c => c.modified_time >= request.ModifyDTM);
                }

                var items = query.ToList();

                return new PlatformBasicDataResult<bas_category>
                {
                    items = items,
                    totalCount = items.Count,
                    queryTime = queryTime
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询类目数据失败，ModifyDTM: {request.ModifyDTM?.ToString("yyyy-MM-dd HH:mm:ss") ?? "null"}");
                throw;
            }
        }
    }
}



