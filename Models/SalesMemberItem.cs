using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalesMemberItem")]
    public partial class SalesMemberItem
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Key]
        [StringLength(20)]
        public string SalesMemberCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        public double? AddMoney { get; set; }
        public double? UseMoney { get; set; }
        public double? AddPoint { get; set; }
        public double? RedeemPoint { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(2)]
        public string LogTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
