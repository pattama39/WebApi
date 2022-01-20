using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerSSP")]
    public partial class CustomerSsp
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("SSPTypeID")]
        public byte? SsptypeId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column("ICD10Code")]
        [StringLength(255)]
        public string Icd10code { get; set; }
        [Column("ICD9CMCode")]
        [StringLength(255)]
        public string Icd9cmcode { get; set; }
        [Column("ICD9CMTypeID")]
        public byte? Icd9cmtypeId { get; set; }
        [Column("ICD10TypeID")]
        public byte? Icd10typeId { get; set; }
        [StringLength(50)]
        public string SyndromeGroupCode { get; set; }
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
    }
}
