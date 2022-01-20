using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReturnFromCustomer")]
    public partial class ReturnFromCustomer
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnFromCustomerNo { get; set; }
        [Column("ReturnTypeID")]
        public int? ReturnTypeId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Required]
        [StringLength(20)]
        public string SalesNo { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string SalesCode { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("VatChargeID")]
        public short? VatChargeId { get; set; }
        [Column("VatInPeriodID")]
        public int? VatInPeriodId { get; set; }
        public byte? IsAddVat { get; set; }
        [Column("DownLiabilityID")]
        public short? DownLiabilityId { get; set; }
        public double? VatBaseAmount { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public double? BeginsAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
    }
}
