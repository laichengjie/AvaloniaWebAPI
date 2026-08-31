using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-换购促销
    /// </summary>
    [Table("mc_bundle_act_exch")]
    public class mc_bundle_act_exch
    {
        /// <summary>
        /// ID（主键，自增）
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
        /// 活动ID
        /// </summary>
        [Column("activity_id")]
        public int activity_id { get; set; }

        /// <summary>
        /// 换购规则
        /// </summary>
        [Column("exch_rule_id")]
        public int exch_rule_id { get; set; }

        /// <summary>
        /// 换购规则值
        /// </summary>
        [Column("exch_rule_value")]
        public decimal exch_rule_value { get; set; }

        /// <summary>
        /// 换购数量
        /// </summary>
        [Column("exch_qty")]
        public int exch_qty { get; set; }

        /// <summary>
        /// 换购上限
        /// </summary>
        [Column("exch_max_qty")]
        public int exch_max_qty { get; set; }

        /// <summary>
        /// 参与商品-促销商品设置方式
        /// </summary>
        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        /// <summary>
        /// 换购方式
        /// </summary>
        [Column("exch_type_id")]
        public int exch_type_id { get; set; }

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
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);
    }
}