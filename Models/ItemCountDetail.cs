using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemCountDetail")]
    public partial class ItemCountDetail
    {
        [Key]
        [StringLength(20)]
        public string ItemCountNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? QuantitySystem { get; set; }
        public double? QuantityCount { get; set; }
        [StringLength(50)]
        public string UnitCountName { get; set; }
        public double? QuantityDiff { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? IsConfirm { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? CountDate { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("UnitTypeID")]
        public byte? UnitTypeId { get; set; }
    }
}
