using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MExpense")]
    public partial class Mexpense
    {
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Required]
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        public string ItemName { get; set; }
        [StringLength(20)]
        public string ItemGroupCode { get; set; }
        [Column("ItemTypeID")]
        public short? ItemTypeId { get; set; }
        public byte? IsCalVatPurchase { get; set; }
        public double? AverageCost { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? IndexCost { get; set; }
        public byte? IsCalCost { get; set; }
        public byte? IsCalRevenue { get; set; }
        public byte? ApproveLevel { get; set; }
        [StringLength(20)]
        public string ItemStockFormatCode { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(255)]
        public string ItemName2 { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string ItemCode2 { get; set; }
    }
}
