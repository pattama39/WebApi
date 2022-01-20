using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("InvoiceReference")]
    public partial class InvoiceReference
    {
        [Key]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Key]
        [StringLength(50)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
