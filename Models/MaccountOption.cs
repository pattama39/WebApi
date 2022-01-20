using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MAccountOptions")]
    public partial class MaccountOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Column("COMTAXNO")]
        [StringLength(15)]
        public string Comtaxno { get; set; }
        [Column("COMVAT", TypeName = "money")]
        public decimal? Comvat { get; set; }
        [Column("TAXTYPE")]
        [StringLength(2)]
        public string Taxtype { get; set; }
        [Column("AREATYPE")]
        [StringLength(2)]
        public string Areatype { get; set; }
        [Column("ACCMTH")]
        public int? Accmth { get; set; }
        [Column("ACCYR")]
        public int? Accyr { get; set; }
        [Column("ASKUNRATIO")]
        [StringLength(1)]
        public string Askunratio { get; set; }
        [Column("AROLDPRICE")]
        [StringLength(1)]
        public string Aroldprice { get; set; }
        [Column("APOLDPRICE")]
        [StringLength(1)]
        public string Apoldprice { get; set; }
        [Column("LOCID")]
        [StringLength(2)]
        public string Locid { get; set; }
        [Column("CASH")]
        [StringLength(2)]
        public string Cash { get; set; }
        [Column("VATTYPE")]
        [StringLength(2)]
        public string Vattype { get; set; }
        [Column("GLTYPE")]
        [StringLength(2)]
        public string Gltype { get; set; }
        [Column("COSTTYPE")]
        [StringLength(2)]
        public string Costtype { get; set; }
        [Column("SARMST")]
        [StringLength(15)]
        public string Sarmst { get; set; }
        [Column("SVATSALE")]
        [StringLength(15)]
        public string Svatsale { get; set; }
        [Column("SSALE")]
        [StringLength(15)]
        public string Ssale { get; set; }
        [Column("SCOST")]
        [StringLength(15)]
        public string Scost { get; set; }
        [Column("SINV1")]
        [StringLength(15)]
        public string Sinv1 { get; set; }
        [Column("SCASHIN")]
        [StringLength(15)]
        public string Scashin { get; set; }
        [Column("SDISCEX")]
        [StringLength(15)]
        public string Sdiscex { get; set; }
        [Column("SCASHOUT")]
        [StringLength(15)]
        public string Scashout { get; set; }
        [Column("SBKKBL")]
        [StringLength(15)]
        public string Sbkkbl { get; set; }
        [Column("SPCHKREC")]
        [StringLength(15)]
        public string Spchkrec { get; set; }
        [Column("SVATPUR")]
        [StringLength(15)]
        public string Svatpur { get; set; }
        [Column("SXVATPUR")]
        [StringLength(15)]
        public string Sxvatpur { get; set; }
        [Column("STAXGLAR")]
        [StringLength(15)]
        public string Staxglar { get; set; }
        [Column("SAPGL")]
        [StringLength(15)]
        public string Sapgl { get; set; }
        [Column("SPCHKEXP")]
        [StringLength(15)]
        public string Spchkexp { get; set; }
        [Column("STAXGL")]
        [StringLength(15)]
        public string Staxgl { get; set; }
        [Column("SXVATSAL")]
        [StringLength(15)]
        public string Sxvatsal { get; set; }
        [Column("SRETUIN")]
        [StringLength(15)]
        public string Sretuin { get; set; }
        [Column("SDISC_R")]
        [StringLength(15)]
        public string SdiscR { get; set; }
        [Column("SPURCHASE")]
        [StringLength(15)]
        public string Spurchase { get; set; }
        [Column("SRETUOU")]
        [StringLength(15)]
        public string Sretuou { get; set; }
        [Column("SBKKCHG")]
        [StringLength(15)]
        public string Sbkkchg { get; set; }
        [Column("SVATCHG")]
        [StringLength(15)]
        public string Svatchg { get; set; }
        [Column("SFIXEXP")]
        [StringLength(15)]
        public string Sfixexp { get; set; }
        [Column("INVZERO")]
        [StringLength(1)]
        public string Invzero { get; set; }
        [Column("AROVER")]
        [StringLength(2)]
        public string Arover { get; set; }
        [Column("GLSHOW")]
        [StringLength(1)]
        public string Glshow { get; set; }
        [Column("COMADD1")]
        [StringLength(70)]
        public string Comadd1 { get; set; }
        [Column("COMADD2")]
        [StringLength(70)]
        public string Comadd2 { get; set; }
        [Column("SDOWNPAY")]
        [StringLength(15)]
        public string Sdownpay { get; set; }
        [Column("SDOWNREC")]
        [StringLength(15)]
        public string Sdownrec { get; set; }
        [Column("SPLINYEAR")]
        [StringLength(15)]
        public string Splinyear { get; set; }
        [Column("SWARNBACK")]
        public int? Swarnback { get; set; }
        [Column("DATETYPE")]
        [StringLength(2)]
        public string Datetype { get; set; }
        [Column("CASHAP")]
        [StringLength(2)]
        public string Cashap { get; set; }
        [Column("SPLACCU")]
        [StringLength(15)]
        public string Splaccu { get; set; }
        [Column("SLASTBACK", TypeName = "smalldatetime")]
        public DateTime? Slastback { get; set; }
        [Column("SFIRSTUSE")]
        public byte? Sfirstuse { get; set; }
        [Column("SFIRSTEND")]
        public byte? Sfirstend { get; set; }
        [Column("STEXTLINE")]
        public short? Stextline { get; set; }
        [Column("SLINESPACE1")]
        public short? Slinespace1 { get; set; }
        [Column("SLINESPACE2")]
        public short? Slinespace2 { get; set; }
        [Column("SLINESPACE3")]
        public short? Slinespace3 { get; set; }
        [Column("SKINPATH")]
        [StringLength(50)]
        public string Skinpath { get; set; }
        [Column("DBVERSION")]
        [StringLength(10)]
        public string Dbversion { get; set; }
        [Column("COSTLOCID")]
        [StringLength(2)]
        public string Costlocid { get; set; }
        [Column("FIXDAYINYR")]
        public int? Fixdayinyr { get; set; }
        [Column("F3INV")]
        [StringLength(1)]
        public string F3inv { get; set; }
        [Column("SENG")]
        [StringLength(1)]
        public string Seng { get; set; }
        [Column("SLOCK")]
        [StringLength(1)]
        public string Slock { get; set; }
        [Column("SLOCKDATE1", TypeName = "smalldatetime")]
        public DateTime? Slockdate1 { get; set; }
        [Column("SLOCKDATE2", TypeName = "smalldatetime")]
        public DateTime? Slockdate2 { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginPeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartSystemDate { get; set; }
        [Column("RevenueTaxTypeID")]
        public byte? RevenueTaxTypeId { get; set; }
        [StringLength(50)]
        public string ShipAddress1 { get; set; }
        [StringLength(50)]
        public string ShipAddress2 { get; set; }
        [StringLength(50)]
        public string ShipRoad { get; set; }
        [StringLength(50)]
        public string ShipTumbonName { get; set; }
        [StringLength(50)]
        public string ShipAmphurName { get; set; }
        [StringLength(50)]
        public string ShipProvinceName { get; set; }
        [StringLength(50)]
        public string ShipPostCode { get; set; }
        [StringLength(50)]
        public string ShipTelephone { get; set; }
        [StringLength(50)]
        public string ShipFax { get; set; }
        [StringLength(255)]
        public string ShipEmail { get; set; }
        [StringLength(255)]
        public string ShipWebSite { get; set; }
        [StringLength(50)]
        public string MonetaryAddress1 { get; set; }
        [StringLength(50)]
        public string MonetaryAddress2 { get; set; }
        [StringLength(50)]
        public string MonetaryRoad { get; set; }
        [StringLength(50)]
        public string MonetaryTumbonName { get; set; }
        [StringLength(50)]
        public string MonetaryAmphurName { get; set; }
        [StringLength(50)]
        public string MonetaryProvinceName { get; set; }
        [StringLength(50)]
        public string MonetaryPostCode { get; set; }
        [StringLength(50)]
        public string MonetaryTelephone { get; set; }
        [StringLength(50)]
        public string MonetaryFax { get; set; }
        [StringLength(255)]
        public string MonetaryEmail { get; set; }
        [StringLength(255)]
        public string MonetaryWebSite { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginPeriodMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginPeriodYear { get; set; }
        [Column("DepreciationMethodID")]
        public byte? DepreciationMethodId { get; set; }
        [Column("DefaultSaleTypeID")]
        public short? DefaultSaleTypeId { get; set; }
        [Column("DefaultPurchaseTypeID")]
        public short? DefaultPurchaseTypeId { get; set; }
        public short? InventoryCostType { get; set; }
        [Column("InventoryPostTypeID")]
        public short? InventoryPostTypeId { get; set; }
        [Column("DepreciateTypeID")]
        public byte? DepreciateTypeId { get; set; }
        public short? DepreciateDay { get; set; }
        public int? CurrentBuild { get; set; }
        [StringLength(20)]
        public string DefaultCustomerCodeWhenSalesCash { get; set; }
        [StringLength(20)]
        public string DefaultReceiptHeaderCode { get; set; }
        public int? PeriodSetUpProgram { get; set; }
        public int? YearSetUpProgram { get; set; }
        public int? PeriodPerYear { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
