using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IMaterialService
    {
        Task<PlatformBasicDataResult<SD_Mat_Material>> GetMaterialsAsync(PlatformBasicDataRequest request);
    }
}