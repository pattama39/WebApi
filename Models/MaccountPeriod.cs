using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MAccountPeriod")]
    public partial class MaccountPeriod
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PeriodID")]
        public short PeriodId { get; set; }
        [Key]
        public short PeriodYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginPeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndPeriodDate { get; set; }
        public byte? IsClose { get; set; }
        [StringLength(20)]
        public string CloseByCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RealDatetime { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        [Column("LastPeriodID")]
        public byte? LastPeriodId { get; set; }
        public byte? IsSyncFromServer { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsDelete { get; set; }
    }
}
