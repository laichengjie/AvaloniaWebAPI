using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-分级促销
    /// </summary>
    [Table("mc_bundle_act_graded_promo")]
    public class mc_bundle_act_graded_promo
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

        [Column("buy_qty")]
        public int buy_qty { get; set; }

        [Column("promotion_price")]
        public decimal promotion_price { get; set; }

        [Column("reduced_price")]
        public decimal reduced_price { get; set; }

        [Column("discount")]
        public decimal discount { get; set; }

        [Column("reduced_amount")]
        public decimal reduced_amount { get; set; }

        [Column("combination_amount")]
        public decimal combination_amount { get; set; }

        [Column("exch_qty")]
        public int exch_qty { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("buy_seq")]
        public int buy_seq { get; set; }

        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }
    }
}