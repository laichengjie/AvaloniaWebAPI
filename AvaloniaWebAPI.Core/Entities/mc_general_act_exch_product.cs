using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 通用活动-换购规则-换购商品
    /// </summary>
    [Table("mc_general_act_exch_product")]
    public class mc_general_act_exch_product
    {
        /// <summary>
        /// ID（主键，自增）
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
        /// 活动ID
        /// </summary>
        [Column("activity_id")]
        public int activity_id { get; set; }

        /// <summary>
        /// 商品组序号
        /// </summary>
        [Column("pgroup_seq")]
        public int pgroup_seq { get; set; }

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
        /// 商品条件JSON格式
        /// </summary>
        [Column("filter_json")]
        public string filter_json { get; set; } = string.Empty;

        /// <summary>
        /// 商品条件SQL表达式
        /// </summary>
        [Column("filter_sql")]
        public string filter_sql { get; set; } = string.Empty;

        /// <summary>
        /// 商品条件描述
        /// </summary>
        [Column("filter_description")]
        public string filter_description { get; set; } = string.Empty;

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        /// <summary>
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 业绩系数
        /// </summary>
        [Column("performance_factor")]
        public decimal performance_factor { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [Column("discount")]
        public decimal discount { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Column("amount")]
        public decimal amount { get; set; }

        /// <summary>
        /// SKC编码
        /// </summary>
        [Column("skc_code")]
        public string skc_code { get; set; } = string.Empty;

        /// <summary>
        /// SKCID
        /// </summary>
        [Column("skc_id")]
        public string skc_id { get; set; } = string.Empty;

        /// <summary>
        /// SKC名称
        /// </summary>
        [Column("skc_name")]
        public string skc_name { get; set; } = string.Empty;

        /// <summary>
        /// 规格值ID
        /// </summary>
        [Column("spec_value_id")]
        public int spec_value_id { get; set; }

        /// <summary>
        /// 规格值名称
        /// </summary>
        [Column("spec_value_name")]
        public string spec_value_name { get; set; } = string.Empty;

        /// <summary>
        /// 条码
        /// </summary>
        [Column("barcode")]
        public string barcode { get; set; } = string.Empty;

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
    }
}