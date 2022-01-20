using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffReturnAdvance")]
    public partial class StaffReturnAdvance
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnAdvanceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnAdvanceDate { get; set; }
        [StringLength(20)]
        public string AdvanceRequestNo { get; set; }
        [Column("ReceieveTypeID")]
        public byte? ReceieveTypeId { get; set; }
        public double? ReturnAmount { get; set; }
        public byte? PeriodNo { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("InDeID")]
        public int? InDeId { get; set; }
        public byte? IsReturn { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
