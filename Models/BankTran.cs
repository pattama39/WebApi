using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class BankTran
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column("DocTypeID")]
        public short? DocTypeId { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string JournalNo { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(50)]
        public string BankCode { get; set; }
        [StringLength(50)]
        public string BankBranchName { get; set; }
        [StringLength(50)]
        public string BankCode2 { get; set; }
        [StringLength(50)]
        public string BankBranchName2 { get; set; }
        public double? NetAmountIn { get; set; }
        public double? NetAmountOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePass { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePayIn { get; set; }
        public double? FeeAmount { get; set; }
        public byte? IsClearingCheque { get; set; }
        public byte? IsReturnCheque { get; set; }
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
        public double? NetAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
