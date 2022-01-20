using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffOT")]
    public partial class StaffOt
    {
        [Key]
        [Column("OTID")]
        public int Otid { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("OTCode")]
        [StringLength(20)]
        public string Otcode { get; set; }
        [Column("OTDate", TypeName = "smalldatetime")]
        public DateTime? Otdate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        public float? TotalHours { get; set; }
        [Column("OTPeriod")]
        public int? Otperiod { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("OTTypeID")]
        public int? OttypeId { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
