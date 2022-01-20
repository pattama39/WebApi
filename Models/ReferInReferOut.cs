using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ReferInReferOut")]
    public partial class ReferInReferOut
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReferInDate { get; set; }
        [StringLength(255)]
        public string ReferInFrom { get; set; }
        [Column(TypeName = "text")]
        public string ReferInRemark { get; set; }
        [StringLength(20)]
        public string ReferInTypeCode { get; set; }
        public byte? IsReferIn { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReferOutDate { get; set; }
        [StringLength(255)]
        public string ReferOutTo { get; set; }
        [Column(TypeName = "text")]
        public string ReferOutRemark { get; set; }
        [StringLength(50)]
        public string ReferOutStatusCode { get; set; }
        [StringLength(20)]
        public string ReferOutTypeCode { get; set; }
        public byte? IsReferOut { get; set; }
    }
}
