using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemIncentive")]
    public partial class ItemIncentive
    {
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveSellRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveSellFix { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? IncentiveDoRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDoFix { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDiagRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveDiagFix { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IncentiveAllRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? IncentiveAllFix { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        public double? IncentiveConsultRate { get; set; }
        public double? IncentiveConsultFix { get; set; }
        public byte? IsActiveSell { get; set; }
        public byte? IsActiveDo { get; set; }
        public byte? IsActiveConsult { get; set; }
        public byte? IsActiveDiag { get; set; }
    }
}
