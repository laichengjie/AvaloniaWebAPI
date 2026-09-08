using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 整单促销活动-促销设置
    /// </summary>
    [Table("mc_whole_act_config")]
    public class mc_whole_act_config
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
        /// 整单金额
        /// </summary>
        [Column("whole_amount")]
        public decimal whole_amount { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [Column("discount")]
        public decimal discount { get; set; }

        /// <summary>
        /// 让利金额
        /// </summary>
        [Column("preferential_amount")]
        public decimal preferential_amount { get; set; }

        /// <summary>
        /// 换购数量
        /// </summary>
        [Column("exch_qty")]
        public int exch_qty { get; set; }

        /// <summary>
        /// 赠送优惠券
        /// </summary>
        [Column("coupon_id")]
        public int coupon_id { get; set; }

        /// <summary>
        /// 赠送优惠券数量
        /// </summary>
        [Column("coupon_qty")]
        public int coupon_qty { get; set; }

        /// <summary>
        /// 公司承担让利金额
        /// </summary>
        [Column("company_pref_amount")]
        public decimal company_pref_amount { get; set; }

        /// <summary>
        /// 参与商品-促销商品设置方式
        /// </summary>
        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [Column("coupon_name")]
        public string coupon_name { get; set; } = string.Empty;

        /// <summary>
        /// 赠送卡券类型(1.卡券、2.券包)
        /// </summary>
        [Column("gift_coupon_type")]
        public int gift_coupon_type { get; set; } = 1;

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