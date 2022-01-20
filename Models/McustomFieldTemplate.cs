using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCustomFieldTemplate")]
    public partial class McustomFieldTemplate
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("TemplateTypeID")]
        public int TemplateTypeId { get; set; }
        [StringLength(50)]
        public string CustomText1 { get; set; }
        [StringLength(50)]
        public string CustomText2 { get; set; }
        [StringLength(50)]
        public string CustomText3 { get; set; }
        [StringLength(50)]
        public string CustomText4 { get; set; }
        [StringLength(50)]
        public string CustomText5 { get; set; }
        [StringLength(50)]
        public string CustomText6 { get; set; }
        [StringLength(50)]
        public string CustomText7 { get; set; }
        [StringLength(50)]
        public string CustomText8 { get; set; }
        [StringLength(50)]
        public string CustomText9 { get; set; }
        [StringLength(50)]
        public string CustomText10 { get; set; }
        [StringLength(50)]
        public string CustomNumber1 { get; set; }
        [StringLength(50)]
        public string CustomNumber2 { get; set; }
        [StringLength(50)]
        public string CustomNumber3 { get; set; }
        [StringLength(50)]
        public string CustomNumber4 { get; set; }
        [StringLength(50)]
        public string CustomNumber5 { get; set; }
        [StringLength(50)]
        public string CustomNumber6 { get; set; }
        [StringLength(50)]
        public string CustomNumber7 { get; set; }
        [StringLength(50)]
        public string CustomNumber8 { get; set; }
        [StringLength(50)]
        public string CustomNumber9 { get; set; }
        [StringLength(50)]
        public string CustomNumber10 { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public int? CustomOrder1 { get; set; }
        public int? CustomOrder2 { get; set; }
        public int? CustomOrder3 { get; set; }
        public int? CustomOrder4 { get; set; }
        public int? CustomOrder5 { get; set; }
        public int? CustomOrder6 { get; set; }
        public int? CustomOrder7 { get; set; }
        public int? CustomOrder8 { get; set; }
        public int? CustomOrder9 { get; set; }
        public int? CustomOrder10 { get; set; }
    }
}
