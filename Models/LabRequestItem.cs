using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("LabRequestItem")]
    [Index(nameof(CustomerGid), Name = "IX_LabRequestItem")]
    [Index(nameof(ModDate), Name = "IX_LabRequestItem_1")]
    public partial class LabRequestItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string LabRequestNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(50)]
        public string LabItemCode { get; set; }
        [Column(TypeName = "text")]
        public string Result { get; set; }
        public double? Result2 { get; set; }
        public short? Col { get; set; }
        public short? Row { get; set; }
        [StringLength(20)]
        public string LabMethodCode { get; set; }
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
        [StringLength(20)]
        public string ReadByCode { get; set; }
        public byte? CellType { get; set; }
        [Column("ResultTypeID")]
        public int? ResultTypeId { get; set; }
        [StringLength(1)]
        public string Classified { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? IsSyncToServer { get; set; }
        [StringLength(20)]
        public string AttendingByCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(50)]
        public string LabUnit { get; set; }
        public byte? IsComplete { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsRequest { get; set; }
        [Column("SpouseGID")]
        [StringLength(36)]
        public string SpouseGid { get; set; }
        [Column("LabPatientTypeID")]
        public byte? LabPatientTypeId { get; set; }
        public double? LabResultMin { get; set; }
        public double? LabResultMax { get; set; }
        [Column("LabResultSTD")]
        public double? LabResultStd { get; set; }
        [Column(TypeName = "text")]
        public string LabResultPositiveText { get; set; }
        [Column(TypeName = "text")]
        public string LabResultNegativeText { get; set; }
        [Column(TypeName = "text")]
        public string LabResultText { get; set; }
    }
}
