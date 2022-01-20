using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MQue")]
    public partial class Mque
    {
        [Key]
        [StringLength(20)]
        public string QueCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(50)]
        public string QueName { get; set; }
        [StringLength(50)]
        public string QueName2 { get; set; }
        [StringLength(20)]
        public string QueGroupCode { get; set; }
        [Column("TemplateID")]
        public short? TemplateId { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(20)]
        public string ClinicCode { get; set; }
        public int? ShowColor { get; set; }
        [StringLength(20)]
        public string DoctorCode { get; set; }
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
        public byte? IsShowChieftComplaint { get; set; }
        public byte? IsShowDoctorNote { get; set; }
        public byte? IsShowItem { get; set; }
        public byte? IsShowItemAndReceive { get; set; }
        public byte? IsShowReceiveMoney { get; set; }
        public byte? IsShowDiag { get; set; }
        public byte? IsShowOperation { get; set; }
        public byte? IsShowDrugHistory { get; set; }
        public byte? IsShowLab { get; set; }
        [Column("IsShowXRay")]
        public byte? IsShowXray { get; set; }
        public byte? IsShowOngoingOrder { get; set; }
        public byte? IsShowTabAppointment { get; set; }
        public byte? IsShowMarkPicture { get; set; }
        public byte? IsShowAnimalSickStatistics { get; set; }
        public byte? IsShowDocument { get; set; }
        [StringLength(20)]
        public string OrderDrugIncomeTypeCode { get; set; }
        [StringLength(20)]
        public string OrderCourseIncomeTypeCode { get; set; }
        public byte? IsShowAppoinment { get; set; }
        [StringLength(50)]
        public string RegistrationNo { get; set; }
        [StringLength(50)]
        public string PrinterName { get; set; }
        [Column("IsVFD")]
        public byte? IsVfd { get; set; }
        [Column("VFDPort")]
        [StringLength(50)]
        public string Vfdport { get; set; }
        public byte? IsElectronicJournal { get; set; }
        public byte? IsCashDrawer { get; set; }
        [StringLength(50)]
        public string CashDrawerPort { get; set; }
        [StringLength(50)]
        public string LastBillNo { get; set; }
        [StringLength(50)]
        public string LastReturnBillNo { get; set; }
        public byte? IsUseBarcode { get; set; }
        public byte? IsUseSerial { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? SeatQuantity { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? LayOutTop { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? LayOutLeft { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsHideDrugItem { get; set; }
        public byte? IsHideLabItem { get; set; }
        [Column("IsHideXRayItem")]
        public byte? IsHideXrayItem { get; set; }
        public byte? IsHideVaccineItem { get; set; }
        public byte? IsHideServiceItem { get; set; }
        public byte? IsHideCourseItem { get; set; }
        public byte? IsHideProductItem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLogInTime { get; set; }
        [StringLength(50)]
        public string LastLogInBy { get; set; }
        [Column("CashDrawerTypeID")]
        public byte? CashDrawerTypeId { get; set; }
        public byte? IsShowProgressNote { get; set; }
        public byte? IsShowCheckUp { get; set; }
        public byte? IsShowReceiveMoneyButton { get; set; }
        public byte? IsShowCompareImage { get; set; }
        public byte? IsShowOrderCourse { get; set; }
        public byte? IsShowAllSaleByCode { get; set; }
        public byte? IsShowAllDoByCode { get; set; }
        public byte? IsShowAllConsultByCode { get; set; }
        [Column("IsShowAllDFByCode")]
        public byte? IsShowAllDfbyCode { get; set; }
        [StringLength(20)]
        public string OrderLabIncomeTypeCode { get; set; }
        [StringLength(20)]
        public string OrderXrayIncomeTypeCode { get; set; }
        [StringLength(20)]
        public string OrderServiceIncomeTypeCode { get; set; }
        [StringLength(20)]
        public string OrderProductIncomeTypeCode { get; set; }
        public byte? IsShowSurgeryOrder { get; set; }
        public byte? IsShowReferIn { get; set; }
        [Column("IsShowICD10")]
        public byte? IsShowIcd10 { get; set; }
        public byte? IsShowReferOut { get; set; }
        [StringLength(255)]
        public string SoundFilePath { get; set; }
        public byte? IsShowReceipt { get; set; }
        public byte? IsShowCustomerInfo { get; set; }
        public byte? IsShowTreatment { get; set; }
        public byte? IsAlertOpinion { get; set; }
        [StringLength(20)]
        public string OrderDoctorFeeIncomeTypeCode { get; set; }
        public byte? IsShowSpermOvumBank { get; set; }
        [Column("OrderIVTherapyIncomeTypeCode")]
        [StringLength(20)]
        public string OrderIvtherapyIncomeTypeCode { get; set; }
        [Column("IsHideIVTherapyItem")]
        public byte? IsHideIvtherapyItem { get; set; }
        [Column("IsShowIVTherapy")]
        public byte? IsShowIvtherapy { get; set; }
        [StringLength(10)]
        public string OrganizationCode { get; set; }
    }
}
