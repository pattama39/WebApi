using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class PromotionItemSale
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(50)]
        public string ItemGroupCode { get; set; }
        [StringLength(20)]
        public string BarCode { get; set; }
        public double? SalesQuantity { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string PriceLevelCode { get; set; }
        [Column("PromotionTypeID")]
        public int? PromotionTypeId { get; set; }
        [StringLength(20)]
        public string BrandCode { get; set; }
        public double? AmountPromotion { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? FromPrice { get; set; }
    }
}
