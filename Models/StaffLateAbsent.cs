using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffLateAbsent")]
    public partial class StaffLateAbsent
    {
        [Key]
        [Column("StaffLateAbsentID")]
        public long StaffLateAbsentId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public short? IsSystem { get; set; }
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
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LateAbsentDate { get; set; }
        public float? TotalLateHours { get; set; }
        [StringLength(255)]
        public string AbsentCause { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
