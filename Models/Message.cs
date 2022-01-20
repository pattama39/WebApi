using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Message")]
    public partial class Message
    {
        [Key]
        [Column("MessageID")]
        [StringLength(50)]
        public string MessageId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("MessageTypeID")]
        public byte? MessageTypeId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [Column("Message", TypeName = "text")]
        public string Message1 { get; set; }
        [StringLength(255)]
        public string SendFrom { get; set; }
        [StringLength(255)]
        public string SendTo { get; set; }
        [Column("PriorityID")]
        public byte? PriorityId { get; set; }
        public byte? IsProcess { get; set; }
        public byte? IsComplete { get; set; }
        [Column("CC")]
        [StringLength(255)]
        public string Cc { get; set; }
        [Column("BCC")]
        [StringLength(255)]
        public string Bcc { get; set; }
        [MaxLength(50)]
        public byte[] Attach { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        public byte? IsReply { get; set; }
        public byte? IsRead { get; set; }
        [Column("FolderID")]
        public int? FolderId { get; set; }
        public byte? IsSystem { get; set; }
        public byte? InActive { get; set; }
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
        [Key]
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Key]
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        public byte? IsAppDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AppDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AppToDate { get; set; }
        [Column(TypeName = "text")]
        public string AppRemark { get; set; }
        public byte? IsBirthDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(255)]
        public string SendStatus { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string AnimalName { get; set; }
        public byte? IsVaccine { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VaccineDate { get; set; }
        [StringLength(50)]
        public string VaccineName { get; set; }
        [Column("StatusID")]
        public byte? StatusId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("AppID")]
        public int? AppId { get; set; }
        [Column("DataTypeID")]
        public byte? DataTypeId { get; set; }
        [Column("AccessLineTypeID")]
        public byte? AccessLineTypeId { get; set; }
    }
}
