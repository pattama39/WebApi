using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CaseComplaint")]
    public partial class CaseComplaint
    {
        [Key]
        [Column("ComplaintID")]
        public int ComplaintId { get; set; }
        [StringLength(20)]
        public string ComplaintCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string ComplaintComment { get; set; }
        [Column("ComplaintVoteTypeID")]
        public short? ComplaintVoteTypeId { get; set; }
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
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
    }
}
