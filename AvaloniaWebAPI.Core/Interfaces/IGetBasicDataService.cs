using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IGetBasicDataService
    {
        Task<PlatformBasicDataResult<T>> GetBasicDataAsync<T>(PlatformBasicDataRequest request);
    }
}  