using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 联赠促销活动
    /// </summary>
    [Table("mc_joint_gift_act")]
    public class mc_joint_gift_act
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

        [Column("apply_crowd_id")]
        public int apply_crowd_id { get; set; }

        [Column("repeat_enabled")]
        public int repeat_enabled { get; set; } = 1;

        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        [Column("max_participation_count")]
        public int max_participation_count { get; set; }

        [Column("coupon_limit_type_id")]
        public int coupon_limit_type_id { get; set; }

        [Column("commission_calculate_enabled")]
        public int commission_calculate_enabled { get; set; }

        [Column("spe_target_calculate_enabled")]
        public int spe_target_calculate_enabled { get; set; }

        [Column("status")]
        public int status { get; set; }

        [Column("checker")]
        public string checker { get; set; } = string.Empty;

        [Column("check_time")]
        public DateTime check_time { get; set; } = DateTime.Now;

        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        [Column("created_by")]
        public string created_by { get; set; } = "system";

        [Column("created_time")]
        public DateTime created_time { get; set; } = DateTime.Now;

        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("push_times")]
        public int push_times { get; set; }

        [Column("coupon_type_id")]
        public int coupon_type_id { get; set; }
    }
}