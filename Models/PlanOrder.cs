using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("PlanOrder")]
    public partial class PlanOrder
    {
        [Key]
        [StringLength(50)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [Column("SeqID")]
        public int SeqId { get; set; }
        [Column("IPDChartNoteID")]
        public int? IpdchartNoteId { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("OrderQTY")]
        public double? OrderQty { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        public double? TotalAmount { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [StringLength(50)]
        public string OrderByCode { get; set; }
        [Column(TypeName = "text")]
        public string SpecialNote { get; set; }
        [Column(TypeName = "text")]
        public string DoseNote { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        public byte? IsOff { get; set; }
        public byte? F1 { get; set; }
        public byte? F2 { get; set; }
        public byte? F3 { get; set; }
        public byte? F4 { get; set; }
        public byte? F5 { get; set; }
        public byte? F6 { get; set; }
        public byte? F7 { get; set; }
        public byte? F8 { get; set; }
        public byte? F9 { get; set; }
        public byte? F10 { get; set; }
        public byte? F11 { get; set; }
        public byte? F12 { get; set; }
        public byte? F13 { get; set; }
        public byte? F14 { get; set; }
        public byte? F15 { get; set; }
        public byte? F16 { get; set; }
        public byte? F17 { get; set; }
        public byte? F18 { get; set; }
        public byte? F19 { get; set; }
        public byte? F20 { get; set; }
        public byte? F21 { get; set; }
        public byte? F22 { get; set; }
        public byte? F23 { get; set; }
        public byte? F24 { get; set; }
        [Column("ProgressID")]
        public int? ProgressId { get; set; }
        [Column("PlanTypeID")]
        public byte? PlanTypeId { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? NetAmount { get; set; }
        [Column("WHCode")]
        [StringLength(20)]
        public string Whcode { get; set; }
        [StringLength(20)]
        public string RightCode { get; set; }
        public byte? IsCalVat { get; set; }
        [StringLength(255)]
        public string Dose1Code { get; set; }
        [StringLength(255)]
        public string Dose2Code { get; set; }
        [StringLength(255)]
        public string Dose3Code { get; set; }
        [StringLength(255)]
        public string Dose4Code { get; set; }
        [StringLength(255)]
        public string Dose5Code { get; set; }
        [StringLength(255)]
        public string Dose1 { get; set; }
        [StringLength(255)]
        public string Dose2 { get; set; }
        [StringLength(255)]
        public string Dose3 { get; set; }
        [StringLength(255)]
        public string Dose4 { get; set; }
        [StringLength(255)]
        public string Dose5 { get; set; }
        [StringLength(255)]
        public string Dose6 { get; set; }
        [StringLength(255)]
        public string DoseText { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitCost { get; set; }
        [StringLength(20)]
        public string SalesByCode { get; set; }
        [StringLength(20)]
        public string ApproveByCode { get; set; }
        [StringLength(20)]
        public string ConsultByCode { get; set; }
        [Column("DFByCode")]
        [StringLength(20)]
        public string DfbyCode { get; set; }
        [StringLength(20)]
        public string DoByCode { get; set; }
        [StringLength(50)]
        public string MemberCardNumber { get; set; }
        [Column("MemberCardRenewSeqID")]
        public int? MemberCardRenewSeqId { get; set; }
        [StringLength(50)]
        public string PromotionCode { get; set; }
        [Column("PromotionID")]
        public int? PromotionId { get; set; }
        [Column("MemberCardSeqID")]
        public int? MemberCardSeqId { get; set; }
        public short? TotalCourseCredit { get; set; }
    }
}
