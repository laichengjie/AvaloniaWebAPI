using Microsoft.Extensions.Logging;
using MyWebAPI.Core.Entities;
using MyWebAPI.Core.Interfaces;
using System.Linq.Expressions;

namespace MyWebAPI.Service.Services
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

        public async Task<SD_Mat_Material?> GetMaterialByIdAsync(string materialId)
        {
            _logger.LogInformation($"查询货号: MaterialID={materialId}");
            var materials = await _materialRepository.FindAsync(m => m.MaterialID == materialId);
            return materials.FirstOrDefault();
        }

       

        public async Task<IEnumerable<SD_Mat_Material>> GetAllMaterialsAsync(string? ModifyDTM)
        {
            try
            {
                _logger.LogInformation($"查询货号数据，ModifyDTM: {ModifyDTM ?? "null"}");

                // 如果没有提供日期或日期无效，返回所有数据
                if (string.IsNullOrWhiteSpace(ModifyDTM))
                {
                    _logger.LogInformation("未提供修改时间，返回所有货号数据");
                    return await _materialRepository.GetAllAsync();
                }

                // 尝试解析日期
                if (DateTime.TryParse(ModifyDTM, out var modifyDateTime))
                {
                    _logger.LogInformation($"查询 ModifyDTM >= {modifyDateTime:yyyy-MM-dd HH:mm:ss} 的货号数据");
                    return await _materialRepository.FindAsync(m => m.ModifyDTM >= modifyDateTime);
                }

                // 日期格式无效，记录警告并返回所有数据
                _logger.LogWarning($"无效的日期格式: {ModifyDTM}，返回所有货号数据");
                return await _materialRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"查询货号数据失败，ModifyDTM: {ModifyDTM}");
                throw;
            }
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsAsync(Expression<Func<SD_Mat_Material, bool>> predicate)
        {
            return await _materialRepository.FindAsync(predicate);
        }

        public async Task<SD_Mat_Material> CreateMaterialAsync(SD_Mat_Material material)
        {
            _logger.LogInformation($"创建货号: {material.MaterialCode}");

            // 检查是否已存在
            var exists = await MaterialExistsAsync(material.MaterialID);
            if (exists)
            {
                throw new InvalidOperationException($"货号已存在: {material.MaterialID}");
            }

            material.ModifyDTM = DateTime.Now;
            material.CreateDateTime = material.CreateDateTime ?? DateTime.Now;

            return await _materialRepository.AddAsync(material);
        }

        public async Task UpdateMaterialAsync(SD_Mat_Material material)
        {
            _logger.LogInformation($"更新货号: {material.MaterialID}");
            material.ModifyDTM = DateTime.Now;
            await _materialRepository.UpdateAsync(material);
        }

        public async Task DeleteMaterialAsync(string materialId)
        {
            _logger.LogInformation($"删除货号: {materialId}");
            var material = await GetMaterialByIdAsync(materialId);
            if (material != null)
            {
                await _materialRepository.DeleteAsync(material);
            }
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsByCodeAsync(string materialCode)
        {
            return await _materialRepository.FindAsync(m => m.MaterialCode.Contains(materialCode));
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsByNameAsync(string materialName)
        {
            return await _materialRepository.FindAsync(m =>
                m.MaterialName != null && m.MaterialName.Contains(materialName));
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsByYearAsync(int yearNo)
        {
            return await _materialRepository.FindAsync(m => m.YearNo == yearNo);
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsBySeasonAsync(string seasonId)
        {
            return await _materialRepository.FindAsync(m => m.SeasonID == seasonId);
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsByCompanyAsync(string companyId)
        {
            return await _materialRepository.FindAsync(m => m.CreateCompanyID == companyId);
        }

        public async Task<IEnumerable<SD_Mat_Material>> GetMaterialsByTypeAsync(string matTypeId)
        {
            return await _materialRepository.FindAsync(m => m.MatTypeID == matTypeId);
        }

        public async Task<bool> MaterialExistsAsync(string materialId)
        {
            var materials = await _materialRepository.FindAsync(m => m.MaterialID == materialId);
            return materials.Any();
        }

        public async Task<int> GetMaterialsCountAsync(Expression<Func<SD_Mat_Material, bool>>? predicate = null)
        {
            if (predicate == null)
            {
                var all = await _materialRepository.GetAllAsync();
                return all.Count();
            }
            var filtered = await _materialRepository.FindAsync(predicate);
            return filtered.Count();
        }

        public async Task<(IEnumerable<SD_Mat_Material> Items, int Total)> GetPagedMaterialsAsync(
            int page, int pageSize,
            string? searchKey = null,
            int? yearNo = null,
            string? seasonId = null,
            bool? proAllowUsed = null)
        {
            _logger.LogInformation($"分页查询货号: Page={page}, PageSize={pageSize}");

            var allMaterials = await _materialRepository.GetAllAsync();
            var query = allMaterials.AsQueryable();

            // 筛选条件
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
            // 按 MaterialID 排序（升序）
            query = query.OrderBy(m => m.MaterialID);
            var total = query.Count();
            var items = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return (items, total);
        }
    }
}