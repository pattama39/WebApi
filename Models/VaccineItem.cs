using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("VaccineItem")]
    public partial class VaccineItem
    {
        [Key]
        [Column("VaccineItemID")]
        public int VaccineItemId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InjectionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RecordDate { get; set; }
        [StringLength(50)]
        public string VaccineCode { get; set; }
        [StringLength(255)]
        public string VaccineName { get; set; }
        [Column("VaccineProductTypeID")]
        public byte? VaccineProductTypeId { get; set; }
        [StringLength(255)]
        public string BatchNo { get; set; }
        public byte? InjectionType { get; set; }
        public double? Quantity { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(20)]
        public string RecordByCode { get; set; }
        [StringLength(20)]
        public string InjectionByCode { get; set; }
        [StringLength(255)]
        public string InjectionByName { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
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
    }
}
