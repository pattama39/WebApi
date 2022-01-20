using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SSPReport")]
    public partial class Sspreport
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(50)]
        public string SpeciesCode { get; set; }
        [Column("ICD9CMCode")]
        [StringLength(50)]
        public string Icd9cmcode { get; set; }
        [Column("ICD9CMTypeCode")]
        [StringLength(50)]
        public string Icd9cmtypeCode { get; set; }
        [Column("ICD10Code")]
        [StringLength(50)]
        public string Icd10code { get; set; }
        [StringLength(50)]
        public string SyndromeGroupCode { get; set; }
        public int? Month1Amount { get; set; }
        public int? Month2Amount { get; set; }
        public int? Month3Amount { get; set; }
        public int? Month4Amount { get; set; }
        public int? Month5Amount { get; set; }
        public int? Month6Amount { get; set; }
        public int? Month7Amount { get; set; }
        public int? Month8Amount { get; set; }
        public int? Month9Amount { get; set; }
        public int? Month10Amount { get; set; }
        public int? Month11Amount { get; set; }
        public int? Month12Amount { get; set; }
        public int? Summary { get; set; }
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
