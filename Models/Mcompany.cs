using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MCompany")]
    public partial class Mcompany
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(20)]
        public string IndustryCode { get; set; }
        [StringLength(20)]
        public string CompanyTypeCode { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(6)]
        public string TumbonCode { get; set; }
        [StringLength(4)]
        public string AmphurCode { get; set; }
        [StringLength(2)]
        public string ProvinceCode { get; set; }
        [StringLength(5)]
        public string PostCode { get; set; }
        [StringLength(20)]
        public string CountryCode { get; set; }
        [StringLength(50)]
        public string MailAddress { get; set; }
        [StringLength(50)]
        public string MailTumbonCode { get; set; }
        [StringLength(50)]
        public string MailAmphurCode { get; set; }
        [StringLength(50)]
        public string MailProvinceCode { get; set; }
        [StringLength(5)]
        public string MailPostCode { get; set; }
        [StringLength(50)]
        public string MailCountryCode { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [Column("ScopeID")]
        public int? ScopeId { get; set; }
        public byte? IsSystem { get; set; }
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
        [StringLength(255)]
        public string Remark { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber3 { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
