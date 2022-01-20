using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AdmitDischarge")]
    public partial class AdmitDischarge
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdmitDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdmitTime { get; set; }
        [StringLength(20)]
        public string RoomCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DischargeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DischargeTime { get; set; }
        [StringLength(20)]
        public string DischageStatusCode { get; set; }
        [StringLength(20)]
        public string DischargeTypeCode { get; set; }
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
        [Column(TypeName = "text")]
        public string RemarkAdmit { get; set; }
        [Column(TypeName = "text")]
        public string RemarkDischarge { get; set; }
        public byte? IsAdmit { get; set; }
        [StringLength(20)]
        public string AdmitDepartmentCode { get; set; }
        [StringLength(20)]
        public string AdmitByDoctorCode { get; set; }
        public byte? IsDischarge { get; set; }
        [StringLength(50)]
        public string DischargeStatusCode { get; set; }
        [StringLength(255)]
        public string DischargeNote { get; set; }
        [StringLength(50)]
        public string ReferInTypeCode { get; set; }
        [StringLength(20)]
        public string ReferInFromCode { get; set; }
        public byte? IsReferIn { get; set; }
        [StringLength(20)]
        public string ReferOutToCode { get; set; }
        [StringLength(20)]
        public string CauseCode { get; set; }
        [StringLength(20)]
        public string FoodTypeCode { get; set; }
        [StringLength(255)]
        public string FoodTypeNote { get; set; }
        [Column(TypeName = "text")]
        public string ForwardSymptoms { get; set; }
        [Column("PrognosisTypeID")]
        public byte? PrognosisTypeId { get; set; }
        [Column(TypeName = "text")]
        public string PatientStuff { get; set; }
        [StringLength(20)]
        public string DischargeByCode { get; set; }
        [StringLength(20)]
        public string ReleaseByCode { get; set; }
        [StringLength(20)]
        public string RecordByCode { get; set; }
        [Column("AdmitTypeID")]
        public byte? AdmitTypeId { get; set; }
        [StringLength(50)]
        public string ReferInFromLocation { get; set; }
        [Column("DischargeTypeID")]
        public byte? DischargeTypeId { get; set; }
        [StringLength(50)]
        public string ReferOutToLocation { get; set; }
        [Column("PetCareChargeTypeID")]
        public byte? PetCareChargeTypeId { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
    }
}
