using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Index(nameof(LogTypeId), Name = "IX_LogData")]
    public partial class LogDatum
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("LogTypeID")]
        public int? LogTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column("DataID1")]
        public int? DataId1 { get; set; }
        [Column("DataID2")]
        public int? DataId2 { get; set; }
        [StringLength(20)]
        public string DataCode1 { get; set; }
        [StringLength(20)]
        public string DataCode2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string ActionTypeCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
    }
}
