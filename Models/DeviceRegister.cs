using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("DeviceRegister")]
    public partial class DeviceRegister
    {
        [Key]
        [StringLength(50)]
        public string DeviceIdentifier { get; set; }
        [Key]
        [Column("ProgramTypeID")]
        public byte ProgramTypeId { get; set; }
        [StringLength(50)]
        public string DeviceName { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        [StringLength(20)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
    }
}
