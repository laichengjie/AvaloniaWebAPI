using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 店铺对应职员类型表
    /// </summary>
    [Table("bas_employee_shop")]
    public class bas_employee_shop
    {
        /// <summary>
        /// ID（自增主键）
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
        /// 职员ID
        /// </summary>
        [Column("employee_id")]
        public int employee_id { get; set; }

        /// <summary>
        /// 组织单元
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 所属店铺
        /// </summary>
        [Column("shop_id")]
        public int shop_id { get; set; }

        /// <summary>
        /// 是否默认（0否，1是）
        /// </summary>
        [Column("is_default")]
        public int is_default { get; set; }

        /// <summary>
        /// 职员类型
        /// </summary>
        [Column("employee_type_id")]
        public int employee_type_id { get; set; }

        /// <summary>
        /// 职员类型名称
        /// </summary>
        [Column("employee_type_Name")]
        public string employee_type_Name { get; set; } = string.Empty;

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