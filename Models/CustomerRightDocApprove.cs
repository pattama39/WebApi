using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerRightDocApprove")]
    public partial class CustomerRightDocApprove
    {
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(20)]
        public string DocCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [Key]
        [StringLength(20)]
        public string RightCode { get; set; }
        [Column("ApprovedStatusID")]
        public byte? ApprovedStatusId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
