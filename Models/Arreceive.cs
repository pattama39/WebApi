using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ARReceive")]
    [Index(nameof(CustomerGid), Name = "IX_ARReceive")]
    [Index(nameof(ModDate), Name = "IX_ARReceive_1")]
    [Index(nameof(Vn), Name = "IX_ARReceive_2")]
    [Index(nameof(AnimalGid), Name = "IX_ARReceive_3")]
    [Index(nameof(IsSyncToServer), Name = "IX_ARReceive_4")]
    [Index(nameof(ReceiptNo), Name = "IX_ARReceive_5")]
    public partial class Arreceive
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("ARReceiveNo")]
        [StringLength(20)]
        public string ArreceiveNo { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountForVat { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [StringLength(50)]
        public string DiscountTextForVat { get; set; }
        public double? DiscountAmountForVat { get; set; }
        public double? TotalAmountAfterDiscount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? NetAmountForVat { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
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
        public double? ReceiveAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("PayTypeID")]
        public byte? PayTypeId { get; set; }
        public double? CouponAmount { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public double? ReserveAmount { get; set; }
        public double? DownReceiveAmount { get; set; }
        public double? MemberCardAmount { get; set; }
        [Column("SeqID")]
        public int? SeqId { get; set; }
        public byte? IsFinish { get; set; }
        public double? PayDebtAmount { get; set; }
        public double? DebtAmount { get; set; }
        [StringLength(50)]
        public string ReceiptNo { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public double? SumDiscountAmount { get; set; }
        public double? SumDiscountAmountForVat { get; set; }
        public double? VatAmount { get; set; }
        public double? VatRate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? DoctorFee { get; set; }
        [StringLength(50)]
        public string DoctorCode { get; set; }
        public double? SumTotalItemAmount { get; set; }
        public double? SumTotalItemAmountForVat { get; set; }
        public double? BankAmount { get; set; }
        [StringLength(50)]
        public string TransferNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
        [Column("BookbankID")]
        [StringLength(50)]
        public string BookbankId { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        public int? ReferenceIndex { get; set; }
        [StringLength(50)]
        public string CreditcardSwipeCode { get; set; }
        [StringLength(50)]
        public string ReferenceNo { get; set; }
        [Column("ShiftTypeID")]
        public int? ShiftTypeId { get; set; }
        [Column("CurrentCustomerGID")]
        [StringLength(36)]
        public string CurrentCustomerGid { get; set; }
        public double? SocialDiscountAmount { get; set; }
        [Column("ReceiveTypeID")]
        public byte? ReceiveTypeId { get; set; }
        public double? RoundingAmount { get; set; }
        public double? ReduceDebtAmount { get; set; }
        public double? DiscountPoint { get; set; }
        public double? PointAmount { get; set; }
        public double? RedeemPoint { get; set; }
        [Column("ARReceiveAbleNo")]
        [StringLength(20)]
        public string ArreceiveAbleNo { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        public byte? ProgramType { get; set; }
        [Column("POSReceiptNo")]
        [StringLength(20)]
        public string PosreceiptNo { get; set; }
        [Column("POSInvoiceNo")]
        [StringLength(20)]
        public string PosinvoiceNo { get; set; }
        public double? TotalAmountForNonVat { get; set; }
        public double? ClaimAmount { get; set; }
        [Column("AppID")]
        public int? AppId { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
        [StringLength(20)]
        public string ReceiveByCode { get; set; }
        public double? ClaimDiscountAmount { get; set; }
    }
}
