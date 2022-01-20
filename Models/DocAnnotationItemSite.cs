using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DocAnnotationItemSite")]
    public partial class DocAnnotationItemSite
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("AnnotationID")]
        public int AnnotationId { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [Key]
        public int InjectionSiteNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column("VN")]
        public int Vn { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
