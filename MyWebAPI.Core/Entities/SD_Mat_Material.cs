using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPI.Core.Entities
{

    //public class Material
    //{
    //    [Key]
    //    [Column("MaterialID")]
    //    [MaxLength(40)]
    //    public string MaterialID { get; set; } = string.Empty;

    //    [Column("VendorMaterialCode")]
    //    [MaxLength(20)]
    //    public string? VendorMaterialCode { get; set; }

    //    [Column("MaterialCode")]
    //    [MaxLength(40)]
    //    [Required]
    //    public string MaterialCode { get; set; } = string.Empty;

    //    [Column("BarCode")]
    //    [MaxLength(40)]
    //    public string? BarCode { get; set; }

    //    [Column("MaterialName")]
    //    [MaxLength(200)]
    //    public string? MaterialName { get; set; }

    //    [Column("MaterialShortName")]
    //    [MaxLength(120)]
    //    public string? MaterialShortName { get; set; }

    //    [Column("ForeignName")]
    //    public string? ForeignName { get; set; }

    //    [Column("MatTypeID")]
    //    [MaxLength(20)]
    //    public string? MatTypeID { get; set; }

    //    [Column("CardID")]
    //    [MaxLength(20)]
    //    public string? CardID { get; set; }

    //    [Column("KindID")]
    //    [MaxLength(20)]
    //    public string? KindID { get; set; }

    //    [Column("SeriesID")]
    //    [MaxLength(20)]
    //    public string? SeriesID { get; set; }

    //    [Column("ModelID")]
    //    [MaxLength(20)]
    //    public string? ModelID { get; set; }

    //    [Column("ItemID")]
    //    [MaxLength(20)]
    //    public string? ItemID { get; set; }

    //    [Column("AccreditID")]
    //    [MaxLength(20)]
    //    public string? AccreditID { get; set; }

    //    [Column("StuffID")]
    //    [MaxLength(20)]
    //    public string? StuffID { get; set; }

    //    [Column("ColorID")]
    //    [MaxLength(20)]
    //    public string? ColorID { get; set; }

    //    [Column("ColorName2")]
    //    [MaxLength(60)]
    //    public string? ColorName2 { get; set; }

    //    [Column("SexID")]
    //    [MaxLength(20)]
    //    public string? SexID { get; set; }

    //    [Column("UnitID")]
    //    [MaxLength(20)]
    //    public string? UnitID { get; set; }

    //    [Column("SizeTypeID")]
    //    [MaxLength(20)]
    //    public string? SizeTypeID { get; set; }

    //    [Column("YearNo")]
    //    public int? YearNo { get; set; }

    //    [Column("SeasonID")]
    //    [MaxLength(20)]
    //    public string? SeasonID { get; set; }

    //    [Column("NewOld")]
    //    public int? NewOld { get; set; }

    //    [Column("PictureCode")]
    //    [MaxLength(40)]
    //    public string? PictureCode { get; set; }

    //    [Column("InvSpec")]
    //    [MaxLength(60)]
    //    public string? InvSpec { get; set; }

    //    [Column("StyleCode")]
    //    [MaxLength(40)]
    //    public string? StyleCode { get; set; }

    //    [Column("Season1")]
    //    public bool? Season1 { get; set; }

    //    [Column("Season2")]
    //    public bool? Season2 { get; set; }

    //    [Column("Season3")]
    //    public bool? Season3 { get; set; }

    //    [Column("Season4")]
    //    public bool? Season4 { get; set; }

    //    [Column("Season5")]
    //    public bool? Season5 { get; set; }

    //    [Column("ProRetailPrice")]
    //    public decimal? ProRetailPrice { get; set; }

    //    [Column("ProSaleDate")]
    //    public DateTime? ProSaleDate { get; set; }

    //    [Column("SubSeries")]
    //    [MaxLength(60)]
    //    public string? SubSeries { get; set; }

    //    [Column("SubModel")]
    //    [MaxLength(60)]
    //    public string? SubModel { get; set; }

    //    [Column("SubItem")]
    //    [MaxLength(60)]
    //    public string? SubItem { get; set; }

    //    [Column("MasterItem")]
    //    public string? MasterItem { get; set; }

    //    [Column("MaterialProperty")]
    //    [MaxLength(60)]
    //    public string? MaterialProperty { get; set; }

    //    [Column("Channel")]
    //    [MaxLength(60)]
    //    public string? Channel { get; set; }

    //    [Column("MatStyle")]
    //    public int? MatStyle { get; set; }

    //    [Column("SendCheckNo")]
    //    [MaxLength(60)]
    //    public string? SendCheckNo { get; set; }

    //    [Column("CreateCompanyID")]
    //    public string? CreateCompanyID { get; set; }

    //    [Column("Remark")]
    //    [MaxLength(250)]
    //    public string? Remark { get; set; }

    //    [Column("ProAllowUsed")]
    //    [Required]
    //    public bool? ProAllowUsed { get; set; }

    //    [Column("CheckDate")]
    //    public DateTime? CheckDate { get; set; }

    //    [Column("Checker")]
    //    public string? Checker { get; set; }

    //    [Column("CheckState")]
    //    [Required]
    //    public bool CheckState { get; set; }

    //    [Column("LockState")]
    //    public int? LockState { get; set; }

    //    [Column("SyncState")]
    //    public int? SyncState { get; set; }

    //    [Column("ModifyDTM")]
    //    [Required]
    //    public DateTime ModifyDTM { get; set; }

    //    [Column("Texture")]
    //    [MaxLength(1000)]
    //    public string? Texture { get; set; }

    //    [Column("StyleID")]
    //    public string? StyleID { get; set; }

    //    [Column("CommodityLevelID")]
    //    public string? CommodityLevelID { get; set; }

    //    [Column("CommodityProfileID")]
    //    public string? CommodityProfileID { get; set; }

    //    [Column("FactoryNo")]
    //    public string? FactoryNo { get; set; }

    //    [Column("DesignNo")]
    //    [MaxLength(40)]
    //    public string? DesignNo { get; set; }

    //    [Column("CountryBarCode")]
    //    [MaxLength(40)]
    //    public string? CountryBarCode { get; set; }

    //    [Column("SizeSection")]
    //    [MaxLength(40)]
    //    public string? SizeSection { get; set; }

    //    [Column("ShoeTreeNo")]
    //    [MaxLength(40)]
    //    public string? ShoeTreeNo { get; set; }

    //    [Column("LargeBase")]
    //    [MaxLength(40)]
    //    public string? LargeBase { get; set; }

    //    [Column("ClothesVersionID")]
    //    [MaxLength(20)]
    //    public string? ClothesVersionID { get; set; }

    //    [Column("Creator")]
    //    [MaxLength(20)]
    //    public string? Creator { get; set; }

    //    [Column("CreateDateTime")]
    //    public DateTime? CreateDateTime { get; set; }

    //    [Column("Lan")]
    //    [Required]
    //    public int Lan { get; set; }

    //    [Column("FactoryStyleNo")]
    //    [MaxLength(60)]
    //    public string? FactoryStyleNo { get; set; }

    //    [Column("Volume")]
    //    public decimal? Volume { get; set; }

    //    [Column("WeightNo")]
    //    public decimal? WeightNo { get; set; }

    //    [Column("BoxBoard")]
    //    public decimal? BoxBoard { get; set; }

    //    [Column("Season6")]
    //    public bool? Season6 { get; set; }

    //    [Column("PreVolumeModels")]
    //    public int? PreVolumeModels { get; set; }

    //    [Column("ProNature")]
    //    public int? ProNature { get; set; }

    //    [Column("StuffName2")]
    //    [MaxLength(250)]
    //    public string? StuffName2 { get; set; }

    //    [Column("Lining")]
    //    [MaxLength(250)]
    //    public string? Lining { get; set; }

    //    [Column("Filling")]
    //    [MaxLength(250)]
    //    public string? Filling { get; set; }

    //    [Column("ExecStandard")]
    //    [MaxLength(100)]
    //    public string? ExecStandard { get; set; }

    //    [Column("SecurityKind")]
    //    [MaxLength(80)]
    //    public string? SecurityKind { get; set; }

    //    [Column("WashingMethod")]
    //    [MaxLength(60)]
    //    public string? WashingMethod { get; set; }

    //    [Column("DesignNoColor")]
    //    [MaxLength(80)]
    //    public string? DesignNoColor { get; set; }

    //    [Column("ExecStandardID")]
    //    public string? ExecStandardID { get; set; }

    //    [Column("WashingMethodID")]
    //    public string? WashingMethodID { get; set; }

    //    [Column("SecurityKindID")]
    //    public string? SecurityKindID { get; set; }

    //    [Column("IsCreateByStyle")]
    //    public bool? IsCreateByStyle { get; set; }

    //    [Column("BatchNO")]
    //    [MaxLength(40)]
    //    public string? BatchNO { get; set; }

    //    [Column("BandCode")]
    //    [MaxLength(40)]
    //    public string? BandCode { get; set; }

    //    [Column("ListingBatch")]
    //    [MaxLength(40)]
    //    public string? ListingBatch { get; set; }

    //    [Column("GroupFitName")]
    //    [MaxLength(40)]
    //    public string? GroupFitName { get; set; }

    //    [Column("OrnamentName")]
    //    [MaxLength(40)]
    //    public string? OrnamentName { get; set; }

    //    [Column("ProdStypleName")]
    //    [MaxLength(40)]
    //    public string? ProdStypleName { get; set; }

    //    [Column("SituationName")]
    //    [MaxLength(40)]
    //    public string? SituationName { get; set; }

    //    [Column("MatPriceName")]
    //    [MaxLength(40)]
    //    public string? MatPriceName { get; set; }

    //    [Column("FabricTypeName")]
    //    [MaxLength(40)]
    //    public string? FabricTypeName { get; set; }

    //    [Column("SourceMatName")]
    //    [MaxLength(40)]
    //    public string? SourceMatName { get; set; }

    //    //[Column("BasicBarCode")]
    //    //[MaxLength(40)]
    //    //public string? BasicBarCode { get; set; }

    //    //[Column("TailBarCode")]
    //    //[MaxLength(40)]
    //    //public string? TailBarCode { get; set; }

    //    //[Column("SerialNo")]
    //    //[MaxLength(40)]
    //    //public string? SerialNo { get; set; }

    //    [Column("MaterialType")]
    //    public int? MaterialType { get; set; }

    //    [Column("MaterialLink")]
    //    [MaxLength(1000)]
    //    public string? MaterialLink { get; set; }

    //    [Column("IsHorizontal")]
    //    [Required]
    //    public bool IsHorizontal { get; set; }

    //    [Column("VirtualMat")]
    //    public bool? VirtualMat { get; set; }

    //    [Column("CarVersion")]
    //    [MaxLength(250)]
    //    public string? CarVersion { get; set; }

    //    [Column("PressID")]
    //    [MaxLength(20)]
    //    public string? PressID { get; set; }

    //    [Column("IsCanotChk")]
    //    public bool? IsCanotChk { get; set; }

    //    [Column("IsOtherSystem")]
    //    public int? IsOtherSystem { get; set; }

    //    [Column("UsedBatch")]
    //    public bool? UsedBatch { get; set; }

    //    [Column("UsedValidity")]
    //    public bool? UsedValidity { get; set; }

    //    [Column("ShelfLife")]
    //    public int? ShelfLife { get; set; }

    //    [Column("MinPackingQty")]
    //    [MaxLength(500)]
    //    public string? MinPackingQty { get; set; }

    //    [Column("PackageName")]
    //    [MaxLength(500)]
    //    public string? PackageName { get; set; }

    //    [Column("MainMaterial")]
    //    [MaxLength(1000)]
    //    public string? MainMaterial { get; set; }

    //    [Column("NetContent")]
    //    [MaxLength(500)]
    //    public string? NetContent { get; set; }

    //    [Column("IngredientsContent")]
    //    [MaxLength(1000)]
    //    public string? IngredientsContent { get; set; }

    //    [Column("InPackageSize")]
    //    [MaxLength(500)]
    //    public string? InPackageSize { get; set; }

    //    [Column("VIPPrice")]
    //    public decimal? VIPPrice { get; set; }

    //    [Column("StyleName")]
    //    [MaxLength(40)]
    //    public string? StyleName { get; set; }

    //    [Column("SoleMaterials")]
    //    [MaxLength(100)]
    //    public string? SoleMaterials { get; set; }

    //    [Column("FootInsoles")]
    //    [MaxLength(100)]
    //    public string? FootInsoles { get; set; }

    //    [Column("ShoesFunction")]
    //    [MaxLength(100)]
    //    public string? ShoesFunction { get; set; }

    //    [Column("ProductionPlace")]
    //    [MaxLength(100)]
    //    public string? ProductionPlace { get; set; }

    //    [Column("InnerBox")]
    //    [MaxLength(100)]
    //    public string? InnerBox { get; set; }

    //    [Column("InsideBox")]
    //    [MaxLength(100)]
    //    public string? InsideBox { get; set; }

    //    [Column("SubTypeID")]
    //    [MaxLength(20)]
    //    public string? SubTypeID { get; set; }

    //    [Column("ProductionDate")]
    //    public DateTime? ProductionDate { get; set; }

    //    [Column("ProductFeature")]
    //    [MaxLength(1000)]
    //    public string? ProductFeature { get; set; }

    //    [Column("IsBuyout")]
    //    public bool? IsBuyout { get; set; }

    //    [Column("IsProp")]
    //    public bool? IsProp { get; set; }

    //    [Column("SizeSpec")]
    //    [MaxLength(80)]
    //    public string? SizeSpec { get; set; }

    //    [Column("CommonDataType")]
    //    [MaxLength(80)]
    //    public string? CommonDataType { get; set; }

    //    [Column("CommonDataContent")]
    //    [MaxLength(200)]
    //    public string? CommonDataContent { get; set; }

    //    [Column("HorizontalContent")]
    //    [MaxLength(160)]
    //    public string? HorizontalContent { get; set; }

    //    [Column("VerticalContent")]
    //    [MaxLength(160)]
    //    public string? VerticalContent { get; set; }

    //    [Column("WarrantyYear")]
    //    public int? WarrantyYear { get; set; }

    //    [Column("IsStandard")]
    //    public bool? IsStandard { get; set; }

    //    [Column("MaxApplyNum")]
    //    public int? MaxApplyNum { get; set; }

    //    [Column("MarketPrice")]
    //    public decimal? MarketPrice { get; set; }

    //    [Column("InsidePrice")]
    //    public decimal? InsidePrice { get; set; }

    //    [Column("ItemClassType")]
    //    [MaxLength(80)]
    //    public string? ItemClassType { get; set; }

    //    [Column("PropsClassType")]
    //    [MaxLength(80)]
    //    public string? PropsClassType { get; set; }

    //    [Column("Typing")]
    //    public int? Typing { get; set; }

    //    [Column("IsVirtualMat")]
    //    public bool? IsVirtualMat { get; set; }

    //    [Column("IsImageData")]
    //    public bool? IsImageData { get; set; }

    //    [Column("ExtID")]
    //    [MaxLength(20)]
    //    public string? ExtID { get; set; }

    //    [Column("IsSpecialMaterial")]
    //    public bool? IsSpecialMaterial { get; set; }

    //    [Column("Modifyer")]
    //    [MaxLength(20)]
    //    public string? Modifyer { get; set; }
    //} 

    [Table("SD_Mat_Material")]
    public class SD_Mat_Material
    { 
        [Key]
        public string MaterialID { get; set; } = string.Empty;
        public string? VendorMaterialCode { get; set; }
        public string MaterialCode { get; set; } = string.Empty;
        public string? BarCode { get; set; }
        public string? MaterialName { get; set; }
        public string MaterialShortName { get; set; } = string.Empty;
        public string? ForeignName { get; set; }
        public string? MatTypeID { get; set; }
        public string? CardID { get; set; }
        public string? KindID { get; set; }
        public string? SeriesID { get; set; }
        public string? ModelID { get; set; }
        public string? ItemID { get; set; }
        public string? AccreditID { get; set; }
        public string? StuffID { get; set; }
        public string? ColorID { get; set; }
        public string? ColorName2 { get; set; }
        public string? SexID { get; set; }
        public string? UnitID { get; set; }
        public string? SizeTypeID { get; set; }
        public int? YearNo { get; set; }
        public string? SeasonID { get; set; }
        public int? NewOld { get; set; }
        public string? PictureCode { get; set; }
        public string? InvSpec { get; set; }
        public string? StyleCode { get; set; }
        public bool? Season1 { get; set; }
        public bool? Season2 { get; set; }
        public bool? Season3 { get; set; }
        public bool? Season4 { get; set; }
        public bool? Season5 { get; set; }
        public decimal? ProRetailPrice { get; set; }
        public DateTime? ProSaleDate { get; set; }
        public string? SubSeries { get; set; }
        public string? SubModel { get; set; }
        public string? SubItem { get; set; }
        public string? MasterItem { get; set; }
        public string? MaterialProperty { get; set; }
        public string? Channel { get; set; }
        public int? MatStyle { get; set; }
        public string? SendCheckNo { get; set; }
        public string? CreateCompanyID { get; set; }
        public string? Remark { get; set; }
        public bool ProAllowUsed { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? Checker { get; set; }
        public bool CheckState { get; set; }
        public int? LockState { get; set; }
        public int? SyncState { get; set; }
        public DateTime ModifyDTM { get; set; }
        public string? Texture { get; set; }
        public string? StyleID { get; set; }
        public string? CommodityLevelID { get; set; }
        public string? CommodityProfileID { get; set; }
        public string? FactoryNo { get; set; }
        public string? DesignNo { get; set; }
        public string? CountryBarCode { get; set; }
        public string? SizeSection { get; set; }
        public string? ShoeTreeNo { get; set; }
        public string? LargeBase { get; set; }
        public string? ClothesVersionID { get; set; }
        public string? Creator { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int Lan { get; set; }
        public string? FactoryStyleNo { get; set; }
        public decimal? Volume { get; set; }
        public decimal? WeightNo { get; set; }
        public decimal? BoxBoard { get; set; }
        public bool? Season6 { get; set; }
        public int? PreVolumeModels { get; set; }
        public int? ProNature { get; set; }
        public string? StuffName2 { get; set; }
        public string? Lining { get; set; }
        public string? Filling { get; set; }
        public string? ExecStandard { get; set; }
        public string? SecurityKind { get; set; }
        public string? WashingMethod { get; set; }
        public string? DesignNoColor { get; set; }
        public string? ExecStandardID { get; set; }
        public string? WashingMethodID { get; set; }
        public string? SecurityKindID { get; set; }
        public bool? IsCreateByStyle { get; set; }
        public string? BatchNO { get; set; }
        public string? BandCode { get; set; }
        public string? ListingBatch { get; set; }
        public string? GroupFitName { get; set; }
        public string? OrnamentName { get; set; }
        public string? ProdStypleName { get; set; }
        public string? SituationName { get; set; }
        public string? MatPriceName { get; set; }
        public string? FabricTypeName { get; set; }
        public string? SourceMatName { get; set; }
        //public string? BasicBarCode { get; set; }
        //public string? TailBarCode { get; set; }
        //public string? SerialNo { get; set; }
        public int? MaterialType { get; set; }
        public string? MaterialLink { get; set; }
        public decimal? LongMetre { get; set; }
        public decimal? WidthMetre { get; set; }
        public decimal? HighMetre { get; set; }
        public bool? IsHorizontal { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public string? OriginCountry { get; set; }
        public decimal? TariffRate { get; set; }
        public bool? VirtualMat { get; set; }
        public string? CarVersion { get; set; }
        public string? PressId { get; set; }
        public bool? IsCanotChk { get; set; }
        public int? IsOtherSystem { get; set; }
        public bool? UsedValidity { get; set; }
        public bool? UsedBatch { get; set; }
        public int? ShelfLife { get; set; }
        public string? PackageName { get; set; }
        public string? MainMaterial { get; set; }
        public string? NetContent { get; set; }
        public string? IngredientsContent { get; set; }
        public string? InPackageSize { get; set; }
        public string? MinPackingQty { get; set; }
        public decimal? VIPPrice { get; set; }
        public string? StyleName { get; set; }
        public string? SoleMaterials { get; set; }
        public string? FootInsoles { get; set; }
        public string? ShoesFunction { get; set; }
        public string? ProductionPlace { get; set; }
        public string? InnerBox { get; set; }
        public string? InsideBox { get; set; }
        public string? SubTypeID { get; set; }
        public DateTime? ProductionDate { get; set; }
        public bool? IsBuyout { get; set; }
        public string? ProductFeature { get; set; }
        public bool? IsProp { get; set; }
        public string? SizeSpec { get; set; }
        public string? CommonDataType { get; set; }
        public string? CommonDataContent { get; set; }
        public string? HorizontalContent { get; set; }
        public string? VerticalContent { get; set; }
        public int? WarrantyYear { get; set; }
        public bool? IsStandard { get; set; }
        public int? MaxApplyNum { get; set; }
        public decimal? MarketPrice { get; set; }
        public decimal? InsidePrice { get; set; }
        public string? ItemClassType { get; set; }
        public string? PropsClassType { get; set; }
        public int? Typing { get; set; }
        public bool? IsVirtualMat { get; set; }
        public bool? IsImageData { get; set; }
        public bool? IsSpecialMaterial { get; set; }
        public string? ExtID { get; set; }
        public string? Modifyer { get; set; }
    }

}