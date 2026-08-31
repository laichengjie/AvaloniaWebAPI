using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 通用活动-换购规则-商品组
    /// </summary>
    [Table("mc_general_act_exch_pgroup")]
    public class mc_general_act_exch_pgroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("pgroup_seq")]
        public int pgroup_seq { get; set; }

        [Column("extra_amount")]
        public decimal extra_amount { get; set; }

        [Column("exch_qty")]
        public int exch_qty { get; set; }

        [Column("exch_discount")]
        public decimal? exch_discount { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("exch_amount")]
        public decimal? exch_amount { get; set; }
    }
}