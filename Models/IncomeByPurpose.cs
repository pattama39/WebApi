using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("IncomeByPurpose")]
    public partial class IncomeByPurpose
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime IncomeDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SubTotal { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CreditAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ChangeInAmount { get; set; }
        [StringLength(50)]
        public string ExRemark1 { get; set; }
        [StringLength(50)]
        public string ExRemark2 { get; set; }
        [StringLength(50)]
        public string ExRemark3 { get; set; }
        [StringLength(50)]
        public string ExRemark4 { get; set; }
        [StringLength(50)]
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
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ChangeOutAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? GrandTotal { get; set; }
        [StringLength(50)]
        public string Remark1 { get; set; }
        [StringLength(50)]
        public string Remark2 { get; set; }
        [StringLength(50)]
        public string Remark3 { get; set; }
        [StringLength(50)]
        public string Remark4 { get; set; }
        [StringLength(50)]
        public string Remark5 { get; set; }
        [StringLength(50)]
        public string Remark6 { get; set; }
        [StringLength(50)]
        public string Remark7 { get; set; }
        [StringLength(50)]
        public string Remark8 { get; set; }
        [StringLength(50)]
        public string Remark9 { get; set; }
        [StringLength(50)]
        public string Remark10 { get; set; }
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
        public byte? IsDeleted { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
