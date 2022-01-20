using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MRecruit")]
    public partial class Mrecruit
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string RecruitCode { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string DisplayName { get; set; }
        [StringLength(50)]
        public string TitleName2 { get; set; }
        [StringLength(50)]
        public string FirstName2 { get; set; }
        [StringLength(50)]
        public string LastName2 { get; set; }
        [StringLength(100)]
        public string DisplayName2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RecruitDate { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        [StringLength(20)]
        public string PositionCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StandByDate { get; set; }
        public byte? IsOutside { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(20)]
        public string NationCode { get; set; }
        [StringLength(20)]
        public string RaceCode { get; set; }
        [StringLength(20)]
        public string ReligionCode { get; set; }
        [StringLength(20)]
        public string MaritalStatusCode { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Weight { get; set; }
        [StringLength(20)]
        public string BloodGroup { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string WorkTelephone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Column("IDCardNo")]
        [StringLength(50)]
        public string IdcardNo { get; set; }
        [Column("IDCardIssueDate", TypeName = "datetime")]
        public DateTime? IdcardIssueDate { get; set; }
        [Column("IDCardExpireDate", TypeName = "datetime")]
        public DateTime? IdcardExpireDate { get; set; }
        [Column("IDCardIssueFromProvince")]
        [StringLength(50)]
        public string IdcardIssueFromProvince { get; set; }
        [Column("IDCardIssueFromAmphur")]
        [StringLength(50)]
        public string IdcardIssueFromAmphur { get; set; }
        [Column("StatusArmyTypeID")]
        public int? StatusArmyTypeId { get; set; }
        [StringLength(50)]
        public string CurrentAddress1 { get; set; }
        [StringLength(6)]
        public string CurrentTumbonCode { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(4)]
        public string CurrentAmphurCode { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(2)]
        public string CurrentProvinceCode { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [Column("IDCardAddress1")]
        [StringLength(50)]
        public string IdcardAddress1 { get; set; }
        [Column("IDCardTumbonCode")]
        [StringLength(6)]
        public string IdcardTumbonCode { get; set; }
        [Column("IDCardTumbonName")]
        [StringLength(50)]
        public string IdcardTumbonName { get; set; }
        [Column("IDCardAmphurCode")]
        [StringLength(4)]
        public string IdcardAmphurCode { get; set; }
        [Column("IDCardAmphurName")]
        [StringLength(50)]
        public string IdcardAmphurName { get; set; }
        [Column("IDCardProvinceCode")]
        [StringLength(2)]
        public string IdcardProvinceCode { get; set; }
        [Column("IDCardProvinceName")]
        [StringLength(50)]
        public string IdcardProvinceName { get; set; }
        [Column("StatusHomeTypeID")]
        public int? StatusHomeTypeId { get; set; }
        [StringLength(100)]
        public string FatherName { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? FatherAge { get; set; }
        [StringLength(50)]
        public string FatherOccupationCode { get; set; }
        public byte? IsFatherStay { get; set; }
        [StringLength(100)]
        public string MotherName { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? MotherAge { get; set; }
        [StringLength(50)]
        public string MotherOccupationCode { get; set; }
        public byte? IsMotherStay { get; set; }
        [StringLength(100)]
        public string PersonName { get; set; }
        [StringLength(20)]
        public string PersonOccupationCode { get; set; }
        [StringLength(50)]
        public string PersonTelephone { get; set; }
        [StringLength(100)]
        public string LastLeaderName { get; set; }
        [StringLength(50)]
        public string LastLeaderTelephone { get; set; }
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
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [Column("IDCardPostCode")]
        [StringLength(5)]
        public string IdcardPostCode { get; set; }
        public byte? IsStaff { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
