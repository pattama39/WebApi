using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Announcement")]
    public partial class Announcement
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string AnnounceHeader { get; set; }
        public string AnnounceMessage { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AnnounceDate { get; set; }
        [Column("AnnounceTypeID")]
        public short? AnnounceTypeId { get; set; }
        public byte? IsAlert { get; set; }
        public byte? IsRead { get; set; }
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
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
    }
}
