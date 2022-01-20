using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Request")]
    public partial class Request
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("RequestID")]
        public int RequestId { get; set; }
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
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Detail { get; set; }
        [StringLength(20)]
        public string RequestTypeCode { get; set; }
        [Column("SeverityID")]
        public byte? SeverityId { get; set; }
        [Column("PriorityID")]
        public byte? PriorityId { get; set; }
        [StringLength(20)]
        public string SeverityCode { get; set; }
        [StringLength(20)]
        public string PriorityCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }
        [StringLength(20)]
        public string RequestByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column("DueTypeID")]
        public int? DueTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueTime { get; set; }
        [StringLength(20)]
        public string AssignToCode { get; set; }
        [Column("ScopeID")]
        public byte? ScopeId { get; set; }
        [StringLength(20)]
        public string CompanyCode { get; set; }
        [StringLength(20)]
        public string ContactCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [StringLength(20)]
        public string LockByCode { get; set; }
        [StringLength(20)]
        public string StatusCode { get; set; }
        [StringLength(20)]
        public string CategoryCode { get; set; }
        [StringLength(20)]
        public string ProcessCode { get; set; }
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
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [MaxLength(50)]
        public byte[] AttachFile { get; set; }
        [Column("ProposedByID")]
        public short? ProposedById { get; set; }
        [StringLength(50)]
        public string RequestByName { get; set; }
        [StringLength(50)]
        public string CostCenterCode { get; set; }
        [StringLength(255)]
        public string QuantitativeImpact { get; set; }
        [StringLength(255)]
        public string Financial { get; set; }
        [Column("RequestTypeID")]
        public short? RequestTypeId { get; set; }
        [StringLength(255)]
        public string Comment1 { get; set; }
        [StringLength(50)]
        public string CommentBy1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CommentDate1 { get; set; }
        [StringLength(255)]
        public string Comment2 { get; set; }
        [StringLength(50)]
        public string CommentBy2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CommentDate2 { get; set; }
        [StringLength(255)]
        public string Comment3 { get; set; }
        [StringLength(50)]
        public string CommentBy3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CommentDate3 { get; set; }
        [StringLength(50)]
        public string OpinionFrom { get; set; }
        [Column("IRR")]
        [StringLength(50)]
        public string Irr { get; set; }
        [StringLength(50)]
        public string PaybackPeriod { get; set; }
        public double? NetPresentValue { get; set; }
        [StringLength(20)]
        public string DecisionByCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DecisionDate { get; set; }
        [StringLength(20)]
        public string AssignByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpdateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExecutionFromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExecutionToDate { get; set; }
        [StringLength(50)]
        public string Expectation { get; set; }
        [StringLength(50)]
        public string ActualResult { get; set; }
        [StringLength(50)]
        public string GainLoss { get; set; }
        public double? GainLossQuantity { get; set; }
        [StringLength(20)]
        public string CloseByCode { get; set; }
        [StringLength(50)]
        public string DecisionDetail { get; set; }
        public double? Quantity { get; set; }
        [StringLength(20)]
        public string RelizationByCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
