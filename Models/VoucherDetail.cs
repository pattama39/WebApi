using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("VoucherDetail")]
    public partial class VoucherDetail
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
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
        [StringLength(50)]
        public string VoucherTypeCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string VoucherNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("VoucherLotID")]
        public int? VoucherLotId { get; set; }
        public double? Price { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string SalesNo { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("VoucherTypeID")]
        public byte? VoucherTypeId { get; set; }
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [Column("PromotionID")]
        public int? PromotionId { get; set; }
    }
}
