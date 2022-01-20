using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDocGroup")]
    public partial class MdocGroup
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(36)]
        public string DocGroupCode { get; set; }
        [StringLength(36)]
        public string ParentDocGroupCode { get; set; }
        [StringLength(50)]
        public string DocGroupName { get; set; }
        [StringLength(50)]
        public string DocGroupName2 { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("ProgramTypeID")]
        public int? ProgramTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsDefaultGroup { get; set; }
        public byte? InActive { get; set; }
        public int? Priority { get; set; }
    }
}
