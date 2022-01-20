using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ARReceiveItem")]
    [Index(nameof(ModDate), Name = "IX_ARReceiveItem")]
    [Index(nameof(CustomerGid), Name = "IX_ARReceiveItem_1")]
    [Index(nameof(Vn), Name = "IX_ARReceiveItem_2")]
    [Index(nameof(IsSyncToServer), Name = "IX_ARReceiveItem_3")]
    public partial class ArreceiveItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ARReceiveNo")]
        [StringLength(20)]
        public string ArreceiveNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("OrderQTY")]
        public double? OrderQty { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmountAfterDiscount { get; set; }
        public double? NetAmount { get; set; }
        public double? ReceiveAmount { get; set; }
        public double? PayDebtAmount { get; set; }
        public double? DebtAmount { get; set; }
        [Column("SalesItemSeqID")]
        public int? SalesItemSeqId { get; set; }
        [Column("ReceiveTypeID")]
        public int? ReceiveTypeId { get; set; }
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
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? BankAmount { get; set; }
        public double? CouponAmount { get; set; }
        public double? GrandTotalReceiveAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        public double? ReserveAmount { get; set; }
        public double? MemberCardAmount { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefSeqID")]
        public int? RefSeqId { get; set; }
        [StringLength(50)]
        public string DoByCode { get; set; }
        [StringLength(50)]
        public string DiagByCode { get; set; }
        [StringLength(50)]
        public string ConsultByCode { get; set; }
        [StringLength(50)]
        public string SalesByCode { get; set; }
        public byte? IsCalVat { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string SurgeryGroupCode { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? IsEarnPoint { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SalesDate { get; set; }
        [Column("SalesTypeID")]
        public byte? SalesTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayDate { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        public byte? ProgramType { get; set; }
        public double? ClaimDiscountAmount { get; set; }
        public double? ClaimAmount { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
    }
}
