using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Appointment")]
    [Index(nameof(AppFromDate), Name = "IX_Appointment")]
    [Index(nameof(AppToDate), Name = "IX_Appointment_1")]
    [Index(nameof(CustomerGid), Name = "IX_Appointment_2")]
    public partial class Appointment
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("AppID")]
        public int AppId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("OwnerGID")]
        [StringLength(36)]
        public string OwnerGid { get; set; }
        [StringLength(50)]
        public string OwnerName { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(20)]
        public string QueCode { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [StringLength(20)]
        public string AppointmentByCode { get; set; }
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
        public byte? IsCome { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppFromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppToTime { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string FollowUpTypeCode { get; set; }
        [Column("IsOT")]
        public byte? IsOt { get; set; }
        public byte? FollowUpCount { get; set; }
        [Column("ICDCode")]
        [StringLength(50)]
        public string Icdcode { get; set; }
        [StringLength(20)]
        public string FixAssetCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(50)]
        public string LocationCode { get; set; }
        [StringLength(20)]
        public string CompanyCode { get; set; }
        [StringLength(20)]
        public string AppointmentTypeCode { get; set; }
        public byte? IsRecall { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(50)]
        public string AppTel { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("IsSendSMS")]
        public byte? IsSendSms { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [Column("AppointTypeID")]
        public byte? AppointTypeId { get; set; }
        public int? NotificationsDay { get; set; }
        public int? NotificationsMonth { get; set; }
        public int? NotificationsYear { get; set; }
        public int? NotificationsHour { get; set; }
        public int? NotificationsMinute { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NotificationOrderDate { get; set; }
        [Column("VNVisit")]
        public int? Vnvisit { get; set; }
        public byte? IsAllDay { get; set; }
    }
}
