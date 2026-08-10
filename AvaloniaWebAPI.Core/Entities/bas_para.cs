using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 系统参数表
    /// </summary>
    [Table("bas_para")]
    public class bas_para
    {
        /// <summary>
        /// ID（自增）
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
        /// 业务组织ID
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [Column("shop_id")]
        public int shop_id { get; set; }

        /// <summary>
        /// 参数编码
        /// </summary>
        [Column("para_code")]
        public string para_code { get; set; } = string.Empty;

        /// <summary>
        /// 参数名称
        /// </summary>
        [Column("para_name")]
        public string para_name { get; set; } = string.Empty;

        /// <summary>
        /// 参数值
        /// </summary>
        [Column("para_value")]
        public string para_value { get; set; } = string.Empty;

        /// <summary>
        /// 临时参数值
        /// </summary>
        [Column("tmp_para_value")]
        public string tmp_para_value { get; set; } = string.Empty;

        /// <summary>
        /// 有效开始时间
        /// </summary>
        [Column("effective_start")]
        public DateTime effective_start { get; set; } = DateTime.Now;

        /// <summary>
        /// 有效结束时间（文本存储）
        /// </summary>
        [Column("effective_end")]
        public string effective_end { get; set; } = "30001231";

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