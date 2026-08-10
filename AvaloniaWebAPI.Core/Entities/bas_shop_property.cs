using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 店铺属性表
    /// </summary>
    [Table("bas_shop_property")]
    public class bas_shop_property
    {
        /// <summary>
        /// 表ID（主键）
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
        /// 店铺ID
        /// </summary>
        [Column("shop_id")]
        public int shop_id { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [Column("property_id")]
        public int property_id { get; set; }

        /// <summary>
        /// 属性编码
        /// </summary>
        [Column("property_code")]
        public string property_code { get; set; } = string.Empty;

        /// <summary>
        /// 属性名称
        /// </summary>
        [Column("property_name")]
        public string property_name { get; set; } = string.Empty;

        /// <summary>
        /// 属性值ID
        /// </summary>
        [Column("property_value_id")]
        public int property_value_id { get; set; }

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
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }
}