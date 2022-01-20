using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    public partial class RoomTran
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("RoomTransID")]
        public int RoomTransId { get; set; }
        [Key]
        [Column("SeqID")]
        public short SeqId { get; set; }
        [StringLength(20)]
        public string RoomCode { get; set; }
        [Column("RoomTransTypeID")]
        public byte? RoomTransTypeId { get; set; }
        [StringLength(10)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndTime { get; set; }
        [StringLength(20)]
        public string ReserveByCode { get; set; }
        public byte? IsFinish { get; set; }
        [StringLength(50)]
        public string OwnerName { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("PetCareChargeTypeID")]
        public byte? PetCareChargeTypeId { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
    }
}
