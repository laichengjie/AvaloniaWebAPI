using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 组合商品属性
    /// </summary>
    [Table("bas_combine_property")]
    public class bas_combine_property
    {
        /// <summary>
        /// 表ID（主键，自增）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime created_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string? modified_by { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string? deleted_by { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 组合商品ID
        /// </summary>
        [Column("combine_id")]
        public int combine_id { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [Column("property_id")]
        public int property_id { get; set; }

        /// <summary>
        /// 属性值编码
        /// </summary>
        [Column("property_value_code")]
        public string property_value_code { get; set; } = string.Empty;

        /// <summary>
        /// 属性值名称
        /// </summary>
        [Column("property_value_name")]
        public string property_value_name { get; set; } = string.Empty;

        /// <summary>
        /// 属性值ID
        /// </summary>
        [Column("property_value_id")]
        public int property_value_id { get; set; }
    }
}