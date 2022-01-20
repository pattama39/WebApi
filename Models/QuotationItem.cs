using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("QuotationItem")]
    public partial class QuotationItem
    {
        [Key]
        [StringLength(20)]
        public string QuotationNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalAmount { get; set; }
        public byte? IsConfirm { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        public double? UnitCost { get; set; }
        public double? SubTotal { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public byte? IsFree { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column("PromotionTypeID")]
        public int? PromotionTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
