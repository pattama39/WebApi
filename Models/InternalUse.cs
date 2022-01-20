using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("InternalUse")]
    public partial class InternalUse
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string InternalUseNo { get; set; }
        [Column("UseTypeID")]
        public byte? UseTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UseDate { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string ToDepartmentCode { get; set; }
        [StringLength(50)]
        public string ToFactionCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public byte? IsAddVat { get; set; }
        [StringLength(255)]
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
        public int? ReferenceIndex { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
    }
}
