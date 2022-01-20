using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MKitchen")]
    public partial class Mkitchen
    {
        [Key]
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string KitchenCode { get; set; }
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
        [StringLength(50)]
        public string KitchenName { get; set; }
        [StringLength(50)]
        public string KitchenName2 { get; set; }
        [Column("DisplayTypeID")]
        public int? DisplayTypeId { get; set; }
        [StringLength(50)]
        public string PrinterModel { get; set; }
        [StringLength(50)]
        public string PrinterName { get; set; }
        [StringLength(50)]
        public string MonitorModel { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
