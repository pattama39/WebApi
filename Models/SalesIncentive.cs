using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalesIncentive")]
    public partial class SalesIncentive
    {
        [Column("VN")]
        public int? Vn { get; set; }
        [Key]
        [StringLength(20)]
        public string SalesNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [Column("IncentiveTypeID")]
        public int IncentiveTypeId { get; set; }
        public double? NetBeforeCal { get; set; }
        public double? IncentiveFromRate { get; set; }
        public double? IncentiveFromFix { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
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
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("ReceiveTypeID")]
        public int? ReceiveTypeId { get; set; }
        [StringLength(50)]
        public string RefSalesNo { get; set; }
        [Column("RefSalesItemSeqID")]
        public int? RefSalesItemSeqId { get; set; }
    }
}
