using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ProcessScheduleChange")]
    public partial class ProcessScheduleChange
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ChangeID")]
        public int ChangeId { get; set; }
        [Column("ProcessID")]
        public int? ProcessId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        [Column("SourceID")]
        public byte? SourceId { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
        [StringLength(20)]
        public string ResponsibleByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
