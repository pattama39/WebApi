using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffIncomeDeductTemplate")]
    public partial class StaffIncomeDeductTemplate
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("InDeID")]
        public int InDeId { get; set; }
        [Required]
        [StringLength(50)]
        public string StaffCode { get; set; }
        [StringLength(10)]
        public string InDeCode { get; set; }
        public byte? PeriodNo { get; set; }
        public int? PeriodYear { get; set; }
        [Column(TypeName = "numeric(9, 2)")]
        public decimal? Amount { get; set; }
        public int? LeftPeriod { get; set; }
        public short? IsSystem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
