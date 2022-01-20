using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("POItem")]
    [Index(nameof(ItemCode), Name = "IX_POItem")]
    public partial class Poitem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PONo")]
        [StringLength(20)]
        public string Pono { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
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
        [Column("PRNoText")]
        [StringLength(255)]
        public string PrnoText { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        public double? UnitCost { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public byte? IsFree { get; set; }
        [Column("ROQuantity")]
        public double? Roquantity { get; set; }
        public double? NetAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public byte? IsCalVat { get; set; }
        [Column("PODate", TypeName = "smalldatetime")]
        public DateTime? Podate { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? StockMin { get; set; }
        public double? StockMax { get; set; }
        [Column("CurrentQTY")]
        public double? CurrentQty { get; set; }
        [Column("ActualQTY")]
        public double? ActualQty { get; set; }
        [Column("PRSeqID")]
        public int? PrseqId { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
    }
}
