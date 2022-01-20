using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PCReimburse")]
    public partial class Pcreimburse
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Key]
        [Column("PCReimburseNo")]
        [StringLength(50)]
        public string PcreimburseNo { get; set; }
        [Column("PCCode")]
        [StringLength(20)]
        public string Pccode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        public double? TotalAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? BankAmount { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public int? ReferenceIndex { get; set; }
    }
}
