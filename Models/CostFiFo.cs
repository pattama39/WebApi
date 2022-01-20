using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CostFiFo")]
    public partial class CostFiFo
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Key]
        [Column("SeqIDSales")]
        public short SeqIdsales { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? UnitCost { get; set; }
        [StringLength(20)]
        public string RoNo { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
        [Column("SeqIDRo")]
        public short? SeqIdro { get; set; }
        public byte? IsErrorCost { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
