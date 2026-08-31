using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动
    /// </summary>
    [Table("mc_bundle_act")]
    public class mc_bundle_act
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
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [Column("activity_type_id")]
        public int activity_type_id { get; set; }

        /// <summary>
        /// 活动等级
        /// </summary>
        [Column("activity_grade_id")]
        public int activity_grade_id { get; set; }

        /// <summary>
        /// 活动编码
        /// </summary>
        [Column("bill_code")]
        public string bill_code { get; set; } = string.Empty;

        /// <summary>
        /// 活动名称
        /// </summary>
        [Column("activity_name")]
        public string activity_name { get; set; } = string.Empty;

        /// <summary>
        /// 有效开始时间
        /// </summary>
        [Column("effective_start")]
        public DateTime effective_start { get; set; } = DateTime.Now;

        /// <summary>
        /// 有效结束时间
        /// </summary>
        [Column("effective_end")]
        public DateTime effective_end { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 是否时段约束
        /// </summary>
        [Column("time_range_enabled")]
        public int time_range_enabled { get; set; }

        /// <summary>
        /// 时段开始
        /// </summary>
        [Column("time_range_start")]
        public DateTime time_range_start { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// 时段结束
        /// </summary>
        [Column("time_range_end")]
        public DateTime time_range_end { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// 活动基准价
        /// </summary>
        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }

        /// <summary>
        /// 活动参与次数(每一个人参与最大次数)
        /// </summary>
        [Column("per_max_times")]
        public int per_max_times { get; set; }

        /// <summary>
        /// 适用人群
        /// </summary>
        [Column("apply_crowd_id")]
        public int apply_crowd_id { get; set; }

        /// <summary>
        /// 是否与整单销售活动叠加
        /// </summary>
        [Column("overlay_whole_promotion")]
        public int overlay_whole_promotion { get; set; }

        /// <summary>
        /// 按周期重复
        /// </summary>
        [Column("repeat_enabled")]
        public int repeat_enabled { get; set; } = 1;

        /// <summary>
        /// 促销方式
        /// </summary>
        [Column("promotion_mode_id")]
        public int promotion_mode_id { get; set; }

        /// <summary>
        /// 分级促销
        /// </summary>
        [Column("is_graded_promotion")]
        public int is_graded_promotion { get; set; }

        /// <summary>
        /// 分级折扣
        /// </summary>
        [Column("is_graded_discount")]
        public int is_graded_discount { get; set; }

        /// <summary>
        /// 换购促销
        /// </summary>
        [Column("is_redemption_promotion")]
        public int is_redemption_promotion { get; set; }

        /// <summary>
        /// 商品组捆绑规则
        /// </summary>
        [Column("pgroup_bundling_rule_id")]
        public int pgroup_bundling_rule_id { get; set; }

        /// <summary>
        /// 捆绑数量
        /// </summary>
        [Column("pgroup_bundling_qty")]
        public int pgroup_bundling_qty { get; set; }

        /// <summary>
        /// 参与商品-促销商品设置方式
        /// </summary>
        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        /// <summary>
        /// 店铺范围(是否所有店铺):0 指定 1不限制 2排除
        /// </summary>
        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        /// <summary>
        /// 商品促销折扣是否有效
        /// </summary>
        [Column("product_discount_effected")]
        public int product_discount_effected { get; set; }

        /// <summary>
        /// 分级折扣-分级优惠方式
        /// </summary>
        [Column("graded_discount_modeid")]
        public int graded_discount_modeid { get; set; }

        /// <summary>
        /// 分级折扣-分级排序方式
        /// </summary>
        [Column("graded_disoucnt_sortmodeid")]
        public int graded_disoucnt_sortmodeid { get; set; }

        /// <summary>
        /// 可参加次数
        /// </summary>
        [Column("max_participation_count")]
        public int max_participation_count { get; set; }

        /// <summary>
        /// 商品退货时是否组合退
        /// </summary>
        [Column("bundle_return_enabled")]
        public int bundle_return_enabled { get; set; }

        /// <summary>
        /// 优惠券限定(分类)
        /// </summary>
        [Column("coupon_limit_type_id")]
        public int coupon_limit_type_id { get; set; }

        /// <summary>
        /// 支持优惠券 "先抵后折"
        /// </summary>
        [Column("first_coupon_enabled")]
        public int first_coupon_enabled { get; set; }

        /// <summary>
        /// 是否参与佣金计算
        /// </summary>
        [Column("commission_calculate_enabled")]
        public int commission_calculate_enabled { get; set; }

        /// <summary>
        /// 是否参与特定目标计算
        /// </summary>
        [Column("spe_target_calculate_enabled")]
        public int spe_target_calculate_enabled { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 秒杀活动(开关)
        /// </summary>
        [Column("seckill_enabled")]
        public int seckill_enabled { get; set; }

        /// <summary>
        /// 适用场景(1线上2线下)
        /// </summary>
        [Column("applicable_scenario")]
        public int applicable_scenario { get; set; } = 1;

        /// <summary>
        /// 删除标记
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 活动场景
        /// </summary>
        [Column("activity_scene")]
        public int activity_scene { get; set; }

        /// <summary>
        /// 分级促销方式（字典：MC_GradedPromotionMode）
        /// </summary>
        [Column("graded_promotion_mode")]
        public int graded_promotion_mode { get; set; }

        /// <summary>
        /// 不同商品组捆绑规则细分（1.按活动捆绑数量捆绑、2.按商品组购买数量捆绑）
        /// </summary>
        [Column("different_pgroup_bundling_rule")]
        public int different_pgroup_bundling_rule { get; set; }

        /// <summary>
        /// 活动捆绑金额
        /// </summary>
        [Column("act_bundling_amount")]
        public decimal act_bundling_amount { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [Column("act_description")]
        public string act_description { get; set; } = string.Empty;

        /// <summary>
        /// 是否参与业绩金额计算
        /// </summary>
        [Column("performance_amount_enabled")]
        public int performance_amount_enabled { get; set; }

        /// <summary>
        /// 品牌会员类型(字典：BAS_MbBrandType)
        /// </summary>
        [Column("mb_brand_type")]
        public int mb_brand_type { get; set; }

        /// <summary>
        /// 品牌促销码
        /// </summary>
        [Column("brand_promo_code")]
        public string brand_promo_code { get; set; } = string.Empty;

        /// <summary>
        /// 达成金额类型(字典：MC_AchievedAmountType)
        /// </summary>
        [Column("achieved_amount_type")]
        public int achieved_amount_type { get; set; }

        /// <summary>
        /// 推送次数
        /// </summary>
        [Column("push_times")]
        public int push_times { get; set; }

        /// <summary>
        /// 商品组计算折扣规则(1.所有商品组统一分级优惠;2.不同商品组可设置不同分级优惠)
        /// </summary>
        [Column("pgroup_discount_rule")]
        public int pgroup_discount_rule { get; set; }

        /// <summary>
        /// 第三方推送状态
        /// </summary>
        [Column("push_third_flag")]
        public int push_third_flag { get; set; }

        /// <summary>
        /// 第三方推送时间
        /// </summary>
        [Column("push_third_time")]
        public DateTime push_third_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 券类型 0=代金券,1=商场券
        /// </summary>
        [Column("coupon_type_id")]
        public int coupon_type_id { get; set; }

        /// <summary>
        /// 商场业绩折扣
        /// </summary>
        [Column("mall_performance_discount")]
        public decimal mall_performance_discount { get; set; }

        /// <summary>
        /// 未添加换购商品弹窗提示
        /// </summary>
        [Column("popup_enabled")]
        public int popup_enabled { get; set; }

        /// <summary>
        /// 折扣券限定(分类) 字典：MC_CouponLimitType
        /// </summary>
        [Column("discount_limit_type_id")]
        public int discount_limit_type_id { get; set; }

        /// <summary>
        /// 是否已使用通知功能
        /// </summary>
        [Column("is_notify_record")]
        public int is_notify_record { get; set; }
    }

}




