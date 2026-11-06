using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 组合商品-内容
    /// </summary>
    [Table("bas_combine_item")]
    public class bas_combine_item
    {
        /// <summary>
        /// 主键，自增
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
        /// 组合商品ID
        /// </summary>
        [Column("combine_id")]
        public int combine_id { get; set; }

        /// <summary>
        /// SKUID
        /// </summary>
        [Column("sku_id")]
        public int sku_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Column("qty")]
        public int qty { get; set; }

        /// <summary>
        /// 比例权重
        /// </summary>
        [Column("ratio")]
        public decimal ratio { get; set; }

        /// <summary>
        /// 删除标记（0/1）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        /// <summary>
        /// 活动价格
        /// </summary>
        [Column("activity_price")]
        public decimal activity_price { get; set; }

        /// <summary>
        /// 删除人ID
        /// </summary>
        [Column("deleted_id")]
        public int deleted_id { get; set; }
    }
}