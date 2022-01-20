using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ICD9CMVisit")]
    [Index(nameof(CustomerGid), Name = "IX_ICD9CMVisit")]
    [Index(nameof(Icdcode), Name = "IX_ICD9CMVisit_1")]
    [Index(nameof(Vn), Name = "IX_ICD9CMVisit_2")]
    public partial class Icd9cmvisit
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Required]
        [Column("ICDCode")]
        [StringLength(50)]
        public string Icdcode { get; set; }
        [Column("ICDName")]
        [StringLength(255)]
        public string Icdname { get; set; }
        [Column("ICDTypeCode")]
        [StringLength(50)]
        public string IcdtypeCode { get; set; }
        [Column("ICDTypeSubCode")]
        [StringLength(50)]
        public string IcdtypeSubCode { get; set; }
        [StringLength(20)]
        public string DiagByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DiagDate { get; set; }
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
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("ICDTypeID")]
        public byte? IcdtypeId { get; set; }
        [Column("TreatmentTypeID")]
        public byte? TreatmentTypeId { get; set; }
    }
}
