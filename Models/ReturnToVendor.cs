using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReturnToVendor")]
    public partial class ReturnToVendor
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnToVendorNo { get; set; }
        [Column("ReturnTypeID")]
        public byte? ReturnTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string RoNo { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FationCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public byte? IsAddVat { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("DownLiabilityID")]
        public short? DownLiabilityId { get; set; }
        public byte? IsNotReVat { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(100)]
        public string BankBranchCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BeginsAmount { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        public double? NetAmountForCalVat { get; set; }
        public int? ReferenceIndex { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
    }
}
