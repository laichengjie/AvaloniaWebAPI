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
    [Table("SD_Pos_SalPromotionVip")]
    public class SD_Pos_SalPromotionVip
    {
        [Key]
        [MaxLength(10)]
        public string CompanyID { get; set; } = string.Empty;

        [Key]
        [MaxLength(20)]
        public string PromotionID { get; set; } = string.Empty;

        [Key]
        [MaxLength(20)]
        public string CardTypeID { get; set; } = string.Empty;

        public decimal? AmtRatio { get; set; }

        public decimal? AmtDiscount { get; set; }

        public string? ConditionCN { get; set; }

        public string? ConditionEN { get; set; }

        public string? ConditionENList { get; set; }

        // 导航属性
        [JsonIgnore]
        public virtual SD_Pos_SalPromotion? Promotion { get; set; }
    }
}
