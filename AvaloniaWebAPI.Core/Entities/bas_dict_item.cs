using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 数据字典项表
    /// </summary>
    [Table("bas_dict_item")]
    public class bas_dict_item
    {
        /// <summary>
        /// 主键ID（自增）
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
        /// 字典ID
        /// </summary>
        [Column("dict_id")]
        public int dict_id { get; set; }

        /// <summary>
        /// 值编码
        /// </summary>
        [Column("item_code")]
        public string item_code { get; set; } = string.Empty;

        /// <summary>
        /// 值名称
        /// </summary>
        [Column("item_name")]
        public string item_name { get; set; } = string.Empty;

        /// <summary>
        /// 值（smallint映射为INTEGER）
        /// </summary>
        [Column("item_value")]
        public int item_value { get; set; } = 1;

        /// <summary>
        /// 排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }

        /// <summary>
        /// 多语言关键字
        /// </summary>
        [Column("multi_language_key")]
        public string multi_language_key { get; set; } = string.Empty;

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = string.Empty;

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }
}