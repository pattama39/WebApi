using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDataTransferFieldTemplate")]
    public partial class MdataTransferFieldTemplate
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("FieldTemplateID")]
        public long FieldTemplateId { get; set; }
        public short? IsSystem { get; set; }
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
        public int? FieldOrder { get; set; }
        [StringLength(50)]
        public string FieldName { get; set; }
        [StringLength(255)]
        public string FieldDisplay { get; set; }
        [StringLength(50)]
        public string FieldType { get; set; }
        [StringLength(50)]
        public string FieldGroupType { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
