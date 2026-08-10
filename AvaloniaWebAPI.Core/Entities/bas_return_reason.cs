using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 退货原因表
    /// </summary>
    [Table("bas_return_reason")]
    public class bas_return_reason
    {
        /// <summary>
        /// 退货原因ID（自增）
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
        /// 所属公司(组织单元)
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 退货大类代码
        /// </summary>
        [Column("return_code")]
        public string return_code { get; set; } = string.Empty;

        /// <summary>
        /// 退货大类名称
        /// </summary>
        [Column("return_name")]
        public string return_name { get; set; } = string.Empty;

        /// <summary>
        /// 退货类别(1采购、2零售、3批发)
        /// </summary>
        [Column("return_type")]
        public int return_type { get; set; }

        /// <summary>
        /// 退货原因代码
        /// </summary>
        [Column("reason_code")]
        public string reason_code { get; set; } = string.Empty;

        /// <summary>
        /// 退货原因名称
        /// </summary>
        [Column("reason_name")]
        public string reason_name { get; set; } = string.Empty;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; } = 1;

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