using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ToSocialWelfare")]
    public partial class ToSocialWelfare
    {
        [Key]
        [Column("ToSWCode")]
        [StringLength(20)]
        public string ToSwcode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        public float? TotalSoW { get; set; }
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
        public float? Income { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayYear { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(20)]
        public string AccountNo { get; set; }
        [StringLength(50)]
        public string BranchNo { get; set; }
        [Column("IDCardNo")]
        [StringLength(50)]
        public string IdcardNo { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("SSPay")]
        public float? Sspay { get; set; }
        [Column("PeriodEndID")]
        public int? PeriodEndId { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
