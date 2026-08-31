using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 整单促销活动-按周期重复
    /// </summary>
    [Table("mc_whole_act_repeat")]
    public class mc_whole_act_repeat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("per_year")]
        public int per_year { get; set; } = 1;

        [Column("select_year")]
        public string select_year { get; set; } = string.Empty;

        [Column("per_month")]
        public int per_month { get; set; } = 1;

        [Column("select_month")]
        public string select_month { get; set; } = " ";

        [Column("per_week")]
        public int per_week { get; set; }

        [Column("select_week")]
        public string select_week { get; set; } = string.Empty;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;
    }
}