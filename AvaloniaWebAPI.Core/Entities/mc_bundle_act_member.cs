using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-会员设置
    /// </summary>
    [Table("mc_bundle_act_member")]
    public class mc_bundle_act_member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("integral_calculation_enabled")]
        public int integral_calculation_enabled { get; set; }

        [Column("integral_deduction_enabled")]
        public int integral_deduction_enabled { get; set; }

        [Column("double_discount_enabled")]
        public int double_discount_enabled { get; set; }

        [Column("double_discount_mode_id")]
        public int double_discount_mode_id { get; set; }

        [Column("period_mode_id")]
        public int period_mode_id { get; set; }

        [Column("limit_times")]
        public int limit_times { get; set; }

        [Column("limit_qty")]
        public int limit_qty { get; set; }

        [Column("birthday_mode_id")]
        public int birthday_mode_id { get; set; }

        [Column("member_grade_enabled")]
        public int member_grade_enabled { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("double_discount_joint_card")]
        public int double_discount_joint_card { get; set; }
    }
}