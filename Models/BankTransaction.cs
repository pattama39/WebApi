using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BankTransaction")]
    public partial class BankTransaction
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("BankTransactionID")]
        public int BankTransactionId { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
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
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(50)]
        public string CreditcardCode { get; set; }
        [StringLength(50)]
        public string CreditcardNo { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [StringLength(50)]
        public string CouponNo { get; set; }
        [StringLength(50)]
        public string TransferNo { get; set; }
        public double? AmountIn { get; set; }
        public double? AmountOut { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "text")]
        public string Remark2 { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string PayerCode { get; set; }
        [StringLength(255)]
        public string PayerName { get; set; }
        [StringLength(50)]
        public string ReceiverCode { get; set; }
        [StringLength(255)]
        public string ReceiverName { get; set; }
        public byte? IsConfirm { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ConfirmDate { get; set; }
        [Column("TransactionTypeID")]
        public byte? TransactionTypeId { get; set; }
        [Column("BookBankStatementTypeID")]
        public byte? BookBankStatementTypeId { get; set; }
        [StringLength(50)]
        public string BookBankStatementNo { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsReturn { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string CreditcardSwipeCode { get; set; }
        [Column("PCCode")]
        [StringLength(50)]
        public string Pccode { get; set; }
    }
}
