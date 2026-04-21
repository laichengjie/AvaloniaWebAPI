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

        // 新增：把活动促销表加入模型
        public DbSet<SD_Pos_SalPromotion> SalPromotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 现有配置
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            // 只需要配置复合主键
            modelBuilder.Entity<SD_Pos_SalPromotion>(entity =>
            {
                // 如果实体类已经有 [Table] 特性，这里不需要再调用 ToTable
                // entity.ToTable("SD_Pos_SalPromotion");

                // 配置复合主键
                entity.HasKey(e => new { e.CompanyID, e.PromotionID });
            });
        }
    }
}