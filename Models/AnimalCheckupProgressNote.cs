using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AnimalCheckupProgressNote")]
    public partial class AnimalCheckupProgressNote
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(50)]
        public string CheckUpCode { get; set; }
        [Key]
        [Column("ProgressID")]
        public int ProgressId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CheckUpDate { get; set; }
        [Column("ResultTypeID")]
        public byte? ResultTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
