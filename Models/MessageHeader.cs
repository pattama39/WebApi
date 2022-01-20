using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MessageHeader")]
    public partial class MessageHeader
    {
        [Key]
        [Column("MessageID")]
        [StringLength(50)]
        public string MessageId { get; set; }
        [StringLength(50)]
        public string SendFrom { get; set; }
        [Column("MessageTypeID")]
        public byte? MessageTypeId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Message { get; set; }
        [Column("MessageStatusID")]
        public byte? MessageStatusId { get; set; }
        public int? TotalReceiver { get; set; }
        public int? TotalComplete { get; set; }
        public int? TotalFailed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("IsScheduleSMS")]
        public byte? IsScheduleSms { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SendDate { get; set; }
        [Column("PurposeTypeID")]
        public byte? PurposeTypeId { get; set; }
    }
}
