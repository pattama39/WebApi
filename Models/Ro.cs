using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("RO")]
    [Index(nameof(IsSyncToServer), Name = "IX_RO")]
    public partial class Ro
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("RONo")]
        [StringLength(20)]
        public string Rono { get; set; }
        [Column("AENo")]
        [StringLength(50)]
        public string Aeno { get; set; }
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
        [Column("PONo")]
        [StringLength(20)]
        public string Pono { get; set; }
        [Column("ROTypeID")]
        public byte? RotypeId { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string VendorAddressCode { get; set; }
        [StringLength(50)]
        public string ConstraintPayment { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column("ConstraintMethodID")]
        public byte? ConstraintMethodId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DiscountDueDate { get; set; }
        public double? DiscountDueValue { get; set; }
        [Column("DiscountUnitID")]
        public byte? DiscountUnitId { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountForVat { get; set; }
        public double? DiscountAmount { get; set; }
        public double? DiscountAmountForVat { get; set; }
        [Column("WHTAmount")]
        public double? Whtamount { get; set; }
        public double? NetAmount { get; set; }
        public double? PayAmount { get; set; }
        public byte? IsComplete { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public byte? IsBegin { get; set; }
        public byte? IsLock { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column("RODate", TypeName = "smalldatetime")]
        public DateTime? Rodate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string TransferNo { get; set; }
        [StringLength(50)]
        public string TransferFromOrgCode { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [StringLength(50)]
        public string DiscountTextForVat { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(20)]
        public string RefNo { get; set; }
        public byte? IsNotReturnVat { get; set; }
        [StringLength(20)]
        public string DownPayNo { get; set; }
        public double? DownAmount { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        public short? PaymentTerm { get; set; }
        public byte? IsAddVat { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        public double? CashPayAmount { get; set; }
        [StringLength(20)]
        public string TransportCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsHidePrice { get; set; }
        public double? NetAmountForCalVat { get; set; }
        public double? ExpenseAmount { get; set; }
        public int? ReferenceIndex { get; set; }
        [Column("AEAmount")]
        public double? Aeamount { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(20)]
        public string RecurringNo { get; set; }
        [StringLength(20)]
        public string RecurringGroupNo { get; set; }
        [StringLength(255)]
        public string RecurringName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(20)]
        public string RecurringGroupCode { get; set; }
    }
}
