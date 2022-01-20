using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerQue")]
    [Index(nameof(QueCode), Name = "IX_CustomerQue_2")]
    public partial class CustomerQue
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
        [StringLength(50)]
        public string FromQueCode { get; set; }
        [StringLength(50)]
        public string FromQueName { get; set; }
        [StringLength(20)]
        public string LockByCode { get; set; }
        public int? ShowColor { get; set; }
        public byte? IsReceiveMoney { get; set; }
        public byte? IsFingerPrintScan { get; set; }
        [Column("IsReVN")]
        public byte? IsReVn { get; set; }
        public int? WaitingTime { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [StringLength(50)]
        public string QueCode { get; set; }
        [StringLength(50)]
        public string QueName { get; set; }
        public byte? IsFinish { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterQueTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExitQueTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDate { get; set; }
        [StringLength(50)]
        public string ReserveNo { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("QueID")]
        public int? QueId { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("IsSendSMS")]
        public byte? IsSendSms { get; set; }
        public byte? IsSendFollow { get; set; }
        [Column("CaseTypeID")]
        public int? CaseTypeId { get; set; }
        public byte? IsSaveAnimalSickStatistics { get; set; }
        public byte? IsCallQue { get; set; }
        [Column("CallQueStatusID")]
        public byte? CallQueStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CallQueDate { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column("AppointTypeID")]
        public byte? AppointTypeId { get; set; }
        [Column("CVN")]
        public int? Cvn { get; set; }
        [StringLength(20)]
        public string CaseTypeCode { get; set; }
        [Column("NotifyWaitQueQTY")]
        public int? NotifyWaitQueQty { get; set; }
        [Column("CarrierGID")]
        [StringLength(36)]
        public string CarrierGid { get; set; }
        [Column("PFPID")]
        public int? Pfpid { get; set; }
    }
}
