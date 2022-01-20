using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DocItem")]
    [Index(nameof(OwnerGid), Name = "IX_DocItem")]
    [Index(nameof(Vn), Name = "IX_DocItem_1")]
    [Index(nameof(DocGroupCode), Name = "IX_DocItem_2")]
    public partial class DocItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("DocID")]
        public int DocId { get; set; }
        [StringLength(50)]
        public string FileCode { get; set; }
        [Column("OwnerGID")]
        [StringLength(36)]
        public string OwnerGid { get; set; }
        [StringLength(5)]
        public string DocExt { get; set; }
        [StringLength(20)]
        public string DocGroupCode { get; set; }
        [Column(TypeName = "image")]
        public byte[] DocImage { get; set; }
        [StringLength(20)]
        public string CompareTypeCode { get; set; }
        public byte[] DocFile { get; set; }
        [StringLength(20)]
        public string DocTypeCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column("ICD10Code")]
        [StringLength(50)]
        public string Icd10code { get; set; }
        [Column("ICD10Name")]
        [StringLength(50)]
        public string Icd10name { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [StringLength(50)]
        public string Moisture { get; set; }
        [StringLength(50)]
        public string Elastic { get; set; }
        [StringLength(50)]
        public string Oil { get; set; }
        [StringLength(255)]
        public string SkinRemark { get; set; }
        [Column("OpportunityID")]
        public int? OpportunityId { get; set; }
        [Column("RequestID")]
        public int? RequestId { get; set; }
        [Column("ScopeID")]
        public byte? ScopeId { get; set; }
        [StringLength(20)]
        public string LockByCode { get; set; }
        [StringLength(50)]
        public string DocName { get; set; }
        public float? DocSize { get; set; }
        [StringLength(50)]
        public string ContentType { get; set; }
        [Column(TypeName = "text")]
        public string DocInk { get; set; }
        [Column(TypeName = "text")]
        public string DocInkThumbnail { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "image")]
        public byte[] BackgroundDocImage { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("RefTypeID")]
        public short? RefTypeId { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
        [Column("DocTypeID")]
        public byte? DocTypeId { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Column("DocFormID")]
        public int? DocFormId { get; set; }
        public int? Priority { get; set; }
        public byte? InActive { get; set; }
        [StringLength(255)]
        public string PublicShareLink { get; set; }
    }
}
