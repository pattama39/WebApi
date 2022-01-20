using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ChequeReturn")]
    public partial class ChequeReturn
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }
        [Key]
        [Column("SeqIDofBankTrans")]
        public int SeqIdofBankTrans { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
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
