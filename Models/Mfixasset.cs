using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MFixasset")]
    public partial class Mfixasset
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string FixassetCode { get; set; }
        [StringLength(50)]
        public string FixassetName { get; set; }
        [StringLength(50)]
        public string FixAssetName2 { get; set; }
        [StringLength(50)]
        public string FixassetTypeCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? PurchasePrice { get; set; }
        public double? TransportationAmount { get; set; }
        [Column("installationAmount")]
        public double? InstallationAmount { get; set; }
        public double? OtherExpenseAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Cost { get; set; }
        [StringLength(50)]
        public string MainAssetCode { get; set; }
        public byte? IsTangibleAsset { get; set; }
        public byte? IsUse { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BeginUseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column("DepreciationMethodID")]
        public byte? DepreciationMethodId { get; set; }
        [Column("DepreciationMethodByTimeID")]
        public byte? DepreciationMethodByTimeId { get; set; }
        [Column(TypeName = "numeric(9, 5)")]
        public decimal? DepreciationRate { get; set; }
        public double? RemainsPrice { get; set; }
        public double? BeginingDepreciation { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SellDate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SellOrCutLossAmount { get; set; }
        [StringLength(50)]
        public string SellNo { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [StringLength(50)]
        public string Model { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        public short? UseAge { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(50)]
        public string VoucherNo { get; set; }
        [StringLength(50)]
        public string WarrantyNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyEndDate { get; set; }
        [StringLength(50)]
        public string AssuranceName { get; set; }
        [StringLength(20)]
        public string AssuranceNo { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? AssuranceValue { get; set; }
        public double? AssurancePerYear { get; set; }
        public int? AssurancePeriod { get; set; }
        [Column(TypeName = "image")]
        public byte[] ImagePath { get; set; }
        [StringLength(50)]
        public string Instruction { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndUseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastCalDepDate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? RemainsValue { get; set; }
        public int? Duration { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? FirstDepreciation { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string FixassetAccCode { get; set; }
        [StringLength(50)]
        public string FixassetDepAccCode { get; set; }
        [StringLength(50)]
        public string FixassetDepSumAccCode { get; set; }
        [StringLength(50)]
        public string ConstructionFixAccCode { get; set; }
        [StringLength(50)]
        public string ProfitAndLossAccCode { get; set; }
        [StringLength(50)]
        public string LossAccCode { get; set; }
        [StringLength(50)]
        public string CutLossNo { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? VatAmount { get; set; }
        public double? ProfitAndLossAmount { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        public byte? IsDeleted { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string ManufactureBy { get; set; }
        [Column("PurchasePONo")]
        [StringLength(50)]
        public string PurchasePono { get; set; }
        [Column("WarrantyStatusID")]
        public int? WarrantyStatusId { get; set; }
        [StringLength(50)]
        public string FixAssetStatusCode { get; set; }
        public double? WarrantyPrice { get; set; }
        [StringLength(50)]
        public string Brand { get; set; }
        [Column("UseAgeUnitID")]
        public byte? UseAgeUnitId { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public double? CostAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BeginUseAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CurrentUseAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MaxAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BeginTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CurrentTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MaxTime { get; set; }
        [Column("ReadTypeID")]
        public int? ReadTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? UseTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? UseAmount { get; set; }
        [StringLength(50)]
        public string FisassetRegistrationNo { get; set; }
        public double? InitialDepreciationAmount { get; set; }
        public double? DepreciationAmountByCal { get; set; }
        public byte? IsSold { get; set; }
    }
}
