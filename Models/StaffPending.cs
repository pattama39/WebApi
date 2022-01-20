using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffPending")]
    public partial class StaffPending
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string PendingNo { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartPendingDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndPendingDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? PendingDuration { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [StringLength(50)]
        public string PendingReason { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
