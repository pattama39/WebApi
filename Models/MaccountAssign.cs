using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MAccountAssign")]
    public partial class MaccountAssign
    {
        [Key]
        [Column("AccountAssignTypeID")]
        public int AccountAssignTypeId { get; set; }
        [StringLength(50)]
        public string AccountCode { get; set; }
        public byte? InActive { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        [Key]
        [StringLength(50)]
        public string TargetCode { get; set; }
        [StringLength(255)]
        public string TargetName { get; set; }
        [StringLength(255)]
        public string TargetName2 { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("AccountTypeID")]
        public short? AccountTypeId { get; set; }
    }
}
