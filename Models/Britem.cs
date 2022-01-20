using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BRItem")]
    public partial class Britem
    {
        [Key]
        [Column("BRNo")]
        [StringLength(50)]
        public string Brno { get; set; }
        [Key]
        [StringLength(50)]
        public string RefNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column("BRDate", TypeName = "smalldatetime")]
        public DateTime? Brdate { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? PayAmount { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsDelete { get; set; }
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RefDate { get; set; }
        [Column("RefTypeID")]
        public byte? RefTypeId { get; set; }
    }
}
