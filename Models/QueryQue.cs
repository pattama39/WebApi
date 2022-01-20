using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("QueryQue")]
    public partial class QueryQue
    {
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(50)]
        public string CreateByAddress { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByAddress { get; set; }
        [Key]
        [Column("QueryID")]
        public int QueryId { get; set; }
        [Key]
        [Column("QueryGID")]
        [StringLength(36)]
        public string QueryGid { get; set; }
        [Column(TypeName = "text")]
        public string QueryString { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public byte? InActive { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
    }
}
