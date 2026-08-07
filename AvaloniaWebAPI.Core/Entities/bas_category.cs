using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_category")]
    public class bas_category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("category_code")]
        public string category_code { get; set; } = string.Empty;

        [Column("category_name")]
        public string category_name { get; set; } = string.Empty;

        [Column("category_fullpath_id")]
        public string category_fullpath_id { get; set; } = string.Empty;

        [Column("category_fullpath_name")]
        public string category_fullpath_name { get; set; } = string.Empty;

        [Column("is_service")]
        public int is_service { get; set; }

        [Column("seq")]
        public int seq { get; set; } = 1;

        [Column("status")]
        public int status { get; set; }

        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        [Column("english_name")]
        public string english_name { get; set; } = string.Empty;
    }

}




