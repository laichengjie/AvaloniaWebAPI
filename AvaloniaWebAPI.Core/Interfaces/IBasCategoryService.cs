using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IBasCategoryService
    {
        /// <summary>
        /// 获取所有类目
        /// </summary>
        Task<PlatformBasicDataResult<bas_category>> GetAllCategoriesAsync(PlatformBasicDataRequest request);
    }
}