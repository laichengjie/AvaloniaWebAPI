using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_custom_product")]
    public class bas_custom_product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("counter_custom_id")]
        public int counter_custom_id { get; set; }

        [Column("product_id")]
        public int product_id { get; set; }

        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}