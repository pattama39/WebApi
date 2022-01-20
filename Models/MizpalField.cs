using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MIzpalField")]
    public partial class MizpalField
    {
        [Key]
        [StringLength(50)]
        public string TableName { get; set; }
        [Key]
        [StringLength(50)]
        public string FieldName { get; set; }
        [Column("IsPK")]
        public byte? IsPk { get; set; }
        [Column("FieldGroupID")]
        public byte? FieldGroupId { get; set; }
        [Column("FieldTypeID")]
        public byte? FieldTypeId { get; set; }
        [Column("WinControlTypeID")]
        public byte? WinControlTypeId { get; set; }
        [Column("WebControlTypeID")]
        public byte? WebControlTypeId { get; set; }
        public byte? IsValidateData { get; set; }
        [StringLength(255)]
        public string FieldDescription { get; set; }
        public int? FieldSize { get; set; }
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
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsClearData { get; set; }
        public byte? IsSpreadColumn { get; set; }
        public byte? IsEnableControl { get; set; }
        public byte? IsSaveData { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
