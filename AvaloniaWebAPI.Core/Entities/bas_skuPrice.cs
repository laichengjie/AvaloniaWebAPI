using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// SKU表
    /// </summary>
    [Table("bas_skuPrice")]
    public class bas_skuPrice
    {
        /// <summary>
        /// SKUID（主键）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int skuid { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [Column("product_id")]
        public int product_id { get; set; }

        /// <summary>
        /// SKCID
        /// </summary>
        [Column("skc_id")]
        public string skc_id { get; set; } = string.Empty;

        /// <summary>
        /// 折扣
        /// </summary>
        [Column("discount")]
        public decimal discount { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        [Column("vip_price")]
        public decimal vip_price { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        [Column("retail_price")]
        public decimal retail_price { get; set; }

        /// <summary>
        /// 现售价方案单号
        /// </summary>
        [Column("np_bill_no")]
        public string np_bill_no { get; set; } = string.Empty;

        /// <summary>
        /// 现售价享受折扣券优惠
        /// </summary>
        [Column("np_is_discount_by_zkq")]
        public int np_is_discount_by_zkq { get; set; }

        /// <summary>
        /// 现售价
        /// </summary>
        [Column("np_price")]
        public decimal np_price { get; set; }

        /// <summary>
        /// 现售价会员折扣
        /// </summary>
        [Column("np_vip_discount")]
        public int np_vip_discount { get; set; }

        /// <summary>
        /// 现售价会员打折规则
        /// </summary>
        [Column("np_vip_rule")]
        public int np_vip_rule { get; set; }
    }
}