using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("SD_Pos_SalPromotionMaterial")]
    public class SD_Pos_SalPromotionMaterial
    {
        [Key]

        public string CompanyID { get; set; } = string.Empty;

        [Key]

        public string PromotionID { get; set; } = string.Empty;

        [Key]

        public string Sequence { get; set; } = string.Empty;


        public string? MaterialID { get; set; }

        public int? TypeCode { get; set; }

        public decimal? Par1 { get; set; }
        public decimal? Par2 { get; set; }
        public decimal? Par3 { get; set; }
        public decimal? Par4 { get; set; }
        public decimal? Par5 { get; set; }
        public decimal? Par6 { get; set; }
        public decimal? Par7 { get; set; }
        public decimal? Par8 { get; set; }
        public decimal? Par9 { get; set; }
        public decimal? Par10 { get; set; }

        public string? MaterialConENG { get; set; }

        public string? MaterialConCHN { get; set; }

        public decimal? RetailPrice { get; set; }

        [JsonIgnore]
        public virtual SD_Pos_SalPromotion? Promotion { get; set; }

    }
}
