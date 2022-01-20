using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PointDetail")]
    public partial class PointDetail
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
        public byte? IsSyncToServer { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        public double? CurrentPoint { get; set; }
        public double? TotalPoint { get; set; }
        [StringLength(50)]
        public string OrganizationName { get; set; }
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [StringLength(50)]
        public string PromotionName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PointDate { get; set; }
        public double? NetAmount { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        public double? PointIn { get; set; }
        public double? PointOut { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(50)]
        public string CardNumber { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string ReceiptNo { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string SalesNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PointExpireDate { get; set; }
        [Column("PointTypeID")]
        public byte? PointTypeId { get; set; }
        public byte? IsFinish { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UsePointDate { get; set; }
        public double? UseDiscountAmount { get; set; }
        [StringLength(20)]
        public string SalesNoFromReturn { get; set; }
        public byte? IsCancel { get; set; }
        [Column("SeqIDFromCancelPoint")]
        public int? SeqIdfromCancelPoint { get; set; }
        [Column("CustomerMemberSeqID")]
        public int? CustomerMemberSeqId { get; set; }
    }
}
