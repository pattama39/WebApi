using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DataXRayPosition")]
    public partial class DataXrayPosition
    {
        [Key]
        [Column("XRayTypeCode")]
        [StringLength(20)]
        public string XrayTypeCode { get; set; }
        [Key]
        [Column("XRayPositionCode")]
        [StringLength(20)]
        public string XrayPositionCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("XRayPositionName")]
        [StringLength(255)]
        public string XrayPositionName { get; set; }
        [Column("XRayPositionName2")]
        [StringLength(255)]
        public string XrayPositionName2 { get; set; }
        [Column("XRayAbbr")]
        [StringLength(255)]
        public string XrayAbbr { get; set; }
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
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
