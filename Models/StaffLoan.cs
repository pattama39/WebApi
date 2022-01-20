using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffLoan")]
    public partial class StaffLoan
    {
        [Key]
        [Column("LoanID")]
        public int LoanId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string ContractNo { get; set; }
        public float? TotalLoan { get; set; }
        public float? TotalNetLoan { get; set; }
        public float? TotalDeductPerPeriod { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        public int? LoanYear { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? LoanDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
