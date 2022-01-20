using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDatabaseConnection")]
    public partial class MdatabaseConnection
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
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("HostTypeID")]
        public byte? HostTypeId { get; set; }
        [StringLength(50)]
        public string HostAddress { get; set; }
        [StringLength(50)]
        public string HostInstanceName { get; set; }
        [StringLength(50)]
        public string DatabaseName { get; set; }
        [StringLength(50)]
        public string HostUserName { get; set; }
        [StringLength(50)]
        public string HostUserPassword { get; set; }
        [StringLength(10)]
        public string HostPort { get; set; }
        [Column("ConnectionTypeID")]
        public byte? ConnectionTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? InActive { get; set; }
    }
}
