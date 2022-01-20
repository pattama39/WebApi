using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDataTransferFormat")]
    public partial class MdataTransferFormat
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("TransferFormatID")]
        public long TransferFormatId { get; set; }
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
        [StringLength(50)]
        public string TransferNameCode { get; set; }
        public int? FieldsOrder { get; set; }
        [StringLength(50)]
        public string FieldsSection { get; set; }
        [StringLength(500)]
        public string FieldsName { get; set; }
        [StringLength(500)]
        public string FieldsAlias { get; set; }
        [StringLength(50)]
        public string FieldsType { get; set; }
        [StringLength(50)]
        public string FieldsDataType { get; set; }
        [StringLength(50)]
        public string CharPadding { get; set; }
        [StringLength(500)]
        public string PreFix { get; set; }
        [StringLength(500)]
        public string PostFix { get; set; }
        public short? IsFixLen { get; set; }
        public int? LenValue { get; set; }
        public int? DecimalPlace { get; set; }
        [StringLength(50)]
        public string ThousandSeprator { get; set; }
        [StringLength(50)]
        public string DateFormat { get; set; }
        public short? IsNewLineAfter { get; set; }
        [StringLength(500)]
        public string WhereCriteria { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
