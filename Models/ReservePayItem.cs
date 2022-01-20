﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReservePayItem")]
    public partial class ReservePayItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReservePayNo { get; set; }
        [Key]
        public short SeqNo { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(53)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
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
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
    }
}
