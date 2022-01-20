using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MStaffGroup")]
    public partial class MstaffGroup
    {
        [Key]
        [StringLength(20)]
        public string StaffGroupCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string StaffGroupName { get; set; }
        [StringLength(50)]
        public string StaffGroupName2 { get; set; }
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
        public byte? IsViewOtherDoc { get; set; }
        public byte? IsDeleteDoc { get; set; }
        public byte? IsDeleteOtherDoc { get; set; }
        public byte? IsCopyDoc { get; set; }
        public byte? IsCopyOtherDoc { get; set; }
        public byte? IsEditDoc { get; set; }
        public byte? IsEditOtherDoc { get; set; }
        public byte? IsAddDoc { get; set; }
        public byte? IsPrintDoc { get; set; }
        public byte? IsPrintOtherDoc { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
