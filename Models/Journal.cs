using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Journal")]
    public partial class Journal
    {
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
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column("DocTypeID")]
        public byte? DocTypeId { get; set; }
        [StringLength(50)]
        public string RefDoc { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        public double? CreditAmount { get; set; }
        public double? DebitAmount { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "text")]
        public string Remark2 { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(50)]
        public string ProjectCode { get; set; }
        [StringLength(50)]
        public string StaffCode { get; set; }
        public byte? IsActiveReverse { get; set; }
        public byte? IsPost { get; set; }
        public byte? IsReverseAlready { get; set; }
        [Column("IsVNLastConfirm")]
        public byte? IsVnlastConfirm { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string RecurringNo { get; set; }
        [StringLength(20)]
        public string RecurringGroupNo { get; set; }
        [StringLength(255)]
        public string RecurringName { get; set; }
        [StringLength(20)]
        public string RecurringGroupCode { get; set; }
        [Column("DocExpenseTypeID")]
        public byte? DocExpenseTypeId { get; set; }
        public int? ReferenceIndex { get; set; }
    }
}
