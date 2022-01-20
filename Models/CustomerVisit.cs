using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("CustomerVisit")]
    public partial class CustomerVisit
    {
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? NetAmount { get; set; }
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
        [Column("AN")]
        [StringLength(20)]
        public string An { get; set; }
        public byte? IsForAdmit { get; set; }
        public byte? IsAdmit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdmitDate { get; set; }
        [StringLength(50)]
        public string AdmitStatusCode { get; set; }
        [StringLength(50)]
        public string AdmitTypeCode { get; set; }
        [StringLength(50)]
        public string WardCode { get; set; }
        [StringLength(20)]
        public string BedCode { get; set; }
        public byte? IsDischarge { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DischargeDate { get; set; }
        [StringLength(20)]
        public string DischargeStatusCode { get; set; }
        [StringLength(20)]
        public string DischargeTypeCode { get; set; }
        [StringLength(20)]
        public string FoodTypeCode { get; set; }
        [StringLength(20)]
        public string DoctorByCode { get; set; }
        [StringLength(20)]
        public string SpecialInsCode { get; set; }
        [StringLength(20)]
        public string ReferHospCode { get; set; }
        public byte? ReferType { get; set; }
        public byte? IsReferJuristic { get; set; }
        [StringLength(20)]
        public string ContactCode { get; set; }
        public byte? IsContactConsent { get; set; }
        [StringLength(20)]
        public string AccidentNo { get; set; }
        [StringLength(20)]
        public string AccidentCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AccidentDate { get; set; }
        [Column(TypeName = "text")]
        public string AccidentRemark { get; set; }
        [StringLength(255)]
        public string Advise { get; set; }
        public byte? IsLockExpense { get; set; }
        public byte? LockExpenseByCode { get; set; }
        [StringLength(255)]
        public string SpecialIns { get; set; }
        [Column("QueID")]
        public short? QueId { get; set; }
        [StringLength(50)]
        public string SpecifiedDoctorCode { get; set; }
        [StringLength(255)]
        public string AdmitRemark { get; set; }
        [StringLength(50)]
        public string VisitPurposeCode { get; set; }
        [StringLength(50)]
        public string ReasonCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DoctorFeeAmount { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? DiscountAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
