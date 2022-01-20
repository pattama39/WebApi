using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MStaffRight")]
    public partial class MstaffRight
    {
        [Key]
        [StringLength(50)]
        public string StaffRightCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string SourceProgram { get; set; }
        [StringLength(20)]
        public string StaffRightGroupCode { get; set; }
        [StringLength(50)]
        public string StaffRightName { get; set; }
        [StringLength(50)]
        public string StaffRightName2 { get; set; }
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
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(7)]
        public string RightFlag { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
