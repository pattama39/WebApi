using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Reminder")]
    public partial class Reminder
    {
        [Key]
        [Column("ReminderID")]
        public int ReminderId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderDateTime { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [Column("OpportunityID")]
        public int? OpportunityId { get; set; }
        [StringLength(20)]
        public string ContactCode { get; set; }
        [Column("RequestID")]
        public int? RequestId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("RecurringTypeID")]
        public byte? RecurringTypeId { get; set; }
        [Column("ReminderTypeID")]
        public byte? ReminderTypeId { get; set; }
        public byte? ReminderDayIndex { get; set; }
        public byte? ReminderDayInMonth { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        public byte? IsUnEndDate { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
    }
}
