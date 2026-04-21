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
        public DbSet<SD_Pos_SalPromotionVip> SalPromotionVips { get; set; }
        public DbSet<SD_Pos_SalPromotionMaterial> SalPromotionMaterials { get; set; }
        public DbSet<SD_Pos_SalPromotionSetPresendPro> SalPromotionSetPresendPros { get; set; }
        public DbSet<SD_Pos_SalPromotionSetPresendTHQ> SalPromotionSetPresendTHQs { get; set; }
        public DbSet<SD_Pos_SalPromotionSetTHQ> SalPromotionSetTHQs { get; set; }

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


            // 促销活动从表
            modelBuilder.Entity<SD_Pos_SalPromotionMaterial>(entity =>
            {

                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.Sequence });

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.Sequence);
                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionMaterials)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });
            modelBuilder.Entity<SD_Pos_SalPromotionSetPresendPro>(entity =>
            {

                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.JoinPromotionID });

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.JoinPromotionID);
                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionSetPresendPros)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });
            modelBuilder.Entity<SD_Pos_SalPromotionSetPresendTHQ>(entity =>
            {

                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.THQID, e.THQType });

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.THQID);
                entity.HasIndex(e => e.THQType);
                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionSetPresendTHQs)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });
            modelBuilder.Entity<SD_Pos_SalPromotionSetTHQ>(entity =>
            {

                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.THQID, e.THQType });

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.THQID);
                entity.HasIndex(e => e.THQType);
                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionSetTHQs)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });
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
            modelBuilder.Entity<SD_Pos_SalPromotionVip>(entity =>
            {

                entity.HasKey(e => new { e.CompanyID, e.PromotionID, e.CardTypeID });

                // 索引
                entity.HasIndex(e => e.PromotionID);
                entity.HasIndex(e => e.CardTypeID);
                // 外键关系
                entity.HasOne(e => e.Promotion)
                      .WithMany(p => p.PromotionVips)
                      .HasForeignKey(e => new { e.CompanyID, e.PromotionID });
            });
           
        }
    }
}