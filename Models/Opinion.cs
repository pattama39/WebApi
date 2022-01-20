using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Opinion")]
    public partial class Opinion
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("OpinionID")]
        public int OpinionId { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column("RequestID")]
        public int? RequestId { get; set; }
        [Column("RequestTypeID")]
        public short? RequestTypeId { get; set; }
        [StringLength(50)]
        public string PostByName { get; set; }
        [StringLength(255)]
        public string OpinionDetail { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public short? Score { get; set; }
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
        [Column("CC", TypeName = "text")]
        public string Cc { get; set; }
        [Column(TypeName = "text")]
        public string Dx { get; set; }
        [Column("OpinionAdmitTypeID")]
        public byte? OpinionAdmitTypeId { get; set; }
        [Column("OpinionOwnerTypeID")]
        public byte? OpinionOwnerTypeId { get; set; }
        [Column(TypeName = "text")]
        public string ReasonOwner { get; set; }
    }
}
