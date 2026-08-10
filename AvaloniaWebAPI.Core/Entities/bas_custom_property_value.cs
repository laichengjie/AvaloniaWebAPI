using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_custom_property_value")]
    public class bas_custom_property_value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("counter_custom_id")]
        public int counter_custom_id { get; set; }

        [Column("property_value_code")]
        public string? property_value_code { get; set; }

        [Column("property_value_name")]
        public string? property_value_name { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}