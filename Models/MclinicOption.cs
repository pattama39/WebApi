using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MClinicOptions")]
    public partial class MclinicOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(50)]
        public string DoctorName { get; set; }
        [Column("FDANo")]
        [StringLength(20)]
        public string Fdano { get; set; }
        public int? UpdateQueTime { get; set; }
        [Column("VFDComPort")]
        [StringLength(50)]
        public string VfdcomPort { get; set; }
        [StringLength(50)]
        public string ShelfComPort { get; set; }
        [StringLength(50)]
        public string BarcodeComport { get; set; }
        [StringLength(50)]
        public string WelcomeMessage { get; set; }
        [StringLength(50)]
        public string ReceiveMessage { get; set; }
        [StringLength(50)]
        public string ThanksMessage { get; set; }
        [StringLength(255)]
        public string ImagingPath { get; set; }
        [Column("ImagingSourceTypeID")]
        public byte? ImagingSourceTypeId { get; set; }
        [StringLength(255)]
        public string ImageDirectory { get; set; }
        public byte? IsCheckOpenAccount { get; set; }
        [StringLength(255)]
        public string PrinterForReceipt { get; set; }
        public int? PrintAmountForReceipt { get; set; }
        [StringLength(255)]
        public string PrinterForPatientCard { get; set; }
        [StringLength(255)]
        public string PrinterForLabel { get; set; }
        [StringLength(255)]
        public string PrinterForLabel2 { get; set; }
        [StringLength(255)]
        public string PrinterForCertificate { get; set; }
        [Column("PrinterForOPDCard")]
        [StringLength(255)]
        public string PrinterForOpdcard { get; set; }
        [StringLength(255)]
        public string PrinterForOrderDrug { get; set; }
        [StringLength(255)]
        public string PrinterForAppointment { get; set; }
        [StringLength(255)]
        public string PrinterForReport { get; set; }
        [StringLength(255)]
        public string PrinterForLabLabel { get; set; }
        [StringLength(255)]
        public string DigitalPenPath { get; set; }
        public byte? IsCalStockFromBeginning { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CurrentDate { get; set; }
        public int? CurrentBuild { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastMonthEndDate { get; set; }
        public int? StockMinDays { get; set; }
        public int? StockMaxDays { get; set; }
        public int? StockCalDays { get; set; }
        public short? IsAllowOrder2SubCoursesPerDay { get; set; }
        public byte? IsOrderItemByName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurrentBeginMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurrentBeginYear { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column("CostTypeID")]
        public byte? CostTypeId { get; set; }
        public byte? IsCalCostWithoutVat { get; set; }
        [Column("BackupTypeID")]
        public byte? BackupTypeId { get; set; }
        [Column("IsAllowEnterHN")]
        public byte? IsAllowEnterHn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OpenTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseTime { get; set; }
        public short? AppMinutesInterval { get; set; }
        public byte? IsMustPrintReceiptBeforeConfirm { get; set; }
        public byte? IsConfirmAfterPrintReceipt { get; set; }
        public byte? IsShowDoseByItem { get; set; }
        public byte? IsShowCourseWhenSearchPatient { get; set; }
        public byte? IsOpenShelfWhenReceive { get; set; }
        [StringLength(50)]
        public string ReceiptFormat { get; set; }
        public short? MaxSubCourseNo { get; set; }
        [Column("InventoryOrderItemFormID")]
        public byte? InventoryOrderItemFormId { get; set; }
        [Column("SalesOrderItemFormID")]
        public byte? SalesOrderItemFormId { get; set; }
        [Column("IsExportDataToIDCWhenReceiveMoney")]
        public byte? IsExportDataToIdcwhenReceiveMoney { get; set; }
        [Column("IsImportDataFromIDCWhenSearchPatient")]
        public byte? IsImportDataFromIdcwhenSearchPatient { get; set; }
        public byte? IsHidePatientDataForOtherOrg { get; set; }
        public byte? IsShowEndDaySummary { get; set; }
        public byte? IsAllowEnterPackingQuantity { get; set; }
        public byte? IsAllowCancelQue { get; set; }
        public byte? IsAllowManageCourse { get; set; }
        public byte? IsAllowRemed { get; set; }
        public byte? IsAllowEditSalesItem { get; set; }
        public byte? IsAllowDeleteSalesItem { get; set; }
        [Column("PayDebtTypeID")]
        public byte? PayDebtTypeId { get; set; }
        public byte? IsAllowCancelFingerprint { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsUsePasswordToDiscount { get; set; }
        public byte? IsPayIncentiveWhenCourseComplete { get; set; }
        public byte? IsCheckItemBeforeConfirm { get; set; }
        [StringLength(20)]
        public string SalesNetAmountRoundUpCode { get; set; }
        [StringLength(255)]
        public string BackupDataPath { get; set; }
        public byte? IsForceImportPatientData { get; set; }
        public byte? IsImportCourseWhenSearch { get; set; }
        public byte? IsImportSaleswhenSearch { get; set; }
        public byte? IsImportLabWhenSearch { get; set; }
        [Column("IsImportXRayWhenSearch")]
        public byte? IsImportXrayWhenSearch { get; set; }
        [Column("IsImportICDWhenSearch")]
        public byte? IsImportIcdwhenSearch { get; set; }
        [Column("IsImportARWhenSearch")]
        public byte? IsImportArwhenSearch { get; set; }
        public byte? IsAutoOrderSubCourse { get; set; }
        public byte? IsShowMarkOnNewOrderItem { get; set; }
        [StringLength(20)]
        public string ReceiptHeaderCode { get; set; }
        public double? CashBudgetAmount { get; set; }
        public byte? IsMustReceiveMoneyBeforeConfirmQue { get; set; }
        public short? MaxDayReturnItem { get; set; }
        [StringLength(255)]
        public string PrinterForMemberCard { get; set; }
        public byte? IsMultiCardHolder { get; set; }
        public byte? IsShowDebt { get; set; }
        [StringLength(10)]
        public string TypeHolderMemberCard { get; set; }
        [StringLength(20)]
        public string TypeUseMemberCard { get; set; }
        [StringLength(255)]
        public string AccessKey { get; set; }
        public byte? IsReturnItemAllType { get; set; }
        [StringLength(50)]
        public string VendorCodeForTransfer { get; set; }
        public byte? IsHidePriceWhenTransfer { get; set; }
        [Column("ReportTHPath", TypeName = "text")]
        public string ReportThpath { get; set; }
        [Column("ReportENPath", TypeName = "text")]
        public string ReportEnpath { get; set; }
        [StringLength(255)]
        public string LogPath { get; set; }
        public byte? IsReplacePurchasePrice { get; set; }
        [Column("LabInstrumentTypeID")]
        public byte? LabInstrumentTypeId { get; set; }
        [StringLength(255)]
        public string LabOptions1 { get; set; }
        [StringLength(255)]
        public string LabOptions2 { get; set; }
        [StringLength(255)]
        public string LabOptions3 { get; set; }
        [StringLength(255)]
        public string LabOptions4 { get; set; }
        [StringLength(255)]
        public string LabOptions5 { get; set; }
        [StringLength(255)]
        public string LabOptions6 { get; set; }
        [StringLength(255)]
        public string LabOptions7 { get; set; }
        [StringLength(255)]
        public string LabOptions8 { get; set; }
        [StringLength(255)]
        public string LabOptions9 { get; set; }
        [StringLength(255)]
        public string LabOptions10 { get; set; }
        [Column("OrderCourseTypeID")]
        public byte? OrderCourseTypeId { get; set; }
        [StringLength(255)]
        public string ExchangePath { get; set; }
        [Column("XrayInstrumentTypeID")]
        public byte? XrayInstrumentTypeId { get; set; }
        [StringLength(50)]
        public string XrayOptions1 { get; set; }
        [StringLength(50)]
        public string XrayOptions2 { get; set; }
        [StringLength(50)]
        public string XrayOptions3 { get; set; }
        [StringLength(50)]
        public string XrayOptions4 { get; set; }
        [StringLength(50)]
        public string XrayOptions5 { get; set; }
        [StringLength(50)]
        public string XrayOptions6 { get; set; }
        [StringLength(50)]
        public string XrayOptions7 { get; set; }
        [StringLength(50)]
        public string XrayOptions8 { get; set; }
        [StringLength(50)]
        public string XrayOptions9 { get; set; }
        [StringLength(50)]
        public string XrayOptions10 { get; set; }
        public byte? IsUseOnlineDataSystem { get; set; }
        [StringLength(255)]
        public string PrinterForLabelPath { get; set; }
        [StringLength(255)]
        public string PrinterForLabel2Path { get; set; }
        public byte? IsUsePharmaRoomSystem { get; set; }
        [StringLength(255)]
        public string HelpPath { get; set; }
        [Column("ExpireDateForLabelTypeID")]
        public byte? ExpireDateForLabelTypeId { get; set; }
        [Column("CameraSystemTypeID")]
        public byte? CameraSystemTypeId { get; set; }
        public byte? IsCanDebtAmount { get; set; }
        public double? CollectAmountPerPoint { get; set; }
        public double? CollectPoint { get; set; }
        public double? RedeemAmountPerPoint { get; set; }
        public double? RedeemPoint { get; set; }
        public int? PointExpireDay { get; set; }
        [Column("PointCalculateTypeID")]
        public byte? PointCalculateTypeId { get; set; }
        public byte? IsUsePoint { get; set; }
        public double? MinimumReserveAmount { get; set; }
        public int? ExpireDayReserveAmount { get; set; }
        public byte? IsMemberCanRedeemPoint { get; set; }
        [Column("MemberReportTHPath", TypeName = "text")]
        public string MemberReportThpath { get; set; }
        [Column("MemberReportENPath", TypeName = "text")]
        public string MemberReportEnpath { get; set; }
        public byte? IsAlertRight { get; set; }
        [StringLength(255)]
        public string PrinterForInvoice { get; set; }
        public int? PrintAmountForInvoice { get; set; }
        public byte? IsCalVatFromSalesPrice { get; set; }
        [Column("UserNameSMS")]
        [StringLength(50)]
        public string UserNameSms { get; set; }
        [Column("PasswordSMS")]
        [StringLength(255)]
        public string PasswordSms { get; set; }
        [Column("IsAutoConnectSMS")]
        public byte? IsAutoConnectSms { get; set; }
        [StringLength(255)]
        public string PrinterForSticker { get; set; }
        public int? PrintAmountForSticker { get; set; }
        [StringLength(20)]
        public string LicenseForNarcoticsType2 { get; set; }
        [StringLength(20)]
        public string LicenseForPsychotropicType2 { get; set; }
        [StringLength(20)]
        public string LicenseForPsychotropicType3 { get; set; }
        [StringLength(20)]
        public string LicenseForPsychotropicType4 { get; set; }
        [StringLength(50)]
        public string CaseComplaintComPort { get; set; }
        [Column("IsSpecifyXRayImplement")]
        public byte? IsSpecifyXrayImplement { get; set; }
        public byte? IsCalReserveVat { get; set; }
        [StringLength(255)]
        public string ImageVideoPath { get; set; }
        [StringLength(11)]
        public string SmsSenderName { get; set; }
        public byte? IsMonday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonTimeOut { get; set; }
        public byte? IsTuesday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TueTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TueTimeOut { get; set; }
        public byte? IsWednesday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WedTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WedTimeOut { get; set; }
        public byte? IsThursday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThuTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThuTimeOut { get; set; }
        public byte? IsFriday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FriTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FriTimeOut { get; set; }
        public byte? IsSaturday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SatTimeOut { get; set; }
        public byte? IsSunday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunTimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SunTimeOut { get; set; }
        public double? ChargeLateCheckOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DayCareCheckInTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DayCareCheckOutTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DayNightCheckInTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DayNightCheckOutTime { get; set; }
        public byte? CoCourseCustomer { get; set; }
        [StringLength(50)]
        public string MedchatAccSid { get; set; }
        [StringLength(50)]
        public string MedchatAccAuth { get; set; }
        [StringLength(50)]
        public string MedchatApiSid { get; set; }
        [StringLength(50)]
        public string MedchatApiSecret { get; set; }
        [Column("LineOAChatURL")]
        [StringLength(255)]
        public string LineOachatUrl { get; set; }
        [Column("ClinicCalendarURL")]
        [StringLength(255)]
        public string ClinicCalendarUrl { get; set; }
    }
}
