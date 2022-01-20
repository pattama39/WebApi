using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDocOptions")]
    public partial class MdocOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Column("ProgramTypeID")]
        public int? ProgramTypeId { get; set; }
        public byte? IsAutoLogin { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("CameraDetectTypeID")]
        public int? CameraDetectTypeId { get; set; }
        [StringLength(50)]
        public string ImageExt { get; set; }
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [StringLength(255)]
        public string ProgramPath { get; set; }
        public byte? IsShowCancelQueButton { get; set; }
        public byte? IsShowConfirmQueButton { get; set; }
        public byte? IsShowWaitQueButton { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string CurrentBuild { get; set; }
        [Column("ResizeTypeID")]
        public byte? ResizeTypeId { get; set; }
    }
}
