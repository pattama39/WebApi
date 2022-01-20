using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffTaxTemplate")]
    public partial class StaffTaxTemplate
    {
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
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
        public short? CalcMethod { get; set; }
        public float? IncomeFromOldCompany { get; set; }
        public float? TaxFromOldCompany { get; set; }
        public float? IncomeSpouse { get; set; }
        public short? ChildEdu { get; set; }
        public short? ChildNotEdu { get; set; }
        public byte? IsDeductDad { get; set; }
        public byte? IsDeductMom { get; set; }
        public byte? IsDeductDadSpouse { get; set; }
        public byte? IsDeductMomSpouse { get; set; }
        [Column("DadIDCard")]
        [StringLength(50)]
        public string DadIdcard { get; set; }
        [Column("MomIDCard")]
        [StringLength(50)]
        public string MomIdcard { get; set; }
        [Column("DadIDCardSpouse")]
        [StringLength(50)]
        public string DadIdcardSpouse { get; set; }
        [Column("MomIDCardSpouse")]
        [StringLength(50)]
        public string MomIdcardSpouse { get; set; }
        public byte? IsHealthDadInsure { get; set; }
        public byte? IsHealthMomInsure { get; set; }
        public byte? IsHealthDadSpouseInsure { get; set; }
        public byte? IsHealthMomSpouseInsure { get; set; }
        public float? AmountHealthInsure { get; set; }
        public float? AmountHealthSpouseInsure { get; set; }
        public float? AmountLifeInsure { get; set; }
        public float? AmountLifeSpouseInsure { get; set; }
        public float? AmountStockProvident { get; set; }
        public float? AmountStockLongPeriod { get; set; }
        public float? AmountInterestHouse { get; set; }
        public float? AmountDonateEdu { get; set; }
        public float? AmountDonateSport { get; set; }
        public float? AmountDonate { get; set; }
        public float? IncomeFromOldCompanyBak { get; set; }
        public float? TaxFromOldCompanyBak { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SpouseBirthDate { get; set; }
        [Column("SpouseIDCard")]
        [StringLength(100)]
        public string SpouseIdcard { get; set; }
        [StringLength(100)]
        public string SpouseName { get; set; }
        [StringLength(100)]
        public string SpouseSurname { get; set; }
        [StringLength(100)]
        public string SpouseTaxNo { get; set; }
        public float? IncomeFromOldCompanyIgnorePeriod { get; set; }
        public float? IncomeFromOldCompanyIgnorePeriodBak { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
