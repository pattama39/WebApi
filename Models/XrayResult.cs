using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("XrayResult")]
    [Index(nameof(CustomerGid), Name = "IX_XrayResult")]
    [Index(nameof(Vn), Name = "IX_XrayResult_1")]
    [Index(nameof(ModDate), Name = "IX_XrayResult_2")]
    public partial class XrayResult
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("XRayRequestNo")]
        [StringLength(20)]
        public string XrayRequestNo { get; set; }
        [Column("XRayRequestItemSeqID")]
        public int? XrayRequestItemSeqId { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string XrayResultName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReportDate { get; set; }
        [StringLength(20)]
        public string ReportByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }
        [StringLength(20)]
        public string RequestByCode { get; set; }
        public byte? IsRead { get; set; }
        public byte? IsStat { get; set; }
        [StringLength(20)]
        public string RefDoc { get; set; }
        [StringLength(20)]
        public string ReadByCode { get; set; }
        public byte? IsRepeated { get; set; }
        [StringLength(20)]
        public string ReXrayNo { get; set; }
        public byte? IsAbnormal { get; set; }
        [Column("StatusWorkID")]
        public int? StatusWorkId { get; set; }
        [StringLength(50)]
        public string ResultLevel2Name { get; set; }
        [StringLength(50)]
        public string XrayResultCode { get; set; }
        [Column(TypeName = "text")]
        public string Result { get; set; }
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
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("ImageDocID")]
        public int? ImageDocId { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(255)]
        public string ImageFileName { get; set; }
        [StringLength(20)]
        public string PositionCode { get; set; }
        [StringLength(255)]
        public string PositionName { get; set; }
        [StringLength(20)]
        public string PositionViewCode { get; set; }
        [StringLength(255)]
        public string PositionViewName { get; set; }
        [Column(TypeName = "text")]
        public string DefaultResult { get; set; }
        [Column(TypeName = "text")]
        public string ClinicalComment { get; set; }
        [Column(TypeName = "text")]
        public string ReasonResend { get; set; }
        [Column(TypeName = "text")]
        public string DefaultClinicalComment { get; set; }
        [Column("XRayOrder", TypeName = "text")]
        public string XrayOrder { get; set; }
        [Column("mA")]
        [StringLength(50)]
        public string MA { get; set; }
        [Column("kV")]
        [StringLength(50)]
        public string KV { get; set; }
        [StringLength(50)]
        public string Time { get; set; }
        [StringLength(50)]
        public string Thickness { get; set; }
    }
}
