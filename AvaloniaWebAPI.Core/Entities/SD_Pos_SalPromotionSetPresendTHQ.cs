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
    [Table("SD_Pos_SalPromotionSetPresendTHQ")]
    public class SD_Pos_SalPromotionSetPresendTHQ
    {
        [Key]

        public string CompanyID { get; set; } = string.Empty;

        [Key]

        public string PromotionID { get; set; } = string.Empty;

        [Key]

        public string THQID { get; set; } = string.Empty;

        [Key]
 
        public string THQType { get; set; } = string.Empty;

        public decimal? Qty { get; set; }

        // 导航属性
        [JsonIgnore]
        public virtual SD_Pos_SalPromotion? Promotion { get; set; }
    }
}
