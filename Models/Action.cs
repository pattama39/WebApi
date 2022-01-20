using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Action")]
    public partial class Action
    {
        [Key]
        [Column("ActionID")]
        public int ActionId { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("RequestID")]
        public int? RequestId { get; set; }
        [Column("OpportunityID")]
        public int? OpportunityId { get; set; }
        [StringLength(20)]
        public string ContactCode { get; set; }
        [StringLength(20)]
        public string ActionTypeCode { get; set; }
        [StringLength(20)]
        public string ActionByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionToTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? BillableTime { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(255)]
        public string Regarding { get; set; }
        [Column("PriorityID")]
        public byte? PriorityId { get; set; }
        [Column("ScopeID")]
        public byte? ScopeId { get; set; }
        [StringLength(20)]
        public string LockByCode { get; set; }
        [StringLength(50)]
        public string CustomText1 { get; set; }
        [StringLength(50)]
        public string CustomText2 { get; set; }
        [StringLength(50)]
        public string CustomText3 { get; set; }
        [StringLength(50)]
        public string CustomText4 { get; set; }
        [StringLength(50)]
        public string CustomText5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomDate3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? CustomNumber3 { get; set; }
        [Column(TypeName = "ntext")]
        public string Details { get; set; }
        [Column("ActionTypeID")]
        public byte? ActionTypeId { get; set; }
        [Column("RequestTypeID")]
        public byte? RequestTypeId { get; set; }
        [StringLength(50)]
        public string ActionList { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishDate { get; set; }
        [StringLength(255)]
        public string ActionByName { get; set; }
        [StringLength(20)]
        public string StatusCode { get; set; }
        public double? Budget { get; set; }
        public short? Manpower { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string Others { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        public int? InterruptAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
