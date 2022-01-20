using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("EvaluateTraining")]
    public partial class EvaluateTraining
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string EvaluateNo { get; set; }
        [StringLength(20)]
        public string TrainingCode { get; set; }
        [StringLength(50)]
        public string EvaluateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EvaluateDate { get; set; }
        [Column("EvaluateTypeID")]
        public byte? EvaluateTypeId { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
