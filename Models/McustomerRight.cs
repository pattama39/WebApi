using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCustomerRight")]
    public partial class McustomerRight
    {
        [Key]
        [StringLength(20)]
        public string RightCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string RightName { get; set; }
        [StringLength(255)]
        public string RightName2 { get; set; }
        public byte? IsCheckCreditLine { get; set; }
        [Column("DiscountTypeID")]
        public byte? DiscountTypeId { get; set; }
        public double? DiscountRate { get; set; }
        public double? DiscountBaht { get; set; }
        [Column(TypeName = "numeric(5, 2)")]
        public decimal? ClaimRate { get; set; }
        [Column(TypeName = "numeric(5, 2)")]
        public decimal? CashRate { get; set; }
        public byte? IsMain { get; set; }
        [Column("RightTypeID")]
        public byte? RightTypeId { get; set; }
        public byte? IsCheckCredit { get; set; }
        [Column(TypeName = "text")]
        public string Contract { get; set; }
        [StringLength(50)]
        public string ArCode { get; set; }
        public int? ShowColor { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSystem { get; set; }
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
        [StringLength(50)]
        public string RunningNoFormat { get; set; }
        public int? LastRunningNo { get; set; }
        [StringLength(50)]
        public string ReportFileName { get; set; }
        [Column("ShowTypeID")]
        public byte? ShowTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("CreditTypeID")]
        public byte? CreditTypeId { get; set; }
        public byte? IsDefaultRight { get; set; }
        [StringLength(255)]
        public string OrgName { get; set; }
        [StringLength(255)]
        public string AddressName { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [Column("IsPayerByCGD")]
        public byte? IsPayerByCgd { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
    }
}
