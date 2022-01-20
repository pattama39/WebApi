using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCounsellor")]
    public partial class Mcounsellor
    {
        [Key]
        [StringLength(20)]
        public string CounsellorCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(10)]
        public string CurrentOrgCode { get; set; }
        [Column("CounsellorGID")]
        [StringLength(36)]
        public string CounsellorGid { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
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
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(50)]
        public string CurrentAddress1 { get; set; }
        [StringLength(50)]
        public string CurrentAddress2 { get; set; }
        [StringLength(4)]
        public string CurrentAmphurCode { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(6)]
        public string CurrentTumbonCode { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(2)]
        public string CurrentProvinceCode { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
