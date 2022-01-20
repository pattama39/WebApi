using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffExperience")]
    public partial class StaffExperience
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Key]
        [StringLength(50)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        public int? Salary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(50)]
        public string SectionName { get; set; }
        [StringLength(50)]
        public string PositionName { get; set; }
        public int? CurrentSalary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayDate { get; set; }
        [StringLength(50)]
        public string PayMethod { get; set; }
        [StringLength(50)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BankBranch { get; set; }
        [StringLength(20)]
        public string AccountCode { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
