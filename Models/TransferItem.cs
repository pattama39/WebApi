using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("TransferItem")]
    public partial class TransferItem
    {
        [Key]
        [StringLength(20)]
        public string TransferNo { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        public double? UnitCost { get; set; }
        [StringLength(50)]
        public string LotNoIn { get; set; }
        [StringLength(50)]
        public string LotNoEx { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
        public byte? IsExpense { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferDate { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("BOSeqID")]
        public int? BoseqId { get; set; }
    }
}
