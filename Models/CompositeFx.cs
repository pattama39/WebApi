using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CompositeFX")]
    public partial class CompositeFx
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [StringLength(20)]
        public string CompositeCode { get; set; }
        [Column("FXLevelID")]
        public short? FxlevelId { get; set; }
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
