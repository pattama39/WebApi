using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MVendor")]
    public partial class Mvendor
    {
        [Key]
        [StringLength(20)]
        public string VendorCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [StringLength(50)]
        public string VendorGroupCode { get; set; }
        [StringLength(20)]
        public string VendorTypeCode { get; set; }
        [StringLength(50)]
        public string TelNo { get; set; }
        [StringLength(50)]
        public string FaxNo { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Website { get; set; }
        [StringLength(50)]
        public string MobileNo { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [StringLength(20)]
        public string TransportTypeCode { get; set; }
        [Column("PaymentMethodID")]
        public int? PaymentMethodId { get; set; }
        [StringLength(255)]
        public string TermsOfPayment { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CreditLine { get; set; }
        [StringLength(50)]
        public string ConstraintText { get; set; }
        [Column("TaxTypeID")]
        public byte? TaxTypeId { get; set; }
        [Column(TypeName = "numeric(9, 5)")]
        public decimal? TaxRate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(5, 2)")]
        public decimal? VatRate { get; set; }
        [StringLength(50)]
        public string CustomText1 { get; set; }
        [StringLength(50)]
        public string CustomText2 { get; set; }
        [StringLength(50)]
        public string CustomText3 { get; set; }
        [StringLength(50)]
        public string CustomText4 { get; set; }
        [StringLength(50)]
        public string CustomText5 { get; set; }
        public short? LeadTime { get; set; }
        [StringLength(255)]
        public string PayRemark { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        public string ImagePath { get; set; }
        [Column("ConstraintMethodID")]
        public byte? ConstraintMethodId { get; set; }
        [StringLength(50)]
        public string ApAccountCode { get; set; }
        [StringLength(50)]
        public string ApGeneralAccountCode { get; set; }
        [StringLength(50)]
        public string ContactPhone { get; set; }
        [StringLength(50)]
        public string ContactMobile { get; set; }
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
        [Column("MemberID")]
        [StringLength(50)]
        public string MemberId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CreditAmount { get; set; }
        [StringLength(50)]
        public string SalesLevel { get; set; }
        [StringLength(50)]
        public string PaymentTerm { get; set; }
        [StringLength(50)]
        public string Credit { get; set; }
        [StringLength(50)]
        public string SalesBranch { get; set; }
        [StringLength(50)]
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
        [StringLength(255)]
        public string CurrentAddress1 { get; set; }
        [StringLength(50)]
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
        [StringLength(255)]
        public string ContactName { get; set; }
        [StringLength(20)]
        public string TransportCode { get; set; }
        public double? DiscountDefault { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        [StringLength(20)]
        public string SaleCode { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string CurrentSoi { get; set; }
        [StringLength(50)]
        public string CurrentRoad { get; set; }
        [StringLength(50)]
        public string CurrentTelephone { get; set; }
        [StringLength(50)]
        public string CurrentMobile { get; set; }
        [StringLength(50)]
        public string CurrentFax { get; set; }
        [StringLength(50)]
        public string CurrentEmail { get; set; }
        [StringLength(50)]
        public string CurrentWebSite { get; set; }
        [StringLength(50)]
        public string FormalAddress1 { get; set; }
        [StringLength(50)]
        public string FormalAddress2 { get; set; }
        [StringLength(50)]
        public string FormalSoi { get; set; }
        [StringLength(50)]
        public string FormalRoad { get; set; }
        [StringLength(6)]
        public string FormalTumbonCode { get; set; }
        [StringLength(4)]
        public string FormalAmphurCode { get; set; }
        [StringLength(2)]
        public string FormalProvinceCode { get; set; }
        [StringLength(5)]
        public string FormalPostCode { get; set; }
        [StringLength(50)]
        public string FormalTelephone { get; set; }
        [StringLength(50)]
        public string FormalMobile { get; set; }
        [StringLength(50)]
        public string FormalFax { get; set; }
        [StringLength(50)]
        public string FormalEmail { get; set; }
        [StringLength(50)]
        public string FormalWebSite { get; set; }
        [StringLength(50)]
        public string ShipSoi { get; set; }
        [StringLength(50)]
        public string ShipRoad { get; set; }
        [StringLength(50)]
        public string ShipFax { get; set; }
        [StringLength(50)]
        public string ShipEmail { get; set; }
        [StringLength(50)]
        public string ShipWebSite { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastContactDate { get; set; }
        [StringLength(50)]
        public string ContactWeekDay { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [StringLength(50)]
        public string TransportByName { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Key]
        [Column("VendorTypeID")]
        public byte VendorTypeId { get; set; }
        [StringLength(10)]
        public string TaxOrgCode { get; set; }
        [StringLength(50)]
        public string TaxOrgName { get; set; }
        public double? IncentiveFix { get; set; }
        public double? IncentiveRate { get; set; }
    }
}
