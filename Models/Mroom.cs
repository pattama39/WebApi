using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MRoom")]
    public partial class Mroom
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string RoomCode { get; set; }
        [StringLength(50)]
        public string RoomName { get; set; }
        [StringLength(50)]
        public string RoomName2 { get; set; }
        [StringLength(10)]
        public string CreateByCode { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
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
        public DateTime? ReserveDate { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReserveTime { get; set; }
        [StringLength(20)]
        public string ReserveByCode { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public int? PetsPerCustomer { get; set; }
        [Column("DiscountTypeID")]
        public byte? DiscountTypeId { get; set; }
        [Column("DayCareTypeID")]
        public byte? DayCareTypeId { get; set; }
        public int? ShowColor { get; set; }
        public byte? InActive { get; set; }
    }
}
