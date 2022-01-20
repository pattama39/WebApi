using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MHospital")]
    public partial class Mhospital
    {
        [Key]
        [Column("HospitalID")]
        [StringLength(50)]
        public string HospitalId { get; set; }
        [StringLength(10)]
        public string HospitalCode { get; set; }
        [StringLength(50)]
        public string HospitalName { get; set; }
        [Column("DatabaseID")]
        [StringLength(50)]
        public string DatabaseId { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        [Column("VersionTypeID")]
        public short? VersionTypeId { get; set; }
        public short? MaxUser { get; set; }
        public short? MaxOrganization { get; set; }
    }
}
