﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MOrganizationLogo")]
    public partial class MorganizationLogo
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "image")]
        public byte[] OrganizationLogo { get; set; }
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
        [StringLength(50)]
        public string OrganizationLogoName { get; set; }
        [Column(TypeName = "text")]
        public string OrganizationLogoPath { get; set; }
    }
}
