using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MXrayItem")]
    public partial class MxrayItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("XRayGroupCode")]
        [StringLength(20)]
        public string XrayGroupCode { get; set; }
        [Key]
        [Column("XRayItemCode")]
        [StringLength(50)]
        public string XrayItemCode { get; set; }
        [Column("XRayItemName")]
        [StringLength(50)]
        public string XrayItemName { get; set; }
        [Column("XRayItemName2")]
        [StringLength(50)]
        public string XrayItemName2 { get; set; }
        [Column("XRayResultTypeID")]
        public byte? XrayResultTypeId { get; set; }
        [Column("IsXRayResultGeneral")]
        public byte? IsXrayResultGeneral { get; set; }
        [Column("XRayResultGeneralMin")]
        public double? XrayResultGeneralMin { get; set; }
        [Column("XRayResultGeneralMax")]
        public double? XrayResultGeneralMax { get; set; }
        [Column("XRayResultGeneralSTD")]
        public double? XrayResultGeneralStd { get; set; }
        [Column("XRayResultGeneralMinText")]
        [StringLength(50)]
        public string XrayResultGeneralMinText { get; set; }
        [Column("XRayResultGeneralMaxText")]
        [StringLength(50)]
        public string XrayResultGeneralMaxText { get; set; }
        [Column("XRayResultGeneralSTDText")]
        [StringLength(50)]
        public string XrayResultGeneralStdtext { get; set; }
        [Column("IsXRayResultMale")]
        public byte? IsXrayResultMale { get; set; }
        [Column("XRayResultMaleMin")]
        public double? XrayResultMaleMin { get; set; }
        [Column("XRayResultMaleMax")]
        public double? XrayResultMaleMax { get; set; }
        [Column("XRayResultMaleSTD")]
        public double? XrayResultMaleStd { get; set; }
        [Column("XRayResultMaleMinText")]
        [StringLength(50)]
        public string XrayResultMaleMinText { get; set; }
        [Column("XRayResultMaleMaxText")]
        [StringLength(50)]
        public string XrayResultMaleMaxText { get; set; }
        [Column("XRayResultMaleSTDText")]
        [StringLength(50)]
        public string XrayResultMaleStdtext { get; set; }
        [Column("IsXRayResultFemale")]
        public byte? IsXrayResultFemale { get; set; }
        [Column("XRayResultFemaleMin")]
        public double? XrayResultFemaleMin { get; set; }
        [Column("XRayResultFemaleMax")]
        public double? XrayResultFemaleMax { get; set; }
        [Column("XRayResultFemaleSTD")]
        public double? XrayResultFemaleStd { get; set; }
        [Column("XRayResultFemaleMinText")]
        [StringLength(50)]
        public string XrayResultFemaleMinText { get; set; }
        [Column("XRayResultFemaleMaxText")]
        [StringLength(50)]
        public string XrayResultFemaleMaxText { get; set; }
        [Column("XRayResultFemaleSTDText")]
        [StringLength(50)]
        public string XrayResultFemaleStdtext { get; set; }
        [Column("XRayUnit")]
        [StringLength(50)]
        public string XrayUnit { get; set; }
        [Column("XRayMethod")]
        [StringLength(50)]
        public string XrayMethod { get; set; }
        [Column("XRayTypeID")]
        public byte? XrayTypeId { get; set; }
        [Column("RawXRayCode1")]
        [StringLength(50)]
        public string RawXrayCode1 { get; set; }
        [Column("RawXRayCode2")]
        [StringLength(50)]
        public string RawXrayCode2 { get; set; }
        [Column("RawXRayCode3")]
        [StringLength(50)]
        public string RawXrayCode3 { get; set; }
        [Column("RawXRayCode4")]
        [StringLength(50)]
        public string RawXrayCode4 { get; set; }
        [Column("RawXRayCode5")]
        [StringLength(50)]
        public string RawXrayCode5 { get; set; }
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
    }
}
