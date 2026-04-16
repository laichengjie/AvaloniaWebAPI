using System.Linq.Expressions;
using System.Linq.Expressions;
using System.Linq;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);

        // 新增：暴露 IQueryable 以便上层在数据库端构造查询（用于分页/排序/复杂筛选）
        IQueryable<T> Query();
    }
}