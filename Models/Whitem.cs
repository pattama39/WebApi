using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("WHItem")]
    public partial class Whitem
    {
        [Key]
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        public double? CurrentQty { get; set; }
        public double? MinimumQty { get; set; }
        public double? MaximumQty { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public double? BeginMonthQty { get; set; }
        public double? BeginYearQty { get; set; }
        [StringLength(50)]
        public string LocationCode { get; set; }
        [StringLength(50)]
        public string MfgNo { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public double? PendingDeliverQty { get; set; }
        public double? PendingReceiveQty { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? TotalCost { get; set; }
        public double? TotalCostAverage { get; set; }
        [Column("TotalCostFIFO")]
        public double? TotalCostFifo { get; set; }
    }
}
