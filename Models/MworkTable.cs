using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MWorkTable")]
    public partial class MworkTable
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        public long WorkCode { get; set; }
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
        public string WorkStaffCode { get; set; }
        [StringLength(20)]
        public string ShiftCode { get; set; }
        public int? WorkYear { get; set; }
        public int? WorkPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkDay { get; set; }
        public short? IsNoneWorkDay { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
