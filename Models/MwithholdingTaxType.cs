using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MWithholdingTaxType")]
    public partial class MwithholdingTaxType
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string WithholdingTaxTypeCode { get; set; }
        [StringLength(50)]
        public string WithholdingTaxTypeName { get; set; }
        [StringLength(50)]
        public string WithholdingTaxTypeName2 { get; set; }
        public double? WithholdingTaxRate { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
