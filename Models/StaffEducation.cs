﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffEducation")]
    public partial class StaffEducation
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string StaffCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string DegreeCode { get; set; }
        [StringLength(50)]
        public string Institute { get; set; }
        [StringLength(20)]
        public string GraduateField { get; set; }
        public int? GraduatedYear { get; set; }
        public float? Grade { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
