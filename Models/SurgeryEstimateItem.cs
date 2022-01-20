using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SurgeryEstimateItem")]
    public partial class SurgeryEstimateItem
    {
        [Key]
        [StringLength(20)]
        public string SurgeryEstimateNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("SurgeryID")]
        public int? SurgeryId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
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
        [Column("CostTypeID")]
        public short? CostTypeId { get; set; }
        [Column("DFByCode")]
        [StringLength(10)]
        public string DfbyCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column("IsFX")]
        public byte? IsFx { get; set; }
        [StringLength(255)]
        public string PackageCode { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
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
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string ChargeText { get; set; }
        public double? ChargeAmount { get; set; }
        public byte? IsFree { get; set; }
        [StringLength(20)]
        public string SalesByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [StringLength(20)]
        public string ConsultByCode { get; set; }
        [StringLength(20)]
        public string DoByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public short? TotalCourseCredit { get; set; }
        [StringLength(50)]
        public string PriceLevelCode { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        [Column("SalesTypeID")]
        public byte? SalesTypeId { get; set; }
        [Column("PackageID")]
        public int? PackageId { get; set; }
        [StringLength(20)]
        public string DiscountTypeCode { get; set; }
        [StringLength(50)]
        public string DiscountCode { get; set; }
        [StringLength(255)]
        public string DiscountDetail { get; set; }
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
        public byte? IsOrder { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
    }
}
