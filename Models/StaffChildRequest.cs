using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffChildRequest")]
    public partial class StaffChildRequest
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ChildRequestNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChildRequestDate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
        public double? TotalAmount { get; set; }
        public double? RemainAmount { get; set; }
        [Column("PaymentTypeID")]
        public byte? PaymentTypeId { get; set; }
        [Column("InDeID")]
        public byte? InDeId { get; set; }
        [Column("DocStatusID")]
        public byte DocStatusId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
    }
}
