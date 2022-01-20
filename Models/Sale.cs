using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Index(nameof(CustomerGid), Name = "IX_Sales")]
    [Index(nameof(SalesDate), Name = "IX_Sales_1")]
    [Index(nameof(ModDate), Name = "IX_Sales_2")]
    [Index(nameof(IsSyncToServer), Name = "IX_Sales_3")]
    [Index(nameof(AnimalGid), Name = "IX_Sales_4")]
    [Index(nameof(Vn), Name = "IX_Sales_5")]
    public partial class Sale
    {
        [Key]
        [StringLength(20)]
        public string SalesNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SalesDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(20)]
        public string QuotationNo { get; set; }
        public int? PaymentTerm { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public byte? IsAddVat { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("SalesTypeID")]
        public int? SalesTypeId { get; set; }
        [StringLength(20)]
        public string TransportByCode { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountFix { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(20)]
        public string CustomerPoNo { get; set; }
        [StringLength(20)]
        public string ReserveNo { get; set; }
        [StringLength(20)]
        public string DownReceiveNo { get; set; }
        public double? DownReceiveAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? CreditAmount { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        public double? ReceiveAmount { get; set; }
        public double? CostAmount { get; set; }
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
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        public double? TotalAmountForVat { get; set; }
        public double? TotalAmountForNonVat { get; set; }
        [StringLength(50)]
        public string ChargeText { get; set; }
        public double? ChargeAmount { get; set; }
        public double? RoundingAmount { get; set; }
        public double? DoctorFee { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        [Column("POSCode")]
        [StringLength(20)]
        public string Poscode { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? ChequeAmount { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        public double? ReserveAmount { get; set; }
        public double? CouponAmount { get; set; }
        public double? PayDebtAmount { get; set; }
        public double? DebtAmount { get; set; }
        public double? SumTotalAmount { get; set; }
        public double? SumDiscountAmount { get; set; }
        public double? SalesThisBranchButDoOtherBranch { get; set; }
        public double? DoThisBranchButSalesOtherBranch { get; set; }
        [StringLength(50)]
        public string OtherBranchCode { get; set; }
        [Column("OtherBranchTypeID")]
        public byte? OtherBranchTypeId { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(20)]
        public string ReceiptNo { get; set; }
        public double? MemberCardAmount { get; set; }
        public double? ClaimAmount { get; set; }
        public double? RightDiscountAmount { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        public double? DiscountTextForVat { get; set; }
        public double? DiscountAmountForVat { get; set; }
        public double? NetAmountForCalVat { get; set; }
        public int? ReferenceIndex { get; set; }
        public double? PriceWeight { get; set; }
        public double? BankAmount { get; set; }
        public double? SumSocialDiscountAmount { get; set; }
        public double? RedeemPoint { get; set; }
        [Column("RedeemPointSeqID")]
        public int? RedeemPointSeqId { get; set; }
        public double? ReduceDebtAmount { get; set; }
        public double? DiscountPoint { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        public double? ClaimDiscountAmount { get; set; }
        public byte? ProgramType { get; set; }
        [Column("POSReceiptNo")]
        [StringLength(20)]
        public string PosreceiptNo { get; set; }
        [Column("POSInvoiceNo")]
        [StringLength(20)]
        public string PosinvoiceNo { get; set; }
        [StringLength(20)]
        public string NurseCode { get; set; }
        [Column("PTcode")]
        [StringLength(20)]
        public string Ptcode { get; set; }
        [StringLength(20)]
        public string CustomerServiceCode { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
    }
}
