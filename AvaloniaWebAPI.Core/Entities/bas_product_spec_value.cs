using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品规格值表
    /// </summary>
    [Table("bas_product_spec_value")]
    public class bas_product_spec_value
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
        /// 商品规格ID
        /// </summary>
        [Column("product_spec_id")]
        public int product_spec_id { get; set; }

        /// <summary>
        /// 规格值ID
        /// </summary>
        [Column("spec_id")]
        public int spec_id { get; set; }

        /// <summary>
        /// 规格值ID
        /// </summary>
        [Column("spec_value_id")]
        public int? spec_value_id { get; set; }

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
        /// 英文名称
        /// </summary>
        [Column("english_name")]
        public string english_name { get; set; } = string.Empty;

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}