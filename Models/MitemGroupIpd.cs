using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MItemGroupIPD")]
    public partial class MitemGroupIpd
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ItemGroupCodeIPD")]
        [StringLength(20)]
        public string ItemGroupCodeIpd { get; set; }
        [Column("ItemGroupNameIPD")]
        [StringLength(50)]
        public string ItemGroupNameIpd { get; set; }
        [Column("ItemGroupNameIPD2")]
        [StringLength(50)]
        public string ItemGroupNameIpd2 { get; set; }
        public int? ShowColor { get; set; }
        public byte? IsOutStatement { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [StringLength(50)]
        public string AccountCodeRevenue { get; set; }
        [StringLength(50)]
        public string AccountCodeItem { get; set; }
    }
}
