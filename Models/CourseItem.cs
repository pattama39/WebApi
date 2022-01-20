using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CourseItem")]
    [Index(nameof(Vn), Name = "IX_CourseItem")]
    [Index(nameof(CustomerGid), Name = "IX_CourseItem_1")]
    [Index(nameof(DoDate), Name = "IX_CourseItem_2")]
    [Index(nameof(ModDate), Name = "IX_CourseItem_3")]
    [Index(nameof(IsSyncToServer), Name = "IX_CourseItem_4")]
    public partial class CourseItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CourseNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DoDate { get; set; }
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
        public string FixAssetCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DoTime { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsDelete { get; set; }
        public byte? IsCancel { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(50)]
        public string OrganizationName { get; set; }
        [StringLength(100)]
        public string Remark { get; set; }
        public double? Quantity { get; set; }
        [StringLength(20)]
        public string DoByCode { get; set; }
        [StringLength(20)]
        public string SellByCode { get; set; }
        [StringLength(20)]
        public string DiagByCode { get; set; }
        [StringLength(20)]
        public string ConsultByCode { get; set; }
        [Column("CurrentQTY")]
        public double? CurrentQty { get; set; }
        public double? CurrentUse { get; set; }
        public double? TotalCredit { get; set; }
        public double? CurrentCredit { get; set; }
        [Column("TotalQTY")]
        public double? TotalQty { get; set; }
        [Column("CurrentUseQTY")]
        public double? CurrentUseQty { get; set; }
    }
}
