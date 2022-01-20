using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MICD9CM")]
    public partial class Micd9cm
    {
        [Key]
        [Column("ICDCode")]
        [StringLength(50)]
        public string Icdcode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("ICDName")]
        [StringLength(255)]
        public string Icdname { get; set; }
        [Column("ICDName2")]
        [StringLength(255)]
        public string Icdname2 { get; set; }
        [Column("ICD9CMGroupCode")]
        [StringLength(50)]
        public string Icd9cmgroupCode { get; set; }
        [StringLength(50)]
        public string SyndromeGroupCode { get; set; }
        [Column("UR", TypeName = "numeric(18, 5)")]
        public decimal? Ur { get; set; }
        [Column(TypeName = "text")]
        public string Advice { get; set; }
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
    }
}
