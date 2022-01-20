using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MInventoryOptions")]
    public partial class MinventoryOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastEndMonthDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsShowLastOrderQtyWhenOrder { get; set; }
        [StringLength(1)]
        public string OneText { get; set; }
        [StringLength(1)]
        public string TwoText { get; set; }
        [StringLength(1)]
        public string ThreeText { get; set; }
        [StringLength(1)]
        public string FourText { get; set; }
        [StringLength(1)]
        public string FiveText { get; set; }
        [StringLength(1)]
        public string SixText { get; set; }
        [StringLength(1)]
        public string SevenText { get; set; }
        [StringLength(1)]
        public string EightText { get; set; }
        [StringLength(1)]
        public string NineText { get; set; }
        [StringLength(1)]
        public string ZeroText { get; set; }
        [StringLength(1)]
        public string DotText { get; set; }
        public double? StockMaxDays { get; set; }
        public double? StockMinDays { get; set; }
        public double? StockCalDays { get; set; }
        [Column("CutStockTypeID")]
        public byte? CutStockTypeId { get; set; }
        public byte? IsUsePasswordOpenShelf { get; set; }
    }
}
