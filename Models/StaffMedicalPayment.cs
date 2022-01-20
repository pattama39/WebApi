using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffMedicalPayment")]
    public partial class StaffMedicalPayment
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string MedicalPaymentNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MedicalPaymentDate { get; set; }
        [StringLength(20)]
        public string MedicalRequestNo { get; set; }
        [Column("PaymentTypeID")]
        public byte? PaymentTypeId { get; set; }
        public double? PaymentAmount { get; set; }
        public byte? PeriodNo { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("InDeID")]
        public int? InDeId { get; set; }
        public byte? IsPayment { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
