using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("LabResultByType")]
    public partial class LabResultByType
    {
        [Required]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Required]
        [StringLength(20)]
        public string TypeCode { get; set; }
        [Column("ResultTypeID")]
        public byte? ResultTypeId { get; set; }
        public double? MinimumValue { get; set; }
        public double? MaximumValue { get; set; }
        [StringLength(50)]
        public string Standard { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
