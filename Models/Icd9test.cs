using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Keyless]
    [Table("ICD9Test")]
    public partial class Icd9test
    {
        [Column("ICDCode")]
        [StringLength(50)]
        public string Icdcode { get; set; }
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("ICDName")]
        [StringLength(255)]
        public string Icdname { get; set; }
        [Column("ICDName2")]
        [StringLength(255)]
        public string Icdname2 { get; set; }
    }
}
