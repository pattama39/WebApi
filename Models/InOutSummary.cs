using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("InOutSummary")]
    public partial class InOutSummary
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(50)]
        public string PeriodNo { get; set; }
        [Key]
        public int PeriodYear { get; set; }
        public double? WorkHours { get; set; }
        public double? LeaveHoursDeduct { get; set; }
        public double? LeaveHours { get; set; }
        public double? AbsentHours { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? LateMinute { get; set; }
        [Column("OTWorkDayHours")]
        public double? OtworkDayHours { get; set; }
        public double? WorkHolidayHours { get; set; }
        [Column("OTHolidayHours")]
        public double? OtholidayHours { get; set; }
        public double? WorkOfficialHolidayHours { get; set; }
        [Column("OTOfficialHolidayHours")]
        public double? OtofficialHolidayHours { get; set; }
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
    }
}
