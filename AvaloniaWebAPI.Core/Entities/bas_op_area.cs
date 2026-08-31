using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 业务地区表
    /// </summary>
    [Table("bas_op_area")]
    public class bas_op_area
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int? group_id { get; set; }

        /// <summary>
        /// 所属公司(组织单元)
        /// </summary>
        [Column("ou_id")]
        public int? ou_id { get; set; }

        /// <summary>
        /// 层级编号
        /// </summary>
        [Column("level_no")]
        public int? level_no { get; set; }

        /// <summary>
        /// 父级地区ID
        /// </summary>
        [Column("area_parent_id")]
        public int? area_parent_id { get; set; }

        /// <summary>
        /// 地区代码
        /// </summary>
        [Column("area_code")]
        public string? area_code { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        [Column("area_name")]
        public string? area_name { get; set; }

        /// <summary>
        /// 地区全称
        /// </summary>
        [Column("area_full_name")]
        public string? area_full_name { get; set; }

        /// <summary>
        /// 全路径ID
        /// </summary>
        [Column("area_full_path_id")]
        public string? area_full_path_id { get; set; }

        /// <summary>
        /// 全路径名称
        /// </summary>
        [Column("area_full_path_name")]
        public string? area_full_path_name { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [Column("manager")]
        public string? manager { get; set; }

        /// <summary>
        /// 启用状态（0禁用，1启用）
        /// </summary>
        [Column("status")]
        public int? status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string? remark { get; set; }

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
        /// 外部ID
        /// </summary>
        [Column("ext_id")]
        public string? ext_id { get; set; }
    }

}




