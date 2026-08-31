using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 通用活动-换购规则
    /// </summary>
    [Table("mc_general_act_exch")]
    public class mc_general_act_exch
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

        [Column("exch_threshold")]
        public decimal exch_threshold { get; set; }

        [Column("circular_rule")]
        public int circular_rule { get; set; }

        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        [Column("exch_max_qty")]
        public int exch_max_qty { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);
    }
}