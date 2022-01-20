using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReceiptNo { get; set; }
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
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TaxAmount { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceiptDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CashAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CreditAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ChequeAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
