using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CutStock")]
    public partial class CutStock
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CutStockNo { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CutStockReasonCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CutStockDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatRate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
