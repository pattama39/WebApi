using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MLabItemStandard")]
    public partial class MlabItemStandard
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string LabItemCode { get; set; }
        [Key]
        [StringLength(20)]
        public string SpeciesCode { get; set; }
        public double? LabResultMin { get; set; }
        public double? LabResultMax { get; set; }
        [Column("LabResultSTD")]
        public double? LabResultStd { get; set; }
        [StringLength(50)]
        public string LabResultMinText { get; set; }
        [StringLength(50)]
        public string LabResultMaxText { get; set; }
        [Column("LabResultSTDText")]
        [StringLength(50)]
        public string LabResultStdtext { get; set; }
        [Column(TypeName = "text")]
        public string LabResultPositiveText { get; set; }
        [Column(TypeName = "text")]
        public string LabResultNegativeText { get; set; }
        [Column(TypeName = "text")]
        public string LabResultText { get; set; }
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
        public byte? InActive { get; set; }
    }
}
