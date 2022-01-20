using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("VatPurchase")]
    public partial class VatPurchase
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column("DocTypeID")]
        public byte DocTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountBeforeVat { get; set; }
        public double? TotalAmountForVat { get; set; }
        public double? TotalAmountForNonVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        public byte? IsAddVat { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public byte? InActive { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string RefNo { get; set; }
        [Column("RefSeqID")]
        public int? RefSeqId { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [Column("VendorTypeID")]
        public byte? VendorTypeId { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [StringLength(20)]
        public string AccountPeriod { get; set; }
    }
}
