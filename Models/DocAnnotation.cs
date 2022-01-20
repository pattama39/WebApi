using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DocAnnotation")]
    public partial class DocAnnotation
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("AnnotationID")]
        public int AnnotationId { get; set; }
        [StringLength(50)]
        public string AnnotationName { get; set; }
        [StringLength(50)]
        public string DoctorCode { get; set; }
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? DisplayMode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column("VN")]
        public int Vn { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
    }
}
