using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ARReceiveAbleItem")]
    public partial class ArreceiveAbleItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(50)]
        public string RightCode { get; set; }
        [StringLength(50)]
        public string RightName { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
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
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [StringLength(20)]
        public string SalesNo { get; set; }
        [Column("SalesItemSeqID")]
        public int? SalesItemSeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [StringLength(50)]
        public string ReceiptNo { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        public double? TotalAmount { get; set; }
        public double? ClaimAmount { get; set; }
        public double? ClaimDisCountAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? DiscountAmount { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        public double? NetClaimAmount { get; set; }
        public double? ReceiveAmount { get; set; }
        public double? RemainingAmount { get; set; }
        [Column("ARReceiveAbleNo")]
        [StringLength(20)]
        public string ArreceiveAbleNo { get; set; }
        [Column("ARReceiveAbleSeqID")]
        public int? ArreceiveAbleSeqId { get; set; }
        public double? CurrentPayDebtAmount { get; set; }
    }
}
