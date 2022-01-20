using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("StaffInsurance")]
    public partial class StaffInsurance
    {
        [Required]
        [StringLength(10)]
        public string InsuranceNo { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string InsuranceRight { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string InsuranceCompanyCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
