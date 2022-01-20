using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CertificateVisit")]
    public partial class CertificateVisit
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CertificateCode { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(50)]
        public string AnimalGid { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
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
        [StringLength(20)]
        public string CertificateTypeCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(100)]
        public string Remark1 { get; set; }
        [StringLength(100)]
        public string Remark2 { get; set; }
        [StringLength(100)]
        public string Remark3 { get; set; }
        [StringLength(100)]
        public string Remark4 { get; set; }
        [StringLength(100)]
        public string Remark5 { get; set; }
        [StringLength(100)]
        public string Remark6 { get; set; }
        [Column("DocTypeID")]
        public byte? DocTypeId { get; set; }
        [Column("PrognosisTypeID")]
        public byte? PrognosisTypeId { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark1 { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark2 { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark3 { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark4 { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark5 { get; set; }
        [Column(TypeName = "text")]
        public string ReferRemark6 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReferFromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReferToDate { get; set; }
        [StringLength(20)]
        public string OfficialCertificateCode { get; set; }
        [Column(TypeName = "text")]
        public string RemarkText { get; set; }
    }
}
