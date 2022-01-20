using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MShift")]
    public partial class Mshift
    {
        [Key]
        [StringLength(20)]
        public string ShiftCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string ShiftName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeLate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeEarly { get; set; }
        public int? MinIn { get; set; }
        public int? MinOut { get; set; }
        public int? MinBreak { get; set; }
        public int? MaxBreak { get; set; }
        public int? InOutGap { get; set; }
        public int? AllowLate { get; set; }
        public int? AllowEarly { get; set; }
        public int? MinInAsCome { get; set; }
        public int? MinOutAsCome { get; set; }
        [Column("IsCalOT1")]
        public byte? IsCalOt1 { get; set; }
        [Column("StartOT1", TypeName = "datetime")]
        public DateTime? StartOt1 { get; set; }
        [Column("EndOT1", TypeName = "datetime")]
        public DateTime? EndOt1 { get; set; }
        [Column("IsCalOT2")]
        public byte? IsCalOt2 { get; set; }
        [Column("StartOT2", TypeName = "datetime")]
        public DateTime? StartOt2 { get; set; }
        [Column("EndOT2", TypeName = "datetime")]
        public DateTime? EndOt2 { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        public byte? IsSubtractBreak { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? SubtractBreak { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        public byte? IsNextDayShift { get; set; }
        [StringLength(50)]
        public string ShiftName2 { get; set; }
        [StringLength(50)]
        public string ShortName2 { get; set; }
        public byte? IsUseDefaultTimeIn { get; set; }
        public byte? IsUseDefaultTimeOut { get; set; }
        [StringLength(50)]
        public string ShiftColor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndOut { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ShiftGroupCode { get; set; }
    }
}
