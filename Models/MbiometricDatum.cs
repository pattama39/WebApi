using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MBiometricData")]
    [Index(nameof(OwnerGid), Name = "IX_MBiometricData")]
    [Index(nameof(ModDate), Name = "IX_MBiometricData_1")]
    public partial class MbiometricDatum
    {
        [Key]
        [Column("BioDataGID")]
        [StringLength(36)]
        public string BioDataGid { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [MaxLength(8000)]
        public byte[] BioData { get; set; }
        public int? BioDataIndex { get; set; }
        [Column("BioDataTypeID")]
        public int? BioDataTypeId { get; set; }
        [Column("OwnerGID")]
        [StringLength(36)]
        public string OwnerGid { get; set; }
        [StringLength(20)]
        public string OwnerCode { get; set; }
        [Column("OwnerTypeID")]
        public int? OwnerTypeId { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(100)]
        public string OwnerName { get; set; }
        [StringLength(100)]
        public string OwnerName2 { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
