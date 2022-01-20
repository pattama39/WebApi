using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("WithholdingTaxItem")]
    public partial class WithholdingTaxItem
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
        [Key]
        [Column("WHTNo")]
        [StringLength(50)]
        public string Whtno { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        public double? PayAmount { get; set; }
        [Column("WHTRate")]
        public double? Whtrate { get; set; }
        [Column("WHTAmount")]
        public double? Whtamount { get; set; }
        [Column("WHTTypeCode")]
        [StringLength(50)]
        public string WhttypeCode { get; set; }
        [StringLength(20)]
        public string AccountPeriod { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
    }
}
