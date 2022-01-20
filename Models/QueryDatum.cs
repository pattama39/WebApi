using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class QueryDatum
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("QueryID")]
        public int QueryId { get; set; }
        [StringLength(50)]
        public string DataType { get; set; }
        [StringLength(50)]
        public string QueryName { get; set; }
        [StringLength(255)]
        public string SelectPart { get; set; }
        [StringLength(255)]
        public string FromPart { get; set; }
        [StringLength(255)]
        public string WherePart { get; set; }
        [StringLength(255)]
        public string OrderPart { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
