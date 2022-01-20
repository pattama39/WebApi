using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MItemStockFormat")]
    public partial class MitemStockFormat
    {
        [Key]
        [StringLength(20)]
        public string ItemStockFormatCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string ItemStockFormatName { get; set; }
        public byte? IsCheckStock { get; set; }
        public byte? IsCheckPurchase { get; set; }
        public byte? IsCheckCutStock { get; set; }
        public byte? IsCheckIncome { get; set; }
        [Column("CostTypeID")]
        public byte? CostTypeId { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
