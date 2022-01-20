using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDocument")]
    public partial class Mdocument
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("DocTypeID")]
        public short? DocTypeId { get; set; }
        [StringLength(50)]
        public string DocTypeName { get; set; }
        [StringLength(50)]
        public string DocTypeName2 { get; set; }
        [StringLength(50)]
        public string DocTypeFlag { get; set; }
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
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(20)]
        public string Prefix { get; set; }
        [Column("FormatID1")]
        public byte? FormatId1 { get; set; }
        [Column("FormatID2")]
        public byte? FormatId2 { get; set; }
        public int? StartRunningNo { get; set; }
        public long? LastRunningNo { get; set; }
        [StringLength(50)]
        public string FormatText { get; set; }
        public byte? IsAutoRunningNo { get; set; }
        public byte? IsAutoReset { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsStandard { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Column("WHCode")]
        [StringLength(50)]
        public string Whcode { get; set; }
        [Key]
        public int ReferenceIndex { get; set; }
        [Column("AutoResetTypeID")]
        public byte? AutoResetTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastAutoResetDate { get; set; }
    }
}
