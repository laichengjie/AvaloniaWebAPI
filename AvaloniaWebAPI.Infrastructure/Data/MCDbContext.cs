using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; // 添加此 using
using AvaloniaWebAPI.Core.Entities;

namespace AvaloniaWebAPI.Infrastructure.Data
{
    public class MCDbContext : DbContext
    {
        public MCDbContext(DbContextOptions<MCDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}




