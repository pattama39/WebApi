using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("APDown")]
    public partial class Apdown
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DownNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownDate { get; set; }
        [Column("PONo")]
        [StringLength(20)]
        public string Pono { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column("DownTypeID")]
        public int? DownTypeId { get; set; }
        [StringLength(50)]
        public string VatInPeriod { get; set; }
        [Column("VatChargeID")]
        public int? VatChargeId { get; set; }
        public byte? IsAddVat { get; set; }
        public byte? IsNotReVat { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string ConfirmByCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        public double? VatBaseAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmountAfterDiscount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TotalAmountAfterVat { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [StringLength(50)]
        public string ChequeDate { get; set; }
        [StringLength(50)]
        public string BankBranchName { get; set; }
        public double? ReceiveAmt { get; set; }
        [StringLength(50)]
        public string Refflag { get; set; }
        public double? NetBalanceAmount { get; set; }
        [StringLength(50)]
        public string BillDoc { get; set; }
        [Column("NBAL_12")]
        public double? Nbal12 { get; set; }
        [Column("RecAmt_12")]
        public double? RecAmt12 { get; set; }
        [Column("RECBEG")]
        public double? Recbeg { get; set; }
        public byte? IsEndMonth { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
