using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MProject")]
    public partial class Mproject
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(50)]
        public string ProjectName { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimatedFinishDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualFinishDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimatedStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualStartDate { get; set; }
        public int? TotalBugs { get; set; }
        [StringLength(255)]
        public string Risk { get; set; }
        [StringLength(255)]
        public string Tools { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("StatusFinishID")]
        public short? StatusFinishId { get; set; }
        public byte? Inactive { get; set; }
        [Column(TypeName = "numeric(10, 0)")]
        public decimal? EstimatedBudget { get; set; }
        [Column(TypeName = "numeric(10, 0)")]
        public decimal? ActualBudget { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ProjectTypeCode { get; set; }
    }
}
