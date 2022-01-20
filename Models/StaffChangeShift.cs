using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffChangeShift")]
    public partial class StaffChangeShift
    {
        [Key]
        [StringLength(20)]
        public string StaffChangeShiftNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        public string StaffCode1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangeShiftDate1 { get; set; }
        [StringLength(20)]
        public string ShiftCodeStaff1 { get; set; }
        [StringLength(20)]
        public string StaffCode2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChangeShiftDate2 { get; set; }
        [StringLength(20)]
        public string ShiftCodeStaff2 { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
