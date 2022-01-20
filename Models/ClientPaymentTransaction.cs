using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class ClientPaymentTransaction
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(20)]
        public string PaymentNo { get; set; }
        [Column("PaymentTypeID")]
        public byte? PaymentTypeId { get; set; }
        [Column("PaymentChannelTypeID")]
        public byte? PaymentChannelTypeId { get; set; }
        [Column("PaymentStatusID")]
        public byte? PaymentStatusId { get; set; }
        public double? PaymentAmount { get; set; }
    }
}
