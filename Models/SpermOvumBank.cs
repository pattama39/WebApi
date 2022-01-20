using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SpermOvumBank")]
    public partial class SpermOvumBank
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DepositNo { get; set; }
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
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("DepositTypeID")]
        public byte? DepositTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DepositDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        [Column(TypeName = "text")]
        public string DepositNote { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "image")]
        public byte[] DepositImage { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("SpouseGID")]
        [StringLength(36)]
        public string SpouseGid { get; set; }
        [Column(TypeName = "text")]
        public string DestroyDepositNote { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DestroyDate { get; set; }
        public byte? IsDestroy { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
    }
}
