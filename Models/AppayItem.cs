using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("APPayItem")]
    public partial class AppayItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("APPayNo")]
        [StringLength(20)]
        public string AppayNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmountAfterDiscount { get; set; }
        public double? NetAmount { get; set; }
        public double? PayAmount { get; set; }
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
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ReceiveAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("BRNo")]
        [StringLength(50)]
        public string Brno { get; set; }
        [Column("BRDate", TypeName = "smalldatetime")]
        public DateTime? Brdate { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column("DocTypeID")]
        public byte? DocTypeId { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
    }
}
