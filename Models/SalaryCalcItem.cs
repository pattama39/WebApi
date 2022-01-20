using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalaryCalcItem")]
    public partial class SalaryCalcItem
    {
        [Key]
        [Column("SalaryCalcItemID")]
        public long SalaryCalcItemId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public short? IsSystem { get; set; }
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
        [Column("SalaryCalcID")]
        public long? SalaryCalcId { get; set; }
        public int? ItemNo { get; set; }
        [StringLength(20)]
        public string InDeCode { get; set; }
        [StringLength(50)]
        public string InDeName { get; set; }
        [StringLength(50)]
        public string InDeDisplay { get; set; }
        public short? IsDeduct { get; set; }
        public float? TotalAmount { get; set; }
        public short? IsCalcTax { get; set; }
        [StringLength(1)]
        public string Tag1 { get; set; }
        [StringLength(1)]
        public string Tag2 { get; set; }
        public float? TagNum1 { get; set; }
        public float? TagNum2 { get; set; }
        public short? IsIgnorePeriod { get; set; }
        [StringLength(255)]
        public string InDeDetail { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
