using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffMedicalRequest")]
    public partial class StaffMedicalRequest
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string MedicalRequestNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MedicalRequestDate { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
        public double? TotalAmount { get; set; }
        public double? RemainAmount { get; set; }
        public double? AmountPerPeriod { get; set; }
        [Column("PaymentTypeID")]
        public byte? PaymentTypeId { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
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
        [StringLength(10)]
        public string InDeCode { get; set; }
        public byte? PeriodNo { get; set; }
        public int? LeftPeriod { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
