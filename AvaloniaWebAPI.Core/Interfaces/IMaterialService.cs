using AvaloniaWebAPI.Core.Entities;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IMaterialService
    {
        // 基础 CRUD
        Task<SD_Mat_Material?> GetMaterialByIdAsync(string materialId);
        Task<IEnumerable<SD_Mat_Material>> GetAllMaterialsAsync(string ModifyDTM);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsAsync(Expression<Func<SD_Mat_Material, bool>> predicate);
        Task<SD_Mat_Material> CreateMaterialAsync(SD_Mat_Material material);
        Task UpdateMaterialAsync(SD_Mat_Material material);
        Task DeleteMaterialAsync(string materialId);

        // 业务方法
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsByCodeAsync(string materialCode);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsByNameAsync(string materialName);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsByYearAsync(int yearNo);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsBySeasonAsync(string seasonId);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsByCompanyAsync(string companyId);
        Task<IEnumerable<SD_Mat_Material>> GetMaterialsByTypeAsync(string matTypeId);
        Task<bool> MaterialExistsAsync(string materialId);
        Task<int> GetMaterialsCountAsync(Expression<Func<SD_Mat_Material, bool>>? predicate = null);

        // 分页查询
        Task<(IEnumerable<SD_Mat_Material> Items, int Total)> GetPagedMaterialsAsync(
            int page, int pageSize,
            string? searchKey = null,
            int? yearNo = null,
            string? seasonId = null,
            bool? proAllowUsed = null);
    }
}