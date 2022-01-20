using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExchangeJob")]
    public partial class ExchangeJob
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ExchangeJobID")]
        public int ExchangeJobId { get; set; }
        [Key]
        [StringLength(10)]
        public string SendToOrgCode { get; set; }
        [Key]
        public byte IsRemote { get; set; }
        [StringLength(50)]
        public string JobName { get; set; }
        [StringLength(50)]
        public string TemplateCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsProcess { get; set; }
        public byte? IsSend { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
