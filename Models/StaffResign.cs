using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffResign")]
    public partial class StaffResign
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ResignNo { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ResignDate { get; set; }
        [Column("ResignTypeID")]
        public int? ResignTypeId { get; set; }
        [StringLength(50)]
        public string Reason { get; set; }
        public byte? IsCalcLastSalary { get; set; }
        [Column("BaseSalaryCalcTypeID")]
        public int? BaseSalaryCalcTypeId { get; set; }
        public byte? IsCalcNonSalaryRevenue { get; set; }
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
    }
}
