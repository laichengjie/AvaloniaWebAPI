using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_brand")]
    public class bas_brand 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int group_id { get; set; }

        public string brand_code { get; set; } = string.Empty;

        public string brand_name { get; set; } = string.Empty;

        [Column("brand_ename")]
        public string brand_english_name { get; set; } = string.Empty;

        public int status { get; set; } = 1;

        public string? remark { get; set; }

        public string created_by { get; set; } = "system";

        public DateTime created_time { get; set; } = DateTime.Now;

        public string modified_by { get; set; } = "system";

        public DateTime modified_time { get; set; } = DateTime.Now;

        public int is_deleted { get; set; } = 0;

        public string? deleted_by { get; set; }

        public DateTime? deleted_time { get; set; }

        public int mb_brand_type { get; set; } = 0;
    }

}




