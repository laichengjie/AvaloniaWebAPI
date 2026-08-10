using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 用户基础资料表
    /// </summary>
    [Table("scy_user")]
    public class scy_user
    {
        /// <summary>
        /// 用户ID（自增主键）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        [Column("user_group_id")]
        public int? user_group_id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int? group_id { get; set; }

        /// <summary>
        /// 组织单元ID
        /// </summary>
        [Column("ou_id")]
        public int? ou_id { get; set; }

        /// <summary>
        /// 用户代码
        /// </summary>
        [Column("user_code")]
        public string? user_code { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Column("display_name")]
        public string? display_name { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Column("gravatar")]
        public string? gravatar { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Column("password")]
        public string? password { get; set; }

        /// <summary>
        /// 密码强度
        /// </summary>
        [Column("password_strength")]
        public int? password_strength { get; set; }

        /// <summary>
        /// 最后修改密码时间
        /// </summary>
        [Column("last_password_time")]
        public DateTime? last_password_time { get; set; }

        /// <summary>
        /// 职员ID
        /// </summary>
        [Column("employee_id")]
        public int? employee_id { get; set; }

        /// <summary>
        /// 职员编码
        /// </summary>
        [Column("employee_code")]
        public string? employee_code { get; set; }

        /// <summary>
        /// 职员姓名
        /// </summary>
        [Column("employee_name")]
        public string? employee_name { get; set; }

        /// <summary>
        /// 客户/供应商ID
        /// </summary>
        [Column("contact_id")]
        public int? contact_id { get; set; }

        /// <summary>
        /// 客户/供应商编码
        /// </summary>
        [Column("contact_code")]
        public string? contact_code { get; set; }

        /// <summary>
        /// 客户/供应商名称
        /// </summary>
        [Column("contact_name")]
        public string? contact_name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Column("phone_number")]
        public string? phone_number { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [Column("mobile_area_code")]
        public string? mobile_area_code { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [Column("email")]
        public string? email { get; set; }

        /// <summary>
        /// 身份类型
        /// </summary>
        [Column("user_type")]
        public int? user_type { get; set; }

        /// <summary>
        /// 语种
        /// </summary>
        [Column("language_id")]
        public int? language_id { get; set; }

        /// <summary>
        /// 是否注册会员（0否，1是）
        /// </summary>
        [Column("is_reg")]
        public int? is_reg { get; set; }

        /// <summary>
        /// 验证类型
        /// </summary>
        [Column("auth_type")]
        public int? auth_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string? remark { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int? status { get; set; }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        [Column("effective_start")]
        public DateTime? effective_start { get; set; }

        /// <summary>
        /// 有效结束时间
        /// </summary>
        [Column("effective_end")]
        public DateTime? effective_end { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string? created_by { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime? created_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string? modified_by { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime? modified_time { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int? is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string? deleted_by { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime? deleted_time { get; set; }

        /// <summary>
        /// 并发令牌
        /// </summary>
        [Column("concurrency_stamp")]
        public string? concurrency_stamp { get; set; }

        /// <summary>
        /// 手机号码是否有效（0否，1是）
        /// </summary>
        [Column("phone_confirmed")]
        public int? phone_confirmed { get; set; }

        /// <summary>
        /// 是否启用两步认证
        /// </summary>
        [Column("is_two_factor_enabled")]
        public int? is_two_factor_enabled { get; set; }

        /// <summary>
        /// 邮箱是否有效
        /// </summary>
        [Column("email_confirmed")]
        public int? email_confirmed { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [Column("last_login_time")]
        public DateTime? last_login_time { get; set; }

        /// <summary>
        /// 系统版本号
        /// </summary>
        [Column("version_no")]
        public string? version_no { get; set; }

        /// <summary>
        /// 是否主账号
        /// </summary>
        [Column("is_master")]
        public int? is_master { get; set; }

        /// <summary>
        /// 帆软报表用户id
        /// </summary>
        [Column("finertp_user_id")]
        public string? finertp_user_id { get; set; }

        /// <summary>
        /// 默认组织ID
        /// </summary>
        [Column("default_ou_id")]
        public int? default_ou_id { get; set; }
    }
}