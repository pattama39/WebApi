using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MProcedure")]
    public partial class Mprocedure
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ProcedureCode { get; set; }
        [StringLength(255)]
        public string ProcedureName { get; set; }
        [StringLength(255)]
        public string Practices { get; set; }
        [StringLength(255)]
        public string Ideas { get; set; }
        [StringLength(50)]
        public string Innovation { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        [StringLength(510)]
        public string Practics { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
