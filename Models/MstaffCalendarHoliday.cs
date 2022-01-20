using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MStaffCalendarHoliday")]
    public partial class MstaffCalendarHoliday
    {
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NoWorkDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoWorkFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoWorkToTime { get; set; }
        public byte? RecurrenceType { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WeekDate { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string HolidayNote { get; set; }
    }
}
