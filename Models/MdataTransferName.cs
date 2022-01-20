using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MDataTransferName")]
    public partial class MdataTransferName
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string TransferNameCode { get; set; }
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
        public string TransferTypeCode { get; set; }
        [StringLength(255)]
        public string TransferName { get; set; }
        [StringLength(500)]
        public string OrderPart { get; set; }
        [StringLength(255)]
        public string CharCrop4String { get; set; }
        [StringLength(255)]
        public string CharCrop4DateTime { get; set; }
        [StringLength(255)]
        public string CharCrop4Number { get; set; }
        [StringLength(255)]
        public string CharFieldsSeparate { get; set; }
        [StringLength(255)]
        public string CharRecordSeparate { get; set; }
        public short? IsIncludeLeadingFileNameWithDateTime { get; set; }
        [StringLength(255)]
        public string ExportFileName { get; set; }
        [StringLength(255)]
        public string ExportFolderName { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
