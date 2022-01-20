using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("VitalSign")]
    [Index(nameof(VisitDate), Name = "IX_VitalSign")]
    [Index(nameof(AnimalGid), Name = "IX_VitalSign_1")]
    [Index(nameof(ModDate), Name = "IX_VitalSign_2")]
    [Index(nameof(CustomerGid), Name = "IX_VitalSign_3")]
    public partial class VitalSign
    {
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VisitDate { get; set; }
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
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(50)]
        public string BlindColor { get; set; }
        [StringLength(50)]
        public string EyeSightBareR { get; set; }
        [Column("EyeSightBareRU")]
        [StringLength(50)]
        public string EyeSightBareRu { get; set; }
        [StringLength(50)]
        public string EyeSightBareL { get; set; }
        [Column("EyeSightBareLU")]
        [StringLength(50)]
        public string EyeSightBareLu { get; set; }
        [Column("PEStatus")]
        public byte? Pestatus { get; set; }
        public byte? IsAbnormal { get; set; }
        [StringLength(50)]
        public string NurseAidCode { get; set; }
        [Column(TypeName = "text")]
        public string ChieftComplaint { get; set; }
        [Column(TypeName = "text")]
        public string DoctorNote { get; set; }
        [Column(TypeName = "text")]
        public string DoctorDiag { get; set; }
        [Column(TypeName = "text")]
        public string SpecialIns { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? Temperature { get; set; }
        public double? TemperatureF { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? P { get; set; }
        public double? R { get; set; }
        [Column("BPressureHigh")]
        public double? BpressureHigh { get; set; }
        [Column("BPressureLow")]
        public double? BpressureLow { get; set; }
        [Column("BPressureHigh2")]
        public double? BpressureHigh2 { get; set; }
        [Column("BPressureLow2")]
        public double? BpressureLow2 { get; set; }
        public double? Waist { get; set; }
        public double? BreastI { get; set; }
        public double? BreastO { get; set; }
        [Column("OFC")]
        public double? Ofc { get; set; }
        public double? BoneDensity { get; set; }
        [Column("FBS")]
        public double? Fbs { get; set; }
        [Column("GT")]
        public double? Gt { get; set; }
        [StringLength(50)]
        public string Hydration { get; set; }
        [Column("CRT")]
        [StringLength(50)]
        public string Crt { get; set; }
        [StringLength(50)]
        public string MucousMembrane { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [Column("LS")]
        [StringLength(255)]
        public string Ls { get; set; }
        [Column("HS")]
        [StringLength(255)]
        public string Hs { get; set; }
        [Column("BCSTypeID")]
        public byte? BcstypeId { get; set; }
        [Column("PulseTypeID")]
        public byte? PulseTypeId { get; set; }
        [StringLength(20)]
        public string BloodGroup { get; set; }
        [StringLength(20)]
        public string PainScore { get; set; }
        [StringLength(50)]
        public string Triage { get; set; }
        [Column("O2Sat")]
        public double? O2sat { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastPeriod { get; set; }
        [Column(TypeName = "text")]
        public string MedicationNote { get; set; }
        [StringLength(20)]
        public string ChieftComplaintModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChieftComplaintModDate { get; set; }
        [StringLength(20)]
        public string DoctorNoteModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DoctorNoteModDate { get; set; }
        [StringLength(20)]
        public string DoctorDiagModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DoctorDiagModDate { get; set; }
        [Column(TypeName = "text")]
        public string DoctorOrder { get; set; }
        [StringLength(20)]
        public string DoctorOrderModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DoctorOrderModDate { get; set; }
        [Column(TypeName = "text")]
        public string FinalDiag { get; set; }
        [Column(TypeName = "text")]
        public string PhyExam { get; set; }
        [Column(TypeName = "text")]
        public string PhyExam1 { get; set; }
        [Column("VitalsignHTMLDetail", TypeName = "text")]
        public string VitalsignHtmldetail { get; set; }
        [StringLength(20)]
        public string SpecialInsModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SpecialInsModDate { get; set; }
        [Column(TypeName = "text")]
        public string TxNote { get; set; }
        [Column(TypeName = "text")]
        public string RxNote { get; set; }
        [Column(TypeName = "text")]
        public string LabNote { get; set; }
        [Column("XRayNote", TypeName = "text")]
        public string XrayNote { get; set; }
        [StringLength(20)]
        public string Assistant { get; set; }
        [StringLength(20)]
        public string Assistant2 { get; set; }
        [Column("GA")]
        [StringLength(255)]
        public string Ga { get; set; }
        [StringLength(255)]
        public string Mentation { get; set; }
        [StringLength(255)]
        public string Posture { get; set; }
        [Column(TypeName = "text")]
        public string ModifyNote { get; set; }
    }
}
