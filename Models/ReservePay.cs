using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReservePay")]
    [Index(nameof(Vn), Name = "IX_ReservePay")]
    [Index(nameof(AnimalGid), Name = "idxAnimalGID")]
    public partial class ReservePay
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReservePayNo { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservePayDate { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public byte? IsNotReVat { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        [StringLength(20)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeDate { get; set; }
        [StringLength(20)]
        public string BankCode { get; set; }
        [StringLength(20)]
        public string BranchBankCode { get; set; }
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
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(50)]
        public string ReserveNo { get; set; }
        public byte? IsFinish { get; set; }
        [Column("ARReceiveNo")]
        [StringLength(50)]
        public string ArreceiveNo { get; set; }
        [Column("CurrentCustomerGID")]
        [StringLength(36)]
        public string CurrentCustomerGid { get; set; }
    }
}
