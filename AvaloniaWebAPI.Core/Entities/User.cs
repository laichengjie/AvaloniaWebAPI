using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("Sys_User")]  
    public class User  
    {
        [Key]
        [Column("UserID")]
        public string UserID { get; set; }

        [Column("UserCode")]
        [MaxLength(50)]
        public string? UserCode { get; set; }

        [Column("UserPassword")]
        [MaxLength(200)]
        [JsonIgnore]
        public string? UserPassword { get; set; }

        [Column("UserName")]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Column("CompanyID")]
        [Required]
        [MaxLength(50)]
        public string CompanyID { get; set; } = string.Empty;

        [Column("AbleTime")]
        public DateTime? AbleTime { get; set; }

        [Column("DisableTime")]
        public DateTime? DisableTime { get; set; }

        [Column("UserNote")]
        [MaxLength(500)]
        public string? UserNote { get; set; }

        [Column("AuthType")]
        [MaxLength(20)]
        public string? AuthType { get; set; }

        [Column("PasswordType")]
        public int? PasswordType { get; set; }

        [Column("PasswordParam")]
        [MaxLength(50)]
        public string? PasswordParam { get; set; }

        [Column("PersonnelID")]
        [MaxLength(20)]
        public string? PersonnelID { get; set; }

        [Column("IsInit")]
        public bool? IsInit { get; set; }

        [Column("AllowUsed")]
        public bool? AllowUsed { get; set; }

        [Column("ModifyPwdDTM")]
        public DateTime? ModifyPwdDTM { get; set; }

        [Column("ModifyDTM")]
        public DateTime? ModifyDTM { get; set; }

        [Column("ADAccount")]
        [MaxLength(50)]
        public string? ADAccount { get; set; }

        [Column("IfShowWorkToDoPage")]
        public bool? IfShowWorkToDoPage { get; set; }

        [Column("SendUserGroup")]
        public bool? SendUserGroup { get; set; }

        [Column("StartSoftLoginByAD")]
        public bool? StartSoftLoginByAD { get; set; }

        [Column("AllowUserDataRight")]
        public bool? AllowUserDataRight { get; set; }

        [Column("ADPassword")]
        [MaxLength(200)]
        [JsonIgnore]
        public string? ADPassword { get; set; }

        [Column("DataSyncFlag")]
        public bool? DataSyncFlag { get; set; }

        [Column("IDaaS_Init")]
        public bool? IDaaS_Init { get; set; }

        // 非数据库字段，用于返回用户信息（可选）
        [NotMapped]
        public string? DisplayName => UserName ?? UserCode;
    }
}