using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReturnFromCustomerItem")]
    public partial class ReturnFromCustomerItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ReturnFromCustomerNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? NetAmount { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
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
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitCost { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        public byte? IsCalVat { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        public byte? IsSyncToServer { get; set; }
        public int? VnFromSalesItem { get; set; }
        [StringLength(20)]
        public string SalesNoFromSalesItem { get; set; }
        public int? SeqIdFromSalesItem { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("ARReceiveNo")]
        [StringLength(50)]
        public string ArreceiveNo { get; set; }
        [Column("ARReceiveNoFromSalesItem")]
        [StringLength(50)]
        public string ArreceiveNoFromSalesItem { get; set; }
        [Column("SeqIDReturnFromSalesItem")]
        public int? SeqIdreturnFromSalesItem { get; set; }
        [Column("PackageID")]
        public int? PackageId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
