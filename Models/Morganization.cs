using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MOrganization")]
    [Index(nameof(OrganizationName), Name = "IX_MOrganization", IsUnique = true)]
    public partial class Morganization
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(10)]
        public string OrganizationOfficialCode { get; set; }
        [StringLength(50)]
        public string OrganizationName { get; set; }
        [StringLength(50)]
        public string OrganizationName2 { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string JoinPassword { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [Column("OrganizationID")]
        [StringLength(50)]
        public string OrganizationId { get; set; }
        [Column("OrganizationTaxID")]
        [StringLength(50)]
        public string OrganizationTaxId { get; set; }
        [Column("IsTransferItemByPROnly")]
        public byte? IsTransferItemByPronly { get; set; }
        [Column("DepreciationMethodID")]
        public byte? DepreciationMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginPeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartSystemDate { get; set; }
        [Column("RevenueTaxTypeID")]
        public byte? RevenueTaxTypeId { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TaxRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? TaxMinBase { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? VatRate { get; set; }
        public int? InventoryCostType { get; set; }
        [Column("InventoryPostTypeID")]
        public int? InventoryPostTypeId { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(20)]
        public string TaxCardNo { get; set; }
        [StringLength(20)]
        public string CommercialNo { get; set; }
        [Column("OrganizationTypeID")]
        public int? OrganizationTypeId { get; set; }
        [StringLength(20)]
        public string CurrentcyCode { get; set; }
        [StringLength(20)]
        public string DefaultLanguage { get; set; }
        [StringLength(50)]
        public string BusinessName { get; set; }
        [StringLength(50)]
        public string BusinessName2 { get; set; }
        [StringLength(20)]
        public string OrganizationTaxCode { get; set; }
        [StringLength(20)]
        public string SocialInsuranceCode { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(20)]
        public string ProvidentFundCode { get; set; }
        public int? WorkHoursSalary { get; set; }
        public int? WorkHoursDay { get; set; }
        public int? CurrentYear { get; set; }
        [StringLength(20)]
        public string LateCode { get; set; }
        [StringLength(20)]
        public string LeaveCode { get; set; }
        [StringLength(20)]
        public string TaxDocNo { get; set; }
        [StringLength(20)]
        public string RevenueTax { get; set; }
        public float? TaxCal { get; set; }
        [StringLength(50)]
        public string Disc { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(255)]
        public string CurrentAddress1 { get; set; }
        [StringLength(255)]
        public string CurrentAddress2 { get; set; }
        [StringLength(50)]
        public string CurrentRoad { get; set; }
        [StringLength(50)]
        public string CurrentRoad2 { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName2 { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName2 { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName2 { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [StringLength(5)]
        public string CurrentPostCode2 { get; set; }
        [StringLength(50)]
        public string CurrentTelephone { get; set; }
        [StringLength(50)]
        public string CurrentTelephone2 { get; set; }
        [StringLength(50)]
        public string CurrentFax { get; set; }
        [StringLength(50)]
        public string CurrentFax2 { get; set; }
        [StringLength(255)]
        public string CurrentEmail { get; set; }
        [StringLength(255)]
        public string CurrentWebSite { get; set; }
        [StringLength(50)]
        public string LanguageType { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }
        public int? MaximumStaff { get; set; }
        [StringLength(50)]
        public string ExchangeUserName { get; set; }
        [StringLength(50)]
        public string ExchangeUserPassword { get; set; }
        public int? RegisterCredit { get; set; }
        public int? RegisterCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastRegisterDate { get; set; }
        public byte? IsUseSecurity { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastSyncDateTime { get; set; }
        public double? NotSyncDataAmount { get; set; }
        public double? ShowAbsoluteDateReport { get; set; }
        public byte? IsAutoLiveUpdate { get; set; }
        [StringLength(50)]
        public string LicenseNoForAnimalNursing { get; set; }
        [StringLength(50)]
        public string LicenseNoForAnimalHospital { get; set; }
        public int? DeleteAppointment { get; set; }
        [StringLength(50)]
        public string HospitalName { get; set; }
        [StringLength(50)]
        public string BusinessAddress1 { get; set; }
        [StringLength(50)]
        public string BusinessAddress2 { get; set; }
        [StringLength(50)]
        public string BusinessRoad { get; set; }
        [StringLength(50)]
        public string BusinessRoad2 { get; set; }
        [StringLength(50)]
        public string BusinessTumbonName { get; set; }
        [StringLength(50)]
        public string BusinessTumbonName2 { get; set; }
        [StringLength(50)]
        public string BusinessAmphurName { get; set; }
        [StringLength(50)]
        public string BusinessAmphurName2 { get; set; }
        [StringLength(50)]
        public string BusinessProvinceName { get; set; }
        [StringLength(50)]
        public string BusinessProvinceName2 { get; set; }
        [StringLength(5)]
        public string BusinessPostCode { get; set; }
        [StringLength(5)]
        public string BusinessPostCode2 { get; set; }
        [StringLength(50)]
        public string BusinessTelephone { get; set; }
        [StringLength(50)]
        public string BusinessTelephone2 { get; set; }
        [StringLength(50)]
        public string BusinessFax { get; set; }
        [StringLength(50)]
        public string BusinessFax2 { get; set; }
        [StringLength(255)]
        public string BusinessEmail { get; set; }
        [StringLength(255)]
        public string BusinessWebSite { get; set; }
    }
}
