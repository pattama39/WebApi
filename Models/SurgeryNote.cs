using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("SurgeryNote")]
    public partial class SurgeryNote
    {
        [Key]
        [Column("SurgeryID")]
        public int SurgeryId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("TreatmentTypeID")]
        public byte TreatmentTypeId { get; set; }
        [Required]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoteTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoteDate { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column(TypeName = "text")]
        public string DoctorDiag { get; set; }
        [Column(TypeName = "text")]
        public string SpecialIns { get; set; }
        [Column(TypeName = "text")]
        public string Note { get; set; }
        [StringLength(255)]
        public string SurgeryName { get; set; }
        [StringLength(20)]
        public string SurgeryByCode { get; set; }
        [Column(TypeName = "text")]
        public string DoctorOrder { get; set; }
    }
}
