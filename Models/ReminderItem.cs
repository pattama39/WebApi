using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReminderItem")]
    public partial class ReminderItem
    {
        [Key]
        [Column("ReminderID")]
        public int ReminderId { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Column("ResponseTypeID")]
        public byte? ResponseTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
