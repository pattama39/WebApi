using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AEReimburseItem")]
    public partial class AereimburseItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [Key]
        [Column("AEReimburseNo")]
        [StringLength(50)]
        public string AereimburseNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("AENo")]
        [StringLength(50)]
        public string Aeno { get; set; }
        public double? NetAmount { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
