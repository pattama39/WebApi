using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PettyCash")]
    public partial class PettyCash
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("PCValue", TypeName = "numeric(18, 5)")]
        public decimal? Pcvalue { get; set; }
        [Column("PCLastValue", TypeName = "numeric(18, 5)")]
        public decimal? PclastValue { get; set; }
        [Column("PCAccountCode")]
        [StringLength(20)]
        public string PcaccountCode { get; set; }
        [Column("PCBankAccountCode")]
        [StringLength(20)]
        public string PcbankAccountCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
