using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExchangeTemplate")]
    [Index(nameof(TemplateName), nameof(CreateByOrgCode), Name = "IX_ExchangeTemplate", IsUnique = true)]
    public partial class ExchangeTemplate
    {
        public ExchangeTemplate()
        {
            ExchangeTemplateItems = new HashSet<ExchangeTemplateItem>();
        }

        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [StringLength(50)]
        public string TemplateName { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }

        [InverseProperty("ExchangeTemplate")]
        public virtual ExchangeSchedule ExchangeSchedule { get; set; }
        [InverseProperty(nameof(ExchangeTemplateItem.ExchangeTemplate))]
        public virtual ICollection<ExchangeTemplateItem> ExchangeTemplateItems { get; set; }
    }
}
