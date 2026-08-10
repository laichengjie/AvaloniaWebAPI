using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 规格表
    /// </summary>
    [Table("bas_spec")]
    public class bas_spec
    {
        /// <summary>
        /// 规格ID（主键）
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
        /// 规格编码
        /// </summary>
        [Column("spec_code")]
        public string spec_code { get; set; } = string.Empty;

        /// <summary>
        /// 规格名称
        /// </summary>
        [Column("spec_name")]
        public string spec_name { get; set; } = string.Empty;

        /// <summary>
        /// 控件类型（1.下拉 2.日期 3.手工输入 4.关联档案）
        /// </summary>
        [Column("control_type")]
        public int control_type { get; set; } = 1;

        /// <summary>
        /// 是否系统定义（0否，1是）
        /// </summary>
        [Column("Is_system")]
        public int Is_system { get; set; }

        /// <summary>
        /// 显示排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; } = 1;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 启用规则组（0否，1是）
        /// </summary>
        [Column("specgroup_enable")]
        public int specgroup_enable { get; set; } = 1;

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string created_by { get; set; } = "system";

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime created_time { get; set; } = DateTime.Now;

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
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        /// <summary>
        /// 删除时间（默认3000-12-31）
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);
    }
}