using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Transfer")]
    public partial class Transfer
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string TransferNo { get; set; }
        [StringLength(50)]
        public string BranchOrderNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferDate { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string ToDepartmentCode { get; set; }
        [StringLength(50)]
        public string ToFactionCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column("FromWHCode")]
        [StringLength(20)]
        public string FromWhcode { get; set; }
        [Column("ToWHCode")]
        [StringLength(20)]
        public string ToWhcode { get; set; }
        [StringLength(10)]
        public string FromOrgCode { get; set; }
        [StringLength(10)]
        public string ToOrgCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public double? NetAmount { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("TransferTypeID")]
        public byte? TransferTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public int? ReferenceIndex { get; set; }
        [StringLength(50)]
        public string BranchOrderRemarkCode { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("TransferShiftsTypeID")]
        public byte? TransferShiftsTypeId { get; set; }
        public int? TransferShiftsCount { get; set; }
        [StringLength(20)]
        public string TransferShiftsReferenceNo { get; set; }
    }
}
