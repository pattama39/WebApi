using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDoseShortcut")]
    public partial class MdoseShortcut
    {
        [Key]
        [StringLength(255)]
        public string DoseCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(255)]
        public string Dose1Code { get; set; }
        [StringLength(255)]
        public string Dose2Code { get; set; }
        [StringLength(255)]
        public string Dose3Code { get; set; }
        [StringLength(255)]
        public string Dose4Code { get; set; }
        [StringLength(255)]
        public string Dose5Code { get; set; }
        [StringLength(255)]
        public string Dose6Code { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
