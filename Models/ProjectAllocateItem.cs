﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ProjectAllocateItem")]
    public partial class ProjectAllocateItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("RONo")]
        [StringLength(20)]
        public string Rono { get; set; }
        [Column("ROItemSeqID")]
        public int? RoitemSeqId { get; set; }
        public double? NetAmount { get; set; }
        public double? BalanceAmount { get; set; }
        public double? UsedAmount { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
