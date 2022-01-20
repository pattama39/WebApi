using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MBank")]
    public partial class Mbank
    {
        [Key]
        [StringLength(20)]
        public string BankCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string BankName { get; set; }
        [Column("BankTypeID")]
        public byte? BankTypeId { get; set; }
        [Column("BankAccountTypeID")]
        public byte? BankAccountTypeId { get; set; }
        [Key]
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(50)]
        public string BookBankName { get; set; }
        [StringLength(20)]
        public string BankAccountCode { get; set; }
        public double? Amount { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(50)]
        public string Branch { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string BankBranch { get; set; }
        [StringLength(10)]
        public string BankBrachCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string AccountType { get; set; }
        [StringLength(255)]
        public string AccountName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsForCheque { get; set; }
        public double? InitialAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InitialDate { get; set; }
        public byte? IsCashFlow { get; set; }
    }
}
