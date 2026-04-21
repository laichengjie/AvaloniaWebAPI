using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaWebAPI.Core.Entities
{
    [Table("SD_Pos_SalPromotion")]
    public class SD_Pos_SalPromotion
    {
        [Key]
        public string CompanyID { get; set; } = string.Empty; 

        [Key]
        public string PromotionID { get; set; } = string.Empty;

        public string? PromotionCode { get; set; }

        public string? PromotionName { get; set; }

        public int? Game { get; set; }

        public string? GameName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int BillStatus { get; set; }

        public string? Remark { get; set; }

        public bool? IsVip { get; set; }

        public bool? IsTHQ { get; set; }

        public string? Operator { get; set; }

        public string? Checker { get; set; }

        public DateTime? CheckDate { get; set; }

        public bool AllowUsed { get; set; }

        public DateTime ModifyDTM { get; set; }

        public string? UnChecker { get; set; }

        public DateTime? UnCheckDate { get; set; }

        public string? NowPriceGroupID { get; set; }

        public string? NowPriceGroupRangeID { get; set; }

        public DateTime? NowPriceStartDate { get; set; }

        public DateTime? NowPriceEndDate { get; set; }

        public bool IsMaterialCon { get; set; }

        public decimal? Par1 { get; set; }

        public decimal? Par2 { get; set; }

        public decimal? Par3 { get; set; }

        public decimal? Par4 { get; set; }

        public decimal? Par5 { get; set; }

        public string? OpAreaID { get; set; }

        public string? BillTypeID { get; set; }

        public DateTime? BillDate { get; set; }

        public string? Signature { get; set; }

        public bool? IsLimit { get; set; }

        public int? BasePriceMode { get; set; }

        public string? LimitPeriod { get; set; }

        public string? VipBirthdayPromPeriod { get; set; }

        public bool? IsVipBirthdayProm { get; set; }

        public int? VipBirthdayNums { get; set; }

        public int? TimeLimitType { get; set; }

        public int? SpecialDate { get; set; }

        public string? SpecialDateList { get; set; }

        public string? PresendTHQID { get; set; }

        public bool? IsJoinDouble { get; set; }

        public bool? OwnerVIP { get; set; }

        public int? SaleLimitQty { get; set; }

        public bool? IsCalcVIPIntegral { get; set; }

        public decimal? Discount { get; set; }

        public bool? IsVipBabyBirthdayProm { get; set; }

        public int? THQRand { get; set; }

        public string? DiscountNPGroupID { get; set; }

        public string? DiscountNPGroupRangID { get; set; }

        public bool? IsLessDiscount { get; set; }

        public bool? IsAttend { get; set; }

        public bool? IsNotPartakeShop { get; set; }

        public bool? IsSpeTarget { get; set; }

        public bool? IsCreateCouponNo { get; set; }

        public bool? IsNotCalcGold { get; set; }

        public bool? IsOnline { get; set; }

        public string? ApplicableType { get; set; }

        public string? BrandPlatform { get; set; }

        public string? BrandPromotionCode { get; set; }

        public int? UpLoadERP2State { get; set; }

        public decimal? MarkDiscount { get; set; }
    }
}