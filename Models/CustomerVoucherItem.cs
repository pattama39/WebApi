using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerVoucherItem")]
    public partial class CustomerVoucherItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? CreditLimit { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? ExistingCredit { get; set; }
        [Column("LimitByVN", TypeName = "numeric(18, 5)")]
        public decimal? LimitByVn { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsUnExpire { get; set; }
        public byte? InActive { get; set; }
        [StringLength(20)]
        public string SalesNoFromSalesItem { get; set; }
        [Column("SeqIDFromSalesItem")]
        public short? SeqIdfromSalesItem { get; set; }
        [StringLength(50)]
        public string ItemCodeFromSalesItem { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? CreditIn { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? CreditOut { get; set; }
        [Column("VoucherTypeID")]
        public byte? VoucherTypeId { get; set; }
        [Key]
        public int RunningNo { get; set; }
    }
}
