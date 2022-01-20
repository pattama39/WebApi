using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffChildRequestItem")]
    public partial class StaffChildRequestItem
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string ChildRequestNo { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(20)]
        public string BillNo { get; set; }
        [StringLength(50)]
        public string ChildName { get; set; }
        [StringLength(50)]
        public string Institute { get; set; }
        [StringLength(50)]
        public string ClassLevel { get; set; }
        [StringLength(50)]
        public string Term { get; set; }
        public int? StudyYear { get; set; }
        public double? Amount { get; set; }
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
        public byte? IsSyncToServer { get; set; }
    }
}
