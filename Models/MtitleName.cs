using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MTitleName")]
    public partial class MtitleName
    {
        [Key]
        [StringLength(20)]
        public string TitleCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        [StringLength(50)]
        public string TitleName2 { get; set; }
        public short? FromAge { get; set; }
        public short? ToAge { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        public byte? IsCheck { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
        [StringLength(20)]
        public string MaritalStatusCode { get; set; }
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
