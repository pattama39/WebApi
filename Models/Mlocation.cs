using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MLocation")]
    public partial class Mlocation
    {
        [Key]
        [StringLength(20)]
        public string LocationCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public byte? IsLocationItem { get; set; }
        [StringLength(255)]
        public string LocationName { get; set; }
        [StringLength(50)]
        public string Building { get; set; }
        [StringLength(50)]
        public string Room { get; set; }
        [StringLength(50)]
        public string Shelf { get; set; }
        [StringLength(50)]
        public string Lock { get; set; }
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
    }
}
