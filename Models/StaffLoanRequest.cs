using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffLoanRequest")]
    public partial class StaffLoanRequest
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string LoanRequestNo { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LoanRequestDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? IncomePerPeriod { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CurrentDebt { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DeductDebtPerPeriod { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalAmountLoan { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
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
        public byte? IsUse { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
