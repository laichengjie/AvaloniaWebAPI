using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-商品分组
    /// </summary>
    [Table("mc_bundle_act_pgroup")]
    public class mc_bundle_act_pgroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("pgroup_name")]
        public string pgroup_name { get; set; } = string.Empty;

        [Column("combination_amount")]
        public decimal combination_amount { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("qty")]
        public decimal qty { get; set; }

        [Column("graded_promo_enabled")]
        public int graded_promo_enabled { get; set; }
    }
}