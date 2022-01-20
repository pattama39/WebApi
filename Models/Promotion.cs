using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Promotion")]
    public partial class Promotion
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [StringLength(50)]
        public string RightCode { get; set; }
        [StringLength(50)]
        public string PromotionName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BeginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("PromotionTypeID")]
        public int? PromotionTypeId { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? SalesQuantity { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? FreeQuantity { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? FreeQuantityBrand { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        public byte? IsMonday { get; set; }
        public byte? IsTuesday { get; set; }
        public byte? IsWednesday { get; set; }
        public byte? IsThursday { get; set; }
        public byte? IsFriday { get; set; }
        public byte? IsSaturday { get; set; }
        public byte? IsSunday { get; set; }
        public byte? IsUnExpire { get; set; }
        public byte? IsOneTimePromotion { get; set; }
        public byte? IsUseWithVoucher { get; set; }
        public byte? IsDiscountable { get; set; }
        [Column("IsCanEditFreeQTY")]
        public byte? IsCanEditFreeQty { get; set; }
        public byte? IsUseWithMember { get; set; }
        [StringLength(50)]
        public string MemberCode { get; set; }
        [StringLength(20)]
        public string Barcode { get; set; }
    }
}
