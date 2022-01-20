using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MClinicCalendar")]
    public partial class MclinicCalendar
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(10)]
        public string CalendarName { get; set; }
        public byte? IsMonday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonTimeOut { get; set; }
        public byte? IsTueday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TueTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TueTimeOut { get; set; }
        public byte? IsWedday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WedTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WedTimeOut { get; set; }
        public byte? IsThuday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThuTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThuTimeOut { get; set; }
        public byte? IsFriday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FriTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FriTimeOut { get; set; }
        public byte? IsSatday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatTimeOut { get; set; }
        public byte? IsSunday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunTimeOut { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        public byte? IsShowAppointment { get; set; }
    }
}
