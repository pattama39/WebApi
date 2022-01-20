using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("AuditRequest")]
    public partial class AuditRequest
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("RequestID")]
        public int RequestId { get; set; }
        [Column("RequestTypeID")]
        public byte RequestTypeId { get; set; }
        [Column("SeqID")]
        public short SeqId { get; set; }
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
        [StringLength(50)]
        public string ProductNo { get; set; }
        [StringLength(50)]
        public string AuditItem { get; set; }
        public short? Frequency { get; set; }
        [StringLength(50)]
        public string AuditorByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column("ScheduleTypeID")]
        public short? ScheduleTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AuditDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
