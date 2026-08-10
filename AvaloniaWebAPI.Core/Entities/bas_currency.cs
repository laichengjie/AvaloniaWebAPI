using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_currency")]
    public class bas_currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("currency_code")]
        public string currency_code { get; set; } = string.Empty;

        [Column("currency_name")]
        public string currency_name { get; set; } = string.Empty;

        [Column("increment")]
        public decimal increment { get; set; }

        [Column("symbol")]
        public string symbol { get; set; } = string.Empty;

        [Column("seq")]
        public int seq { get; set; }

        [Column("status")]
        public int status { get; set; } = 1;

        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        [Column("created_by")]
        public string created_by { get; set; } = "system";

        [Column("created_time")]
        public DateTime created_time { get; set; } = DateTime.Now;

        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        [Column("is_deleted")]
        public int is_deleted { get; set; }

        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        [Column("deleted_time")]
        public DateTime? deleted_time { get; set; }
    }
}