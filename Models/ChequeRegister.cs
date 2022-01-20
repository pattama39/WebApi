using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ChequeRegister")]
    public partial class ChequeRegister
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChequeDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChequeCreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CompleteDate { get; set; }
        public double? ChequeAmount { get; set; }
        [Key]
        [Column("BookBankID")]
        [StringLength(50)]
        public string BookBankId { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
        [Column(TypeName = "text")]
        public string RefNo2 { get; set; }
        [Column("RefTypeID2")]
        public byte? RefTypeId2 { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column("CurrentStatusID")]
        public byte? CurrentStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CurrentStatusDate { get; set; }
        [Column(TypeName = "text")]
        public string CurrentStatusRemark { get; set; }
        [Column("LastStatusID")]
        public byte? LastStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastStatusDate { get; set; }
        [Column(TypeName = "text")]
        public string LastStatusRemark { get; set; }
        [Column("ReceiverTypeID")]
        public byte? ReceiverTypeId { get; set; }
        [Column("ChequeTypeID")]
        public byte? ChequeTypeId { get; set; }
    }
}
