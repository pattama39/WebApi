using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PromotionItemGroup")]
    public partial class PromotionItemGroup
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ItemGroupCode { get; set; }
        [StringLength(20)]
        public string PriceLevelCode { get; set; }
        [StringLength(10)]
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
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Key]
        public int ReferenceIndex { get; set; }
    }
}
