using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-分级促销
    /// </summary>
    [Table("mc_bundle_act_graded_promo")]
    public class mc_bundle_act_graded_promo
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
        /// 序号
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }

        /// <summary>
        /// 购买x件
        /// </summary>
        [Column("buy_qty")]
        public int buy_qty { get; set; }

        /// <summary>
        /// 促销价
        /// </summary>
        [Column("promotion_price")]
        public decimal promotion_price { get; set; }

        /// <summary>
        /// 降价
        /// </summary>
        [Column("reduced_price")]
        public decimal reduced_price { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [Column("discount")]
        public decimal discount { get; set; }

        /// <summary>
        /// 减Y元
        /// </summary>
        [Column("reduced_amount")]
        public decimal reduced_amount { get; set; }

        /// <summary>
        /// 组合金额
        /// </summary>
        [Column("combination_amount")]
        public decimal combination_amount { get; set; }

        /// <summary>
        /// 换购数量
        /// </summary>
        [Column("exch_qty")]
        public int exch_qty { get; set; }

        /// <summary>
        /// 购买金额
        /// </summary>
        [Column("buy_amount")]
        public decimal buy_amount { get; set; }

        /// <summary>
        /// 达成金额类型
        /// </summary>
        [Column("achieved_amount_type")]
        public decimal achieved_amount_type { get; set; }

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

        /// <summary>
        /// 购买第x件
        /// </summary>
        [Column("buy_seq")]
        public int buy_seq { get; set; }

        /// <summary>
        /// 活动基准价
        /// </summary>
        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }
    }
}