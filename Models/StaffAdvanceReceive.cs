using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffAdvanceReceive")]
    public partial class StaffAdvanceReceive
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string AdvanceReceiveNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvanceReceiveDate { get; set; }
        [StringLength(20)]
        public string AdvanceRequestNo { get; set; }
        [StringLength(20)]
        public string InDeCode { get; set; }
        public short? PeriodNo { get; set; }
        public short? PeriodYear { get; set; }
        public short? LeftPeriod { get; set; }
        public double? Amount { get; set; }
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
    }
}
