using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StockCard")]
    public partial class StockCard
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("StockCardID")]
        public int StockCardId { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column("DocTypeID")]
        public int? DocTypeId { get; set; }
        [Column("SeqID")]
        public short? SeqId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        public double? QuantityIn { get; set; }
        public double? QuantityOut { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitRatio { get; set; }
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
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(255)]
        public string Remark2 { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
        [Column("CurrentQTY")]
        public double? CurrentQty { get; set; }
        public double? UnitCost { get; set; }
        public double? AverageCost { get; set; }
        public double? FixCost { get; set; }
        public double? ReplaceCost { get; set; }
        [Column("FIFOCost")]
        public double? Fifocost { get; set; }
        public byte? IsFinish { get; set; }
        public byte? IsDone { get; set; }
        [Column("RefStockCardID")]
        public int? RefStockCardId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
    }
}
