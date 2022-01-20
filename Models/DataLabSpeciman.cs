using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class DataLabSpeciman
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Key]
        [StringLength(20)]
        public string SpecimenCode { get; set; }
        [StringLength(50)]
        public string SpecimenName { get; set; }
        [StringLength(50)]
        public string SpecimenName2 { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
