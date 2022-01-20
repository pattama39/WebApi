using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("QueTracking")]
    public partial class QueTracking
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column("QueID")]
        public int? QueId { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
        [StringLength(50)]
        public string QueCode { get; set; }
        [StringLength(50)]
        public string QueName { get; set; }
        [StringLength(50)]
        public string ToQueCode { get; set; }
        [StringLength(50)]
        public string ToQueName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionDateTime { get; set; }
        [Column("ActionTypeID")]
        public byte? ActionTypeId { get; set; }
        public byte? IsFinish { get; set; }
        public byte? IsAdmit { get; set; }
        public double? DifferenceHours { get; set; }
        public double? DifferenceMinutes { get; set; }
        public double? DifferenceSeconds { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
