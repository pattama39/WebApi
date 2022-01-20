using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MKeyCard")]
    public partial class MkeyCard
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string KeyCardCode { get; set; }
        [StringLength(50)]
        public string KeyCardName { get; set; }
        [StringLength(50)]
        public string KeyCardName2 { get; set; }
        [StringLength(50)]
        public string KeyCardBrandName { get; set; }
        [StringLength(50)]
        public string KeyCardSerial { get; set; }
        [StringLength(255)]
        public string VendorName { get; set; }
        [StringLength(50)]
        public string VendorTelNo { get; set; }
        [StringLength(255)]
        public string VendorAddress { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
