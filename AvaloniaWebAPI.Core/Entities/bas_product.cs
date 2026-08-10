using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品档案表
    /// </summary>
    [Table("bas_product")]
    public class bas_product
    {
        /// <summary>
        /// 商品ID（自增主键）
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
        /// 类目ID
        /// </summary>
        [Column("category_id")]
        public int category_id { get; set; } = 1;

        /// <summary>
        /// 品牌ID
        /// </summary>
        [Column("brand_id")]
        public int brand_id { get; set; }

        /// <summary>
        /// 税类ID
        /// </summary>
        [Column("taxkind_id")]
        public int taxkind_id { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [Column("product_code")]
        public string product_code { get; set; } = string.Empty;

        /// <summary>
        /// 商品名称
        /// </summary>
        [Column("product_name")]
        public string product_name { get; set; } = string.Empty;

        /// <summary>
        /// 供应商ID
        /// </summary>
        [Column("supplier_id")]
        public int supplier_id { get; set; }

        /// <summary>
        /// 上市日期
        /// </summary>
        [Column("sale_date")]
        public DateTime sale_date { get; set; } = DateTime.Now;

        /// <summary>
        /// 销售模式
        /// </summary>
        [Column("sale_mode_id")]
        public int sale_mode_id { get; set; }

        /// <summary>
        /// 唯一码管理
        /// </summary>
        [Column("unique_mgt")]
        public int unique_mgt { get; set; }

        /// <summary>
        /// 批次管理
        /// </summary>
        [Column("lot_mgt")]
        public int lot_mgt { get; set; }

        /// <summary>
        /// 有效期管理
        /// </summary>
        [Column("validity_mgt")]
        public int validity_mgt { get; set; }

        /// <summary>
        /// 启用多单位
        /// </summary>
        [Column("multi_unit_enabled")]
        public int multi_unit_enabled { get; set; }

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
        /// 零售默认单位
        /// </summary>
        [Column("retail_unit")]
        public int retail_unit { get; set; }

        /// <summary>
        /// 是否组合商品
        /// </summary>
        [Column("is_combine")]
        public int is_combine { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 是否服务商品
        /// </summary>
        [Column("service_product_enabled")]
        public int service_product_enabled { get; set; }

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
        /// 英文名称
        /// </summary>
        [Column("english_name")]
        public string english_name { get; set; } = string.Empty;

        /// <summary>
        /// 是否赠品
        /// </summary>
        [Column("is_gift")]
        public int is_gift { get; set; }

        /// <summary>
        /// 主图地址
        /// </summary>
        [Column("picture_url")]
        public string picture_url { get; set; } = string.Empty;
    }
}