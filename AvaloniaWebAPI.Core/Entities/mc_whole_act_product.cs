using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 整单促销活动-参与商品
    /// </summary>
    [Table("mc_whole_act_product")]
    public class mc_whole_act_product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("activity_id")]
        public int activity_id { get; set; }

        [Column("pgroup_id")]
        public int pgroup_id { get; set; }

        [Column("product_id")]
        public int product_id { get; set; }

        [Column("sku_id")]
        public int sku_id { get; set; }

        [Column("filter_description")]
        public string? filter_description { get; set; }

        [Column("filter_json")]
        public string filter_json { get; set; } = string.Empty;

        [Column("filter_sql")]
        public string filter_sql { get; set; } = string.Empty;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime deleted_time { get; set; } = new DateTime(3000, 12, 31);

        [Column("performance_factor")]
        public decimal performance_factor { get; set; }

        [Column("skc_id")]
        public string skc_id { get; set; } = string.Empty;

        [Column("skc_code")]
        public string skc_code { get; set; } = string.Empty;

        [Column("skc_name")]
        public string skc_name { get; set; } = string.Empty;

        [Column("spec_value_id")]
        public int spec_value_id { get; set; }

        [Column("spec_value_name")]
        public string spec_value_name { get; set; } = string.Empty;
    }
}