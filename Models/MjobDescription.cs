using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MJobDescription")]
    public partial class MjobDescription
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string JobDescriptionNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? JobDate { get; set; }
        [StringLength(20)]
        public string PositionCode { get; set; }
        [StringLength(10)]
        public string BranchCode { get; set; }
        [StringLength(20)]
        public string SectionCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SupervisorPositionCode { get; set; }
        [StringLength(50)]
        public string ExperienceInside { get; set; }
        [StringLength(50)]
        public string ExperienceOutside { get; set; }
        [StringLength(50)]
        public string TeamRole { get; set; }
        [StringLength(50)]
        public string LeadershipRole { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? FromAge { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ToAge { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? FromSalary { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ToSalary { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MinimumTrainHours { get; set; }
        [StringLength(50)]
        public string UpSalaryCondition { get; set; }
        [StringLength(50)]
        public string BonusSalary { get; set; }
        [StringLength(50)]
        public string SalaryRemark { get; set; }
        [StringLength(50)]
        public string Responsibility { get; set; }
        [StringLength(50)]
        public string JobDetail { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string FromExperience { get; set; }
        [StringLength(50)]
        public string ToExperience { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
