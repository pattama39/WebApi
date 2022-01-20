using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerMemberCard")]
    public partial class CustomerMemberCard
    {
        [Key]
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [StringLength(50)]
        public string CardNumber { get; set; }
        [StringLength(15)]
        public string CardTypeCode { get; set; }
        [StringLength(50)]
        public string PinCode { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SubscriptionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        [Column("SeqID")]
        public int? SeqId { get; set; }
        public double? CreditLimit { get; set; }
        public double? ExistingCredit { get; set; }
        public byte? IsUnExpire { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsUnLimitCredit { get; set; }
        public byte? IsExpire { get; set; }
        public byte? IsStartDateExpire { get; set; }
        public int? ExpireDay { get; set; }
    }
}
