using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDose5")]
    [Index(nameof(DoseName), Name = "IX_MDose5")]
    [Index(nameof(DoseName2), Name = "IX_MDose5_1")]
    public partial class Mdose5
    {
        [Key]
        [StringLength(255)]
        public string DoseCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string DoseName { get; set; }
        [StringLength(255)]
        public string DoseName2 { get; set; }
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
        [Key]
        [StringLength(50)]
        public string LanguageCode { get; set; }
    }
}
