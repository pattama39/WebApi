using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalesItem")]
    [Index(nameof(CustomerGid), Name = "IX_SalesItem")]
    [Index(nameof(SalesDate), Name = "IX_SalesItem_1")]
    [Index(nameof(ModDate), Name = "IX_SalesItem_2")]
    [Index(nameof(Vn), Name = "IX_SalesItem_3")]
    [Index(nameof(IsSyncToServer), Name = "IX_SalesItem_4")]
    [Index(nameof(AnimalGid), Name = "IX_SalesItem_5")]
    [Index(nameof(ItemCode), Name = "IX_SalesItem_6")]
    [Index(nameof(ItemName), Name = "IX_SalesItem_7")]
    [Index(nameof(ArreceiveNo), Name = "IX_SalesItem_8")]
    [Index(nameof(CourseNo), Name = "index_courseno")]
    public partial class SalesItem
    {
        [Key]
        [StringLength(20)]
        public string SalesNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
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
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string ChangeDateByCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(50)]
        public string ReceiptNo { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("OrderQTY")]
        public double? OrderQty { get; set; }
        [Column("CutStockQTY")]
        public double? CutStockQty { get; set; }
        [Column("UseQTY")]
        public double? UseQty { get; set; }
        [StringLength(255)]
        public string Dose1Code { get; set; }
        [StringLength(255)]
        public string Dose2Code { get; set; }
        [StringLength(255)]
        public string Dose3Code { get; set; }
        [StringLength(255)]
        public string Dose4Code { get; set; }
        [StringLength(255)]
        public string Dose5Code { get; set; }
        [StringLength(255)]
        public string Dose1 { get; set; }
        [StringLength(255)]
        public string Dose2 { get; set; }
        [StringLength(255)]
        public string Dose3 { get; set; }
        [StringLength(255)]
        public string Dose4 { get; set; }
        [StringLength(255)]
        public string Dose5 { get; set; }
        [StringLength(255)]
        public string Dose6 { get; set; }
        [StringLength(255)]
        public string DoseText { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitCost { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmount { get; set; }
        public byte? IsCalVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? RealAmount { get; set; }
        [Column("CostTypeID")]
        public short? CostTypeId { get; set; }
        public double? IncentiveRate { get; set; }
        public byte? IsPrintLabel { get; set; }
        public byte? IsPost { get; set; }
        public byte? IsPrintOrder { get; set; }
        [Column("DFByCode")]
        [StringLength(20)]
        public string DfbyCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column("IsFX")]
        public byte? IsFx { get; set; }
        [Column("FXRemark")]
        [StringLength(255)]
        public string Fxremark { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
        public byte? IsPay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayDate { get; set; }
        public byte? IsPrepare { get; set; }
        [StringLength(50)]
        public string FixAssetCode { get; set; }
        public double? FixAssetTime { get; set; }
        [StringLength(50)]
        public string XrayTypeCode { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Column("IncomeByPurposeTypeID")]
        public int? IncomeByPurposeTypeId { get; set; }
        public double? IncentiveRateC { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string ChargeText { get; set; }
        public double? ChargeAmount { get; set; }
        public byte? IsFree { get; set; }
        [Column("CourseGroupID")]
        public int? CourseGroupId { get; set; }
        [StringLength(50)]
        public string CourseNo { get; set; }
        [Column("CourseSeqID")]
        public int? CourseSeqId { get; set; }
        [StringLength(50)]
        public string IncomeTypeCode { get; set; }
        [StringLength(20)]
        public string SalesByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SalesDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string LabRequestNo { get; set; }
        [Column("XRayRequestNo")]
        [StringLength(20)]
        public string XrayRequestNo { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayIncentiveDate { get; set; }
        [StringLength(20)]
        public string ConsultByCode { get; set; }
        [StringLength(20)]
        public string DoByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public short? TotalCourseCredit { get; set; }
        [StringLength(50)]
        public string PriceLevelCode { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
        [Column("SurgeryID")]
        public int? SurgeryId { get; set; }
        public byte? IsPaid { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        [StringLength(50)]
        public string RightNo { get; set; }
        public double? RightDiscountAmount { get; set; }
        [StringLength(50)]
        public string RightDiscountRate { get; set; }
        public double? ClaimAmount { get; set; }
        [Column("PromotionTypeID")]
        public int? PromotionTypeId { get; set; }
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [StringLength(50)]
        public string PromotionNo { get; set; }
        [Column("SalesTypeID")]
        public byte? SalesTypeId { get; set; }
        [Column("OngoingTypeID")]
        public byte? OngoingTypeId { get; set; }
        [Column("ARReceiveNo")]
        [StringLength(50)]
        public string ArreceiveNo { get; set; }
        [Column("PackageID")]
        public int? PackageId { get; set; }
        [StringLength(20)]
        public string DiscountTypeCode { get; set; }
        [StringLength(50)]
        public string DiscountCode { get; set; }
        [StringLength(255)]
        public string DiscountDetail { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        [Column("PromotionID")]
        public int? PromotionId { get; set; }
        public byte? IsPromotionFree { get; set; }
        [Column("VoucherSeqID")]
        public int? VoucherSeqId { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string SurgeryGroupCode { get; set; }
        [StringLength(50)]
        public string MemberCardNumber { get; set; }
        [Column("MemberCardSeqID")]
        public int? MemberCardSeqId { get; set; }
        public double? VoucherCreditLimit { get; set; }
        public double? VoucherDiscountAmount { get; set; }
        [StringLength(50)]
        public string VoucherDiscountRate { get; set; }
        [Column("WaitReturnQTY")]
        public double? WaitReturnQty { get; set; }
        public double? SocialDiscountAmount { get; set; }
        [Column("PharmaRequestSeqID")]
        public int? PharmaRequestSeqId { get; set; }
        [Column("PharmaStatusID")]
        public byte? PharmaStatusId { get; set; }
        [Column("ApplyTypeID")]
        public short? ApplyTypeId { get; set; }
        public byte? IsEarnPoint { get; set; }
        public byte? IsCanEditSeller { get; set; }
        [Column("MemberCardRenewSeqID")]
        public int? MemberCardRenewSeqId { get; set; }
        [StringLength(20)]
        public string ReservePayNo { get; set; }
        public int? Round { get; set; }
        public double? ClaimDiscountAmount { get; set; }
        [StringLength(255)]
        public string Dose6Code { get; set; }
        public double? MemberDisCountAmount { get; set; }
        [StringLength(50)]
        public string MemberDisCountRate { get; set; }
        public byte? ProgramType { get; set; }
        public double? ItemPrice { get; set; }
        [StringLength(20)]
        public string DispenseByCode { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [Column("AppID")]
        public int? AppId { get; set; }
        [Column("ItemOrderTypeID")]
        public byte? ItemOrderTypeId { get; set; }
        [Column("HomeCareProgressID")]
        public int? HomeCareProgressId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SubscriptionDate { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
    }
}
