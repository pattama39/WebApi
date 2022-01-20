using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DebtDeduction")]
    public partial class DebtDeduction
    {
        [Key]
        [StringLength(20)]
        public string DebtNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DebtDate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string ReasonDebt { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [StringLength(50)]
        public string SalesBranch { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
