using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class VatSale
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Key]
        [Column("DocTypeID")]
        public short DocTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string CustomerCode { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        public double? TotalAmount { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsAddVat { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public byte? InActive { get; set; }
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
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("ARReceiveNo")]
        [StringLength(50)]
        public string ArreceiveNo { get; set; }
        [StringLength(50)]
        public string SalesNo { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        public double? TotalAmountBeforeVat { get; set; }
        public double? TotalAmountForVat { get; set; }
        public double? TotalAmountForNonVat { get; set; }
        [StringLength(20)]
        public string AccountPeriod { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [Column("CustomerTypeID")]
        public byte? CustomerTypeId { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Column("RefSeqID")]
        public int? RefSeqId { get; set; }
        [StringLength(50)]
        public string ReceiptNo { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("POSReceiptNo")]
        [StringLength(20)]
        public string PosreceiptNo { get; set; }
    }
}
