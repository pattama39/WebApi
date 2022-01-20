using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Course")]
    [Index(nameof(Vn), Name = "IX_Course")]
    [Index(nameof(CustomerGid), Name = "IX_Course_1")]
    [Index(nameof(ItemCode), Name = "IX_Course_2")]
    [Index(nameof(CourseDate), Name = "IX_Course_3")]
    [Index(nameof(ModDate), Name = "IX_Course_4")]
    [Index(nameof(IsDelete), Name = "IX_Course_5")]
    [Index(nameof(IsSyncToServer), Name = "IX_Course_6")]
    public partial class Course
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CourseNo { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public byte? IsComplete { get; set; }
        public short? TotalCredit { get; set; }
        public double? TotalQuantity { get; set; }
        public short? CurrentUse { get; set; }
        public double? CurrentUseQuantity { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CourseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        public byte? IsCancel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancelDate { get; set; }
        [StringLength(50)]
        public string CancelBy { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastDoDate { get; set; }
        [StringLength(50)]
        public string OrganizationName { get; set; }
        [StringLength(100)]
        public string CustomerName { get; set; }
        [StringLength(100)]
        public string CancelReason { get; set; }
        public int? CourseExpire { get; set; }
        public byte? IsExpire { get; set; }
        [StringLength(20)]
        public string SellByCode { get; set; }
        [StringLength(20)]
        public string DiagByCode { get; set; }
        [StringLength(20)]
        public string ConsultByCode { get; set; }
        [StringLength(20)]
        public string DoByCode { get; set; }
        [StringLength(36)]
        public string CoCourseCustomer1 { get; set; }
        [StringLength(36)]
        public string CoCourseCustomer2 { get; set; }
        [StringLength(36)]
        public string CoCourseCustomer3 { get; set; }
        [StringLength(36)]
        public string CoCourseCustomer4 { get; set; }
        [StringLength(36)]
        public string CoCourseCustomer5 { get; set; }
        [Column("IsFX")]
        public byte? IsFx { get; set; }
        [Column("FXRemark")]
        [StringLength(255)]
        public string Fxremark { get; set; }
        [Column("CourseGroupID")]
        public int? CourseGroupId { get; set; }
    }
}
