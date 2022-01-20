using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CutStockItem")]
    public partial class CutStockItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CutStockNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? UnitCost { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountAmount { get; set; }
        [StringLength(50)]
        public string TotalAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CutStockDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
