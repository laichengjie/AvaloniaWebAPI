using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; // 添加此 using
using AvaloniaWebAPI.Core.Entities;

namespace AvaloniaWebAPI.Infrastructure.Data
{
    public class SDDbContext : DbContext
    {
        public SDDbContext(DbContextOptions<SDDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}




