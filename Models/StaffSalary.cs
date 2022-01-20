using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffSalary")]
    public partial class StaffSalary
    {
        [StringLength(50)]
        public string ApproveByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string CreateByOrgName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string DeduceName1 { get; set; }
        public double? DeduceAmount1 { get; set; }
        [StringLength(20)]
        public string DeduceName2 { get; set; }
        public double? DeduceAmount2 { get; set; }
        [StringLength(20)]
        public string DeduceName3 { get; set; }
        public double? DeduceAmount3 { get; set; }
        [StringLength(20)]
        public string DeduceName4 { get; set; }
        public double? DeduceAmount4 { get; set; }
        [StringLength(20)]
        public string DeduceName5 { get; set; }
        public double? DeduceAmount5 { get; set; }
        [StringLength(20)]
        public string DeduceName6 { get; set; }
        public double? DeduceAmount6 { get; set; }
        [StringLength(20)]
        public string DeduceName7 { get; set; }
        public double? DeduceAmount7 { get; set; }
        [StringLength(20)]
        public string DeduceName8 { get; set; }
        public double? DeduceAmount8 { get; set; }
        [StringLength(20)]
        public string DeduceName9 { get; set; }
        public double? DeduceAmount9 { get; set; }
        [StringLength(20)]
        public string DeduceName10 { get; set; }
        public double? DeduceAmount10 { get; set; }
        [Column("DepartmentID")]
        [StringLength(20)]
        public string DepartmentId { get; set; }
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [Column("IDCard")]
        [StringLength(50)]
        public string Idcard { get; set; }
        [StringLength(20)]
        public string IncomeName1 { get; set; }
        public double? IncomeAmount1 { get; set; }
        [StringLength(20)]
        public string IncomeName2 { get; set; }
        public double? IncomeAmount2 { get; set; }
        [StringLength(20)]
        public string IncomeName3 { get; set; }
        public double? IncomeAmount3 { get; set; }
        [StringLength(20)]
        public string IncomeName4 { get; set; }
        public double? IncomeAmount4 { get; set; }
        [StringLength(20)]
        public string IncomeName5 { get; set; }
        public double? IncomeAmount5 { get; set; }
        [StringLength(20)]
        public string IncomeName6 { get; set; }
        public double? IncomeAmount6 { get; set; }
        [StringLength(20)]
        public string IncomeName7 { get; set; }
        public double? IncomeAmount7 { get; set; }
        [StringLength(20)]
        public string IncomeName8 { get; set; }
        public double? IncomeAmount8 { get; set; }
        [StringLength(20)]
        public string IncomeName9 { get; set; }
        public double? IncomeAmount9 { get; set; }
        [StringLength(20)]
        public string IncomeName10 { get; set; }
        public double? IncomeAmount10 { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string ModBycode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public double? OtHolidayAmount1 { get; set; }
        public double? OtHolidayAmount2 { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public short? Period { get; set; }
        [StringLength(50)]
        public string SaveByCode { get; set; }
        [StringLength(10)]
        public string StaffCode { get; set; }
        [Column("StaffGID")]
        [StringLength(36)]
        public string StaffGid { get; set; }
        [Key]
        [Column("StaffSalaryID")]
        [StringLength(32)]
        public string StaffSalaryId { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalForSocialSecurity { get; set; }
        public double? TotalBeforeTax { get; set; }
    }
}
