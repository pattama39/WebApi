using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ConfirmCreditItem")]
    public partial class ConfirmCreditItem
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Key]
        [StringLength(50)]
        public string ConfirmCreditNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        public double? TotalAmount { get; set; }
        public double? ChargeAmount { get; set; }
        public double? VatAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column("BankTransactionID")]
        public int BankTransactionId { get; set; }
    }
}
