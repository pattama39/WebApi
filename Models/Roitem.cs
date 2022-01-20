using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ROItem")]
    [Index(nameof(ItemCode), Name = "IX_ROItem")]
    [Index(nameof(IsSyncToServer), Name = "IX_ROItem_1")]
    public partial class Roitem
    {
        [Key]
        [Column("RONo")]
        [StringLength(20)]
        public string Rono { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        public double? Quantity { get; set; }
        public double? UnitCost { get; set; }
        [StringLength(20)]
        public string LocationCode { get; set; }
        public int? LotNoI { get; set; }
        [StringLength(50)]
        public string LotNoE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        public byte? IsFree { get; set; }
        public double? SellCost { get; set; }
        public byte? IsExpense { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DiscountAmount { get; set; }
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
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column("POSeqID")]
        public int? PoseqId { get; set; }
        [Column("FDAAnalyzeNo")]
        [StringLength(50)]
        public string FdaanalyzeNo { get; set; }
        [Column("FDALotNo")]
        [StringLength(50)]
        public string FdalotNo { get; set; }
        public double? NetAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        public byte? IsSales { get; set; }
        public byte? IsCalVat { get; set; }
        public double? CutQty { get; set; }
        [Column("RODate", TypeName = "smalldatetime")]
        public DateTime? Rodate { get; set; }
        public double? SalesQty { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string UnitCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(100)]
        public string Manufacturer { get; set; }
        [Column("ReturnToVendorQTY")]
        public double? ReturnToVendorQty { get; set; }
    }
}
