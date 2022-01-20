using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ARReceiveBy")]
    [Index(nameof(CustomerGid), Name = "IX_ARReceiveBy")]
    [Index(nameof(ModDate), Name = "IX_ARReceiveBy_1")]
    [Index(nameof(Vn), Name = "IX_ARReceiveBy_2")]
    [Index(nameof(IsSyncToServer), Name = "IX_ARReceiveBy_3")]
    public partial class ArreceiveBy
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
        public short SeqId { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column("ReceiveTypeID")]
        public short? ReceiveTypeId { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [StringLength(50)]
        public string CreditCardCode { get; set; }
        [StringLength(50)]
        public string CreditCardNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        public double? ReceiveAmount { get; set; }
        [StringLength(50)]
        public string BankCode { get; set; }
        [StringLength(50)]
        public string BankBranchName { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string CouponTypeCode { get; set; }
        [StringLength(50)]
        public string CouponNo { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string CreditCardTypeCode { get; set; }
        [StringLength(50)]
        public string CreditCardPaymentTypeCode { get; set; }
        [StringLength(50)]
        public string MemberCardNo { get; set; }
        [StringLength(50)]
        public string TransferNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string CreditCardSwipeCode { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? ProgramType { get; set; }
    }
}
