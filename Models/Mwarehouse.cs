using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MWarehouse")]
    public partial class Mwarehouse
    {
        [Key]
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("WHOfficialCode")]
        [StringLength(20)]
        public string WhofficialCode { get; set; }
        [Column("WHName")]
        [StringLength(50)]
        public string Whname { get; set; }
        [Column("WHName2")]
        [StringLength(50)]
        public string Whname2 { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string CurrentAddress1 { get; set; }
        [StringLength(50)]
        public string CurrentAddress2 { get; set; }
        [StringLength(4)]
        public string CurrentAmphurCode { get; set; }
        [StringLength(50)]
        public string CurrentAmphurName { get; set; }
        [StringLength(6)]
        public string CurrentTumbonCode { get; set; }
        [StringLength(50)]
        public string CurrentTumbonName { get; set; }
        [StringLength(2)]
        public string CurrentProvinceCode { get; set; }
        [StringLength(50)]
        public string CurrentProvinceName { get; set; }
        [StringLength(5)]
        public string CurrentPostCode { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsCanSell { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        public int? Priority { get; set; }
        public byte? InActive { get; set; }
    }
}
