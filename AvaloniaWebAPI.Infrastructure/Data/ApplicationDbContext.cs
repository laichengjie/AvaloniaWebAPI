using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; // 添加此 using
using AvaloniaWebAPI.Core.Entities;

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

        public DbSet<SD_Pos_SalPromotionShop> SalPromotionShops { get; set; }

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
                // entity.ToTable("SD_Pos_SalPromotion"); // 保持注释或删除此行

                // 配置复合主键
                entity.HasKey(e => new { e.CompanyID, e.PromotionID });
            });


            // 门店促销关联表配置
            modelBuilder.Entity<SD_Pos_SalPromotionShop>(entity =>
            {
               
                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.ShopID });

          

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.ShopID);

                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionShops)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });


        }
    }
}