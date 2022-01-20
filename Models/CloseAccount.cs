using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CloseAccount")]
    public partial class CloseAccount
    {
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [Column("AccountID")]
        public short AccountId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDate { get; set; }
        [StringLength(10)]
        public string CloseByCode { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? DocMoney { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? AmountMoney { get; set; }
        [StringLength(50)]
        public string LocationCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
