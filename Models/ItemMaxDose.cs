using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemMaxDose")]
    public partial class ItemMaxDose
    {
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        public short FromAge { get; set; }
        [Key]
        public short ToAge { get; set; }
        [Key]
        [StringLength(1)]
        public string Sex { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? MaxDose { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
