using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IMaterialService
    {
        Task<PagedResult<SD_Mat_Material>> GetAllMaterialsAsync(string? ModifyDTM);
        Task<PagedResult<SD_Mat_Material>> GetAllMaterialsAsync(PlatformBasicDataRequest request);
    }
}