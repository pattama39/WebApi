using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MSubItemGroupIPD")]
    public partial class MsubItemGroupIpd
    {
        [Key]
        [Column("SubItemGroupCodeIPD")]
        [StringLength(50)]
        public string SubItemGroupCodeIpd { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("SubItemGroupNameIPD")]
        [StringLength(50)]
        public string SubItemGroupNameIpd { get; set; }
        [Column("SubItemGroupNameIPD2")]
        [StringLength(50)]
        public string SubItemGroupNameIpd2 { get; set; }
        [Key]
        [Column("ItemGroupCodeIPD")]
        [StringLength(20)]
        public string ItemGroupCodeIpd { get; set; }
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
    }
}
