using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 员购折扣表（按品牌设置折扣）
    /// </summary>
    [Table("sd_ygou_discount")]
    public class sd_ygou_discount
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
        public int group_id { get; set; }

        /// <summary>
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [Column("brand_id")]
        public int brand_id { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [Column("discount")]
        public decimal discount { get; set; }

        /// <summary>
        /// 状态
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




