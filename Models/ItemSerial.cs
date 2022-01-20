using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemSerial")]
    public partial class ItemSerial
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public byte? IsSales { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SalesDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("RONo")]
        [StringLength(20)]
        public string Rono { get; set; }
        [Column("SeqID")]
        public int? SeqId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("WHCode")]
        [StringLength(50)]
        public string Whcode { get; set; }
    }
}
