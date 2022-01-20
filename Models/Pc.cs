using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PC")]
    public partial class Pc
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("PCCode")]
        [StringLength(20)]
        public string Pccode { get; set; }
        [Key]
        [StringLength(20)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Column("PCValue")]
        public double? Pcvalue { get; set; }
        [Column("PCBeginValue")]
        public double? PcbeginValue { get; set; }
        [Column("PCCurrentValue")]
        public double? PccurrentValue { get; set; }
        [Column("PCAccountCode")]
        [StringLength(20)]
        public string PcaccountCode { get; set; }
        [Column("PCBankAccountCode")]
        [StringLength(20)]
        public string PcbankAccountCode { get; set; }
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
        public string ParentOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
