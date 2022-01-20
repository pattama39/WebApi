using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MFixassetType")]
    public partial class MfixassetType
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string FixassetTypeName { get; set; }
        [StringLength(50)]
        public string FixassetTypeName2 { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? RemainsValue { get; set; }
        public int? Duration { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DepreciationRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? FirstYearRate { get; set; }
        [StringLength(50)]
        public string FixassetAccountCode { get; set; }
        [StringLength(50)]
        public string FixassetDepAccountCode { get; set; }
        [StringLength(50)]
        public string FixassetDepSumAccountCode { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        [Key]
        [StringLength(50)]
        public string FixassetTypeCode { get; set; }
    }
}
