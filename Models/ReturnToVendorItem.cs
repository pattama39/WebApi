using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReturnToVendorItem")]
    public partial class ReturnToVendorItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnToVendorNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("ReturnTypeID")]
        public byte? ReturnTypeId { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitCost { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(50)]
        public string LotNoI { get; set; }
        [StringLength(50)]
        public string LotNoE { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        public byte? IsCalVat { get; set; }
        [StringLength(20)]
        public string CancelByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("ROSeqID")]
        public int? RoseqId { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [Column("ItemTypeID")]
        public byte? ItemTypeId { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
    }
}
