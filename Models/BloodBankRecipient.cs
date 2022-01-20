using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BloodBankRecipient")]
    public partial class BloodBankRecipient
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BloodBankDonorID")]
        public int? BloodBankDonorId { get; set; }
        [Column("RecipientGID")]
        [StringLength(36)]
        public string RecipientGid { get; set; }
        [Column("DonorGID")]
        [StringLength(36)]
        public string DonorGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RecipientDate { get; set; }
        public double? Volumn { get; set; }
        [StringLength(50)]
        public string HosiptialName { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        [StringLength(50)]
        public string OnwerName { get; set; }
        [StringLength(50)]
        public string DoctorName { get; set; }
        [StringLength(20)]
        public string DoctocCode { get; set; }
        [Column(TypeName = "text")]
        public string Remarks { get; set; }
        [Column("RecipientTypeID")]
        public byte? RecipientTypeId { get; set; }
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
        [StringLength(20)]
        public string RecordByCode { get; set; }
    }
}
