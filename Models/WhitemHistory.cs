using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("WHItemHistory")]
    public partial class WhitemHistory
    {
        [Key]
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        public int StockMonth { get; set; }
        [Key]
        public int StockYear { get; set; }
        [Key]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime StockDate { get; set; }
        public double? CurrentQty { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
