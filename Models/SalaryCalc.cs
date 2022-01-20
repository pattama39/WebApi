using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalaryCalc")]
    public partial class SalaryCalc
    {
        [Key]
        [Column("SalaryCalcID")]
        public long SalaryCalcId { get; set; }
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
        public int? CalcPeriod { get; set; }
        public int? CalcYear { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string StaffPayType { get; set; }
        public float? TotalLeaveDay { get; set; }
        public float? TotalLeaveHour { get; set; }
        public float? TotalDayForCalc { get; set; }
        public float? TotalHourForCalc { get; set; }
        public float? TotalJobForCalc { get; set; }
        public float? BaseSalary { get; set; }
        public float? BaseIncome { get; set; }
        public float? IncomeBeforTax { get; set; }
        public float? IncomeBeforSocial { get; set; }
        [Column("IncomeBeforOT")]
        public float? IncomeBeforOt { get; set; }
        public float? IncomeBeforProvidentFund { get; set; }
        public float? TotalIncomeForThisPeriod { get; set; }
        public float? TotalDeductForThisPeriod { get; set; }
        public float? IncomeNetAmount { get; set; }
        public int? CalcForMonth { get; set; }
        public float? IncomeBeforTaxTaxIgnorePeriod { get; set; }
        [Column("PongSakSalaryOT")]
        public float? PongSakSalaryOt { get; set; }
        public float? PongSakMoneyBank1 { get; set; }
        public float? PongSakMoneyBank2 { get; set; }
        [Column("SalaryAndOT", TypeName = "numeric(18, 0)")]
        public decimal? SalaryAndOt { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? IncomeBeforeTaxTaxIgnorePeriod { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
