using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MStaffTaxDeduct")]
    public partial class MstaffTaxDeduct
    {
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public float? LowIncome { get; set; }
        public float? ExpenseDeduct { get; set; }
        public float? ExpenseMax { get; set; }
        public float? PersonalExpense { get; set; }
        public float? MaritalExpense { get; set; }
        public float? NonEduSon { get; set; }
        public float? EduSon { get; set; }
        public float? InsuranceDeduct { get; set; }
        public float? InterestDeduct { get; set; }
        public float? Donate { get; set; }
        public float? TaxDeduct { get; set; }
        [Column("RMF")]
        public float? Rmf { get; set; }
        public float? MaritalInsure { get; set; }
        public float? ProWorkYear { get; set; }
        public float? Provident { get; set; }
        public float? CalOverPro { get; set; }
        public float? AddMeanMoney { get; set; }
        public float? MeanPercent { get; set; }
        public float? SocailWellfare { get; set; }
        public float? BaseSalary { get; set; }
        public float? LowMoneyDeduct { get; set; }
        public float? SocialWelfareDeduct { get; set; }
        public float? ProvidentDeduct { get; set; }
        public float? WageYear { get; set; }
        public float? FatherDeduct { get; set; }
        public float? MotherDeduct { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public float? MarryExpense { get; set; }
        public float? MarryInsure { get; set; }
        [StringLength(50)]
        public string FatherSpouse { get; set; }
        [StringLength(50)]
        public string MotherSpouse { get; set; }
        public float? OverTax { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
