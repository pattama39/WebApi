using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("MResource")]
    public partial class Mresource
    {
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ResourceCode { get; set; }
        [Column("ResourceTypeID")]
        public byte? ResourceTypeId { get; set; }
        [Column("ResourceTH")]
        [StringLength(255)]
        public string ResourceTh { get; set; }
        [Column("ResourceEN")]
        [StringLength(255)]
        public string ResourceEn { get; set; }
        [StringLength(50)]
        public string ResourceCustom1 { get; set; }
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
    }
}
