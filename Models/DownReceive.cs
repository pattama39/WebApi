using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("DownReceive")]
    public partial class DownReceive
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DownReceiveNo { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditCardAmount { get; set; }
        public double? TotalAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? NetAmount { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
