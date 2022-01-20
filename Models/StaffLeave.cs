using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffLeave")]
    public partial class StaffLeave
    {
        [Key]
        [Column("LeaveID")]
        public int LeaveId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string LeaveTypeCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public double? TotalLeaveDays { get; set; }
        public double? TotalLeaveHours { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToTime { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
