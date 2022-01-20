using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MessageTemplate")]
    public partial class MessageTemplate
    {
        [Key]
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [StringLength(50)]
        public string TemplateName { get; set; }
        [StringLength(255)]
        public string TemplateFormat { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        public byte? InActive { get; set; }
        public byte? IsSendWhenReceive { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        [Column("TemplateTypeID")]
        public int? TemplateTypeId { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
    }
}
