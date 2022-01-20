using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCardType")]
    public partial class McardType
    {
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CardTypeCode { get; set; }
        [StringLength(20)]
        public string CardTypeName { get; set; }
        public double? InitialPoint { get; set; }
        public double? InitialMoney { get; set; }
        public int? CardAge { get; set; }
        public double? CardPoint { get; set; }
    }
}
