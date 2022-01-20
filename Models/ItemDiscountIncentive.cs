using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemDiscountIncentive")]
    public partial class ItemDiscountIncentive
    {
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public double? IncentiveAllRate { get; set; }
        public double? IncentiveAllFix { get; set; }
        public double? IncentiveSellRate { get; set; }
        public double? IncentiveSellFix { get; set; }
        public double? IncentiveConsultRate { get; set; }
        public double? IncentiveConsultFix { get; set; }
        public double? IncentiveDiagRate { get; set; }
        public double? IncentiveDiagFix { get; set; }
        public double? IncentiveDoRate { get; set; }
        public double? IncentiveDoFix { get; set; }
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
        public double? MinDiscount { get; set; }
        public double? MaxDiscount { get; set; }
        public byte? IsActiveSell { get; set; }
        public byte? IsActiveConsult { get; set; }
        public byte? IsActiveDiag { get; set; }
        public byte? IsActiveDo { get; set; }
        public byte? IsAll { get; set; }
    }
}
