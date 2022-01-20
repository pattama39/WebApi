using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AccountCode")]
    public partial class AccountCode
    {
        [Key]
        [Column("AccountCode")]
        [StringLength(50)]
        public string AccountCode1 { get; set; }
        [StringLength(255)]
        public string AccountName { get; set; }
        [StringLength(255)]
        public string AccountName2 { get; set; }
        [Column("AccountTypeID")]
        public short? AccountTypeId { get; set; }
        public byte? IsSubAccount { get; set; }
        [StringLength(50)]
        public string MainAccountCode { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public double? BeginAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BeginDate { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsForecast { get; set; }
    }
}
