using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DeliveryOrder")]
    public partial class DeliveryOrder
    {
        [Key]
        [Column("DONo")]
        [StringLength(50)]
        public string Dono { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("StaffID")]
        [StringLength(50)]
        public string StaffId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
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
        public byte? IsConfirm { get; set; }
        [Column("ConstraintMethodID")]
        public byte? ConstraintMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Discount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? NetAmount { get; set; }
        public byte? IsCancel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancelDate { get; set; }
        [StringLength(50)]
        public string CancelByCode { get; set; }
        [Column("PONo")]
        [StringLength(20)]
        public string Pono { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        [StringLength(50)]
        public string RightNo { get; set; }
        [Column("ClaimTypeID")]
        public byte? ClaimTypeId { get; set; }
        [StringLength(50)]
        public string ClaimAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ReceiptAmount { get; set; }
        public byte? ReprintNum { get; set; }
        public byte? IsCutLoss { get; set; }
        public byte? IsBegin { get; set; }
        [StringLength(50)]
        public string LanguageCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string SalesBranch { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
