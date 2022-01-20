using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("ARCard")]
    public partial class Arcard
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        public short SeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public double? BeginAmount { get; set; }
        public double? DebtAmount { get; set; }
        public double? ReceiveAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? BalanceAmount { get; set; }
        [StringLength(50)]
        public string CustomerPoNo { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public byte? IsAddVat { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? InvoiceAmount { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public double? SalesBalance { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
