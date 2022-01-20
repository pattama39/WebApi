﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DataCheckUpRemark")]
    public partial class DataCheckUpRemark
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CheckupCode { get; set; }
        [Key]
        [StringLength(50)]
        public string DataCode { get; set; }
        [StringLength(50)]
        public string DataName { get; set; }
        [StringLength(50)]
        public string DataName2 { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
