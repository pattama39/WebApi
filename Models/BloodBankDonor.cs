using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BloodBankDonor")]
    public partial class BloodBankDonor
    {
        [Key]
        [Column("BloodBankID")]
        public int BloodBankId { get; set; }
        [StringLength(20)]
        public string ProductCode { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CollectionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        public double? Volume { get; set; }
        [Column("DonorGID")]
        [StringLength(36)]
        public string DonorGid { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("PCV")]
        public double? Pcv { get; set; }
        [Column("RBC")]
        public double? Rbc { get; set; }
        [Column("WBC")]
        public double? Wbc { get; set; }
        [Column("PLT")]
        public double? Plt { get; set; }
        public double? Creat { get; set; }
        [Column("SGDT")]
        public double? Sgdt { get; set; }
        [Column("HCT")]
        public double? Hct { get; set; }
        [StringLength(20)]
        public string BloodGroupCode { get; set; }
        [StringLength(50)]
        public string HosiptialName { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        [StringLength(50)]
        public string OnwerName { get; set; }
        [Column("DonorTypeID")]
        public byte? DonorTypeId { get; set; }
        public byte? IsFinish { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        public string RecordByCode { get; set; }
    }
}
