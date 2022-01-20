using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ExpenditureItem")]
    public partial class ExpenditureItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ExpenditureNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(20)]
        public string UnitCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public double? Quantity { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalAmount { get; set; }
        public double? DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public byte? IsCalVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; }
        [StringLength(50)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SaveDate { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("POSeqID")]
        public int? PoseqId { get; set; }
    }
}
