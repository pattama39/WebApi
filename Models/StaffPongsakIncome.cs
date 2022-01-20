using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffPongsakIncome")]
    public partial class StaffPongsakIncome
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("RowID")]
        public long RowId { get; set; }
        public short? IsSystem { get; set; }
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
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string IncomeCode { get; set; }
        [StringLength(255)]
        public string IncomeString { get; set; }
        public int? IncomePeriod { get; set; }
        public int? IncomeYear { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? IncomeForDate { get; set; }
        public float? Amount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCalc { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
