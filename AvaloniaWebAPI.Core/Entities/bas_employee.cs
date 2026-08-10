using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 职员基础资料表
    /// </summary>
    [Table("bas_employee")]
    public class bas_employee
    {
        /// <summary>
        /// 职员ID（自增主键）
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
        /// 职员编码
        /// </summary>
        [Column("employee_code")]
        public string employee_code { get; set; } = string.Empty;

        /// <summary>
        /// 职员姓名
        /// </summary>
        [Column("employee_name")]
        public string employee_name { get; set; } = string.Empty;

        /// <summary>
        /// 手机号码
        /// </summary>
        [Column("mobile")]
        public string mobile { get; set; } = string.Empty;

        /// <summary>
        /// 性别
        /// </summary>
        [Column("sex")]
        public int sex { get; set; }

        /// <summary>
        /// 状态(在职状态)
        /// </summary>
        [Column("status")]
        public int status { get; set; } = 1;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("enable_status")]
        public int enable_status { get; set; } = 1;

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

        /// <summary>
        /// 密码
        /// </summary>
        [Column("password")]
        public string password { get; set; } = string.Empty;
    }
}