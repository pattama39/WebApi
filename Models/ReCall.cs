using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReCall")]
    public partial class ReCall
    {
        [Key]
        [Column("ReCallID")]
        public int ReCallId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("AppID")]
        public int? AppId { get; set; }
        [Column("SeqID")]
        public short? SeqId { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [Column("IPDExpenseDate", TypeName = "smalldatetime")]
        public DateTime? IpdexpenseDate { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("ReCallTypeID")]
        public byte? ReCallTypeId { get; set; }
        [StringLength(255)]
        public string ReCallRemark { get; set; }
        [StringLength(20)]
        public string ReCallStaffCode { get; set; }
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
        [StringLength(255)]
        public string ReceiverName { get; set; }
    }
}
