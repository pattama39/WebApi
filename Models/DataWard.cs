using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DataWard")]
    public partial class DataWard
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string WardCode { get; set; }
        [StringLength(50)]
        public string WardName { get; set; }
        [StringLength(50)]
        public string WardName2 { get; set; }
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
        [Column("WardTypeID")]
        public byte? WardTypeId { get; set; }
        public int? ShowColor { get; set; }
        public byte? InActive { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
    }
}
