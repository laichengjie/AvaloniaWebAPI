using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// SKU表
    /// </summary>
    [Table("bas_sku")]
    public class bas_sku
    {
        /// <summary>
        /// SKUID（自增主键）
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
        /// SKC编码
        /// </summary>
        [Column("skc_code")]
        public string skc_code { get; set; } = string.Empty;

        /// <summary>
        /// SKC名称
        /// </summary>
        [Column("skc_name")]
        public string skc_name { get; set; } = string.Empty;

        /// <summary>
        /// SKU编码
        /// </summary>
        [Column("sku_code")]
        public string sku_code { get; set; } = string.Empty;

        /// <summary>
        /// SKU名称
        /// </summary>
        [Column("sku_name")]
        public string sku_name { get; set; } = string.Empty;

        /// <summary>
        /// 条码
        /// </summary>
        [Column("barcode")]
        public string barcode { get; set; } = string.Empty;

        /// <summary>
        /// 条码1
        /// </summary>
        [Column("barcode1")]
        public string barcode1 { get; set; } = string.Empty;

        /// <summary>
        /// 条码2
        /// </summary>
        [Column("barcode2")]
        public string barcode2 { get; set; } = string.Empty;

        /// <summary>
        /// 基本单位
        /// </summary>
        [Column("unit_id")]
        public int unit_id { get; set; }

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
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        /// <summary>
        /// SKCID
        /// </summary>
        [Column("skc_id")]
        public string skc_id { get; set; } = string.Empty;

        /// <summary>
        /// 序号
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }
    }
}