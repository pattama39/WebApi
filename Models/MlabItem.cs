using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MLabItem")]
    public partial class MlabItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string LabGroupCode { get; set; }
        [Key]
        [StringLength(50)]
        public string LabItemCode { get; set; }
        [StringLength(50)]
        public string LabItemName { get; set; }
        [StringLength(50)]
        public string LabItemName2 { get; set; }
        [Column("LabResultTypeID")]
        public byte? LabResultTypeId { get; set; }
        public byte? IsLabResultGeneral { get; set; }
        public double? LabResultGeneralMin { get; set; }
        public double? LabResultGeneralMax { get; set; }
        [Column("LabResultGeneralSTD")]
        public double? LabResultGeneralStd { get; set; }
        [StringLength(50)]
        public string LabResultGeneralMinText { get; set; }
        [StringLength(50)]
        public string LabResultGeneralMaxText { get; set; }
        [Column("LabResultGeneralSTDText")]
        [StringLength(50)]
        public string LabResultGeneralStdtext { get; set; }
        public byte? IsLabResultMale { get; set; }
        public double? LabResultMaleMin { get; set; }
        public double? LabResultMaleMax { get; set; }
        [Column("LabResultMaleSTD")]
        public double? LabResultMaleStd { get; set; }
        [StringLength(50)]
        public string LabResultMaleMinText { get; set; }
        [StringLength(50)]
        public string LabResultMaleMaxText { get; set; }
        [Column("LabresultMaleSTDText")]
        [StringLength(50)]
        public string LabresultMaleStdtext { get; set; }
        public byte? IsLabResultFemale { get; set; }
        public double? LabResultFemaleMin { get; set; }
        public double? LabResultFemaleMax { get; set; }
        [Column("LabResultFemaleSTD")]
        public double? LabResultFemaleStd { get; set; }
        [StringLength(50)]
        public string LabResultFemaleMinText { get; set; }
        [StringLength(50)]
        public string LabResultFemaleMaxText { get; set; }
        [Column("LabResultFemaleSTDText")]
        [StringLength(50)]
        public string LabResultFemaleStdtext { get; set; }
        [StringLength(50)]
        public string LabUnit { get; set; }
        [StringLength(50)]
        public string LabMethod { get; set; }
        [Column("LabTypeID")]
        public byte? LabTypeId { get; set; }
        [StringLength(50)]
        public string RawLabCode1 { get; set; }
        [StringLength(50)]
        public string RawLabCode2 { get; set; }
        [StringLength(50)]
        public string RawLabCode3 { get; set; }
        [StringLength(50)]
        public string RawLabCode4 { get; set; }
        [StringLength(50)]
        public string RawLabCode5 { get; set; }
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
        public byte? IsSyncToServer { get; set; }
        public byte? InActive { get; set; }
        [Column("IDEXXCode")]
        [StringLength(50)]
        public string Idexxcode { get; set; }
        [StringLength(50)]
        public string FuseCode { get; set; }
        [StringLength(50)]
        public string MindrayCode { get; set; }
        [Column("HL7Code")]
        [StringLength(50)]
        public string Hl7code { get; set; }
    }
}
