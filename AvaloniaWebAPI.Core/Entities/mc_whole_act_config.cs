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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("seq")]
        public int seq { get; set; }

        [Column("whole_amount")]
        public decimal whole_amount { get; set; }

        [Column("discount")]
        public decimal discount { get; set; }

        [Column("preferential_amount")]
        public decimal preferential_amount { get; set; }

        [Column("exch_qty")]
        public int exch_qty { get; set; }

        [Column("coupon_id")]
        public int coupon_id { get; set; }

        [Column("coupon_qty")]
        public int coupon_qty { get; set; }

        [Column("company_pref_amount")]
        public decimal company_pref_amount { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);
    }
}