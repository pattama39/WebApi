using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AccountPeriod")]
    public partial class AccountPeriod
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PeriodID")]
        public int PeriodId { get; set; }
        [StringLength(50)]
        public string PeriodName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodDate { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        public byte? IsCanEdit { get; set; }
        public byte? IsCanApprove { get; set; }
        public byte? IsCanDelete { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OpenTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
