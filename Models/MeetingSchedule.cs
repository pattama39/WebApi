using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MeetingSchedule")]
    public partial class MeetingSchedule
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string MeetingCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
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
        [StringLength(50)]
        public string Topic { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MeetingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToTime { get; set; }
        [StringLength(50)]
        public string MeetingByName { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
