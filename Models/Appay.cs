using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("APPay")]
    public partial class Appay
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("APPayNo")]
        [StringLength(20)]
        public string AppayNo { get; set; }
        [Column("AENo")]
        [StringLength(50)]
        public string Aeno { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmountAfterDiscount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
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
        public double? PayAmount { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? ExpenseAmount { get; set; }
        [Column("WHTAmount")]
        public double? Whtamount { get; set; }
        public int? ReferenceIndex { get; set; }
    }
}
