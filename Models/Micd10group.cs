using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MICD10Group")]
    public partial class Micd10group
    {
        [Key]
        [Column("ICD10GroupCode")]
        [StringLength(20)]
        public string Icd10groupCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("ICD10GroupName")]
        [StringLength(50)]
        public string Icd10groupName { get; set; }
        [Column("ICD10GroupName2")]
        [StringLength(50)]
        public string Icd10groupName2 { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column("ModByCOde")]
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsSystem { get; set; }
    }
}
