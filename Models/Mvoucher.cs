using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MVoucher")]
    public partial class Mvoucher
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        [Key]
        [Column("VoucherLotID")]
        public int VoucherLotId { get; set; }
        [StringLength(50)]
        public string VoucherLotPin { get; set; }
        public double? Price { get; set; }
        public int? TotalVoucher { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(50)]
        public string ItemGroupCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        public byte? InActive { get; set; }
    }
}
