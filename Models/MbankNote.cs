using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MBankNote")]
    public partial class MbankNote
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string BankNoteCode { get; set; }
        [StringLength(50)]
        public string BankNoteName { get; set; }
        [StringLength(50)]
        public string BankNoteName2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BankValue { get; set; }
        [Column(TypeName = "image")]
        public byte[] BankNoteImage { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
