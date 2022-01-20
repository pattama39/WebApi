using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MLabOptions")]
    public partial class MlabOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string InstrumentCode { get; set; }
        [StringLength(50)]
        public string InstrumentName { get; set; }
        [StringLength(50)]
        public string InstrumentName2 { get; set; }
        [Key]
        [Column("InstrumentTypeID")]
        public byte InstrumentTypeId { get; set; }
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
        [Column("IDEXXPDFFileNameFormat")]
        [StringLength(255)]
        public string IdexxpdffileNameFormat { get; set; }
        [Column("IDEXXMLFileNameFormat")]
        [StringLength(255)]
        public string IdexxmlfileNameFormat { get; set; }
        [Column("IDEXXRequestFolderPath")]
        [StringLength(255)]
        public string IdexxrequestFolderPath { get; set; }
        [Column("IDEXXResultPDFFolderPath")]
        [StringLength(255)]
        public string IdexxresultPdffolderPath { get; set; }
        [Column("IDEXXResultXMLFolderPath")]
        [StringLength(255)]
        public string IdexxresultXmlfolderPath { get; set; }
        [Column("CBCComportName")]
        [StringLength(255)]
        public string CbccomportName { get; set; }
        [Column("CBCComportBaudRate")]
        public int? CbccomportBaudRate { get; set; }
        [Column("CBCIPAddress")]
        [StringLength(50)]
        public string Cbcipaddress { get; set; }
        [Column("CBCIPPort")]
        [StringLength(50)]
        public string Cbcipport { get; set; }
        [Column("CBCBackupFolderPath")]
        [StringLength(255)]
        public string CbcbackupFolderPath { get; set; }
        [StringLength(255)]
        public string FuseUrl { get; set; }
        [StringLength(50)]
        public string FuseUserName { get; set; }
        [StringLength(255)]
        public string FusePassword { get; set; }
        [Column("FuseClientID")]
        [StringLength(50)]
        public string FuseClientId { get; set; }
        [StringLength(255)]
        public string FuseClientPassword { get; set; }
        [StringLength(36)]
        public string LabDocGroup { get; set; }
        [Column("HL7RequestFolderPath")]
        [StringLength(255)]
        public string Hl7requestFolderPath { get; set; }
        [Column("HL7ResultFolderPath")]
        [StringLength(255)]
        public string Hl7resultFolderPath { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
    }
}
