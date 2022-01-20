using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MVoucherType")]
    public partial class MvoucherType
    {
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
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string VoucherTypeCode { get; set; }
        [StringLength(50)]
        public string VoucherTypeName { get; set; }
        [StringLength(50)]
        public string VoucherTypeName2 { get; set; }
        public double? Price { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public byte? IsOneTimeVoucher { get; set; }
        public byte? InActive { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        public byte? IsFixByItem { get; set; }
        public byte? IsUnlimitDate { get; set; }
    }
}
