using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SalesPeriod")]
    [Index(nameof(ModDate), Name = "IX_SalesPeriod")]
    public partial class SalesPeriod
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PeriodID")]
        public int PeriodId { get; set; }
        [StringLength(50)]
        public string PeriodName { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OpenTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseTime { get; set; }
        [Column("POSCode")]
        [StringLength(20)]
        public string Poscode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public double? SubTotal { get; set; }
        public double? CreditAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? CouponAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? BankAmount { get; set; }
        public double? ChangeInAmount { get; set; }
        [StringLength(255)]
        public string ExRemark1 { get; set; }
        [StringLength(255)]
        public string ExRemark2 { get; set; }
        [StringLength(255)]
        public string ExRemark3 { get; set; }
        [StringLength(255)]
        public string ExRemark4 { get; set; }
        [StringLength(255)]
        public string ExRemark5 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ExAmount1 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ExAmount2 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ExAmount3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ExAmount4 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ExAmount5 { get; set; }
        public double? ChangeOutAmount { get; set; }
        public double? GrandTotal { get; set; }
        [Column(TypeName = "text")]
        public string Remark1 { get; set; }
        [Column(TypeName = "text")]
        public string Remark2 { get; set; }
        [Column(TypeName = "text")]
        public string Remark3 { get; set; }
        [Column(TypeName = "text")]
        public string Remark4 { get; set; }
        [Column(TypeName = "text")]
        public string Remark5 { get; set; }
        [Column(TypeName = "text")]
        public string Remark6 { get; set; }
        [Column(TypeName = "text")]
        public string Remark7 { get; set; }
        [Column(TypeName = "text")]
        public string Remark8 { get; set; }
        [Column(TypeName = "text")]
        public string Remark9 { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "text")]
        public string Remark10 { get; set; }
    }
}
