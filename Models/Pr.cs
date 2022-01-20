using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PR")]
    public partial class Pr
    {
        [Key]
        [Column("PRNo")]
        [StringLength(20)]
        public string Prno { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(50)]
        public string AddressCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Column("PRDate", TypeName = "smalldatetime")]
        public DateTime? Prdate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("PORemark")]
        [StringLength(255)]
        public string Poremark { get; set; }
        public byte? IsLock { get; set; }
        public byte? IsCancel { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [StringLength(20)]
        public string CancelByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountTextForVat { get; set; }
        public double? DiscountAmount { get; set; }
        public double? DiscountAmountForVat { get; set; }
        public double? VatRate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountFotVat { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(255)]
        public string TermofPayment { get; set; }
        [StringLength(50)]
        public string SalesBranch { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public byte? IsComplete { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(20)]
        public string TransportByCode { get; set; }
        [StringLength(50)]
        public string PaymentCondition { get; set; }
        public int? PaymentTerm { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("PRByCode")]
        [StringLength(20)]
        public string PrbyCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public int? ReferenceIndex { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApproveDate { get; set; }
    }
}
