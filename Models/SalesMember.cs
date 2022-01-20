using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalesMember")]
    public partial class SalesMember
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string SaleMemberCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(50)]
        public string CardCode { get; set; }
        public double? CurrentMoney { get; set; }
        public double? TotalUseMoney { get; set; }
        public double? TotalRefillMoney { get; set; }
        public double? CurrentPoint { get; set; }
        public double? TotalRedeemPoint { get; set; }
        public double? TotalRecievePoint { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? ToTalPoint { get; set; }
        public double? ToTalAddMoney { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        public double? TaTalRedeem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModTime { get; set; }
    }
}
