using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("OngoingOrder")]
    public partial class OngoingOrder
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("OrderQTY")]
        public double? OrderQty { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        public byte? IsOff { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(50)]
        public string OrderByCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsAuto { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AutoDate { get; set; }
        public short? DaysAuto { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AutoFromTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AutoToTime { get; set; }
    }
}
