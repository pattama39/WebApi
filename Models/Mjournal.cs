using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MJournal")]
    public partial class Mjournal
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string JournalCode { get; set; }
        [StringLength(50)]
        public string JournalName { get; set; }
        [StringLength(50)]
        public string JournalName2 { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(20)]
        public string BookCode { get; set; }
        public byte? IsSystem { get; set; }
        public byte? Inactive { get; set; }
        [StringLength(50)]
        public string Prefix { get; set; }
        [Column("FormatID1")]
        public byte? FormatId1 { get; set; }
        [Column("FormatID2")]
        public byte? FormatId2 { get; set; }
        [StringLength(50)]
        public string StartRunningNo { get; set; }
        [StringLength(50)]
        public string LastRunningNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
