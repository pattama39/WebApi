using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("HomeCareProgressNote")]
    public partial class HomeCareProgressNote
    {
        [Key]
        [Column("HomeCareProgressID")]
        public int HomeCareProgressId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public double? Temperature { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoteTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoteDate { get; set; }
        [StringLength(20)]
        public string NoteByCode { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? P { get; set; }
        public double? R { get; set; }
        [Column("BPressureHigh")]
        public double? BpressureHigh { get; set; }
        [Column("BPressureLow")]
        public double? BpressureLow { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string Hydration { get; set; }
        [Column("CRT")]
        [StringLength(50)]
        public string Crt { get; set; }
        [StringLength(50)]
        public string MucousMembrane { get; set; }
        [Column("LS")]
        [StringLength(255)]
        public string Ls { get; set; }
        [Column("HS")]
        [StringLength(255)]
        public string Hs { get; set; }
        [Column(TypeName = "text")]
        public string DoctorDiag { get; set; }
        [Column("BCSTypeID")]
        public byte? BcstypeId { get; set; }
        [Column("PulseTypeID")]
        public byte? PulseTypeId { get; set; }
        [Column(TypeName = "text")]
        public string SpecialIns { get; set; }
        [Column(TypeName = "text")]
        public string NurseNote { get; set; }
        [Column(TypeName = "text")]
        public string NurseRemark { get; set; }
        public double? TemperatureF { get; set; }
        [StringLength(50)]
        public string ProgressName { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [Column(TypeName = "text")]
        public string DoctorOrder { get; set; }
        public double? Intake { get; set; }
        public double? Output { get; set; }
        [Column("SeqID")]
        public int? SeqId { get; set; }
        [StringLength(20)]
        public string PainScore { get; set; }
        [Column("O2Sat")]
        public double? O2sat { get; set; }
        [Column(TypeName = "text")]
        public string Fluid { get; set; }
        public double? Rate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProgressFromTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProgressToTime { get; set; }
        [StringLength(20)]
        public string Assistant { get; set; }
        [StringLength(255)]
        public string Vomit { get; set; }
        [StringLength(255)]
        public string Fecal { get; set; }
        [StringLength(255)]
        public string Urine { get; set; }
        [StringLength(20)]
        public string Assistant2 { get; set; }
        [StringLength(255)]
        public string Food { get; set; }
        [StringLength(255)]
        public string Water { get; set; }
        [StringLength(20)]
        public string AuditByCode { get; set; }
        [StringLength(255)]
        public string Mentation { get; set; }
        [StringLength(255)]
        public string Posture { get; set; }
        [Column("GA")]
        [StringLength(255)]
        public string Ga { get; set; }
        [Column("ContactTypeID")]
        public byte? ContactTypeId { get; set; }
        [Column("TriageTypeID")]
        public byte? TriageTypeId { get; set; }
        public byte? ProgressRound { get; set; }
    }
}
