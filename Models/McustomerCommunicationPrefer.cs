using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCustomerCommunicationPrefer")]
    public partial class McustomerCommunicationPrefer
    {
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public int CommunicationPrefNo { get; set; }
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
        [Column("IsSMS")]
        public byte? IsSms { get; set; }
        [Column("ReceiveBookingSMS")]
        public byte? ReceiveBookingSms { get; set; }
        public byte? IsEmail { get; set; }
        public byte? ReceiveBookingEmail { get; set; }
        public byte? IsLine { get; set; }
        public byte? ReceiveBookingLine { get; set; }
        public byte? IsFacebook { get; set; }
        public byte? ReceiveBookingFacebook { get; set; }
        public byte? IsTelephone { get; set; }
        public byte? ReceiveBookingTelephone { get; set; }
    }
}
