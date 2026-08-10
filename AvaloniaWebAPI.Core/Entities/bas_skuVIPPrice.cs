using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// SKU会员价表
    /// </summary>
    [Table("bas_skuVIPPrice")]
    public class bas_skuVIPPrice
    {
        /// <summary>
        /// SKUID
        /// </summary>
        [Key]
        [Column("skuid")]
        public int skuid { get; set; }

        /// <summary>
        /// 会员等级ID
        /// </summary>
        [Key]
        [Column("member_grade_id")]
        public int member_grade_id { get; set; }

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
        /// 会员价
        /// </summary>
        [Column("vip_price")]
        public decimal vip_price { get; set; }
    }
}