using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("FDAReport")]
    public partial class Fdareport
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("FDAReportID")]
        public int FdareportId { get; set; }
        [Column("ReportSeqID")]
        public int? ReportSeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(20)]
        public string CustomerCode { get; set; }
        [StringLength(150)]
        public string CustomerName { get; set; }
        [Column("CustomerIDCard")]
        [StringLength(50)]
        public string CustomerIdcard { get; set; }
        [StringLength(500)]
        public string CustomerAddress { get; set; }
        [StringLength(50)]
        public string AnalyzeNo { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
        public byte? IsNewPage { get; set; }
        [StringLength(50)]
        public string ReceiveFrom { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("RecordTypeID")]
        public int? RecordTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public int? VisitAmount { get; set; }
        public double? CustomerAge { get; set; }
        public double? BeginQty { get; set; }
        public double? ReceiveQty { get; set; }
        public double? SalesQty { get; set; }
        public double? SalesQty1 { get; set; }
        public double? SalesQty2 { get; set; }
        public double? SalesQty3 { get; set; }
        public double? SalesQty4 { get; set; }
        public double? BalanceQty { get; set; }
        [Column("BMI")]
        public double? Bmi { get; set; }
        [StringLength(50)]
        public string ItemGroupName { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column("CurrentQTY")]
        [StringLength(50)]
        public string CurrentQty { get; set; }
        public byte? IsCheckStock { get; set; }
        [StringLength(50)]
        public string AnimalCode { get; set; }
        [StringLength(150)]
        public string AnimalName { get; set; }
        public double? UnitCost { get; set; }
    }
}
