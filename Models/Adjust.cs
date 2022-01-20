using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Adjust")]
    public partial class Adjust
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string AdjustNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjustDate { get; set; }
        [StringLength(50)]
        public string ReferenceNo { get; set; }
        [StringLength(50)]
        public string AdjustByCode { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(50)]
        public string AdjustCode { get; set; }
        [Column("AdjustTypeID")]
        public short? AdjustTypeId { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
        [StringLength(20)]
        public string StaffCode { get; set; }
        public double? NetAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
