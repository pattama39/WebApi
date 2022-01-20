using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MLeaveType")]
    public partial class MleaveType
    {
        [Key]
        [StringLength(20)]
        public string LeaveTypeCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public int? AlllowableLeave { get; set; }
        public int? PropationPeriod { get; set; }
        public int? LeaveWithPay { get; set; }
        [StringLength(3)]
        public string LeaveableSex { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Description2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        public int? LeavePerYear { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
