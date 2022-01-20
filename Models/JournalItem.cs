using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("JournalItem")]
    public partial class JournalItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(255)]
        public string AccountName { get; set; }
        [StringLength(20)]
        public string BookCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        public double? CreditAmount { get; set; }
        public double? DebitAmount { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public double? NetAmount { get; set; }
        public double? BalanceAmount { get; set; }
        public double? VatAmount { get; set; }
        public double? BeginingBalance { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
