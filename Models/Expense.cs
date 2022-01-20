using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Expense")]
    public partial class Expense
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ExpenseID")]
        public int ExpenseId { get; set; }
        [StringLength(50)]
        public string ExpenseTypeCode { get; set; }
        [Column("RequestID")]
        public int? RequestId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public int? IsConfirm { get; set; }
        [Column("ScopeID")]
        public int? ScopeId { get; set; }
        [StringLength(50)]
        public string LockByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string CompanyCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
