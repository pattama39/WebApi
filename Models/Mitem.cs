using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MItem")]
    public partial class Mitem
    {
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string CutStockItemCode { get; set; }
        [StringLength(50)]
        public string ItemCode2 { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(255)]
        public string GenericCode { get; set; }
        [StringLength(255)]
        public string PrintName { get; set; }
        [StringLength(255)]
        public string PrintName2 { get; set; }
        [StringLength(50)]
        public string Keyword { get; set; }
        [StringLength(20)]
        public string ItemGroupCode { get; set; }
        [StringLength(20)]
        public string SubItemGroupCode { get; set; }
        [Column("ItemGroupCodeIPD")]
        [StringLength(50)]
        public string ItemGroupCodeIpd { get; set; }
        [Column("SubItemGroupCodeIPD")]
        [StringLength(50)]
        public string SubItemGroupCodeIpd { get; set; }
        [Column("ItemTypeID")]
        public short? ItemTypeId { get; set; }
        public byte? IsPackage { get; set; }
        [StringLength(20)]
        public string PrimaryAccountCode { get; set; }
        public byte? IsCustom { get; set; }
        public byte? IsCalVatPurchase { get; set; }
        public byte? IsCalVatSales { get; set; }
        [StringLength(50)]
        public string Hints { get; set; }
        [StringLength(50)]
        public string UnitStock { get; set; }
        [StringLength(50)]
        public string UnitOrder { get; set; }
        public double? UnitOrderRatio { get; set; }
        [StringLength(50)]
        public string UnitSales { get; set; }
        public double? UnitSalesRatio { get; set; }
        [Column("UnitCountHQ")]
        [StringLength(50)]
        public string UnitCountHq { get; set; }
        [Column("UnitCountHQRatio")]
        public double? UnitCountHqratio { get; set; }
        [StringLength(50)]
        public string UnitCountBranch { get; set; }
        public double? UnitCountBranchRatio { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSizeStock { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSizeSales1 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSizeSales2 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? UnitExchange { get; set; }
        [StringLength(20)]
        public string ComputeCode { get; set; }
        [StringLength(50)]
        public string Warnnig { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SellDefault { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IndexCost { get; set; }
        public byte? IsCalCost { get; set; }
        public byte? IsCalRevenue { get; set; }
        public byte? ApproveLevel { get; set; }
        public byte? IsPrintLabel { get; set; }
        public short? PrintLabel { get; set; }
        [StringLength(50)]
        public string LabelDesc { get; set; }
        public byte? IsCheckStock { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveSellRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveSellFix { get; set; }
        public double? IncentiveConsultRate { get; set; }
        public double? IncentiveConsultFix { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDiagRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDiagFix { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDoRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDoFix { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveAllRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveAllFix { get; set; }
        public byte? IsCalMinMax { get; set; }
        public byte? IsAutoPurchase { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PurchaseSize { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSize1 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSize2 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSize3 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSize4 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? PackSize5 { get; set; }
        [StringLength(20)]
        public string ItemAccountCode { get; set; }
        [StringLength(20)]
        public string SellCostAccountCode { get; set; }
        [StringLength(50)]
        public string Effect1 { get; set; }
        [StringLength(50)]
        public string Effect2 { get; set; }
        [StringLength(50)]
        public string Warn1 { get; set; }
        [StringLength(50)]
        public string Warn2 { get; set; }
        [StringLength(20)]
        public string ItemStockFormatCode { get; set; }
        [Column("IsYS")]
        public byte? IsYs { get; set; }
        [Column("ControlTypeID")]
        public byte? ControlTypeId { get; set; }
        public byte? IsSocial { get; set; }
        public byte? Is30Baht { get; set; }
        public byte? IsAct { get; set; }
        public byte? IsChild { get; set; }
        public byte? IsSpecialControl { get; set; }
        public byte? IsNotAllowPregnant { get; set; }
        [StringLength(255)]
        public string DoseDefault { get; set; }
        [StringLength(20)]
        public string TypeFoodCode { get; set; }
        [Column("IsXRay")]
        public byte? IsXray { get; set; }
        [StringLength(20)]
        public string XrayTypeCode { get; set; }
        [Column("OPDRevenueAccountCode")]
        [StringLength(20)]
        public string OpdrevenueAccountCode { get; set; }
        [Column("IPDRevenueAccountCode")]
        [StringLength(20)]
        public string IpdrevenueAccountCode { get; set; }
        [StringLength(20)]
        public string ReturnVendorAccountCode { get; set; }
        [Column("OPDGroupCode")]
        [StringLength(20)]
        public string OpdgroupCode { get; set; }
        [Column("IPDGroupCode")]
        [StringLength(20)]
        public string IpdgroupCode { get; set; }
        [Column("HMGroupCode")]
        [StringLength(20)]
        public string HmgroupCode { get; set; }
        [StringLength(50)]
        public string ToolTypeCode { get; set; }
        public double? ToolTime { get; set; }
        public byte? IsContrast { get; set; }
        [StringLength(20)]
        public string Barcode { get; set; }
        public double? MinimumPrice { get; set; }
        public double? MaximumPrice { get; set; }
        public byte? IsLab { get; set; }
        [StringLength(20)]
        public string LabGroupCode { get; set; }
        [Column("LabResultTypeID")]
        public byte? LabResultTypeId { get; set; }
        public byte? IsLabResultMale { get; set; }
        [StringLength(50)]
        public string LabResultMaleText { get; set; }
        public double? LabResultMaleMin { get; set; }
        public double? LabResultMaleMax { get; set; }
        public byte? IsLabResultFemale { get; set; }
        [StringLength(50)]
        public string LabResultFemaleText { get; set; }
        public double? LabResultFemaleMin { get; set; }
        public double? LabResultFemaleMax { get; set; }
        [StringLength(50)]
        public string LabUnit { get; set; }
        [StringLength(50)]
        public string LabMethod { get; set; }
        public byte? IsVaccine { get; set; }
        [Column("VaccineProductTypeID")]
        public byte? VaccineProductTypeId { get; set; }
        [Column("VaccineTypeID")]
        public byte? VaccineTypeId { get; set; }
        [StringLength(50)]
        public string VaccineForDesease { get; set; }
        [StringLength(50)]
        public string VaccineDose { get; set; }
        [StringLength(50)]
        public string VaccineRemark { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VaccineDuration { get; set; }
        [StringLength(20)]
        public string VaccineParentCode { get; set; }
        [StringLength(50)]
        public string VaccineQuantity { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        public byte? IsCourse { get; set; }
        [Column("CourseTypeID")]
        public byte? CourseTypeId { get; set; }
        [StringLength(50)]
        public string MainCourseCode { get; set; }
        public int? SubCourseAmount { get; set; }
        public int? SubCourseNo { get; set; }
        public byte? IsService { get; set; }
        public byte? IsDrug { get; set; }
        [StringLength(20)]
        public string InProgressAccountCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "text")]
        public string Indication { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MaxSalesQuantity { get; set; }
        public byte? IsMustScanFingerprint { get; set; }
        [Column("UnitPriceTypeID")]
        public int? UnitPriceTypeId { get; set; }
        public int? PrintBarcodeAmount { get; set; }
        [StringLength(20)]
        public string LocationCode { get; set; }
        public double? MaxOrderQuantity { get; set; }
        [StringLength(50)]
        public string PurchaseCondition { get; set; }
        [StringLength(20)]
        public string BrandCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastSalesDate { get; set; }
        public byte? IsMenu { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InActiveDate { get; set; }
        [Column("IsBOM")]
        public byte? IsBom { get; set; }
        [StringLength(255)]
        public string ItemName2 { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsPayIncentiveWhenComplete { get; set; }
        [Column("LabTypeID")]
        public byte? LabTypeId { get; set; }
        [StringLength(50)]
        public string RawLabCode1 { get; set; }
        [StringLength(20)]
        public string ManufactureCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastReceiveDate { get; set; }
        [StringLength(50)]
        public string Dose1 { get; set; }
        [StringLength(50)]
        public string Dose2 { get; set; }
        [StringLength(50)]
        public string Dose3 { get; set; }
        [StringLength(50)]
        public string Dose4 { get; set; }
        [StringLength(50)]
        public string Dose5 { get; set; }
        public byte? IsFavoriteLab { get; set; }
        [StringLength(50)]
        public string RawLabCode2 { get; set; }
        [StringLength(50)]
        public string RawLabCode3 { get; set; }
        [StringLength(50)]
        public string RawLabCode4 { get; set; }
        [StringLength(50)]
        public string RawLabCode5 { get; set; }
        [StringLength(20)]
        public string ColorCode { get; set; }
        [StringLength(20)]
        public string ShapeCode { get; set; }
        [StringLength(20)]
        public string TabletText { get; set; }
        public double? TempNumber1 { get; set; }
        [Column("PromotionTypeID")]
        public byte? PromotionTypeId { get; set; }
        public double? PromotionPriceFrom { get; set; }
        public double? PromotionPriceTo { get; set; }
        public double? PromotionFreeDrugQty { get; set; }
        public double? PromotionTotalCredit { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        public double? WithholdingTaxRate { get; set; }
        [StringLength(50)]
        public string WithholdingTaxTypeCode { get; set; }
        public double? SafetyDate { get; set; }
        public double? HoldingDate { get; set; }
        public double? LeadTime { get; set; }
        public double? CourseExpire { get; set; }
        public byte? IsSetRight { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        public double? RightCreditLimit { get; set; }
        public byte? RightIsUnLimitCredit { get; set; }
        public double? RightExpire { get; set; }
        public byte? RightIsUnExpire { get; set; }
        public double? RightAmountPerDay { get; set; }
        [Column("OnShelfQTY")]
        public double? OnShelfQty { get; set; }
        public double? UnitCost { get; set; }
        public double? AverageCost { get; set; }
        public double? FixCost { get; set; }
        public double? ReplaceCost { get; set; }
        [Column("FIFOCost")]
        public double? Fifocost { get; set; }
        [Column("LIFOCost")]
        public double? Lifocost { get; set; }
        public double? QuantityPerCourse { get; set; }
        [Column("ExpireTypeID")]
        public byte? ExpireTypeId { get; set; }
        [StringLength(50)]
        public string UnitCourse { get; set; }
        [Column("ROTypeID")]
        public int? RotypeId { get; set; }
        public byte? IsDiscountable { get; set; }
        [Column("DiscountTypeID")]
        public byte? DiscountTypeId { get; set; }
        public double? DiscountFix { get; set; }
        public double? DiscountRate { get; set; }
        [Column("IncentiveMethodID")]
        public byte? IncentiveMethodId { get; set; }
        [StringLength(50)]
        public string ForecastTypeCode { get; set; }
        public byte? IsCalIncentiveRateAllByMainCourse { get; set; }
        public byte? IsCalIncentiveRateSellByMainCourse { get; set; }
        public byte? IsCalIncentiveRateDiagByMainCourse { get; set; }
        public byte? IsCalIncentiveRateConsultByMainCourse { get; set; }
        public byte? IsCalIncentiveRateDoByMainCourse { get; set; }
        [StringLength(20)]
        public string DiscountTypeCode { get; set; }
        [StringLength(50)]
        public string DiscountCode { get; set; }
        [StringLength(255)]
        public string DiscountDetail { get; set; }
        [Column("IsFDA")]
        public byte? IsFda { get; set; }
        public byte? IsDrugOrder { get; set; }
        public byte? IncentiveSellPersonCount { get; set; }
        public byte? IncentiveDoPersionCount { get; set; }
        public byte? IncentiveDiagPersonCount { get; set; }
        public byte? IncentiveConsultPersonCount { get; set; }
        public double? CreditLimit { get; set; }
        public byte? IsCanEditPrice { get; set; }
        [StringLength(20)]
        public string SurgeryGroupCode { get; set; }
        public byte? IsSurgery { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCodeSurgery { get; set; }
        [Column("MemberExpireTypeID")]
        public byte? MemberExpireTypeId { get; set; }
        public int? MemberExpireDays { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MemberExpireDate { get; set; }
        public int? MemberColor { get; set; }
        public byte? IsUnLimitCredit { get; set; }
        [Column("ItemGroupCodeIPDSurgery")]
        [StringLength(50)]
        public string ItemGroupCodeIpdsurgery { get; set; }
        [Column("SubItemGroupCodeIPDSurgery")]
        [StringLength(50)]
        public string SubItemGroupCodeIpdsurgery { get; set; }
        public double? TotalCost { get; set; }
        public double? TotalCostAverage { get; set; }
        [Column("TotalCostFIFO")]
        public double? TotalCostFifo { get; set; }
        public double? SocialDiscountAmount { get; set; }
        public byte? IsHaveIncentiveSellPerson { get; set; }
        public byte? IsHaveIncentiveDoPerson { get; set; }
        public byte? IsHaveIncentiveDiagPerson { get; set; }
        public byte? IsHaveIncentiveConsultPerson { get; set; }
        public byte? IsUseWithPoint { get; set; }
        public byte? IsMemberExpireForUse { get; set; }
        [Column("MemberRunningNoTypeID")]
        public byte? MemberRunningNoTypeId { get; set; }
        [StringLength(20)]
        public string MemberRunningPrefix { get; set; }
        [StringLength(50)]
        public string MemberRunningFormatText { get; set; }
        public long? MemberLastRunningNo { get; set; }
        public double? MemberCollectAmountPerPoint { get; set; }
        public double? MemberCollectPoint { get; set; }
        public byte? IsEarnPoint { get; set; }
        [StringLength(50)]
        public string VoucherPriceLevelCode { get; set; }
        [Column("CalIncentiveTypeID")]
        public byte? CalIncentiveTypeId { get; set; }
        public byte? IsControl { get; set; }
        [StringLength(20)]
        public string ClassifiedGroupCode { get; set; }
        [Column("CutStockTypeID")]
        public byte? CutStockTypeId { get; set; }
        [Column("IsIVTherapy")]
        public byte? IsIvtherapy { get; set; }
        public byte? IsLabStandard { get; set; }
        [Column("IsPOSOrder")]
        public byte? IsPosorder { get; set; }
        public byte? IsNotifications { get; set; }
        public int? NotificationsDay { get; set; }
        public int? NotificationsMonth { get; set; }
        public int? NotificationsYear { get; set; }
        public int? NotificationsHour { get; set; }
        public int? NotificationsMinute { get; set; }
        [Column(TypeName = "text")]
        public string LabResultNote { get; set; }
        public byte? IsMutiOrder { get; set; }
        public byte? IsPriceUnitSales { get; set; }
        [Column("IncentiveSellTypeID")]
        public byte? IncentiveSellTypeId { get; set; }
        [Column("IncentiveDiagTypeID")]
        public byte? IncentiveDiagTypeId { get; set; }
        [Column("IncentiveConsultTypeID")]
        public byte? IncentiveConsultTypeId { get; set; }
        [Column("IncentiveDoTypeID")]
        public byte? IncentiveDoTypeId { get; set; }
        [StringLength(20)]
        public string LabCode { get; set; }
        [StringLength(100)]
        public string Manufacturer { get; set; }
        [StringLength(20)]
        public string SpecimenCode { get; set; }
        public double? CollectAmountPerPoint { get; set; }
        public double? CollectPoint { get; set; }
        public double? RedeemAmountPerPoint { get; set; }
        public double? RedeemPoint { get; set; }
        public int? PointExpireDay { get; set; }
        [Column("PointCalculateTypeID")]
        public byte? PointCalculateTypeId { get; set; }
        public byte? IsUsePoint { get; set; }
    }
}
