using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPayrollPeriod")]
    public partial class MpayrollPeriod
    {
        [Key]
        [StringLength(20)]
        public string PeriodCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public short? IsSystem { get; set; }
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
        [StringLength(20)]
        public string PeriodNo { get; set; }
        public int PeriodYear { get; set; }
        public short? IsClose { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateStartStaffHour { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEndStaffHour { get; set; }
        public int? TotalHour { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateStartStaffDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEndStaffDay { get; set; }
        public int? TotalDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateStartStaffMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEndStaffMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateStartStaffContract { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEndStaffContract { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
