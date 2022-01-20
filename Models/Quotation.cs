using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Quotation")]
    public partial class Quotation
    {
        [Key]
        [StringLength(20)]
        public string QuotationNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        public double? DiscountAmount { get; set; }
        public double? VatRate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? NetAmount { get; set; }
        public short? TermofPayment { get; set; }
        [StringLength(50)]
        public string TermofDelivery { get; set; }
        [StringLength(50)]
        public string PriceValid { get; set; }
        public int? DueAmount { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(50)]
        public string TransportTypeCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QuotationDate { get; set; }
        [Column("OpportunityID")]
        public int? OpportunityId { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public double? SubTotal { get; set; }
        [StringLength(20)]
        public string QuotationStatusCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ContactCode { get; set; }
    }
}
