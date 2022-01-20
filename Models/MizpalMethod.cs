using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MIzpalMethod")]
    public partial class MizpalMethod
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ClassName { get; set; }
        [Key]
        [StringLength(50)]
        public string MethodName { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ParentClassName { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }

        [ForeignKey(nameof(ClassName))]
        [InverseProperty(nameof(MizpalClass.MizpalMethods))]
        public virtual MizpalClass ClassNameNavigation { get; set; }
    }
}
