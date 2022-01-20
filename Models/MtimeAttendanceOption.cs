using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MTimeAttendanceOptions")]
    public partial class MtimeAttendanceOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string Address3 { get; set; }
        [Column("lateinduration")]
        public int? Lateinduration { get; set; }
        [Column("earlyoutduration")]
        public int? Earlyoutduration { get; set; }
        [StringLength(2)]
        public string LanguageSystem { get; set; }
        [StringLength(50)]
        public string Datesystem { get; set; }
        public byte? IsAllowEnterStaffCode { get; set; }
        [StringLength(50)]
        public string ClockFontSize { get; set; }
        public byte? IsAllowNoFinger { get; set; }
        public byte? IsFullScreen { get; set; }
        public byte? IsUsePasswordToCloseClock { get; set; }
        [StringLength(50)]
        public string CloseClockPassword { get; set; }
        public byte? IsAllowEnrollNextDay { get; set; }
        [StringLength(50)]
        public string StaffCodeFormat { get; set; }
        public int? Threshold { get; set; }
        [Column("ImageDPI")]
        public int? ImageDpi { get; set; }
        public int? MinMinutiaCount { get; set; }
        public byte? IsCheckForDuplicateFinger { get; set; }
        public byte? IsParentMustIn { get; set; }
        public byte? IsParentMustOut { get; set; }
        public float? ShowStatusDelayTime { get; set; }
        [StringLength(255)]
        public string BackgroundPicture { get; set; }
        public byte? IsAskIfNotRegisterFinger { get; set; }
        public byte? IsAutoRefreshInOut { get; set; }
        public byte? IsUseFastSystem { get; set; }
        [Column("FAR")]
        public int? Far { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        public float? EnrollDelayTime { get; set; }
        [Column("BiometricTypeID")]
        public int? BiometricTypeId { get; set; }
        public byte? IsGetTimeFromServer { get; set; }
        [StringLength(255)]
        public string PathSoundEnrollIn { get; set; }
        [StringLength(255)]
        public string PathSoundEnrollOut { get; set; }
        [StringLength(255)]
        public string PathSoundGoodFingerprint { get; set; }
        [StringLength(255)]
        public string PathSoundInvalidFingerprint { get; set; }
        [StringLength(255)]
        public string PathSoundWorking { get; set; }
        [StringLength(255)]
        public string PathSoundErrorDuplicateFingerprint { get; set; }
        [StringLength(255)]
        public string PathSoundDataFingerprintIsNotFound { get; set; }
        [StringLength(255)]
        public string PathSoundScanFingerprint { get; set; }
        [StringLength(255)]
        public string PathSoundCanNotEnrollIn { get; set; }
        [StringLength(255)]
        public string PathSoundCanNotEnrollOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EarlyTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? ShowStaffPictureDelayTime { get; set; }
        public byte? IsShowEnrollOptions { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string CurrentBuild { get; set; }
    }
}
