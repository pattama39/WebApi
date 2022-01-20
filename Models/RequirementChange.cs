using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("RequirementChange")]
    public partial class RequirementChange
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ChangeID")]
        public int ChangeId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }
        [Column("RefRequirementID")]
        public int? RefRequirementId { get; set; }
        public int? Effort { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
