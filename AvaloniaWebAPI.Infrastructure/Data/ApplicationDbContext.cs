using Microsoft.EntityFrameworkCore;
using AvaloniaWebAPI.Core.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AvaloniaWebAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SD_Mat_Material> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 软删除过滤
            //modelBuilder.Entity<User>().HasQueryFilter(e => !e.IsDeleted);

            // 唯一索引
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
        }
    }
}