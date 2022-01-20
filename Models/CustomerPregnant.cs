using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerPregnant")]
    public partial class CustomerPregnant
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PregnantID")]
        public int PregnantId { get; set; }
        [Column("PregnantTypeID")]
        public byte? PregnantTypeId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("LMPDate", TypeName = "datetime")]
        public DateTime? Lmpdate { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
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
        [Column("EDCDate", TypeName = "datetime")]
        public DateTime? Edcdate { get; set; }
        [Column("CalGAFrom")]
        public byte? CalGafrom { get; set; }
    }
}
