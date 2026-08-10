using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// SKU规格值表
    /// </summary>
    [Table("bas_sku_spec_value")]
    public class bas_sku_spec_value
    {
        /// <summary>
        /// 表ID（自增主键）
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
        /// SKUID
        /// </summary>
        [Column("sku_id")]
        public int sku_id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [Column("product_id")]
        public int product_id { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [Column("spec_id")]
        public int spec_id { get; set; }

        /// <summary>
        /// 规格编码
        /// </summary>
        [Column("spec_code")]
        public string spec_code { get; set; } = string.Empty;

        /// <summary>
        /// 规格名称
        /// </summary>
        [Column("spec_name")]
        public string spec_name { get; set; } = string.Empty;

        /// <summary>
        /// 规格值ID
        /// </summary>
        [Column("spec_value_id")]
        public int spec_value_id { get; set; }

        /// <summary>
        /// 规格值编码
        /// </summary>
        [Column("spec_value_code")]
        public string spec_value_code { get; set; } = string.Empty;

        /// <summary>
        /// 规格值名称
        /// </summary>
        [Column("spec_value_name")]
        public string spec_value_name { get; set; } = string.Empty;

        /// <summary>
        /// 排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }
}