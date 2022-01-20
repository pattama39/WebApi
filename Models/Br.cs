using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BR")]
    public partial class Br
    {
        [Key]
        [Column("BRNo")]
        [StringLength(50)]
        public string Brno { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(50)]
        public string TermsOfPayment { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column("BRDate", TypeName = "smalldatetime")]
        public DateTime? Brdate { get; set; }
        [StringLength(50)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string BillingByName { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        public int? ReferenceIndex { get; set; }
        public double? TotalAmount { get; set; }
        [Column("WHTAmount")]
        public double? Whtamount { get; set; }
        public double? NetAmount { get; set; }
        public double? PayAmount { get; set; }
    }
}
