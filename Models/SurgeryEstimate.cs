using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SurgeryEstimate")]
    public partial class SurgeryEstimate
    {
        [Key]
        [StringLength(20)]
        public string SurgeryEstimateNo { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        public int? PaymentTerm { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("SalesTypeID")]
        public int? SalesTypeId { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
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
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        public double? TotalAmountForVat { get; set; }
        public double? TotalAmountForNonVat { get; set; }
        public double? ChargeAmount { get; set; }
        public double? RoundingAmount { get; set; }
        public double? DoctorFee { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [Column("PeriodID")]
        public int? PeriodId { get; set; }
        [StringLength(20)]
        public string InvoiceNo { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        public double? SumTotalAmount { get; set; }
        public double? SumDiscountAmount { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        public double? DiscountTextForVat { get; set; }
        public double? DiscountAmountForVat { get; set; }
        public double? NetAmountForCalVat { get; set; }
        public byte? IsOrder { get; set; }
        [Column("DocTypeID")]
        public byte? DocTypeId { get; set; }
    }
}
