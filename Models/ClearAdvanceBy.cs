using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ClearAdvanceBy")]
    public partial class ClearAdvanceBy
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [Key]
        [StringLength(50)]
        public string ClearAdvanceNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column("PayTypeID")]
        public short? PayTypeId { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PayDate { get; set; }
        public double? PayAmount { get; set; }
        [StringLength(50)]
        public string BankCode { get; set; }
        [StringLength(50)]
        public string BankBranchName { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(50)]
        public string CreditCardCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string TransferNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferDate { get; set; }
    }
}
