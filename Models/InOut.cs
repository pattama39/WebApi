using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("InOut")]
    [Index(nameof(StaffCode), Name = "IX_InOut")]
    [Index(nameof(TimeIn), Name = "IX_InOut_1")]
    [Index(nameof(TimeOut), Name = "IX_InOut_2")]
    public partial class InOut
    {
        [Key]
        [Column("InoutID")]
        public int InoutId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("SeqID")]
        public int? SeqId { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeIn { get; set; }
        public byte? IsTimeIn { get; set; }
        public byte? IsLate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOut { get; set; }
        public byte? IsTimeOut { get; set; }
        public byte? IsEarly { get; set; }
        public int? TotalMinutesWork { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalMinutesBreak { get; set; }
        public byte? IsModify { get; set; }
        [StringLength(255)]
        public string ModifyReason { get; set; }
        [Column("IsSendSMSIn")]
        public byte? IsSendSmsin { get; set; }
        [Column("IsSendSMSOut")]
        public byte? IsSendSmsout { get; set; }
        [StringLength(20)]
        public string ShiftCode { get; set; }
        public byte? IsManualIn { get; set; }
        public byte? IsManualOut { get; set; }
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
        [Column("TotalMinutesOT1", TypeName = "numeric(18, 0)")]
        public decimal? TotalMinutesOt1 { get; set; }
        [Column("TotalMinutesOT2", TypeName = "numeric(18, 0)")]
        public decimal? TotalMinutesOt2 { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalMinutesLate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalMinutesEarly { get; set; }
        public byte? IsProcess { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
