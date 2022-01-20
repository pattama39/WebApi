using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BloodBankCross")]
    public partial class BloodBankCross
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BloodBankDonorID")]
        public int? BloodBankDonorId { get; set; }
        [Column("PCVDonor")]
        public double? Pcvdonor { get; set; }
        [Column("PCVRecipient")]
        public double? Pcvrecipient { get; set; }
        [Column("DonorGID")]
        [StringLength(36)]
        public string DonorGid { get; set; }
        [Column("RecipientGID")]
        [StringLength(36)]
        public string RecipientGid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CrossMatchDate { get; set; }
        public byte? IsMajorMatch { get; set; }
        public byte? IsMinorMatch { get; set; }
        public byte? NotPassMajorResult { get; set; }
        public byte? NotPassMinorResult { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
        [StringLength(20)]
        public string ReportCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
    }
}
