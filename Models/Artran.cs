using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ARTrans")]
    [Index(nameof(CustomerGid), Name = "IX_ARTrans")]
    [Index(nameof(ModDate), Name = "IX_ARTrans_1")]
    [Index(nameof(Vn), Name = "IX_ARTrans_2")]
    [Index(nameof(AnimalGid), Name = "IX_ARTrans_3")]
    [Index(nameof(IsSyncToServer), Name = "IX_ARTrans_4")]
    public partial class Artran
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ARTransID")]
        public int ArtransId { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? PaymentTerm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(20)]
        public string TransportByCode { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public byte? IsAddVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public double? BeginAmount { get; set; }
        public double? AfterDiscountAmount { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        public double? InvoiceAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditCardAmount { get; set; }
        public double? CashAmount { get; set; }
        [StringLength(50)]
        public string DownReceiveNo { get; set; }
        public double? DownReceiveAmount { get; set; }
        public double? ReceiveAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Column("CustomerPONo")]
        [StringLength(50)]
        public string CustomerPono { get; set; }
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
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column("DocTypeID")]
        public int? DocTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? ReserveAmount { get; set; }
        public double? CouponAmount { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public double? MemberCardAmount { get; set; }
        [Column("ARReceiveNo")]
        [StringLength(50)]
        public string ArreceiveNo { get; set; }
        [Column("ReferenceID")]
        public int? ReferenceId { get; set; }
        public double? BankAmount { get; set; }
        [Column("OldCustomerGID")]
        [StringLength(36)]
        public string OldCustomerGid { get; set; }
        public double? ReduceDebtAmount { get; set; }
        public double? DiscountPoint { get; set; }
        public byte? ProgramType { get; set; }
        [StringLength(50)]
        public string RightCode { get; set; }
        [Column("ARReceiveAbleNo")]
        [StringLength(20)]
        public string ArreceiveAbleNo { get; set; }
    }
}
