using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("DeliveryOrderItem")]
    public partial class DeliveryOrderItem
    {
        [Required]
        [Column("DONo")]
        [StringLength(50)]
        public string Dono { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("SeqID")]
        public short SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? UnitCost { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? NetAmount { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SocAmount { get; set; }
        [StringLength(50)]
        public string ReceiptGroupCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
