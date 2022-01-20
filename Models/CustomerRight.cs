using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerRight")]
    public partial class CustomerRight
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [Column("VN")]
        public double Vn { get; set; }
        [Key]
        [StringLength(20)]
        public string RightCode { get; set; }
        [StringLength(50)]
        public string RightName { get; set; }
        [StringLength(20)]
        public string RightNo { get; set; }
        [Column("RightStatusID")]
        public byte? RightStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? CreditLimit { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? ExistingCredit { get; set; }
        [StringLength(50)]
        public string HospitalCode { get; set; }
        public byte? IsUseRight { get; set; }
        [Column("SeqID")]
        public short? SeqId { get; set; }
        [Column("LimitByVN", TypeName = "numeric(18, 5)")]
        public decimal? LimitByVn { get; set; }
        [Column("IsReverseToHN")]
        public byte? IsReverseToHn { get; set; }
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
        public byte? IsUnLimitCredit { get; set; }
        public double? RightAmountPerDay { get; set; }
        [StringLength(50)]
        public string RightName2 { get; set; }
    }
}
