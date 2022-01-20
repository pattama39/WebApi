using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExchangeSchedule")]
    [Index(nameof(CreateByOrgCode), nameof(TemplateCode), Name = "IX_ExchangeSchedule", IsUnique = true)]
    public partial class ExchangeSchedule
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ExchangeScheduleID")]
        public int ExchangeScheduleId { get; set; }
        [Required]
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NextRunDate { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? InActive { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }

        [ForeignKey("CreateByOrgCode,TemplateCode")]
        [InverseProperty("ExchangeSchedule")]
        public virtual ExchangeTemplate ExchangeTemplate { get; set; }
        [InverseProperty("ExchangeSchedule")]
        public virtual ExchangeScheduleBranch ExchangeScheduleBranch { get; set; }
    }
}
