using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 规格值表
    /// </summary>
    [Table("bas_spec_value")]
    public class bas_spec_value
    {
        /// <summary>
        /// 规格值ID（主键）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [Column("spec_id")]
        public int spec_id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 规格值编码
        /// </summary>
        [Column("spec_value_code")]
        public string spec_value_code { get; set; } = string.Empty;

        /// <summary>
        /// 规格值名称
        /// </summary>
        [Column("spec_value_name")]
        public string spec_value_name { get; set; } = string.Empty;

        /// <summary>
        /// 排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; } = 1;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}