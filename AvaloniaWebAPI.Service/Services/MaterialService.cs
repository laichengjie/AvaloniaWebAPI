using AvaloniaWebAPI.Core.Entities;
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

        public async Task<PlatformBasicDataResult<SD_Mat_Material>> GetMaterialsAsync(PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation($"查询货号数据，ModifyDTM: {(request.ModifyDTM == null ? "null" : request.ModifyDTM.Value.ToString("yyyy-MM-dd HH:mm:ss"))}");
                // 使用 IQueryable，避免把整个表拉到内存
                var query = _materialRepository.Query();
                var queryTime = DateTime.Now;

                if (request.ModifyDTM!=null)
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {request.ModifyDTM:yyyy-MM-dd HH:mm:ss} 的货号数据");
                    query = query.Where(m => m.ModifyDTM >= request.ModifyDTM);
                    
                }
                var items = await query.ToListAsync();
                return new PlatformBasicDataResult<SD_Mat_Material>
                {
                    items = items,
                    totalCount = items.Count,
                    queryTime = queryTime
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询货号数据失败，ModifyDTM: {request.ModifyDTM:yyyy-MM-dd HH:mm:ss}");
                throw;
            }
        }
    }
}