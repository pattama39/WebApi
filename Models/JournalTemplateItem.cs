using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("JournalTemplateItem")]
    public partial class JournalTemplateItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string TemplateCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(255)]
        public string AccountName { get; set; }
        [StringLength(50)]
        public string FormulaDebitName { get; set; }
        [StringLength(50)]
        public string FormulaCreditName { get; set; }
        public byte? InActive { get; set; }
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
