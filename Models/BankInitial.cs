using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BankInitial")]
    public partial class BankInitial
    {
        [Required]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [Column("BookbankID")]
        [StringLength(50)]
        public string BookbankId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BookbankDate { get; set; }
        public double? Amount { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Key]
        [Column("RowID")]
        public int RowId { get; set; }
    }
}
