using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemPriceTableBranch")]
    public partial class ItemPriceTableBranch
    {
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [StringLength(20)]
        public string PriceLevelCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        public double? MinAmount { get; set; }
        public double? MaxAmount { get; set; }
        public double? Price { get; set; }
        [Key]
        [StringLength(20)]
        public string DepartmentCode { get; set; }
    }
}
