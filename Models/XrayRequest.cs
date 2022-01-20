using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("XrayRequest")]
    public partial class XrayRequest
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string XrayRequestNo { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }
        [StringLength(20)]
        public string XrayTemplateCode { get; set; }
        public byte? IsRegist { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistDate { get; set; }
        [StringLength(255)]
        public string Diagnosis { get; set; }
        public byte? IsStat { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReportDate { get; set; }
        [StringLength(20)]
        public string ReportByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovedDate { get; set; }
        [StringLength(20)]
        public string ApprovedByCode { get; set; }
        [StringLength(20)]
        public string ReceiveByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceiveDate { get; set; }
        public byte? IsRead { get; set; }
        [StringLength(10)]
        public string ReadByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(20)]
        public string FromQueCode { get; set; }
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
        [StringLength(20)]
        public string AttendingByCode { get; set; }
        public double? Age { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public byte? IsExternalXray { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? IsRequest { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsComplete { get; set; }
        [Column("DocID")]
        public int? DocId { get; set; }
        public byte? IsEnQue { get; set; }
        [StringLength(50)]
        public string EnQueByCode { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
        [StringLength(20)]
        public string PositionCode { get; set; }
        [StringLength(255)]
        public string PositionName { get; set; }
        [Column("XRayImplementCode")]
        [StringLength(20)]
        public string XrayImplementCode { get; set; }
        [StringLength(10)]
        public string OrgDestinationCode { get; set; }
    }
}
