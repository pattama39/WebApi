using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("GroomingVisit")]
    public partial class GroomingVisit
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
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
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
        [StringLength(20)]
        public string GroomingByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? GroomingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GroomingTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? GroomingFinishDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GroomingFinishTime { get; set; }
        [Column("GroomningTypeID")]
        public byte? GroomningTypeId { get; set; }
        [Column(TypeName = "text")]
        public string RemarkGrooming { get; set; }
        public byte? IsFinish { get; set; }
    }
}
