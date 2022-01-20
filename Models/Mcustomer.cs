using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCustomer")]
    [Index(nameof(FirstName), Name = "IX_MCustomer")]
    [Index(nameof(LastName), Name = "IX_MCustomer_1")]
    [Index(nameof(CustomerTypeCode), Name = "IX_MCustomer_2")]
    [Index(nameof(CustomerCode), Name = "IX_MCustomer_3")]
    [Index(nameof(ModDate), Name = "IX_MCustomer_4")]
    [Index(nameof(IsSyncToServer), Name = "IX_MCustomer_5")]
    public partial class Mcustomer
    {
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string TitleName2 { get; set; }
        [StringLength(50)]
        public string FirstName2 { get; set; }
        [StringLength(50)]
        public string MiddleName2 { get; set; }
        [StringLength(50)]
        public string LastName2 { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        [StringLength(20)]
        public string NationCode { get; set; }
        [StringLength(20)]
        public string RaceCode { get; set; }
        [StringLength(20)]
        public string ReligionCode { get; set; }
        [StringLength(20)]
        public string MaritalStatusCode { get; set; }
        [StringLength(50)]
        public string SpouseName { get; set; }
        [StringLength(50)]
        public string BloodGroup { get; set; }
        [StringLength(50)]
        public string FatherName { get; set; }
        [StringLength(50)]
        public string FatherPhone { get; set; }
        [StringLength(50)]
        public string MotherName { get; set; }
        [StringLength(50)]
        public string MotherPhone { get; set; }
        [StringLength(20)]
        public string OccupationCode { get; set; }
        [StringLength(50)]
        public string OccupationName { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Website { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        public byte? InActive { get; set; }
        [Column("IDCardNo")]
        [StringLength(20)]
        public string IdcardNo { get; set; }
        [Column("IDCardExpireDate", TypeName = "smalldatetime")]
        public DateTime? IdcardExpireDate { get; set; }
        [Column("TaxIDCardNo")]
        [StringLength(20)]
        public string TaxIdcardNo { get; set; }
        [Column("OtherIDCardNo")]
        [StringLength(50)]
        public string OtherIdcardNo { get; set; }
        [Column("OtherIDType")]
        [StringLength(255)]
        public string OtherIdtype { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(10)]
        public string BirthDateText { get; set; }
        public byte? IsDead { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeadDate { get; set; }
        public byte? IsRealBirthDate { get; set; }
        public byte? IsSideEffect { get; set; }
        [StringLength(255)]
        public string OtherSideEffect { get; set; }
        public double? Height { get; set; }
        public byte? IsFingerPrintScan { get; set; }
        public byte? IsSelfsick { get; set; }
        [Column("CustomerTypeID")]
        public byte? CustomerTypeId { get; set; }
        public byte? IsSystem { get; set; }
        [StringLength(2)]
        public string DefaultLanguage { get; set; }
        [StringLength(50)]
        public string PatientIndex { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastVisitDate { get; set; }
        [StringLength(20)]
        public string DrCode { get; set; }
        public byte? IsPrintMailLabel { get; set; }
        [StringLength(100)]
        public string CurrentAddress1 { get; set; }
        [StringLength(100)]
        public string CurrentAddress2 { get; set; }
        [StringLength(4)]
        public string CurrentAmphurCode { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(6)]
        public string CurrentTumbonCode { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(2)]
        public string CurrentProvinceCode { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [StringLength(20)]
        public string CurrentCountryCode { get; set; }
        [StringLength(50)]
        public string CurrentTelephone { get; set; }
        [Column("IDCardAddress1")]
        [StringLength(50)]
        public string IdcardAddress1 { get; set; }
        [Column("IDCardAddress2")]
        [StringLength(50)]
        public string IdcardAddress2 { get; set; }
        [StringLength(4)]
        public string IdCardAmphurCode { get; set; }
        [Column("IDCardAmphurName")]
        [StringLength(50)]
        public string IdcardAmphurName { get; set; }
        [Column("IDCardTumbonCode")]
        [StringLength(6)]
        public string IdcardTumbonCode { get; set; }
        [Column("IDCardTumbonName")]
        [StringLength(50)]
        public string IdcardTumbonName { get; set; }
        [Column("IDCardProvinceCode")]
        [StringLength(2)]
        public string IdcardProvinceCode { get; set; }
        [Column("IDCardProvinceName")]
        [StringLength(50)]
        public string IdcardProvinceName { get; set; }
        [Column("IDCardPostCode")]
        [StringLength(5)]
        public string IdcardPostCode { get; set; }
        [Column("IDCardCountryCode")]
        [StringLength(20)]
        public string IdcardCountryCode { get; set; }
        [StringLength(255)]
        public string WorkAddress1 { get; set; }
        [StringLength(50)]
        public string WorkAddress2 { get; set; }
        [StringLength(4)]
        public string WorkAmphurCode { get; set; }
        [StringLength(50)]
        public string WorkAmphurName { get; set; }
        [StringLength(6)]
        public string WorkTumbonCode { get; set; }
        [StringLength(50)]
        public string WorkTumbonName { get; set; }
        [StringLength(2)]
        public string WorkProvinceCode { get; set; }
        [StringLength(50)]
        public string WorkProvinceName { get; set; }
        [StringLength(5)]
        public string WorkPostCode { get; set; }
        [StringLength(20)]
        public string WorkCountryCode { get; set; }
        [StringLength(50)]
        public string WorkTelephone { get; set; }
        [Column(TypeName = "text")]
        public string SpecialDrNote { get; set; }
        [StringLength(20)]
        public string CustomerTypeCode { get; set; }
        [StringLength(50)]
        public string ContactPhone { get; set; }
        [StringLength(50)]
        public string ContactMobile { get; set; }
        [StringLength(50)]
        public string PaymentTerm { get; set; }
        [StringLength(50)]
        public string Credit { get; set; }
        [StringLength(50)]
        public string SalesBranch { get; set; }
        [StringLength(50)]
        public string ShipAddress1 { get; set; }
        [StringLength(50)]
        public string ShipAddress2 { get; set; }
        [StringLength(4)]
        public string ShipAmphurCode { get; set; }
        [StringLength(50)]
        public string ShipAmphurName { get; set; }
        [StringLength(6)]
        public string ShipTumbonCode { get; set; }
        [StringLength(50)]
        public string ShipTumbonName { get; set; }
        [StringLength(2)]
        public string ShipProvinceCode { get; set; }
        [StringLength(50)]
        public string ShipProvinceName { get; set; }
        [StringLength(5)]
        public string ShipPostCode { get; set; }
        [StringLength(50)]
        public string ShipMobile { get; set; }
        [StringLength(50)]
        public string ShipTelephone { get; set; }
        [StringLength(20)]
        public string ShipCountryCode { get; set; }
        [Column("MemberID")]
        [StringLength(50)]
        public string MemberId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CreditAmount { get; set; }
        [StringLength(20)]
        public string CustomerCode { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [StringLength(20)]
        public string TransportTypeCode { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [StringLength(20)]
        public string IndustryCode { get; set; }
        [Column(TypeName = "image")]
        public byte[] CustomerMap { get; set; }
        [StringLength(20)]
        public string PriceLevelCode { get; set; }
        [StringLength(50)]
        public string ContactEmail { get; set; }
        [StringLength(20)]
        public string MediaSourceCode { get; set; }
        public byte? IsSyncFromServer { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsLock { get; set; }
        [StringLength(50)]
        public string LockReason { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastSyncDate { get; set; }
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [StringLength(50)]
        public string Remark2 { get; set; }
        public double? ReserveAmount { get; set; }
        [StringLength(20)]
        public string ReceiptCode { get; set; }
        [StringLength(255)]
        public string CompanyName { get; set; }
        [StringLength(255)]
        public string CompanyAddress { get; set; }
        [StringLength(20)]
        public string TaxCompanyNo { get; set; }
        [StringLength(50)]
        public string ContactRelation { get; set; }
        [Column(TypeName = "text")]
        public string ContactAddress { get; set; }
        [StringLength(255)]
        public string ImageDirectory { get; set; }
        public byte? IsOldPatient { get; set; }
        public byte? IsCustomer { get; set; }
        [Column("SpouseGID")]
        [StringLength(36)]
        public string SpouseGid { get; set; }
        [StringLength(10)]
        public string TaxOrgCode { get; set; }
        [StringLength(50)]
        public string TaxOrgName { get; set; }
        public int? CreditTerm { get; set; }
        [Column("DebtTypeID")]
        public byte? DebtTypeId { get; set; }
        [StringLength(20)]
        public string CounsellorCode { get; set; }
        public double? CurrentPoint { get; set; }
        public byte? IsLockByIzpalMember { get; set; }
        [StringLength(255)]
        public string RemarkIsLock { get; set; }
        [StringLength(20)]
        public string AgencyCode { get; set; }
        [Column("OtherIDCardExpireDate", TypeName = "smalldatetime")]
        public DateTime? OtherIdcardExpireDate { get; set; }
        [Column("InActiveTypeID")]
        public byte? InActiveTypeId { get; set; }
        public double? Weight { get; set; }
        [Column("MemberGID")]
        [StringLength(36)]
        public string MemberGid { get; set; }
        public byte? PolicyNotice { get; set; }
        public byte? IsMarketingConsent { get; set; }
        [StringLength(50)]
        public string PayerName { get; set; }
        [Column("PayerTaxIDCardNo")]
        [StringLength(20)]
        public string PayerTaxIdcardNo { get; set; }
        [StringLength(255)]
        public string PayerAddress { get; set; }
        [StringLength(5)]
        public string PayerZipCode { get; set; }
        [StringLength(50)]
        public string PayerContactMobile { get; set; }
        [StringLength(255)]
        public string FoodAllergy { get; set; }
        [StringLength(255)]
        public string OtherAllergy { get; set; }
        [StringLength(50)]
        public string HospialName { get; set; }
        [StringLength(50)]
        public string HospialTelephone { get; set; }
        [StringLength(255)]
        public string CounsellorNote { get; set; }
    }
}
