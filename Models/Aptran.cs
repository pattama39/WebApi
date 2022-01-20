using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("APTrans")]
    public partial class Aptran
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? PaymentTerm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public byte? IsAddVat { get; set; }
        public byte? IsNotReturnVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public double? BeginAmount { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        public double? InvoiceAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditCardAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("DocTypeID")]
        public int? DocTypeId { get; set; }
        [Column("VatChargeID")]
        public int? VatChargeId { get; set; }
        public double? PayAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
