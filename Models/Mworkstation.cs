using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MWorkstation")]
    public partial class Mworkstation
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string WorkstationCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string WorkstationName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAudit { get; set; }
        [StringLength(50)]
        public string DomainName { get; set; }
        [Column("CPU")]
        [StringLength(50)]
        public string Cpu { get; set; }
        [Column("CPUSpeed")]
        [StringLength(50)]
        public string Cpuspeed { get; set; }
        [Column("OS")]
        [StringLength(50)]
        public string Os { get; set; }
        [Column("OSVersionNumber")]
        [StringLength(50)]
        public string OsversionNumber { get; set; }
        [Column("BIOS")]
        [StringLength(50)]
        public string Bios { get; set; }
        [Column("BIOSDate", TypeName = "datetime")]
        public DateTime? Biosdate { get; set; }
        [Column("BIOSVersion")]
        [StringLength(50)]
        public string Biosversion { get; set; }
        [StringLength(50)]
        public string LoginName { get; set; }
        [StringLength(50)]
        public string NetAddress { get; set; }
        [StringLength(50)]
        public string NodeAddress { get; set; }
        [Column("IPAddress")]
        [StringLength(50)]
        public string Ipaddress { get; set; }
        [StringLength(50)]
        public string Keyboard { get; set; }
        [StringLength(50)]
        public string VideoMemory { get; set; }
        [StringLength(50)]
        public string TotalMemory { get; set; }
        [StringLength(50)]
        public string MemoryAvailable { get; set; }
        [StringLength(50)]
        public string ScreenResolution { get; set; }
        [Column(TypeName = "ntext")]
        public string Remark { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
