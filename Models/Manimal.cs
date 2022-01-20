using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MAnimal")]
    public partial class Manimal
    {
        [Key]
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("OwnerGID")]
        [StringLength(36)]
        public string OwnerGid { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string AnimalCode { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(10)]
        public string BirthDateText { get; set; }
        public byte? IsHide { get; set; }
        public byte? IsDead { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeadDate { get; set; }
        [StringLength(255)]
        public string DeadRemark { get; set; }
        [StringLength(255)]
        public string DeadRelative { get; set; }
        [StringLength(255)]
        public string DeadSendTo { get; set; }
        [StringLength(20)]
        public string DoctorCodeCheck { get; set; }
        [StringLength(20)]
        public string DoctorCodeWrite { get; set; }
        public byte? IsRealBirthDate { get; set; }
        [StringLength(20)]
        public string SpeciesCode { get; set; }
        [StringLength(20)]
        public string BreedCode { get; set; }
        public byte? IsFerocious { get; set; }
        [StringLength(50)]
        public string Microchip { get; set; }
        public byte? IsSterilize { get; set; }
        public byte? InActive { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string ColorCode { get; set; }
        [StringLength(50)]
        public string FerociousNote { get; set; }
        [StringLength(50)]
        public string XrayNo { get; set; }
        [StringLength(20)]
        public string PriceLevelCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string AnimalIndex { get; set; }
        public double? ReserveAmount { get; set; }
        [Column(TypeName = "text")]
        public string OtherSideEffect { get; set; }
        [StringLength(20)]
        public string BloodGroup { get; set; }
        [Column(TypeName = "text")]
        public string PrimaryDiagnosis { get; set; }
        [Column(TypeName = "text")]
        public string FinalDiagnosis { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdmitDate { get; set; }
        [Column(TypeName = "text")]
        public string CauseDeath { get; set; }
        public double? AdmitDuration { get; set; }
        [Column(TypeName = "text")]
        public string Autopsy { get; set; }
        [Column(TypeName = "text")]
        public string FeedbackOwner { get; set; }
        [Column(TypeName = "text")]
        public string Sensible { get; set; }
        [Column("SensibleTypeID")]
        public byte? SensibleTypeId { get; set; }
        [Column(TypeName = "text")]
        public string Warning { get; set; }
        [Column(TypeName = "text")]
        public string Character { get; set; }
        [Column(TypeName = "text")]
        public string OtherRemark { get; set; }
        [Column("InActiveTypeID")]
        public byte? InActiveTypeId { get; set; }
        [StringLength(255)]
        public string InsuranceCompany { get; set; }
        [StringLength(255)]
        public string InsurancePolicyNo { get; set; }
    }
}
