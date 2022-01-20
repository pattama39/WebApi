using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPackageItem")]
    public partial class MpackageItem
    {
        [Key]
        [StringLength(50)]
        public string PackageCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string Dose1 { get; set; }
        [StringLength(50)]
        public string Dose2 { get; set; }
        [StringLength(50)]
        public string Dose3 { get; set; }
        [StringLength(50)]
        public string Dose4 { get; set; }
        [StringLength(50)]
        public string Dose5 { get; set; }
        [StringLength(50)]
        public string Dose6 { get; set; }
        [StringLength(255)]
        public string DoseText { get; set; }
        public double? UnitPrice { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? UnitCost { get; set; }
        public double? IncentiveSellRate { get; set; }
        public double? IncentiveSellFix { get; set; }
        public double? IncentiveDoRate { get; set; }
        public double? IncentiveDoFix { get; set; }
        public double? IncentiveDiagRate { get; set; }
        public double? IncentiveDiagFix { get; set; }
        public double? IncentiveAllRate { get; set; }
        public double? IncentiveAllFix { get; set; }
        public double? Total { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        public int? SubCourseAmount { get; set; }
        public byte? IsCanEditFeeQty { get; set; }
        [StringLength(20)]
        public string DiscountTypeCode { get; set; }
        [StringLength(50)]
        public string DiscountCode { get; set; }
        [StringLength(255)]
        public string DiscountDetail { get; set; }
        [Column("QuantityTypeID")]
        public byte? QuantityTypeId { get; set; }
        public byte? IsFree { get; set; }
        [Column("ItemPriceSeqID")]
        public int? ItemPriceSeqId { get; set; }
    }
}
