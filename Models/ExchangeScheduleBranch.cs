using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExchangeScheduleBranch")]
    public partial class ExchangeScheduleBranch
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ExchangeScheduleID")]
        public int ExchangeScheduleId { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }

        [ForeignKey("CreateByOrgCode,ExchangeScheduleId")]
        [InverseProperty("ExchangeScheduleBranch")]
        public virtual ExchangeSchedule ExchangeSchedule { get; set; }
    }
}
