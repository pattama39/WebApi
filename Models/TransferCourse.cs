using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("TransferCourse")]
    public partial class TransferCourse
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
        [StringLength(20)]
        public string SellByCode { get; set; }
        [StringLength(20)]
        public string DiagByCode { get; set; }
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
        public byte? IsCancel { get; set; }
        [StringLength(50)]
        public string CancelBy { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastDoDate { get; set; }
        [StringLength(100)]
        public string CustomerName { get; set; }
        [StringLength(100)]
        public string CancelReason { get; set; }
        [StringLength(100)]
        public string OrganizationName { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        public byte? IsExpire { get; set; }
        public int? CourseExpire { get; set; }
    }
}
