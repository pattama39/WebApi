using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MJournalOptions")]
    public partial class MjournalOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(255)]
        public string DefaultTemplate { get; set; }
        public int? PenColor { get; set; }
        public int? PenWidth { get; set; }
        public int? PenHeight { get; set; }
        public int? PenTransparency { get; set; }
        public int? HighlightColor { get; set; }
        public int? HighlightWidth { get; set; }
        public int? HighlightHeight { get; set; }
        public int? HighlightTransparency { get; set; }
        public int? EraserColor { get; set; }
        public int? EraserWidth { get; set; }
        public int? EraserHeight { get; set; }
        public int? EraserTransparency { get; set; }
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
    }
}
