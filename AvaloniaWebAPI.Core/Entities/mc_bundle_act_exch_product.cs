using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 捆绑促销活动-换购促销-换购商品
    /// </summary>
    [Table("mc_bundle_act_exch_product")]
    public class mc_bundle_act_exch_product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("product_id")]
        public int product_id { get; set; }

        [Column("sku_id")]
        public int sku_id { get; set; }

        [Column("filter_json")]
        public string filter_json { get; set; } = string.Empty;

        [Column("filter_sql")]
        public string filter_sql { get; set; } = string.Empty;

        [Column("filter_description")]
        public string filter_description { get; set; } = string.Empty;

        [Column("discount")]
        public decimal discount { get; set; }

        [Column("extra_amount")]
        public decimal extra_amount { get; set; }

        [Column("company_bears_payment")]
        public int company_bears_payment { get; set; }

        [Column("active_inv_qty")]
        public decimal active_inv_qty { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("performance_factor")]
        public decimal performance_factor { get; set; }
    }
}