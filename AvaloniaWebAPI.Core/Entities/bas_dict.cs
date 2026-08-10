using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 数据字典表
    /// </summary>
    [Table("bas_dict")]
    public class bas_dict
    {
        /// <summary>
        /// 主键ID（自增）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 字段编码代码
        /// </summary>
        [Column("dict_code")]
        public string dict_code { get; set; } = string.Empty;

        /// <summary>
        /// 字段名称
        /// </summary>
        [Column("dict_name")]
        public string dict_name { get; set; } = string.Empty;

        /// <summary>
        /// 多语言关键字
        /// </summary>
        [Column("multi_language_key")]
        public string multi_language_key { get; set; } = string.Empty;
    }
}