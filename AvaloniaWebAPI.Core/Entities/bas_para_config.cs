using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 组织参数配置表
    /// </summary>
    [Table("bas_para_config")]
    public class bas_para_config
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
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [Column("shop_id")]
        public int shop_id { get; set; }

        /// <summary>
        /// 参数ID
        /// </summary>
        [Column("para_id")]
        public int para_id { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [Column("para_value")]
        public string para_value { get; set; } = string.Empty;

        /// <summary>
        /// 显示值
        /// </summary>
        [Column("show_value")]
        public string show_value { get; set; } = string.Empty;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; } = 1;

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string created_by { get; set; } = string.Empty;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime created_time { get; set; } = DateTime.Now;

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

        /// <summary>
        /// 是否被引用（0否，1是）
        /// </summary>
        [Column("is_used")]
        public int is_used { get; set; }

        /// <summary>
        /// POS自定义设置（0否，1是）
        /// </summary>
        [Column("is_pos_custom")]
        public int is_pos_custom { get; set; }
    }

}




