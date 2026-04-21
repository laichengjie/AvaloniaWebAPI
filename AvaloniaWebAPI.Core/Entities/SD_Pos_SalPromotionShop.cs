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
    [Table("SD_Pos_SalPromotionShop")]

    public class SD_Pos_SalPromotionShop
    {
        [Key]
        [MaxLength(10)]
        public string CompanyID { get; set; } = string.Empty;

        [Key]
        [MaxLength(20)]
        public string PromotionID { get; set; } = string.Empty;

        [Key]
        [MaxLength(20)]
        public string ShopID { get; set; } = string.Empty;

        public decimal? DisCount { get; set; }

        public bool? ShopVip { get; set; }

        public bool? OwnerVip { get; set; }

        public bool? MarkBalance { get; set; }

        public decimal? PromExpenceApportionRate { get; set; }

        public string? PromExpenceApportionFormulaEN { get; set; }

        public string? PromExpenceApportionFormulaCN { get; set; }

        // 导航属性
        [JsonIgnore]
        public virtual SD_Pos_SalPromotion? Promotion { get; set; }

    }
}