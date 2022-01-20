using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffGroupRight")]
    public partial class StaffGroupRight
    {
        [Key]
        [StringLength(20)]
        public string StaffGroupCode { get; set; }
        [Key]
        [StringLength(50)]
        public string StaffRightCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        public byte? IsCanRead { get; set; }
        public byte? IsCanEdit { get; set; }
        public byte? IsCanCreate { get; set; }
        public byte? IsCanDelete { get; set; }
        public byte? IsCanApprove { get; set; }
        public byte? IsCanCancel { get; set; }
        public byte? IsCanPrint { get; set; }
        public byte? IsCanCencelApprove { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
