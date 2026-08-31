using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 通用活动
    /// </summary>
    [Table("mc_general_act")]
    public class mc_general_act
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

        [Column("activity_code")]
        public string activity_code { get; set; } = string.Empty;

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

        [Column("commission_calculate_enabled")]
        public int commission_calculate_enabled { get; set; }

        [Column("spe_target_calculate_enabled")]
        public int spe_target_calculate_enabled { get; set; }

        [Column("performance_amount_enabled")]
        public int performance_amount_enabled { get; set; }

        [Column("repeat_enabled")]
        public int repeat_enabled { get; set; } = 1;

        [Column("apply_crowd_id")]
        public int apply_crowd_id { get; set; }

        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }

        [Column("per_max_times")]
        public int per_max_times { get; set; }

        [Column("activity_grade_id")]
        public int activity_grade_id { get; set; }

        [Column("act_description")]
        public string act_description { get; set; } = string.Empty;

        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        [Column("checker")]
        public string checker { get; set; } = string.Empty;

        [Column("check_time")]
        public DateTime check_time { get; set; } = DateTime.Now;

        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("activity_scene")]
        public int activity_scene { get; set; }

        [Column("exch_price_enabled")]
        public int exch_price_enabled { get; set; }

        [Column("coupon_type_id")]
        public int coupon_type_id { get; set; }

        [Column("mall_performance_discount")]
        public decimal mall_performance_discount { get; set; }

        [Column("is_notify_record")]
        public int is_notify_record { get; set; }
    }
}