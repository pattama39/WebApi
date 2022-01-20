using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BranchOrder")]
    public partial class BranchOrder
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Key]
        [StringLength(50)]
        public string BranchOrderNo { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(50)]
        public string ToDepartmentCode { get; set; }
        [Column("ToWHCode")]
        [StringLength(50)]
        public string ToWhcode { get; set; }
        [StringLength(50)]
        public string ToFactionCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public double? NetAmount { get; set; }
        public byte? IsComplete { get; set; }
        [StringLength(255)]
        public string TransferRemark { get; set; }
        public int? ReferenceIndex { get; set; }
        [StringLength(50)]
        public string BranchOrderRemarkCode { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
    }
}
