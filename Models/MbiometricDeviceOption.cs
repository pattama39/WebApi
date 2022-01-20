using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MBiometricDeviceOptions")]
    public partial class MbiometricDeviceOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("FAR", TypeName = "numeric(18, 0)")]
        public decimal? Far { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Threshold { get; set; }
        [Column("DPI", TypeName = "numeric(18, 0)")]
        public decimal? Dpi { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MinMinutiaCount { get; set; }
        [Column("SearchTypeID")]
        public int? SearchTypeId { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
