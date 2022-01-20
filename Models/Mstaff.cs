using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MStaff")]
    public partial class Mstaff
    {
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(10)]
        public string CurrentOrgCode { get; set; }
        [Column("StaffGID")]
        [StringLength(36)]
        public string StaffGid { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
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
        [StringLength(50)]
        public string FirstName2 { get; set; }
        [StringLength(50)]
        public string LastName2 { get; set; }
        [Column("StaffTypeID")]
        public byte? StaffTypeId { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(20)]
        public string CertificateNo { get; set; }
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
        [StringLength(20)]
        public string PositionCode { get; set; }
        [StringLength(20)]
        public string HospitalCode { get; set; }
        [Column("DoctorTypeID")]
        public byte? DoctorTypeId { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        public byte? IsWorkQue { get; set; }
        [StringLength(50)]
        public string DefaultQueCode { get; set; }
        [Column("WorkTypeID")]
        public byte? WorkTypeId { get; set; }
        public int? ApproveDocLevel { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        public byte? IsDiscountable { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountRate { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BaseSalary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(50)]
        public string CurrentAddress1 { get; set; }
        [StringLength(50)]
        public string CurrentAddress2 { get; set; }
        [StringLength(4)]
        public string CurrentAmphurCode { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(6)]
        public string CurrentTumbonCode { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(2)]
        public string CurrentProvinceCode { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [Column("DisplayLanguageID")]
        public int? DisplayLanguageId { get; set; }
        [StringLength(255)]
        public string DisplayName2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? HireDate { get; set; }
        [Column("IDCardAddress1")]
        [StringLength(50)]
        public string IdcardAddress1 { get; set; }
        [Column("IDCardAddress2")]
        [StringLength(50)]
        public string IdcardAddress2 { get; set; }
        [StringLength(4)]
        public string IdCardAmphurCode { get; set; }
        [Column("IDCardAmphurName")]
        [StringLength(50)]
        public string IdcardAmphurName { get; set; }
        [Column("IDCardTumbonCode")]
        [StringLength(6)]
        public string IdcardTumbonCode { get; set; }
        [Column("IDCardTumbonName")]
        [StringLength(50)]
        public string IdcardTumbonName { get; set; }
        [Column("IDCardProvinceCode")]
        [StringLength(2)]
        public string IdcardProvinceCode { get; set; }
        [Column("IDCardProvinceName")]
        [StringLength(50)]
        public string IdcardProvinceName { get; set; }
        [Column("IDCardPostCode")]
        [StringLength(5)]
        public string IdcardPostCode { get; set; }
        [Column("IDCardExpireDate", TypeName = "smalldatetime")]
        public DateTime? IdcardExpireDate { get; set; }
        [Column("IDCardIssueDate", TypeName = "smalldatetime")]
        public DateTime? IdcardIssueDate { get; set; }
        [Column("IDCardNo")]
        [StringLength(50)]
        public string IdcardNo { get; set; }
        [StringLength(20)]
        public string NationCode { get; set; }
        [StringLength(20)]
        public string RaceCode { get; set; }
        [StringLength(20)]
        public string ReligionCode { get; set; }
        [Column("SSN")]
        [StringLength(50)]
        public string Ssn { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [StringLength(50)]
        public string TitleName2 { get; set; }
        [StringLength(20)]
        public string WorkStatusCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotHireDate { get; set; }
        [StringLength(50)]
        public string FatherName { get; set; }
        [StringLength(50)]
        public string MotherName { get; set; }
        public byte? IsResign { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ResignDate { get; set; }
        public int? MaxOpenRequest { get; set; }
        public int? MinOpenRequest { get; set; }
        public int? MaxInProgressRequest { get; set; }
        [StringLength(20)]
        public string ProvidentCode { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DoctorFee { get; set; }
        [StringLength(255)]
        public string UserPassword { get; set; }
        [Column("InOutStatusID")]
        public int? InOutStatusId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StaffImage { get; set; }
        [StringLength(50)]
        public string DueBack { get; set; }
        public byte? IsDeligent { get; set; }
        [StringLength(20)]
        public string DeligentCode { get; set; }
        [StringLength(20)]
        public string LevelCode { get; set; }
        [StringLength(20)]
        public string ResignReasonCode { get; set; }
        [StringLength(20)]
        public string InsuranceCode { get; set; }
        public short? IncomeMethod { get; set; }
        public short? ProbationMonth { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        [StringLength(20)]
        public string SectionCode { get; set; }
        [StringLength(50)]
        public string StaffPaymentTypeCode { get; set; }
        [StringLength(20)]
        public string InsureCode { get; set; }
        [StringLength(20)]
        public string BankCode { get; set; }
        [StringLength(20)]
        public string BankBranchCode { get; set; }
        [StringLength(20)]
        public string AccountNo { get; set; }
        public byte? IsCalcSocial { get; set; }
        public byte? IsCalcProvident { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        public float? TotalAmountDeductProvidentFund { get; set; }
        public short? IsCalcProvidentByPercent { get; set; }
        public int? PongSakStaffType { get; set; }
        [StringLength(20)]
        public string BankAccNo2 { get; set; }
        [StringLength(20)]
        public string BankBranchCode2 { get; set; }
        [StringLength(20)]
        public string BankCode2 { get; set; }
        public short? PongSakIsHouseKeeper { get; set; }
        [Column("PongSakOTPerDay")]
        public short? PongSakOtperDay { get; set; }
        [StringLength(50)]
        public string MaritalStatusCode { get; set; }
        [Column("ShiftTypeID")]
        public int? ShiftTypeId { get; set; }
        [Column("IsOT")]
        public byte? IsOt { get; set; }
        public byte? IsNextDayShift { get; set; }
        public byte? IsMustEnroll { get; set; }
        public byte? IsForeigner { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartWorkDate { get; set; }
        public int? ProbationDay { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsUseDiscountByItem { get; set; }
        public byte? IsUseDiscountByBill { get; set; }
        public byte? IsUsePasswordDiscountByItem { get; set; }
        public byte? IsUsePasswordDiscountByBill { get; set; }
        public double? DiscountByItemRate { get; set; }
        public double? DiscountByBillRate { get; set; }
        [StringLength(20)]
        public string PasswordDiscountByItem { get; set; }
        [StringLength(20)]
        public string PasswordDiscountByBill { get; set; }
        [StringLength(20)]
        public string ShiftCode1 { get; set; }
        [StringLength(20)]
        public string ShiftCode2 { get; set; }
        [StringLength(20)]
        public string ShiftCode3 { get; set; }
        [StringLength(20)]
        public string PasswordOpenShelf { get; set; }
        [Column("POSTypeID")]
        public byte? PostypeId { get; set; }
        [Column("OrderItemTypeID")]
        public byte? OrderItemTypeId { get; set; }
        public byte? IsChangePriceReturnItem { get; set; }
        public byte? IsRecieveLessZero { get; set; }
        [StringLength(50)]
        public string WorkRoomCode { get; set; }
        public byte? IsConfirmReturnItem { get; set; }
        public byte? IsEmployee { get; set; }
        public double? DiscountLimitByBill { get; set; }
        public byte? IsAccessLogin { get; set; }
        public byte? IsCheckForPaid { get; set; }
        public byte? IsShift { get; set; }
        public byte? IsNotShowPrice { get; set; }
        [Column("ShowHistoryTypeID")]
        public byte? ShowHistoryTypeId { get; set; }
        public byte? IsReduceDebt { get; set; }
        public byte? IsShowStockWarning { get; set; }
        public byte? IsCanUseWebApp { get; set; }
        public int? ShowColor { get; set; }
        [StringLength(20)]
        public string EmployeeCode { get; set; }
        public int? Priority { get; set; }
        public byte? IsPayer { get; set; }
        [StringLength(20)]
        public string UserPincode { get; set; }
        [Column(TypeName = "text")]
        public string NoteMemo { get; set; }
        [StringLength(255)]
        public string StaffDescription { get; set; }
    }
}
