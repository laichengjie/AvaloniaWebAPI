using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐-参与商品表
    /// </summary>
    [Table("bas_packagt_product")]
    public class bas_packagt_product
    {
        /// <summary>
        /// ID（自增主键）
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
        /// 商品组名称
        /// </summary>
        [Column("pgroup_name")]
        public string pgroup_name { get; set; } = string.Empty;

        /// <summary>
        /// 购买数量
        /// </summary>
        [Column("qty")]
        public decimal qty { get; set; }

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
    }
}