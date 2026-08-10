using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("bas_class")]
    public class bas_class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("group_id")]
        public int group_id { get; set; }

        [Column("ou_id")]
        public int ou_id { get; set; }

        [Column("shop_id")]
        public int shop_id { get; set; }

        [Column("project_id")]
        public int project_id { get; set; }

        [Column("project_code")]
        public string project_code { get; set; } = string.Empty;

        [Column("project_name")]
        public string project_name { get; set; } = string.Empty;

        [Column("class_code")]
        public string class_code { get; set; } = string.Empty;

        [Column("class_name")]
        public string class_name { get; set; } = string.Empty;

        [Column("start_time")]
        public DateTime start_time { get; set; } = DateTime.Now;

        [Column("end_time")]
        public DateTime end_time { get; set; } = DateTime.Now;

        [Column("status")]
        public int status { get; set; }

        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }

}





