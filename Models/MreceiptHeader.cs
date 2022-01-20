using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MReceiptHeader")]
    public partial class MreceiptHeader
    {
        [Key]
        [StringLength(20)]
        public string ReceiptHeaderCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string ReceiptHeaderName { get; set; }
        [StringLength(255)]
        public string ReceiptHeaderName2 { get; set; }
        [StringLength(50)]
        public string ReportFileName { get; set; }
        public byte? IsPrintByOrderAmount { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        [Column("DocTypeID")]
        public int? DocTypeId { get; set; }
        [Column("FieldTypeID")]
        public int? FieldTypeId { get; set; }
        [Column("FieldDocTypeID")]
        public int? FieldDocTypeId { get; set; }
        public byte? IsRunningNo { get; set; }
    }
}
