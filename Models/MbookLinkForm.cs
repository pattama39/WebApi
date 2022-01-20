using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MBookLinkForm")]
    public partial class MbookLinkForm
    {
        [Key]
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string FormCode { get; set; }
        [Required]
        [StringLength(20)]
        public string BookCode { get; set; }
        [StringLength(50)]
        public string FormName { get; set; }
        public byte? IsSystem { get; set; }
        public byte? Inactive { get; set; }
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
