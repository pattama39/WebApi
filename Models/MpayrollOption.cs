using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPayrollOptions")]
    public partial class MpayrollOption
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public float? TotalHourForMonthStaff { get; set; }
        public float? TotalHourForDayStaff { get; set; }
        public int? CurrentYear { get; set; }
        [Column("OT1")]
        public float? Ot1 { get; set; }
        [Column("OT2")]
        public float? Ot2 { get; set; }
        [Column("OT3")]
        public float? Ot3 { get; set; }
        [Column("OT4")]
        public float? Ot4 { get; set; }
        public float? SociMinIncome { get; set; }
        public float? SociMaxIncome { get; set; }
        public float? SociMinDeduct { get; set; }
        public float? SociMaxDeduct { get; set; }
        public float? SociRate { get; set; }
        public int? CurrentPeriod { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartSystemDate { get; set; }
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
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        public float? TaxdeSpendMaxPercent { get; set; }
        public float? TaxdeSpendMax { get; set; }
        public float? TaxdePayerMax { get; set; }
        public float? TaxdeSpouseMax { get; set; }
        public float? TaxdeChildStudyMax { get; set; }
        public float? TaxdeChildNotStudyMax { get; set; }
        public float? TaxdeDadMax { get; set; }
        public float? TaxdeMomMax { get; set; }
        public float? TaxdeDadSpouseMax { get; set; }
        public float? TaxdeMomSpouseMax { get; set; }
        public float? TaxdeDadMomHealthInsuranceMax { get; set; }
        public float? TaxdeLifeInsuranceFirstPartMax { get; set; }
        public float? TaxdeLifeInsuranceSecondPartMax { get; set; }
        public float? TaxdeProvidentFundMax { get; set; }
        public float? TaxdeStockProvidentFundMaxPercent { get; set; }
        public float? TaxdeStockProvidentFundMax { get; set; }
        public float? TaxdeStockLongPeriodMaxPercent { get; set; }
        public float? TaxdeStockLongPeriodMax { get; set; }
        public float? TaxdeHouseLoanInterestMax { get; set; }
        public float? TaxdeSocialMax { get; set; }
        public float? TaxdeDonateEduRatio { get; set; }
        public float? TaxdeDonateEduMaxPercent { get; set; }
        public float? TaxdeDonateSportRatio { get; set; }
        public float? TaxdeDonateSportMaxPercent { get; set; }
        public float? TaxdeDonateMax { get; set; }
        public float? TaxdeDadMomSpouseHealthInsuranceMax { get; set; }
        public short? TaxCalcMethod { get; set; }
        [StringLength(1)]
        public string TaxBookNo { get; set; }
        [StringLength(1)]
        public string BankAccountNo { get; set; }
        [StringLength(1)]
        public string BankCode { get; set; }
        [StringLength(1)]
        public string BankBranchCode { get; set; }
        public short? TotalPeriodStaffHour { get; set; }
        public short? TotalPeriodStaffDay { get; set; }
        public short? TotalPeriodStaffMonth { get; set; }
        public short? TotalPeriodStaffContract { get; set; }
        public float? DeductForLateBahtPerHour { get; set; }
        public float? DeductForAbsentBahtPerDay { get; set; }
        public int? TotalLateBecome2Absent { get; set; }
        public int? TaxdeChildMax { get; set; }
        [Column("RoundUpTAX")]
        [StringLength(50)]
        public string RoundUpTax { get; set; }
        [StringLength(50)]
        public string RoundUpSoci { get; set; }
        [StringLength(50)]
        public string RoundUpProvident { get; set; }
        [Column("RoundUpOT")]
        [StringLength(50)]
        public string RoundUpOt { get; set; }
        public double? ProvidentFundCompanyRate { get; set; }
        [Column("PSPercentCenter1")]
        public float? PspercentCenter1 { get; set; }
        [Column("PSPercentCenter2")]
        public float? PspercentCenter2 { get; set; }
        [Column("PSPercentCenter4Staff")]
        public float? PspercentCenter4Staff { get; set; }
        [Column("PSPercentCenter4Manager")]
        public float? PspercentCenter4Manager { get; set; }
        [Column("PSPercentOver1M")]
        public float? PspercentOver1M { get; set; }
        [Column("PSPercentDeligent1")]
        public float? PspercentDeligent1 { get; set; }
        [Column("PSPercentDeligent2")]
        public float? PspercentDeligent2 { get; set; }
        [Column("PSDeMissItemFrom")]
        [StringLength(100)]
        public string PsdeMissItemFrom { get; set; }
        [Column("PSDeLeaveFrom")]
        [StringLength(100)]
        public string PsdeLeaveFrom { get; set; }
        [Column("PSDeLateFrom")]
        [StringLength(100)]
        public string PsdeLateFrom { get; set; }
        [Column("PSDeOtherFrom")]
        [StringLength(100)]
        public string PsdeOtherFrom { get; set; }
        [Column("PSOTPerDay")]
        public int? PsotperDay { get; set; }
        [Column("OT5")]
        public float? Ot5 { get; set; }
        [Column("PSFixSociSalary")]
        public float? PsfixSociSalary { get; set; }
        [Column("PSFixSociDeduct")]
        public float? PsfixSociDeduct { get; set; }
        [Column("PSIsUseNormalSocialCalc")]
        public short? PsisUseNormalSocialCalc { get; set; }
        [Column("PSPercentOver1MStep1")]
        public float? PspercentOver1Mstep1 { get; set; }
        [Column("PSPercentOver1MStep2")]
        public float? PspercentOver1Mstep2 { get; set; }
        [Column("PSPercentOver1MStep3")]
        public float? PspercentOver1Mstep3 { get; set; }
        [Column("PSPercentOver1MStep4")]
        public float? PspercentOver1Mstep4 { get; set; }
        [Column("PSPercentOver1MStep5")]
        public float? PspercentOver1Mstep5 { get; set; }
        public int? CurrentPeriodDaily { get; set; }
        public int? CurrentPeriodMonthly { get; set; }
        public int? CurrentPeriodContract { get; set; }
        public int? CurrentPeriodHourly { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
