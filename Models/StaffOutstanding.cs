using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffOutstanding")]
    public partial class StaffOutstanding
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string OutstandingNo { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string OutstandingDetail { get; set; }
        [StringLength(50)]
        public string OutstandingReward { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [StringLength(50)]
        public string ApproveDetail { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
