using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DocApproveLevel")]
    public partial class DocApproveLevel
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("DocTypeID")]
        public int DocTypeId { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("DocApproveLevel")]
        public int? DocApproveLevel1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget { get; set; }
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
