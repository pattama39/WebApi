using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Expenditure")]
    public partial class Expenditure
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ExpenditureNo { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public double? TotalAmount { get; set; }
        public double? VatAmount { get; set; }
        public double? VatRate { get; set; }
        public double? DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("WHTAmount")]
        public double? Whtamount { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(20)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [Column("PCCode")]
        [StringLength(20)]
        public string Pccode { get; set; }
        [Column("PCWithDrawNo")]
        [StringLength(50)]
        public string PcwithDrawNo { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [Column("IsPCPay")]
        public byte? IsPcpay { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column("ExpenditureTypeID")]
        public byte? ExpenditureTypeId { get; set; }
        public byte? IsReimburse { get; set; }
        public int? ReferenceIndex { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string RecurringNo { get; set; }
        [StringLength(20)]
        public string RecurringGroupNo { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
    }
}
