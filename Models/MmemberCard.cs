using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MMemberCard")]
    public partial class MmemberCard
    {
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CardTypeCode { get; set; }
        [StringLength(50)]
        public string CardTypeName1 { get; set; }
        [StringLength(50)]
        public string CardTypeName2 { get; set; }
        public double? InitialMoney { get; set; }
        public double? InitialPoint { get; set; }
        public double? PointRate { get; set; }
        public byte? InActive { get; set; }
        public short? MaxDayLifeCard { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
    }
}
