using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExpenseEntry")]
    public partial class ExpenseEntry
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ExpenseEntryNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpenseEntryDate { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public double? TotalExpenseAmount { get; set; }
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
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
    }
}
