using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("WorkstationDrive")]
    public partial class WorkstationDrive
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string WorkstationCode { get; set; }
        [Key]
        [StringLength(20)]
        public string DriveCode { get; set; }
        [StringLength(50)]
        public string DriveType { get; set; }
        [StringLength(50)]
        public string DrivePath { get; set; }
        [StringLength(50)]
        public string VolumeName { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(50)]
        public string TotalSpace { get; set; }
        [StringLength(50)]
        public string FreeSpace { get; set; }
        [StringLength(50)]
        public string FileSystem { get; set; }
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
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
