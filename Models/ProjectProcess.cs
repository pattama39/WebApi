using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ProjectProcess")]
    public partial class ProjectProcess
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ProcessID")]
        public int ProcessId { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("RequirementID")]
        public int? RequirementId { get; set; }
        [StringLength(20)]
        public string ResponsibleByCode { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string ProcessStatusCode { get; set; }
        [StringLength(20)]
        public string ComplexCode { get; set; }
        public int? EstimatedEffort { get; set; }
        public int? ActualEffort { get; set; }
        public byte? IsActualStart { get; set; }
        [StringLength(20)]
        public string ProcessStageCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimatedStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimatedFinishDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualFinishDate { get; set; }
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
        public byte? IsStart { get; set; }
        public byte? IsFinish { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? PercentComplete { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber3 { get; set; }
        [StringLength(50)]
        public string CustomText1 { get; set; }
        [StringLength(50)]
        public string CustomText2 { get; set; }
        [StringLength(50)]
        public string CustomText3 { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
