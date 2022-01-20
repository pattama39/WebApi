using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCustomerCustomField")]
    public partial class McustomerCustomField
    {
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber4 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber5 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber6 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber7 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber8 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber9 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber10 { get; set; }
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
        [StringLength(255)]
        public string CustomText1 { get; set; }
        [StringLength(255)]
        public string CustomText2 { get; set; }
        [StringLength(255)]
        public string CustomText3 { get; set; }
        [StringLength(255)]
        public string CustomText4 { get; set; }
        [StringLength(255)]
        public string CustomText5 { get; set; }
        [StringLength(255)]
        public string CustomText6 { get; set; }
        [StringLength(255)]
        public string CustomText7 { get; set; }
        [StringLength(255)]
        public string CustomText8 { get; set; }
        [StringLength(255)]
        public string CustomText9 { get; set; }
        [StringLength(255)]
        public string CustomText10 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate6 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate7 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate8 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate9 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate10 { get; set; }
        [StringLength(20)]
        public string DegreeCode { get; set; }
        [StringLength(20)]
        public string IncomeLevelCode { get; set; }
        [StringLength(20)]
        public string CompetitorCode { get; set; }
    }
}
