using AvaloniaWebAPI.Core.Entities;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IMaterialService
    {
        Task<IEnumerable<SD_Mat_Material>> GetAllMaterialsAsync(string ModifyDTM);
        
    }
}