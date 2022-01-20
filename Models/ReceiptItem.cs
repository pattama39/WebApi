using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReceiptItem")]
    public partial class ReceiptItem
    {
        [Key]
        [StringLength(20)]
        public string ReceiptNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TaxRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TaxAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
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
    }
}
