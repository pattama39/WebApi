using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPaymentType")]
    public partial class MpaymentType
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string PaymentTypeCode { get; set; }
        [StringLength(50)]
        public string PaymentTypeName { get; set; }
        [StringLength(50)]
        public string PaymentTypeName2 { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        public byte? IsCheque { get; set; }
        [Column("PaymentTypeID")]
        public byte? PaymentTypeId { get; set; }
    }
}
