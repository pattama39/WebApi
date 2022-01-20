using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemPaymentItem")]
    public partial class ItemPaymentItem
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemPaymentNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
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
        [Column("PRNoText")]
        [StringLength(255)]
        public string PrnoText { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Quantity { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? UnitCost { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "numeric(9, 5)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? VatAmount { get; set; }
        public double? NetAmount { get; set; }
        public byte? IsFree { get; set; }
        [Column("ROQuantity", TypeName = "numeric(18, 5)")]
        public decimal? Roquantity { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
