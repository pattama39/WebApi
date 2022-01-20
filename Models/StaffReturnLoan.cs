using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffReturnLoan")]
    public partial class StaffReturnLoan
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnLoanNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnLoanDate { get; set; }
        [StringLength(20)]
        public string LoanPaymentNo { get; set; }
        public short? ReturnLoanMethod { get; set; }
        public int? ReturnLoanPeriod { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalAmountBeforePay { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ReturnLoanInPeriod { get; set; }
        public double? InterrestPayInPeriod { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmountAfterPay { get; set; }
        [StringLength(20)]
        public string StaffReceiveCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
