using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExpenseEntryItem")]
    public partial class ExpenseEntryItem
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ExpenseEntryNo { get; set; }
        [Key]
        [Column("SeqID")]
        public byte SeqId { get; set; }
        [StringLength(20)]
        public string ExpenseTypeCode { get; set; }
        public double? ExpenseAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        public double? Quantity { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalAmount { get; set; }
        public double? DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public byte? IsCalVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? NetAmount { get; set; }
    }
}
