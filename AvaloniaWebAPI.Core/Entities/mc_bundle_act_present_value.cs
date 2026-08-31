using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-现值设置
    /// </summary>
    [Table("mc_bundle_act_present_value")]
    public class mc_bundle_act_present_value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("present_value_set_id")]
        public int present_value_set_id { get; set; }

        [Column("present_value_set_dtl_id")]
        public int present_value_set_dtl_id { get; set; }

        [Column("start_value")]
        public decimal start_value { get; set; }

        [Column("end_value")]
        public decimal end_value { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("is_present_value_act")]
        public int is_present_value_act { get; set; }
    }
}