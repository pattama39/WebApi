using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MTumbon")]
    [Index(nameof(TumbonName), Name = "IX_MTumbon")]
    [Index(nameof(TumbonName2), Name = "IX_MTumbon_1")]
    public partial class Mtumbon
    {
        [Key]
        [StringLength(6)]
        public string TumbonCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string TumbonName { get; set; }
        [StringLength(50)]
        public string TumbonName2 { get; set; }
        [StringLength(5)]
        public string PostCode { get; set; }
        public byte? IsDefault { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
