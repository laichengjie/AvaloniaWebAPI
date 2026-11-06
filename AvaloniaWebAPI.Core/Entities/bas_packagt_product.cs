using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐-参与商品
    /// </summary>
    [Table("bas_packagt_product")]
    public class bas_packagt_product
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 商品套餐ID
        /// </summary>
        [Column("package_id")]
        public int package_id { get; set; }

        /// <summary>
        /// 商品组ID
        /// </summary>
        [Column("pgroup_id")]
        public int pgroup_id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [Column("product_id")]
        public int product_id { get; set; }

        /// <summary>
        /// SKUID
        /// </summary>
        [Column("sku_id")]
        public int sku_id { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        [Column("retail_price")]
        public decimal retail_price { get; set; }

        /// <summary>
        /// 加价
        /// </summary>
        [Column("markup")]
        public decimal markup { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}