using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class DataGenericSpecy
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DataCode { get; set; }
        [StringLength(50)]
        public string DataName { get; set; }
        [StringLength(50)]
        public string DataName2 { get; set; }
        [StringLength(50)]
        public string Remark1 { get; set; }
        [StringLength(50)]
        public string Remark2 { get; set; }
        [StringLength(50)]
        public string Remark3 { get; set; }
        [StringLength(50)]
        public string Remark4 { get; set; }
        [StringLength(50)]
        public string Remark5 { get; set; }
        [StringLength(50)]
        public string Remark6 { get; set; }
        [StringLength(50)]
        public string Remark7 { get; set; }
        [StringLength(50)]
        public string Remark8 { get; set; }
        [StringLength(50)]
        public string Remark9 { get; set; }
        [StringLength(50)]
        public string Remark10 { get; set; }
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
