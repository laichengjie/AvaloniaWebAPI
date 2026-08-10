using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 规格组表
    /// </summary>
    [Table("bas_specgroup")]
    public class bas_specgroup
    {
        /// <summary>
        /// 规格组ID（自增主键）
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
        /// 规格ID
        /// </summary>
        [Column("spec_id")]
        public int spec_id { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [Column("category_id")]
        public int category_id { get; set; } = 1;

        /// <summary>
        /// 规格组编码
        /// </summary>
        [Column("specgroup_code")]
        public string specgroup_code { get; set; } = string.Empty;

        /// <summary>
        /// 规格组名称
        /// </summary>
        [Column("specgroup_name")]
        public string specgroup_name { get; set; } = string.Empty;

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; } = 1;

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

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