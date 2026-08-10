using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 属性表
    /// </summary>
    [Table("bas_property")]
    public class bas_property
    {
        /// <summary>
        /// 属性ID（自增主键）
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
        /// 全路径ID
        /// </summary>
        [Column("property_fullpath_id")]
        public string property_fullpath_id { get; set; } = string.Empty;

        /// <summary>
        /// 全路径名称
        /// </summary>
        [Column("property_fullpath_name")]
        public string property_fullpath_name { get; set; } = string.Empty;

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; } = 1;

        /// <summary>
        /// 是否POS显示（0否，1是）
        /// </summary>
        [Column("pos_show_enabled")]
        public int pos_show_enabled { get; set; }

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
        /// 英文名称
        /// </summary>
        [Column("english_name")]
        public string english_name { get; set; } = string.Empty;
    }
}