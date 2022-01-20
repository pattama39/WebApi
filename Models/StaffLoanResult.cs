using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffLoanResult")]
    public partial class StaffLoanResult
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string LoanResultNo { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string LoanRequestNo { get; set; }
        [StringLength(20)]
        public string StaffApproveCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LoanResultDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalLoanApprove { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ReturnAmountPerPeriod { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? InterrestPerPeriod { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public int? ReceiveLoanMethod { get; set; }
        [StringLength(20)]
        public string IncomeCode { get; set; }
        public int? IncomePeriod { get; set; }
        public int? ReturnLoanMethod { get; set; }
        [StringLength(20)]
        public string DeductCode { get; set; }
        public int? DeductPeriod { get; set; }
        [StringLength(20)]
        public string DeductInterrestCode { get; set; }
        public int? PayInterrestInPeriod { get; set; }
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
