using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExchangeTemplateItem")]
    [Index(nameof(CreateByOrgCode), nameof(TemplateCode), nameof(TableName), Name = "IX_ExchangeTemplateItem", IsUnique = true)]
    public partial class ExchangeTemplateItem
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Required]
        [StringLength(50)]
        public string TableName { get; set; }
        [StringLength(4000)]
        public string PrimarykeyField { get; set; }
        [StringLength(4000)]
        public string SelectedField { get; set; }
        [StringLength(4000)]
        public string WherePart { get; set; }
        public byte Command { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }

        [ForeignKey("CreateByOrgCode,TemplateCode")]
        [InverseProperty("ExchangeTemplateItems")]
        public virtual ExchangeTemplate ExchangeTemplate { get; set; }
    }
}
