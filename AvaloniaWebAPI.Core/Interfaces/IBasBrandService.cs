using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IBasBrandService
    {
        /// <summary>
        /// 获取所有品牌
        /// </summary>
        Task<PagedResult<bas_brand>> GetAllBrandsAsync(PlatformBasicDataRequest request);
    }
}