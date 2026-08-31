using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 整单促销活动
    /// </summary>
    [Table("mc_whole_act")]
    public class mc_whole_act
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("ou_id")]
        public int ou_id { get; set; }

        [Column("activity_type_id")]
        public int activity_type_id { get; set; }

        [Column("activity_grade_id")]
        public int activity_grade_id { get; set; }

        [Column("bill_code")]
        public string bill_code { get; set; } = string.Empty;

        [Column("activity_name")]
        public string activity_name { get; set; } = string.Empty;

        [Column("effective_start")]
        public DateTime effective_start { get; set; } = DateTime.Now;

        [Column("effective_end")]
        public DateTime effective_end { get; set; } = new DateTime(3000, 12, 31);

        [Column("time_range_enabled")]
        public int time_range_enabled { get; set; }

        [Column("time_range_start")]
        public DateTime time_range_start { get; set; } = new DateTime(1900, 1, 1);

        [Column("time_range_end")]
        public DateTime time_range_end { get; set; } = new DateTime(1900, 1, 1);

        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }

        [Column("per_max_times")]
        public int per_max_times { get; set; }

        [Column("apply_crowd_id")]
        public int apply_crowd_id { get; set; }

        [Column("overlay_bundle_promotion")]
        public int overlay_bundle_promotion { get; set; }

        [Column("repeat_enabled")]
        public int repeat_enabled { get; set; } = 1;

        [Column("promotion_mode_id")]
        public int promotion_mode_id { get; set; }

        [Column("accum_preferential_enabled")]
        public int accum_preferential_enabled { get; set; }

        [Column("max_preferential_amount")]
        public decimal max_preferential_amount { get; set; }

        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        [Column("preferential_mode_id")]
        public int preferential_mode_id { get; set; }

        [Column("exch_apply_product_modelid")]
        public int exch_apply_product_modelid { get; set; }

        [Column("is_config_pgroup")]
        public int is_config_pgroup { get; set; }

        [Column("max_participation_count")]
        public int max_participation_count { get; set; }

        [Column("whole_return_enabled")]
        public int whole_return_enabled { get; set; }

        [Column("exch_type_id")]
        public int exch_type_id { get; set; }

        [Column("coupon_limit_type_id")]
        public int coupon_limit_type_id { get; set; }

        [Column("first_coupon_enabled")]
        public int first_coupon_enabled { get; set; }

        [Column("commission_calculate_enabled")]
        public int commission_calculate_enabled { get; set; }

        [Column("spe_target_calculate_enabled")]
        public int spe_target_calculate_enabled { get; set; }

        [Column("status")]
        public int status { get; set; }

        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("activity_scene")]
        public int activity_scene { get; set; }

        [Column("exch_rule_id")]
        public int exch_rule_id { get; set; }

        [Column("exch_rule_value")]
        public decimal exch_rule_value { get; set; }

        [Column("creater_id")]
        public int creater_id { get; set; }

        [Column("company_preference_enabled")]
        public int company_preference_enabled { get; set; }

        [Column("is_redemption_promotion")]
        public int is_redemption_promotion { get; set; }

        [Column("performance_amount_enabled")]
        public int performance_amount_enabled { get; set; }

        [Column("mb_brand_type")]
        public int mb_brand_type { get; set; }

        [Column("brand_promo_code")]
        public string brand_promo_code { get; set; } = string.Empty;

        [Column("push_times")]
        public int push_times { get; set; }

        [Column("push_third_flag")]
        public int push_third_flag { get; set; }

        [Column("push_third_time")]
        public DateTime push_third_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("act_description")]
        public string act_description { get; set; } = string.Empty;

        [Column("gift_coupon_type")]
        public int gift_coupon_type { get; set; }

        [Column("coupon_type_id")]
        public int coupon_type_id { get; set; }

        [Column("mall_performance_discount")]
        public decimal mall_performance_discount { get; set; }

        [Column("achievement_method")]
        public int achievement_method { get; set; }

        [Column("discount_limit_type_id")]
        public int discount_limit_type_id { get; set; }

        [Column("busine_activity_type")]
        public int busine_activity_type { get; set; }

        [Column("is_notify_record")]
        public int is_notify_record { get; set; }
    }
}