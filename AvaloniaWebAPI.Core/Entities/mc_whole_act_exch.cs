using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 整单促销活动-换购促销
    /// </summary>
    [Table("mc_whole_act_exch")]
    public class mc_whole_act_exch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("exch_rule_id")]
        public int exch_rule_id { get; set; }

        [Column("exch_rule_value")]
        public decimal exch_rule_value { get; set; }

        [Column("exch_qty")]
        public int exch_qty { get; set; }

        [Column("exch_max_qty")]
        public int exch_max_qty { get; set; }

        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        [Column("exch_type_id")]
        public int exch_type_id { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);
    }
}