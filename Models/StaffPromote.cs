using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffPromote")]
    public partial class StaffPromote
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string PromoteNo { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? OldSalary { get; set; }
        [StringLength(50)]
        public string OldSection { get; set; }
        [StringLength(50)]
        public string OldDepartment { get; set; }
        [StringLength(50)]
        public string OldBranch { get; set; }
        [StringLength(50)]
        public string OldLevel { get; set; }
        [StringLength(50)]
        public string OldPosition { get; set; }
        [StringLength(50)]
        public string OldType { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NewSalary { get; set; }
        [StringLength(50)]
        public string NewSection { get; set; }
        [StringLength(50)]
        public string NewDepartment { get; set; }
        [StringLength(50)]
        public string NewBranch { get; set; }
        [StringLength(50)]
        public string NewLevel { get; set; }
        [StringLength(50)]
        public string NewPosition { get; set; }
        [StringLength(50)]
        public string NewType { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(50)]
        public string ApproveDetail { get; set; }
        [StringLength(50)]
        public string ApproveRemark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
