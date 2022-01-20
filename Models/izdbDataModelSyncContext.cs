using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi.Models
{
    public partial class izdbDataModelSyncContext : DbContext
    {
        public izdbDataModelSyncContext()
        {
        }

        public izdbDataModelSyncContext(DbContextOptions<izdbDataModelSyncContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCode> AccountCodes { get; set; }
        public virtual DbSet<AccountPeriod> AccountPeriods { get; set; }
        public virtual DbSet<AccountPeriodTran> AccountPeriodTrans { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Adjust> Adjusts { get; set; }
        public virtual DbSet<AdjustItem> AdjustItems { get; set; }
        public virtual DbSet<AdmitDischarge> AdmitDischarges { get; set; }
        public virtual DbSet<AdvancePay> AdvancePays { get; set; }
        public virtual DbSet<AdvanceReceive> AdvanceReceives { get; set; }
        public virtual DbSet<AdvanceReimburse> AdvanceReimburses { get; set; }
        public virtual DbSet<AdvanceReimburseBy> AdvanceReimburseBies { get; set; }
        public virtual DbSet<AdvanceReimburseItem> AdvanceReimburseItems { get; set; }
        public virtual DbSet<Ae> Aes { get; set; }
        public virtual DbSet<Aeby> Aebies { get; set; }
        public virtual DbSet<Aeitem> Aeitems { get; set; }
        public virtual DbSet<Aereimburse> Aereimburses { get; set; }
        public virtual DbSet<AereimburseBy> AereimburseBies { get; set; }
        public virtual DbSet<AereimburseItem> AereimburseItems { get; set; }
        public virtual DbSet<Ai> Ais { get; set; }
        public virtual DbSet<Aiby> Aibies { get; set; }
        public virtual DbSet<Aiitem> Aiitems { get; set; }
        public virtual DbSet<AnimalCheckUp> AnimalCheckUps { get; set; }
        public virtual DbSet<AnimalCheckupProgressNote> AnimalCheckupProgressNotes { get; set; }
        public virtual DbSet<AnimalSideEffect> AnimalSideEffects { get; set; }
        public virtual DbSet<Anniversary> Anniversaries { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Apcard> Apcards { get; set; }
        public virtual DbSet<Apdown> Apdowns { get; set; }
        public virtual DbSet<Apexpense> Apexpenses { get; set; }
        public virtual DbSet<Appay> Appays { get; set; }
        public virtual DbSet<AppayBy> AppayBies { get; set; }
        public virtual DbSet<AppayCheque> AppayCheques { get; set; }
        public virtual DbSet<AppayItem> AppayItems { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Aptran> Aptrans { get; set; }
        public virtual DbSet<Arbill> Arbills { get; set; }
        public virtual DbSet<ArbillItem> ArbillItems { get; set; }
        public virtual DbSet<Arcard> Arcards { get; set; }
        public virtual DbSet<Arreceive> Arreceives { get; set; }
        public virtual DbSet<ArreceiveAble> ArreceiveAbles { get; set; }
        public virtual DbSet<ArreceiveAbleItem> ArreceiveAbleItems { get; set; }
        public virtual DbSet<ArreceiveBy> ArreceiveBies { get; set; }
        public virtual DbSet<ArreceiveItem> ArreceiveItems { get; set; }
        public virtual DbSet<Artran> Artrans { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserLoginsTime> AspNetUserLoginsTimes { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AuditRequest> AuditRequests { get; set; }
        public virtual DbSet<BankInitial> BankInitials { get; set; }
        public virtual DbSet<BankMonthlyInitial> BankMonthlyInitials { get; set; }
        public virtual DbSet<BankTran> BankTrans { get; set; }
        public virtual DbSet<BankTransaction> BankTransactions { get; set; }
        public virtual DbSet<BeginingAccountPeriod> BeginingAccountPeriods { get; set; }
        public virtual DbSet<BigDealAlert> BigDealAlerts { get; set; }
        public virtual DbSet<BigDealAlertToStaff> BigDealAlertToStaffs { get; set; }
        public virtual DbSet<BigDealAlertToStaffGroup> BigDealAlertToStaffGroups { get; set; }
        public virtual DbSet<BloodBankCross> BloodBankCrosses { get; set; }
        public virtual DbSet<BloodBankDonor> BloodBankDonors { get; set; }
        public virtual DbSet<BloodBankRecipient> BloodBankRecipients { get; set; }
        public virtual DbSet<Br> Brs { get; set; }
        public virtual DbSet<BranchOrder> BranchOrders { get; set; }
        public virtual DbSet<BranchOrderItem> BranchOrderItems { get; set; }
        public virtual DbSet<Brby> Brbies { get; set; }
        public virtual DbSet<Britem> Britems { get; set; }
        public virtual DbSet<CampaignCost> CampaignCosts { get; set; }
        public virtual DbSet<CampaignCustomer> CampaignCustomers { get; set; }
        public virtual DbSet<CampaignRevenue> CampaignRevenues { get; set; }
        public virtual DbSet<CaseComplaint> CaseComplaints { get; set; }
        public virtual DbSet<CertificateVisit> CertificateVisits { get; set; }
        public virtual DbSet<ChequeRegister> ChequeRegisters { get; set; }
        public virtual DbSet<ChequeReturn> ChequeReturns { get; set; }
        public virtual DbSet<ClearAdvance> ClearAdvances { get; set; }
        public virtual DbSet<ClearAdvanceBy> ClearAdvanceBies { get; set; }
        public virtual DbSet<ClearAdvanceItem> ClearAdvanceItems { get; set; }
        public virtual DbSet<ClientPaymentDetail> ClientPaymentDetails { get; set; }
        public virtual DbSet<ClientPaymentTransaction> ClientPaymentTransactions { get; set; }
        public virtual DbSet<CloseAccount> CloseAccounts { get; set; }
        public virtual DbSet<CompositeFx> CompositeFxes { get; set; }
        public virtual DbSet<ConfirmCredit> ConfirmCredits { get; set; }
        public virtual DbSet<ConfirmCreditItem> ConfirmCreditItems { get; set; }
        public virtual DbSet<CostFiFo> CostFiFos { get; set; }
        public virtual DbSet<CounsellorIncentive> CounsellorIncentives { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseItem> CourseItems { get; set; }
        public virtual DbSet<CustomerCaseVisit> CustomerCaseVisits { get; set; }
        public virtual DbSet<CustomerHair> CustomerHairs { get; set; }
        public virtual DbSet<CustomerMap> CustomerMaps { get; set; }
        public virtual DbSet<CustomerMemberCard> CustomerMemberCards { get; set; }
        public virtual DbSet<CustomerPregnant> CustomerPregnants { get; set; }
        public virtual DbSet<CustomerQue> CustomerQues { get; set; }
        public virtual DbSet<CustomerRight> CustomerRights { get; set; }
        public virtual DbSet<CustomerRightDocApprove> CustomerRightDocApproves { get; set; }
        public virtual DbSet<CustomerRightItem> CustomerRightItems { get; set; }
        public virtual DbSet<CustomerSideEffect> CustomerSideEffects { get; set; }
        public virtual DbSet<CustomerSkin> CustomerSkins { get; set; }
        public virtual DbSet<CustomerSkinCondition> CustomerSkinConditions { get; set; }
        public virtual DbSet<CustomerSsp> CustomerSsps { get; set; }
        public virtual DbSet<CustomerVisit> CustomerVisits { get; set; }
        public virtual DbSet<CustomerVoucherItem> CustomerVoucherItems { get; set; }
        public virtual DbSet<CustomerWait> CustomerWaits { get; set; }
        public virtual DbSet<CutStock> CutStocks { get; set; }
        public virtual DbSet<CutStockItem> CutStockItems { get; set; }
        public virtual DbSet<DataAccidentCause> DataAccidentCauses { get; set; }
        public virtual DbSet<DataAccountType> DataAccountTypes { get; set; }
        public virtual DbSet<DataActionType> DataActionTypes { get; set; }
        public virtual DbSet<DataAddressType> DataAddressTypes { get; set; }
        public virtual DbSet<DataAppFrequency> DataAppFrequencies { get; set; }
        public virtual DbSet<DataAppInterval> DataAppIntervals { get; set; }
        public virtual DbSet<DataAppPurpose> DataAppPurposes { get; set; }
        public virtual DbSet<DataAppStatus> DataAppStatuses { get; set; }
        public virtual DbSet<DataAppointmentType> DataAppointmentTypes { get; set; }
        public virtual DbSet<DataArea> DataAreas { get; set; }
        public virtual DbSet<DataBank> DataBanks { get; set; }
        public virtual DbSet<DataBloodGroup> DataBloodGroups { get; set; }
        public virtual DbSet<DataBranchOrderRemark> DataBranchOrderRemarks { get; set; }
        public virtual DbSet<DataBrand> DataBrands { get; set; }
        public virtual DbSet<DataBuilding> DataBuildings { get; set; }
        public virtual DbSet<DataBusinessType> DataBusinessTypes { get; set; }
        public virtual DbSet<DataCategory> DataCategories { get; set; }
        public virtual DbSet<DataCause> DataCauses { get; set; }
        public virtual DbSet<DataCheckUp> DataCheckUps { get; set; }
        public virtual DbSet<DataCheckUpRemark> DataCheckUpRemarks { get; set; }
        public virtual DbSet<DataChieftComplaint> DataChieftComplaints { get; set; }
        public virtual DbSet<DataCity> DataCities { get; set; }
        public virtual DbSet<DataClinic> DataClinics { get; set; }
        public virtual DbSet<DataColor> DataColors { get; set; }
        public virtual DbSet<DataCompanyTitleName> DataCompanyTitleNames { get; set; }
        public virtual DbSet<DataCompanyType> DataCompanyTypes { get; set; }
        public virtual DbSet<DataCompareType> DataCompareTypes { get; set; }
        public virtual DbSet<DataCompetitor> DataCompetitors { get; set; }
        public virtual DbSet<DataComplex> DataComplices { get; set; }
        public virtual DbSet<DataComposite> DataComposites { get; set; }
        public virtual DbSet<DataContactGroup> DataContactGroups { get; set; }
        public virtual DbSet<DataContactType> DataContactTypes { get; set; }
        public virtual DbSet<DataCostCenter> DataCostCenters { get; set; }
        public virtual DbSet<DataCountry> DataCountries { get; set; }
        public virtual DbSet<DataCouponType> DataCouponTypes { get; set; }
        public virtual DbSet<DataCreditCardPaymentType> DataCreditCardPaymentTypes { get; set; }
        public virtual DbSet<DataCreditCardSwipe> DataCreditCardSwipes { get; set; }
        public virtual DbSet<DataCreditCardType> DataCreditCardTypes { get; set; }
        public virtual DbSet<DataCustomerCase> DataCustomerCases { get; set; }
        public virtual DbSet<DataCustomerContactType> DataCustomerContactTypes { get; set; }
        public virtual DbSet<DataCustomerRightDoc> DataCustomerRightDocs { get; set; }
        public virtual DbSet<DataCustomerRightStatus> DataCustomerRightStatuses { get; set; }
        public virtual DbSet<DataCutStockReason> DataCutStockReasons { get; set; }
        public virtual DbSet<DataDeadCause> DataDeadCauses { get; set; }
        public virtual DbSet<DataDegree> DataDegrees { get; set; }
        public virtual DbSet<DataDepartment> DataDepartments { get; set; }
        public virtual DbSet<DataDischargeStatus> DataDischargeStatuses { get; set; }
        public virtual DbSet<DataDischargeType> DataDischargeTypes { get; set; }
        public virtual DbSet<DataDoctorNoteTemplate> DataDoctorNoteTemplates { get; set; }
        public virtual DbSet<DataDueBack> DataDueBacks { get; set; }
        public virtual DbSet<DataDuration> DataDurations { get; set; }
        public virtual DbSet<DataEmployeeType> DataEmployeeTypes { get; set; }
        public virtual DbSet<DataExpenseType> DataExpenseTypes { get; set; }
        public virtual DbSet<DataFavorite> DataFavorites { get; set; }
        public virtual DbSet<DataFixAssetStatus> DataFixAssetStatuses { get; set; }
        public virtual DbSet<DataFixAssetType> DataFixAssetTypes { get; set; }
        public virtual DbSet<DataFollowUpType> DataFollowUpTypes { get; set; }
        public virtual DbSet<DataFoodType> DataFoodTypes { get; set; }
        public virtual DbSet<DataForecastType> DataForecastTypes { get; set; }
        public virtual DbSet<DataGenericName> DataGenericNames { get; set; }
        public virtual DbSet<DataGenericSpecy> DataGenericSpecies { get; set; }
        public virtual DbSet<DataHair> DataHairs { get; set; }
        public virtual DbSet<DataHardware> DataHardwares { get; set; }
        public virtual DbSet<DataHospital> DataHospitals { get; set; }
        public virtual DbSet<DataIcdtype> DataIcdtypes { get; set; }
        public virtual DbSet<DataInOutStatus> DataInOutStatuses { get; set; }
        public virtual DbSet<DataIncomeLevel> DataIncomeLevels { get; set; }
        public virtual DbSet<DataIncomeType> DataIncomeTypes { get; set; }
        public virtual DbSet<DataIndustry> DataIndustries { get; set; }
        public virtual DbSet<DataInsuranceCompany> DataInsuranceCompanies { get; set; }
        public virtual DbSet<DataItemClassifiedGroup> DataItemClassifiedGroups { get; set; }
        public virtual DbSet<DataItemReturn> DataItemReturns { get; set; }
        public virtual DbSet<DataItemWarn> DataItemWarns { get; set; }
        public virtual DbSet<DataJournalGroup> DataJournalGroups { get; set; }
        public virtual DbSet<DataKbcategory> DataKbcategories { get; set; }
        public virtual DbSet<DataLabGroup> DataLabGroups { get; set; }
        public virtual DbSet<DataLabMethod> DataLabMethods { get; set; }
        public virtual DbSet<DataLabSpeciman> DataLabSpecimen { get; set; }
        public virtual DbSet<DataLanguage> DataLanguages { get; set; }
        public virtual DbSet<DataLocation> DataLocations { get; set; }
        public virtual DbSet<DataMaritalStatus> DataMaritalStatuses { get; set; }
        public virtual DbSet<DataMediaSource> DataMediaSources { get; set; }
        public virtual DbSet<DataMessageType> DataMessageTypes { get; set; }
        public virtual DbSet<DataNation> DataNations { get; set; }
        public virtual DbSet<DataOccupation> DataOccupations { get; set; }
        public virtual DbSet<DataOnset> DataOnsets { get; set; }
        public virtual DbSet<DataOperate> DataOperates { get; set; }
        public virtual DbSet<DataOperateActing> DataOperateActings { get; set; }
        public virtual DbSet<DataOperateCause> DataOperateCauses { get; set; }
        public virtual DbSet<DataOperateMethod> DataOperateMethods { get; set; }
        public virtual DbSet<DataOperateProblem> DataOperateProblems { get; set; }
        public virtual DbSet<DataOperateResult> DataOperateResults { get; set; }
        public virtual DbSet<DataPosition> DataPositions { get; set; }
        public virtual DbSet<DataPriceLevel> DataPriceLevels { get; set; }
        public virtual DbSet<DataProcess> DataProcesses { get; set; }
        public virtual DbSet<DataProcessStage> DataProcessStages { get; set; }
        public virtual DbSet<DataProcessStatus> DataProcessStatuses { get; set; }
        public virtual DbSet<DataQueStatus> DataQueStatuses { get; set; }
        public virtual DbSet<DataQuestionGroup> DataQuestionGroups { get; set; }
        public virtual DbSet<DataRace> DataRaces { get; set; }
        public virtual DbSet<DataReason> DataReasons { get; set; }
        public virtual DbSet<DataReceiptGroup> DataReceiptGroups { get; set; }
        public virtual DbSet<DataRecurringGroup> DataRecurringGroups { get; set; }
        public virtual DbSet<DataReferInType> DataReferInTypes { get; set; }
        public virtual DbSet<DataReferLocation> DataReferLocations { get; set; }
        public virtual DbSet<DataRegarding> DataRegardings { get; set; }
        public virtual DbSet<DataReligion> DataReligions { get; set; }
        public virtual DbSet<DataRemark> DataRemarks { get; set; }
        public virtual DbSet<DataRepeatedFilm> DataRepeatedFilms { get; set; }
        public virtual DbSet<DataReportGroup> DataReportGroups { get; set; }
        public virtual DbSet<DataReportSubGroup> DataReportSubGroups { get; set; }
        public virtual DbSet<DataReqPriority> DataReqPriorities { get; set; }
        public virtual DbSet<DataRequest> DataRequests { get; set; }
        public virtual DbSet<DataRequestCategory> DataRequestCategories { get; set; }
        public virtual DbSet<DataRequestPriority> DataRequestPriorities { get; set; }
        public virtual DbSet<DataRequestProcess> DataRequestProcesses { get; set; }
        public virtual DbSet<DataRequestSeverity> DataRequestSeverities { get; set; }
        public virtual DbSet<DataRequestStatus> DataRequestStatuses { get; set; }
        public virtual DbSet<DataRequestType> DataRequestTypes { get; set; }
        public virtual DbSet<DataRoad> DataRoads { get; set; }
        public virtual DbSet<DataRoomStatus> DataRoomStatuses { get; set; }
        public virtual DbSet<DataRoundupName> DataRoundupNames { get; set; }
        public virtual DbSet<DataScreen> DataScreens { get; set; }
        public virtual DbSet<DataShape> DataShapes { get; set; }
        public virtual DbSet<DataSkill> DataSkills { get; set; }
        public virtual DbSet<DataSkillLevel> DataSkillLevels { get; set; }
        public virtual DbSet<DataSkin> DataSkins { get; set; }
        public virtual DbSet<DataSkinCondition> DataSkinConditions { get; set; }
        public virtual DbSet<DataSoftware> DataSoftwares { get; set; }
        public virtual DbSet<DataSource> DataSources { get; set; }
        public virtual DbSet<DataSpecialInstruction> DataSpecialInstructions { get; set; }
        public virtual DbSet<DataSsoservice> DataSsoservices { get; set; }
        public virtual DbSet<DataStaffLevel> DataStaffLevels { get; set; }
        public virtual DbSet<DataStaffRightGroup> DataStaffRightGroups { get; set; }
        public virtual DbSet<DataStaffSection> DataStaffSections { get; set; }
        public virtual DbSet<DataStaffType> DataStaffTypes { get; set; }
        public virtual DbSet<DataStage> DataStages { get; set; }
        public virtual DbSet<DataState> DataStates { get; set; }
        public virtual DbSet<DataSubItemGroup> DataSubItemGroups { get; set; }
        public virtual DbSet<DataSurgeryGroup> DataSurgeryGroups { get; set; }
        public virtual DbSet<DataSymptomGroup> DataSymptomGroups { get; set; }
        public virtual DbSet<DataTaxForm> DataTaxForms { get; set; }
        public virtual DbSet<DataTransportType> DataTransportTypes { get; set; }
        public virtual DbSet<DataUnit> DataUnits { get; set; }
        public virtual DbSet<DataVatBasisType> DataVatBasisTypes { get; set; }
        public virtual DbSet<DataVendorType> DataVendorTypes { get; set; }
        public virtual DbSet<DataVisitPurpose> DataVisitPurposes { get; set; }
        public virtual DbSet<DataWard> DataWards { get; set; }
        public virtual DbSet<DataWarrantyStatus> DataWarrantyStatuses { get; set; }
        public virtual DbSet<DataWithholdingDocFormat> DataWithholdingDocFormats { get; set; }
        public virtual DbSet<DataWounded> DataWoundeds { get; set; }
        public virtual DbSet<DataXrayPosition> DataXrayPositions { get; set; }
        public virtual DbSet<DataXrayRepeated> DataXrayRepeateds { get; set; }
        public virtual DbSet<DataXrayType> DataXrayTypes { get; set; }
        public virtual DbSet<DebtDeduction> DebtDeductions { get; set; }
        public virtual DbSet<DebtDeductionItem> DebtDeductionItems { get; set; }
        public virtual DbSet<DeliveryOrder> DeliveryOrders { get; set; }
        public virtual DbSet<DeliveryOrderItem> DeliveryOrderItems { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<DeviceRegister> DeviceRegisters { get; set; }
        public virtual DbSet<DocAnnotation> DocAnnotations { get; set; }
        public virtual DbSet<DocAnnotationItem> DocAnnotationItems { get; set; }
        public virtual DbSet<DocAnnotationItemSite> DocAnnotationItemSites { get; set; }
        public virtual DbSet<DocApprove> DocApproves { get; set; }
        public virtual DbSet<DocApproveLevel> DocApproveLevels { get; set; }
        public virtual DbSet<DocItem> DocItems { get; set; }
        public virtual DbSet<DownPay> DownPays { get; set; }
        public virtual DbSet<DownReceive> DownReceives { get; set; }
        public virtual DbSet<Draw> Draws { get; set; }
        public virtual DbSet<DrawItem> DrawItems { get; set; }
        public virtual DbSet<Dtproperty> Dtproperties { get; set; }
        public virtual DbSet<EmployeeAdvance> EmployeeAdvances { get; set; }
        public virtual DbSet<EmployeeAdvanceBy> EmployeeAdvanceBies { get; set; }
        public virtual DbSet<EmployeeAdvanceItem> EmployeeAdvanceItems { get; set; }
        public virtual DbSet<EvaluateExhibitionItem> EvaluateExhibitionItems { get; set; }
        public virtual DbSet<EvaluateMeetingItem> EvaluateMeetingItems { get; set; }
        public virtual DbSet<EvaluateTraining> EvaluateTrainings { get; set; }
        public virtual DbSet<EvaluateTrainingItem> EvaluateTrainingItems { get; set; }
        public virtual DbSet<ExchangeJob> ExchangeJobs { get; set; }
        public virtual DbSet<ExchangeSchedule> ExchangeSchedules { get; set; }
        public virtual DbSet<ExchangeScheduleBranch> ExchangeScheduleBranches { get; set; }
        public virtual DbSet<ExchangeTemplate> ExchangeTemplates { get; set; }
        public virtual DbSet<ExchangeTemplateItem> ExchangeTemplateItems { get; set; }
        public virtual DbSet<ExhibitionExpense> ExhibitionExpenses { get; set; }
        public virtual DbSet<ExhibitionJoin> ExhibitionJoins { get; set; }
        public virtual DbSet<ExhibitionSchedule> ExhibitionSchedules { get; set; }
        public virtual DbSet<ExhibitionStaff> ExhibitionStaffs { get; set; }
        public virtual DbSet<Expenditure> Expenditures { get; set; }
        public virtual DbSet<ExpenditureItem> ExpenditureItems { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseEntry> ExpenseEntries { get; set; }
        public virtual DbSet<ExpenseEntryItem> ExpenseEntryItems { get; set; }
        public virtual DbSet<Fdareport> Fdareports { get; set; }
        public virtual DbSet<ForecastExpense> ForecastExpenses { get; set; }
        public virtual DbSet<GroomingVisit> GroomingVisits { get; set; }
        public virtual DbSet<HomeCare> HomeCares { get; set; }
        public virtual DbSet<HomeCareProgressNote> HomeCareProgressNotes { get; set; }
        public virtual DbSet<Icd10visit> Icd10visits { get; set; }
        public virtual DbSet<Icd9cmvisit> Icd9cmvisits { get; set; }
        public virtual DbSet<Icd9test> Icd9tests { get; set; }
        public virtual DbSet<InOut> InOuts { get; set; }
        public virtual DbSet<InOutExport> InOutExports { get; set; }
        public virtual DbSet<InOutExportItem> InOutExportItems { get; set; }
        public virtual DbSet<InOutSummary> InOutSummaries { get; set; }
        public virtual DbSet<IncomeByPurpose> IncomeByPurposes { get; set; }
        public virtual DbSet<InternalUse> InternalUses { get; set; }
        public virtual DbSet<InternalUseItem> InternalUseItems { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<InvoicePurchase> InvoicePurchases { get; set; }
        public virtual DbSet<InvoicePurchaseItem> InvoicePurchaseItems { get; set; }
        public virtual DbSet<InvoiceReference> InvoiceReferences { get; set; }
        public virtual DbSet<IpdchartNote> IpdchartNotes { get; set; }
        public virtual DbSet<ItemBeginMonth> ItemBeginMonths { get; set; }
        public virtual DbSet<ItemBeginYear> ItemBeginYears { get; set; }
        public virtual DbSet<ItemComposite> ItemComposites { get; set; }
        public virtual DbSet<ItemCount> ItemCounts { get; set; }
        public virtual DbSet<ItemCountDetail> ItemCountDetails { get; set; }
        public virtual DbSet<ItemDiscountIncentive> ItemDiscountIncentives { get; set; }
        public virtual DbSet<ItemDose> ItemDoses { get; set; }
        public virtual DbSet<ItemForSkin> ItemForSkins { get; set; }
        public virtual DbSet<ItemFx> ItemFxes { get; set; }
        public virtual DbSet<ItemIncentive> ItemIncentives { get; set; }
        public virtual DbSet<ItemLabPackage> ItemLabPackages { get; set; }
        public virtual DbSet<ItemLot> ItemLots { get; set; }
        public virtual DbSet<ItemMaxDose> ItemMaxDoses { get; set; }
        public virtual DbSet<ItemPayment> ItemPayments { get; set; }
        public virtual DbSet<ItemPaymentItem> ItemPaymentItems { get; set; }
        public virtual DbSet<ItemPrice> ItemPrices { get; set; }
        public virtual DbSet<ItemPriceBranch> ItemPriceBranches { get; set; }
        public virtual DbSet<ItemPriceTable> ItemPriceTables { get; set; }
        public virtual DbSet<ItemPriceTableBranch> ItemPriceTableBranches { get; set; }
        public virtual DbSet<ItemPromotion> ItemPromotions { get; set; }
        public virtual DbSet<ItemPurchasePrice> ItemPurchasePrices { get; set; }
        public virtual DbSet<ItemQue> ItemQues { get; set; }
        public virtual DbSet<ItemSerial> ItemSerials { get; set; }
        public virtual DbSet<ItemVaccineIcd10> ItemVaccineIcd10s { get; set; }
        public virtual DbSet<ItemXrayPackage> ItemXrayPackages { get; set; }
        public virtual DbSet<Ivtherapy> Ivtherapies { get; set; }
        public virtual DbSet<JobDescriptionEducation> JobDescriptionEducations { get; set; }
        public virtual DbSet<JobDescriptionSkill> JobDescriptionSkills { get; set; }
        public virtual DbSet<JobDescriptionTrain> JobDescriptionTrains { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<JournalBy> JournalBies { get; set; }
        public virtual DbSet<JournalItem> JournalItems { get; set; }
        public virtual DbSet<JournalTemplate> JournalTemplates { get; set; }
        public virtual DbSet<JournalTemplateItem> JournalTemplateItems { get; set; }
        public virtual DbSet<Knowledge> Knowledges { get; set; }
        public virtual DbSet<LabRequest> LabRequests { get; set; }
        public virtual DbSet<LabRequestItem> LabRequestItems { get; set; }
        public virtual DbSet<LabResultByType> LabResultByTypes { get; set; }
        public virtual DbSet<LabResultReport> LabResultReports { get; set; }
        public virtual DbSet<LineNotify> LineNotifies { get; set; }
        public virtual DbSet<LogDatum> LogData { get; set; }
        public virtual DbSet<Maccount> Maccounts { get; set; }
        public virtual DbSet<MaccountAssign> MaccountAssigns { get; set; }
        public virtual DbSet<MaccountBook> MaccountBooks { get; set; }
        public virtual DbSet<MaccountGroup> MaccountGroups { get; set; }
        public virtual DbSet<MaccountItem> MaccountItems { get; set; }
        public virtual DbSet<MaccountOption> MaccountOptions { get; set; }
        public virtual DbSet<MaccountPeriod> MaccountPeriods { get; set; }
        public virtual DbSet<MaccountSheetsFormat> MaccountSheetsFormats { get; set; }
        public virtual DbSet<MaccountSheetsFormatItem> MaccountSheetsFormatItems { get; set; }
        public virtual DbSet<MaccountTaskToBook> MaccountTaskToBooks { get; set; }
        public virtual DbSet<Mamphur> Mamphurs { get; set; }
        public virtual DbSet<Manimal> Manimals { get; set; }
        public virtual DbSet<ManimalImage> ManimalImages { get; set; }
        public virtual DbSet<MappBuild> MappBuilds { get; set; }
        public virtual DbSet<MappDateFormat> MappDateFormats { get; set; }
        public virtual DbSet<MarketingList> MarketingLists { get; set; }
        public virtual DbSet<Mbank> Mbanks { get; set; }
        public virtual DbSet<MbankBranch> MbankBranches { get; set; }
        public virtual DbSet<MbankNote> MbankNotes { get; set; }
        public virtual DbSet<MbiometricDatum> MbiometricData { get; set; }
        public virtual DbSet<MbiometricDevice> MbiometricDevices { get; set; }
        public virtual DbSet<MbiometricDeviceOption> MbiometricDeviceOptions { get; set; }
        public virtual DbSet<MbookLinkForm> MbookLinkForms { get; set; }
        public virtual DbSet<Mbreed> Mbreeds { get; set; }
        public virtual DbSet<Mcampaign> Mcampaigns { get; set; }
        public virtual DbSet<McardType> McardTypes { get; set; }
        public virtual DbSet<Mcertificate> Mcertificates { get; set; }
        public virtual DbSet<MchequeForm> MchequeForms { get; set; }
        public virtual DbSet<MclinicCalendar> MclinicCalendars { get; set; }
        public virtual DbSet<MclinicCalendarHoliday> MclinicCalendarHolidays { get; set; }
        public virtual DbSet<MclinicOption> MclinicOptions { get; set; }
        public virtual DbSet<Mcompany> Mcompanies { get; set; }
        public virtual DbSet<McompanyMap> McompanyMaps { get; set; }
        public virtual DbSet<Mcontact> Mcontacts { get; set; }
        public virtual DbSet<Mcounsellor> Mcounsellors { get; set; }
        public virtual DbSet<Mcoupon> Mcoupons { get; set; }
        public virtual DbSet<McreditCard> McreditCards { get; set; }
        public virtual DbSet<Mcrmoption> Mcrmoptions { get; set; }
        public virtual DbSet<McustomFieldTemplate> McustomFieldTemplates { get; set; }
        public virtual DbSet<Mcustomer> Mcustomers { get; set; }
        public virtual DbSet<McustomerCommunicationPrefer> McustomerCommunicationPrefers { get; set; }
        public virtual DbSet<McustomerContact> McustomerContacts { get; set; }
        public virtual DbSet<McustomerCustomField> McustomerCustomFields { get; set; }
        public virtual DbSet<McustomerImage> McustomerImages { get; set; }
        public virtual DbSet<McustomerMember> McustomerMembers { get; set; }
        public virtual DbSet<McustomerRelation> McustomerRelations { get; set; }
        public virtual DbSet<McustomerRight> McustomerRights { get; set; }
        public virtual DbSet<McustomerType> McustomerTypes { get; set; }
        public virtual DbSet<MdataTransferFieldTemplate> MdataTransferFieldTemplates { get; set; }
        public virtual DbSet<MdataTransferFormat> MdataTransferFormats { get; set; }
        public virtual DbSet<MdataTransferName> MdataTransferNames { get; set; }
        public virtual DbSet<MdataTransferType> MdataTransferTypes { get; set; }
        public virtual DbSet<MdatabaseConnection> MdatabaseConnections { get; set; }
        public virtual DbSet<Mdeligent> Mdeligents { get; set; }
        public virtual DbSet<Mdepartment> Mdepartments { get; set; }
        public virtual DbSet<MdiscountType> MdiscountTypes { get; set; }
        public virtual DbSet<MdocGroup> MdocGroups { get; set; }
        public virtual DbSet<MdocOption> MdocOptions { get; set; }
        public virtual DbSet<MdocType> MdocTypes { get; set; }
        public virtual DbSet<MdoctorNote> MdoctorNotes { get; set; }
        public virtual DbSet<Mdocument> Mdocuments { get; set; }
        public virtual DbSet<Mdose1> Mdose1s { get; set; }
        public virtual DbSet<Mdose2> Mdose2s { get; set; }
        public virtual DbSet<Mdose3> Mdose3s { get; set; }
        public virtual DbSet<Mdose4> Mdose4s { get; set; }
        public virtual DbSet<Mdose5> Mdose5s { get; set; }
        public virtual DbSet<Mdose6> Mdose6s { get; set; }
        public virtual DbSet<MdoseShortcut> MdoseShortcuts { get; set; }
        public virtual DbSet<MeetingExpense> MeetingExpenses { get; set; }
        public virtual DbSet<MeetingJoin> MeetingJoins { get; set; }
        public virtual DbSet<MeetingSchedule> MeetingSchedules { get; set; }
        public virtual DbSet<MeetingStaff> MeetingStaffs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageHeader> MessageHeaders { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<MevaluateDatum> MevaluateData { get; set; }
        public virtual DbSet<MexchangeOption> MexchangeOptions { get; set; }
        public virtual DbSet<Mexhibition> Mexhibitions { get; set; }
        public virtual DbSet<Mexpense> Mexpenses { get; set; }
        public virtual DbSet<MexpenseType> MexpenseTypes { get; set; }
        public virtual DbSet<Mfaction> Mfactions { get; set; }
        public virtual DbSet<Mfixasset> Mfixassets { get; set; }
        public virtual DbSet<MfixassetType> MfixassetTypes { get; set; }
        public virtual DbSet<Mholiday> Mholidays { get; set; }
        public virtual DbSet<Micd10> Micd10s { get; set; }
        public virtual DbSet<Micd10group> Micd10groups { get; set; }
        public virtual DbSet<Micd9cm> Micd9cms { get; set; }
        public virtual DbSet<Micd9cmgroup> Micd9cmgroups { get; set; }
        public virtual DbSet<MincomeDeduct> MincomeDeducts { get; set; }
        public virtual DbSet<MincomeDeductList> MincomeDeductLists { get; set; }
        public virtual DbSet<MinventoryOption> MinventoryOptions { get; set; }
        public virtual DbSet<Mitem> Mitems { get; set; }
        public virtual DbSet<MitemCustomField> MitemCustomFields { get; set; }
        public virtual DbSet<MitemExchange> MitemExchanges { get; set; }
        public virtual DbSet<MitemGroup> MitemGroups { get; set; }
        public virtual DbSet<MitemGroupImage> MitemGroupImages { get; set; }
        public virtual DbSet<MitemGroupIpd> MitemGroupIpds { get; set; }
        public virtual DbSet<MitemImage> MitemImages { get; set; }
        public virtual DbSet<MitemStockFormat> MitemStockFormats { get; set; }
        public virtual DbSet<MizpalClass> MizpalClasses { get; set; }
        public virtual DbSet<MizpalField> MizpalFields { get; set; }
        public virtual DbSet<MizpalMethod> MizpalMethods { get; set; }
        public virtual DbSet<MizpalTable> MizpalTables { get; set; }
        public virtual DbSet<MjobDescription> MjobDescriptions { get; set; }
        public virtual DbSet<Mjournal> Mjournals { get; set; }
        public virtual DbSet<MjournalOption> MjournalOptions { get; set; }
        public virtual DbSet<MkeyCard> MkeyCards { get; set; }
        public virtual DbSet<MkeyCardItem> MkeyCardItems { get; set; }
        public virtual DbSet<Mkitchen> Mkitchens { get; set; }
        public virtual DbSet<MlabItem> MlabItems { get; set; }
        public virtual DbSet<MlabItemStandard> MlabItemStandards { get; set; }
        public virtual DbSet<MlabOption> MlabOptions { get; set; }
        public virtual DbSet<Mlanguage> Mlanguages { get; set; }
        public virtual DbSet<MleaveType> MleaveTypes { get; set; }
        public virtual DbSet<Mlocation> Mlocations { get; set; }
        public virtual DbSet<Mmeeting> Mmeetings { get; set; }
        public virtual DbSet<MmemberCard> MmemberCards { get; set; }
        public virtual DbSet<MmesssageGroup> MmesssageGroups { get; set; }
        public virtual DbSet<Morganization> Morganizations { get; set; }
        public virtual DbSet<MorganizationLogo> MorganizationLogos { get; set; }
        public virtual DbSet<MpackageItem> MpackageItems { get; set; }
        public virtual DbSet<MpaymentType> MpaymentTypes { get; set; }
        public virtual DbSet<MpayrollOption> MpayrollOptions { get; set; }
        public virtual DbSet<MpayrollPeriod> MpayrollPeriods { get; set; }
        public virtual DbSet<MpictureTemplate> MpictureTemplates { get; set; }
        public virtual DbSet<MpongsakIncome> MpongsakIncomes { get; set; }
        public virtual DbSet<Mposoption> Mposoptions { get; set; }
        public virtual DbSet<Mprocedure> Mprocedures { get; set; }
        public virtual DbSet<Mproject> Mprojects { get; set; }
        public virtual DbSet<MprojectType> MprojectTypes { get; set; }
        public virtual DbSet<Mprovince> Mprovinces { get; set; }
        public virtual DbSet<Mque> Mques { get; set; }
        public virtual DbSet<MqueGroup> MqueGroups { get; set; }
        public virtual DbSet<MqueLocation> MqueLocations { get; set; }
        public virtual DbSet<MreceiptHeader> MreceiptHeaders { get; set; }
        public virtual DbSet<Mrecruit> Mrecruits { get; set; }
        public virtual DbSet<MrecruitImage> MrecruitImages { get; set; }
        public virtual DbSet<Mreport> Mreports { get; set; }
        public virtual DbSet<MrequestStatus> MrequestStatuses { get; set; }
        public virtual DbSet<Mresource> Mresources { get; set; }
        public virtual DbSet<Mroom> Mrooms { get; set; }
        public virtual DbSet<MroundUp> MroundUps { get; set; }
        public virtual DbSet<Mshift> Mshifts { get; set; }
        public virtual DbSet<MshiftGroup> MshiftGroups { get; set; }
        public virtual DbSet<MsocialContact> MsocialContacts { get; set; }
        public virtual DbSet<MspecialIn> MspecialIns { get; set; }
        public virtual DbSet<MspeciesBloodGroup> MspeciesBloodGroups { get; set; }
        public virtual DbSet<Mspecy> Mspecies { get; set; }
        public virtual DbSet<Mstaff> Mstaffs { get; set; }
        public virtual DbSet<MstaffAccess> MstaffAccesses { get; set; }
        public virtual DbSet<MstaffCalendar> MstaffCalendars { get; set; }
        public virtual DbSet<MstaffCalendarHoliday> MstaffCalendarHolidays { get; set; }
        public virtual DbSet<MstaffGroup> MstaffGroups { get; set; }
        public virtual DbSet<MstaffImage> MstaffImages { get; set; }
        public virtual DbSet<MstaffMap> MstaffMaps { get; set; }
        public virtual DbSet<MstaffOrganization> MstaffOrganizations { get; set; }
        public virtual DbSet<MstaffRight> MstaffRights { get; set; }
        public virtual DbSet<MstaffTaxDeduct> MstaffTaxDeducts { get; set; }
        public virtual DbSet<MsubItemGroup> MsubItemGroups { get; set; }
        public virtual DbSet<MsubItemGroupIpd> MsubItemGroupIpds { get; set; }
        public virtual DbSet<MsyndromeGroup> MsyndromeGroups { get; set; }
        public virtual DbSet<MtaxTable> MtaxTables { get; set; }
        public virtual DbSet<MtemplateSiteItem> MtemplateSiteItems { get; set; }
        public virtual DbSet<MtimeAttendanceOption> MtimeAttendanceOptions { get; set; }
        public virtual DbSet<MtitleName> MtitleNames { get; set; }
        public virtual DbSet<Mtraining> Mtrainings { get; set; }
        public virtual DbSet<Mtumbon> Mtumbons { get; set; }
        public virtual DbSet<Mvendor> Mvendors { get; set; }
        public virtual DbSet<MvendorGroup> MvendorGroups { get; set; }
        public virtual DbSet<Mvoucher> Mvouchers { get; set; }
        public virtual DbSet<MvoucherType> MvoucherTypes { get; set; }
        public virtual DbSet<MvoucherTypeItem> MvoucherTypeItems { get; set; }
        public virtual DbSet<Mwarehouse> Mwarehouses { get; set; }
        public virtual DbSet<MwithholdingTaxType> MwithholdingTaxTypes { get; set; }
        public virtual DbSet<MworkInHoliday> MworkInHolidays { get; set; }
        public virtual DbSet<MworkTable> MworkTables { get; set; }
        public virtual DbSet<Mworkstation> Mworkstations { get; set; }
        public virtual DbSet<MxrayItem> MxrayItems { get; set; }
        public virtual DbSet<OngoingOrder> OngoingOrders { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<OpportunityItem> OpportunityItems { get; set; }
        public virtual DbSet<OrganizationDatum> OrganizationData { get; set; }
        public virtual DbSet<Pack> Packs { get; set; }
        public virtual DbSet<PackFromItem> PackFromItems { get; set; }
        public virtual DbSet<PackToItem> PackToItems { get; set; }
        public virtual DbSet<PatientAlert> PatientAlerts { get; set; }
        public virtual DbSet<PayByOther> PayByOthers { get; set; }
        public virtual DbSet<PayByOthersItem> PayByOthersItems { get; set; }
        public virtual DbSet<Pc> Pcs { get; set; }
        public virtual DbSet<Pcreimburse> Pcreimburses { get; set; }
        public virtual DbSet<PcreimburseBy> PcreimburseBies { get; set; }
        public virtual DbSet<PcreimburseItem> PcreimburseItems { get; set; }
        public virtual DbSet<PeriodEnd> PeriodEnds { get; set; }
        public virtual DbSet<PetQue> PetQues { get; set; }
        public virtual DbSet<PettyCash> PettyCashes { get; set; }
        public virtual DbSet<PettyCashItem> PettyCashItems { get; set; }
        public virtual DbSet<PharmaRequest> PharmaRequests { get; set; }
        public virtual DbSet<PlanOrder> PlanOrders { get; set; }
        public virtual DbSet<Po> Pos { get; set; }
        public virtual DbSet<PointDetail> PointDetails { get; set; }
        public virtual DbSet<Poitem> Poitems { get; set; }
        public virtual DbSet<Pr> Prs { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<PriceListItem> PriceListItems { get; set; }
        public virtual DbSet<Pritem> Pritems { get; set; }
        public virtual DbSet<ProcessScheduleChange> ProcessScheduleChanges { get; set; }
        public virtual DbSet<ProgressNote> ProgressNotes { get; set; }
        public virtual DbSet<ProjectAllocate> ProjectAllocates { get; set; }
        public virtual DbSet<ProjectAllocateItem> ProjectAllocateItems { get; set; }
        public virtual DbSet<ProjectProcess> ProjectProcesses { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionItem> PromotionItems { get; set; }
        public virtual DbSet<PromotionItemFree> PromotionItemFrees { get; set; }
        public virtual DbSet<PromotionItemGroup> PromotionItemGroups { get; set; }
        public virtual DbSet<PromotionItemSale> PromotionItemSales { get; set; }
        public virtual DbSet<QueTracking> QueTrackings { get; set; }
        public virtual DbSet<QueryDatum> QueryData { get; set; }
        public virtual DbSet<QueryQue> QueryQues { get; set; }
        public virtual DbSet<Quotation> Quotations { get; set; }
        public virtual DbSet<QuotationItem> QuotationItems { get; set; }
        public virtual DbSet<ReCall> ReCalls { get; set; }
        public virtual DbSet<RealSalesIncentive> RealSalesIncentives { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptItem> ReceiptItems { get; set; }
        public virtual DbSet<RecruitEducation> RecruitEducations { get; set; }
        public virtual DbSet<RecruitExperience> RecruitExperiences { get; set; }
        public virtual DbSet<ReferInReferOut> ReferInReferOuts { get; set; }
        public virtual DbSet<RegisterProgram> RegisterPrograms { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<ReminderItem> ReminderItems { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestFixAsset> RequestFixAssets { get; set; }
        public virtual DbSet<Requirement> Requirements { get; set; }
        public virtual DbSet<RequirementChange> RequirementChanges { get; set; }
        public virtual DbSet<Reserve> Reserves { get; set; }
        public virtual DbSet<ReserveItem> ReserveItems { get; set; }
        public virtual DbSet<ReservePay> ReservePays { get; set; }
        public virtual DbSet<ReservePayItem> ReservePayItems { get; set; }
        public virtual DbSet<ReturnFromCustomer> ReturnFromCustomers { get; set; }
        public virtual DbSet<ReturnFromCustomerItem> ReturnFromCustomerItems { get; set; }
        public virtual DbSet<ReturnToVendor> ReturnToVendors { get; set; }
        public virtual DbSet<ReturnToVendorItem> ReturnToVendorItems { get; set; }
        public virtual DbSet<Ro> Ros { get; set; }
        public virtual DbSet<Roitem> Roitems { get; set; }
        public virtual DbSet<RoomTran> RoomTrans { get; set; }
        public virtual DbSet<SalaryCalc> SalaryCalcs { get; set; }
        public virtual DbSet<SalaryCalcItem> SalaryCalcItems { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesIncentive> SalesIncentives { get; set; }
        public virtual DbSet<SalesItem> SalesItems { get; set; }
        public virtual DbSet<SalesMember> SalesMembers { get; set; }
        public virtual DbSet<SalesMemberItem> SalesMemberItems { get; set; }
        public virtual DbSet<SalesPeriod> SalesPeriods { get; set; }
        public virtual DbSet<SpermOvumBank> SpermOvumBanks { get; set; }
        public virtual DbSet<Sspreport> Sspreports { get; set; }
        public virtual DbSet<StaffAdvanceReceive> StaffAdvanceReceives { get; set; }
        public virtual DbSet<StaffAdvanceRequest> StaffAdvanceRequests { get; set; }
        public virtual DbSet<StaffBorrowAsset> StaffBorrowAssets { get; set; }
        public virtual DbSet<StaffBorrowAssetItem> StaffBorrowAssetItems { get; set; }
        public virtual DbSet<StaffByGroup> StaffByGroups { get; set; }
        public virtual DbSet<StaffCancelPending> StaffCancelPendings { get; set; }
        public virtual DbSet<StaffChangeShift> StaffChangeShifts { get; set; }
        public virtual DbSet<StaffChildRequest> StaffChildRequests { get; set; }
        public virtual DbSet<StaffChildRequestItem> StaffChildRequestItems { get; set; }
        public virtual DbSet<StaffContract> StaffContracts { get; set; }
        public virtual DbSet<StaffDiscountLimit> StaffDiscountLimits { get; set; }
        public virtual DbSet<StaffEducation> StaffEducations { get; set; }
        public virtual DbSet<StaffExperience> StaffExperiences { get; set; }
        public virtual DbSet<StaffFamily> StaffFamilies { get; set; }
        public virtual DbSet<StaffGroupRight> StaffGroupRights { get; set; }
        public virtual DbSet<StaffGuarantee> StaffGuarantees { get; set; }
        public virtual DbSet<StaffIncomeDeductTemplate> StaffIncomeDeductTemplates { get; set; }
        public virtual DbSet<StaffInsurance> StaffInsurances { get; set; }
        public virtual DbSet<StaffLateAbsent> StaffLateAbsents { get; set; }
        public virtual DbSet<StaffLeave> StaffLeaves { get; set; }
        public virtual DbSet<StaffLoan> StaffLoans { get; set; }
        public virtual DbSet<StaffLoanPayment> StaffLoanPayments { get; set; }
        public virtual DbSet<StaffLoanRequest> StaffLoanRequests { get; set; }
        public virtual DbSet<StaffLoanResult> StaffLoanResults { get; set; }
        public virtual DbSet<StaffMedicalPayment> StaffMedicalPayments { get; set; }
        public virtual DbSet<StaffMedicalRequest> StaffMedicalRequests { get; set; }
        public virtual DbSet<StaffMedicalRequestItem> StaffMedicalRequestItems { get; set; }
        public virtual DbSet<StaffOt> StaffOts { get; set; }
        public virtual DbSet<StaffOutstanding> StaffOutstandings { get; set; }
        public virtual DbSet<StaffPending> StaffPendings { get; set; }
        public virtual DbSet<StaffPeriod> StaffPeriods { get; set; }
        public virtual DbSet<StaffPongsakIncome> StaffPongsakIncomes { get; set; }
        public virtual DbSet<StaffPromote> StaffPromotes { get; set; }
        public virtual DbSet<StaffPunish> StaffPunishes { get; set; }
        public virtual DbSet<StaffResign> StaffResigns { get; set; }
        public virtual DbSet<StaffReturnAdvance> StaffReturnAdvances { get; set; }
        public virtual DbSet<StaffReturnLoan> StaffReturnLoans { get; set; }
        public virtual DbSet<StaffSalary> StaffSalaries { get; set; }
        public virtual DbSet<StaffSkill> StaffSkills { get; set; }
        public virtual DbSet<StaffTaxTemplate> StaffTaxTemplates { get; set; }
        public virtual DbSet<StaffWorkQue> StaffWorkQues { get; set; }
        public virtual DbSet<StaffWorkTime> StaffWorkTimes { get; set; }
        public virtual DbSet<StockCard> StockCards { get; set; }
        public virtual DbSet<SurgeryEstimate> SurgeryEstimates { get; set; }
        public virtual DbSet<SurgeryEstimateItem> SurgeryEstimateItems { get; set; }
        public virtual DbSet<SurgeryNote> SurgeryNotes { get; set; }
        public virtual DbSet<TempBeginingAccount> TempBeginingAccounts { get; set; }
        public virtual DbSet<ToDo> ToDos { get; set; }
        public virtual DbSet<ToSocialWelfare> ToSocialWelfares { get; set; }
        public virtual DbSet<ToolSummary> ToolSummaries { get; set; }
        public virtual DbSet<TrainingExpense> TrainingExpenses { get; set; }
        public virtual DbSet<TrainingJoin> TrainingJoins { get; set; }
        public virtual DbSet<TrainingSchedule> TrainingSchedules { get; set; }
        public virtual DbSet<TrainingStaff> TrainingStaffs { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<TransferCourse> TransferCourses { get; set; }
        public virtual DbSet<TransferCourseItem> TransferCourseItems { get; set; }
        public virtual DbSet<TransferItem> TransferItems { get; set; }
        public virtual DbSet<TransferToBank> TransferToBanks { get; set; }
        public virtual DbSet<VaccineItem> VaccineItems { get; set; }
        public virtual DbSet<VatPurchase> VatPurchases { get; set; }
        public virtual DbSet<VatSale> VatSales { get; set; }
        public virtual DbSet<VitalSign> VitalSigns { get; set; }
        public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }
        public virtual DbSet<Whitem> Whitems { get; set; }
        public virtual DbSet<WhitemDaily> WhitemDailies { get; set; }
        public virtual DbSet<WhitemHistory> WhitemHistories { get; set; }
        public virtual DbSet<WithholdingTax> WithholdingTaxes { get; set; }
        public virtual DbSet<WithholdingTaxItem> WithholdingTaxItems { get; set; }
        public virtual DbSet<WorkstationDrive> WorkstationDrives { get; set; }
        public virtual DbSet<WorkstationDriver> WorkstationDrivers { get; set; }
        public virtual DbSet<WorkstationHardware> WorkstationHardwares { get; set; }
        public virtual DbSet<WorkstationSoftware> WorkstationSoftwares { get; set; }
        public virtual DbSet<XrayRequest> XrayRequests { get; set; }
        public virtual DbSet<XrayRequestItem> XrayRequestItems { get; set; }
        public virtual DbSet<XrayResult> XrayResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<AccountCode>(entity =>
            {
                entity.HasKey(e => new { e.AccountCode1, e.CreateByOrgCode });
            });

            modelBuilder.Entity<AccountPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PeriodId });

                entity.Property(e => e.PeriodId).HasComment("รหัสรอบบัญชี");

                entity.Property(e => e.CloseTime).HasComment("วันที่ปิดรอบ");

                entity.Property(e => e.IsCanApprove).HasComment("รอบบัญชีนี้ยังสามารถอนุมัติเอกสารในงวดได้หรือไม่");

                entity.Property(e => e.IsCanDelete).HasComment("รอบบัญชีนี้ยังสามารถลบเอกสารในงวดได้หรือไม่");

                entity.Property(e => e.IsCanEdit).HasComment("รอบบัญชีนี้ยังสามารถแก้ไขเอกสารในงวดได้หรือไม่");

                entity.Property(e => e.OpenTime).HasComment("วันที่เปิดรอบ");

                entity.Property(e => e.PeriodDate).HasComment("วันที่งวด สนใจแค่เดือนกับปี ว่าเป็นงวดของเดือนและปีอะไร");

                entity.Property(e => e.PeriodName).HasComment("ชื่อรอบบัญชี (งวด) ex. 01/59 คือ งวดเดือน 1 ปี 59");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("ผู้เปิดรอบบัญชี");

                entity.Property(e => e.StatusId).HasComment("สถานะรอบบัญชี 1 เปิดอยู่/ 2 ปิดแล้ว");
            });

            modelBuilder.Entity<AccountPeriodTran>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PeriodId, e.AccountCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.PeriodId).HasComment("ลำดับงวด");

                entity.Property(e => e.BalanceAmount).HasComment("ยอดยกมา");

                entity.Property(e => e.BudgetAmount).HasComment("งบประมาณปีบช.ปัจจุบัน");

                entity.Property(e => e.BudgetCause).HasComment("เกณฑ์ในการคิดงบประมาณของปีบช.ปัจจุบัน");

                entity.Property(e => e.CarryForWordAmount).HasComment("ยอดยกไป");

                entity.Property(e => e.LastPeriodId).HasComment("ลำดับงวดที่ต้องการเปรียบเทียบ");
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.CreateByOrgCode });

                entity.Property(e => e.ActionId).HasComment("SeqID");

                entity.Property(e => e.Details).HasComment("Description");

                entity.Property(e => e.Remark).HasComment("other");

                entity.Property(e => e.RequestTypeId).HasComment("ประเภทข้อเสนอ");
            });

            modelBuilder.Entity<Adjust>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdjustNo });
            });

            modelBuilder.Entity<AdjustItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdjustNo, e.SeqId });
            });

            modelBuilder.Entity<AdmitDischarge>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn });

                entity.Property(e => e.AdmitTypeId).HasComment("ประเภทการเข้าพัก 10=ปกติ, 30=ส่งต่อจาก ,50= ฝากเลี้ยง(สำหรับ Vettale)");

                entity.Property(e => e.CauseCode).HasComment("รหัสสาเหตุการ ReferOut");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DischargeByCode).HasComment("แพทย์ผู้ปล่อย");

                entity.Property(e => e.DischargeStatusCode).HasComment("สถานะการ Discharge");

                entity.Property(e => e.DischargeTypeId).HasComment("ประเภทการปล่อย 10=ปกติ, 30=ส่งไปที่, 50= เสียชีวิต (สำหรับ Vettale)");

                entity.Property(e => e.FoodTypeCode).HasComment("ประเภทอาหาร");

                entity.Property(e => e.FoodTypeNote).HasComment("รายละเอียดประเภทอาหาร");

                entity.Property(e => e.ForwardSymptoms).HasComment("บันทึกการส่งเวร");

                entity.Property(e => e.IsAdmit).HasComment("ทำการ Admint แล้ว");

                entity.Property(e => e.IsDischarge).HasComment("ทำการ Discharge แล้ว");

                entity.Property(e => e.PatientStuff).HasComment("ของใช้ติดตัว");

                entity.Property(e => e.PetCareChargeTypeId).HasComment("ประเภทการคิดเงินฝากเลี้ยง 1=ค้างคืน 2=รายวัน");

                entity.Property(e => e.PrognosisTypeId).HasComment("ประเมินอาการ");

                entity.Property(e => e.RecordByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.ReferInFromLocation).HasComment("สถานที่ที่ถูกส่งมา (สำหรับ Vettale)");

                entity.Property(e => e.ReferOutToLocation).HasComment("สถานที่ที่ถูกส่งไป (สำหรับ Vettale)");

                entity.Property(e => e.ReleaseByCode).HasComment("ผู้ปล่อย");
            });

            modelBuilder.Entity<AdvancePay>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvancePayNo });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AdvancePayNo).HasComment("เลขที่รายการจ่ายชำระล่วงหน้า (ชำระเงินให้ผู้จำหน่ายโดยยังไม่ได้รับบริการ/สินค้า)");

                entity.Property(e => e.CashAmount).HasComment("ยอดชำระ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.InvoiceAmount).HasComment("ยอดจ่ายล่วงหน้า");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");
            });

            modelBuilder.Entity<AdvanceReceive>(entity =>
            {
                entity.Property(e => e.AdvanceReceveNo).HasComment("เลขที่รายการรับชำระล่วงหน้า(รับชำระโดยลูกค้ายังไม่ได้รับบริการ/สินค้า)");

                entity.Property(e => e.CashAmount).HasComment("ยอดชำระ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.InvoiceAmount).HasComment("ยอดจ่ายล่วงหน้า");

                entity.Property(e => e.Vn).HasComment("VN");
            });

            modelBuilder.Entity<AdvanceReimburse>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvanceReimburseNo });
            });

            modelBuilder.Entity<AdvanceReimburseBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvanceReimburseNo, e.SeqId });
            });

            modelBuilder.Entity<AdvanceReimburseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvanceReimburseNo, e.SeqId });
            });

            modelBuilder.Entity<Ae>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aeno });
            });

            modelBuilder.Entity<Aeby>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aeno, e.SeqId });
            });

            modelBuilder.Entity<Aeitem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aeno, e.SeqId });
            });

            modelBuilder.Entity<Aereimburse>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AereimburseNo });
            });

            modelBuilder.Entity<AereimburseBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AereimburseNo, e.SeqId });
            });

            modelBuilder.Entity<AereimburseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AereimburseNo, e.SeqId });
            });

            modelBuilder.Entity<Ai>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aino });

                entity.Property(e => e.Aino).HasComment("เลขที่รับมัดจำ");

                entity.Property(e => e.Aidate).HasComment("วันที่รับมัดจำ");

                entity.Property(e => e.BeginAmount).HasComment("จำนวนเงิน");

                entity.Property(e => e.CustomerCode).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CustomerContactGid).HasComment("GID ผู้ติดต่อ (มาจาก Vet เป็นสัตว์)");

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างอิง");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารอ้างอิง");

                entity.Property(e => e.RemainAmount).HasComment("เงินคงเหลือ");

                entity.Property(e => e.UseAmount).HasComment("จำนวนที่ใช้ไป");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");
            });

            modelBuilder.Entity<Aiby>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aino, e.SeqId });

                entity.Property(e => e.Aino).HasComment("เลขที่รับมัดจำ");

                entity.Property(e => e.AccountCode).HasComment("รหัสผังบัญชี");

                entity.Property(e => e.BankBranchName).HasComment("สาขาธนาคาร");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคาร");

                entity.Property(e => e.BookBankId).HasComment("สมุดบัญชี");

                entity.Property(e => e.ChequeDate).HasComment("วันที่เช็ค");

                entity.Property(e => e.ChequeNo).HasComment("เลขที่เช็ค");

                entity.Property(e => e.CreditCardCode).HasComment("รหัสบัตรเครดิต");

                entity.Property(e => e.CreditCardNo).HasComment("เลขที่บัตรเครดิต");

                entity.Property(e => e.CreditCardSwipeCode).HasComment("รหัสเครื่องรูดบัตรเครดิต");

                entity.Property(e => e.CreditCardTypeCode).HasComment("ประเภทบัตรเดรดิต");

                entity.Property(e => e.ReceiveAmount).HasComment("จำนวนเงิน");

                entity.Property(e => e.ReceiveDate).HasComment("วันที่รับเงิน");

                entity.Property(e => e.ReceiveTypeId).HasComment("ประเภทการรับเงิน");

                entity.Property(e => e.TransferDate).HasComment("วันที่โอน");

                entity.Property(e => e.TransferNo).HasComment("เลขที่โอน");
            });

            modelBuilder.Entity<Aiitem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Aino, e.SeqId });

                entity.Property(e => e.Aino).HasComment("เลขที่รับมัดจำ");
            });

            modelBuilder.Entity<AnimalCheckUp>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.CheckUpCode });

                entity.Property(e => e.AnimalGid).HasComment("รหัสสัตว์ป่วย");

                entity.Property(e => e.ResultTypeId).HasComment("0=Not Specify, 1= Normal, 2=Abnormal");
            });

            modelBuilder.Entity<AnimalCheckupProgressNote>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.CheckUpCode, e.ProgressId });
            });

            modelBuilder.Entity<AnimalSideEffect>(entity =>
            {
                entity.HasKey(e => new { e.CompositeCode, e.AnimalGid, e.CreateByOrgCode });

                entity.Property(e => e.CompositeCode).HasComment("รหัสส่วนประกอบ");

                entity.Property(e => e.AnimalGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CompositeTypeId).HasComment("1=ส่วนประกอบ 2=ยา");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.IsSeverity).HasComment("ความรุนแรง 0,null เตือน,1 ห้ามจ่าย");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Severity).HasComment("อาการแพ้/ความรุนแรง");
            });

            modelBuilder.Entity<Anniversary>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AnniversaryId });
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CreateByOrgCode });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AnnounceDate).HasComment("วันที่ประกาศ");

                entity.Property(e => e.AnnounceHeader).HasComment("หัวข้อ");

                entity.Property(e => e.AnnounceMessage).HasComment("ข้อความ");

                entity.Property(e => e.AnnounceTypeId).HasComment("ประเภทของประกาศ 1=ระบบ 2=อัปเดต 3=ประกาศ");

                entity.Property(e => e.IsAlert).HasComment("=1 คือแสดงแจ้งเตือน");

                entity.Property(e => e.IsRead).HasComment("=1 คืออ่านแล้ว");
            });

            modelBuilder.Entity<Apcard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo, e.SeqId });
            });

            modelBuilder.Entity<Apdown>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DownNo });
            });

            modelBuilder.Entity<Appay>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AppayNo });

                entity.Property(e => e.Aeno).HasComment("เลขที่ใบจ่ายมัดจำเจ้าหนี้ ที่นำมาใช้กับ APPay นี้");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (centre II เก็บรหัสสาขา)");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.DueDate).HasComment("กำหนดชำระ");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II เก็บ รหัสแผนก)");

                entity.Property(e => e.PayDate).HasComment("วันที่ชำระ");

                entity.Property(e => e.Whtamount).HasComment("ยอดรวม");
            });

            modelBuilder.Entity<AppayBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AppayNo, e.SeqId });

                entity.Property(e => e.AccountCode).HasComment("เลขที่ผังบัญชี");
            });

            modelBuilder.Entity<AppayItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AppayNo, e.SeqId });

                entity.Property(e => e.DocNo).HasComment("RO.RONo  หรือ APTrans.DocNo");

                entity.Property(e => e.DocTypeId).HasComment("เก็บว่าการจ่ายนี้จ่ายจากเอกสารอะไร 1-RO/2-RTV");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II เก็บรหัสแผนก)");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AppId })
                    .HasName("PK_AppCustomer");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AppId).HasComment("เลขที่การนัดหมาย Running No.");

                entity.Property(e => e.AppFromDate).HasComment("วันที่นัดตั้งแต่");

                entity.Property(e => e.AppFromTime).HasComment("เวลานัดตั้งแต่");

                entity.Property(e => e.AppTel).HasComment("เบอร์โทรติดต่อของผู้นัดหมาย");

                entity.Property(e => e.AppToDate).HasComment("วันที่นัดถึง");

                entity.Property(e => e.AppToTime).HasComment("เวลาที่นัดถึง");

                entity.Property(e => e.AppointTypeId).HasComment("ประเภทการมาตามนัด 1 มาตามนัด | 2 มาไม่ตรงนัด | 3 ยกเลิกนัด | 4 ยืนยันนัด");

                entity.Property(e => e.AppointmentByCode).HasComment("รหัสผู้สร้างการนัดหมายครั้งนี้");

                entity.Property(e => e.AppointmentTypeCode).HasComment("รหัสประเภทการนัดหมาย");

                entity.Property(e => e.CompanyCode).HasComment("รหัสบริษัทลูกค้าที่นัดหมาย");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DisplayName).HasComment("ชื่อผู้นัด (กรณีที่ยังไม่เคยเป็นลูกค้า)");

                entity.Property(e => e.DoctorCode).HasComment("นัดมาเพื่อพบหมอรหัสนี้");

                entity.Property(e => e.FixAssetCode).HasComment("รหัสเครื่องมือที่จะใช้");

                entity.Property(e => e.FollowUpCount).HasComment("ตามนัดครั้งที่");

                entity.Property(e => e.FollowUpTypeCode).HasComment("รหัสประเภทการตามนัด");

                entity.Property(e => e.Icdcode).HasComment("รหัสการวินิจฉัย");

                entity.Property(e => e.IsAllDay).HasComment("ระบุว่านัดทั้งวัน");

                entity.Property(e => e.IsCome).HasComment("มาตามนัด");

                entity.Property(e => e.IsOt).HasComment("เป็นการนัดนอกเวลา 1 ไม่ใช่ 2 ใช่");

                entity.Property(e => e.IsRecall).HasComment("เป็นการ Recall หรือไม่");

                entity.Property(e => e.IsSendSms).HasComment("ส่ง SMS เตือนหรือยัง");

                entity.Property(e => e.LocationCode).HasComment("รหัสสถานที่นัด");

                entity.Property(e => e.NotificationOrderDate).HasComment("วันที่ตั้งต้นสำหรับการคำนวณเวลาแจ้งเตือน ");

                entity.Property(e => e.NotificationsDay).HasComment("ระบุจำนวนวันการแจ้งเตือนนัดรับผล");

                entity.Property(e => e.NotificationsHour).HasComment("ระบุจำนวนชั่วโมงการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.NotificationsMinute).HasComment("ระบุจำนวนนาทีการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.NotificationsMonth).HasComment("ระบุจำนวนเดือนการแจ้งเตือนนัดรับผล");

                entity.Property(e => e.NotificationsYear).HasComment("ระบุจำนวนปีการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.QueCode).HasComment("นัดมาเพื่อเจอเจอรหัสห้องนี้");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("นัดมาเพื่อเจอพนักงานรหัสนี้");

                entity.Property(e => e.StatusId).HasComment("สถานะของการโทร");

                entity.Property(e => e.Subject).HasComment("หัวข้อในการนัด");

                entity.Property(e => e.Vnvisit).HasComment("Visit No ที่เข้ามาใช้บริการ");
            });

            modelBuilder.Entity<Aptran>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo });

                entity.Property(e => e.DocTypeId).HasComment("ประเภทเอกสาร");

                entity.Property(e => e.VatChargeId).HasComment("รหัสภาระภาษี");
            });

            modelBuilder.Entity<Arbill>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BillNo });

                entity.Property(e => e.BillNo).HasComment("เลขที่ใบวางบิล");

                entity.Property(e => e.BillDate).HasComment("วันที่วางบิล");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DueDate).HasComment("วันที่กำหนดรับ");

                entity.Property(e => e.StaffCode).HasComment("รหัสผู้วางบิล");
            });

            modelBuilder.Entity<ArbillItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BillNo, e.DocNo });

                entity.Property(e => e.BillNo).HasComment("เลขที่ใบวางบิล");

                entity.Property(e => e.DocNo).HasComment("เอกสารตั้งหนี้/ลดหนี้");

                entity.Property(e => e.ConfirmByCode).HasComment("รหัสผู้ยืนยันสถานะ");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DocDate).HasComment("วันที่ออกเอกสาร");

                entity.Property(e => e.DueDate).HasComment("วันที่กำหนดตามเอกสาร");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่อ้างอิง");

                entity.Property(e => e.NetAmount).HasComment("รวมสุทธิ");

                entity.Property(e => e.TotalAmount).HasComment("รวม");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");
            });

            modelBuilder.Entity<Arreceive>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.ArreceiveNo })
                    .HasName("PK_ARReceive_1");

                entity.Property(e => e.AccountCode).HasComment("รหัสผังบัญชี");

                entity.Property(e => e.AppId).HasComment("เลขที่การนัดหมาย");

                entity.Property(e => e.BankAmount).HasComment("ยอดสุทธิจากสมุดธนาคาร");

                entity.Property(e => e.BookbankId).HasComment("เลขที่สมุดบัญชี");

                entity.Property(e => e.ClaimAmount).HasComment("ยอดที่ประกันจ่าย");

                entity.Property(e => e.ClaimDiscountAmount).HasComment("เก็บยอดส่วนลดที่เบิกกับผู้จ่ายร่วม");

                entity.Property(e => e.CouponAmount).HasComment("ยอดคูปอง");

                entity.Property(e => e.CreditcardSwipeCode).HasComment("รหัสเครื่องรูดบัตรเครดิต");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดสุทธิท้ายบิลเฉพาะที่ไม่คิด vat");

                entity.Property(e => e.DiscountAmountForVat).HasComment("ส่วนลดสุทธิท้ายบิลเฉพาะที่คิด vat");

                entity.Property(e => e.DiscountPoint).HasComment("ส่วนลดที่ใช้จากการแลกแต้ม");

                entity.Property(e => e.DiscountText).HasComment("อัตราส่วนลดท้ายบิลเฉพาะไม่คิด vat");

                entity.Property(e => e.DiscountTextForVat).HasComment("อัตราส่วนลดท้ายบิลเฉพาะที่คิด vat");

                entity.Property(e => e.DocStatusId).HasComment("0 ไม่ระบุ/ 1รออนุมัติ/ 2รับเงินแล้วตากปกติ/ 3บิลที่ถูกยกเลิกแล้ว");

                entity.Property(e => e.FactionCode).HasComment("แผนก(ใช้ใน Centre2)");

                entity.Property(e => e.NetAmount).HasComment("รวมท้ายบิลทั้งหลัง vat ทั้งที่คิดและไม่คิด vat");

                entity.Property(e => e.NetAmountForVat).HasComment("รวมท้ายบิลหลัง vat เฉพาะรายการที่คิด vat");

                entity.Property(e => e.PayTypeId).HasComment("1=จ่ายสด 2=จ่ายค้าง");

                entity.Property(e => e.ReceiveAmount).HasComment("รวมรับเงินแล้ว");

                entity.Property(e => e.ReceiveByCode).HasComment("รับเงินโดยใคร?");

                entity.Property(e => e.ReceiveTypeId).HasComment("รูปแบบการชำระเงิน(1=OPD, 2=IPD)");

                entity.Property(e => e.ReduceDebtAmount).HasComment("ยอดยกหนี้");

                entity.Property(e => e.ReferenceIndex).HasComment("รหัสการแยกเล่ม  อ้างอิงจาก MDocument");

                entity.Property(e => e.ReferenceNo).HasComment("ใช้เก็บ ARReceiveNo อ้างอิง กรณีมีการยกเลิกบิล");

                entity.Property(e => e.ReserveAmount).HasComment("เงินมัดจำ");

                entity.Property(e => e.ShiftTypeId).HasComment("เป็นการรับเงินกะใด 1-กลางวัน/ 2-กลางคืน");

                entity.Property(e => e.SocialDiscountAmount).HasComment("ราคาที่เบิกได้(ไม่หักจากยอดราคาสินค้า)");

                entity.Property(e => e.SumDiscountAmount).HasComment("รวมส่วนลดรายตัวเฉพาะที่ไม่คิด vat");

                entity.Property(e => e.SumDiscountAmountForVat).HasComment("รวมส่วนลดรายตัวเฉพาะที่คิด vat");

                entity.Property(e => e.SumTotalItemAmount).HasComment("รวม TotalAmount รายตัวเฉพาะที่ไม่คิด vat ก่อน vat");

                entity.Property(e => e.SumTotalItemAmountForVat).HasComment("รวม TotalAmount รายตัวเฉพาะที่คิด vat ก่อน vat");

                entity.Property(e => e.TotalAmount).HasComment("รวมท้ายบิลก่อนหักส่วนลดท้ายบิล");

                entity.Property(e => e.TotalAmountForNonVat).HasComment("รวมท้ายบิลเฉพาะรายการที่ไม่คิด Vat ก่อน Vat (sum=>TotalAmount-DiscountAmount รายตัวที่ไม่คิด vat)");

                entity.Property(e => e.TotalAmountForVat).HasComment("รวมท้ายบิลเฉพาะรายการที่คิด vat ก่อน vat ( sum=>TotalAmount - DiscoutAmount รายตัวที่คิด vat)");

                entity.Property(e => e.TransferDate).HasComment("วันที่โอนเงิน");

                entity.Property(e => e.TransferNo).HasComment("เลขที่โอนเงิน");
            });

            modelBuilder.Entity<ArreceiveAble>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.ArreceiveAbleNo });

                entity.Property(e => e.ClaimDisCountAmount).HasComment("สำหรับเก็บส่วนลดรายตัว+ท้ายบิล+ส่วนลดประกันอื่นที่ไม่ใช่ของตัวเอง");

                entity.Property(e => e.CurrentPayDebtAmount).HasComment("ยอดจ่ายค้างปัจจุบัน");

                entity.Property(e => e.NetAmount).HasComment("ยอดที่สามารถนำไปเบิกได้ ");

                entity.Property(e => e.NetClaimAmount).HasComment("เก็บยอด Net หลังหัก ClaimAmount");

                entity.Property(e => e.ReceiveAmount).HasComment("ยอดเงินที่รับมาแล้ว");

                entity.Property(e => e.RemainingAmount).HasComment("ยอดค้างคงเหลือ");
            });

            modelBuilder.Entity<ArreceiveAbleItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.Vn, e.RightCode });

                entity.Property(e => e.RightCode).HasComment("1 จะเป็นการจ่ายด้วยตัวเองใช้กับ ClinicLive");

                entity.Property(e => e.ArreceiveAbleSeqId).HasComment("เลขที่ SeqID ของ ARReceiveAble (อ้างอิงการจ่าย)");

                entity.Property(e => e.ClaimDisCountAmount).HasComment("สำหรับเก็บส่วนลดรายตัว+ท้ายบิล+ส่วนลดประกันอื่นที่ไม่ใช่ของตัวเอง");

                entity.Property(e => e.CurrentPayDebtAmount).HasComment("ยอดจ่ายค้างปัจจุบัน");

                entity.Property(e => e.NetClaimAmount).HasComment("เก็บยอด Net หลังหัก ClaimAmount");

                entity.Property(e => e.ReceiveAmount).HasComment("ยอดที่รับเงินมา");

                entity.Property(e => e.RemainingAmount).HasComment("ยอดค้างคงเหลือ");
            });

            modelBuilder.Entity<ArreceiveBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ArreceiveNo, e.SeqId });

                entity.Property(e => e.CreditCardCode).HasComment("ประเภทบัตรเครดิต");

                entity.Property(e => e.CreditCardPaymentTypeCode).HasComment("ประเภทการชำระ (เต็มวงเงิน ...)");

                entity.Property(e => e.CreditCardTypeCode).HasComment("ประเภทบัตรเดรดิต (Platinum,,,)");

                entity.Property(e => e.ReceiveTypeId).HasComment("1=เงินสด 2=เครดิต 3=เช็ค 4=คูปอง 5=เงินโอน");
            });

            modelBuilder.Entity<ArreceiveItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ArreceiveNo, e.SeqId, e.DocNo });

                entity.Property(e => e.CashAmount).HasComment("รวมรับชำระเงินสด");

                entity.Property(e => e.ChequeAmount).HasComment("รวมรับชำระด้วยเช็ค");

                entity.Property(e => e.ClaimAmount).HasComment("จำนวนเงินส่งเบิก");

                entity.Property(e => e.ClaimDiscountAmount).HasComment("เก็บยอดส่วนลดที่เบิกกับผู้จ่ายร่วม");

                entity.Property(e => e.CouponAmount).HasComment("ยอดคูปอง");

                entity.Property(e => e.CreditAmount).HasComment("รวมรับชำระด้วยเครดิต");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DebtAmount).HasComment("ยอดค้างชำระ");

                entity.Property(e => e.FactionCode).HasComment("แผนก(ใช้ใน Centre2)");

                entity.Property(e => e.GrandTotalReceiveAmount).HasComment("ยอดที่เคยรับชำระรวมทุกครั้ง");

                entity.Property(e => e.IsCalVat).HasComment("รายการสินค้านี้คำนวณ Vat หรือไม่");

                entity.Property(e => e.IsEarnPoint).HasComment("สินค้าที่ร่วมรายการสะสมแต้ม");

                entity.Property(e => e.PayDate).HasComment("วันที่กิน/วันที่ฉีด/วันที่ตรวจสอบรายการ");

                entity.Property(e => e.PayDebtAmount).HasComment("ยอดจ่ายค้าง");

                entity.Property(e => e.ReceiveTypeId).HasComment("รูปแบบการรับชำระเงิน 1=รับเงินธรรมดา, 2=รับการจ่ายชำระยอดค้าง");

                entity.Property(e => e.RefNo).HasComment("เลขที่ใบขายกรณีจ่ายค้าง (เลขที่ของใบที่ก่อหนี้)");

                entity.Property(e => e.RefSeqId).HasComment("ลำดับตามตาราง SalesItem (ของ salesitm ที่ก่อหนี้)");

                entity.Property(e => e.RefTypeId).HasComment("รหัสประเภทอ้างอิงของเอกสารต้นทาง");

                entity.Property(e => e.ReserveAmount).HasComment("ยอดรับเงินมัดจำ");

                entity.Property(e => e.SalesDate).HasComment("วันที่ขาย");

                entity.Property(e => e.SalesItemSeqId).HasComment("ลำดับจากตาราง SalesItem");

                entity.Property(e => e.SalesTypeId).HasComment("'เก็บว่าการสั่งครั้งนี้เป็น แบบสั่งให้ OPD หรือ สั่งให่ IPD---  1=OPD, 2=IPD ใช้กับระบบค่าใช้จ่ายสัตว์ป่วยใน");

                entity.Property(e => e.TaxAmount).HasComment("ภาา๊หัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.UnitName).HasComment("หน่วยขาย");

                entity.Property(e => e.VatTypeId).HasComment("รูปแบบภาษีที่คำนวณกับสินค้านี้");
            });

            modelBuilder.Entity<Artran>(entity =>
            {
                entity.Property(e => e.ArtransId).HasComment("เลขที่รันนิ่งของ ARTrans เอง");

                entity.Property(e => e.CouponAmount).HasComment("ยอดชำระด้วย Coupon");

                entity.Property(e => e.DiscountPoint).HasComment("ส่วนลดที่ใช้จากการแลกแต้ม");

                entity.Property(e => e.DocNo).HasComment("เลขที่เอกสารที่ทำให้เกิด ARTrans ใบนี้");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทเอกสาร");

                entity.Property(e => e.ReduceDebtAmount).HasComment("ยอดยกหนี้");

                entity.Property(e => e.ReferenceId).HasComment("เลขที่ ARTransID ที่เป็นใบตั้งต้น");

                entity.Property(e => e.ReserveAmount).HasComment("จำนวนเงินมัดจำ");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<AspNetUserLoginsTime>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.OrganizationCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้งาน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.FriTimeIn).HasComment("ทำงานวันศุกร เวลาเข้า");

                entity.Property(e => e.FriTimeOut).HasComment("ทำงานวันศุกร เวลาออก");

                entity.Property(e => e.IsFriday).HasComment("ทำงานวันศุกร์?");

                entity.Property(e => e.IsMonday).HasComment("ทำงานวันจันทร์?");

                entity.Property(e => e.IsSatday).HasComment("ทำงานวันเสาร์?");

                entity.Property(e => e.IsSunday).HasComment("ทำงานวันอาทิตย์?");

                entity.Property(e => e.IsThuday).HasComment("ทำงานวันพฤหัสดี?");

                entity.Property(e => e.IsTueday).HasComment("ทำงานวันอังคาร?");

                entity.Property(e => e.IsWedday).HasComment("ทำงานวันพุธ?");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.MonTimeIn).HasComment("ทำงานวันจันทร์ เวลาเข้า");

                entity.Property(e => e.MonTimeOut).HasComment("ทำงานวันจันทร์ เวลาออก");

                entity.Property(e => e.SatTimeIn).HasComment("ทำงานวันเสาร เวลาเข้า");

                entity.Property(e => e.SatTimeOut).HasComment("ทำงานวันเสาร เวลาออก");

                entity.Property(e => e.SunTimeIn).HasComment("ทำงานวันอาทิตย์ เวลาเข้า");

                entity.Property(e => e.SunTimeOut).HasComment("ทำงานวันอาทิตย์ เวลาออก");

                entity.Property(e => e.ThuTimeIn).HasComment("ทำงานวันพฤหัสดี เวลาเข้า");

                entity.Property(e => e.ThuTimeOut).HasComment("ทำงานวันพฤหัสดี เวลาออก");

                entity.Property(e => e.TueTimeIn).HasComment("ทำงานวันอังคาร เวลาเข้า");

                entity.Property(e => e.TueTimeOut).HasComment("ทำงานวันอังคาร เวลาออก");

                entity.Property(e => e.WedTimeIn).HasComment(" ทำงานวันพุธ เวลาเข้า");

                entity.Property(e => e.WedTimeOut).HasComment("ทำงานวันพุธ เวลาออก");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<BankInitial>(entity =>
            {
                entity.Property(e => e.RowId).HasComment("เลขที่รันอัตโนมัติ");

                entity.Property(e => e.Amount).HasComment("จำนวนเงิน");

                entity.Property(e => e.BookbankDate).HasComment("วันที่ลงยอด");

                entity.Property(e => e.BookbankId).HasComment("หมายเลขสมุดบัญชีเงินฝาก");
            });

            modelBuilder.Entity<BankMonthlyInitial>(entity =>
            {
                entity.Property(e => e.RowId).HasComment("เลขที่รันอัตโนมัติ");

                entity.Property(e => e.Amount).HasComment("จำนวนเงิน");

                entity.Property(e => e.BookbankDate).HasComment("วันที่ลงยอด");

                entity.Property(e => e.BookbankId).HasComment("หมายเลขสมุดบัญชีเงินฝาก");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (centre II เก็บรหัสสาขา)");
            });

            modelBuilder.Entity<BankTran>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo, e.SeqId });
            });

            modelBuilder.Entity<BankTransaction>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BankTransactionId, e.SeqId });

                entity.Property(e => e.BookBankStatementNo).HasComment("เลขที่รายการที่ทำกับสมุดบัญชีเงินฝาก");

                entity.Property(e => e.BookBankStatementTypeId).HasComment("ประเภทการเคลื่อนไหวของสมุดบัญชีเงินฝาก");

                entity.Property(e => e.CreditcardCode).HasComment("เลขที่บัตรตามหน้าบัตรเครดิต");

                entity.Property(e => e.CreditcardNo).HasComment("เลขที่การทำรายการของบัตรเครดิต");

                entity.Property(e => e.CreditcardSwipeCode).HasComment("รหัสเครื่องรูดบัตรเครดิต");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.IsCancel).HasComment("รายการ Transaction นี้เป้นรายการที่ยกเลิกไปแล้วใช่หรือไม่เช่น การทำเช็คยกเลิก");

                entity.Property(e => e.IsConfirm).HasComment("รายการนี้มีการตรวจสอบว่าถูกต้องและยืนยันแล้วใช่หรือไม่");

                entity.Property(e => e.IsReturn).HasComment("รายการนี้เป็นรายการที่เกิดจากการคืน Transaction หรือไม่ เช่น การยกเลิกเช็คผ่าน");

                entity.Property(e => e.Pccode).HasComment("รหัสวงเงินสดย่อย (กรณีฝาก/ถอนด้วยเงินสดย่อย)");

                entity.Property(e => e.RefTypeId).HasComment("ประเภทเอกสารอ้างอิงที่ทำให้เกิด Transaction ครั้งนี้");

                entity.Property(e => e.TransactionTypeId).HasComment("ประเภทการเคลื่อนไหวของ Transaction ครั้งนี้ (Cash, Credit, ..., etc.)");
            });

            modelBuilder.Entity<BeginingAccountPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AccountCode })
                    .HasName("PK_BeginingAccountPeriod_1");

                entity.Property(e => e.PeriodDate).HasComment("วันที่งวด สนใจแค่เดือนกับปี ว่าเป็นงวดของเดือนและปีอะไร");

                entity.Property(e => e.PeriodName).HasComment("ชื่อรอบบัญชี (งวด) ex. 01/59 คือ งวดเดือน 1 ปี 59");
            });

            modelBuilder.Entity<BigDealAlert>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BigDealAlertId });

                entity.Property(e => e.AlertTypeId).HasComment("1 = Login, 2 = E-mail");
            });

            modelBuilder.Entity<BigDealAlertToStaff>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BigDealAlertId, e.StaffCode })
                    .HasName("PK_BigDealAlertStaff");
            });

            modelBuilder.Entity<BigDealAlertToStaffGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BigDealAlertId, e.StaffGroupCode })
                    .HasName("PK_BigDealAlertStaffGroup");
            });

            modelBuilder.Entity<BloodBankCross>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CreateByOrgCode });

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasComment("รหัส BloodBankCross");

                entity.Property(e => e.BloodBankDonorId).HasComment("รหัส BloodBank ที่บริจาค");

                entity.Property(e => e.DoctorCode).HasComment("รหัสหมอ");

                entity.Property(e => e.DonorGid).HasComment("ผู้บริจาค");

                entity.Property(e => e.IsMajorMatch).HasComment("1 = pass , 2 = not pass");

                entity.Property(e => e.IsMinorMatch).HasComment("1 = pass , 2 = not pass");

                entity.Property(e => e.NotPassMajorResult).HasComment("1 = agglutination , 2 = hemolysis");

                entity.Property(e => e.NotPassMinorResult).HasComment("1 = agglutination , 2 = hemolysis");

                entity.Property(e => e.Pcvdonor).HasComment("ผล PCV ผู้บริจาค");

                entity.Property(e => e.Pcvrecipient).HasComment("ผล PCV ผู้รับบริจาค");

                entity.Property(e => e.RecipientGid).HasComment("ผู้รับบริจาค");

                entity.Property(e => e.ReportCode).HasComment("รหัสผู้บันทึก");
            });

            modelBuilder.Entity<BloodBankDonor>(entity =>
            {
                entity.HasKey(e => new { e.BloodBankId, e.CreateByOrgCode });

                entity.Property(e => e.BloodBankId)
                    .ValueGeneratedOnAdd()
                    .HasComment("รหัส BloodBank ที่บริจาค");

                entity.Property(e => e.AnimalName).HasComment("ชื่อสัตว์  (ภายนอก) ที่รับบริจาคมา");

                entity.Property(e => e.BloodGroupCode).HasComment("กรุ๊ปเลือด");

                entity.Property(e => e.CollectionDate).HasComment("วันที่บริจาค");

                entity.Property(e => e.DonorGid).HasComment("ผู้บริจาค");

                entity.Property(e => e.DonorTypeId).HasComment("รับบริจาคมาจาก  1=ภายใน รพ. 2=รพ.ข้างนอก");

                entity.Property(e => e.ExpireDate).HasComment("หมดอายุ");

                entity.Property(e => e.HosiptialName).HasComment("ชื่อโรงพยาบาล (ภายนอก) ที่รับบริจาคมา");

                entity.Property(e => e.IsFinish).HasComment("ใช้เลือดบริจาคแล้ว");

                entity.Property(e => e.OnwerName).HasComment("ชื่อเจ้าของ  (ภายนอก) ที่รับบริจาคมา");

                entity.Property(e => e.ProductCode).HasComment("รหัสชนิด เช่น FFP");

                entity.Property(e => e.ProductName).HasComment("ชื่อชนิด เช่น Fresh frozen plasma");

                entity.Property(e => e.RecordByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Volume).HasComment("ปริมาณบริจาค");
            });

            modelBuilder.Entity<BloodBankRecipient>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CreateByOrgCode });

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasComment("รหัส BloodBankRecipient");

                entity.Property(e => e.AnimalName).HasComment("ชื่อสัตว์ที่ที่รับไป (ภายนอก)");

                entity.Property(e => e.BloodBankDonorId).HasComment("รหัส BloodBank ที่บริจาค");

                entity.Property(e => e.DoctocCode).HasComment("รหัสหมอ");

                entity.Property(e => e.DoctorName).HasComment("ชื่อหมอ (ภายนอก)");

                entity.Property(e => e.DonorGid).HasComment("ผู้บริจาค");

                entity.Property(e => e.HosiptialName).HasComment("ชื่อโรงพยาบาลที่รับไป (ภายนอก)");

                entity.Property(e => e.OnwerName).HasComment("ชื่อเจ้าของที่รับไป(ภายนอก)");

                entity.Property(e => e.RecipientDate).HasComment("วันที่รับบริจาค");

                entity.Property(e => e.RecipientGid).HasComment("รหัสผู้รับบริจาค");

                entity.Property(e => e.RecipientTypeId).HasComment("ให้เลือด 1 = ในรพ. , 2 = นอก รพ.");

                entity.Property(e => e.RecordByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.Remarks).HasComment("หมายเหตุ");

                entity.Property(e => e.Volumn).HasComment("ปริมาณ");
            });

            modelBuilder.Entity<Br>(entity =>
            {
                entity.HasKey(e => new { e.Brno, e.CreateByOrgCode });

                entity.Property(e => e.BillingByName).HasComment("ผู้วางบิล");

                entity.Property(e => e.StaffCode).HasComment("ผู้รับวางบิล");
            });

            modelBuilder.Entity<BranchOrder>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BranchOrderNo });
            });

            modelBuilder.Entity<BranchOrderItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BranchOrderNo, e.SeqId });

                entity.Property(e => e.ToFactionCode).HasComment("รหัสฝ่ายที่เบิกสินค้า (centre II เก็บรหัสแผนก)");
            });

            modelBuilder.Entity<Brby>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Brno, e.SeqId });
            });

            modelBuilder.Entity<Britem>(entity =>
            {
                entity.HasKey(e => new { e.Brno, e.RefNo, e.SeqId });

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างที่อิงที่ใช้วางบิล (RONo/ReturnToVendorNo)");

                entity.Property(e => e.RefDate).HasComment("วันที่ของเอกสารอ้างอิงที่เอามาใช้วางบิล (RODate/ReturnTiVendorDate)");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารที่นำมาใช้วางบิล (1-RO/2=ReturnToVendor)");
            });

            modelBuilder.Entity<CampaignCost>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CampaignCode, e.SeqId });
            });

            modelBuilder.Entity<CampaignCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CampaignCode, e.CustomerGid });
            });

            modelBuilder.Entity<CampaignRevenue>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CampaignCode, e.SeqId });
            });

            modelBuilder.Entity<CaseComplaint>(entity =>
            {
                entity.HasKey(e => new { e.ComplaintId, e.CreateByOrgCode })
                    .HasName("PK_CaseComplain");

                entity.Property(e => e.ComplaintId).ValueGeneratedOnAdd();

                entity.Property(e => e.ComplaintVoteTypeId).HasComment("ไม่ประเมิน =-1, ไม่ระบุ=0, ควรปรับปรุง=1, พอใช้=2, ดี=3, ดีมาก=4");
            });

            modelBuilder.Entity<CertificateVisit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CertificateCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CertificateCode).HasComment("รหัสใบรับรอง");

                entity.Property(e => e.CertificateTypeCode).HasComment("รหัสประเภทใบรับรองแพทย์");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง Record");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทของเอกสาร 1.ใบรับรองแพทย์ 2.ใบส่งตัว");

                entity.Property(e => e.DoctorCode).HasComment("รหัสแพทย์");

                entity.Property(e => e.OfficialCertificateCode).HasComment("เลขที่ใบรับรองแพทย์ราชการ");

                entity.Property(e => e.PrognosisTypeId).HasComment("ประเมินอาการ");

                entity.Property(e => e.ReferRemark1).HasComment("หมายเหตุการส่งตัว 1");

                entity.Property(e => e.ReferRemark2).HasComment("หมายเหตุการส่งตัว 2");

                entity.Property(e => e.ReferRemark3).HasComment("หมายเหตุการส่งตัว 3");

                entity.Property(e => e.ReferRemark4).HasComment("หมายเหตุการส่งตัว 4");

                entity.Property(e => e.ReferRemark5).HasComment("หมายเหตุการส่งตัว 5");

                entity.Property(e => e.ReferRemark6).HasComment("หมายเหตุการส่งตัว 6");

                entity.Property(e => e.Remark1).HasComment("หมายเหตุ 1");

                entity.Property(e => e.Remark2).HasComment("หมายเหตุ 2");

                entity.Property(e => e.Remark3).HasComment("หมายเหตุ 3");

                entity.Property(e => e.RemarkText).HasComment("Remark สำหรับ Vettale");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<ChequeRegister>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ChequeNo, e.BookBankId });

                entity.Property(e => e.BookBankId).HasComment("เป็นเช็คที่ออกจากเลขที่บัญชีไหน");

                entity.Property(e => e.ChequeTypeId).HasComment("รูปแบบเช็ค 1=เช็คจ่าย, 2=เช็ครับ");

                entity.Property(e => e.ReceiverTypeId).HasComment("1-Vendor/ 2-Staff");

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างอิงที่ 1");

                entity.Property(e => e.RefNo2).HasComment("เลขที่อ้างอิงที่ 2 หากเลขที่อ้างอิงที่ 1 ใช้แล้ว ให้มาบันทึกที่นี่");

                entity.Property(e => e.RefTypeId).HasComment("ประเภทเอกสารอ้างอิงที่ 1");

                entity.Property(e => e.RefTypeId2).HasComment("ประเภทเอกสารอ้างอิงที่ 2");
            });

            modelBuilder.Entity<ChequeReturn>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo, e.SeqIdofBankTrans, e.SeqId });

                entity.Property(e => e.DocNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.SeqIdofBankTrans).HasComment("ลำดับรายการ");

                entity.Property(e => e.ReturnDate).HasComment("วันที่เช็ค");
            });

            modelBuilder.Entity<ClearAdvance>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ClearAdvanceNo });
            });

            modelBuilder.Entity<ClearAdvanceBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ClearAdvanceNo, e.SeqId });
            });

            modelBuilder.Entity<ClearAdvanceItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ClearAdvanceNo, e.SeqId });
            });

            modelBuilder.Entity<ClientPaymentDetail>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CreateByOrgCode });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Address).HasComment("ที่อยู่ปัจจุบัน");

                entity.Property(e => e.AmphurName).HasComment("ชื่ออำเภอปัจจุบัน");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.LastName).HasComment("นามสกุล");

                entity.Property(e => e.PostCode).HasComment("รหัสไปรษณีย์ปัจจุบัน");

                entity.Property(e => e.ProvinceName).HasComment("ชื่อจังหวัดปัจจุบัน");

                entity.Property(e => e.TaxId).HasComment("ประจำตัวผู้เสียภาษี");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์ปัจจุบัน");

                entity.Property(e => e.TitleName).HasComment("คำนำหน้าชื่อ");

                entity.Property(e => e.TumbonName).HasComment("ชื่อตำบลปัจจุบัน");
            });

            modelBuilder.Entity<ClientPaymentTransaction>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CreateByOrgCode });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentChannelTypeId).HasComment("ช่องทางการชำระเงิน");
            });

            modelBuilder.Entity<CloseAccount>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.AccountId, e.CreateDate });
            });

            modelBuilder.Entity<CompositeFx>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.CustomerGid, e.CompositeCode });

                entity.Property(e => e.OrganizationCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า แพ้ส่วนประกอบ");

                entity.Property(e => e.CompositeCode).HasComment("รหัสส่วนประกอบ");

                entity.Property(e => e.FxlevelId).HasComment("รหัสระดับการแพ้ 0,Null เตือน,1 ห้ามจ่ายยา");
            });

            modelBuilder.Entity<ConfirmCredit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ConfirmCreditNo });

                entity.Property(e => e.ConfirmCreditNo).HasComment("เลขที่การยืนยันบัตรเครดิต");

                entity.Property(e => e.ChargeAmount).HasComment("ค่าธรรมเนียม");

                entity.Property(e => e.ConfirmCreditDate).HasComment("วันที่ยืนยัน");

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างอิง");

                entity.Property(e => e.RefTypeId).HasComment("ประเภทเอกสารอ้างอิง");

                entity.Property(e => e.VatAmount).HasComment("ภาษีของค่าธรรมเนียม");
            });

            modelBuilder.Entity<ConfirmCreditItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ConfirmCreditNo, e.SeqId });

                entity.Property(e => e.ConfirmCreditNo).HasComment("เลขที่การยืนยันบัตรเครดิต");

                entity.Property(e => e.BookBankId).HasComment("สมุดบัญชีที่จะให้เงินเข้า");

                entity.Property(e => e.ChargeAmount).HasComment("ค่าธรรมเนียม");

                entity.Property(e => e.VatAmount).HasComment("ภาษีของค่าธรรมเนียม");
            });

            modelBuilder.Entity<CostFiFo>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.Vn, e.SeqId, e.SeqIdsales, e.ItemCode });

                entity.Property(e => e.OrganizationCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Vn).HasComment("VN");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.SeqIdsales).HasComment("ลำดับรายการอ้างอิงจาก Sales");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.IsErrorCost).HasComment("หาต้นทุน FIFO ไม่พบ");

                entity.Property(e => e.LotNo).HasComment("Lot อ้างอิงจาก ROItem");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Quantity).HasComment("จำนวน");

                entity.Property(e => e.RoNo).HasComment("เลขที่ใบรับสินค้าเข้า อ้างอิงจาก ROItem");

                entity.Property(e => e.SeqIdro).HasComment("ลำดับรายการอ้างอิงจาก ROItem");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุน/หน่วย");
            });

            modelBuilder.Entity<CounsellorIncentive>(entity =>
            {
                entity.HasKey(e => new { e.SalesNo, e.SeqId, e.ItemCode, e.CounsellorCode, e.IncentiveTypeId })
                    .HasName("PK_Counsellor");

                entity.Property(e => e.SalesNo).HasComment("SalesNo จากตาราง SalesItem");

                entity.Property(e => e.SeqId).HasComment("SeqID ของ SalesItem");

                entity.Property(e => e.CounsellorCode).HasComment("รหัสพนักงานที่เป็นผู้ได้รับค่าตอบแทนตามบรรทัดนี้");

                entity.Property(e => e.IncentiveTypeId).HasComment("สำรหับเก็บว่าเป็นค่าตอบแทนชนิดไหน All,Do,Sell,Consult,DF");

                entity.Property(e => e.IncentiveFromFix).HasComment("ค่าตอบแทนสุทธิ ที่คำนวณจากค่าตอบแทนคงที่ (หน่วยบาท)");

                entity.Property(e => e.IncentiveFromRate).HasComment("ค่าตอบแทนสุทธิ ที่คำนวณจากอัตราค่าตอบแทน(หน่วยบาท)");

                entity.Property(e => e.NetBeforeCal).HasComment("ราคาสุทธิของสินค้าที่นำมาคำนวณ (ถ้าไม่ใช่ส่วนกลางจะเป็นยอดสุทธิหักกับค่าตอบแทนส่วนกลางก่อน)");

                entity.Property(e => e.ReceiveTypeId).HasComment("รูปแบบการรับชำระเงิน 1=รับเงินธรรมดา, 2=รับการจ่ายชำระยอดค้าง");

                entity.Property(e => e.RefSalesItemSeqId).HasComment("ลำดับตามตาราง SalesItem");

                entity.Property(e => e.RefSalesNo).HasComment("เลขที่อ้างอิงใบขาย");

                entity.Property(e => e.Vn).HasComment("VN จากตาราง SalesItem");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CourseNo })
                    .HasName("PK_CourseItem");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CourseNo).HasComment("เลขที่ Course");

                entity.Property(e => e.CancelBy).HasComment("ยกเลิกโดย");

                entity.Property(e => e.CancelReason).HasComment("เหตุผลในการยกเลิก");

                entity.Property(e => e.CoCourseCustomer1).HasComment("ผู้ใช้คอร์สร่วม 1");

                entity.Property(e => e.CoCourseCustomer2).HasComment("ผู้ใช้คอร์สร่วม 2");

                entity.Property(e => e.CoCourseCustomer3).HasComment("ผู้ใช้คอร์สร่วม 3");

                entity.Property(e => e.CoCourseCustomer4).HasComment("ผู้ใช้คอร์สร่วม 4");

                entity.Property(e => e.CoCourseCustomer5).HasComment("ผู้ใช้คอร์สร่วม 5");

                entity.Property(e => e.CourseDate).HasComment("วันที่ซื้อคอร์ส");

                entity.Property(e => e.CourseExpire).HasComment("คอร์สหมดอายุหลังจากสั่งคอร์สหลักกี่วัน");

                entity.Property(e => e.CourseGroupId).HasComment("เลขที่ชุดคอร์ส");

                entity.Property(e => e.CurrentUse).HasComment("จำนวนครั้งปัจจุบัน");

                entity.Property(e => e.CurrentUseQuantity).HasComment("สำหรับคอร์สปริมาณ เก็บว่าทำไปทั้งหมดเท่าไหร่แล้ว");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DiagByCode).HasComment("รหัสผู้ตรวจ");

                entity.Property(e => e.Fxremark).HasComment("เหตุผลที่ยอมขายยา FX");

                entity.Property(e => e.IsCancel).HasComment("ยกเลิกคอร์สหรือไม่");

                entity.Property(e => e.IsComplete).HasComment("ทำครบหรือยัง");

                entity.Property(e => e.IsExpire).HasComment("หมดอายุแล้ว");

                entity.Property(e => e.IsFx).HasComment("เป็นรายการที่ FX");

                entity.Property(e => e.ItemCode).HasComment("รหัสคอร์ส");

                entity.Property(e => e.LastDoDate).HasComment("วันที่ทำล่าสุด");

                entity.Property(e => e.SellByCode).HasComment("รหัสผู้ขาย");

                entity.Property(e => e.TotalCredit).HasComment("จำนวนครั้งทั้งหมดที่ทำได้");

                entity.Property(e => e.TotalQuantity).HasComment("FK มาจาก MItem.QuantityPerCourse, เก็บปริมณทั้งหมดของคอร์สนี้");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<CourseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CourseNo, e.SeqId })
                    .HasName("PK_Course");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CourseNo).HasComment("เลขที่ Course");

                entity.Property(e => e.SeqId).HasComment("ครั้งที่ทำ");

                entity.Property(e => e.CurrentCredit).HasComment("จำนวนครั้งคงเหลือ");

                entity.Property(e => e.CurrentQty).HasComment("จำนวนปริมาณคงเหลือ");

                entity.Property(e => e.CurrentUse).HasComment("จำนวนครั้งที่ใช้ไปแล้ว");

                entity.Property(e => e.CurrentUseQty).HasComment("จำนวนปริมาณที่ใช้ไปแล้ว");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DoByCode).HasComment("รหัสผู้ทำ");

                entity.Property(e => e.DoDate).HasComment("วันที่ทำ");

                entity.Property(e => e.DoTime).HasComment("จำนวนเวลาที่ทำ");

                entity.Property(e => e.FixAssetCode).HasComment("เครื่องมือ");

                entity.Property(e => e.IsCancel).HasComment("ถูกยกเลิกคอร์สหรือไม่");

                entity.Property(e => e.TotalCredit).HasComment("จำนวนครั้งทั้งหมด");

                entity.Property(e => e.TotalQty).HasComment("จำนวนปริมาณทั้งหมด");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<CustomerCaseVisit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.CustomerCaseCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Vn).HasComment("VN");
            });

            modelBuilder.Entity<CustomerHair>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.HairCode });
            });

            modelBuilder.Entity<CustomerMap>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid });
            });

            modelBuilder.Entity<CustomerMemberCard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.CardNumber })
                    .HasName("PK_CustomerMemberCard_1");

                entity.Property(e => e.CreateByOrgCode).IsFixedLength(true);

                entity.Property(e => e.CardNumber).HasComment("หมายเลขบัตร");

                entity.Property(e => e.CardTypeCode).HasComment("รหัสชนิดบัตร");

                entity.Property(e => e.CreditLimit).HasComment("วงเงินทั้งหมด");

                entity.Property(e => e.ExistingCredit).HasComment("วงเงินคงเหลือในบัตร");

                entity.Property(e => e.ExpireDate).HasComment("วันหมดอายุบัตร");

                entity.Property(e => e.InActive).HasComment("ใช้งานได้อยู่หรือไม่ 0 ได้ /1 ไม่ได้");

                entity.Property(e => e.IsExpire).HasComment("วันหมดอายุ");

                entity.Property(e => e.IsUnExpire).HasComment("เป็นบัตรสมาชิกแบบไม่มีวันหมดอายุ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าของบัตรสมาชิก");

                entity.Property(e => e.PinCode).HasComment("รหัสยืนยันตัวตนเจ้าของบัตร");

                entity.Property(e => e.SeqId).HasComment("ลำดับ");

                entity.Property(e => e.SubscriptionDate).HasComment("วันที่สมัครสมาชิก");
            });

            modelBuilder.Entity<CustomerPregnant>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PregnantId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CalGafrom).HasComment("กำหนดรูปแบบคำนวณอายุครรภ์ 1 CalGAFromLMP , 2 CalGAFromEDC");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.Lmpdate).HasComment("วันที่ประจำเดือนมาล่าสุด (เอาไว้คำนวณการตั้งครรภ์)");

                entity.Property(e => e.PregnantTypeId).HasComment("สถานะตั้งครรภ์ 1=ตั้งครรภ์ 2=คลอดแล้ว 3=ยุติการตั้งครรภ์");
            });

            modelBuilder.Entity<CustomerQue>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn });

                entity.Property(e => e.Vn).HasComment("Visit No.");

                entity.Property(e => e.CallQueDate).HasComment("วัน/เวลาที่เรียกคิว (ระบบหน้าจอ)");

                entity.Property(e => e.CallQueStatusId).HasComment("0-ไม่ได้เรียก, 1-ยังไม่ได้ประกาศ, 2-เรียกประกาศแล้ว");

                entity.Property(e => e.CarrierGid).HasComment("ผู้ที่พาสัตว์เลี้ยงมารักษา");

                entity.Property(e => e.CaseTypeCode).HasComment("ประเภทการมาใช้บริการในครั้งนั้นๆ");

                entity.Property(e => e.CaseTypeId).HasComment("สถานะ เช่น 1ทั่วไป, 2 ฉุกเฉิน เป็นต้น");

                entity.Property(e => e.CustomerCode).HasComment("HN คนไข้");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DisplayName).HasComment("ชื่อคนไข้ที่แสดง");

                entity.Property(e => e.EnterQueTime).HasComment("เวลาที่เข้าคิว");

                entity.Property(e => e.ExitQueTime).HasComment("เวลาที่ออกจากคิว");

                entity.Property(e => e.FromQueCode).HasComment("รหัสห้องที่ส่ง");

                entity.Property(e => e.FromQueName).HasComment("ชื่อห้องที่ส่ง");

                entity.Property(e => e.IsFingerPrintScan).HasComment("สแกนลายนิ้วมือแล้ว");

                entity.Property(e => e.IsFinish).HasComment("ยืนยันจากคิวหรือยัง");

                entity.Property(e => e.IsReVn).HasComment("เป็นการเรียก VN กลับมาแก้ไขหรือไม่");

                entity.Property(e => e.IsReceiveMoney).HasComment("รับเงินแล้ว");

                entity.Property(e => e.IsSaveAnimalSickStatistics).HasComment("บันทึกสถิติสัตว์ป่วย (สสป.)");

                entity.Property(e => e.IsSendFollow).HasComment("ส่ง SMS Follow Up หรือยัง");

                entity.Property(e => e.IsSendSms).HasComment("ส่ง SMS ขอบคุณหรือยัง");

                entity.Property(e => e.LockByCode).HasComment("กำลังใช้ข้อมูลโดยใคร");

                entity.Property(e => e.NotifyWaitQueQty).HasComment("จำนวนครั้งที่ถูกส่ง Line ไปเตือนขณะรอคิวนานเกิน (ใช้เช็คกรณีจะส่งซ้ำ)");

                entity.Property(e => e.Pfpid).HasComment("ใช้เก็บค่าในการมาของการจ่ายรวม");

                entity.Property(e => e.QueCode).HasComment("รหัสห้องปัจจุบัน");

                entity.Property(e => e.QueId).HasComment("ลำดับคิวประจำวัน");

                entity.Property(e => e.QueName).HasComment("ชื่อห้องปัจจุบัน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReserveNo).HasComment("เลขที่ใบจอง");

                entity.Property(e => e.ShowColor).HasComment("สี่ที่ใช้แสดงในคิว");

                entity.Property(e => e.VisitDate).HasComment("วันที่มา");

                entity.Property(e => e.WaitingTime).HasComment("จำนวนเวลาที่รอคอย");
            });

            modelBuilder.Entity<CustomerRight>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.Vn, e.RightCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยาน");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");

                entity.Property(e => e.CreditLimit).HasComment("วงเงิน");

                entity.Property(e => e.ExistingCredit).HasComment("วงเงินคงเหลือ");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.HospitalCode).HasComment("รหัสโรงพยาบาลเจ้าของบัตร");

                entity.Property(e => e.IsReverseToHn).HasComment("1=โอนกลับไปเป็นยอดหนี้ของผู้ป่วย");

                entity.Property(e => e.IsUnExpire).HasComment("สิทธิ์ไม่มีกำหนดหมดอายุ");

                entity.Property(e => e.IsUnLimitCredit).HasComment("สิทธิ์ไม่จำกัดวงเงิน");

                entity.Property(e => e.IsUseRight).HasComment("ใช้สิทธิ์");

                entity.Property(e => e.IssueDate).HasComment("?");

                entity.Property(e => e.LimitByVn).HasComment("จำนวนวงเงินใช้ต่อครั้ง");

                entity.Property(e => e.RightAmountPerDay).HasComment("วงเงินที่ใช้ได้ต่อวัน");

                entity.Property(e => e.RightNo).HasComment("เลขที่บัตร");

                entity.Property(e => e.RightStatusId).HasComment("ใช้ ไม่ใช้ ไม่แน่ใจ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");
            });

            modelBuilder.Entity<CustomerRightDocApprove>(entity =>
            {
                entity.HasKey(e => new { e.Vn, e.DocCode, e.OrganizationCode, e.RightCode });

                entity.Property(e => e.Vn).HasComment("VN");

                entity.Property(e => e.OrganizationCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ApprovedStatusId).HasComment("สถานะการอนุมัติเอกสาร");
            });

            modelBuilder.Entity<CustomerRightItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.RightCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยาน");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");

                entity.Property(e => e.CreditLimit).HasComment("วงเงิน");

                entity.Property(e => e.ExistingCredit).HasComment("วงเงินคงเหลือ");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.HospitalCode).HasComment("รหัสโรงพยาบาลเจ้าของบัตร");

                entity.Property(e => e.IsReverseToHn).HasComment("1=โอนกลับไปเป็นยอดหนี้ของผู้ป่วย");

                entity.Property(e => e.IsUnExpire).HasComment("สิทธิ์ไม่มีกำหนดหมดอายุ");

                entity.Property(e => e.IsUnLimitCredit).HasComment("สิทธิ์ไม่จำกัดวงเงิน");

                entity.Property(e => e.IsUseRight).HasComment("ใช้สิทธิ์");

                entity.Property(e => e.IssueDate).HasComment("?");

                entity.Property(e => e.LimitByVn).HasComment("จำนวนวงเงินใช้ต่อครั้ง");

                entity.Property(e => e.RightAmountPerDay).HasComment("วงเงินที่ใช้ได้ต่อวัน");

                entity.Property(e => e.RightNo).HasComment("เลขที่บัตร");

                entity.Property(e => e.RightStatusId).HasComment("ใช้ ไม่ใช้ ไม่แน่ใจ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");
            });

            modelBuilder.Entity<CustomerSideEffect>(entity =>
            {
                entity.HasKey(e => new { e.CompositeCode, e.CustomerGid, e.CreateByOrgCode })
                    .HasName("PK_PatientSideEffect");

                entity.Property(e => e.CompositeCode).HasComment("รหัสส่วนประกอบ");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CompositeTypeId).HasComment("1=ส่วนประกอบ 2=ยา");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.IsSeverity).HasComment("ความรุนแรง 0,null เตือน,1 ห้ามจ่าย");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Severity).HasComment("อาการแพ้/ความรุนแรง");
            });

            modelBuilder.Entity<CustomerSkin>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SkinCode, e.DocId });

                entity.Property(e => e.SkinCode).HasComment("รหัสประเภทผิว");

                entity.Property(e => e.DocId).HasComment("รหัสรูปภาพ");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");
            });

            modelBuilder.Entity<CustomerSkinCondition>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.SkinConditionCode });
            });

            modelBuilder.Entity<CustomerSsp>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.Icd10code).HasComment("รหัสโรค");

                entity.Property(e => e.Icd10typeId).HasComment("รหัสประเภทโรค 1ทั่วไป/ 2ระบาดสัตว์/ 4ติดสู่คน/ 8ป้องกันด้วยวัคซีน");

                entity.Property(e => e.Icd9cmcode).HasComment("รหัสการรักษา");

                entity.Property(e => e.Icd9cmtypeId).HasComment("รูปแบบการรักษา 1อายุรกรรม/ 2ศัลยกรรม");

                entity.Property(e => e.ItemCode).HasComment("เก็บรหัสสินค้าที่เป็นวัคซีนป้องกันโรค");

                entity.Property(e => e.SsptypeId).HasComment("รูปแบบของรายงาน สสป. เก็บ 1,2,...,N ไปตามเลขที่ สสป.");

                entity.Property(e => e.SyndromeGroupCode).HasComment("รหัสกลุ่มอาการ");
            });

            modelBuilder.Entity<CustomerVisit>(entity =>
            {
                entity.HasKey(e => new { e.Vn, e.CreateByOrgCode });

                entity.Property(e => e.Vn).HasComment("vn");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AccidentCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.AccidentDate).HasComment("วันที่เกิดอุบัติเหตุ");

                entity.Property(e => e.AccidentNo).HasComment("เลขที่ประสบอันตรายของผู้ป่วย");

                entity.Property(e => e.AccidentRemark).HasComment("หมายเหตุการเกิดอุบัติเหตุ");

                entity.Property(e => e.AdmitDate).HasComment("วันที่ Admit");

                entity.Property(e => e.AdmitRemark).HasComment("หมายเหตุการ Admit");

                entity.Property(e => e.AdmitStatusCode).HasComment("สถานะการ Admit");

                entity.Property(e => e.AdmitTypeCode).HasComment("ประเภทการ Admit");

                entity.Property(e => e.Advise).HasComment("คำแนะนำ");

                entity.Property(e => e.An).HasComment("an");

                entity.Property(e => e.BedCode).HasComment("รหัสเตียงนอน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง Record");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า ");

                entity.Property(e => e.DischargeDate).HasComment("วันที่ Discharge");

                entity.Property(e => e.DischargeStatusCode).HasComment("สถานะการ Discharge");

                entity.Property(e => e.DischargeTypeCode).HasComment("ประเภทการ Discharge");

                entity.Property(e => e.DoctorByCode).HasComment("รหัสแพทย์");

                entity.Property(e => e.FoodTypeCode).HasComment("รหัสประเภทอาหาร");

                entity.Property(e => e.IsAdmit).HasComment("Admit");

                entity.Property(e => e.IsDischarge).HasComment("เป็นการ Discharge");

                entity.Property(e => e.IsForAdmit).HasComment("สถานะบอกให้ Admit");

                entity.Property(e => e.IsLockExpense).HasComment("Lock ค่าใช้จ่าย");

                entity.Property(e => e.LockExpenseByCode).HasComment("รหัสผู้ Lock Expense");

                entity.Property(e => e.QueId).HasComment("Que");

                entity.Property(e => e.ReasonCode).HasComment("รหัสการออกจากโรงพยาบาล");

                entity.Property(e => e.ReferHospCode).HasComment("รหัสโรงพยาบาล Refer");

                entity.Property(e => e.ReferType).HasComment("ประเภทการ Refer");

                entity.Property(e => e.SpecialInsCode).HasComment("รหัสคำสั่งพิเศษ");

                entity.Property(e => e.SpecifiedDoctorCode).HasComment("รหัสแพทย์");

                entity.Property(e => e.WardCode).HasComment("รหัส Ward");
            });

            modelBuilder.Entity<CustomerVoucherItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.SeqId, e.RunningNo });

                entity.Property(e => e.RunningNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireDate).HasComment("วันหมดอายุของวงเงิน");

                entity.Property(e => e.IsUnExpire).HasComment("ไม่กำหนดวันหมดอายุ");

                entity.Property(e => e.VoucherTypeId).HasComment("รูปแบบการได้รับหรือหักวงเงิน 1. เกิดจากการซื้อบัตรกำนัล 2. เกิดจากการใช้วงเงิน 3. เกิดจากการยกเลิกการใช้วงเงิน");
            });

            modelBuilder.Entity<CustomerWait>(entity =>
            {
                entity.HasKey(e => new { e.WaitId, e.CreateByOrgCode });

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.LockByCode).HasComment("กำลังใช้ข้อมูลโดยใคร");

                entity.Property(e => e.QueCode).HasComment("รหัสห้องปัจจุบัน");

                entity.Property(e => e.QueName).HasComment("ชื่อห้องปัจจุบัน");
            });

            modelBuilder.Entity<CutStock>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CutStockNo });

                entity.Property(e => e.CutStockDate).HasComment("วันที่ตัด");

                entity.Property(e => e.CutStockReasonCode).HasComment("เหตุผลการตัดจ่าย");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<CutStockItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CutStockNo, e.SeqId });
            });

            modelBuilder.Entity<DataAccidentCause>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทอุบัติเหตุ อุบัติเหตุ/ป่วย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ประเภทสาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAccountType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทบัญชีหลัก 5 ประเภท(สินทรัพย์ หนี้สิน ทุน รายได้ คชจ.)");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทบัญชีหลัก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataActionType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataAddressType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทที่อยู่ เช่น ที่อยู่ปัจจุบัน, ที่อยู่ตามทะเบียนบ้าน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ประเภทที่อยู่");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAppFrequency>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสความถี่การตามนัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ความถี่การตามนัด /ทุก 1 วัน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAppInterval>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสความถี่การตามนัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ความถี่การตามนัด /ทุก 1 วัน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAppPurpose>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสจุดประสงในการนัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("จุดประสงในการนัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAppStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะการนัด/มาตามนัด /ยกเลิก ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะการนัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataAppointmentType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.Duration).HasComment("ระยะเวลาห่างของเวลานัด (นาที)");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้นัดหมายนี้ (Izpal999 = ทุกสาขา)");

                entity.Property(e => e.ShowColor).HasComment("เพื่อแสดงแถบสีในนัดหมาย");

                entity.Property(e => e.TeleHeath).HasComment("มีบริการ TeleHeath ไหม");
            });

            modelBuilder.Entity<DataArea>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.DataName).HasComment("ชื่อเขตการขาย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataBank>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.BankTypeId).HasComment("0 =   ธนาคารเช็ค  1 = ธนาคารของกิจการ");

                entity.Property(e => e.IsPromptPay).HasComment("เป็นธนาคารที่ใช้พร้อมเพย์หรือไม่");

                entity.Property(e => e.PromptPayNo).HasComment("เลขที่พร้อมเพย์");
            });

            modelBuilder.Entity<DataBloodGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่มเลือด");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่มเลือด(1)");

                entity.Property(e => e.DataName2).HasComment("ชื่อกลุ่มเลือด(2)");
            });

            modelBuilder.Entity<DataBranchOrderRemark>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataBrand>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataBuilding>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสอาคาร");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่ออาคาร");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataBusinessType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทธุรกิจ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อธุรกิจ");

                entity.Property(e => e.InActive).HasComment("ยกเลิการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCategory>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทข้อเสนอ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทข้อเสนอ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCause>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัส");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCheckUp>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสศาสนา");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อศาสนา");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCheckUpRemark>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CheckupCode, e.DataCode });
            });

            modelBuilder.Entity<DataChieftComplaint>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสอาการเบื้องต้น");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Count).HasComment("เก็บจำนวนที่ถูกใช้ข้อมูลไป");

                entity.Property(e => e.DataName).HasComment("ชื่อคลินิก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCity>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทข้อเสนอ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทข้อเสนอ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataClinic>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสคลินิก");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อคลินิก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataColor>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสความต้องการ");

                entity.Property(e => e.DataName).HasComment("ความต้องการ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCompanyTitleName>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสคำนำหน้านิติบุคคล");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อคำนำหน้านิติบุคคล");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCompanyType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทผู้ติดต่อ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทผู้ติดต่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCompareType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่มย่อยสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่มย่อย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCompetitor>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.DataName).HasComment("ชื่อเขตการขาย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataComplex>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataComposite>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสส่วนประกอบยา");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อส่วนประกอบ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataContactGroup>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่มผู้ติดต่อ /บริษัทประกัน/ผู้จำหน่าย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่มผู้ติดต่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataContactType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทผู้ติดต่อ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทผู้ติดต่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCostCenter>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัส Costcenter");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อ Costcenter");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCountry>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเทศ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเทศ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้ลมูลระบบ");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละประเทศ(ไม่ควรซ้ำกัน)");
            });

            modelBuilder.Entity<DataCouponType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataCreditCardPaymentType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCreditCardSwipe>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสเครื่องรูดบัตรเครดิต");

                entity.Property(e => e.BookBankId).HasComment("เลขที่สมุดเงินฝาก");

                entity.Property(e => e.DataName).HasComment("ชื่อเครื่องรูดบัตรเครดิต");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCreditCardType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCustomerCase>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัส");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCustomerContactType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataCustomerRightDoc>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสเอกสารที่ใช้เป็นหลักฐานส่งเบิก");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อเอกสาร");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCustomerRightStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะการใช้สิทธิ์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อสถานะการใช้สิทธิ์");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataCutStockReason>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.DataName).HasComment("ชื่อเขตการขาย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataDeadCause>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสาเหตุการตาย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สาเหตุการเสียชีวิต");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataDegree>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataDepartment>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสแผนก");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อแผนก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบการใช้งาน");
            });

            modelBuilder.Entity<DataDischargeStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะการ Discharge");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อสถานะการ Discharge");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataDischargeType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทการ Admit");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทการ Admit");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataDoctorNoteTemplate>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DisplayPointTypeId).HasComment("จุดที่จะแสดงข้อมูล Template");

                entity.Property(e => e.Priority).HasComment("ระดับความสำคัญ");
            });

            modelBuilder.Entity<DataDueBack>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataDuration>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataDurationCode })
                    .HasName("PK_DataDulation");
            });

            modelBuilder.Entity<DataEmployeeType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataExpenseType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataFavorite>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสิ่งที่ชอบ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อสิ่งที่ชอบ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataFixAssetStatus>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataFixAssetType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataFollowUpType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.OrganizationCode).HasComment("บันทึกรหัสสาขาเพื่อการแสดงในสาขาที่ต้องการเฉพาะได้ โดย izpal999 คือ ข้อมูลเบื้องต้นในการบันทึก เพื่อแสดงทุกสาขา");

                entity.Property(e => e.ShowColor).HasComment("สีของประเภทการตามนัด");
            });

            modelBuilder.Entity<DataFoodType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทอาหาร");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่ออาหาร");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataForecastType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataGenericName>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode })
                    .HasName("PK_DataGeneric");

                entity.Property(e => e.DataCode).HasComment("รหัสสามัญ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อสามัญ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็น ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataGenericSpecy>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทสัตว์มาตราฐาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทสัตว์มาตราฐาน(ไทย)");

                entity.Property(e => e.DataName2).HasComment("ชื่อประเภทสัตว์มาตราฐาน(อังกฤษ)");

                entity.Property(e => e.Remark1).HasComment("รหัสประเภทสัตว์สำหรับ Lab IDEXX");

                entity.Property(e => e.Remark2).HasComment("รหัสประเภทสัตว์สำหรับ Lab Mindray");

                entity.Property(e => e.Remark3).HasComment("รหัสประเภทสัตว์สำหรับ Lab Exigo");
            });

            modelBuilder.Entity<DataHair>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataHardware>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataHospital>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสโรงพยาบาล");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อโรงพยาบาล");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataIcdtype>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทโรค");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทโรค");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataInOutStatus>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataIncomeLevel>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.DataName).HasComment("ชื่อเขตการขาย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataIncomeType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataIndustry>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataInsuranceCompany>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataItemClassifiedGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataItemClassifiedCode })
                    .HasName("PK_AdvisoryGroup");
            });

            modelBuilder.Entity<DataItemReturn>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสาเหตุการคืนยา");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สาเหตุการคืนยา");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataItemWarn>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสคำเตือน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("คำเตือน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataJournalGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JournalReferenceIndex, e.DocReferenceIndex })
                    .HasName("PK_JournalGroup");

                entity.Property(e => e.CreateByOrgCode).HasComment("Created by organization code");

                entity.Property(e => e.JournalReferenceIndex).HasComment("เลขที่อ้างอิงของบันทึกบัญชี");

                entity.Property(e => e.DocReferenceIndex).HasComment("เลขที่อ้างอิงของเอกสารที่จะผูกกับเลขที่บันทึกบัญชี");

                entity.Property(e => e.CreateByCode).HasComment("Created by code");

                entity.Property(e => e.DocTypeId).HasComment("รหัสประเภทข้อมูล เช่น ลูกค้า สินค้า สินทรัพย์ฐาวร");

                entity.Property(e => e.DocTypeName).HasComment("ชื่อประเภทข้อมูล เช่น ลูกค้า สินค้า สินทรัพย์ฐาวร");

                entity.Property(e => e.ModByCode).HasComment("Modified by code");

                entity.Property(e => e.ModByOrgCode).HasComment("Modified by organization code");

                entity.Property(e => e.ModDate).HasComment("Modified date");

                entity.Property(e => e.ParentOrgCode).HasComment("Parent organization code");
            });

            modelBuilder.Entity<DataKbcategory>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภท X-ray ---> MItem");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภท X-Ray");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบ");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataLabGroup>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataLabMethod>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสหลักวิชาในการทำ Lab");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อหลักวิชาในการทำ Lab");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataLabSpeciman>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SpecimenCode });
            });

            modelBuilder.Entity<DataLanguage>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode })
                    .HasName("PK_MLanguage");
            });

            modelBuilder.Entity<DataLocation>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataMaritalStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะภาพการสมรส");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อสถานะภาพการสมรส");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataMediaSource>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทอุบัติเหตุ อุบัติเหตุ/ป่วย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ประเภทสาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataMessageType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทข้อความ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภท");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataNation>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละสัญชาติ(ไม่ควรซ้ำกัน)");
            });

            modelBuilder.Entity<DataOccupation>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสอาชีพ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่ออาชีพ");

                entity.Property(e => e.DataName2).HasComment("อาชีพภาษาอังกฤษ");
            });

            modelBuilder.Entity<DataOnset>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataOnsetCode })
                    .HasName("PK_DataOnStep");
            });

            modelBuilder.Entity<DataOperate>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataOperateActing>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสทำหน้าที่ในการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("หน้าที่ในการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataOperateCause>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสาเหตุการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สาเหตุการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataOperateMethod>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสวิธีการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("วิธีการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataOperateProblem>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสปัญหาในการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ปัญหาในการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataOperateResult>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสผลการผ่าตัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ผลการผ่าตัด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataPosition>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataPriceLevel>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อเชื้อชาติ/สัญชาติ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละระดับราคา(ไม่ควรซ้ำกัน)");
            });

            modelBuilder.Entity<DataProcessStage>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะความรุ่นแรง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะความรุนแรง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataProcessStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะความรุ่นแรง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะความรุนแรง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataQueStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะการรอคิว");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะการรอคิว");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataQuestionGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataRace>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Created by organization code");

                entity.Property(e => e.DataCode).HasComment("Race code");

                entity.Property(e => e.CreateByCode).HasComment("Created by code");

                entity.Property(e => e.DataName).HasComment("Race");

                entity.Property(e => e.DataName2).HasComment("Race 2");

                entity.Property(e => e.ModByCode).HasComment("Modified by code");

                entity.Property(e => e.ModByOrgCode).HasComment("Modified by organization code");

                entity.Property(e => e.ModDate).HasComment("Modified date");

                entity.Property(e => e.ParentOrgCode).HasComment("Parent organization code");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละเชื้อชาติ(ไม่ควรซ้ำกัน)");
            });

            modelBuilder.Entity<DataReason>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสการออกจากโรงพยาบาล OPD/IPD");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("เหตุที่ออกจากโรงพยาบาล");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReceiptGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ReceiptGroupTypeId).HasComment("รหัสประเภทใบเสร็จ 1-ไม่แสดง, 2-นับตามรายการสินค้า, 3-นับตามจำนวนหน่วยสินค้า");
            });

            modelBuilder.Entity<DataRecurringGroup>(entity =>
            {
                entity.HasKey(e => new { e.RecurringGroupCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataReferInType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัส ReferIn");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReferLocation>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode, e.ReferInTypeCode, e.ReferOutTypeCode });

                entity.Property(e => e.DataCode).HasComment("รหัส ReferIn");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ReferInTypeCode).HasComment("ประเภทการมารักษา");

                entity.Property(e => e.ReferOutTypeCode).HasComment("ประเภทการปล่อย");

                entity.Property(e => e.DataName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ReferTypeId).HasComment("ประเภท Refer");
            });

            modelBuilder.Entity<DataRegarding>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะความรุ่นแรง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะความรุนแรง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReligion>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสศาสนา");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อศาสนา");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRemark>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสหลักวิชาในการทำ Lab");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อหลักวิชาในการทำ Lab");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRepeatedFilm>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสการทำฟิลมซ้ำ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อการทำฟิลมซ้ำ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReportGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReportSubGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataReqPriority>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสความต้องการ");

                entity.Property(e => e.DataName).HasComment("ความต้องการ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestCategory>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestPriority>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสความเร่งด่วน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ความเร่งด่วน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestProcess>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestSeverity>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode })
                    .HasName("PK_DataSeverity");

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะความรุ่นแรง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะความรุนแรง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestStatus>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRequestType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่ม Request");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่ม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRoad>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสถนน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อถนนน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRoomStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสถานะห้องไม่ว่าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สถานะห้องไม่ว่าง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataRoundupName>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataScreen>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัส Screen");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อ Screen");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataShape>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสความต้องการ");

                entity.Property(e => e.DataName).HasComment("ความต้องการ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataSkill>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataSkillLevel>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสหลักวิชาในการทำ Lab");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อหลักวิชาในการทำ Lab");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataSkin>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสพันธุ์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อพันธุ์");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataSkinCondition>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสพันธุ์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อพันธุ์");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataSoftware>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataSource>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataSpecialInstruction>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสคำสั่งพิเศษ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("คำสั่งพิเศษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมุลระบบ");
            });

            modelBuilder.Entity<DataSsoservice>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataStaffLevel>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataStaffRightGroup>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทอุบัติเหตุ อุบัติเหตุ/ป่วย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ประเภทสาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataStaffSection>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataStaffType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataStage>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataState>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทข้อเสนอ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทข้อเสนอ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataSubItemGroup>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode })
                    .HasName("PK_DataSubItemGroup_1");
            });

            modelBuilder.Entity<DataSurgeryGroup>(entity =>
            {
                entity.HasKey(e => new { e.SurgeryGroupCode, e.CreateByOrgCode })
                    .HasName("PK_dbo.DataSurgeryGroup");

                entity.Property(e => e.SurgeryGroupCode).HasComment("รหัสหมวดผ่าตัด");

                entity.Property(e => e.SurgeryGroupName).HasComment("ชื่อหมวดผ่าตัด");

                entity.Property(e => e.SurgeryGroupName2).HasComment("รหัสหมวดผ่าตัด2");
            });

            modelBuilder.Entity<DataSymptomGroup>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสกลุ่มบ่งชี้อาการ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อกลุ่มบ่งชี้อาการ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataTaxForm>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทแบบฟอร์มภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทแบบฟอร์มภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataTransportType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสวิธีส่งสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("วิธีส่งสินค้า");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataUnit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataVatBasisType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataCode).HasComment("รหัสอุบัติเหตุ");

                entity.Property(e => e.DataName).HasComment("สาเหตุอุบัติเหตุ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataVendorType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภทผู้จำหน่าย");

                entity.Property(e => e.CreateByOrgCode).HasComment("ีรหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภทผู้จำหน่าย");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataVisitPurpose>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสการมา");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อการมา");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataWard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WardCode });

                entity.Property(e => e.OrganizationCode).HasComment("สาขาของหอสัตว์ป่วยนี้");

                entity.Property(e => e.WardTypeId).HasComment("1=ฝากรักษา 2=ฝากเลี้ยง");
            });

            modelBuilder.Entity<DataWarrantyStatus>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DataWithholdingDocFormat>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DataCode });
            });

            modelBuilder.Entity<DataWounded>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสอาการบาดเจ็บ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("อาการบาดเจ็บ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<DataXrayPosition>(entity =>
            {
                entity.HasKey(e => new { e.XrayTypeCode, e.XrayPositionCode, e.CreateByOrgCode });

                entity.Property(e => e.XrayPositionCode).HasComment("รหัสประเภท X-ray ---> MItem");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบ");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.XrayAbbr).HasComment("ชื่อย่อ");

                entity.Property(e => e.XrayPositionName).HasComment("ชื่อประเภท X-Ray");
            });

            modelBuilder.Entity<DataXrayRepeated>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสสาเหตุการทำ X-ray ซ้ำ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("สาเหตุการทำ X-ray ซ้ำ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DataXrayType>(entity =>
            {
                entity.HasKey(e => new { e.DataCode, e.CreateByOrgCode });

                entity.Property(e => e.DataCode).HasComment("รหัสประเภท X-ray ---> MItem");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DataName).HasComment("ชื่อประเภท X-Ray");

                entity.Property(e => e.InActive).HasComment("ยกเลิกระบบ");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<DebtDeduction>(entity =>
            {
                entity.HasKey(e => new { e.DebtNo, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DebtDeductionItem>(entity =>
            {
                entity.HasKey(e => new { e.DebtNo, e.CreateByOrgCode, e.SeqId });
            });

            modelBuilder.Entity<DeliveryOrder>(entity =>
            {
                entity.HasKey(e => new { e.Dono, e.CreateByOrgCode });
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DepositNo })
                    .HasName("PK_Earnest");

                entity.Property(e => e.DepositNo).HasComment("เลขที่ใบรับมัดจำ");

                entity.Property(e => e.BankBranchCode).HasComment("รหัสสาขาธนาคาร");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคาร");

                entity.Property(e => e.CashAmount).HasComment("จำนวนเงินสด");

                entity.Property(e => e.ChequeAmount).HasComment("จำนวนเงินเช็ค");

                entity.Property(e => e.ChequeDate).HasComment("วันที่เช็ค");

                entity.Property(e => e.ChequeNo).HasComment("เลขที่เช็ค");

                entity.Property(e => e.CustomerCode).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DepositDate).HasComment("วันที่รับ");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินหลังหัก/รวมภาษี");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("อธิบายรายการ");

                entity.Property(e => e.SaleCode).HasComment("รหัสพนักงานขาย");

                entity.Property(e => e.TaxAmount).HasComment("ภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");

                entity.Property(e => e.VatRate).HasComment("อัคราภาษี");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษี");
            });

            modelBuilder.Entity<DeviceRegister>(entity =>
            {
                entity.HasKey(e => new { e.DeviceIdentifier, e.ProgramTypeId });

                entity.Property(e => e.StatusId).HasComment("0-รออนุมัติ/ 1-อนุมัติ/ 2-ไม่อนุมัติ/ 3-ยกเลิกอนุมัติ");
            });

            modelBuilder.Entity<DocAnnotation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AnnotationId });
            });

            modelBuilder.Entity<DocAnnotationItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AnnotationId, e.SeqId });
            });

            modelBuilder.Entity<DocAnnotationItemSite>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AnnotationId, e.SeqId, e.InjectionSiteNo });

                entity.Property(e => e.AnnotationId).HasComment("ID ของรูปต้นแบบของคนไข้");

                entity.Property(e => e.SeqId).HasComment("ครั้งที่ของรูป");

                entity.Property(e => e.InjectionSiteNo).HasComment("เลขที่ตำแหน่งสำหรับฉีด");

                entity.Property(e => e.Qty).HasComment("ปริมาณที่ฉีด");

                entity.Property(e => e.TemplateCode).HasComment("รหัสรูปต้นแบบ");
            });

            modelBuilder.Entity<DocApprove>(entity =>
            {
                entity.HasKey(e => new { e.DocNo, e.DocTypeId, e.ApproveByCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<DocApproveLevel>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocTypeId, e.SeqId });
            });

            modelBuilder.Entity<DocItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocId })
                    .HasName("PK_CustomerDocument");

                entity.Property(e => e.BackgroundDocImage).HasComment("รูป Background ของ Ink");

                entity.Property(e => e.CompareTypeCode).HasComment("รหัสการเปรีียบเทียบ");

                entity.Property(e => e.ContentType).HasComment("เก็บประเภทรูปแบบของรูป : IMG-Lab=ประเภทLab , IMG-XRay=ประเภทXRay , IMG-Gen=ประเภททั่วไป, RPT-Ext=รายงานพิเศษ");

                entity.Property(e => e.DocDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.DocFormId).HasComment("ใช้กำหนดเลขของประเภทเอกสาร 101 บัตรนัด , 103 ฉลากยา");

                entity.Property(e => e.DocInk).HasComment("Full path[Centre 2]");

                entity.Property(e => e.DocInkThumbnail).HasComment("Full path Thumbnail");

                entity.Property(e => e.DocTypeCode).HasComment("ประเภทเอกสาร (นามสกุล)");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทของไฟล์ 1=รูป , 2=Devexpress, 3=PDF");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้คลังนี้");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงความสำคัญ");

                entity.Property(e => e.PublicShareLink).HasComment("ลิงก์สาธารณะไว้แชร์ให้คนภายนอก");

                entity.Property(e => e.RefNo).HasComment("ใช้บันทึกเลขที่เอกสารอ้างอิง");
            });

            modelBuilder.Entity<Draw>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DrawNo });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DrawNo).HasComment("เลขที่ใบขอเบิกสินค้า");

                entity.Property(e => e.CancelByCode).HasComment("ผู้ที่ยกเลิกเอกสาร");

                entity.Property(e => e.CancelDate).HasComment("วันที่ยกเลิกเอกสาร");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DrawDate).HasComment("วันที่เบิก");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสผู้เบิก");

                entity.Property(e => e.Whcode).HasComment("รหัสคลังที่ขอเบิก");
            });

            modelBuilder.Entity<DrawItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DrawNo, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DrawNo).HasComment("เลขที่ใบขอเบิก");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.Quantity).HasComment("จำนวนเบิก");

                entity.Property(e => e.UnitCost).HasComment("ราคาทุน/หน่วย");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");
            });

            modelBuilder.Entity<Dtproperty>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property })
                    .HasName("pk_dtproperties");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Property).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeAdvance>(entity =>
            {
                entity.HasKey(e => new { e.ParentOrgCode, e.EmployeeAdvanceNo });
            });

            modelBuilder.Entity<EmployeeAdvanceBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EmployeeAdvanceNo, e.SeqId });
            });

            modelBuilder.Entity<EmployeeAdvanceItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EmployeeAdvanceNo, e.SeqId });
            });

            modelBuilder.Entity<EvaluateExhibitionItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EvaluateNo, e.SeqId });
            });

            modelBuilder.Entity<EvaluateMeetingItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EvaluateNo, e.SeqId });
            });

            modelBuilder.Entity<EvaluateTraining>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EvaluateNo })
                    .HasName("PK_EvaluateTraining_1");
            });

            modelBuilder.Entity<EvaluateTrainingItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EvaluateNo, e.SeqId });
            });

            modelBuilder.Entity<ExchangeJob>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExchangeJobId, e.SendToOrgCode, e.IsRemote });
            });

            modelBuilder.Entity<ExchangeSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExchangeScheduleId });

                entity.Property(e => e.ExchangeScheduleId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ExchangeTemplate)
                    .WithOne(p => p.ExchangeSchedule)
                    .HasForeignKey<ExchangeSchedule>(d => new { d.CreateByOrgCode, d.TemplateCode })
                    .HasConstraintName("FK_ExchangeSchedule_ExchangeTemplate");
            });

            modelBuilder.Entity<ExchangeScheduleBranch>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExchangeScheduleId });

                entity.HasOne(d => d.ExchangeSchedule)
                    .WithOne(p => p.ExchangeScheduleBranch)
                    .HasForeignKey<ExchangeScheduleBranch>(d => new { d.CreateByOrgCode, d.ExchangeScheduleId })
                    .HasConstraintName("FK_ExchangeScheduleBranch_ExchangeSchedule");
            });

            modelBuilder.Entity<ExchangeTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode });
            });

            modelBuilder.Entity<ExchangeTemplateItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode, e.SeqId });

                entity.HasOne(d => d.ExchangeTemplate)
                    .WithMany(p => p.ExchangeTemplateItems)
                    .HasForeignKey(d => new { d.CreateByOrgCode, d.TemplateCode })
                    .HasConstraintName("FK_ExchangeTemplateItem_ExchangeTemplate");
            });

            modelBuilder.Entity<ExhibitionExpense>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExhibitionCode, e.SeqId });

                entity.Property(e => e.ExpenseAmount).HasComment("จำนวนเงิน");

                entity.Property(e => e.ExpenseName).HasComment("ค่าใช้จ่าย");
            });

            modelBuilder.Entity<ExhibitionJoin>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExhibitionCode, e.SeqId });
            });

            modelBuilder.Entity<ExhibitionSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExhibitionCode, e.SeqId });

                entity.Property(e => e.ExhibitionByName).HasComment("วิทยากร");

                entity.Property(e => e.ExhibitionDate).HasComment("วันที่ดูงาน");

                entity.Property(e => e.FromTime).HasComment("ตั้งแต่เวลา");

                entity.Property(e => e.ToTime).HasComment("ถึงเวลา");

                entity.Property(e => e.Topic).HasComment("เรื่องที่ดูงาน");
            });

            modelBuilder.Entity<ExhibitionStaff>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExhibitionCode, e.SeqId });
            });

            modelBuilder.Entity<Expenditure>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenditureNo });

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (centre II เก็บรหัสสาขา)");

                entity.Property(e => e.ExpenditureTypeId).HasComment("ประเภทการบันทึก 1-ค่าใช้จ่าย, 2-เงินสดย่อย, 3-เงินทดรองจ่าย");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.PeriodId).HasComment("Clinic/Vetสำหรับเก็บงวดบัญชีที่อนุมัติค่าใช้จ่าย, CentreII สำหรับเก็บงวดบัญชีที่บันทึกค่าใช้จ่าย");

                entity.Property(e => e.RecurringGroupNo).HasComment("เลขที่ชุดใบบันทึกเอกสารล่วงหน้า");

                entity.Property(e => e.RecurringNo).HasComment("เลขที่ใบบันทึกเอกสารล่วงหน้า");
            });

            modelBuilder.Entity<ExpenditureItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenditureNo, e.SeqId });

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.PoseqId).HasComment("เก็บ SeqID ที่รับค่าใช้จ่ายอ้างอิงจาก PO");

                entity.Property(e => e.SaveDate).HasComment("วันที่ใช้จ่ายเงินสดย่อย (ใช้เฉพาะกรณี PCPay)");

                entity.Property(e => e.StaffCode).HasComment("รหัสผู้ขอใช้เงินสดย่อยของรายการนี้ (ใช้เฉพาะเงินสดย่อย Izpal Centre II)");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenseId });
            });

            modelBuilder.Entity<ExpenseEntry>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenseEntryNo });

                entity.Property(e => e.ExpenseEntryNo).HasComment("เลขที่ใบลงรายการค่าใช้จ่ายประจำวัน");

                entity.Property(e => e.ExpenseEntryDate).HasComment("วันที่ลงรายการค่าใช้จ่ายประจำวัน");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารที่ใช้อ้างอิงกัน 1-RO/ 2-RTV");

                entity.Property(e => e.Remark).HasComment("หมายเหตุของใบลงรายการค่าใช้จ่ายประจำวัน");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานผู้ทำการลงรายการค่าใช้จ่ายประจำวัน");

                entity.Property(e => e.TotalExpenseAmount).HasComment("ยอดรวมค่าใช้จ่ายของใบลงรายการค่าใช้จ่ายประจำวันเลขที่นั้นๆ");
            });

            modelBuilder.Entity<ExpenseEntryItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenseEntryNo, e.SeqId });

                entity.Property(e => e.ExpenseEntryNo).HasComment("เลขที่ใบลงรายการค่าใช้จ่ายประจำวัน");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการค่าใช้จ่ายของใบลงรายการค่าใช้จ่ายประจำวันนั้นๆ");

                entity.Property(e => e.ExpenseAmount).HasComment("ยอดเงินค่าใช้จ่ายของรายการค่าใช้จ่ายนั้นๆ");

                entity.Property(e => e.ExpenseTypeCode).HasComment("รหัสประเภทค่าใช้จ่าย");
            });

            modelBuilder.Entity<Fdareport>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.FdareportId });

                entity.Property(e => e.CurrentQty).HasComment("สาเหตุที่เป็น nvarchar(50) เพราะ บางค่าจะใส่ \"N/A\"");

                entity.Property(e => e.RecordTypeId).HasComment("1=ยกมา, 2=จาก อย 3 = จ่ายให้คนไข้");

                entity.Property(e => e.ReportSeqId).HasComment("ลำดับในรายงานหลัง Balance");

                entity.Property(e => e.SalesQty1).HasComment("ยอดขายเดือน 1");

                entity.Property(e => e.SalesQty2).HasComment("ยอดขายเดือน 2");

                entity.Property(e => e.SalesQty3).HasComment("ยอดขายเดือน 3");

                entity.Property(e => e.SalesQty4).HasComment("ยอดขายเดือน 4");

                entity.Property(e => e.UnitCost).HasComment("ราคาต้นทุน");

                entity.Property(e => e.VisitAmount).HasComment("จำนวน Visit");
            });

            modelBuilder.Entity<ForecastExpense>(entity =>
            {
                entity.HasKey(e => new { e.ForecastId, e.CreateByOrgCode });

                entity.Property(e => e.ForecastId).HasComment("เลขที่การบันทึกค่าใช้จ่ายอื่นๆ");

                entity.Property(e => e.BookBankId).HasComment("เลขที่สมุดบัญชีเงินฝาก");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (Centre II เก็บรหัสสาขา)");

                entity.Property(e => e.Description).HasComment("รายละเอียดค่าใช้จ่าย");

                entity.Property(e => e.DueDate).HasComment("กำหนดจ่ายชำระ");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (Centre II เก็บรหัสแผนก)");

                entity.Property(e => e.NetAmount).HasComment("ยอดเงิน");

                entity.Property(e => e.StatusId).HasComment("สถานะการจ่าย");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.VendorName).HasComment("ชื่อผู้จำหน่าย");
            });

            modelBuilder.Entity<GroomingVisit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.SeqId).HasComment("ลำดับการอาบน้ำตัดขน");

                entity.Property(e => e.GroomingByCode).HasComment("รหัสช่าง");

                entity.Property(e => e.GroomingDate).HasComment("วันที่อาบน้ำตัดขน");

                entity.Property(e => e.GroomingFinishDate).HasComment("วันที่เสร็จสิ้นอาบน้ำตัดขน");

                entity.Property(e => e.GroomingFinishTime).HasComment("เวลาที่เสร็จสิ้นอาบน้ำตัดขน");

                entity.Property(e => e.GroomingTime).HasComment("เวลาที่อาบน้ำตัดขน");

                entity.Property(e => e.GroomningTypeId).HasComment("สถานะการอาบน้ำตัดขน");

                entity.Property(e => e.ModByOrgCode).IsFixedLength(true);

                entity.Property(e => e.ParentOrgCode).IsFixedLength(true);

                entity.Property(e => e.RemarkGrooming).HasComment("บันทึกการอาบน้ำตัดขน");
            });

            modelBuilder.Entity<HomeCare>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn });

                entity.Property(e => e.AdmitTypeId).HasComment("ประเภทการเข้าพัก 100=ปกติ, 200=ส่งต่อจาก (สำหรับ Vettale)");

                entity.Property(e => e.CauseCode).HasComment("รหัสสาเหตุการ ReferOut");

                entity.Property(e => e.DischargeByCode).HasComment("แพทย์ผู้ Discharge");

                entity.Property(e => e.DischargeStatusCode).HasComment("สถานะการ Discharge");

                entity.Property(e => e.DischargeTypeId).HasComment("ประเภทการปล่อย 100=ปกติ, 200=ส่งไปที่, 300= เสียชีวิต (สำหรับ Vettale)");

                entity.Property(e => e.FoodTypeCode).HasComment("ประเภทอาหาร");

                entity.Property(e => e.FoodTypeNote).HasComment("รายละเอียดประเภทอาหาร");

                entity.Property(e => e.ForwardSymptoms).HasComment("บันทึกการส่งเวร");

                entity.Property(e => e.IsAdmit).HasComment("ทำการ Admint แล้ว");

                entity.Property(e => e.IsDischarge).HasComment("ทำการ Discharge แล้ว");

                entity.Property(e => e.PatientStuff).HasComment("ของใช้ติดตัว");

                entity.Property(e => e.PrognosisTypeId).HasComment("ประเมินอาการ");

                entity.Property(e => e.RecordByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.ReferInFromLocation).HasComment("สถานที่ที่ถูกส่งมา (สำหรับ Vettale)");

                entity.Property(e => e.ReferOutToLocation).HasComment("สถานที่ที่ถูกส่งไป (สำหรับ Vettale)");

                entity.Property(e => e.ReleaseByCode).HasComment("ผู้ดำเนินการปล่อย");
            });

            modelBuilder.Entity<HomeCareProgressNote>(entity =>
            {
                entity.HasKey(e => new { e.HomeCareProgressId, e.CreateByOrgCode });

                entity.Property(e => e.HomeCareProgressId).ValueGeneratedOnAdd();

                entity.Property(e => e.Assistant).HasComment("ผูู้ช่วยแพทย์ 1");

                entity.Property(e => e.Assistant2).HasComment("ผูู้ช่วยแพทย์ 2");

                entity.Property(e => e.AuditByCode).HasComment("ผู้ตรวจสอบ");

                entity.Property(e => e.BpressureHigh).HasComment("ความดันโลหิต (สูง)");

                entity.Property(e => e.BpressureLow).HasComment("ความดันโลหิิต (ต่ำ)");

                entity.Property(e => e.ContactTypeId).HasComment("ช่องทางการติดต่อ 1=โทรศัพท์, 2=Social, 3= TeleHealth");

                entity.Property(e => e.Crt).HasComment("ข้อมูล VET");

                entity.Property(e => e.Fecal).HasComment("อุจจาระ");

                entity.Property(e => e.Fluid).HasComment("สารน้ำ");

                entity.Property(e => e.Food).HasComment("อาหารที่ให้ (ยี่ห้อ,ชนิด)");

                entity.Property(e => e.Ga).HasComment("GA");

                entity.Property(e => e.Height).HasComment("ส่วนสูง");

                entity.Property(e => e.Hs).HasComment("เสียงหัวใจ");

                entity.Property(e => e.Hydration).HasComment("ข้อมูล VET");

                entity.Property(e => e.Intake).HasComment("สารน้ำเข้า (CC)");

                entity.Property(e => e.Ls).HasComment("เสียงการหายใจ");

                entity.Property(e => e.Mentation).HasComment("สภาวะทางอารมณ์ของสัตว์");

                entity.Property(e => e.MucousMembrane).HasComment("ข้อมูล VET");

                entity.Property(e => e.NoteByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.O2sat).HasComment("เก็บค่าออกซิเจนในเลือด");

                entity.Property(e => e.Output).HasComment("สารน้ำออก (CC)");

                entity.Property(e => e.P).HasComment("อัตราการหายใจ");

                entity.Property(e => e.PainScore).HasComment("ค่าความเจ็บปวด");

                entity.Property(e => e.Posture).HasComment("ท่าทางของสัตว์ เช่น เดินเซ ตัวสั่น");

                entity.Property(e => e.ProgressRound).HasComment("รอบการบันทึก รอบเช้า=1 , รอบบ่าย=2");

                entity.Property(e => e.R).HasComment("อัตราการเต้นของชีพจร");

                entity.Property(e => e.Rate).HasComment("อัตรา");

                entity.Property(e => e.SeqId).HasComment("ลำดับของรอบภายในแต่ละ VN");

                entity.Property(e => e.TemperatureF).HasComment("อุณหภูมิฟาเรนไฮน์");

                entity.Property(e => e.TriageTypeId).HasComment("การประเมิน 1=เขียว, 2=เหลือง, 3=แดง");

                entity.Property(e => e.Urine).HasComment("ปัสสาวะ");

                entity.Property(e => e.Vomit).HasComment("อาเจียน");

                entity.Property(e => e.Water).HasComment("น้ำที่ให้ (ยี่ห้อ,ชนิด)");

                entity.Property(e => e.Weight).HasComment("น้ำหนัก");
            });

            modelBuilder.Entity<Icd10visit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Vn).HasComment("VN");

                entity.Property(e => e.AccidentNo).HasComment("?");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CreditUse).HasComment("?");

                entity.Property(e => e.Icdcode).HasComment("รหัส ICD10");

                entity.Property(e => e.Icdname).HasComment("ชื่อ ICD10");

                entity.Property(e => e.IcdtypeCode).HasComment("รหัสประเภทโรคหลัก");

                entity.Property(e => e.IcdtypeSubCode).HasComment("รหัสประเภทโรครอง");

                entity.Property(e => e.TreatmentTypeId).HasComment("1=OPD, 2=IPD");
            });

            modelBuilder.Entity<Icd9cmvisit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.Vn })
                    .HasName("PK_PatientICD9");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Vn).HasComment("VN");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DiagByCode).HasComment("รหัสแพทย์ผู้สั่ง ICD9");

                entity.Property(e => e.DiagDate).HasComment("วันที่สั่ง ICD9");

                entity.Property(e => e.Icdcode).HasComment("รหัส ICD9");

                entity.Property(e => e.Icdname).HasComment("ชื่อ  ICD9");

                entity.Property(e => e.IcdtypeCode).HasComment("รหัสประเภทโรคหลัก");

                entity.Property(e => e.IcdtypeId).HasComment("รูปแบบการรักษา 1-อายุกรรม/ 2-ศัลยกรรม");

                entity.Property(e => e.IcdtypeSubCode).HasComment("รหัสประเภทโรครอง");

                entity.Property(e => e.TreatmentTypeId).HasComment("1=OPD, 2=IPD");
            });

            modelBuilder.Entity<Icd9test>(entity =>
            {
                entity.Property(e => e.CreateByOrgCode).IsFixedLength(true);
            });

            modelBuilder.Entity<InOut>(entity =>
            {
                entity.HasKey(e => new { e.InoutId, e.CreateByOrgCode });

                entity.Property(e => e.DateIn).HasComment("วันที่เข้า");

                entity.Property(e => e.DateOut).HasComment("วันที่ออก");

                entity.Property(e => e.IsEarly).HasComment("ออกก่อนหรือไม่");

                entity.Property(e => e.IsLate).HasComment("เข้าสายหรือไม่");

                entity.Property(e => e.IsManualIn).HasComment("เข้าแบบ Manual");

                entity.Property(e => e.IsManualOut).HasComment("ออกแบบ Manual");

                entity.Property(e => e.IsModify).HasComment("มีการแก้ไขข้อมูลการเข้าออก");

                entity.Property(e => e.IsProcess).HasComment("คำนวณการขาดลามาสายแล้ว");

                entity.Property(e => e.IsSendSmsin).HasComment("ส่ง SMS เมื่อเข้าแล้ว");

                entity.Property(e => e.IsSendSmsout).HasComment("ส่ง SMS เมื่อออกแล้ว");

                entity.Property(e => e.IsTimeIn).HasComment("ลงเวลาเข้าแล้ว");

                entity.Property(e => e.IsTimeOut).HasComment("ลงเวลาออกแล้ว");

                entity.Property(e => e.ModifyReason).HasComment("เหตุุผลที่แก้ไข");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่ในวัน");

                entity.Property(e => e.ShiftCode).HasComment("รหัสกะ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.TimeIn).HasComment("เวลาเข้า");

                entity.Property(e => e.TimeOut).HasComment("เวลาออก");

                entity.Property(e => e.TotalMinutesBreak).HasComment("เวลาพักจากครั้งที่แล้ว");

                entity.Property(e => e.TotalMinutesEarly).HasComment("จำนวนนาทีที่ออกก่อน");

                entity.Property(e => e.TotalMinutesLate).HasComment("จำนวนนาทีที่สาย");

                entity.Property(e => e.TotalMinutesOt1).HasComment("จำนวน OT ก่อนทำงาน");

                entity.Property(e => e.TotalMinutesOt2).HasComment("จำนวน OT หลังทำงาน");

                entity.Property(e => e.TotalMinutesWork).HasComment("เวลาทำงานทั้งหมดเป็นนาที");
            });

            modelBuilder.Entity<InOutExport>(entity =>
            {
                entity.HasKey(e => new { e.ExportCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<InOutExportItem>(entity =>
            {
                entity.HasKey(e => new { e.ExportCode, e.SeqId, e.CreateByOrgCode });
            });

            modelBuilder.Entity<InOutSummary>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.PeriodNo, e.PeriodYear });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.PeriodNo).HasComment("งวด");

                entity.Property(e => e.PeriodYear).HasComment("ปี");

                entity.Property(e => e.AbsentHours).HasComment("จำนวนชั่วโมงที่พนักงานขาดงานในงวดนั้นๆ");

                entity.Property(e => e.LateMinute).HasComment("จำนวนนาทีที่พนักงานมาสายในงวดนั้นๆ");

                entity.Property(e => e.LeaveHours).HasComment("จำนวนชั่วโมงที่พนักงานลา(ไม่หักเงิน)ในงวดนั้นๆ");

                entity.Property(e => e.LeaveHoursDeduct).HasComment("จำนวนชั่วโมงที่พนักงานลา(หักเงิน)ในงวดนั้นๆ");

                entity.Property(e => e.OtholidayHours).HasComment("จำนวนชั่วโมงที่พนักงานมาOTในวันหยุด(เกินจากจำนวนชั่วโมงการทำงานปกติต่อวัน)ของงวดนั้นๆ");

                entity.Property(e => e.OtofficialHolidayHours).HasComment("จำนวนชั่วโมงที่พนักงานมาOTในวันหยุดนักขัตฤกษ์(เกินจากจำนวนชั่วโมงการทำงานปกติต่อวัน)ของงวดนั้นๆ");

                entity.Property(e => e.OtworkDayHours).HasComment("จำนวนชั่วโมงที่พนักงานทำOTในวันทำงานของงวดนั้นๆ");

                entity.Property(e => e.WorkHolidayHours).HasComment("จำนวนชั่วโมงที่พนักงานมาทำงานในวันหยุดของงวดนั้นๆ");

                entity.Property(e => e.WorkHours).HasComment("จำนวนชั่วโมงที่พนักงานทำงานในงวดนั้นๆ");

                entity.Property(e => e.WorkOfficialHolidayHours).HasComment("จำนวนชั่วโมงที่พนักงานมาทำงานในวันหยุดนักขัตฤกษ์ของงวดนั้นๆ");
            });

            modelBuilder.Entity<IncomeByPurpose>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.IncomeDate });
            });

            modelBuilder.Entity<InternalUse>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InternalUseNo });

                entity.Property(e => e.InternalUseNo).HasComment("หมายเลขใบเบิกใช้ภายใน");

                entity.Property(e => e.DocStatusId).HasComment("สถานะใบเบิกใช้ภายใน");

                entity.Property(e => e.ToFactionCode).HasComment("เพื่อรหัสฝ่าย (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.UseDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.UseTypeId).HasComment("รหัสประเภทการเบิกใช้");
            });

            modelBuilder.Entity<InternalUseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InternalUseNo, e.SeqId });

                entity.Property(e => e.InternalUseNo).HasComment("หมายเลขใบเบิกใช้ภายใน");

                entity.Property(e => e.SeqId).HasComment("ลำดับสินค้าที่เบิก");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าที่เบิก");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้าที่เบิก");

                entity.Property(e => e.NetAmount).HasComment("ยอดสุทธิของสินค้าชนิดนั้นๆ");

                entity.Property(e => e.Quantity).HasComment("จำนวนสินค้าที่เบิก");

                entity.Property(e => e.ToFactionCode).HasComment("รหัสฝ่าย (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.TotalAmount).HasComment("ยอดรวมของสินค้าชนิดนั้นๆ");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนของสินค้าที่เบิก");

                entity.Property(e => e.UnitName).HasComment("หน่วยของสินค้าที่เบิก");

                entity.Property(e => e.UnitPrice).HasComment("ราคาต่อหน่วยของสินค้าที่เบิก");

                entity.Property(e => e.Whcode).HasComment("รหัสคลังที่ถูกเบิก");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InvoiceNo });

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบแจ้งหนี้");

                entity.Property(e => e.CancelByCode).HasComment("รหัสผูยกเลิก");

                entity.Property(e => e.CancelDate).HasComment("วันที่ยกเลิก");

                entity.Property(e => e.ClaimAmount).HasComment("ยอดส่งเบิก");

                entity.Property(e => e.ClaimTypeId).HasComment("ประเภทการส่งเบิก");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DiscountAmount).HasComment("มูลค่าส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("เงือนไขการลด %/N");

                entity.Property(e => e.DueDate).HasComment("วันกำหนด");

                entity.Property(e => e.IsCancel).HasComment("ยกเลิกใบแจ้งหนี้");

                entity.Property(e => e.IsCutLoss).HasComment("1=ตัดหนี้สูญ");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษาที่ใช้");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.ReceiptAmount).HasComment("ยอดที่รับชำระแล้ว(ทั้งจากผู้ป่วย+หน่วยงานสิทธิ์)");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReprintNum).HasComment("จำนวนครั้งที่พิมพ์ซ้ำ");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");

                entity.Property(e => e.RightNo).HasComment("เลขที่สิทธิ์");

                entity.Property(e => e.VatRate).HasComment("มูลค่า vat");

                entity.Property(e => e.Vn).HasComment("VN");
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InvoiceNo, e.SeqId });

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบแจ้งหนี้");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินตามใบแจ้งหนี้");

                entity.Property(e => e.Quantity).HasComment("จำนวน");

                entity.Property(e => e.ReceiptGroupCode).HasComment("รหัสกลุ่มใบเสร็จ");

                entity.Property(e => e.SocAmount).HasComment("จำนวนเงินส่งเบิก");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนขาย");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");

                entity.Property(e => e.UnitPrice).HasComment("ราคาขาย");

                entity.Property(e => e.VatRate).HasComment("อัตรา vat");

                entity.Property(e => e.VatTypeId).HasComment("ประเภท vat");
            });

            modelBuilder.Entity<InvoicePurchase>(entity =>
            {
                entity.HasKey(e => new { e.InvoicePurchaseNo, e.CreateByOrgCode });
            });

            modelBuilder.Entity<InvoicePurchaseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InvoicePurchaseNo, e.SeqId });
            });

            modelBuilder.Entity<InvoiceReference>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNo, e.OrganizationCode, e.SeqId });

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบแจ้งหนี้ที่อ้างอิง");

                entity.Property(e => e.OrganizationCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.SeqId).HasComment("ลำดับการสร้างเอกสารที่อ้างอิง inv ใช้สร้างเลขที่เอกสารด้วย เช่น invno/1");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกหนี้(สิทธิ์ และ HN)");
            });

            modelBuilder.Entity<IpdchartNote>(entity =>
            {
                entity.HasKey(e => new { e.IpdchartNoteId, e.CreateByOrgCode });

                entity.Property(e => e.ProblemList).HasComment("ปัญหาที่พบ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");
            });

            modelBuilder.Entity<ItemBeginMonth>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.BeginDate, e.Whcode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ItemBeginYear>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.BeginDate, e.Whcode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ItemComposite>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CreateByOrgCode, e.CompositeCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");
            });

            modelBuilder.Entity<ItemCount>(entity =>
            {
                entity.HasKey(e => new { e.ItemCountNo, e.CreateByOrgCode });

                entity.Property(e => e.ItemCountNo).HasComment("เลขที่ใบตรวจนับ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.CountDate).HasComment("วันที่ตรวจนับ");

                entity.Property(e => e.CreateByCode).HasComment("ผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1 = Pending, 2 = Confirm, 3 = Cancel");

                entity.Property(e => e.PercentDiff).HasComment("	อัตราส่วนร้อยละของผลต่างจากการตรวจนับ");

                entity.Property(e => e.StaffCode).HasComment("รหัสผู้นับสินค้า");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ItemCountDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemCountNo, e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.ItemCountNo).HasComment("เลขที่ใบตรวจนับ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.IsConfirm).HasComment("1=ยืนยันการปรับปรุงยอดคงเหลือในคลังตามผลการตรวจนับ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.QuantityCount).HasComment("จำนวนที่นับได้จริง");

                entity.Property(e => e.QuantityDiff).HasComment("จำนวนผลต่างการตรวจนับ");

                entity.Property(e => e.QuantitySystem).HasComment("จำนวนที่มีอยู่ในระบบ");

                entity.Property(e => e.UnitCountName).HasComment("หน่วยที่ใช้นับ");

                entity.Property(e => e.UnitTypeId).HasComment("ประเภทหน่วย 0ไม่ระบุ, 1หน่วยย่อย, 2หน่วยขาย, 3หน่วยซื้อ, 4หน่วยนับส่วนกลาง, 5หน่วยนับสาขา");
            });

            modelBuilder.Entity<ItemDiscountIncentive>(entity =>
            {
                entity.HasKey(e => new { e.SeqId, e.ItemCode, e.StaffCode, e.CreateByOrgCode })
                    .HasName("PK_ItemDiscountIncentive_1");

                entity.Property(e => e.IncentiveSellFix).HasComment("ค่าตอบแทนแบบคงที่");

                entity.Property(e => e.IncentiveSellRate).HasComment("ค่าตอบแทนแบบ %");

                entity.Property(e => e.IsAll).HasComment("1-เป็นแบบที่ตั้งผูกกับ MItem, 0-เป็นแบบที่ตั้งผูกกับ Staff");
            });

            modelBuilder.Entity<ItemDose>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.DoseCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");
            });

            modelBuilder.Entity<ItemForSkin>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SkinCode, e.ItemCode });
            });

            modelBuilder.Entity<ItemFx>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemFxid });

                entity.Property(e => e.Item1TypeId).HasComment("1=กลุ่ม , 2=สามัญ");

                entity.Property(e => e.Item2TypeId).HasComment("1=กลุ่ม , 2=สามัญ");
            });

            modelBuilder.Entity<ItemIncentive>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.StaffCode).HasComment("รหัสประเภทลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsActiveConsult).HasComment("เปิดใช้งานหรือไม่  ถ้าไม่เปิดใช้งานให้เอาค่าตอบแทนจาก MItem มาคำนวณแทน");

                entity.Property(e => e.IsActiveDiag).HasComment("เปิดใช้งานหรือไม่  ถ้าไม่เปิดใช้งานให้เอาค่าตอบแทนจาก MItem มาคำนวณแทน");

                entity.Property(e => e.IsActiveDo).HasComment("เปิดใช้งานหรือไม่  ถ้าไม่เปิดใช้งานให้เอาค่าตอบแทนจาก MItem มาคำนวณแทน");

                entity.Property(e => e.IsActiveSell).HasComment("เปิดใช้งานหรือไม่  ถ้าไม่เปิดใช้งานให้เอาค่าตอบแทนจาก MItem มาคำนวณแทน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<ItemLabPackage>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.LabItemCode });

                entity.Property(e => e.LabPatientTypeId).HasComment("ประเภทแล็บ 1=คนไข้ 2=คู่สมรส 3 = คนไข้และคู่สมรส");
            });

            modelBuilder.Entity<ItemLot>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LotNo, e.ItemCode, e.VendorCode, e.LotNoI });

                entity.Property(e => e.LotNoI).HasComment("เลขล็อตอ้างอิงจาก RoItem");
            });

            modelBuilder.Entity<ItemMaxDose>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CreateByOrgCode, e.FromAge, e.ToAge, e.Sex });

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ItemPayment>(entity =>
            {
                entity.HasKey(e => new { e.ItemPaymentNo, e.CreateByOrgCode });

                entity.Property(e => e.Pono).HasComment("เลขที่ใบสั่งซื้อ");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ItemPaymentItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemPaymentNo, e.SeqId });
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.PriceLevelCode, e.CreateByOrgCode, e.SeqId })
                    .HasName("PK_MItemPrice");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.PriceLevelCode).HasComment("รหัสประเภทลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Barcode).HasComment("Barcode ในการขาย");

                entity.Property(e => e.DiscountRate).HasComment("อัตราส่วนลด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.MinimumQty).HasComment("จำนวนต่ำสุดที่ขายในราคานีั");

                entity.Property(e => e.Price1).HasComment("ราคาขาย OPD");

                entity.Property(e => e.Price2).HasComment("ราคาขาย IPD(ยกเลิก) , เป็นราคาฝากเลี้ยงระหว่างวัน ชม. แรก หรือ ทุก ชม.");

                entity.Property(e => e.Price3).HasComment("ราคาขาย HM(ยกเลิก) ,  เป็นราคาฝากเลี้ยงสำหรับ ชม.ต่อไป");

                entity.Property(e => e.UnitCode).HasComment("หน่วยขาย");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนต่อหน่วย");

                entity.Property(e => e.UnitRatio).HasComment("อัตราส่วนต่อหน่วยเก็บ");
            });

            modelBuilder.Entity<ItemPriceBranch>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.PriceLevelCode, e.CreateByOrgCode, e.DepartmentCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.PriceLevelCode).HasComment("รหัสประเภทลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.DepartmentCode).HasComment("สาขา ใช้ใน Centre2");

                entity.Property(e => e.Barcode).HasComment("Barcode ในการขาย");

                entity.Property(e => e.DiscountRate).HasComment("อัตราส่วนลด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.MinimumQty).HasComment("จำนวนต่ำสุดที่ขายในราคานีั");

                entity.Property(e => e.Price1).HasComment("ราคาขาย OPD");

                entity.Property(e => e.Price2).HasComment("ราคาขาย IPD");

                entity.Property(e => e.Price3).HasComment("ราคาขาย HM");

                entity.Property(e => e.UnitCode).HasComment("หน่วยขาย");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนต่อหน่วย");

                entity.Property(e => e.UnitRatio).HasComment("อัตราส่วนต่อหน่วยเก็บ");
            });

            modelBuilder.Entity<ItemPriceTable>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.SeqId, e.PriceLevelCode });
            });

            modelBuilder.Entity<ItemPriceTableBranch>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.PriceLevelCode, e.SeqId, e.DepartmentCode });

                entity.Property(e => e.DepartmentCode).HasComment("สาขา ใช้ใน Centre2");
            });

            modelBuilder.Entity<ItemPromotion>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode });

                entity.Property(e => e.PromotionCode).HasComment("รหัสโปรโมชั่น");

                entity.Property(e => e.DiscountText).HasComment("ส่วนลดที่ได้รับ");

                entity.Property(e => e.EndDate).HasComment("วันที่สินสุดโปรโมชั่น");

                entity.Property(e => e.EndTime).HasComment("เวลาที่สินสุด");

                entity.Property(e => e.FromItemCode).HasComment("รหัสสินค้าตั้งแต่");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งานหรือไม่");

                entity.Property(e => e.PromotionName).HasComment("ชื่อโปรโมชั่น");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มทำโปรโมชั่น");

                entity.Property(e => e.StartTime).HasComment("เวลาที่เริ่ม");

                entity.Property(e => e.ToItemCode).HasComment("รหัสสินค้าถึง");
            });

            modelBuilder.Entity<ItemPurchasePrice>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.VendorCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Price1).HasComment("ราคาสั่งซื้อ");
            });

            modelBuilder.Entity<ItemQue>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.QueCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.QueCode).HasComment("รหัสห้องที่สั่งสินค้านี้ได้");

                entity.Property(e => e.IsCanOrder).HasComment("สามารถสั่งรายการในห้องได้หรือไม่");
            });

            modelBuilder.Entity<ItemSerial>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SerialNo });

                entity.Property(e => e.Rono).HasComment("เลขที่ใบรับ");

                entity.Property(e => e.SeqId).HasComment("ลำดับใน RO");
            });

            modelBuilder.Entity<ItemVaccineIcd10>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.Icd10code });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า (เฉพาะประเภทวัคซีน)");

                entity.Property(e => e.Icd10code).HasComment("รหัสโรค");

                entity.Property(e => e.SeqId).HasComment("ลำดับ มีไว้เพื่อจะได้ Present กลับมาให้ User เห็นในลำดับเดิมเหมือนตอนที่ตั้งค่า");
            });

            modelBuilder.Entity<ItemXrayPackage>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.XrayItemCode });
            });

            modelBuilder.Entity<Ivtherapy>(entity =>
            {
                entity.HasKey(e => new { e.Vn, e.CreateByOrgCode });

                entity.Property(e => e.AngiocatheterSize).HasComment("ขนาดของเข็ม");

                entity.Property(e => e.BloodPerMeability).HasComment("มีการซึมของเลือดหรือไม่");

                entity.Property(e => e.BpressureHighAfter).HasComment("ความดันโลหิต(สูง) หลังทำ");

                entity.Property(e => e.BpressureHighBefore).HasComment("ความดันโลหิต(สูง) ก่อนทำ");

                entity.Property(e => e.BpressureLowAfter).HasComment("ความดันโลหิต(ต่ำ) หลังทำ");

                entity.Property(e => e.BpressureLowBefore).HasComment("ความดันโลหิต(ต่ำ) ก่อนทำ");

                entity.Property(e => e.Closure).HasComment("มีการปิดแผลเรียบร้อยหรือไม่");

                entity.Property(e => e.DateFromTime).HasComment("เวลาเริ่มต้นการฉีดสารน้ำ");

                entity.Property(e => e.DateToTime).HasComment("เวลาสิ้นสุดการฉีดสารน้ำ");

                entity.Property(e => e.DivestOfNeedleNote).HasComment("บันทึกเพิ่มเติมใน Tab ข้อมูลการถอดสายเข็ม");

                entity.Property(e => e.FulidNote).HasComment("บันทึกเพิ่มเติมใน Tab ข้อมูลการให้สารน้ำ");

                entity.Property(e => e.InjectionCode).HasComment("ผู้ที่ฉีดสารน้ำ");

                entity.Property(e => e.InjectionPosition).HasComment("ตำแหน่งการฉีดเข็ม");

                entity.Property(e => e.InjectionRate).HasComment("อัตราการฉีดเข้าเส้นเลือด");

                entity.Property(e => e.InjectionRatePerHour).HasComment("อัตราการฉีดเข้าเส้นเลือดต่อชั่วโมง");

                entity.Property(e => e.InjectionlNote).HasComment("บันทึกเพิ่มเติมใน Tab ข้อมูลการฉีดเข็ม");

                entity.Property(e => e.MixerCode).HasComment("ผู้ที่ผสมส่วนผสม");

                entity.Property(e => e.NumberOfInjections).HasComment("จำนวนครั้งในการฉีด");

                entity.Property(e => e.Pafter).HasComment("อัตราชีพจรหลังทำ");

                entity.Property(e => e.Pbefore).HasComment("อัตราชีพจรก่อนทำ");

                entity.Property(e => e.PhlebitisScale).HasComment("ระดับอาการการปวดของการฉีดสารน้ำ");

                entity.Property(e => e.PullIvtubeOut).HasComment("มีการถอดสายหรือไม่");
            });

            modelBuilder.Entity<JobDescriptionEducation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JobDescriptionNo, e.SeqId });

                entity.Property(e => e.Degree).HasComment("วุฒิการศึกษา");

                entity.Property(e => e.Gpa).HasComment("เกรดเฉลี่ย");

                entity.Property(e => e.Major).HasComment("สาขาวิชา");

                entity.Property(e => e.Remark).HasComment("อื่นๆ");
            });

            modelBuilder.Entity<JobDescriptionSkill>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JobDescriptionNo, e.SeqId })
                    .HasName("PK_JobDescriptionCapability");
            });

            modelBuilder.Entity<JobDescriptionTrain>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JobDescriptionNo, e.SeqId });
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo });

                entity.Property(e => e.DocNo).HasComment("เลขที่เอกสาร (เลขที่รันของตัวเอง)");

                entity.Property(e => e.CreditAmount).HasComment("ยอดเครดิตทั้งหมด");

                entity.Property(e => e.DebitAmount).HasComment("ยอดเดบิททั้งหมด");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (centre ii เก็บ รหัสสาขา)");

                entity.Property(e => e.DocDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.DocExpenseTypeId).HasComment("ลงบัญชีหรือยัง");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทการบันทึกบัญชี เช่น รายวันทั่วไป รายวันจ่าย เป็นต้น");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre ii เก็บรหัสแผนก)");

                entity.Property(e => e.IsActiveReverse).HasComment("ต้องกลับข้อมูลหรือไม่");

                entity.Property(e => e.IsPost).HasComment("ลงบัญชีหรือยัง");

                entity.Property(e => e.IsReverseAlready).HasComment("กลับข้อมูลแล้วหรือยัง");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.RefDoc).HasComment("เลขที่เอกสารอ้างอิง (Ex. APPayNo, RTV, CN, PCReimburse)");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารอ้างอิง");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Remark2).HasComment("หมายเหตุ 2");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่เสนอให้สร้างเอกสารนี้");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<JournalBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JournalNo, e.SeqId });

                entity.Property(e => e.JournalNo).HasComment("เลขที่เอกสารการบันทึกบัญชี");

                entity.Property(e => e.JournalItemSeqId).HasComment("เกิดจากลำดับใดในการบันทึกบัญชี");
            });

            modelBuilder.Entity<JournalItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo, e.SeqId });

                entity.Property(e => e.DocNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่ของรายการ");

                entity.Property(e => e.AccountCode).HasComment("เลขที่ผังบัญชี");

                entity.Property(e => e.AccountName).HasComment("ชื่อผังบัญชี");

                entity.Property(e => e.BalanceAmount).HasComment("ผลต่าง");

                entity.Property(e => e.BeginingBalance).HasComment("จำนวนเงินต้นงวด");

                entity.Property(e => e.BookCode).HasComment("รหัสสมุดบัญชีธนาคาร");

                entity.Property(e => e.CreditAmount).HasComment("จำนวนเงินที่ Credit");

                entity.Property(e => e.DebitAmount).HasComment("จำนวนเงินที่ Debit");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DocDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบแจ้งหนี้");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("ึคำอธิบายรายการ");

                entity.Property(e => e.VatAmount).HasComment("ภาษีมูลค่าเพิ่ม");
            });

            modelBuilder.Entity<JournalTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode });

                entity.Property(e => e.TemplateCode).HasComment("รหัสรูปแบบ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.TemplateName).HasComment("ชื่อรูปแบบ");

                entity.Property(e => e.TemplateTypeId).HasComment("รหัสประเภทรูปแบบ");
            });

            modelBuilder.Entity<JournalTemplateItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode, e.SeqId });

                entity.Property(e => e.TemplateCode).HasComment("รหัสรูปแบบ");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่ของรายการ");

                entity.Property(e => e.AccountCode).HasComment("เลขที่บัญชี");

                entity.Property(e => e.AccountName).HasComment("ชื่อบัญชี");

                entity.Property(e => e.FormulaCreditName).HasComment("ชื่อ Field ที่นำมา Credit");

                entity.Property(e => e.FormulaDebitName).HasComment("ชื่อ Field ที่นำมา Debit");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");
            });

            modelBuilder.Entity<Knowledge>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.KnowledgeId });
            });

            modelBuilder.Entity<LabRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LabRequestNo, e.Vn });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.LabRequestNo).HasComment("เลขที่ใบ Req");

                entity.Property(e => e.Vn).HasComment("Visit No.");

                entity.Property(e => e.ApprovedByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.ApprovedDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.AttendingByCode).HasComment("รหัสผู้รับผิดชอบ");

                entity.Property(e => e.Col).HasComment("Column ของ Spread");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.Diagnosis).HasComment("คำวินิจฉัย");

                entity.Property(e => e.DocId).HasComment("เก็บรหัสรูปภาพ DocItem.DocID");

                entity.Property(e => e.EmergencyTypeId).HasComment("รูปแบบแล็บด่วน  0-ทั่วไป,1-ด่วน,2-ด่วนมาก");

                entity.Property(e => e.FromQueCode).HasComment("รหัสห้องที่ Request");

                entity.Property(e => e.InstruementCode).HasComment("เครื่องแล็บที่ใช้ในการตรวจแล็บครั้งนี้");

                entity.Property(e => e.IsCalledResult).HasComment("ดึงค่าผลแล็บแล้ว");

                entity.Property(e => e.IsCancel).HasComment("ถูกยกเลิกแล้วหรือไม่");

                entity.Property(e => e.IsComplete).HasComment("ผลแล็บกลับมาสมบูรณ์แล้วหรือไม่");

                entity.Property(e => e.IsEnQue).HasComment("ส่งเข้าคิวแล็บสำหรับ Izpal lab Room หรือไม่");

                entity.Property(e => e.IsExternalLab).HasComment("เป้น Lab จากภายนอกหรือไม่");

                entity.Property(e => e.IsRead).HasComment("สถานะการอ่านผล");

                entity.Property(e => e.IsRegist).HasComment("ได้ทำการขึ้นทะเบียน Regist");

                entity.Property(e => e.IsRequest).HasComment("ส่ง Request ไปหาเครื่องตรวจแล็บแล้วหรือยัง");

                entity.Property(e => e.IsStat).HasComment("ข้อมูล เร่งด่วน");

                entity.Property(e => e.LabTemplateCode).HasComment("รหัสรูปแบบใบ Req");

                entity.Property(e => e.OrgDestinationCode).HasComment("สาขาที่ส่ง Lab");

                entity.Property(e => e.ReadByCode).HasComment("รหัสผู้่อานผล");

                entity.Property(e => e.ReceiveByCode).HasComment("รหัสผู้รับ");

                entity.Property(e => e.ReceiveDate).HasComment("วันที่รับ");

                entity.Property(e => e.RegistDate).HasComment("วันเวลา Regist");

                entity.Property(e => e.ReportByCode).HasComment("รหัสผู้ออกผล");

                entity.Property(e => e.ReportDate).HasComment("วันที่ออกผล");

                entity.Property(e => e.RequestDate).HasComment("วันที่ Request Lab");

                entity.Property(e => e.Row).HasComment("Rows ของ Spread");

                entity.Property(e => e.SpouseGid).HasComment("GID คู่สมรส");
            });

            modelBuilder.Entity<LabRequestItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LabRequestNo, e.SeqId })
                    .HasName("PK_LabRequestedItem");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.LabRequestNo).HasComment("เลขที่ใบ Req");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ApprovedByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.ApprovedDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.AttendingByCode).HasComment("รหัสผู้วินิฉัย");

                entity.Property(e => e.Classified)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Col).HasComment("Column ของ Spread");

                entity.Property(e => e.IsRead).HasComment("สถานะการอ่านผล");

                entity.Property(e => e.IsStat).HasComment("ข้อมูลสถิติ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.LabPatientTypeId).HasComment("ประเภทแล็บ 1=คนไข้ 2=คู่สมรส 3 = คนไข้และคู่สมรส");

                entity.Property(e => e.LabResultMax).HasComment("ผลแล็บสูงสุด (ตัวเลข)");

                entity.Property(e => e.LabResultMin).HasComment("ผลแล็บต่ำสุด (ตัวเลข)");

                entity.Property(e => e.LabResultNegativeText).HasComment("เก็บข้อความกรณี Negative สำหรับผลแล็บแบบ Yes/No");

                entity.Property(e => e.LabResultPositiveText).HasComment("เก็บข้อความกรณี Positive  สำหรับผลแล็บแบบ Yes/No");

                entity.Property(e => e.LabResultStd).HasComment("ผลแล็บมาตราฐาน (ตัวเลข)");

                entity.Property(e => e.LabResultText).HasComment("สำหรับเก็บผลข้อความ หากเป็นผลแล็บแบบ\"ข้อความ\"");

                entity.Property(e => e.ReadByCode).HasComment("รหัสผู้อ่านผล");

                entity.Property(e => e.ReceiveByCode).HasComment("รหัสผู้รับ");

                entity.Property(e => e.ReceiveDate).HasComment("วันที่รับ");

                entity.Property(e => e.ReportByCode).HasComment("รหัสผู้ออกผล");

                entity.Property(e => e.ReportDate).HasComment("วันที่ออกผล");

                entity.Property(e => e.Result).HasComment("ผลแล็บแบบข้อความ");

                entity.Property(e => e.Result2).HasComment("ค่าที่ได้จากการคำนวณ/ ผลแล็บแบบตัวเลข");

                entity.Property(e => e.Row).HasComment("Rows ของ Spread");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<LabResultReport>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LabReportId })
                    .HasName("PK_LabReport");

                entity.Property(e => e.LabGroupCode).HasComment("รหัสกลุ่มแล็บสำหรับพิมพ์ผลแล็บ");

                entity.Property(e => e.LabGroupName).HasComment("ชื่อกลุ่มแล็บสำหรับพิมพ์ผลแล็บ");

                entity.Property(e => e.LabMax).HasComment("ค่ามาตรฐานสูงสุดสำหรับพิมพ์ผลแล็บ");

                entity.Property(e => e.LabMin).HasComment("ค่ามาตรฐานต่ำสุดสำหรับพิมพ์ผลแล็บ");

                entity.Property(e => e.LabTypeId).HasComment("ประเภทผลแล็บสำหรับพิมพ์ผลแล็บ");

                entity.Property(e => e.Reference).HasComment("ค่ามาตรฐาน");

                entity.Property(e => e.RequestHeader).HasComment("วันที่ส่งรีเควสสำหรับพิมพ์ผลแล็บ");
            });

            modelBuilder.Entity<LineNotify>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AccessToken, e.LineTypeId, e.QueCode });

                entity.Property(e => e.AccessToken).HasComment("accessToken ขอได้จาก https://notify-bot.line.me/my/ เป็น accessToken เฉพาะแต่ละกลุ่ม");

                entity.Property(e => e.LineTypeId).HasComment("ประเภท Line 1=LineTemplate, 2=LineAction");

                entity.Property(e => e.QueCode).HasComment("รหัสห้อง");

                entity.Property(e => e.AccessTypeId).HasComment("ประเภท Notify 1=ความเห็นการเข้าพัก(Vetsor), 2=บันทึกการเสียชีวิต(Vetsor), 3=สรุปรายได้ประจำวัน");

                entity.Property(e => e.IsRepeat).HasComment("ส่งซ้ำหรือไม่");

                entity.Property(e => e.Unit).HasComment("จำนวนหน่วย เช่น 10นาที 10ตัว");
            });

            modelBuilder.Entity<LogDatum>(entity =>
            {
                entity.HasKey(e => new { e.LogId, e.CreateByOrgCode });

                entity.Property(e => e.LogId).HasComment("เลขที่ Log ID (Auto Running)");

                entity.Property(e => e.ActionTypeCode).HasComment("View, Create, Edit, Delete");

                entity.Property(e => e.DataCode1).HasComment("รหัสข้อมูลตัวอักษร 1");

                entity.Property(e => e.DataCode2).HasComment("รหัสข้อมูลตัวอักษร 2");

                entity.Property(e => e.DataId1).HasComment("รหัสข้อมูลตัวเลข 1");

                entity.Property(e => e.DataId2).HasComment("รหัสข้อมูลตัวเลข 2");

                entity.Property(e => e.Location).HasComment("ต่ำแหน่งที่อยู่ที่ใช้งาน");

                entity.Property(e => e.LogTypeId).HasComment("รหัสประเภท Log");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");
            });

            modelBuilder.Entity<Maccount>(entity =>
            {
                entity.HasKey(e => new { e.AccountCode, e.CreateByOrgCode });

                entity.Property(e => e.AccountCode).HasComment("เลขที่บัญชี");

                entity.Property(e => e.AccountCashFlowTypeId).HasComment("ประเภทกระแสเงินสด(0=ไม่มี, 1=กิจกรรมดำเนินงาน, 2=ลงทุน, 3=จัดหาเงิน");

                entity.Property(e => e.AccountDescription).HasComment("คำอธิบายเลขที่บัญชี");

                entity.Property(e => e.AccountGroupCode).HasComment("รหัสกลุ่มบ/ช MAccountGroup");

                entity.Property(e => e.AccountLevel).HasComment("ระดับของประเภทบัญชี(บชแม่/บชลูก)");

                entity.Property(e => e.AccountName).HasComment("ชื่อบัญชี");

                entity.Property(e => e.AccountTypeId).HasComment("ประเภทบัญชี 0 ทัวไป 1 กำไรสะสม");

                entity.Property(e => e.Balance1).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance10).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance11).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance12).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance13).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance14).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance15).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance16).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance17).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance18).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance19).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance2).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance20).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance21).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance22).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance23).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance24).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance3).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance4).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance5).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance6).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance7).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance8).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Balance9).HasComment("ยอดบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Budget1).HasComment("งบประมาณปีบช.ปัจจุบันงวด1");

                entity.Property(e => e.Budget10).HasComment("งบประมาณปีบช.ปัจจุบันงวด10");

                entity.Property(e => e.Budget11).HasComment("งบประมาณปีบช.ปัจจุบันงวด11");

                entity.Property(e => e.Budget12).HasComment("งบประมาณปีบช.ปัจจุบันงวด12");

                entity.Property(e => e.Budget13).HasComment("งบประมาณปีบช.ปัจจุบันงวด1");

                entity.Property(e => e.Budget14).HasComment("งบประมาณปีบช.ปัจจุบันงวด2");

                entity.Property(e => e.Budget15).HasComment("งบประมาณปีบช.ปัจจุบันงวด3");

                entity.Property(e => e.Budget16).HasComment("งบประมาณปีบช.ปัจจุบันงวด4");

                entity.Property(e => e.Budget17).HasComment("งบประมาณปีบช.ปัจจุบันงวด5");

                entity.Property(e => e.Budget18).HasComment("งบประมาณปีบช.ปัจจุบันงวด6");

                entity.Property(e => e.Budget19).HasComment("งบประมาณปีบช.ปัจจุบันงวด7");

                entity.Property(e => e.Budget2).HasComment("งบประมาณปีบช.ปัจจุบันงวด2");

                entity.Property(e => e.Budget20).HasComment("งบประมาณปีบช.ปัจจุบันงวด8");

                entity.Property(e => e.Budget21).HasComment("งบประมาณปีบช.ปัจจุบันงวด9");

                entity.Property(e => e.Budget22).HasComment("งบประมาณปีบช.ปัจจุบันงวด10");

                entity.Property(e => e.Budget23).HasComment("งบประมาณปีบช.ปัจจุบันงวด11");

                entity.Property(e => e.Budget24).HasComment("งบประมาณปีบช.ปัจจุบันงวด12");

                entity.Property(e => e.Budget3).HasComment("งบประมาณปีบช.ปัจจุบันงวด3");

                entity.Property(e => e.Budget4).HasComment("งบประมาณปีบช.ปัจจุบันงวด4");

                entity.Property(e => e.Budget5).HasComment("งบประมาณปีบช.ปัจจุบันงวด5");

                entity.Property(e => e.Budget6).HasComment("งบประมาณปีบช.ปัจจุบันงวด6");

                entity.Property(e => e.Budget7).HasComment("งบประมาณปีบช.ปัจจุบันงวด7");

                entity.Property(e => e.Budget8).HasComment("งบประมาณปีบช.ปัจจุบันงวด8");

                entity.Property(e => e.Budget9).HasComment("งบประมาณปีบช.ปัจจุบันงวด9");

                entity.Property(e => e.BudgeteCause).HasComment("เกณฑ์ในการคิดงบประมาณของปีบช.ปัจจุบัน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CreditAmount1).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount10).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount11).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount12).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount13).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount14).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount15).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount16).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount17).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount18).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount19).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount2).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount20).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount21).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount22).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount23).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount24).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount3).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount4).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount5).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount6).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount7).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount8).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.CreditAmount9).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount1).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount10).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount11).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount12).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount13).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount14).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount15).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount16).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount17).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount18).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount19).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount2).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount20).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount21).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount22).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount23).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount24).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount3).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount4).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount5).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount6).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount7).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount8).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.DebitAmount9).HasComment("ยอดยกมาของเดือนบช.ปีบช.บัจจุบัน");

                entity.Property(e => e.Inactive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsHeader).HasComment("1=เป็นบัญชีแม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.LastBalance1).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance10).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance11).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance12).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance13).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance14).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance15).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance16).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance17).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance18).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance19).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance2).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance20).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance21).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance22).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance23).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance24).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance3).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance4).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance5).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance6).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance7).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance8).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBalance9).HasComment("ยอดบช.ของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget1).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget10).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget11).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget12).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget13).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget14).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget15).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget16).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget17).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget18).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget19).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget2).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget20).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget21).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget22).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget23).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget24).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget3).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget4).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget5).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget6).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget7).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget8).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudget9).HasComment("งบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.LastBudgetCause).HasComment("เกณฑ์ในการคิดงบประมาณของปีบช.ที่ผ่านมา");

                entity.Property(e => e.ParentAccountCode).HasComment("เลขที่บัญชีที่เป็นบัญชีแม่");
            });

            modelBuilder.Entity<MaccountAssign>(entity =>
            {
                entity.HasKey(e => new { e.AccountAssignTypeId, e.TargetCode, e.SeqId })
                    .HasName("PK_MAccountAssign_1");

                entity.Property(e => e.AccountAssignTypeId).HasComment("รหัสรูปแบบการผูกบัญชี เช่น 1=PrettyCash, 2=Advance, ..., 101=Cash, 102=Item etc.");

                entity.Property(e => e.TargetCode).HasComment("รหัสเป้าหมายการผูกเช่น รหัสสินค้า, รหัสค่าใช้จ่าย เป็นต้น");

                entity.Property(e => e.AccountTypeId).HasComment("ประเภทของผังบัญชีที่เอามาผูก เช่น 101=Bank, 102=CreditCard เป็นต้น");

                entity.Property(e => e.TargetName).HasComment("ชื่อเป้าหมายการผูกเช่น ชื่อสินค้า, ชื่อค่าใช้จ่าย เป็นต้น");

                entity.Property(e => e.TargetName2).HasComment("ชื่อเป้าหมายการผูก2 เช่น ชื่อสินค้า2, ชื่อค่าใช้จ่าย2 เป็นต้น");
            });

            modelBuilder.Entity<MaccountBook>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BookCode });

                entity.Property(e => e.BookCode).HasComment("รหัสสมุดบัญชี");

                entity.Property(e => e.BookName).HasComment("ชื่อสมุดบัญชี");

                entity.Property(e => e.BookName2).HasComment("ชื่อสมุดบัญชี2");

                entity.Property(e => e.Inactive).HasComment("1=ไม่ใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("1=เป็นข้อมูลของระบบ");
            });

            modelBuilder.Entity<MaccountGroup>(entity =>
            {
                entity.HasKey(e => new { e.AccountGroupCode, e.CreateByOrgCode });

                entity.Property(e => e.AccountGroupCode).HasComment("รหัสกลุ่มบัญชี");

                entity.Property(e => e.AccountGroupName).HasComment("ชื่อกลุ่มบัญชี");

                entity.Property(e => e.AccountTypeId).HasComment("รหัสประเภทบัญชี 1 สินทรัพย์ 2 หนี้สิน...");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<MaccountItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PeriodId, e.PeriodYear, e.AccountCode });

                entity.Property(e => e.PeriodId).HasComment("งวด");

                entity.Property(e => e.PeriodYear).HasComment("ปีของงวด");

                entity.Property(e => e.AccountCode).HasComment("รหัสแฟ้มบัญชี");

                entity.Property(e => e.Budget).HasComment("งบประมาณ");

                entity.Property(e => e.CreditAmount).HasComment("ยอดเครดิต");

                entity.Property(e => e.DebitAmount).HasComment("ยอดเดบิต");

                entity.Property(e => e.NetAmount).HasComment("ยอดยกไป");

                entity.Property(e => e.StartAmount).HasComment("ยอดยกมา");
            });

            modelBuilder.Entity<MaccountOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode })
                    .HasName("PK_MAccountConfig");

                entity.Property(e => e.Arover).HasComment("เตือนวงเงิน ลูกหนี้");

                entity.Property(e => e.BeginPeriodDate).HasComment("วันที่เริ่มต้นรอบปีบัญชี");

                entity.Property(e => e.BeginPeriodMonth).HasComment("เดือนเริ่มต้นรอบปีบัญชี");

                entity.Property(e => e.BeginPeriodYear).HasComment("ปีีเริ่มต้นรอบปีบัญชี");

                entity.Property(e => e.Cashap).HasComment("ลักษณะการซื้อส่วนมาก");

                entity.Property(e => e.Comadd1).HasComment("ที่อยู่บริษัท");

                entity.Property(e => e.Comadd2).HasComment("ที่อยู่บริษัท");

                entity.Property(e => e.Costlocid).HasComment("คำนวนต้นทุน แยกคลัง/รวมคลัง");

                entity.Property(e => e.Costtype).HasComment("วิธีคำนวณต้นทุน");

                entity.Property(e => e.Datetype).HasComment("ชนิด วันที่ พ.ศ. หรือ ค.ศ.");

                entity.Property(e => e.Dbversion).HasComment("DATABASE VERSION");

                entity.Property(e => e.DepreciateDay).HasComment("จำนวนวันคิดค่าเสื่อมต่อปี");

                entity.Property(e => e.DepreciateTypeId).HasComment("ประเภทการคิดค่าเสื่อม 0 คิดจากปี 1 คิดตามจำนวนวันที่ระบุ");

                entity.Property(e => e.DepreciationMethodId).HasComment("รหัสวิธีคำนวณค่าเสื่อมราคา 0=เส้นตรง");

                entity.Property(e => e.F3inv).HasComment("แสดงคลังใน F3 สินค้า");

                entity.Property(e => e.Fixdayinyr).HasComment("จำนวนวันที่คิดใน 1 ปีสำหรับระบบ ค่าเสื่อมทรัพย์สิน");

                entity.Property(e => e.Glshow).HasComment("แสดงรายการบัญชีใน รายวัน");

                entity.Property(e => e.InventoryCostType).HasComment("วิธีคิดต้นทุนขาย 0=เฉลี่ย 1=Fifo 2=Index");

                entity.Property(e => e.InventoryPostTypeId).HasComment("วิธีการบันทึกบัญชี");

                entity.Property(e => e.Invzero).HasComment("ห้ามขายสินค้าต่ำกว่า 0");

                entity.Property(e => e.PeriodPerYear).HasComment("จำนวนงวดบัญชีต่อปี");

                entity.Property(e => e.PeriodSetUpProgram).HasComment("งวดที่ทำการเริ่มใช้โปรแกรม");

                entity.Property(e => e.RevenueTaxTypeId).HasComment("รหัสวิธิคิดภาษีเงินได้นิติบุคคล 0=อัตราเดียว 1=ขั้นบันได");

                entity.Property(e => e.Sapgl).HasComment("เจ้าหนี้");

                entity.Property(e => e.Sarmst).HasComment("รหัสผังบัญชีลูกหนี้");

                entity.Property(e => e.Sbkkbl).HasComment("ธนาคาร");

                entity.Property(e => e.Sbkkchg).HasComment("ค่าใช้จ่ายธนาคาร");

                entity.Property(e => e.Scashin).HasComment("รหัสผังบัญชีเงินสดรับ");

                entity.Property(e => e.Scashout).HasComment("เงินสดจ่าย");

                entity.Property(e => e.Scost).HasComment("รหัสผังบัญชีต้นทุนขาย");

                entity.Property(e => e.SdiscR).HasComment("ส่วนลดจ่าย");

                entity.Property(e => e.Sdiscex).HasComment("รหัสผังบัญชีส่วนลดรับ");

                entity.Property(e => e.Sdownpay).HasComment("ลูกหนี้เงินมัดจำ");

                entity.Property(e => e.Sdownrec).HasComment("เจ้าหนี้เงินมัดจำ");

                entity.Property(e => e.Seng).HasComment("ใช้ภาษาอังกฤษ");

                entity.Property(e => e.Sfirstend).HasComment("เป็นฐานข้อมูลที่เกิดจากปิดงวดแล้วยังไม่ทำ UT");

                entity.Property(e => e.Sfirstuse).HasComment("เป็นการทำงานครั้งแรกในโปรแกรม");

                entity.Property(e => e.Sfixexp).HasComment("ค่าใช้จ่าย ค่าเสื่อมราคา");

                entity.Property(e => e.Sinv1).HasComment("รหัสผังบัญชีสินค้าหลัก");

                entity.Property(e => e.Skinpath).HasComment("SubDirectory Skin");

                entity.Property(e => e.Slastback).HasComment("วันที่สุดท้ายที่ทำการ BACKUP");

                entity.Property(e => e.Slinespace1).HasComment("กำหนด ระยะห่างระหว่าง สระบนกับพยัญชนะ");

                entity.Property(e => e.Slinespace2).HasComment("กำหนด ระยะห่างระหว่าง พยัญชนะกับสระล่าง");

                entity.Property(e => e.Slinespace3).HasComment("กำหนด ระยะห่างระหว่าง สระล่างกับ สระบนบรรทัดต่อไป");

                entity.Property(e => e.Slock).HasComment("LOCK ฐานข้อมูล");

                entity.Property(e => e.Slockdate1).HasComment("วันที่ที่ LOCK ฐานข้อมูล 1");

                entity.Property(e => e.Slockdate2).HasComment("วันที่ที่ LOCK ฐานข้อมูล 2");

                entity.Property(e => e.Spchkexp).HasComment("เช็คจ่ายล่วงหน้า");

                entity.Property(e => e.Spchkrec).HasComment("เช็ครับล่วงหน้า");

                entity.Property(e => e.Splaccu).HasComment("ผังบัญชี กำไรขาดทุนสะสม");

                entity.Property(e => e.Splinyear).HasComment("ผังบัญชี กำไรขาดทุน ภายในปี");

                entity.Property(e => e.Spurchase).HasComment("ซื้อ");

                entity.Property(e => e.Sretuin).HasComment("รับคืน");

                entity.Property(e => e.Sretuou).HasComment("ส่งคืน");

                entity.Property(e => e.Ssale).HasComment("รหัสผังบัญชีขาย");

                entity.Property(e => e.StartSystemDate).HasComment("วันที่เริ่มใช้ระบบ");

                entity.Property(e => e.Staxgl).HasComment("ภาษีหัก ณ ที่จ่ายค้างจ่าย");

                entity.Property(e => e.Staxglar).HasComment("ภาษีหัก ณ ที่จ่าย ค้างรับ");

                entity.Property(e => e.Stextline).HasComment("จำนวนบรรทัด/ 1 หน้ารายงาน");

                entity.Property(e => e.Svatchg).HasComment("ค่าใช้จ่ายภาษีซื้อ ( กรณีภาษีซื้อขอคืนไม่ได้ )");

                entity.Property(e => e.Svatpur).HasComment("ภาษีซื้อ");

                entity.Property(e => e.Svatsale).HasComment("รหัสผังบัญชีภาษีขาย");

                entity.Property(e => e.Swarnback).HasComment("เตือนให้ BACKUP");

                entity.Property(e => e.Sxvatpur).HasComment("ภาษีซื้อที่ยังไม่ถึงกำหนด");

                entity.Property(e => e.Sxvatsal).HasComment("ภาษีขายรอเรียกเก็บ");

                entity.Property(e => e.Taxtype).HasComment("ชนิดภาษี 0:ยกเว้น 1:รวมใน 2:แยกนอก");

                entity.Property(e => e.VatChargeId).HasComment("ภาระภาษี");

                entity.Property(e => e.YearSetUpProgram).HasComment("ปีที่ทำการเริ่มใช้โปรแกรม");
            });

            modelBuilder.Entity<MaccountPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PeriodId, e.PeriodYear });

                entity.Property(e => e.PeriodId).HasComment("รหัสงวดบัญชี");

                entity.Property(e => e.PeriodYear).HasComment("ปีของงวด");

                entity.Property(e => e.LastPeriodId).HasComment("งวดที่ใช้ในการเปรียบเทียบ งบประมาณ");
            });

            modelBuilder.Entity<MaccountSheetsFormat>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.GroupCode, e.DataTypeId });
            });

            modelBuilder.Entity<MaccountSheetsFormatItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.GroupCode, e.DataTypeId, e.AccountCode });
            });

            modelBuilder.Entity<MaccountTaskToBook>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BookCode, e.ActivityTypeCode })
                    .HasName("PK_MAccountLink");

                entity.Property(e => e.BookCode).HasComment("รหัสสมุดบ/ช");

                entity.Property(e => e.ActivityTypeCode).HasComment("ประเภทกิจกรรมดำเนินงาน");

                entity.Property(e => e.ActivityTypeName).HasComment("ชื่อประเภทกิจกรรมดำเนินงาน");
            });

            modelBuilder.Entity<Mamphur>(entity =>
            {
                entity.HasKey(e => new { e.AmphurCode, e.CreateByOrgCode });

                entity.Property(e => e.AmphurCode).HasComment("รหัสอำเภอ 4 หลัก ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AmphurName).HasComment("ชื่ออำเภอ");

                entity.Property(e => e.AmphurName2).HasComment("ชื่ออำเภอ (ภาษาอังกฤษ)");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.PostCode).HasComment("รหัสไปรษณีย์");
            });

            modelBuilder.Entity<Manimal>(entity =>
            {
                entity.Property(e => e.AnimalGid).HasComment("รหัสสัตว์");

                entity.Property(e => e.AdmitDate).HasComment("วันที่และเวลาเข้ารับการรักษา(VetSor)");

                entity.Property(e => e.AdmitDuration).HasComment("ระยะเวลารักษา(VetSor)/วัน");

                entity.Property(e => e.AnimalCode).HasComment("รหัสสัตว์ป่วย");

                entity.Property(e => e.AnimalName).HasComment("ชื่อสัตว์");

                entity.Property(e => e.Autopsy).HasComment("การชันสูตร/ผ่าซาก(VetSor)");

                entity.Property(e => e.BirthDate).HasComment("วันเกิด");

                entity.Property(e => e.BirthDateText).HasComment("วันเกิดรูปแบบ Text");

                entity.Property(e => e.BreedCode).HasComment("พันธุ์");

                entity.Property(e => e.CauseDeath).HasComment("สรุปสาเหตุการเสียชีวิต(VetSor)");

                entity.Property(e => e.ColorCode).HasComment("สีของสัตว์");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง Record");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง Record");

                entity.Property(e => e.DeadDate).HasComment("วันที่เสียชีวิต");

                entity.Property(e => e.DeadRelative).HasComment("ญาติผู้เสียชีวิต");

                entity.Property(e => e.DeadRemark).HasComment("หมายเหตุการเสียชีวิต/วิธีกำจัด");

                entity.Property(e => e.DeadSendTo).HasComment("ชื่อสถานนิติเวช");

                entity.Property(e => e.DoctorCodeCheck).HasComment("แพทย์ผู้รักษา");

                entity.Property(e => e.DoctorCodeWrite).HasComment("แพทย์ผู้เขียน/ผู้รับรองการเสียชีวิต");

                entity.Property(e => e.FeedbackOwner).HasComment("ผลตอบรับจากเจ้าของ(VetSor)");

                entity.Property(e => e.FinalDiagnosis).HasComment("การวินิจฉัยโรคขั้นสุดท้าย(VetSor)");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.InsuranceCompany).HasComment("ชื่อบริษัทประกัน");

                entity.Property(e => e.InsurancePolicyNo).HasComment("เลขที่กรมธรรม์");

                entity.Property(e => e.IsDead).HasComment("สถานะการเสียชีวิต");

                entity.Property(e => e.IsFerocious).HasComment("ดุร้าย");

                entity.Property(e => e.IsSterilize).HasComment("ทำหมันหรือยัง");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไขล่าสุด");

                entity.Property(e => e.ModByOrgCode).HasComment("องค์กรที่แก้ไขข้อมูล");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.OwnerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.PriceLevelCode).HasComment("ระดับราคา");

                entity.Property(e => e.PrimaryDiagnosis).HasComment("การวินิจฉัยโรคขั้นตั้น(VetSor)");

                entity.Property(e => e.Sensible).HasComment("เหตุผลเสียชีวิตสมเหตุสมผล(VetSor)");

                entity.Property(e => e.SensibleTypeId).HasComment("เสียชีวิตสมเหตุสมผลหรือไม่(VetSor) 1=สมเหตุสมผล 2=ไม่สมเหตุสมผล");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("เพศ");

                entity.Property(e => e.SpeciesCode).HasComment("ประเภท");
            });

            modelBuilder.Entity<ManimalImage>(entity =>
            {
                entity.HasKey(e => new { e.AnimalGid, e.CreateByOrgCode });

                entity.Property(e => e.AnimalGid).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");
            });

            modelBuilder.Entity<MappBuild>(entity =>
            {
                entity.HasKey(e => new { e.AppName, e.CreateByOrgCode });

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<MappDateFormat>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AppDateCode });

                entity.Property(e => e.AppDateCode).HasComment("รหัสรูปแบบการนัดหมาย");

                entity.Property(e => e.AppDateName).HasComment("ชื่อรูปแบบการนัดหมาย");

                entity.Property(e => e.DateAddAmount).HasComment("จำนวนที่เพิ่มในการนัดหมาย");

                entity.Property(e => e.DateAddTypeId).HasComment("ประเภทการเพิ่มวันนัดหมาย (1=วัน 2 = สัปดาห์ 3- เดือน 4 = ปี)");
            });

            modelBuilder.Entity<MarketingList>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MarketingListCode });
            });

            modelBuilder.Entity<Mbank>(entity =>
            {
                entity.HasKey(e => new { e.BankCode, e.CreateByOrgCode, e.BookBankId })
                    .HasName("PK_MBank_1");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคาร");

                entity.Property(e => e.BookBankId).HasComment("เลขที่สมุดเงินฝาก");

                entity.Property(e => e.AccountName).HasComment("Account name");

                entity.Property(e => e.AccountType).HasComment("Account type");

                entity.Property(e => e.Amount).HasComment("ยอดคงเหลือ");

                entity.Property(e => e.BankAccountCode).HasComment("เลขที่บัญชีธนาคาร(ในผังบัญชี)");

                entity.Property(e => e.BankAccountTypeId).HasComment("ประเภทเงินฝาก  1=ออมทรัพย์ 2=กระแสรายวัน 3=ประจำ ");

                entity.Property(e => e.BankBrachCode).IsFixedLength(true);

                entity.Property(e => e.BankName).HasComment("ชื่อธนาคาร");

                entity.Property(e => e.BankTypeId).HasComment("1=ธนาคาร 2=บัตรเครดิต");

                entity.Property(e => e.InitialAmount).HasComment("ยอดตั้งต้น");

                entity.Property(e => e.InitialDate).HasComment("วันที่ตั้งต้น");

                entity.Property(e => e.IsForCheque).HasComment("สมุดบัญชีเล่มนี้ใช้เพื่อจ่ายเช็ค");

                entity.Property(e => e.ModByOrgCode).HasComment("Modified by organization code");

                entity.Property(e => e.ParentOrgCode).HasComment("Parent organization code");

                entity.Property(e => e.TransactionDate).HasComment("Transaction date");
            });

            modelBuilder.Entity<MbankBranch>(entity =>
            {
                entity.HasKey(e => new { e.BankBranchCode, e.BankCode, e.CreateByOrgCode });

                entity.Property(e => e.BankBranchCode).HasComment("Bank branch code");

                entity.Property(e => e.CreateByOrgCode).HasComment("Created by organization code");

                entity.Property(e => e.BankBranchName).HasComment("Bank branch");

                entity.Property(e => e.CreateByCode).HasComment("Created by code");

                entity.Property(e => e.CreateDate).HasComment("Created date");

                entity.Property(e => e.ModByCode).HasComment("Modified by code");

                entity.Property(e => e.ModByOrgCode).HasComment("Modified by organization code");

                entity.Property(e => e.ModDate).HasComment("Modified date");

                entity.Property(e => e.ParentOrgCode).HasComment("Parent organiation code");
            });

            modelBuilder.Entity<MbankNote>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BankNoteCode });

                entity.Property(e => e.BankNoteCode).HasComment("รหัสธนบัตร");

                entity.Property(e => e.BankNoteImage).HasComment("รูปธนบัตร");

                entity.Property(e => e.BankNoteName).HasComment("ชื่อ(ไทย)");

                entity.Property(e => e.BankNoteName2).HasComment("ชื่อ(Eng)");

                entity.Property(e => e.BankValue).HasComment("มูลค่า(ตัวเลข)");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");
            });

            modelBuilder.Entity<MbiometricDatum>(entity =>
            {
                entity.HasKey(e => e.BioDataGid)
                    .HasName("PK_MFingerprint");

                entity.Property(e => e.BioDataGid).HasComment("รหัสข้อมูล Biometric");

                entity.Property(e => e.BioData).HasComment("ข้อมูล Biometric");

                entity.Property(e => e.BioDataIndex).HasComment("ลำดับข้อมูล Biometric เช่น รหัสนิ้ว");

                entity.Property(e => e.BioDataTypeId).HasComment("รหัสประเภทข้อมูล Biometric ( 1= Standard 2= Fast)");

                entity.Property(e => e.OwnerCode).HasComment("รหัสเจ้าของข้อมูล Biometric (Customer Code)");

                entity.Property(e => e.OwnerGid).HasComment("รหัสเจ้าของข้้อมูล Biometric (CustomerGID)");

                entity.Property(e => e.OwnerTypeId).HasComment("1=พนักงาน 2=ลูกค้า");
            });

            modelBuilder.Entity<MbiometricDevice>(entity =>
            {
                entity.HasKey(e => new { e.DeviceCode, e.CreateByOrgCode });

                entity.Property(e => e.DeviceCode).HasComment("รหัสเครื่องมือ Biometric");

                entity.Property(e => e.EnrollTypeId).HasComment("ประเภทการใช้งาน (1=ลงเข้า 2=ลงออก 3 ทั้งหมด)");

                entity.Property(e => e.RegCode).HasComment("รหัสลงทะเบียน");

                entity.Property(e => e.RegKey).HasComment("รหัสปลดล๊อค");

                entity.Property(e => e.StatusId).HasComment("สถานะการใช้งาน");
            });

            modelBuilder.Entity<MbiometricDeviceOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode })
                    .HasName("PK_BiometricDeviceOptions");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กรที่สร้างข้อมูล");

                entity.Property(e => e.OrganizationCode).HasComment("รหัสองค์กรที่ใช้งาน");

                entity.Property(e => e.Dpi).HasComment("ค่า Dot Per Inch");

                entity.Property(e => e.Far).HasComment("False Accept Rate");

                entity.Property(e => e.MinMinutiaCount).HasComment("ค่าต่ำสุดของ Minutia");

                entity.Property(e => e.SearchTypeId).HasComment("1=ปกติ 2=เร็ว");

                entity.Property(e => e.Threshold).HasComment("ค่า Threshold");
            });

            modelBuilder.Entity<MbookLinkForm>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.FormCode });

                entity.Property(e => e.FormCode).HasComment("รหัสฟอร์มที่บันทึกข้อมูล");

                entity.Property(e => e.BookCode).HasComment("รหัสสมุดรายวันที่ใช้บันทึก");

                entity.Property(e => e.FormName).HasComment("ชื่อฟอร์ม");

                entity.Property(e => e.Inactive).HasComment("1=ไม่ใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("1=เป็นข้อมูลของระบบ");
            });

            modelBuilder.Entity<Mbreed>(entity =>
            {
                entity.HasKey(e => new { e.BreedCode, e.CreateByOrgCode, e.SpeciesCode });
            });

            modelBuilder.Entity<Mcampaign>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CampaignCode });

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่ม");
            });

            modelBuilder.Entity<McardType>(entity =>
            {
                entity.Property(e => e.CardTypeCode).HasComment("รหัสประเภทบัตร");

                entity.Property(e => e.CardAge).HasComment("อายุบัตร ( วัน )");

                entity.Property(e => e.CardPoint).HasComment("จำนวนแต้ม");

                entity.Property(e => e.CardTypeName).HasComment("ประเภทบัตร");

                entity.Property(e => e.InitialMoney).HasComment("จำนวนเงินเริ่มต้น");

                entity.Property(e => e.InitialPoint).HasComment("จำนวนแต้มเริ่มต้น");
            });

            modelBuilder.Entity<Mcertificate>(entity =>
            {
                entity.HasKey(e => new { e.CertificateCode, e.CreateByOrgCode });

                entity.Property(e => e.CertificateCode).HasComment("รหัสใบรับรองแพทย์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CertificateName).HasComment("ชื่อใบรับรองแพทย์");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทของเอกสาร 1.ใบรับรองแพทย์ 2.ใบส่งตัว");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.ReportName).HasComment("ชื่อรายงาน");
            });

            modelBuilder.Entity<MchequeForm>(entity =>
            {
                entity.HasKey(e => new { e.FormCode, e.CreateByOrgCode });

                entity.Property(e => e.FormCode).HasComment("รหัสฟอร์มเช็ค");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.FormFileName).HasComment("ชื่อ File ของฟอร์มเช็ค");

                entity.Property(e => e.FormName).HasComment("ชื่อฟอร์มเช็ค");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<MclinicCalendar>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.SeqId });

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้ห้องนี้");

                entity.Property(e => e.SeqId).HasComment("ลำดับ");

                entity.Property(e => e.CalendarName)
                    .IsFixedLength(true)
                    .HasComment("ชื่อของปฏิทิน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.FriTimeIn).HasComment("ทำงานวันศุกร เวลาเข้า");

                entity.Property(e => e.FriTimeOut).HasComment("ทำงานวันศุกร เวลาออก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsFriday).HasComment("ทำงานวันศุกร์?");

                entity.Property(e => e.IsMonday).HasComment("ทำงานวันจันทร์?");

                entity.Property(e => e.IsSatday).HasComment("ทำงานวันเสาร์?");

                entity.Property(e => e.IsShowAppointment).HasComment("ใช้กำหนดการแสดงชื่อในการนัดหมาย");

                entity.Property(e => e.IsSunday).HasComment("ทำงานวันอาทิตย์?");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.IsThuday).HasComment("ทำงานวันพฤหัสดี?");

                entity.Property(e => e.IsTueday).HasComment("ทำงานวันอังคาร?");

                entity.Property(e => e.IsWedday).HasComment("ทำงานวันพุธ?");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.MonTimeIn).HasComment("ทำงานวันจันทร์ เวลาเข้า");

                entity.Property(e => e.MonTimeOut).HasComment("ทำงานวันจันทร์ เวลาออก");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SatTimeIn).HasComment("ทำงานวันเสาร เวลาเข้า");

                entity.Property(e => e.SatTimeOut).HasComment("ทำงานวันเสาร เวลาออก");

                entity.Property(e => e.SunTimeIn).HasComment("ทำงานวันอาทิตย์ เวลาเข้า");

                entity.Property(e => e.SunTimeOut).HasComment("ทำงานวันอาทิตย์ เวลาออก");

                entity.Property(e => e.ThuTimeIn).HasComment("ทำงานวันพฤหัสดี เวลาเข้า");

                entity.Property(e => e.ThuTimeOut).HasComment("ทำงานวันพฤหัสดี เวลาออก");

                entity.Property(e => e.TueTimeIn).HasComment("ทำงานวันอังคาร เวลาเข้า");

                entity.Property(e => e.TueTimeOut).HasComment("ทำงานวันอังคาร เวลาออก");

                entity.Property(e => e.WedTimeIn).HasComment(" ทำงานวันพุธ เวลาเข้า");

                entity.Property(e => e.WedTimeOut).HasComment("ทำงานวันพุธ เวลาออก");
            });

            modelBuilder.Entity<MclinicCalendarHoliday>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.SeqId });

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้");

                entity.Property(e => e.SeqId).HasComment("ลำดับของสาขา");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.HolidayNote).HasComment("หมายเหตุวันหยุด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.NoWorkDate).HasComment("วันที่หยุด");

                entity.Property(e => e.NoWorkFromTime).HasComment("เวลาที่หยุดจาก");

                entity.Property(e => e.NoWorkToTime).HasComment("เวลาที่หยุดถึง");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.RecurrenceType).HasComment("ประเภทการเกิดขึ้นอีก 1=ครั้งเดียว 2=ทุกวัน , 3=ทุกสัปดาห์ของเดือน 4=ทุกปี");

                entity.Property(e => e.WeekDate).HasComment("เช่น 1 วันจันทร์  ,2 อังคาร ,11 วันจันทร์สัปดาห์แรก");
            });

            modelBuilder.Entity<MclinicOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กรที่สร้าง");

                entity.Property(e => e.OrganizationCode).HasComment("รหัสองค์กรที่ใช้งาน");

                entity.Property(e => e.AppMinutesInterval).HasComment("ช่วงห่างในแต่ละช่องของตารางนัดหมาย (นาที)");

                entity.Property(e => e.BackupDataPath).HasComment("ที่ตั้งในการสำรองข้อมูล");

                entity.Property(e => e.BackupTypeId).HasComment("ประเภทการสำรองข้อมูล (1 = ทุกวัน 2 = แต่ละสัปดาห์ 3 = ทับที่เดิม)");

                entity.Property(e => e.BarcodeComport).HasComment("Port สำหรับเครื่องอ่าน Barcode");

                entity.Property(e => e.CameraSystemTypeId).HasComment("รูปแบบระบบสำหรับเปิดกล้องเพื่อจับภาพ 1=Twain 2=DirectX");

                entity.Property(e => e.CaseComplaintComPort).HasComment("Port สำหรับความพึงพอใจ");

                entity.Property(e => e.ChargeLateCheckOut).HasComment("คิดค่าใช้จ่าย CheckOut เกินเวลา / ชม.");

                entity.Property(e => e.ClinicCalendarUrl).HasComment("ตั้งค่าลิงค์ เข้า ปฐิทินขิงคลินิก");

                entity.Property(e => e.CloseTime).HasComment("เวลาปิดคลินิก");

                entity.Property(e => e.CoCourseCustomer).HasComment("จำนวนคนที่สามารถใช้ร่วมได้ 1 2 3 4 5");

                entity.Property(e => e.CollectAmountPerPoint).HasComment("ยอดเงินที่จะได้แต้ม");

                entity.Property(e => e.CollectPoint).HasComment("จำนวนแต้มที่จะได้รับ");

                entity.Property(e => e.CostTypeId).HasComment("ปรับราคาต้นทุนแบบ 1 = แทนที่ 2 = เฉลี่ย");

                entity.Property(e => e.CurrentBeginMonth).HasComment("วันที่ต้นงวดประจำเดือน");

                entity.Property(e => e.CurrentBeginYear).HasComment("วันที่ต้นงวดประจำปี");

                entity.Property(e => e.CurrentBuild).HasComment("Build ปัจจุบัน Default format is yyyyMMdd.revision (en-US)");

                entity.Property(e => e.CurrentDate).HasComment("วันที่ปัจจุบัน");

                entity.Property(e => e.DayCareCheckInTime).HasComment("เวลา CheckIn ฝากเลี้ยง (ระหว่างวัน)");

                entity.Property(e => e.DayCareCheckOutTime).HasComment("เวลา CheckOut ฝากเลี้ยง (ระหว่างวัน)");

                entity.Property(e => e.DayNightCheckInTime).HasComment("เวลา CheckIn ฝากเลี้ยง (ระหว่างคืน)");

                entity.Property(e => e.DayNightCheckOutTime).HasComment("เวลา CheckOut ฝากเลี้ยง (ระหว่างคืน)");

                entity.Property(e => e.DigitalPenPath).HasComment("ที่ตั้งโปรแกรม Digital Pen");

                entity.Property(e => e.DoctorName).HasComment("ชื่อแพทย์");

                entity.Property(e => e.ExchangePath).HasComment("สำหรับเก็บพาธที่ตั้งของ exe Exchange");

                entity.Property(e => e.ExpireDateForLabelTypeId).HasComment("ประเภทการดึงข้อมูลวันหมดอายุของยามาแสดงในฉลากยา");

                entity.Property(e => e.ExpireDayReserveAmount).HasComment("จำนวนวันหมดอายุรับมัดจำ");

                entity.Property(e => e.Fdano).HasComment("เลขที่ใบอนุญาต อ.ย.");

                entity.Property(e => e.ImageDirectory).HasComment("สำหรับเก็บไฟล์เอกสารใน Izpal Doc/ Centre II กรณีเก็บภาพแบบไฟล์");

                entity.Property(e => e.ImageVideoPath).HasComment("เก็บ Path แสดงรูปภาพหรือวิดีโอหน้าจอลูกค้า");

                entity.Property(e => e.ImagingPath).HasComment("ที่ตั้งโปรแกรม izpal Imaging");

                entity.Property(e => e.ImagingSourceTypeId).HasComment("สำหรับใช้กับโปรแกรม Izpal.Doc for clinic ว่าเก็บรูปภาพแบบไหน 1=Database, 2=File System");

                entity.Property(e => e.InventoryOrderItemFormId).HasComment("รูปแบบหน้าจอสั่งรายการในระบบคลัง");

                entity.Property(e => e.IsAlertRight).HasComment("แจ้งเตือนให้เลือกสิทธิ์การรักษาทุกครั้ง");

                entity.Property(e => e.IsAllowCancelFingerprint).HasComment("อนุญาตให้ยกเลิกนิ้วหรือไม่");

                entity.Property(e => e.IsAllowCancelQue).HasComment("อนุญาตให้ยกเลิกคิวได้");

                entity.Property(e => e.IsAllowDeleteSalesItem).HasComment("อนุญาติให้ลบรายการที่สั่งได้");

                entity.Property(e => e.IsAllowEditSalesItem).HasComment("อนุญาตให้แก้ไขรายการที่สั่งได้");

                entity.Property(e => e.IsAllowEnterHn).HasComment("สามารถกำหนด HN ได้เอง");

                entity.Property(e => e.IsAllowEnterPackingQuantity).HasComment("อนุญาตให้ใส่จำนวนในการบรรจุหรือไม่");

                entity.Property(e => e.IsAllowManageCourse).HasComment("อนุญาตให้แก้ไขคอร์สคนไข้ได้");

                entity.Property(e => e.IsAllowOrder2SubCoursesPerDay).HasComment("อนุญาตให้ลงคอร์สสองครั้งในหนึ่งวันหรือไม่");

                entity.Property(e => e.IsAllowRemed).HasComment("อนุญาตให้สั่งยาเดิมได้");

                entity.Property(e => e.IsAutoConnectSms).HasComment("เชื่อมต่อรหัสอัตโนมัติหรือไม่");

                entity.Property(e => e.IsAutoOrderSubCourse).HasComment("กำหนดการสั่งคอร์สย่อยให้อัตโนมัติ");

                entity.Property(e => e.IsCalCostWithoutVat).HasComment("การคำนวณต้นทุนจะให้รวมภาษีเข้าไปด้วยหรือไม่");

                entity.Property(e => e.IsCalReserveVat).HasComment("คำนวณภาษีขายกรณีรับมัดจำ");

                entity.Property(e => e.IsCalStockFromBeginning).HasComment("คำนวณยอดคงเหลือจากยอดยกมา");

                entity.Property(e => e.IsCanDebtAmount).HasComment("รูปแบบการกำหนดว่าสามารถค้างชำระได้หรือไม่  0= ได้ 1 = ไม่ได้");

                entity.Property(e => e.IsCheckItemBeforeConfirm).HasComment("ตรวจสอบรายการที่สั่งก่อนยืนยัน");

                entity.Property(e => e.IsCheckOpenAccount).HasComment("ตรวจสอบการเปิด ปิด รอบบญชีหรือไม่");

                entity.Property(e => e.IsConfirmAfterPrintReceipt).HasComment("พิมพ์ใบเสร็จแล้วยืนยันทันที");

                entity.Property(e => e.IsExportDataToIdcwhenReceiveMoney).HasComment("ส่งข้อมูลเข้าศูนย์ข้อมูลเมื่อทำการรับเงิน");

                entity.Property(e => e.IsForceImportPatientData).HasComment("บังคับให้ดึงข้อมูลจากศูนย์ข้อมูล");

                entity.Property(e => e.IsImportDataFromIdcwhenSearchPatient).HasComment("นำเข้าข้อมูลจากศูนย์ข้อมูลเมื่อค้นหาคนไข้");

                entity.Property(e => e.IsMemberCanRedeemPoint).HasComment("โปรแกรม Izpal Member สามารถแลกแต้มจากในโปรแกรมได้หรือไม่");

                entity.Property(e => e.IsMultiCardHolder).HasComment("ลูกค้าสามารถถือบัตรใด้หลายใบ");

                entity.Property(e => e.IsMustPrintReceiptBeforeConfirm).HasComment("ต้องพิมพ์ใบเสร็จก่อนยืนยัน");

                entity.Property(e => e.IsOpenShelfWhenReceive).HasComment("เปิดลิ้นชักเมื่อคลิกรับเงิน");

                entity.Property(e => e.IsOrderItemByName).HasComment("เรียงรายการยาที่สั่ง");

                entity.Property(e => e.IsPayIncentiveWhenCourseComplete).HasComment("จ่ายค่าตอบแทนเมื่อทำคอร์สเสร็จ");

                entity.Property(e => e.IsReplacePurchasePrice).HasComment("แทนที่ราคาซื้อด้วย ราคาที่สั่งซื้อล่าสุด");

                entity.Property(e => e.IsShowCourseWhenSearchPatient).HasComment("แสดงข้อมูลคอร์สเมื่อค้นหาคนไข้");

                entity.Property(e => e.IsShowDoseByItem).HasComment("แสดง Dose เฉพาะของยาแต่ละตัว");

                entity.Property(e => e.IsShowEndDaySummary).HasComment("แสดงหน้าจอสรุปเมื่อปิดรอบบัญชี");

                entity.Property(e => e.IsShowMarkOnNewOrderItem).HasComment("แสดงสีกับรายการที่ยังไม่เคยสั่ง");

                entity.Property(e => e.IsSpecifyXrayImplement).HasComment("ระบุผู้ถ่ายด้วยล๊อกอิน ใน XRayRoom");

                entity.Property(e => e.IsUseOnlineDataSystem).HasComment("เปิดใช้งานระบบข้อมูล Online หรือไม่");

                entity.Property(e => e.IsUsePasswordToDiscount).HasComment("ต้องใส่รหัสผ่านในการลดราคา");

                entity.Property(e => e.IsUsePharmaRoomSystem).HasComment("ใช้งานระบบห้องจัดยา");

                entity.Property(e => e.LabInstrumentTypeId).HasComment("รหัสบริษัทเจ้าของเครื่องมือแล็บ  1=IDEXX");

                entity.Property(e => e.LastMonthEndDate).HasComment("วันที่ปิดรอบเดือน");

                entity.Property(e => e.LineOachatUrl).HasComment("ตั้งค่าลิงค์ เข้า LineOAChatURL");

                entity.Property(e => e.MaxSubCourseNo).HasComment("จำนวนคอร์สย่อยสูงสุด");

                entity.Property(e => e.MedchatAccAuth).HasComment("รหัสบัญชี และให้ในการส่ง API");

                entity.Property(e => e.MedchatApiSecret).HasComment("รหัสสำหรับการสร้างห้องด้วย API");

                entity.Property(e => e.MemberReportEnpath).HasComment("ที่ตั้งรายงานภาษาอังกฤษสำหรับโปรแกรม Izpal Member");

                entity.Property(e => e.MemberReportThpath).HasComment("ที่ตั้งรายงานภาษาไทยสำหรับโปรแกรม Izpal Member ");

                entity.Property(e => e.MinimumReserveAmount).HasComment("ยอดขั้นต่ำรับเงินมัดจำ");

                entity.Property(e => e.OpenTime).HasComment("เวลาเปิดคลินิก");

                entity.Property(e => e.OrderCourseTypeId).HasComment("ใช้เก็บว่าคลินิกนี้การสั่งคอร์สเป็นแบบไหน 1แบบตามสัตว์/ 2แบบตามเจ้าของ (ใช้กับ vet เท่านั้น)");

                entity.Property(e => e.PasswordSms).HasComment("รหัสผ่านเพื่อใช้ส่งข้อความ");

                entity.Property(e => e.PayDebtTypeId).HasComment("1=ชำระค้างเป็นใบ 2=ชำระค้างเป็นรายการ");

                entity.Property(e => e.PointCalculateTypeId).HasComment("รูปแบบการคำนวณแต้ม 1 ให้แต้มตามจริง 2ปัดลง");

                entity.Property(e => e.PointExpireDay).HasComment("จำนวนวันหมดอายุของ Point");

                entity.Property(e => e.PrintAmountForInvoice).HasComment("จำนวนการพิมใบแจ้งหนี้");

                entity.Property(e => e.PrintAmountForReceipt).HasComment("จำนวนสำเนาสำหรับการพิมพ์ใบเสร็จ");

                entity.Property(e => e.PrintAmountForSticker).HasComment("จำนวนที่พิมพ์สติกเกอร์");

                entity.Property(e => e.PrinterForAppointment).HasComment("ชื่อเครื่องพิมพ์ใบนัดหมาย");

                entity.Property(e => e.PrinterForCertificate).HasComment("ชื่อเครื่องพิมพ์ใบรับรองแพทย์");

                entity.Property(e => e.PrinterForInvoice).HasComment("ชื่อเครื่องพิมพ์สำหรับใบแจ้งหนี้");

                entity.Property(e => e.PrinterForLabLabel).HasComment("ชื่อเครืองพิมพ์ฉลากสำหรับ Lab");

                entity.Property(e => e.PrinterForLabel).HasComment("ชื่อเครื่องพิมพ์ฉลากยา");

                entity.Property(e => e.PrinterForOpdcard).HasComment("ชื่อเครื่องพิมพ์ OPD Card");

                entity.Property(e => e.PrinterForOrderDrug).HasComment("ชื่อเครื่องพิมพ์ใบสั่งยา");

                entity.Property(e => e.PrinterForPatientCard).HasComment("ชื่อเครื่องพิมพ์บัตรคนไข้");

                entity.Property(e => e.PrinterForReceipt).HasComment("ชื่อเครื่องพิมพ์สำหรับใบเสร็จ");

                entity.Property(e => e.PrinterForReport).HasComment("ชื่อเครื่องพิมพ์รายงาน");

                entity.Property(e => e.PrinterForSticker).HasComment("ปรื้นสติ๊กเกอร์ HN");

                entity.Property(e => e.ReceiptFormat).HasComment("รูปแบบใบเสร็จรับเงิน");

                entity.Property(e => e.ReceiveMessage).HasComment("ข้อความรับเงิน");

                entity.Property(e => e.RedeemAmountPerPoint).HasComment("จำนวนเงินที่ได้รับจากการแลกแต้ม");

                entity.Property(e => e.RedeemPoint).HasComment("จำนวนแต้มที่ใช้สำหรับการแลก");

                entity.Property(e => e.SalesNetAmountRoundUpCode).HasComment("รูปแบบการปัดเศษ");

                entity.Property(e => e.SalesOrderItemFormId).HasComment("รูปหน้าจอในการสั่งขายสินค้า");

                entity.Property(e => e.ShelfComPort).HasComment("Port สำหรับลิ้นชัก");

                entity.Property(e => e.SmsSenderName).HasComment("ชื่อที่ใช้ส่ง SMS");

                entity.Property(e => e.StockCalDays).HasComment("จำนวนวันที่คำนวณยอดคงเหลือ");

                entity.Property(e => e.StockMaxDays).HasComment("จำนวนวันในการคำนวณยอดสูงสุด");

                entity.Property(e => e.StockMinDays).HasComment("จำนวนวันในการคำนวณยอดต่ำสุด");

                entity.Property(e => e.ThanksMessage).HasComment("ข้อความขอบคุณ");

                entity.Property(e => e.TypeUseMemberCard).HasComment("รูปแบบการใช้งานบัตร  01= แต้มเท่านั้น / 02 = เงินสดเท่านั้น / 03 = ทั้งแต้มและเงิน");

                entity.Property(e => e.UpdateQueTime).HasComment("เวลาในการรีเฟรชคิว (วินาที)");

                entity.Property(e => e.UserNameSms).HasComment("ชื่อผู้ใช้ที่ใช้ส่งข้อความ");

                entity.Property(e => e.VfdcomPort).HasComment("Port สำหรับจอ VFD");

                entity.Property(e => e.WelcomeMessage).HasComment("ข้อความต้อนรับ");
            });

            modelBuilder.Entity<Mcompany>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CreateByOrgCode });

                entity.Property(e => e.CompanyCode).HasComment("รหัสบริษัท");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Address).HasComment("เลขที่/หมู่/ซอย...");

                entity.Property(e => e.AmphurCode).HasComment("รหัสอำเภอ");

                entity.Property(e => e.CompanyName).HasComment("ชื่อบริษัท");

                entity.Property(e => e.CountryCode).HasComment("รหัสประเทศ");

                entity.Property(e => e.Email).HasComment("Email Address");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.MailAddress).HasComment("เลขที่/หมู่/ซอย...");

                entity.Property(e => e.MailAmphurCode).HasComment("รหัสอำเภอ");

                entity.Property(e => e.MailCountryCode).HasComment("รหัสประเทศ");

                entity.Property(e => e.MailPostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.MailProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.MailTumbonCode).HasComment("รหัสตำบล");

                entity.Property(e => e.PostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.ProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.TumbonCode).HasComment("รหัสตำบล");
            });

            modelBuilder.Entity<McompanyMap>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MapId });
            });

            modelBuilder.Entity<Mcontact>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ContactCode });

                entity.Property(e => e.ContactCode).HasComment("รหัสผู้ติดต่อ");

                entity.Property(e => e.Address1).HasComment("ที่อยู่ที่");

                entity.Property(e => e.Address2).HasComment("ที่อยู่");

                entity.Property(e => e.AmphurCode).HasComment("รหัสอำเภอ");

                entity.Property(e => e.CompanyCode).HasComment("รหัสบริษัทที่ทำงาน");

                entity.Property(e => e.ContactGroupCode).HasComment("?");

                entity.Property(e => e.ContactTypeCode).HasComment("รหัสประเภทผู้ติดต่อ");

                entity.Property(e => e.CountryCode).HasComment("รหัสประเทศ");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.JobTitle).HasComment("ตำแหน่ง");

                entity.Property(e => e.LastName).HasComment("สกุล");

                entity.Property(e => e.MailAddress1).HasComment("ที่อยู่ที่");

                entity.Property(e => e.MailAddress2).HasComment("ที่อยู่");

                entity.Property(e => e.MailAmphurCode).HasComment("รหัสอำเภอ");

                entity.Property(e => e.MailCountryCode).HasComment("รหัสประเทศ");

                entity.Property(e => e.MailPostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.MailProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.MailTumbonCode).HasComment("รหัสตำบล");

                entity.Property(e => e.Mobile).HasComment("เบอร์มือถือ");

                entity.Property(e => e.PostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.ProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทร");

                entity.Property(e => e.TitleName).HasComment("รหัสคำนำหน้าชื่อ");

                entity.Property(e => e.TumbonCode).HasComment("รหัสตำบล");
            });

            modelBuilder.Entity<Mcounsellor>(entity =>
            {
                entity.HasKey(e => new { e.CounsellorCode, e.CreateByOrgCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentAddress1).HasComment("ที่อยู่ปัจจุบัน 1");

                entity.Property(e => e.CurrentAddress2).HasComment("ที่อยู่ปัจจุบัน 2");

                entity.Property(e => e.CurrentAmphurCode).HasComment("รหัสอำเภอปัจจุบัน");

                entity.Property(e => e.CurrentAmphurName).HasComment("ชื่ออำเภอปัจจุบัน");

                entity.Property(e => e.CurrentOrgCode).HasComment("รหัสสาขาปัจจุบัน");

                entity.Property(e => e.CurrentPostCode).HasComment("รหัสไปรษณีย์ปัจจุบัน");

                entity.Property(e => e.CurrentProvinceCode).HasComment("รหัสจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentProvinceName).HasComment("ชื่อจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentTumbonCode).HasComment("รหัสตำบลปัจจุบัน");

                entity.Property(e => e.CurrentTumbonName).HasComment("ชื่อตำบลปัจจุบัน");

                entity.Property(e => e.DisplayName).HasComment("ชื่อสำหรับแสดง");

                entity.Property(e => e.Email).HasComment("Email Address");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.LastName).HasComment("นามสกุล");

                entity.Property(e => e.Mobile).HasComment("เบอร์มือถือ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์");
            });

            modelBuilder.Entity<Mcoupon>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CouponId });

                entity.Property(e => e.CouponNo).HasComment("เลขที่คูปอง");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุดการใช้งาน");

                entity.Property(e => e.IsUse).HasComment("เป็น 0 ยังไม่ได้ใช้งาน, เป็น 1 ใช้งานไปแล้ว");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มใช้งานได้");

                entity.Property(e => e.UseDate).HasComment("วันที่ใช้ Coupon");

                entity.Property(e => e.ValueBaht).HasComment("มูลค่าเป็นจำนวนเงิน");

                entity.Property(e => e.ValuePercent).HasComment("มูลค่าเป็นเปอร์เซ็นต์");
            });

            modelBuilder.Entity<McreditCard>(entity =>
            {
                entity.HasKey(e => new { e.CreditCardCode, e.CreateByOrgCode });

                entity.Property(e => e.CreditCardCode).HasComment("รหัสเครดิตการ์ด");

                entity.Property(e => e.CreditCardName).HasComment("ชื่อเครดิตการ์ด");

                entity.Property(e => e.FeeRate).HasComment("ิอัตราค่าธรรมเนียม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.VatRate).HasComment("ิอัตราภาษีมูลค่าเพิ่ม");
            });

            modelBuilder.Entity<Mcrmoption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });
            });

            modelBuilder.Entity<McustomFieldTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateTypeId });

                entity.Property(e => e.TemplateTypeId).HasComment("1=Item, 2=Customer, 3=Animal");

                entity.Property(e => e.CustomOrder1).HasComment("ลำดับข้อมูลที่ 1");

                entity.Property(e => e.CustomOrder10).HasComment("ลำดับข้อมูลที่ 10");

                entity.Property(e => e.CustomOrder2).HasComment("ลำดับข้อมูลที่ 2");

                entity.Property(e => e.CustomOrder3).HasComment("ลำดับข้อมูลที่ 3");

                entity.Property(e => e.CustomOrder4).HasComment("ลำดับข้อมูลที่ 4");

                entity.Property(e => e.CustomOrder5).HasComment("ลำดับข้อมูลที่ 5");

                entity.Property(e => e.CustomOrder6).HasComment("ลำดับข้อมูลที่ 6");

                entity.Property(e => e.CustomOrder7).HasComment("ลำดับข้อมูลที่ 7");

                entity.Property(e => e.CustomOrder8).HasComment("ลำดับข้อมูลที่ 8");

                entity.Property(e => e.CustomOrder9).HasComment("ลำดับข้อมูลที่ 9");
            });

            modelBuilder.Entity<Mcustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGid, e.CreateByOrgCode });

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AccountCode).HasComment("รหัสผังบัญชี");

                entity.Property(e => e.AgencyCode).HasComment("รหัสตัวแทน Agency");

                entity.Property(e => e.AreaCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.BirthDate).HasComment("วันเกิด");

                entity.Property(e => e.BirthDateText).HasComment("วันเกิดรูปแบบ Text");

                entity.Property(e => e.BloodGroup).HasComment("กลุ่มเลือด");

                entity.Property(e => e.CompanyName).HasComment("ชื่อบริษัท");

                entity.Property(e => e.ContactMobile).HasComment("เบอร์มือถือผู้ติดต่อ");

                entity.Property(e => e.ContactName).HasComment("ชื่อผู้ติดต่อ");

                entity.Property(e => e.ContactPhone).HasComment("เบอร์โทรศัพท์ผู้ติดต่อ");

                entity.Property(e => e.CounsellorCode).HasComment("รหัสผู้ดูแล");

                entity.Property(e => e.CounsellorNote).HasComment("หมายเหตุผู้แนะนำ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง Record");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง Record");

                entity.Property(e => e.Credit).HasComment("เครดิตที่ให้");

                entity.Property(e => e.CreditAmount).HasComment("จำนวนเงินที่ให้เครดิต");

                entity.Property(e => e.CreditTerm).HasComment("จำนวนวันที่ให้เครดิต");

                entity.Property(e => e.CurrentAddress1).HasComment("ที่อยู่ปัจจุบัน 1");

                entity.Property(e => e.CurrentAddress2).HasComment("ที่อยู่ปัจจุบัน 2");

                entity.Property(e => e.CurrentAmphurCode).HasComment("รหัสอำเภอปัจจุบัน");

                entity.Property(e => e.CurrentAmphurName).HasComment("ชื่ออำเภอปัจจุบัน");

                entity.Property(e => e.CurrentCountryCode).HasComment("รหัสประเทศปัจจุบัน");

                entity.Property(e => e.CurrentPoint).HasComment("ยอดแต้มสะสมปัจจุบัน");

                entity.Property(e => e.CurrentPostCode).HasComment("รหัสไปรษณีย์ปัจจุบัน");

                entity.Property(e => e.CurrentProvinceCode).HasComment("รหัสจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentProvinceName).HasComment("ชื่อจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentTelephone).HasComment("เบอร์โทรศัพท์ปัจจุบัน");

                entity.Property(e => e.CurrentTumbonCode).HasComment("รหัสตำบลปัจจุบัน");

                entity.Property(e => e.CurrentTumbonName).HasComment("ชื่อตำบลปัจจุบัน");

                entity.Property(e => e.CustomerCode).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CustomerMap).HasComment("แผนที่ลูกค้า");

                entity.Property(e => e.CustomerTypeCode).HasComment("รหัสประเภทลูกค้า");

                entity.Property(e => e.CustomerTypeId).HasComment("ประเภทลูกค้า 1=ผู้ป่วย, 2=หน่วยงาน/บริษัท, 3=สำหนักงานใหญ่, 4=สาขาย่อย");

                entity.Property(e => e.DeadDate).HasComment("วันที่เสียชีวิต");

                entity.Property(e => e.DebtTypeId).HasComment("รหัสสิทธิ์ในการค้างชำระ");

                entity.Property(e => e.DefaultLanguage)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ภาษาที่ใช้ในการพิมพ์เอกสาร");

                entity.Property(e => e.DepartmentName).HasComment("ชื่อแผนก");

                entity.Property(e => e.DiscountText).HasComment("ส่วนลดที่ให้");

                entity.Property(e => e.DrCode).HasComment("รหัสแพทย์ประจำตัว");

                entity.Property(e => e.Email).HasComment("Email Address");

                entity.Property(e => e.FatherName).HasComment("ชื่อบิดา");

                entity.Property(e => e.FatherPhone).HasComment("เบอร์โทรบิดา");

                entity.Property(e => e.Fax).HasComment("เบอร์แฟกซ์");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.FirstName2).HasComment("ชื่อที่ 2 (อังกฤษ)");

                entity.Property(e => e.FoodAllergy).HasComment("แพ้อาหาร");

                entity.Property(e => e.Height).HasComment("ส่วนสุง");

                entity.Property(e => e.HospialName).HasComment("โรงพยาบาลที่ติดต่อ");

                entity.Property(e => e.HospialTelephone).HasComment("เบอร์โทรของโรงพยาบาลที่ติดต่อ");

                entity.Property(e => e.IdCardAmphurCode).HasComment("รหัสอำเภอตามบัตร ปชช");

                entity.Property(e => e.IdcardAddress1).HasComment("ที่อยู่ตามบัตร ปชช 1");

                entity.Property(e => e.IdcardAddress2).HasComment("ที่อยู่ตามบัตร ปชช 2");

                entity.Property(e => e.IdcardAmphurName).HasComment("ชื่ออำเภอตามบัตร ปชช");

                entity.Property(e => e.IdcardCountryCode).HasComment("รหัสประเทศตามบัตร ปชช");

                entity.Property(e => e.IdcardExpireDate).HasComment("วันที่บัตรประชาชนหมดอายุ");

                entity.Property(e => e.IdcardNo).HasComment("เลขที่บัตรประชาชน/เลขที่ประจำตัวผู้เสียภาษี");

                entity.Property(e => e.IdcardPostCode).HasComment("รหัสไปรษณีย์ตามยบัตร ปชช");

                entity.Property(e => e.IdcardProvinceCode).HasComment("รหัสจังหวัดตามบัตร ปชช");

                entity.Property(e => e.IdcardProvinceName).HasComment("ชื่อจังหวัดตามบัตร ปชช");

                entity.Property(e => e.IdcardTumbonCode).HasComment("รหัสตำบลตามบัตร ปชช");

                entity.Property(e => e.IdcardTumbonName).HasComment("ชื่อตำบลตามบัตร ปชช");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IndustryCode).HasComment("รหัสประเภทอุตสาหกรรม");

                entity.Property(e => e.IsDead).HasComment("สถานะการเสียชีวิต");

                entity.Property(e => e.IsFingerPrintScan).HasComment("ลงทะเบียนนิ้วมือหรือยัง");

                entity.Property(e => e.IsLock).HasComment("ถูก Lock หรือไม่");

                entity.Property(e => e.IsLockByIzpalMember).HasComment("เก็บค่าว่ามีการเรียกใช้ที่โปรแกรม Izpal Member");

                entity.Property(e => e.IsMarketingConsent).HasComment("การยินยอมให้ติดต่อทางการตลาด 1=  Accept, 2= Reject");

                entity.Property(e => e.IsOldPatient).HasComment("คนไข้เดิม/คนไข้ใหม่");

                entity.Property(e => e.IsPrintMailLabel).HasComment("พิมพ์ซองจดหมายหรือไม่");

                entity.Property(e => e.IsRealBirthDate).HasComment("เป็นวันเกิดจริงหรือไม่");

                entity.Property(e => e.IsSelfsick).HasComment("มีโรคประจำตัว");

                entity.Property(e => e.IsSideEffect).HasComment("มีการแพ้ยาหรือไม่");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.LastName).HasComment("นามสกุล");

                entity.Property(e => e.LastName2).HasComment("นามสกุลที่ 2 (อังกฤษ)");

                entity.Property(e => e.LastSyncDate).HasComment("วันที่ล่าสุดในการ Sync  ข้อมูล");

                entity.Property(e => e.LastVisitDate).HasComment("วันที่มาล่าสุด");

                entity.Property(e => e.MaritalStatusCode).HasComment("รหัสสถานะภาพการสมรส");

                entity.Property(e => e.MemberGid).HasComment("เลขบัตร RFID");

                entity.Property(e => e.MemberId).HasComment("เลขที่สมาชิก");

                entity.Property(e => e.MiddleName).HasComment("ชื่อกลาง");

                entity.Property(e => e.MiddleName2).HasComment("ชื่อกลางที่ 2 (อังกฤษ)");

                entity.Property(e => e.Mobile).HasComment("เบอร์โทรศัพท์มือถือ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไขล่าสุด");

                entity.Property(e => e.ModByOrgCode).HasComment("องค์กรที่แก้ไขข้อมูล");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.MotherName).HasComment("ชื่อมารดา");

                entity.Property(e => e.MotherPhone).HasComment("เบอร์โทรมารดา");

                entity.Property(e => e.NationCode).HasComment("รหัสสัญชาติ");

                entity.Property(e => e.NickName).HasComment("ชื่อเล่น");

                entity.Property(e => e.OccupationCode).HasComment("รหัสอาชีพ");

                entity.Property(e => e.OccupationName).HasComment("ชื่ออาชีพ");

                entity.Property(e => e.OtherAllergy).HasComment("แพ้อื่นๆ");

                entity.Property(e => e.OtherIdcardNo).HasComment("เลขที่บัตรอื่นๆ");

                entity.Property(e => e.OtherIdtype).HasComment("ประเภทบัตรอื่นๆ");

                entity.Property(e => e.OtherSideEffect).HasComment("แพ้อื่นๆ");

                entity.Property(e => e.PatientIndex).HasComment("รหัสผู้ป่วย");

                entity.Property(e => e.PayerAddress).HasComment("ที่อยู่ของผู้จ่ายแทน");

                entity.Property(e => e.PayerContactMobile).HasComment("เบอร์มือถือของผู้จ่ายแทน");

                entity.Property(e => e.PayerName).HasComment("ชื่อผู้จ่ายแทน");

                entity.Property(e => e.PayerTaxIdcardNo).HasComment("เลขที่บัตรหรือผู้เสียภาษีของผู้จ่ายแทน");

                entity.Property(e => e.PayerZipCode).HasComment("รหัสไปรษณีย์ของผู้จ่ายแทน");

                entity.Property(e => e.PaymentTerm).HasComment("เงื่่อนไขการชำระเงิน");

                entity.Property(e => e.PolicyNotice).HasComment("ข้อตกลงความเป็นส่วนตัว 0=No Response, 1=  Accept, 2= Reject");

                entity.Property(e => e.PriceLevelCode).HasComment("ระดับราคาที่ใช้");

                entity.Property(e => e.RaceCode).HasComment("รหัสเชื้อชาติ");

                entity.Property(e => e.ReceiptCode).HasComment("รหัสประเภทใบเสร็จรับเงิน");

                entity.Property(e => e.ReligionCode).HasComment("รหัสศาสนา");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.RemarkIsLock).HasComment("สำหรับเก็บ MacAddress เครื่องที่ Lock");

                entity.Property(e => e.ReserveAmount).HasComment("ยอดเงินมัดจำ");

                entity.Property(e => e.SalesBranch).HasComment("สาขาที่ขาย");

                entity.Property(e => e.SalesCode).HasComment("รหัสพนักงานขาย");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("เพศ M:ชาย F:หญิง");

                entity.Property(e => e.ShipAddress1).HasComment("ที่จัดส่ง 1");

                entity.Property(e => e.ShipAddress2).HasComment("ที่จัดส่ง 2");

                entity.Property(e => e.ShipAmphurCode).HasComment("รหัสอำเภอที่จัดส่ง");

                entity.Property(e => e.ShipAmphurName).HasComment("ชื่ออำเภอที่จัดส่ง");

                entity.Property(e => e.ShipCountryCode).HasComment("รหัสประเทศที่จัดส่ง");

                entity.Property(e => e.ShipMobile).HasComment("เบอร์มือถือที่จัดส่ง");

                entity.Property(e => e.ShipPostCode).HasComment("รหัสไปรษณีย์ที่จัดส่ง");

                entity.Property(e => e.ShipProvinceCode).HasComment("รหัสจังหวัดที่จัดส่ง");

                entity.Property(e => e.ShipProvinceName).HasComment("ชื่อจังหวัดที่จัดส่ง");

                entity.Property(e => e.ShipTelephone).HasComment("เบอร์โทรศัพท์ที่จัดส่ง");

                entity.Property(e => e.ShipTumbonCode).HasComment("รหัสตำบลที่จัดส่ง");

                entity.Property(e => e.ShipTumbonName).HasComment("ชื่อตำบลที่จัดส่ง");

                entity.Property(e => e.SpecialDrNote).HasComment("หมายเหตุแพทย์พิเศษ");

                entity.Property(e => e.SpouseName).HasComment("ชื่อสามี ภรรยา คู่สมรส");

                entity.Property(e => e.TaxCompanyNo).HasComment("เลขที่ภาษี [ตามบริษัท] ");

                entity.Property(e => e.TaxIdcardNo).HasComment("เลขที่ผู้เสียภาษี");

                entity.Property(e => e.TaxOrgCode).HasComment("รหัสสาขา (เพื่อการออกภาษี)");

                entity.Property(e => e.TaxOrgName).HasComment("ชื่อสาขา (เพื่อการออกภาษี)");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.TitleName).HasComment("คำนำหน้าชื่อ");

                entity.Property(e => e.TitleName2).HasComment("คำนำหน้าชื่อ อังกฤษ");

                entity.Property(e => e.TransportTypeCode).HasComment("รหัสประเภทการขนส่ง");

                entity.Property(e => e.Website).HasComment("Website");

                entity.Property(e => e.Weight).HasComment("น้ำหนัก, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.WorkAddress1).HasComment("ที่ทำงาน 1");

                entity.Property(e => e.WorkAddress2).HasComment("ที่ทำงาน 2");

                entity.Property(e => e.WorkAmphurCode).HasComment("รหัสอำเภอที่ทำงาน");

                entity.Property(e => e.WorkAmphurName).HasComment("ชื่ออำเภอที่ทำงาน");

                entity.Property(e => e.WorkCountryCode).HasComment("รหัสประเทศที่ทำงาน");

                entity.Property(e => e.WorkPostCode).HasComment("รหัสไปรษณีย์ที่ทำงาน");

                entity.Property(e => e.WorkProvinceCode).HasComment("รหัสจังหวัดที่ทำงาน");

                entity.Property(e => e.WorkProvinceName).HasComment("ชื่อจังหวัดที่ทำงาน");

                entity.Property(e => e.WorkTelephone).HasComment("เบอร์โทรศัพท์ทีทำงาน");

                entity.Property(e => e.WorkTumbonCode).HasComment("รหัสตำบลที่ทำงาน");

                entity.Property(e => e.WorkTumbonName).HasComment("ชื่อตำบลที่ทำงาน");
            });

            modelBuilder.Entity<McustomerCommunicationPrefer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGid, e.CreateByOrgCode });

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CommunicationPrefNo)
                    .ValueGeneratedOnAdd()
                    .HasComment("เลขที่รันนิ่งของช่องทางที่ยินยอมให้ติดต่อ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง Record");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง Record");

                entity.Property(e => e.IsEmail).HasComment("0= ไม่ยินยอมส่ง Email ,1= ยินยอมส่ง Email");

                entity.Property(e => e.IsFacebook).HasComment("0= ไม่ยินยอมส่ง Facebook ,1= ยินยอมส่ง Facebook");

                entity.Property(e => e.IsLine).HasComment("0= ไม่ยินยอมส่ง Line ,1= ยินยอมส่ง Line");

                entity.Property(e => e.IsSms).HasComment("0= ไม่ยินยอมส่ง SMS ,1= ยินยอมส่ง SMS");

                entity.Property(e => e.IsTelephone).HasComment("0= ไม่ยินยอมส่ง Telephone ,1= ยินยอมส่ง Telephone");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไขล่าสุด");

                entity.Property(e => e.ModByOrgCode).HasComment("องค์กรที่แก้ไขข้อมูล");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.ReceiveBookingEmail).HasComment("ส่งยืนยัน Email ทันที");

                entity.Property(e => e.ReceiveBookingFacebook).HasComment("ส่งยืนยัน Facebook ทันที");

                entity.Property(e => e.ReceiveBookingLine).HasComment("ส่งยืนยัน Line ทันที");

                entity.Property(e => e.ReceiveBookingSms).HasComment("ส่งยืนยัน SMS ทันที");

                entity.Property(e => e.ReceiveBookingTelephone).HasComment("ส่งยืนยัน Telephone ทันที");
            });

            modelBuilder.Entity<McustomerContact>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerGid, e.CustomerContactGid });

                entity.Property(e => e.CustomerGid).HasComment("รหัสออโต้ของลูกค้า");

                entity.Property(e => e.CustomerContactGid).HasComment("รหัสออโต้ของผู้ติดต่อ");
            });

            modelBuilder.Entity<McustomerCustomField>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGid, e.CreateByOrgCode });

                entity.Property(e => e.CompetitorCode).HasComment("เคยใช้บริการคู่แข่งใครบ้าง");

                entity.Property(e => e.DegreeCode).HasComment("ระดับการศึกษา");

                entity.Property(e => e.IncomeLevelCode).HasComment("ระดับรายได้");
            });

            modelBuilder.Entity<McustomerImage>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGid, e.CreateByOrgCode, e.ImageTypeId });

                entity.Property(e => e.CustomerGid).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ImageTypeId).HasComment("1-รูปคนไข้, 2-ลายเซ็นต์คนไข้");
            });

            modelBuilder.Entity<McustomerMember>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CardCode, e.CustomerGid });

                entity.Property(e => e.CardCode).HasComment("รหัสบัตร");

                entity.Property(e => e.BeginDate).HasComment("วันเริ่มทำบัตร");

                entity.Property(e => e.CardTypeCode).HasComment("รหัสประเภทบัตร");

                entity.Property(e => e.ExpireDate).HasComment("วันหมดอายุบัตร");

                entity.Property(e => e.MoneyBalance).HasComment("จำนวนเงินคงเหลือ");

                entity.Property(e => e.PointBalance).HasComment("จำนวนแต้มคงเหลือ");
            });

            modelBuilder.Entity<McustomerRelation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CustomerRelationGid });
            });

            modelBuilder.Entity<McustomerRight>(entity =>
            {
                entity.HasKey(e => new { e.RightCode, e.CreateByOrgCode });

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ArCode).HasComment("รหัสลูกหนี้ บริษัท/หน่วยงาน");

                entity.Property(e => e.CashRate).HasComment("อัตราเงินสด");

                entity.Property(e => e.ClaimRate).HasComment("อัตราส่งเบิก");

                entity.Property(e => e.Contract).HasComment("เงื่อนไขสัญญาการใช้้สิทธิ์");

                entity.Property(e => e.CreditTypeId).HasComment("ประเภทวงเงิน 1=ต่อครั้ง 2=สะสม");

                entity.Property(e => e.DiscountBaht).HasComment("ส่วนลดเป็นบาท");

                entity.Property(e => e.DiscountRate).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountTypeId).HasComment("ประเภทการลด 1: แบบ% 2 :ลดแบบคงที่");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsCheckCredit).HasComment("ตรวจสอบวงเงิน");

                entity.Property(e => e.IsCheckCreditLine).HasComment("ตรวจสอบจำนวนเงินเครดิตที่เหลือหรือไม่");

                entity.Property(e => e.IsDefaultRight).HasComment("สิทธิ์ที่ใช้ได้ทุกคน(ไม่ต้องไปผูกกับคน)");

                entity.Property(e => e.IsMain).HasComment("เป็นสิทธิ์หลัก");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.LastRunningNo).HasComment("เลขที่เอกสารล่าสุด");

                entity.Property(e => e.Remark).HasComment("หมายเหต/เงื่อนไขการใช้");

                entity.Property(e => e.ReportFileName).HasComment("ชื่อฟอร์มรายงาน");

                entity.Property(e => e.RightTypeId).HasComment("เป็นประเภทสิทธิ์ 0,null ทั่วไป,1=ประกันสังคม 2=พรบ, 3=30บาท, 4=สิทธิราชการ");

                entity.Property(e => e.RunningNoFormat).HasComment("รูปแบบเลขที่เอกสาร");

                entity.Property(e => e.ShowColor).HasComment("สีประจำสิทธิ์");

                entity.Property(e => e.ShowTypeId).HasComment("ประเภทการแสดงในใบเสร็จ");
            });

            modelBuilder.Entity<McustomerType>(entity =>
            {
                entity.HasKey(e => new { e.CustomerTypeCode, e.CreateByOrgCode });

                entity.Property(e => e.CustomerTypeCode).HasComment("รหัสประเภทลูกค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CustomerTypeName).HasComment("ชื่อประเภท");

                entity.Property(e => e.CustomerTypeName2).HasComment("ชื่อประเภท 2");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละประเภทลูกค้า(ไม่ควรซ้ำกัน)");

                entity.Property(e => e.ShowColor).HasComment("สีประจำประเภท");
            });

            modelBuilder.Entity<MdataTransferFieldTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.FieldTemplateId });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.FieldTemplateId).HasComment("Running No ของ FieldTemplate");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.FieldDisplay).HasComment("ชื่อฟิลด์สำหรับแสดงให้ผู้ใช้");

                entity.Property(e => e.FieldGroupType).HasComment("ประเภทกลุ่มข้อมูลในการส่งออก เช่น BANK , SOCIAL , ALL , CUSTOM ฯลฯ");

                entity.Property(e => e.FieldName).HasComment("ชื่อฟิลด์ในฐานข้อมูล");

                entity.Property(e => e.FieldOrder).HasComment("ลำดับในการแสดงผล");

                entity.Property(e => e.FieldType).HasComment("ชนิดของฟิลด์ DateTime , Number , String");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.TableName).HasComment("ชื่อตารางที่จะดึงข้อมูล (บางทีชื่อฟิลด์เดียวกันแต่อาจมีหลายตาราง)");
            });

            modelBuilder.Entity<MdataTransferFormat>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TransferFormatId });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.TransferFormatId).HasComment("รหัส Running No ของ Record");

                entity.Property(e => e.CharPadding).HasComment("ตัวอักษรที่ใช้สำหรับเติมให้ครบตามความยาว ถ้าเป็น STRING จะเติมต่อท้าย ถ้าเป็น NUMBER จะเติมด้านหน้า");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.DateFormat).HasComment("รูปแบบ Format ของวันที่ (ตาม VB)");

                entity.Property(e => e.DecimalPlace).HasComment("จำนวนทศนิยม (เฉพาะ NUMBER)");

                entity.Property(e => e.FieldsAlias).HasComment("ชื่อฟิลด์สำหรับแสดง");

                entity.Property(e => e.FieldsDataType).HasComment("ประเภทข้อมูลที่อยู่ใน Field เช่น DATETIME, NUMBER , STRING");

                entity.Property(e => e.FieldsName).HasComment("ชื่อฟิลด์ใน DB");

                entity.Property(e => e.FieldsOrder).HasComment("ลำดับในการแสดงผล");

                entity.Property(e => e.FieldsSection).HasComment("Section ของ Field เช่น Header , Detail , Footer");

                entity.Property(e => e.FieldsType).HasComment("ประเภทที่มาของฟิลด์ DB, FORMULA, FIXEDWORD, COMPANYINFO");

                entity.Property(e => e.IsFixLen).HasComment("ข้อมูลที่จะส่งออก FixLen หรือไม่?");

                entity.Property(e => e.IsNewLineAfter).HasComment("ให้ขึ้นบรรทัดใหม่หลังสิ้นสุดข้อมูลหรือไม่?");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.LenValue).HasComment("จำนวนความยาวที่จะส่งออก (เฉพาะ STRING)");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.PostFix).HasComment("ข้อความตามหลังฟิลด์(จะไม่นับรวมกับ LenValue)");

                entity.Property(e => e.PreFix).HasComment("ข้อความนำหน้าฟิลด์(จะไม่นับรวมกับ LenValue)");

                entity.Property(e => e.ThousandSeprator).HasComment("ตัวอักษรขั้นหลักพัน");

                entity.Property(e => e.TransferNameCode).HasComment("รหัส MDataTransferName");

                entity.Property(e => e.WhereCriteria).HasComment("ค่าสำหรับนำไปทำเป็นเงื่อนไขสำหรับ Query ข้อมูลของ Field นี้");
            });

            modelBuilder.Entity<MdataTransferName>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TransferNameCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.TransferNameCode).HasComment("รหัสรูปแบบการส่งออก");

                entity.Property(e => e.CharCrop4DateTime).HasComment("อักขระคร่อมวันเวลา");

                entity.Property(e => e.CharCrop4Number).HasComment("อักขระคร่อมตัวเลข");

                entity.Property(e => e.CharCrop4String).HasComment("อักขระคร่อมข้อความ");

                entity.Property(e => e.CharFieldsSeparate).HasComment("อักขระขั้นฟิลด์");

                entity.Property(e => e.CharRecordSeparate).HasComment("อักขระขั้นระเบียน");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.ExportFileName).HasComment("ชื่อไฟล์ที่จะ Export");

                entity.Property(e => e.ExportFolderName).HasComment("โฟล์เดอร์ที่จะเก็บไฟล์ Export");

                entity.Property(e => e.IsIncludeLeadingFileNameWithDateTime).HasComment("ให้แทรกวันเวลาไว้ที่หน้าชื่อไฟล์ที่จะ Export หรือไม่");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.OrderPart).HasComment("ลำดับการเรียงข้อมูล");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.TransferName).HasComment("ชื่อรูปแบบการส่งออก");

                entity.Property(e => e.TransferTypeCode).HasComment("ประเภทการส่งออกเช่น BANK , SOCIAL etc");
            });

            modelBuilder.Entity<MdataTransferType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TransferTypeCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.TransferTypeCode).HasComment("รหัสรูปแบบการส่งออกเช่น ส่งออกสำหรับธนาคาร , ส่งออกสำหรับประกันสังคม , ส่งออกอื่นๆ ทั่วไป ฯลฯ");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.FixedWherePart).HasComment("เงื่อนไขที่ Fix ไว้สำหรับค้นหาข้อมูล (สำหรับโปรแกรมใช้งาน)");

                entity.Property(e => e.FromPart).HasComment("คิวรี่ การ Join ตารางหลายตารางสำหรับการส่งออกแต่ละประเภท");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");
            });

            modelBuilder.Entity<MdatabaseConnection>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.ConnectionTypeId).HasComment("รหัสประเภทการเชื่อมต่อ");

                entity.Property(e => e.HostAddress).HasComment("ที่อยู่ Host หรือ Host Name");

                entity.Property(e => e.HostTypeId).HasComment("รูปแบบของฐานข้อมูล เช่น MSSQL, MySql, Access etc.");
            });

            modelBuilder.Entity<Mdeligent>(entity =>
            {
                entity.HasKey(e => new { e.DeligentCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<Mdepartment>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DepartmentCode });

                entity.Property(e => e.DepartmentTypeId).HasComment("1=รักษา 2=ฝากเลี้ยง");

                entity.Property(e => e.Distance).HasComment("ระยะทางจากสาขาใหญ่ไปสาขานั้นๆ");

                entity.Property(e => e.SectionCode).HasComment("รหัสฝ่าย");
            });

            modelBuilder.Entity<MdiscountType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DiscountTypeCode });
            });

            modelBuilder.Entity<MdocGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocGroupCode });

                entity.Property(e => e.InActive).HasComment("1=ไม่ใช้งาน");

                entity.Property(e => e.IsDefaultGroup).HasComment("เป็นกลุ่มที่จะถูกเลือกบันทึกเป็นกลุ่มแรก ถ้าไม่ได้เลือกกลุ่ม");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละกลุ่มเอกสาร(ไม่ควรซ้ำกัน)");

                entity.Property(e => e.ProgramTypeId).HasComment("1=ทั่วไป 2=การแพทย์");
            });

            modelBuilder.Entity<MdocOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });

                entity.Property(e => e.OrganizationCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.ProgramPath).HasComment("ที่ตั้งโปรแกรม");

                entity.Property(e => e.ProgramTypeId).HasComment("1= เอกสาร 2 = คนไข้");

                entity.Property(e => e.ResizeTypeId).HasComment("ขนาดในการ resize ภาพ (0-NotResize, 1-25%, 2-50%, 3-75%)");
            });

            modelBuilder.Entity<MdocType>(entity =>
            {
                entity.HasKey(e => new { e.DocTypeCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<MdoctorNote>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DoctorNoteId });

                entity.Property(e => e.DoctorNoteId).HasComment("เลขที่ Running");

                entity.Property(e => e.DoctorCode).HasComment("รหัสแพทย์เจ้าของ Note");

                entity.Property(e => e.DoctorNote).HasComment("ข้อความใน Note");
            });

            modelBuilder.Entity<Mdocument>(entity =>
            {
                entity.HasKey(e => e.ReferenceIndex)
                    .HasName("PK_MDocument_1");

                entity.Property(e => e.AutoResetTypeId).HasComment("ประเภทการ Reset 1=วัน \n2=เดือน\n 3=ปี");

                entity.Property(e => e.DocTypeId).HasComment("รหัสประเภทข้อมูล เช่น ลูกค้า สินค้า สินทรัพย์ฐาวร");

                entity.Property(e => e.FormatId1).HasComment("0=ไม่ระบุ, 1=เดือน(ํํMM), 2=ปี(YY)");

                entity.Property(e => e.FormatId2).HasComment("0=ไม่ระบุ, 1=เดือน(ํํMM), 2=ปี(YY)");

                entity.Property(e => e.FormatText).HasComment("รูปแบบ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.LastAutoResetDate).HasComment("วันที่มีการ Reset ล่าสุด");

                entity.Property(e => e.LastRunningNo).HasComment("เลขที่ running ล่าสุด");

                entity.Property(e => e.Prefix).HasComment("อักษรนำรหัสข้อมูล");

                entity.Property(e => e.StartRunningNo).HasComment("เลขที่ running เริ่มต้น");
            });

            modelBuilder.Entity<Mdose1>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode });

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<Mdose2>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode })
                    .HasName("PK_MDose2_1");

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<Mdose3>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode })
                    .HasName("PK_MDose3_1");

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<Mdose4>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode })
                    .HasName("PK_MDose4_1");

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<Mdose5>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode });

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<Mdose6>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode, e.LanguageCode });

                entity.Property(e => e.DoseCode).HasComment("รหัสวิธีใช้");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.LanguageCode).HasComment("รหัสรูปแบบภาษา");

                entity.Property(e => e.DoseName).HasComment("วิธีใช้ภาษาไทย");

                entity.Property(e => e.DoseName2).HasComment("วิธีใช้ภาษาอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");
            });

            modelBuilder.Entity<MdoseShortcut>(entity =>
            {
                entity.HasKey(e => new { e.DoseCode, e.CreateByOrgCode });

                entity.Property(e => e.DoseCode).HasComment("รหัสวิิธีใช้ย่อ");

                entity.Property(e => e.Dose1Code).HasComment("รหัสวิธีใช้ 1 ");

                entity.Property(e => e.Dose2Code).HasComment("รหัสวิธีใช้ 2");

                entity.Property(e => e.Dose3Code).HasComment("รหัสวิธีใช้ 3");

                entity.Property(e => e.Dose4Code).HasComment("รหัสวิธีใช้ 4");

                entity.Property(e => e.Dose5Code).HasComment("รหัสวิธีใช้ 5");

                entity.Property(e => e.Dose6Code).HasComment("รหัสวิธีใช้ 6");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<MeetingExpense>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MeetingCode, e.SeqId })
                    .HasName("PK_MeetingJoin");

                entity.Property(e => e.ExpenseAmount).HasComment("จำนวนเงิน");

                entity.Property(e => e.ExpenseName).HasComment("ค่าใช้จ่าย");
            });

            modelBuilder.Entity<MeetingJoin>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MeetingCode, e.SeqId })
                    .HasName("PK_MeetingJoin_1");
            });

            modelBuilder.Entity<MeetingSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MeetingCode, e.SeqId });

                entity.Property(e => e.FromTime).HasComment("ตั้งแต่เวลา");

                entity.Property(e => e.MeetingByName).HasComment("วิทยากร");

                entity.Property(e => e.MeetingDate).HasComment("วันที่สัมนา");

                entity.Property(e => e.ToTime).HasComment("ถึงเวลา");

                entity.Property(e => e.Topic).HasComment("เรื่องที่สัมนา");
            });

            modelBuilder.Entity<MeetingStaff>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MeetingCode, e.SeqId });
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.CreateByOrgCode, e.CustomerGid, e.AnimalGid })
                    .HasName("PK_Message_1");

                entity.Property(e => e.AccessLineTypeId).HasComment("ประเภท Notify 1=ความเห็นการเข้าพัก(Vetsor), 2=บันทึกการเสียชีวิต(Vetsor), 3=สรุปรายได้ประจำวัน");

                entity.Property(e => e.AnimalName).HasComment("ชื่อสัตว์ป่วย");

                entity.Property(e => e.AppDate).HasComment("วันที่และเวลาเริ่มนัดหมาย");

                entity.Property(e => e.AppRemark).HasComment("หมายเหตุการนัดหมาย");

                entity.Property(e => e.AppToDate).HasComment("วันที่และเวลาสิ้นสุดนัดหมาย");

                entity.Property(e => e.Attach).IsFixedLength(true);

                entity.Property(e => e.BirthDate).HasComment("วันเกิด");

                entity.Property(e => e.DataTypeId).HasComment("Null,0,1 = SMS -- 2 = LINE");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.IsAppDate).HasComment("ส่งเพื่อนัดหมาย");

                entity.Property(e => e.IsBirthDate).HasComment("เป็นการนัดหมายตามวันเกิดหรือไม่");

                entity.Property(e => e.IsVaccine).HasComment("นัดหมายเพื่อทำวัคซีน");

                entity.Property(e => e.LastName).HasComment("สกุล");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SendStatus).HasComment("สถานะการส่งข้อความ");

                entity.Property(e => e.VaccineDate).HasComment("วันที่นัดทำวัคซีน");

                entity.Property(e => e.VaccineName).HasComment("ชื่อวัคซีน");
            });

            modelBuilder.Entity<MessageHeader>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.CreateByOrgCode });

                entity.Property(e => e.PurposeTypeId).HasComment("บันทึกวัตถุประสงค์ในการส่งข้อความ 1. ทั่วไป 2. การตลาด");
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.HasKey(e => new { e.TemplateCode, e.CreateByOrgCode });

                entity.Property(e => e.IsSendWhenReceive).HasComment("ส่งข้อความถึงลูกค้าอัตโนมัติเมื่อยืนยันรับเงิน");

                entity.Property(e => e.Password).HasComment("รหัสผ่านเพื่อใช้ส่งข้อความ");

                entity.Property(e => e.TemplateTypeId).HasComment("รูปแบบการทำงานของTemplate 1-ส่งหาลูกค้าเมื่อยืนยันรับเงิน/ 2-ส่งหาเจ้าเมื่อยืนยันรับเงิน/ 4-ส่งยอดเงินรวมหาเจ้าของเมื่อปิดรอบบัญชี");

                entity.Property(e => e.UserName).HasComment("ชื่อผู้ใช้ที่ใช้ส่งข้อความ");
            });

            modelBuilder.Entity<MevaluateDatum>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.EvaluateCode });

                entity.Property(e => e.EvaluateCode).HasComment("รหัสหัวข้อการประเมิน");

                entity.Property(e => e.EvaluateName).HasComment("ชื่อหัวข้อการประเมิน");

                entity.Property(e => e.IsExhibition).HasComment("ดูงาน");

                entity.Property(e => e.IsMeeting).HasComment("ประชุม / สัมมนา");

                entity.Property(e => e.IsTraining).HasComment("อบรม");
            });

            modelBuilder.Entity<MexchangeOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });

                entity.Property(e => e.UpdateIpaddress2).HasComment("รหัสสาขาในการอัพเดต IP Address");
            });

            modelBuilder.Entity<Mexhibition>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExhibitionCode });

                entity.Property(e => e.ExhibitionCode).HasComment("รหัสหัวข้อดูงาน");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");

                entity.Property(e => e.ExhibitionByName).HasComment("วิทยากร");

                entity.Property(e => e.ExhibitionName).HasComment("หัวข้อการดูงาน");

                entity.Property(e => e.Institute).HasComment("สถาบัน");

                entity.Property(e => e.Location).HasComment("สถานที่ดูงาน");

                entity.Property(e => e.Method).HasComment("วิธีการดูงาน");

                entity.Property(e => e.Purpose).HasComment("วัตถุประสงค์");

                entity.Property(e => e.Reason).HasComment("หลักการและเหตุผล");

                entity.Property(e => e.ResponsibleBy).HasComment("ผู้รับผิดชอบโครงการ");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มต้น");
            });

            modelBuilder.Entity<MexpenseType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ExpenseTypeCode });

                entity.Property(e => e.ExpenseTypeCode).HasComment("รหัสประเภทค่าใช้จ่าย");

                entity.Property(e => e.ExpenseTypeName).HasComment("ชื่อ(ไทย)ของประเภทค่าใช้จ่าย");

                entity.Property(e => e.ExpenseTypeName2).HasComment("ชื่อ(Eng)ของประเภทค่าใช้จ่าย");

                entity.Property(e => e.Remark).HasComment("หมายเหตุของประเภทค่าใช้จ่าย");
            });

            modelBuilder.Entity<Mfaction>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.FactionCode });
            });

            modelBuilder.Entity<Mfixasset>(entity =>
            {
                entity.HasKey(e => new { e.FixassetCode, e.CreateByOrgCode });

                entity.Property(e => e.FixassetCode).HasComment("รหัสสินทรัพย์");

                entity.Property(e => e.AssuranceNo).HasComment("หมายเลขประกัน");

                entity.Property(e => e.AssuranceValue).HasComment("วงเงินประกัน");

                entity.Property(e => e.BeginTime).HasComment("เวลาเริ่มต้นของเครื่องมือ (แพทย์)");

                entity.Property(e => e.BeginUseAmount).HasComment("จำนวนครั้งเริ่มต้นของเครื่องมืือ (แพทย์)");

                entity.Property(e => e.BeginUseDate).HasComment("วันที่เริ่มใช้งาน & วันที่เริ่มคิดค่าเสื่อม");

                entity.Property(e => e.Brand).HasComment("ยี่ห้อ");

                entity.Property(e => e.ConstructionFixAccCode).HasComment("เลขที่บช.งานระหว่างก่อสร้าง");

                entity.Property(e => e.Cost).HasComment("มูลค่าสินทรัพย์");

                entity.Property(e => e.CostAmount).HasComment("มูลค่าสินทรัพย");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentTime).HasComment("เวลาปัจจุบันของเครื่องมือ(แพทย์)");

                entity.Property(e => e.CurrentUseAmount).HasComment("จำนวนครั้งปัจจุบันของเครื่องมือ (แพทย์)");

                entity.Property(e => e.CutLossNo).HasComment("เลขที่ใบตัดจำหน่าย");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนกที่ใช้งาน");

                entity.Property(e => e.DepreciationAmountByCal).HasComment("ค่าเสื่อมราคาที่คำนวณเอง");

                entity.Property(e => e.DepreciationMethodByTimeId).HasComment("คิดรายปี เดือน วัน");

                entity.Property(e => e.DepreciationMethodId).HasComment("วิธีคำนวณค่าเสื่อมราคา 0=เส้นตรง");

                entity.Property(e => e.DepreciationRate).HasComment("อัตราค่าเสื่อมราคาต่อปี");

                entity.Property(e => e.Duration).HasComment("อายุการใช้งาน");

                entity.Property(e => e.EndUseDate).HasComment("วันที่เลิกใช้งาน");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.FirstDepreciation).HasComment("อัตราค่าเสื่อมราคาปีแรก");

                entity.Property(e => e.FisassetRegistrationNo).HasComment("เลขทะเบียนทรัพย์สิน");

                entity.Property(e => e.FixAssetName2).HasComment("ชื่อสินทรัพย์ 2 (อังกฤษ)");

                entity.Property(e => e.FixAssetStatusCode).HasComment("สถานะของสินทรัพย์");

                entity.Property(e => e.FixassetAccCode).HasComment("เลขที่บัญชีสินทรัพย์ถาวร");

                entity.Property(e => e.FixassetDepAccCode).HasComment("เลขที่บัญชีค่าเสื่อมราคา");

                entity.Property(e => e.FixassetDepSumAccCode).HasComment("เลขที่บัญชีค่าเสื่อมราคาสะสม");

                entity.Property(e => e.FixassetName).HasComment("ชื่อสินทรัพย์");

                entity.Property(e => e.FixassetTypeCode).HasComment("รหัสประเภทสินทรัพย์ถาวรย์");

                entity.Property(e => e.ImagePath).HasComment("รูปสินทรัพย์");

                entity.Property(e => e.InActive).HasComment("1=ไม่ใช้งาน");

                entity.Property(e => e.InitialDepreciationAmount).HasComment("ค่าเสื่อมราคาเบื้องต้น");

                entity.Property(e => e.Instruction).HasComment("คำแนะนำในการใช้งาน");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบวางบิล");

                entity.Property(e => e.IsDeleted).HasComment("ถูกลบหรือไม่");

                entity.Property(e => e.IsSold).HasComment("ขายแล้วหรือยัง 1-ขายแล้ว");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.IsUse).HasComment("เริ่มใช้งาน/เริ่มคำนวณค่าเสื่อม");

                entity.Property(e => e.LastCalDepDate).HasComment("วันที่คิดค่าเสื่อมครั้งสุดท้าย");

                entity.Property(e => e.Location).HasComment("สถานที่เก็บ");

                entity.Property(e => e.LossAccCode).HasComment("เลขที่บช.กำไรขาดทุนจากการตัดจำหน่ายสินทรัพย์");

                entity.Property(e => e.ManufactureBy).HasComment("ผู้ผลิต");

                entity.Property(e => e.MaxAmount).HasComment("จำนวนครั้งสูงสุดของเครื่องมือ (แพทย์)");

                entity.Property(e => e.MaxTime).HasComment("เวลาสูงสุทของเครื่องมือ (แพทย์)");

                entity.Property(e => e.Model).HasComment("ชื่อรุ่น");

                entity.Property(e => e.ProfitAndLossAccCode).HasComment("เลขที่บช.กำไรขาดทุนจากการขายสินทรัพย์ถาวรย์");

                entity.Property(e => e.ProfitAndLossAmount).HasComment("จำนวนเงินที่กำไรหรือขาดทุนจากการขาย");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.PurchaseDate).HasComment("วันที่ซื้อ");

                entity.Property(e => e.PurchasePono).HasComment("เลขที่ใบสั่งซ้อ");

                entity.Property(e => e.PurchasePrice).HasComment("ราคาที่ซื้อ");

                entity.Property(e => e.ReadTypeId).HasComment("อ่านเป็นเวลา หรือชั่วโมง");

                entity.Property(e => e.RemainsPrice).HasComment("ราคาซาก");

                entity.Property(e => e.RemainsValue).HasComment("มูลค่าคงเหลือ");

                entity.Property(e => e.Remark).HasComment("รายละเอียด");

                entity.Property(e => e.SellDate).HasComment("วันที่ตัดจำหน่าย");

                entity.Property(e => e.SellNo).HasComment("เลขที่ใบขายสินทรัพย์ถาวร");

                entity.Property(e => e.SellOrCutLossAmount).HasComment("มูลค่าที่ขาย/ตัดจำหน่าย");

                entity.Property(e => e.SerialNo).HasComment("Serial No.");

                entity.Property(e => e.StaffCode).HasComment("รหัสเจ้าหน้าที่ที่รับผิดชอบ");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");

                entity.Property(e => e.UseAge).HasComment("อายุการใช้งาน");

                entity.Property(e => e.UseAmount).HasComment("จำนวนครั้งที่ใช้ไป");

                entity.Property(e => e.UseTime).HasComment("จำนวนเวลาที่ใช้ไป");

                entity.Property(e => e.VatAmount).HasComment("มูลค่าภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VendorCode).HasComment("ชื่อผู้จำหน่าย");

                entity.Property(e => e.WarrantyEndDate).HasComment("วันที่สิ้นสุดการรับประกัน");

                entity.Property(e => e.WarrantyNo).HasComment("หมายเลขประกัน");

                entity.Property(e => e.WarrantyPrice).HasComment("ราคาประกัน");

                entity.Property(e => e.WarrantyStartDate).HasComment("วันที่เริ่มต้นรับประกัน");

                entity.Property(e => e.WarrantyStatusId).HasComment("สถานะการรับประกัน");
            });

            modelBuilder.Entity<MfixassetType>(entity =>
            {
                entity.HasKey(e => new { e.FixassetTypeCode, e.CreateByOrgCode });

                entity.Property(e => e.FixassetTypeCode).HasComment("รหัสประเภทสินทรัพย์ถาวร");

                entity.Property(e => e.DepreciationRate).HasComment("อัตราค่าเสื่อมราคาต่อปี");

                entity.Property(e => e.Duration).HasComment("อายุการใช้งาน");

                entity.Property(e => e.FirstYearRate).HasComment("");

                entity.Property(e => e.FixassetAccountCode).HasComment("เลขที่บัญชีสินทรัพย์ถาวร");

                entity.Property(e => e.FixassetDepAccountCode).HasComment("เลขที่บัญชีค่าเสื่อมราคา");

                entity.Property(e => e.FixassetDepSumAccountCode).HasComment("บัญชีค่าเสื่อมราคาสะสม");

                entity.Property(e => e.FixassetTypeName).HasComment("ชื่อประเภทสินทรัพย์ถาวร");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.RemainsValue).HasComment("ราคาซาก");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");
            });

            modelBuilder.Entity<Mholiday>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.HolidayDate, e.HolidayId });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");
            });

            modelBuilder.Entity<Micd10>(entity =>
            {
                entity.HasKey(e => new { e.Icdcode, e.CreateByOrgCode });

                entity.Property(e => e.Icdcode).HasComment("รหัสโรค");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Advice).HasComment("คำแนะนำ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.Icd10groupCode).HasComment("รหัสกลุ่มรหัสโรค");

                entity.Property(e => e.Icd10typeId).HasComment("รูปแบบของ ICD เพื่อออกรายงาน สสป. (โรคทั่วไป1, โรคระบาด2, โรคติดต่อสู่คน4, วัคซีนป้องกันได้8)");

                entity.Property(e => e.Icdname).HasComment("ชื่อโรค");

                entity.Property(e => e.IcdtypeCode).HasComment("รหัสประเภทโรค");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Ur).HasComment("ระดับราคาต่อโรค");
            });

            modelBuilder.Entity<Micd10group>(entity =>
            {
                entity.HasKey(e => new { e.Icd10groupCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<Micd9cm>(entity =>
            {
                entity.HasKey(e => new { e.Icdcode, e.CreateByOrgCode })
                    .HasName("PK_MICD9");

                entity.Property(e => e.Icdcode).HasComment("รหัส ICD9");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Advice).HasComment("คำแนะนำ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.Icdname).HasComment("ชื่อ ICD9");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ModByCode).HasComment("วันที่แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Ur).HasComment("ราคาประมาณของ ICD9");
            });

            modelBuilder.Entity<Micd9cmgroup>(entity =>
            {
                entity.HasKey(e => new { e.Icd9cmgroupCode, e.CreateByOrgCode })
                    .HasName("PK_MICD9Group");
            });

            modelBuilder.Entity<MincomeDeduct>(entity =>
            {
                entity.HasKey(e => new { e.InDecCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<MincomeDeductList>(entity =>
            {
                entity.HasKey(e => new { e.InDeCode, e.CreateByOrgCode })
                    .HasName("PK_IncomeDeductList");

                entity.Property(e => e.InDeCode).HasComment("รหัสรายได้ รายการหัก");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.InDeName).HasComment("ชื่อรายได้ รายการหัก");

                entity.Property(e => e.IsCalcOt).HasComment("นำไปรวมเพื่อคำนวณ OT หรือไม่");

                entity.Property(e => e.IsCalcProvidentFund).HasComment("นำไปรวมเพื่อคำนวณกองทุนสำรองเลี้ยงชีพหรือไม่");

                entity.Property(e => e.IsCalcSocial).HasComment("นำไปรวมเพื่อคำนวณประกันสังคมหรือไม่");

                entity.Property(e => e.IsCalcTax).HasComment("นำไปรวมเพื่อคำนวณภาษีหรือไม่");

                entity.Property(e => e.IsCalcTaxIgnorePeriod).HasComment("คำนวณภาษีแต่ไม่ต้องคูณจำนวนงวด ให้มองว่าเป็นรายได้ทั้งปี");

                entity.Property(e => e.IsDeduct).HasComment("ใช่รายการหักหรือไม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นฟิลด์สงวนไว้ใช้เฉพาะโปรแกรมหรือไม่");

                entity.Property(e => e.IsTransferBank2).HasComment("เป็นรายรับของบัญชีที่ 2 หรือไม่?");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");
            });

            modelBuilder.Entity<MinventoryOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });

                entity.Property(e => e.CutStockTypeId).HasComment("1=FIFO, 2=LIFO, 3=STD");

                entity.Property(e => e.DotText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข .");

                entity.Property(e => e.EightText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 8");

                entity.Property(e => e.FiveText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 5");

                entity.Property(e => e.FourText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 4");

                entity.Property(e => e.IsShowLastOrderQtyWhenOrder).HasComment("แสดงยอดสั่งซื้อล่าสุด");

                entity.Property(e => e.LastEndMonthDate).HasComment("วันที่ปิดรอบเดือนล่าสุด");

                entity.Property(e => e.NineText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 9");

                entity.Property(e => e.OneText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 1");

                entity.Property(e => e.SevenText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 7");

                entity.Property(e => e.SixText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 6");

                entity.Property(e => e.StockCalDays).HasComment("จำนวนวันในการคำนวณย้อนหลัง");

                entity.Property(e => e.StockMaxDays).HasComment("จำนวนวันในการคำนวณยอดสูงสุด");

                entity.Property(e => e.StockMinDays).HasComment("จำนวนวันในการคำนวณยอดต่ำสุด");

                entity.Property(e => e.ThreeText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 3");

                entity.Property(e => e.TwoText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 2");

                entity.Property(e => e.ZeroText)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ตัวอักษรแทนเลข 0");
            });

            modelBuilder.Entity<Mitem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AccountCode).HasComment("รหัสบัญชีสินค้า");

                entity.Property(e => e.AverageCost).HasComment("ต้นทุนเฉลี่ย/ Centre2, VetSOR เก็บต้นทุนแบบเฉลี่ย (Weighted Average)");

                entity.Property(e => e.Barcode).HasComment("รหัสบาร์โค๊ด");

                entity.Property(e => e.CalIncentiveTypeId).HasComment("รูปแบบการคิดค่าตอบแทน 0=จากราคาขาย, 1=จากจำนวนที่สั่ง, 2=จากราคาคอร์สหลัก");

                entity.Property(e => e.ClassifiedGroupCode).HasComment("รหัสกลุ่มที่ปรึกษา");

                entity.Property(e => e.CollectAmountPerPoint).HasComment("ยอดเงินที่จะได้แต้ม");

                entity.Property(e => e.CollectPoint).HasComment("จำนวนแต้มที่จะได้รับ");

                entity.Property(e => e.ColorCode).HasComment("รหัสสี");

                entity.Property(e => e.ComputeCode).HasComment("รหัสการคำนวณราคา");

                entity.Property(e => e.ControlTypeId).HasComment("เป็นยาควบคุมหรือไม่");

                entity.Property(e => e.CourseExpire).HasComment("จำนวนวันหมดอายุหลังจากสั่งคอร์สนั้นๆ");

                entity.Property(e => e.CourseTypeId).HasComment("1= Main, 2 = Sub, 3 = Add, 4 One Time");

                entity.Property(e => e.CreditLimit).HasComment("เก็บวงเงินที่ใช้ได้สำหรับ Voucher นั้น");

                entity.Property(e => e.CutStockItemCode).HasComment("รหัสสินค้าตัดสต็อก");

                entity.Property(e => e.CutStockTypeId).HasComment("1.สินค้าเพื่อขาย 2.บริการเพื่อขาย 3.สินค้าเพื่อขายกับใช้ 4.สินค้าเพื่อใช้ควบคุม 5.สินค้าเพื่อใช้ไม่ควบคุม");

                entity.Property(e => e.DiscountFix).HasComment("ส่วนลดเบื้องต้นแบบบาท (Default)");

                entity.Property(e => e.DiscountRate).HasComment("ส่วนลดเบื้องต้นแบบ %  (Default)");

                entity.Property(e => e.DiscountTypeId).HasComment("1-ส่วนลดตามอัตราส่วน(DiscountRate)/ 2-ส่วนลดตามคงที่(DiscountFix)");

                entity.Property(e => e.DoseDefault).HasComment("วิธีใช้ รับประทาน/ฉีด/ทา/");

                entity.Property(e => e.Effect1).HasComment("สรรพคุณภาษาไทย");

                entity.Property(e => e.Effect2).HasComment("สรรพคุณภาษาอื่น");

                entity.Property(e => e.ExpireTypeId).HasComment("1=หมดเมื่อสั่งคอร์สหลัก, 2=หมดเมื่อสั่งคอร์สย่อยครั้งที่ 1");

                entity.Property(e => e.Fifocost).HasComment("ต้นทุนแบบ FIFO");

                entity.Property(e => e.FixCost).HasComment("Centre2, VetSOR เก็บต้นทุนแบบกำหนดเอง");

                entity.Property(e => e.ForecastTypeCode).HasComment("รหัสกลุ่มประมาณการ");

                entity.Property(e => e.GenericCode).HasComment("รหัสสามัญ");

                entity.Property(e => e.HmgroupCode).HasComment("รหัสใบเสร็จ Home Med");

                entity.Property(e => e.HoldingDate).HasComment("ระยะเวลาจัดเก็บ (วัน)");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.InActiveDate).HasComment("วันที่สิ้นสุดการใช้งาน");

                entity.Property(e => e.InProgressAccountCode).HasComment("รหัสผังบัญชีงานระหว่างทำ");

                entity.Property(e => e.IncentiveAllFix).HasComment("ค่าตอบแทนส่วนกลาง");

                entity.Property(e => e.IncentiveAllRate).HasComment("อัตราค่าตอบแทนส่วนกลาง");

                entity.Property(e => e.IncentiveConsultPersonCount).HasComment("จำนวนผู้แนะนำทั้งหมดที่ได้ค่าตอบแทน");

                entity.Property(e => e.IncentiveConsultTypeId).HasComment("รูปแบบการแบ่งค่าตอบแทนผู้แนะนำ 0=แบ่งรายบุคคล 1=แบ่งเท่ากัน");

                entity.Property(e => e.IncentiveDiagFix).HasComment("ค่าตอบแทนแพทย์");

                entity.Property(e => e.IncentiveDiagPersonCount).HasComment("จำนวนผู้ตรวจทั้งหมดที่ได้ค่าตอบแทน");

                entity.Property(e => e.IncentiveDiagRate).HasComment("อัตตราค่าตอบแทนแพทย์");

                entity.Property(e => e.IncentiveDiagTypeId).HasComment("รูปแบบการแบ่งค่าตอบแทนผู้ตรวจ 0=แบ่งรายบุคคล 1=แบ่งเท่ากัน");

                entity.Property(e => e.IncentiveDoFix).HasComment("ค่าตอบแทนสำหรับคนทำ");

                entity.Property(e => e.IncentiveDoPersionCount).HasComment("จำนวนผู้ทำทั้งหมดที่ได้ค่าตอบแทน");

                entity.Property(e => e.IncentiveDoRate).HasComment("อัตราค่าตอบแทนสำหรับคนทำ");

                entity.Property(e => e.IncentiveDoTypeId).HasComment("รูปแบบการแบ่งค่าตอบแทนผู้ทำ 0=แบ่งรายบุคคล 1=แบ่งเท่ากัน");

                entity.Property(e => e.IncentiveMethodId).HasComment("รูปแบบการคำนวณค่าตอบแทน 1-ตามราคาขาย(ItemIncentive), 2-ตามส่วนลด(ItemDiscountIncentive)");

                entity.Property(e => e.IncentiveSellFix).HasComment("ค่าตอบแทนในการขาย");

                entity.Property(e => e.IncentiveSellPersonCount).HasComment("จำนวนผู้ขายทั้งหมดที่ได้ค่าตอบแทน");

                entity.Property(e => e.IncentiveSellRate).HasComment("อัตราค่าตอบแทนในการขาย");

                entity.Property(e => e.IncentiveSellTypeId).HasComment("รูปแบบการแบ่งค่าตอบแทนผู้ขาย 0=แบ่งรายบุคคล 1=แบ่งเท่ากัน");

                entity.Property(e => e.IndexCost).HasComment("ต้นทุนอ้างอิง");

                entity.Property(e => e.Indication).HasComment("สรรพคุณ");

                entity.Property(e => e.IpdgroupCode).HasComment("รหัสใบเสร็จ IPD");

                entity.Property(e => e.IpdrevenueAccountCode).HasComment("บัญชีรายได้ผู้ป่วยใน");

                entity.Property(e => e.Is30Baht).HasComment("เป็นยา30บาท");

                entity.Property(e => e.IsAct).HasComment("เป็นยาชุดที่สั่งตัวเอง");

                entity.Property(e => e.IsAutoPurchase).HasComment("ทำการสั่งซื้อแบบอัตโนมัติหรือไม่");

                entity.Property(e => e.IsBom).HasComment("เท่ากับ 0 ไม่เป็นวัตถุดิบ, เท่ากับ 1 เป็นวัตถุดิบ");

                entity.Property(e => e.IsCalCost).HasComment("เป็นประเภทคิดต้นทุน");

                entity.Property(e => e.IsCalMinMax).HasComment("คำนวณค่าต่ำสุดสุดสุดตอนปิดรอบหรือไม่");

                entity.Property(e => e.IsCalRevenue).HasComment("1=คิดรายได้");

                entity.Property(e => e.IsCalVatPurchase).HasComment("คำนวณภาษีซื้อ");

                entity.Property(e => e.IsCalVatSales).HasComment("คำนวณภาษีขาย");

                entity.Property(e => e.IsCanEditPrice).HasComment("สามารถแก้ไขราคาขายได้");

                entity.Property(e => e.IsCheckStock).HasComment("ตรวจสอบยอดคงเหลือก่อนสั่งหรือไม่");

                entity.Property(e => e.IsChild).HasComment("เป็นยาสำหรับเด็ก");

                entity.Property(e => e.IsCourse).HasComment("เป็นสินค้าประเภท Course หรือไม่");

                entity.Property(e => e.IsDiscountable).HasComment("สินค้านี้สามารถให้ส่วนลดได้หรือไม่");

                entity.Property(e => e.IsDrug).HasComment("เป็นรายการยาหรือไม่");

                entity.Property(e => e.IsEarnPoint).HasComment("กลุ่มที่ร่วมรายการสะสมแต้ม");

                entity.Property(e => e.IsFavoriteLab).HasComment("เป็น Lab ใช้บ่อย");

                entity.Property(e => e.IsIvtherapy).HasComment("เป็นสารน้ำ ส่วนประกอบสำหรับสินค้าประเภทการรักษาด้วยสารน้ำ");

                entity.Property(e => e.IsLab).HasComment("เป็นรายการ LAB หรือไม่");

                entity.Property(e => e.IsLabResultFemale).HasComment("เป็น Lab สำหรับผู้หญิงหรือไม่");

                entity.Property(e => e.IsLabResultMale).HasComment("เป็น Lab สำหรับผู้ชายหรือไม่");

                entity.Property(e => e.IsLabStandard).HasComment("มีค่ามาตรฐาน");

                entity.Property(e => e.IsMenu).HasComment("เป็นเมนูอาหารหรือไม่");

                entity.Property(e => e.IsMustScanFingerprint).HasComment("ต้องแสกนลายนิ้วมือก่อนถึงจะสั่งได้");

                entity.Property(e => e.IsMutiOrder).HasComment("สั่งรวม");

                entity.Property(e => e.IsNotAllowPregnant).HasComment("เป็นยาอัตราสำหรับหญิงมีครรภ์หรือไม่");

                entity.Property(e => e.IsNotifications).HasComment("การแจ้งเตือนการนัดรับผล");

                entity.Property(e => e.IsPackage).HasComment("เป็นประเภทกลุ่ม");

                entity.Property(e => e.IsPosorder).HasComment("เป็นรายการสำหรับสั่ง POS หรือไม่");

                entity.Property(e => e.IsPriceUnitSales).HasComment("ราคาตามหน่วยขาย");

                entity.Property(e => e.IsPrintLabel).HasComment("เป็นสินค้าที่พิมพ์ฉลากหรือไม่");

                entity.Property(e => e.IsService).HasComment("เป็นรายการบริการหรือไม่");

                entity.Property(e => e.IsSetRight).HasComment("เป็นสินค้ากำหนดสิทธิ์");

                entity.Property(e => e.IsSocial).HasComment("เป็นยาประกันสังคม");

                entity.Property(e => e.IsSpecialControl).HasComment("เป็นยาควบคุมพิเศษ");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.IsUnLimitCredit).HasComment("บัตรสมาชิกแบบไม่มีการกำหนดวงเงิน");

                entity.Property(e => e.IsUsePoint).HasComment("ใช้ระบบสะสมแต้มพิเศษ(สมาชิก)");

                entity.Property(e => e.IsUseWithPoint).HasComment("สำหรับItemสมาชิก กำหนดให้ใช้ร่วมกับการสะสมแต้ม");

                entity.Property(e => e.IsVaccine).HasComment("เป็น Vaccine หรือไม่");

                entity.Property(e => e.IsXray).HasComment("เป็นรายการ X-Ray หรือไม่");

                entity.Property(e => e.IsYs).HasComment("เป็นยาเสพติด/อันตรายหรือไม่");

                entity.Property(e => e.ItemAccountCode).HasComment("เลขที่บัญชีสินค้า");

                entity.Property(e => e.ItemGroupCode).HasComment("รหัสกลุ่มหลัก");

                entity.Property(e => e.ItemName).HasComment("ชื่อหน่วยงาน");

                entity.Property(e => e.ItemName2).HasComment("ชื่อ (Eng) รายการสินค้า");

                entity.Property(e => e.ItemStockFormatCode).HasComment("ประเภทต้นทุน");

                entity.Property(e => e.ItemTypeId).HasComment("เภทสินค้า1l : ทั่วไป 2: Lab 3:Xray 4:ยานอกบัญชี 5 :ยาต้านไวรัส /ตกลงกันอีกครั้ง");

                entity.Property(e => e.Keyword).HasComment("ชื่อตัวย่อ (ตัดสระ)");

                entity.Property(e => e.LabCode).HasComment("ใช้ MapCode ส่ง Request ไปเครื่อง Fuse");

                entity.Property(e => e.LabGroupCode).HasComment("รหัสกลุ่ม lab");

                entity.Property(e => e.LabMethod).HasComment("มาตรฐษนในการ้ทำ Lab");

                entity.Property(e => e.LabResultFemaleMax).HasComment("ผล Lab สูงสุดเพศหญิง");

                entity.Property(e => e.LabResultFemaleMin).HasComment("ผล Lab ต่ำสุดเพศหญิง");

                entity.Property(e => e.LabResultFemaleText).HasComment("ผล Lab แบบตัวอักษร เพศหญิง");

                entity.Property(e => e.LabResultMaleMax).HasComment("ผล Lab สูงสุด เพศชาย");

                entity.Property(e => e.LabResultMaleMin).HasComment("ผล Lab ต่ำสุดเพศชาย");

                entity.Property(e => e.LabResultMaleText).HasComment("ผล Lab แบบตัวอักษร เพศชาย");

                entity.Property(e => e.LabResultNote).HasComment("บันทึกสำหรับผลแล็บประเภท Note");

                entity.Property(e => e.LabResultTypeId).HasComment("ประเภทผล Lab");

                entity.Property(e => e.LabTypeId).HasComment("1=ลงผล 2=คำนวณ");

                entity.Property(e => e.LabUnit).HasComment("หน่วย Lab");

                entity.Property(e => e.LastReceiveDate).HasComment("วันรับสินค้าล่าสุด");

                entity.Property(e => e.LeadTime).HasComment("ระยะสั่งซื้อ+ขนส่ง (วัน)");

                entity.Property(e => e.Lifocost).HasComment("ต้นทุนแบบ LIFO");

                entity.Property(e => e.LocationCode).HasComment("รหัสสถานที่เก็บสินค้า");

                entity.Property(e => e.MainCourseCode).HasComment("รหัสคอร์สหลัก");

                entity.Property(e => e.ManufactureCode).HasComment("ผู้ผลิต");

                entity.Property(e => e.Manufacturer).HasComment("เก็บข้อมูลผู้ผลิต");

                entity.Property(e => e.MaxOrderQuantity).HasComment("จำนวนสูงสุดที่สั่งซื้อได้ในแต่ละครั้ง");

                entity.Property(e => e.MaxSalesQuantity).HasComment("จำนวนสูงสุดที่สั่งได้ในแต่ละครั้ง (0= ไม่จำกัด)");

                entity.Property(e => e.MaximumPrice).HasComment("ราคาสูงสุดที่อนุญาต");

                entity.Property(e => e.MemberCollectAmountPerPoint).HasComment("ยอดเงินที่จะได้แต้ม");

                entity.Property(e => e.MemberCollectPoint).HasComment("จำนวนแต้มที่จะได้รับ");

                entity.Property(e => e.MemberColor).HasComment("สีของบัตรสมาชิก");

                entity.Property(e => e.MemberExpireDate).HasComment("เก็บวันที่หมดอายุของบัตรสมาชิก");

                entity.Property(e => e.MemberExpireDays).HasComment("จำนวนวันหมดอายุขอบัตรสมาชิกนับจากวันที่ซื้อ");

                entity.Property(e => e.MemberExpireTypeId).HasComment("ประเภทวันหมดอายุของบัตรสมาชิก 1-ไม่ระบุ/ 2-กำหนดวันหมดอายุ/ 3-กำหนดวันที่หมดอายุ");

                entity.Property(e => e.MemberLastRunningNo).HasComment("สำหรับบัตรสมาชิก เก็บเลขที่รันนิ่งล่าสุด");

                entity.Property(e => e.MemberRunningFormatText).HasComment("สำหรับบัตรสมาชิก เก็บรูปแบบเลขที่สมาชิก");

                entity.Property(e => e.MemberRunningNoTypeId).HasComment("สำหรับสินค้าบัตรสมาชิก กำหนดรูปแบบการให้เลขที่สมาชิก1.กำหนดเลขรันนิ่ง 2.ตามรหัสเจ้าของ 3.กรอกเอง");

                entity.Property(e => e.MemberRunningPrefix).HasComment("สำหรับบัตรสมาชิก เก็บรูปแบบข้อความขึ้นต้นเลขที่สมาชิก");

                entity.Property(e => e.MinimumPrice).HasComment("ราคาขายต่ำสุดที่อนุญาต");

                entity.Property(e => e.NotificationsDay).HasComment("ระบุจำนวนวันการแจ้งเตือนนัดรับผล");

                entity.Property(e => e.NotificationsHour).HasComment("ระบุจำนวนชั่วโมงการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.NotificationsMinute).HasComment("ระบุจำนวนนาทีการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.NotificationsMonth).HasComment("ระบุจำนวนเดือนการแจ้งเตือนนัดรับผล");

                entity.Property(e => e.NotificationsYear).HasComment("ระบุจำนวนปีการแจ้งเตือนการนัดรับ");

                entity.Property(e => e.OnShelfQty).HasComment("จำนวนสินค้าบนชั้นวาง");

                entity.Property(e => e.OpdgroupCode).HasComment("รหัสใบเสร็จ OPD");

                entity.Property(e => e.OpdrevenueAccountCode).HasComment("บัญชีรายได้ผู้ป่วยนอก");

                entity.Property(e => e.PackSize1).HasComment("ขนาดในการบรรจุ 1");

                entity.Property(e => e.PackSize2).HasComment("ขนาดในการบรรจุ 2");

                entity.Property(e => e.PackSize3).HasComment("ขนาดในการบรรจุ 3");

                entity.Property(e => e.PackSize4).HasComment("ขนาดในการบรรจุ 4");

                entity.Property(e => e.PackSize5).HasComment("ขนาดในการบรรจุ 5");

                entity.Property(e => e.PackSizeSales1).HasComment("ขนาดบรรจุหน่วยขาย");

                entity.Property(e => e.PackSizeSales2).HasComment("ขนาดบรรจุหน่วยขายย่อย");

                entity.Property(e => e.PackSizeStock).HasComment("ขนาดบรรจุหน่วยเก็บ");

                entity.Property(e => e.PointCalculateTypeId).HasComment("รูปแบบการคำนวณแต้ม 1 ให้แต้มตามจริง 2ปัดลง");

                entity.Property(e => e.PointExpireDay).HasComment("จำนวนวันหมดอายุของ Point");

                entity.Property(e => e.PrimaryAccountCode).HasComment("บัญชียาหลัก");

                entity.Property(e => e.PrintBarcodeAmount).HasComment("จำนวนพิมพ์บาร์โค๊ด");

                entity.Property(e => e.PrintLabel).HasComment("จำนวนพิมพ์ 0:พิมพ์ตามจำนวนสั่ง");

                entity.Property(e => e.PrintName).HasComment("ชื่อใช้พิมพ์");

                entity.Property(e => e.PromotionFreeDrugQty).HasComment("จำนวนยาฟรีที่ให้");

                entity.Property(e => e.PromotionPriceFrom).HasComment("ยอดขายที่ได้โปรโมชั่น ตั้งแต่");

                entity.Property(e => e.PromotionPriceTo).HasComment("ยอดขายที่ได้โปรโมชั่น ถึง");

                entity.Property(e => e.PromotionTotalCredit).HasComment("จำนวน Credit สำหรับคอร์สแถมยา");

                entity.Property(e => e.PromotionTypeId).HasComment("0=ไม่มีโปรโมชั่น 1=มีโปรโมชั่น 3=ยาสำหรับแถม 5=คอร์สแถมยา");

                entity.Property(e => e.PurchaseCondition).HasComment("เงื่อนไขการสั่งซื้อ");

                entity.Property(e => e.PurchaseSize).HasComment("ขนาดที่สั่งซื้อ");

                entity.Property(e => e.QuantityPerCourse).HasComment("จำนวนทั้งหมด ใช้สำหรับคอร์สปริมาณ");

                entity.Property(e => e.RawLabCode1).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ");

                entity.Property(e => e.ReceiptGroupCode).HasComment("รหัสกลุ่มใบเสร็จ");

                entity.Property(e => e.RedeemAmountPerPoint).HasComment("จำนวนเงินที่ได้รับจากการแลกแต้ม");

                entity.Property(e => e.RedeemPoint).HasComment("จำนวนแต้มที่ใช้สำหรับการแลก");

                entity.Property(e => e.ReplaceCost).HasComment("Centre2, VetSOR เก็บต้นทุนแบบแทนที่ (Replace with average by RO)");

                entity.Property(e => e.ReturnVendorAccountCode).HasComment("บัญชีส่งคืนสินค้า");

                entity.Property(e => e.RightAmountPerDay).HasComment("วงเงินสิทธิ์ต่อวัน (กรณีที่สินค้านี้เป็นสินค้าที่ใช้กำหนดสิทธิ์)");

                entity.Property(e => e.RightCreditLimit).HasComment("วงเงินสิทธิ์");

                entity.Property(e => e.RightExpire).HasComment("จำนวนวันหมดอายุสิทธิ์");

                entity.Property(e => e.RightIsUnExpire).HasComment("ไม่จำกัดเวลาสิทธิ์");

                entity.Property(e => e.RightIsUnLimitCredit).HasComment("ไม่จำกัดวงเงินสิทธิ์");

                entity.Property(e => e.RotypeId).HasComment("รูปแบบการรับสินค้า 1 Lot, 2 Serial");

                entity.Property(e => e.SafetyDate).HasComment("ระยะเวลาเผื่อขาด (วัน)");

                entity.Property(e => e.SellCostAccountCode).HasComment("เลขที่บัญชีต้นทุนขาย");

                entity.Property(e => e.SellDefault).HasComment("จำนวนขายเริ่มต้น");

                entity.Property(e => e.ShapeCode).HasComment("รหัสรูปร่าง เช่น เม็ด แคปซูล");

                entity.Property(e => e.SocialDiscountAmount).HasComment("ราคาที่สามารถเบิกได้โดยไม่อ้างอิงกับสิทธิ์ (ทุกสิทธิ์เบิกได้เท่ากันหมด มศว.)");

                entity.Property(e => e.SubCourseAmount).HasComment("จำนวนคอร์สย่อย");

                entity.Property(e => e.SubCourseNo).HasComment("ลำดับคอร์สย่อย");

                entity.Property(e => e.SubItemGroupCode).HasComment("รหัสกลุ่มย่อย");

                entity.Property(e => e.TabletText).HasComment("ข้อความในเม็ดยา");

                entity.Property(e => e.ToolTime).HasComment("เวลาที่ใช้สำหรับเครื่องมือแพทย์");

                entity.Property(e => e.ToolTypeCode).HasComment("รหัสประเภทเครื่องมือ");

                entity.Property(e => e.TotalCost).HasComment("ต้นทุนรวมของสินค้า หลังจากเกิดข้อมูลนี้");

                entity.Property(e => e.TotalCostAverage).HasComment("ต้นทุนรวมของสินค้าแบบเฉลี่ยหลังจากเกิดข้อมูลนี้");

                entity.Property(e => e.TotalCostFifo).HasComment("ต้นทุนรวมของสินค้าแบบเข้าก่อนออกก่อน หลังจากเกิดข้อมูลนี้");

                entity.Property(e => e.TypeFoodCode).HasComment("รหัสประเภทอาหาร");

                entity.Property(e => e.UnitCost).HasComment("ราคาต้นทุน");

                entity.Property(e => e.UnitCountBranch).HasComment("หน่วนนับสาขา");

                entity.Property(e => e.UnitCountBranchRatio).HasComment("อัตรส่วนหน่วยนับสาขา");

                entity.Property(e => e.UnitCountHq).HasComment("หน่วยนับสำนักงานใหญ่");

                entity.Property(e => e.UnitCountHqratio).HasComment("อัตราส่วนหน่วยนับ สำนักงานใหญ่");

                entity.Property(e => e.UnitCourse).HasComment("หน่วยของคอร์สปริมาณ เช่น คอร๋สร้อยไหม มีหน่วยเป็น เส้น");

                entity.Property(e => e.UnitOrder).HasComment("ชื่อหน่วยสั่งซื้อ");

                entity.Property(e => e.UnitOrderRatio).HasComment("อัตราส่วนหน่วยซื้อกับหน่วยเก็บ");

                entity.Property(e => e.UnitPriceTypeId).HasComment("1 บังคับใช้ 2 แก้ไขได้ 3 เครื่องชั่ง 4 ระดับราคา 5 น้ำหนัก");

                entity.Property(e => e.UnitSales).HasComment("ชื่อหน่วยขาย  ID: 0,Null");

                entity.Property(e => e.UnitSalesRatio).HasComment("อัตราส่วนหน่วยขายกับหน่วยเก็บ");

                entity.Property(e => e.UnitStock).HasComment("หน่วยเก็บ");

                entity.Property(e => e.VaccineDose).HasComment("ขนาดในการใช้วัคซีน");

                entity.Property(e => e.VaccineDuration).HasComment("ระยะเวลาฉีด");

                entity.Property(e => e.VaccineForDesease).HasComment("เป็นวัคซีนสำหรับโรคอะไร");

                entity.Property(e => e.VaccineParentCode).HasComment("รหัส vaccine หลัก");

                entity.Property(e => e.VaccineProductTypeId).HasComment("ชนิดของวัคซีน 0=ไม่ระบุ , 1=MLV, 2=Killed Vacine");

                entity.Property(e => e.VaccineQuantity).HasComment("ปริมาณที่ใช้วัคซีน");

                entity.Property(e => e.VaccineRemark).HasComment("หมายเหตุสำหรับวัคซีน");

                entity.Property(e => e.VaccineTypeId).HasComment("1=ตามวันเกิด หรือ 2= ตามวันที่ฉีด");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.VoucherPriceLevelCode).HasComment("'ระดับราคาของสินค้าที่จะนำมาหักวงเงิน ไม่กำหนดคือตามระดับราคาชองลูกค้า");

                entity.Property(e => e.Warn1).HasComment("คำเตือนภาษาไทย");

                entity.Property(e => e.Warn2).HasComment("คำเตือนภาษาอื่น");

                entity.Property(e => e.Warnnig).HasComment("คำเตือนในการใช้ยา");

                entity.Property(e => e.WithholdingTaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.WithholdingTaxTypeCode).HasComment("รูปแบบการหัก ณ ที่จ่าย");

                entity.Property(e => e.XrayTypeCode).HasComment("รหัสประเภท X-ray");
            });

            modelBuilder.Entity<MitemCustomField>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<MitemExchange>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemCode, e.CardTypeCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CardTypeCode).HasComment("รหัสชนิดบัตรสมาชิกที่ใช้แลก");

                entity.Property(e => e.IsCanExchange).HasComment("เปิดให้แลกอยู่หรือไม่ 0=ไม่ให่แลก , 1=แลกได้อยู่");

                entity.Property(e => e.PointUse).HasComment("แต้มที่ใช้แลก");
            });

            modelBuilder.Entity<MitemGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemGroupCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemGroupCode).HasComment("รหัสกลุ่มสินค้า");

                entity.Property(e => e.AccountCode).HasComment("รหัสผังบัญชีต้นทุน");

                entity.Property(e => e.AccountCodeItem).HasComment("รหัสผังบัญชีสินค้า");

                entity.Property(e => e.AccountCodeRevenue).HasComment("รหัสผังบัญชีรายได้");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsEarnPoint).HasComment("กลุ่มที่ร่วมรายการสะสมแต้ม");

                entity.Property(e => e.IsOutStatement).HasComment("ออกรายการที่ Statement Req 6.16 ");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ItemGroupName).HasComment("ชื่อกลุ่มสินค้า");

                entity.Property(e => e.ItemGroupName2).HasComment("ชื่อกลุ่มสินค้า ภาษาอังกฤษ");

                entity.Property(e => e.ShowColor).HasComment("สีประจำกลุ่ม");
            });

            modelBuilder.Entity<MitemGroupImage>(entity =>
            {
                entity.HasKey(e => new { e.ItemGroupCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemGroupCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");
            });

            modelBuilder.Entity<MitemGroupIpd>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ItemGroupCodeIpd });
            });

            modelBuilder.Entity<MitemImage>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ItemImageName).HasComment("ชื่อรูปภาพ");

                entity.Property(e => e.ItemImagePath).HasComment("Path ในการเก็บรูป");
            });

            modelBuilder.Entity<MitemStockFormat>(entity =>
            {
                entity.HasKey(e => new { e.ItemStockFormatCode, e.CreateByOrgCode });

                entity.Property(e => e.ItemStockFormatCode).HasComment("รหัสประเภทต้นทุน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CostTypeId).HasComment("ประเภทต้นทุน 1 :เฉลี่ย 2: FiFo 3: อ้างอิง 4: ไม่มีต้นทุน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsCheckCutStock).HasComment("เป็นประเภทตัดสต็อก");

                entity.Property(e => e.IsCheckIncome).HasComment("เป็นประเภทรายได้");

                entity.Property(e => e.IsCheckPurchase).HasComment("เป็นประเภทสั่งซื้อ");

                entity.Property(e => e.IsCheckStock).HasComment("เป็นประเภทตรวจสอบยอดคงเหลือ");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.ItemStockFormatName).HasComment("ชื่อประเภทต้นทุน");
            });

            modelBuilder.Entity<MizpalField>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.FieldName });
            });

            modelBuilder.Entity<MizpalMethod>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ClassName, e.MethodName });

                entity.Property(e => e.ParentClassName).HasComment("Not use");

                entity.Property(e => e.TableName).HasComment("Not Use");

                entity.HasOne(d => d.ClassNameNavigation)
                    .WithMany(p => p.MizpalMethods)
                    .HasForeignKey(d => d.ClassName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIzpalMethod_MIzpalClass");
            });

            modelBuilder.Entity<MizpalTable>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.CreateByOrgCode });
            });

            modelBuilder.Entity<MjobDescription>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JobDescriptionNo });

                entity.Property(e => e.JobDescriptionNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.BonusSalary).HasComment("เงื่อนไขการให้โบนัส");

                entity.Property(e => e.DepartmentCode).HasComment("แผนก");

                entity.Property(e => e.ExperienceInside).HasComment("ประสบการณ์ภายใน");

                entity.Property(e => e.ExperienceOutside).HasComment("ประสบการณ์ภายนอก");

                entity.Property(e => e.FromAge).HasComment("ตั้งแต่อายุ");

                entity.Property(e => e.FromExperience).HasComment("อายุงานตั้งแต่");

                entity.Property(e => e.FromSalary).HasComment("รายได้จาก");

                entity.Property(e => e.JobDate).HasComment("วันที่");

                entity.Property(e => e.JobDetail).HasComment("รายละเอียดงาน");

                entity.Property(e => e.LeadershipRole).HasComment("คุณสมบัติการเป็นผู้นำ");

                entity.Property(e => e.MinimumTrainHours).HasComment("ชั่วโมงอบรมขั้นต่ำ");

                entity.Property(e => e.PositionCode).HasComment("ตำแหน่ง");

                entity.Property(e => e.Responsibility).HasComment("หน้าที่ความรับผิดชอบ");

                entity.Property(e => e.SalaryRemark).HasComment("หมายเหตุการให้เงินเดือน");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("เพศ");

                entity.Property(e => e.SupervisorPositionCode).HasComment("ตำแหน่งผู้บังคับบัญชา");

                entity.Property(e => e.TeamRole).HasComment("การทำงานร่วมกับผู้อื่น");

                entity.Property(e => e.ToAge).HasComment("ถึงอายุ");

                entity.Property(e => e.ToExperience).HasComment("อายุงานถึง");

                entity.Property(e => e.ToSalary).HasComment("รายได้ถึง");

                entity.Property(e => e.UpSalaryCondition).HasComment("เงื่อนไขการปรับเงินเดือน");
            });

            modelBuilder.Entity<Mjournal>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.JournalCode });

                entity.Property(e => e.JournalCode).HasComment("รหัสสมุดบัญชี");

                entity.Property(e => e.BookCode).HasComment("รหัสสมุดรายวันที่ใช้บันทึก");

                entity.Property(e => e.FormatId1).HasComment("0=ไม่ระบุ, 1=เดือน(ํํMM), 2=ปี(YY)");

                entity.Property(e => e.FormatId2).HasComment("0=ไม่ระบุ, 1=เดือน(ํํMM), 2=ปี(YY)");

                entity.Property(e => e.Inactive).HasComment("1=ไม่ใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("1=เป็นข้อมูลของระบบ");

                entity.Property(e => e.JournalName).HasComment("ชื่อสมุดบัญชี");

                entity.Property(e => e.JournalName2).HasComment("ชื่อสมุดบัญชี2");

                entity.Property(e => e.LastRunningNo).HasComment("เลขที่ running ล่าสุด");

                entity.Property(e => e.Prefix).HasComment("อักษรนำรหัสเอกสาร");

                entity.Property(e => e.StartRunningNo).HasComment("เลขที่ running เริ่มต้น");
            });

            modelBuilder.Entity<MjournalOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode })
                    .HasName("PK_MJournalOptioins");
            });

            modelBuilder.Entity<MkeyCard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.KeyCardCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.KeyCardCode).HasComment("รหัสเครื่องรูดบัตร");

                entity.Property(e => e.KeyCardBrandName).HasComment("ยี่ห้อเครื่องรูดบัตร");

                entity.Property(e => e.KeyCardName).HasComment("ชื่อเครื่องรูดบัตร(ไทย)");

                entity.Property(e => e.KeyCardName2).HasComment("ชื่อเครื่องรูดบัตร(อังกฤษ)");

                entity.Property(e => e.KeyCardSerial).HasComment("เลขที่เครื่องรูดบัตร");

                entity.Property(e => e.VendorAddress).HasComment("ที่อยู่ผู้จำหน่าย");

                entity.Property(e => e.VendorName).HasComment("ชื่อผู้จำหน่าย");

                entity.Property(e => e.VendorTelNo).HasComment("เบอร์โทรศัพท์ผู้จำหน่าย");
            });

            modelBuilder.Entity<MkeyCardItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.KeyCardCode })
                    .HasName("PK_MKeyCardItem_1");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.SeqId).HasComment("ลำดับข้อมูลเครื่องรูดบัตร");

                entity.Property(e => e.KeyCardCode).HasComment("รหัสเครื่องรูดบัตร");

                entity.Property(e => e.FieldName).HasComment("ชื่อข้อมูลเครื่องรูดบัตร");

                entity.Property(e => e.Separator).HasComment("ตัวขั้นข้อมูลเครื่องรูดบัตร");
            });

            modelBuilder.Entity<Mkitchen>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.KitchenCode });

                entity.Property(e => e.DisplayTypeId).HasComment("1=ไม่มี 2=เครื่องพิมพ์ 3=จอภาพ");

                entity.Property(e => e.PrinterModel).HasComment("รุ่นเครื่องพิมพ์");

                entity.Property(e => e.PrinterName).HasComment("ชื่อเครื่องพิมพ์");
            });

            modelBuilder.Entity<MlabItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LabItemCode })
                    .HasName("PK_MLabItem_1");

                entity.Property(e => e.FuseCode).HasComment("รหัสจับคู่การรับผลลัพธ์จากเครื่อง Fuse");

                entity.Property(e => e.Idexxcode).HasComment("รหัสจับคู่การรับผลลัพธ์จากเครื่อง IDexx");

                entity.Property(e => e.IsLabResultFemale).HasComment("เป็น Lab สำหรับผู้หญิงหรือไม่");

                entity.Property(e => e.IsLabResultGeneral).HasComment("เป็น Lab ทั่วไปไม่แยกเพศ");

                entity.Property(e => e.IsLabResultMale).HasComment("เป็น Lab สำหรับผู้ชายหรือไม่");

                entity.Property(e => e.LabGroupCode).HasComment("รหัสกลุ่ม Lab");

                entity.Property(e => e.LabMethod).HasComment("มาตรฐานในการทำ Lab");

                entity.Property(e => e.LabResultFemaleMax).HasComment("ผล Lab สูงสุดเพศหญิง");

                entity.Property(e => e.LabResultFemaleMin).HasComment("ผล Lab ต่ำสุดเพศหญิง");

                entity.Property(e => e.LabResultFemaleStd).HasComment("ผล lab มาตราฐาน เพศหญิง");

                entity.Property(e => e.LabResultGeneralMax).HasComment("ผลแล็บสูงสุดสำหรับแล็บทั่วไป");

                entity.Property(e => e.LabResultGeneralMin).HasComment("ผลแล็บต่ำสุดสำหรับ lab ทั่วไป");

                entity.Property(e => e.LabResultGeneralStd).HasComment("ค่ามาตราฐานสำหรับ lab ทั่วไป");

                entity.Property(e => e.LabResultMaleMax).HasComment("ผล Lab สูงสุด เพศชาย");

                entity.Property(e => e.LabResultMaleMin).HasComment("ผล Lab ต่ำสุดเพศชาย");

                entity.Property(e => e.LabResultMaleStd).HasComment("ผล lab มาตราฐาน เพศชาย");

                entity.Property(e => e.LabResultTypeId).HasComment("ประเภทผล Lab 1 ตัวเลข, 2 ตัวหนังสือ");

                entity.Property(e => e.LabTypeId).HasComment("1=ลงผล 2=คำนวณ");

                entity.Property(e => e.LabUnit).HasComment("หน่วย Lab");

                entity.Property(e => e.MindrayCode).HasComment("รหัสจับคู่การรับผลลัพธ์จากเครื่อง Mindray");

                entity.Property(e => e.RawLabCode1).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ 1");

                entity.Property(e => e.RawLabCode2).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ 2");

                entity.Property(e => e.RawLabCode3).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ 3");

                entity.Property(e => e.RawLabCode4).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ 4");

                entity.Property(e => e.RawLabCode5).HasComment("Lab ที่ได้จากการลงผล ที่ผูกกับ Lab ที่ได้จากการคำนวณ 5");
            });

            modelBuilder.Entity<MlabItemStandard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LabItemCode, e.SpeciesCode });

                entity.Property(e => e.LabResultMax).HasComment("ผลแล็บสูงสุด (ตัวเลข)");

                entity.Property(e => e.LabResultMaxText).HasComment("ผลแล็บสูงสุด (ตัวหนังสือ)");

                entity.Property(e => e.LabResultMin).HasComment("ผลแล็บต่ำสุด (ตัวเลข)");

                entity.Property(e => e.LabResultMinText).HasComment("ผลแล็บต่ำสุด (ตัวหนังสือ)");

                entity.Property(e => e.LabResultNegativeText).HasComment("เก็บข้อความกรณี Negative สำหรับผลแล็บแบบ Yes/No");

                entity.Property(e => e.LabResultPositiveText).HasComment("เก็บข้อความกรณี Positive  สำหรับผลแล็บแบบ Yes/No");

                entity.Property(e => e.LabResultStd).HasComment("ผลแล็บมาตราฐาน (ตัวเลข)");

                entity.Property(e => e.LabResultStdtext).HasComment("ผลแล็บมาตราฐาน (ตัวหนังสือ)");

                entity.Property(e => e.LabResultText).HasComment("สำหรับเก็บผลข้อความ หากเป็นผลแล็บแบบ\"ข้อความ\"");
            });

            modelBuilder.Entity<MlabOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InstrumentCode, e.InstrumentTypeId });

                entity.Property(e => e.InstrumentCode).HasComment("รหัสเครื่องแล็บ");

                entity.Property(e => e.InstrumentTypeId).HasComment("รหัสเจ้าของเครื่องแล็บ1-Idexx, 2-Exigo, 3-Mindray, 4-Turbo");

                entity.Property(e => e.CbcbackupFolderPath).HasComment("Path สำหรับเก็บไฟล์ผลแล็บที่ได้มาจากเครื่อง CBC ทุกยี่ห้อ");

                entity.Property(e => e.CbccomportBaudRate).HasComment("Baud Rate ของเครื่อง CBC ที่ใช้ Com port");

                entity.Property(e => e.CbccomportName).HasComment("ชื่อ Com port ของเครื่อง CBC ที่ใช้ Com port");

                entity.Property(e => e.Cbcipaddress).HasComment("IP Address สำหรับเครื่อง CBC Mindary");

                entity.Property(e => e.Cbcipport).HasComment("Port สำหรับ IP Address สำหรับเครื่อง CBC Mindray");

                entity.Property(e => e.FuseClientId).HasComment("Client ID Fuse ใช้เชื่อมต่อ API Fuse");

                entity.Property(e => e.FuseClientPassword).HasComment("Client Password Fuse ใช้เชื่อมต่อ API Fuse");

                entity.Property(e => e.FusePassword).HasComment("Password Authorization Fuse");

                entity.Property(e => e.FuseUrl).HasComment("Url API ของ Fuse");

                entity.Property(e => e.FuseUserName).HasComment("UserName Authorization Fuse");

                entity.Property(e => e.IdexxmlfileNameFormat).HasComment("รูปแบบของชื่อไฟล์แบบ XML ของเครื่อง IDEXX");

                entity.Property(e => e.IdexxpdffileNameFormat).HasComment("รูปแบบของชื่อไฟล์แบบ PDF ของเครื่อง IDEXX");

                entity.Property(e => e.IdexxrequestFolderPath).HasComment("พาธเก็บไฟล์ Lab Request ของเครื่อง IDEXX");

                entity.Property(e => e.IdexxresultPdffolderPath).HasComment("พาธเก็บไฟล์ผลแล็บแบบ PDF ของเครื่อง IDEXX");

                entity.Property(e => e.IdexxresultXmlfolderPath).HasComment("พาธเก็บไฟล์ผลแล็บแบบ XML ของเครื่อง IDEXX");

                entity.Property(e => e.InstrumentName).HasComment("ชื่อเครื่องแล็บ1");

                entity.Property(e => e.InstrumentName2).HasComment("ชื่อเครื่องแล็บ2");

                entity.Property(e => e.LabDocGroup).HasComment("กลุ่มเอกสารสำหรับผล Lab");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้เครื่องแล็บนี้");
            });

            modelBuilder.Entity<Mlanguage>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LanguageCode })
                    .HasName("PK_MLanguage_1");

                entity.Property(e => e.LanguageCode).HasComment("รหัสภาษาใช้ Culture Keyword เช่น th-TH, en-US เป็นต้น");

                entity.Property(e => e.LanguageName).HasComment("ชื่อภาษา 1");

                entity.Property(e => e.LanguageName2).HasComment("ชื่อภาษา 2");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละภาษา(ไม่ควรซ้ำกัน)");
            });

            modelBuilder.Entity<MleaveType>(entity =>
            {
                entity.HasKey(e => new { e.LeaveTypeCode, e.CreateByOrgCode });

                entity.Property(e => e.Description).HasComment("Description");

                entity.Property(e => e.Description2).HasComment("Description 2");
            });

            modelBuilder.Entity<Mlocation>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CreateByOrgCode });

                entity.Property(e => e.LocationCode).HasComment("รหัสที่เก็บ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Building).HasComment("อาคาร");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsLocationItem).HasComment("เป็นข้อมูลของ 1=สินค้า   0,null=OPD Card,อื่นๆ");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.Lock).HasComment("กล่อง");

                entity.Property(e => e.Room).HasComment("ห้อง");

                entity.Property(e => e.Shelf).HasComment("ชั้น");
            });

            modelBuilder.Entity<Mmeeting>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MeetingCode });

                entity.Property(e => e.MeetingCode).HasComment("รหัสหัวข้อสัมนา");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");

                entity.Property(e => e.Institute).HasComment("สถาบัน");

                entity.Property(e => e.Location).HasComment("สถานที่สัมนา");

                entity.Property(e => e.MeetingByName).HasComment("วิทยากร");

                entity.Property(e => e.MeetingName).HasComment("หัวข้อการสัมนา");

                entity.Property(e => e.Method).HasComment("วิธีการสัมนา");

                entity.Property(e => e.Purpose).HasComment("วัตถุประสงค์");

                entity.Property(e => e.Reason).HasComment("หลักการและเหตุผล");

                entity.Property(e => e.ResponsibleBy).HasComment("ผู้รับผิดชอบโครงการ");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มต้น");
            });

            modelBuilder.Entity<MmemberCard>(entity =>
            {
                entity.Property(e => e.CardTypeCode).HasComment("รหัสชนิดบัตร");

                entity.Property(e => e.CardTypeName1).HasComment("ชื่อชนิดบัตรไทย");

                entity.Property(e => e.CardTypeName2).HasComment("ชื่อชนิดบัตรอังกฤษ");

                entity.Property(e => e.InActive).HasComment("ยังใช้งานอยู่หรือไม่ 0 ใช้  1 เลิกใช้");

                entity.Property(e => e.InitialMoney).HasComment("เงินขั้นต่ำตอนออกบัตร");

                entity.Property(e => e.InitialPoint).HasComment("แต้มที่ได้ทันทีเมื่อออกบัตร");

                entity.Property(e => e.PointRate).HasComment("อัตรการคิดแต้ม บาทต่อหนึ่งแต้ม");
            });

            modelBuilder.Entity<MmesssageGroup>(entity =>
            {
                entity.HasKey(e => new { e.MessageGroupId, e.CreateByOrgCode });

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<Morganization>(entity =>
            {
                entity.HasKey(e => e.OrganizationCode)
                    .HasName("PK__MOrganization__71B3832E");

                entity.Property(e => e.OrganizationCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AccountCode).HasComment("Account code");

                entity.Property(e => e.BeginPeriodDate).HasComment("วันที่เริ่มต้นรอบปีบัญชี");

                entity.Property(e => e.BusinessAddress1).HasComment("เลขที่บริษัท");

                entity.Property(e => e.BusinessAddress2).HasComment("หมู่ที่บริษัท");

                entity.Property(e => e.BusinessAmphurName).HasComment("ชื่ออำเภอบริษัท");

                entity.Property(e => e.BusinessEmail).HasComment("Email บริษัท");

                entity.Property(e => e.BusinessFax).HasComment("เบอร์แฟ็กซ์บริษัท");

                entity.Property(e => e.BusinessName).HasComment("Business name");

                entity.Property(e => e.BusinessName2).HasComment("Business name2");

                entity.Property(e => e.BusinessPostCode).HasComment("รหัสไปรษณีย์บริษัท");

                entity.Property(e => e.BusinessProvinceName).HasComment("ชื่อจังหวัดบริษัท");

                entity.Property(e => e.BusinessRoad).HasComment("ถนนบริษัท");

                entity.Property(e => e.BusinessTelephone).HasComment("เบอร์โทรศัพท์บริษัท");

                entity.Property(e => e.BusinessTumbonName).HasComment("ชื่อตำบลบริษัท");

                entity.Property(e => e.BusinessWebSite).HasComment("WebSite บริษัท");

                entity.Property(e => e.CommercialNo).HasComment("เลขทะเบียนการค้า");

                entity.Property(e => e.Contact).HasComment("ชื่อผู้ติดต่อ");

                entity.Property(e => e.CreateByCode).HasComment("Created by code");

                entity.Property(e => e.CurrentAddress1).HasComment("เลขที่");

                entity.Property(e => e.CurrentAddress2).HasComment("หมู่ที่");

                entity.Property(e => e.CurrentAmphurName).HasComment("ชื่ออำเภอ");

                entity.Property(e => e.CurrentEmail).HasComment("Email");

                entity.Property(e => e.CurrentFax).HasComment("เบอร์แฟค");

                entity.Property(e => e.CurrentPostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.CurrentProvinceName).HasComment("ชื่อจังหวัด");

                entity.Property(e => e.CurrentRoad).HasComment("ถนน");

                entity.Property(e => e.CurrentTelephone).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.CurrentTumbonName).HasComment("ชื่อตำบล");

                entity.Property(e => e.CurrentWebSite).HasComment("WebSite");

                entity.Property(e => e.CurrentYear).HasComment("Current year");

                entity.Property(e => e.DeleteAppointment).HasComment("กำหนดลบข้อมูลนัดหมาย(วัน)");

                entity.Property(e => e.DepreciationMethodId).HasComment("รหัสวิธีคำนวณค่าเสื่อมราคา 0=เส้นตรง");

                entity.Property(e => e.Disc).HasComment("Disc");

                entity.Property(e => e.ExpireDate).HasComment("วันที่ Expire ของการใช้งาน");

                entity.Property(e => e.HospitalName).HasComment("ชือโรงพยาบาล");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.InventoryCostType).HasComment("วิธีคิดต้นทุนขาย 0=เฉลี่ย 1=Fifo 2=Index");

                entity.Property(e => e.IsAutoLiveUpdate).HasComment("Live Update หรือไม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.IsTransferItemByPronly).HasComment("1=ใช้ใบ PR ในการเบิก/โอนสินค้าเท่านั้น");

                entity.Property(e => e.JoinPassword).HasComment("รหัสผ่านในการเชื่อมต่อเป็นสาขาย่อย");

                entity.Property(e => e.LanguageType).HasComment("ใช้ภาษา");

                entity.Property(e => e.LastSyncDateTime).HasComment("วันที่และเวลาที่ Sync");

                entity.Property(e => e.LateCode).HasComment("Late code");

                entity.Property(e => e.LeaveCode).HasComment("Leave code");

                entity.Property(e => e.LicenseNoForAnimalHospital).HasComment("เลขที่ใบอนุญาตตั้งสถานพยาบาลสัตว์");

                entity.Property(e => e.LicenseNoForAnimalNursing).HasComment("เลขที่ใบอนุญาตดำเนินการสถานพยาบาลสัตว์");

                entity.Property(e => e.MaximumStaff).HasComment("จำนวน Staff สูงสุดที่อนุญาต");

                entity.Property(e => e.ModByCode).HasComment("Modified by code");

                entity.Property(e => e.ModDate).HasComment("Modified date");

                entity.Property(e => e.NotSyncDataAmount).HasComment("จำนวนข้อมูลที่ยังไม่ได้ส่ง");

                entity.Property(e => e.OrganizationId).HasComment("เลขทะเบียนนิติบุคคล");

                entity.Property(e => e.OrganizationName).HasComment("ชื่อหน่วยงาน");

                entity.Property(e => e.OrganizationTaxCode)
                    .IsFixedLength(true)
                    .HasComment("Organization tax code");

                entity.Property(e => e.OrganizationTaxId).HasComment("ประจำตัวผู้เสียภาษี");

                entity.Property(e => e.OrganizationTypeId).HasComment("นิติบุคคล");

                entity.Property(e => e.ProvidentFundCode)
                    .IsFixedLength(true)
                    .HasComment("Provident fund code");

                entity.Property(e => e.Remark).HasComment("Remark");

                entity.Property(e => e.RevenueTax).HasComment("Revenue tax");

                entity.Property(e => e.RevenueTaxTypeId).HasComment("รหัสวิธิคิดภาษีเงินได้นิติบุคคล 0=อัตราเดียว 1=ขั้นบันได");

                entity.Property(e => e.ShowAbsoluteDateReport).HasComment("แสดงวันที่ขณะดูรายงาน -1, 0");

                entity.Property(e => e.SocialInsuranceCode)
                    .IsFixedLength(true)
                    .HasComment("Social insurance code");

                entity.Property(e => e.StartSystemDate).HasComment("วันที่เริ่มใช้ระบบ");

                entity.Property(e => e.TaxCal).HasComment("Tax calculation");

                entity.Property(e => e.TaxCardNo).HasComment("--- ยกเลิกการใช้งาน ---");

                entity.Property(e => e.TaxDocNo).HasComment("Tax document no.");

                entity.Property(e => e.TaxMinBase).HasComment("มูลค่าขั้นต่ำในการคิดภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatTypeId).HasComment("รหัสประเภทภาษีมูลค่าเพิ่ม (ไม่มี แยกนอก รวมใน)");

                entity.Property(e => e.WorkHoursDay).HasComment("Working hours for day paid employee");

                entity.Property(e => e.WorkHoursSalary).HasComment("Working hours for salary man");
            });

            modelBuilder.Entity<MorganizationLogo>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.CreateByOrgCode });

                entity.Property(e => e.OrganizationCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.OrganizationLogoName).HasComment("ชื่อไฟล์ Logo");

                entity.Property(e => e.OrganizationLogoPath).HasComment("ตำแหน่งเก็บไฟล์ Logo");
            });

            modelBuilder.Entity<MpackageItem>(entity =>
            {
                entity.HasKey(e => new { e.PackageCode, e.CreateByOrgCode, e.SeqId })
                    .HasName("PK_MItemPackage");

                entity.Property(e => e.PackageCode).HasComment("รหัสสินค้าชุด");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่");

                entity.Property(e => e.Dose1).HasComment("วิธีใช้ 1");

                entity.Property(e => e.Dose2).HasComment("วิธีใช้ 2");

                entity.Property(e => e.Dose3).HasComment("วิธีใช้ 3");

                entity.Property(e => e.Dose4).HasComment("วิธีใช้ 4");

                entity.Property(e => e.Dose5).HasComment("วิธีใช้ 5");

                entity.Property(e => e.Dose6).HasComment("วิธีใช้ 6");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IncentiveAllFix).HasComment("ค่าตอบแทนส่วนกลาง");

                entity.Property(e => e.IncentiveAllRate).HasComment("อัตราค่าตอบแทนส่วนกลาง");

                entity.Property(e => e.IncentiveDiagFix).HasComment("ค่าตอบแทนในการตรวจ");

                entity.Property(e => e.IncentiveDiagRate).HasComment("อัตราค่าตอบแทนในการตรวจ");

                entity.Property(e => e.IncentiveDoFix).HasComment("ค่าตอบแทนในการทำ");

                entity.Property(e => e.IncentiveDoRate).HasComment("ิัอัตราค่าตอบแทนในการทำ");

                entity.Property(e => e.IncentiveSellFix).HasComment("ค่าตอบแทนในการขาย");

                entity.Property(e => e.IncentiveSellRate).HasComment("อัตราค่าตอบแทนในการขาย");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าในชุด");

                entity.Property(e => e.ItemPriceSeqId).HasComment("ลำดับราคาของราคาขายแบบหลายหน่วย");

                entity.Property(e => e.Quantity).HasComment("จำนวนในชุด");

                entity.Property(e => e.QuantityTypeId).HasComment("1-ตามจำนวนที่สั่งตัวชุด/ 2-คงที่ตั้งไว้เท่าไหร่ก็ไม่คูณกับจำนวนชุด");

                entity.Property(e => e.Total).HasComment("ราคารวม");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนต่อหน่วย");

                entity.Property(e => e.UnitPrice).HasComment("ราคาต่อหน่วยในชุด");
            });

            modelBuilder.Entity<MpaymentType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PaymentTypeCode });

                entity.Property(e => e.IsCheque).HasComment("เป็นการจ่ายด้วยเช็คหรือไม่");

                entity.Property(e => e.PaymentTypeId).HasComment("รูปแบบการจ่าย 1เงินสด, 2บัตรเครดิต, 3เช็ค, 4คูปอง");
            });

            modelBuilder.Entity<MpayrollOption>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.CreateByOrgCode })
                    .HasName("PK_MPayrollOptionsNew");

                entity.Property(e => e.BankAccountNo).HasComment("หมายเลขบัญชีธนาคารของบริษัท");

                entity.Property(e => e.BankBranchCode).HasComment("รหัสสาขาธานาคารของบริษัท");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคารของบริษัท");

                entity.Property(e => e.CreateByCode).HasComment("Izpal field");

                entity.Property(e => e.CreateDate).HasComment("Izpal field");

                entity.Property(e => e.CurrentPeriod).HasComment("งวดปัจจุบันที่จะคำนวณ Payroll (ยังไม่ปิด)");

                entity.Property(e => e.CurrentPeriodContract).HasComment("เก็บค่างวดปัจจุบันของประเภทงวดพนักงานเหมาจ่าย");

                entity.Property(e => e.CurrentPeriodDaily).HasComment("เก็บค่างวดปัจจุบันของประเภทงวดพนักงานรายเดือน");

                entity.Property(e => e.CurrentPeriodHourly).HasComment("งวดปัจจุบันที่จะคำนวณ Payroll (ยังไม่ปิด), เก็บค่างวดปัจจุบันของประเภทงวดพนักงานรายชั่วโมง");

                entity.Property(e => e.CurrentPeriodMonthly).HasComment("เก็บค่างวดปัจจุบันของประเภทงวดพนักงานรายเดือน");

                entity.Property(e => e.CurrentYear).HasComment("ปีปัจจุบันที่กำลังทำงาน");

                entity.Property(e => e.DeductForAbsentBahtPerDay).HasComment("จำนวนเงินที่จะหักต่อวันที่ขาดงาน (ไม่ได้ลา)");

                entity.Property(e => e.DeductForLateBahtPerHour).HasComment("จำนวนเงินที่จะหักต่อชั่วโมงเมื่อมาสาย");

                entity.Property(e => e.InActive).HasComment("Izpal field");

                entity.Property(e => e.IsSystem).HasComment("Izpal field");

                entity.Property(e => e.ModByCode).HasComment("Izpal field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal field");

                entity.Property(e => e.ModDate).HasComment("Izpal field");

                entity.Property(e => e.Ot1).HasComment("โอทีในเวลางานของวันหยุดที่มีการจ่ายเงิน");

                entity.Property(e => e.Ot2).HasComment("โอทีนอกเวลางานของวันทำงาน");

                entity.Property(e => e.Ot3).HasComment("โอทีในเวลางานของวันหยุดที่ไม่มีการจ่ายเงิน");

                entity.Property(e => e.Ot4).HasComment("นอกเวลางานของวันหยุด");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal field");

                entity.Property(e => e.PsdeLateFrom).HasComment("PONGSAK หักมาสายจากบัญชีเงินเดือน(Salary)  หรือ บัญชีรายได้อื่นๆ (Other)");

                entity.Property(e => e.PsdeLeaveFrom).HasComment("PONGSAK หักไม่มาทำงานจากบัญชีเงินเดือน(Salary)  หรือ บัญชีรายได้อื่นๆ (Other)");

                entity.Property(e => e.PsdeMissItemFrom).HasComment("PONGSAK หักของหายจากบัญชีเงินเดือน(Salary)  หรือ บัญชีรายได้อื่นๆ (Other)");

                entity.Property(e => e.PsdeOtherFrom).HasComment("PONGSAK หักเงินจากรายการหักอื่นๆ จากบัญชีเงินเดือน(Salary)  หรือ บัญชีรายได้อื่นๆ (Other)");

                entity.Property(e => e.PsfixSociDeduct).HasComment("PONGSAK ยอดที่จะโดนหักประกันสังคมในงวดนั้นๆ ไม่ต้องคำนวณ (สำนักงานใหญ่บอกตัวเลขมา) เหมือนกันทุกคน");

                entity.Property(e => e.PsfixSociSalary).HasComment("PONGSAK ยอดเงินเดือนแบบ Fix สำหรับกำหนดค่าส่งประกันสังคมโดยตรง เหมือนกันทุกคน");

                entity.Property(e => e.PsisUseNormalSocialCalc).HasComment("PONGSAK สำหรับแพทย์พงศ์ศักดิ์จะให้ใช้วิธีคำนวณประกันสังคมแบบปกติ หรือ ให้ใส่ค่า Fix ลงไปตรงๆ");

                entity.Property(e => e.PsotperDay).HasComment("จำนวนชั่วโมงที่ทำ OT ต่อวัน (โดยปกติพนักงานต้องทำ OT ทุกวันอยู่แล้ว)");

                entity.Property(e => e.PspercentCenter1).HasComment("PONGSAK % ส่วนรวมขั้นที่ 1");

                entity.Property(e => e.PspercentCenter2).HasComment("PONGSAK % ส่วนรวมขั้นที่ 2");

                entity.Property(e => e.PspercentCenter4Manager).HasComment("PONGSAK % ส่วนรวมที่จะให้ผู้จัดการ");

                entity.Property(e => e.PspercentCenter4Staff).HasComment("PONGSAK % ส่วนรวมที่จะแบ่งให้พนักงาน");

                entity.Property(e => e.PspercentDeligent1).HasComment("PONGSAK % ตั้งต้นเบี้ยขยัน");

                entity.Property(e => e.PspercentDeligent2).HasComment("PONGSAK % เบี้ยขยันที่จะนำไปหารแบ่งพนักงาน");

                entity.Property(e => e.PspercentOver1M).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน");

                entity.Property(e => e.PspercentOver1Mstep1).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน 1,000,000 - 1,500,000");

                entity.Property(e => e.PspercentOver1Mstep2).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน 1,500,001 - 1,800,000");

                entity.Property(e => e.PspercentOver1Mstep3).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน >= 1,800,001");

                entity.Property(e => e.PspercentOver1Mstep4).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน สำรองไว้ใช้");

                entity.Property(e => e.PspercentOver1Mstep5).HasComment("PONGSAK % ส่วนแบ่งยอดเกินล้าน สำรองไว้ใช้");

                entity.Property(e => e.Remark).HasComment("Izpal field");

                entity.Property(e => e.RoundUpOt).HasComment("รหัสรูปแบบการปัดเศษค่าล่วงเวลา");

                entity.Property(e => e.RoundUpProvident).HasComment("รหัสรูปแบบการปัดเศษเงินกองทุนสำรองฯ");

                entity.Property(e => e.RoundUpSoci).HasComment("รหัสรูปแบบการปัดเศษเงินประกันสังคม");

                entity.Property(e => e.RoundUpTax).HasComment("รหัสรูปแบบการปัดเศษภาษีเงินได้");

                entity.Property(e => e.SociMaxDeduct).HasComment("เงินที่จะหักประกันสังคมสูงสุด");

                entity.Property(e => e.SociMaxIncome).HasComment("รายได้คำนวณหักประกันสังคมสูงสุด");

                entity.Property(e => e.SociMinDeduct).HasComment("เงินที่จะหักประกันสังคมต่ำสุด");

                entity.Property(e => e.SociMinIncome).HasComment("รายได้คำนวณหักประกันสังคมต่ำสุด");

                entity.Property(e => e.SociRate).HasComment("อัตราสมทบประกันสังคม");

                entity.Property(e => e.StartSystemDate).HasComment("Izpal field");

                entity.Property(e => e.TaxBookNo).HasComment("เล่มที่ ของหนังสือรับรองหัก ณ ที่จ่าย (52 ทวิ)");

                entity.Property(e => e.TaxCalcMethod).HasComment("วิธีคำนวณภาษี 0 =  แบบเฉลี่ย 12 เดือน , 1= แบบสะสมแต่ละเดือน");

                entity.Property(e => e.TaxdeChildMax).HasComment("จำนวนบุตรที่ลดหย่อนได้สูงสุด(รวมทั้งศึกษาและไม่ศึกษา)");

                entity.Property(e => e.TaxdeChildNotStudyMax).HasComment("ลดหย่อนค่าบุตรไม่ได้ศึกษา หรือ ศึกษาต่างประเทศ");

                entity.Property(e => e.TaxdeChildStudyMax).HasComment("ลดหย่อนค่าบุตรศึกษาในประเทศ");

                entity.Property(e => e.TaxdeDadMax).HasComment("ลดหย่อนบิดาผู้มีเงินได้");

                entity.Property(e => e.TaxdeDadMomHealthInsuranceMax).HasComment("ลดหย่อนประกันสุขภาพบิดามารดาผู้มีเงินได้");

                entity.Property(e => e.TaxdeDadMomSpouseHealthInsuranceMax).HasComment("ลดหย่อนประกันสุขภาพบิดามารดาคู่สมรสของผู้มีเงินได้");

                entity.Property(e => e.TaxdeDadSpouseMax).HasComment("ลดหย่อนบิดาคู่สมรส");

                entity.Property(e => e.TaxdeDonateEduMaxPercent).HasComment("หักเงินค่าบริจาคเพื่อการศึกษา ได้ไม่เกินจำนวน % ของ ก.10");

                entity.Property(e => e.TaxdeDonateEduRatio).HasComment("หักเงินค่าบริจาคเพื่อการศึกษา ได้ไม่เกินจำนวนเท่าที่ระบุไว้นี้");

                entity.Property(e => e.TaxdeDonateMax).HasComment("ลดหย่อนเงินบริจาคอื่น ๆ ได้ไม่เกินจำนวนที่ระบุนี้");

                entity.Property(e => e.TaxdeDonateSportMaxPercent).HasComment("หักเงินค่าบริจาคเพื่อการกีฬา ได้ไม่เกินจำนวน % ของ ก.10");

                entity.Property(e => e.TaxdeDonateSportRatio).HasComment("หักเงินค่าบริจาคเพื่อการกีฬา ได้ไม่เกินจำนวนเท่าที่ระบุไว้นี้");

                entity.Property(e => e.TaxdeHouseLoanInterestMax).HasComment("ลดหย่อนดอกเบี้ยกู้ยืมเพื่อที่อยู่อาศัยได้สูงสุดตามจำนวนนี้");

                entity.Property(e => e.TaxdeLifeInsuranceFirstPartMax).HasComment("ลดหย่อนประกันชีวิตส่วนแรก");

                entity.Property(e => e.TaxdeLifeInsuranceSecondPartMax).HasComment("ลดหย่อนประกันชีวิตส่วนที่สอง");

                entity.Property(e => e.TaxdeMomMax).HasComment("ลดหย่อนมารดาผู้มีเงินได้");

                entity.Property(e => e.TaxdeMomSpouseMax).HasComment("ลดหย่อนมารดาคู่สมรส");

                entity.Property(e => e.TaxdePayerMax).HasComment("ลดหย่อนผู้มีเงินได้");

                entity.Property(e => e.TaxdeProvidentFundMax).HasComment("ลดหย่อนกองทุนสำรองเลี้ยงชีพ");

                entity.Property(e => e.TaxdeSocialMax).HasComment("ลดหย่อนประกันสังคมได้สูงสุดตามจำนวนนี้");

                entity.Property(e => e.TaxdeSpendMax).HasComment("ค่าใช้จ่ายผู้มีเงินได้ , คู่สมรสหักได้ไม่เกิน (บาท)");

                entity.Property(e => e.TaxdeSpendMaxPercent).HasComment("ค่าใช้จ่ายผู้มีเงินได้ , คู่สมรสหักได้ไม่เกิน %");

                entity.Property(e => e.TaxdeSpouseMax).HasComment("ลดหย่อนคู่สมรส กรณีรวมคำนวณ หรือ คู่สมรสไม่มีรายได้");

                entity.Property(e => e.TaxdeStockLongPeriodMax).HasComment("ลดหย่อนหน่วยลงทุนกองทุนรวมหุ้นระยะยาว ไม่เกินจำนวนเงินที่ระบุนี้");

                entity.Property(e => e.TaxdeStockLongPeriodMaxPercent).HasComment("ลดหย่อนหน่วยลงทุนกองทุนรวมหุ้นระยะยาว ไม่เกิน % ของเงินได้");

                entity.Property(e => e.TaxdeStockProvidentFundMax).HasComment("ลดหย่อนหน่วยลงทุนกองทุนรวมเพื่อการเลี้ยงชีพไม่เกินจำนวนเงิน กองทุน กบข กับ กองทุนเลี้ยงชีพรวมกัน");

                entity.Property(e => e.TaxdeStockProvidentFundMaxPercent).HasComment("ลดหย่อนหน่วยลงทุนกองทุนรวมเพื่อการเลี้ยงชีพไม่เกิน % ของเงินได้");

                entity.Property(e => e.TotalHourForDayStaff).HasComment("ชั่วโมงทำงานของพนักงานรายวัน");

                entity.Property(e => e.TotalHourForMonthStaff).HasComment("ชั่วโมงทำงานของพนักงานรายเดือน");

                entity.Property(e => e.TotalLateBecome2Absent).HasComment("จำนวนครั้งที่สาย จะถูกปรับเป็นขาดงาน 1 วัน");

                entity.Property(e => e.TotalPeriodStaffContract).HasComment("จำนวนงวดทั้งหมดในปีปัจจุบัน ของพนักงานเหมาจ่าย");

                entity.Property(e => e.TotalPeriodStaffDay).HasComment("จำนวนงวดทั้งหมดในปีปัจจุบัน ของพนักงานรายวัน");

                entity.Property(e => e.TotalPeriodStaffHour).HasComment("จำนวนงวดทั้งหมดในปีปัจจุบัน ของพนักงานรายชั่วโมง");

                entity.Property(e => e.TotalPeriodStaffMonth).HasComment("จำนวนงวดทั้งหมดในปีปัจจุบัน ของพนักงานรายเดือน");
            });

            modelBuilder.Entity<MpayrollPeriod>(entity =>
            {
                entity.HasKey(e => new { e.PeriodCode, e.CreateByOrgCode })
                    .HasName("PK_MPeriod");

                entity.Property(e => e.PeriodCode).HasComment("รหัสงวด");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.DateEndStaffContract).HasComment("วันสิ้นงวดพนักงานเหมาจ่าย");

                entity.Property(e => e.DateEndStaffDay).HasComment("วันสิ้นงวดพนักงานรายวัน");

                entity.Property(e => e.DateEndStaffHour).HasComment("วันสิ้นงวดพนักงานชั่วโมง");

                entity.Property(e => e.DateEndStaffMonth).HasComment("วันสิ้นงวดพนักงานรายเดือน");

                entity.Property(e => e.DateStartStaffContract).HasComment("วันเริ่มงวดพนักงานเหมาจ่าย");

                entity.Property(e => e.DateStartStaffDay).HasComment("วันเริ่มงวดพนักงานรายวัน");

                entity.Property(e => e.DateStartStaffHour).HasComment("วันเริ่มงวดพนักงานชั่วโมง");

                entity.Property(e => e.DateStartStaffMonth).HasComment("วนเริ่มงวดพนักงานรายเดือน");

                entity.Property(e => e.IsClose).HasComment("งวดนี้ปิดหรือยัง?");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.PayDate).HasComment("วันที่จ่ายเงิน");

                entity.Property(e => e.PeriodNo).HasComment("งวดที่");

                entity.Property(e => e.PeriodYear).HasComment("ปีที่");

                entity.Property(e => e.TotalDay).HasComment("จำนวนวัน 100% ของงวด");

                entity.Property(e => e.TotalHour).HasComment("จำนวนชั่วโมง 100% ของงวด");
            });

            modelBuilder.Entity<MpictureTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode });

                entity.Property(e => e.TemplateExt).HasComment("นามสกุลไฟล์");
            });

            modelBuilder.Entity<MpongsakIncome>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.IncomeDate });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.IncomeDate).HasComment("รายได้ลงวันที่");

                entity.Property(e => e.CourseAcc).HasComment("คอร์สการเงิน");

                entity.Property(e => e.CourseDoc).HasComment("คอร์สแพทย์");

                entity.Property(e => e.CourseStaff).HasComment("คอร์สพนักงาน");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.CusBuyMed).HasComment("ซื้อยา");

                entity.Property(e => e.DateSave).HasComment("วันที่บันทึก");

                entity.Property(e => e.DisCourseAcc).HasComment("ส่วนลดคอร์สการเงิน");

                entity.Property(e => e.DisCourseDoc).HasComment("ส่วนลดคอร์สแพทย์");

                entity.Property(e => e.DisCourseStaff).HasComment("ส่วนลดคอร์สพนักงาน");

                entity.Property(e => e.DisCusBuyMed).HasComment("ส่วนลดซื้อยา");

                entity.Property(e => e.DisMeetDoc).HasComment("ส่วนลดพบแพทย์");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.MeetDoc).HasComment("พบแพทย์");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.NetCourseAcc).HasComment("คอร์สการเงินสุทธิ");

                entity.Property(e => e.NetCourseDoc).HasComment("คอร์สแพทย์สุทธิ");

                entity.Property(e => e.NetCourseStaff).HasComment("คอร์สพนักงานสุทธิ");

                entity.Property(e => e.NetCusBuyMed).HasComment("ซื้อยาสุทธิ");

                entity.Property(e => e.NetMeetDoc).HasComment("พบแพทย์สุทธิ");

                entity.Property(e => e.NetReturnMed).HasComment("คืนยาสุทธิ");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.SaveBy).HasComment("บันทึกโดย(รหัสพนักงาน)");
            });

            modelBuilder.Entity<Mposoption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode });

                entity.Property(e => e.AutoPurchaseQuantityTypeId).HasComment("1=ตามค่าสูงสุด 2=ตามครั้งล่าสุด");

                entity.Property(e => e.CostTypeId).HasComment("ประเภทต้นทุน 1=เฉลี่ย 2 = แทนที่");

                entity.Property(e => e.FontColor).HasComment("สีตัวอักษรของหน้าจอ 2");

                entity.Property(e => e.IsAutoOrderByBarcode).HasComment("สั่งสินค้าทันทีด้วย Barcode");

                entity.Property(e => e.IsAutoPrintLabel).HasComment("พิมพ์ฉลากยาทันทีเมื่อคลิกรับเงิน");

                entity.Property(e => e.IsAutoPrintReceipt).HasComment("พิมพ์ใบเสร็จอัตโนมัติเมื่อรับเงิน");

                entity.Property(e => e.IsAutoRunInvoiceNoWhenSales).HasComment("ออกเลขที่ใบกำกับภาษีเลยหรือไม่เวลาขาย");

                entity.Property(e => e.IsMustEnterQueCode).HasComment("ต้องใส่รหัสเครื่องจุดขายหรือไม่");

                entity.Property(e => e.IsOpenCashDrawerWhenReceiveMoney).HasComment("เปิดลิ้นชักเมื่อรับเงิน");

                entity.Property(e => e.IsSaveElectronicJournal).HasComment("บันทึก Electronic Journal หรือไม่");

                entity.Property(e => e.IsShowCostWhenSales).HasComment("แสดงต้นทุนเมื่อขาย");

                entity.Property(e => e.IsShowCurrentQuantityItemCount).HasComment("แสดงยอดคงเหลือขณะตรวจนับหรือไม่");

                entity.Property(e => e.IsShowMoneyWhenReceive).HasComment("แสดงยอดเงินขณะรับเงินหรือไม่");

                entity.Property(e => e.IsShowOutstandingWhenSales).HasComment("แสดงยอดคงเหลือเมื่อขาย");

                entity.Property(e => e.IsSingleCustomerPerQue).HasComment("กำหนดให้มีลูกค้าคนเดียวในคิวหรือไม่");

                entity.Property(e => e.ProgramTypeId).HasComment("1=ทัวไป 2=DrugStore");

                entity.Property(e => e.ThemeColor).HasComment("สีธีมของหน้าจอ 2");
            });

            modelBuilder.Entity<Mprocedure>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProcedureCode });
            });

            modelBuilder.Entity<Mproject>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProjectCode });
            });

            modelBuilder.Entity<MprojectType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProjectTypeCode });
            });

            modelBuilder.Entity<Mprovince>(entity =>
            {
                entity.HasKey(e => new { e.ProvinceCode, e.CreateByOrgCode });

                entity.Property(e => e.ProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsDefault).HasComment("Default ในแสดงทำบัตรใหม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ProvinceName).HasComment("ชื่อจังหวัด");
            });

            modelBuilder.Entity<Mque>(entity =>
            {
                entity.HasKey(e => new { e.QueCode, e.CreateByOrgCode });

                entity.Property(e => e.QueCode).HasComment("รหัสห้อง/ชื่อห้อง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CashDrawerTypeId).HasComment("0=Serial, 1=ผ่านเครื่องพิมพ์");

                entity.Property(e => e.ClinicCode).HasComment("รหัสคลินิก");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsAlertOpinion).HasComment("แจ้งเตือนเมื่อไม่ได้กรอกความเห็น");

                entity.Property(e => e.IsHideCourseItem).HasComment("ไม่แสดงรายการคอร์ส");

                entity.Property(e => e.IsHideDrugItem).HasComment("ไม่แสดงรายการยา");

                entity.Property(e => e.IsHideLabItem).HasComment("ไม่แสดงรายการ Lab");

                entity.Property(e => e.IsHideProductItem).HasComment("ไม่แสดงรายการสินค้า");

                entity.Property(e => e.IsHideServiceItem).HasComment("ไม่แสดงรายการบริการ");

                entity.Property(e => e.IsHideVaccineItem).HasComment("ไม่แสดงรายการวัคซีน");

                entity.Property(e => e.IsHideXrayItem).HasComment("ไม่แสดง X-ray");

                entity.Property(e => e.IsShowAnimalSickStatistics).HasComment("แสดงแท็บสถิติสัตว์ป่วยหรือไม่");

                entity.Property(e => e.IsShowAppoinment).HasComment("ต้องการแสดงหน้านัดหมายตอนส่งคิวหรือไม่");

                entity.Property(e => e.IsShowCheckUp).HasComment("ไม่แสดงรายการ CheckUp");

                entity.Property(e => e.IsShowChieftComplaint).HasComment("แสดง Tab อาการเบื้องต้นหรือไม่");

                entity.Property(e => e.IsShowCustomerInfo).HasComment("แสดงข้อมูลลูกค้า");

                entity.Property(e => e.IsShowDiag).HasComment("แสดง Tab ICD 10 ์หรือไม่");

                entity.Property(e => e.IsShowDoctorNote).HasComment("แสดง Tab หมายเหตุแพทย์หรือไม่");

                entity.Property(e => e.IsShowDocument).HasComment("แสดงแท็บเอกสารหรือไม่");

                entity.Property(e => e.IsShowDrugHistory).HasComment("แสดง Tab ประวัติการจ่ายยาหรือไม่");

                entity.Property(e => e.IsShowIcd10).HasComment("แสดงหน้าต่าง ICD10 เมื่อส่งคิว");

                entity.Property(e => e.IsShowItem).HasComment("แสดง Tab รายการค่ารักษาหรือไม่");

                entity.Property(e => e.IsShowItemAndReceive).HasComment("แสดงแท็บสั่งรายการและรับเงิน(All In One)");

                entity.Property(e => e.IsShowIvtherapy).HasComment("แสดงแท็บการรักษาด้วยสารน้ำ");

                entity.Property(e => e.IsShowLab).HasComment("แสดง Tab Lab หรือไม่");

                entity.Property(e => e.IsShowMarkPicture).HasComment("แสดง tab มาร์กรูป ในห้องนี้หรือไม่");

                entity.Property(e => e.IsShowOperation).HasComment("แสดง Tab ICD9CM หรือไม่");

                entity.Property(e => e.IsShowProgressNote).HasComment("ซ่อนรายการ Progress Note");

                entity.Property(e => e.IsShowReceipt).HasComment("แสดงหน้าจอการรับเงินของลูกค้า");

                entity.Property(e => e.IsShowReceiveMoney).HasComment("แสดง Tab การรับเงินหรือไม่");

                entity.Property(e => e.IsShowReferIn).HasComment("แสดงหน้าต่างข้อมูลการมารักษาเมื่อส่งคิว");

                entity.Property(e => e.IsShowReferOut).HasComment("แสดงหน้าต่างบันทึกข้อมูลการปล่อยเมื่อส่งคิว");

                entity.Property(e => e.IsShowSpermOvumBank).HasComment("แสดงแท๊ปฝากสเปิร์ม/ไข่");

                entity.Property(e => e.IsShowTabAppointment).HasComment("ต้องการให้แสดง Tab นัดหมายคู่กับ Tab Que หรือไม่");

                entity.Property(e => e.IsShowXray).HasComment("แสดง Tab X-Ray หรือไม่");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.LastLogInBy).HasComment("ชื่อผู้เข้าสู่ระบบ");

                entity.Property(e => e.LastLogInTime).HasComment("วัน เวลา ที่ Log In เข้าใช้งาน");

                entity.Property(e => e.LayOutLeft).HasComment("ตำแหน่ง LayOut ด้าน Left");

                entity.Property(e => e.LayOutTop).HasComment("ตำแหน่งใน LayOut ส่วน Top");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้ห้องนี้");

                entity.Property(e => e.QueGroupCode).HasComment("รหัสกลุ่มคิว");

                entity.Property(e => e.QueName).HasComment("ชื่อห้อง");

                entity.Property(e => e.SeatQuantity).HasComment("จำนวนที่นั่ง");

                entity.Property(e => e.ShowColor).HasComment("สีประชำห้อง");

                entity.Property(e => e.SoundFilePath).HasComment("ที่ตั้งไฟล์เสียงเพื่อใช้กับระบบเรียกคิว");

                entity.Property(e => e.TemplateId).HasComment("รูปแบบห้อง 0,Null ห้องเวชระเบียน ,1 ตรวจ,2 การเงิน,3 ICU");
            });

            modelBuilder.Entity<MqueGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.QueGroupCode });
            });

            modelBuilder.Entity<MqueLocation>(entity =>
            {
                entity.HasKey(e => new { e.QueLocationId, e.CreateByOrgCode });

                entity.Property(e => e.QueLocationId)
                    .ValueGeneratedOnAdd()
                    .HasComment("Running ตำแหน่งที่ตั้ง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.QueLocationCode).HasComment("รหัสตำแหน่งที่ตั้ง");

                entity.Property(e => e.QueLocationName).HasComment("ชื่อตำแหน่งที่ตั้ง");

                entity.Property(e => e.SeqId).HasComment("ลำดับตำแหน่งที่ตั้ง");
            });

            modelBuilder.Entity<MreceiptHeader>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptHeaderCode, e.CreateByOrgCode })
                    .HasName("PK_MReceiptGroup");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทเอกสารที่พิมพ์");

                entity.Property(e => e.FieldDocTypeId).HasComment("ประเภทใบเสร็จ 0=ใบเสร็จ 1=ใบแจ้งหนี้");

                entity.Property(e => e.FieldTypeId).HasComment("1=Invoice, 0= Receipt");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsPrintByOrderAmount).HasComment("พิมพ์ตามจำนวนที่สั่ง");

                entity.Property(e => e.IsRunningNo).HasComment("ให้รันเลขหรือไม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");
            });

            modelBuilder.Entity<Mrecruit>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RecruitCode });

                entity.Property(e => e.IsStaff).HasComment("เป็นพนักงานหรือไม่");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<MrecruitImage>(entity =>
            {
                entity.HasKey(e => new { e.RecruitCode, e.CreateByOrgCode });
            });

            modelBuilder.Entity<Mreport>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.CreateByOrgCode });

                entity.Property(e => e.ReportId).HasComment("รหัสรายงาน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ReportName).HasComment("ชื่อรายงาน");
            });

            modelBuilder.Entity<MrequestStatus>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StatusCode });
            });

            modelBuilder.Entity<Mroom>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RoomCode });

                entity.Property(e => e.DayCareTypeId).HasComment("ประเภทการฝากเลี้ยง 1 รายวัน 2 ราย ชม.");

                entity.Property(e => e.DiscountTypeId).HasComment("ประเภทส่วนลด 1 จำนวนเงินส่วนลดตัวต่อไป 2 จำนวน%ส่วนลดตัวต่อไป");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าค่าห้อง/คืน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้กรงนี้");

                entity.Property(e => e.PetsPerCustomer).HasComment("จำนวนเข้าพักได้สูงสุด");

                entity.Property(e => e.ReserveDate).HasComment("วันที่จอง");

                entity.Property(e => e.ReserveTime).HasComment("เวลาจองห้อง");

                entity.Property(e => e.ShowColor).HasComment("สีที่แสดงของห้อง");

                entity.Property(e => e.StatusId).HasComment("1=ว่าง , 2=ไม่ว่าง");
            });

            modelBuilder.Entity<MroundUp>(entity =>
            {
                entity.HasKey(e => new { e.RoundUpCode, e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.RoundUpCode).HasComment("รหัส RoundUp Link มาจาก DataRoundUpName");
            });

            modelBuilder.Entity<Mshift>(entity =>
            {
                entity.HasKey(e => new { e.ShiftCode, e.CreateByOrgCode });

                entity.Property(e => e.ShiftCode).HasComment("รหัสกะ");

                entity.Property(e => e.AllowEarly).HasComment("จำนวนที่อนุญาตให้ออกก่อน");

                entity.Property(e => e.AllowLate).HasComment("จำนวนที่อนุญาตให้สาย");

                entity.Property(e => e.EndOt1).HasComment("เริ่มคิด OT ช่วงที่ 1 ถึงเวลา");

                entity.Property(e => e.EndOt2).HasComment("เริ่มคิด OT ช่วงที่ 2 ถึงเวลา");

                entity.Property(e => e.EndOut).HasComment("ลงเวลาถึง");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.InOutGap).HasComment("จำนวนนาทีที่ต้องทำงานขั้นต่ำ 1");

                entity.Property(e => e.IsCalOt1).HasComment("คำนวณ OT ช่วงที่ 1 หรือไม่");

                entity.Property(e => e.IsCalOt2).HasComment("คำนวณ OT ช่วงที่ 2 หรือไม่");

                entity.Property(e => e.IsSubtractBreak).HasComment("หักเวลาพักในการทำงานหรือไม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.MaxBreak).HasComment("จำนวนนาทีพักได้สูงสุด 1");

                entity.Property(e => e.MinBreak).HasComment("จำนวนนาทีขั้นต่ำที่ี่ต้องพัก 1");

                entity.Property(e => e.MinIn).HasComment("จำนวนลงเวลาเข้าต่ำสุดที่ถือว่าไม่ขาดงาน");

                entity.Property(e => e.MinInAsCome).HasComment("จำนวนเวลาเข้าทถือว่ามา");

                entity.Property(e => e.MinOut).HasComment("จำนวนลงเวลาออกต่ำสุดที่ถือว่าไม่ขาดงาน");

                entity.Property(e => e.MinOutAsCome).HasComment("จำนวนลงเวลาออกที่ถือว่ามา");

                entity.Property(e => e.ShiftName).HasComment("ชื่อกะ");

                entity.Property(e => e.ShortName).HasComment("ชื่อย่อที่แสดงในตารางการทำงาน");

                entity.Property(e => e.StartIn).HasComment("เริ่มลงเวลา");

                entity.Property(e => e.StartOt1).HasComment("เริ่มคิด OT ช่่วงที่ 1 ตั้งแต่เวลา");

                entity.Property(e => e.StartOt2).HasComment("เริ่มคิด OT ช่่วงที่ 2 ตั้งแต่เวลา");

                entity.Property(e => e.SubtractBreak).HasComment("จำนวนนาทีที่หักช่วงพัก");

                entity.Property(e => e.TimeEarly).HasComment("เวลาที่ถือว่าออกก่อน");

                entity.Property(e => e.TimeIn).HasComment("เวลาเข้างาน");

                entity.Property(e => e.TimeLate).HasComment("เวลาที่ถือว่าสาย");

                entity.Property(e => e.TimeOut).HasComment("เวลาเลิกงาน");
            });

            modelBuilder.Entity<MshiftGroup>(entity =>
            {
                entity.Property(e => e.ShiftGroupId).HasComment("เลขที่รันนิ่งของ ShiftGroup");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.ShiftGroupName).HasComment("ชื่อกลุ่ม");
            });

            modelBuilder.Entity<MsocialContact>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ContactypeId, e.CustomerGid });

                entity.Property(e => e.ContactypeId).HasComment("ประเภทการติดต่อ 1=Mobile, 2=Email, 3=Facebook, 4=Line, 5=Intragram");

                entity.Property(e => e.ContactString).HasComment("Url หรือ ID ในการติดต่อ");

                entity.Property(e => e.TokenLineOa).HasComment("Token สำหรับคนไข้ เพื่อการไป แสดง ต่อเชื่อมในการ chat");
            });

            modelBuilder.Entity<MspecialIn>(entity =>
            {
                entity.HasKey(e => new { e.SpecialInsCode, e.CreateByOrgCode });

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.ShowColor).HasComment("สี่ที่แสดง");

                entity.Property(e => e.SpecialInsName).HasComment("คำอธิบายหมายเหตุแพทย์");
            });

            modelBuilder.Entity<MspeciesBloodGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SpeciesCode, e.BloodGroupCode });

                entity.Property(e => e.SpeciesCode).HasComment("รหัสประเภทสัตว์ป่วย");

                entity.Property(e => e.BloodGroupCode).HasComment("รหัสกลุ่มเลือด");
            });

            modelBuilder.Entity<Mspecy>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesCode, e.CreateByOrgCode })
                    .HasName("PK_DataSpecies");

                entity.Property(e => e.SpeciesCode).HasComment("รหัสพันธุ์");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.SpeciesName).HasComment("ชื่อพันธุ์");
            });

            modelBuilder.Entity<Mstaff>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AccountNo).HasComment("หมายเลขบัญชีธนาคารที่รับเงินเดือน");

                entity.Property(e => e.ApproveDocLevel).HasComment("ระดับการอนุมัติเอกสาร");

                entity.Property(e => e.BankAccNo2).HasComment("หมายเลขบัญชีธนาคารแห่งที่สอง");

                entity.Property(e => e.BankBranchCode).HasComment("รหัสสาขาธนาคารที่รับเงินเดือน");

                entity.Property(e => e.BankBranchCode2).HasComment("รหัสสาขาบัญชีธนาคารแห่งที่สอง");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคารที่รับเงินเดือน");

                entity.Property(e => e.BankCode2).HasComment("รหัสธนาคารแห่งที่สอง");

                entity.Property(e => e.BaseSalary).HasComment("ฐานเงินเดือน");

                entity.Property(e => e.BirthDate).HasComment("วันเกิด");

                entity.Property(e => e.CertificateNo).HasComment("เลขที่ใบประกอบโรคศิลป์");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentAddress1).HasComment("ที่อยู่ปัจจุบัน 1");

                entity.Property(e => e.CurrentAddress2).HasComment("ที่อยู่ปัจจุบัน 2");

                entity.Property(e => e.CurrentAmphurCode).HasComment("รหัสอำเภอปัจจุบัน");

                entity.Property(e => e.CurrentAmphurName).HasComment("ชื่ออำเภอปัจจุบัน");

                entity.Property(e => e.CurrentOrgCode).HasComment("รหัสสาขาปัจจุบัน");

                entity.Property(e => e.CurrentPostCode).HasComment("รหัสไปรษณีย์ปัจจุบัน");

                entity.Property(e => e.CurrentProvinceCode).HasComment("รหัสจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentProvinceName).HasComment("ชื่อจังหวัดปัจจุบัน");

                entity.Property(e => e.CurrentTumbonCode).HasComment("รหัสตำบลปัจจุบัน");

                entity.Property(e => e.CurrentTumbonName).HasComment("ชื่อตำบลปัจจุบัน");

                entity.Property(e => e.DefaultQueCode).HasComment("รหัสห้องที่ใช้งาน");

                entity.Property(e => e.DeligentCode).HasComment("รหัสประเภทเบี้ยขยันที่จะได้รับ");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountByBillRate).HasComment("ส่วนลดท้ายบิล");

                entity.Property(e => e.DiscountByItemRate).HasComment("ส่วนลดรายตัว");

                entity.Property(e => e.DiscountRate).HasComment("อัตราส่วนลดที่ลดได้");

                entity.Property(e => e.DisplayLanguageId).HasComment("รหัสภาษาทีใช้แสดง่");

                entity.Property(e => e.DisplayName).HasComment("ชื่อสำหรับแสดง");

                entity.Property(e => e.DisplayName2).HasComment("ชื่อที่ใช้แสดง ภาษาอังกฤษ");

                entity.Property(e => e.DoctorFee).HasComment("Default ค่าตรวจ ");

                entity.Property(e => e.DoctorTypeId).HasComment("รหัสประเภทแพทย์ 1 PartTime 2 FullTime 3 Part-Full");

                entity.Property(e => e.DueBack).HasComment("วันที่คาดว่าจะกลับ");

                entity.Property(e => e.Email).HasComment("Email Address");

                entity.Property(e => e.EmployeeCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.FatherName).HasComment("ชื่อบิดา");

                entity.Property(e => e.FirstName).HasComment("ชื่อ");

                entity.Property(e => e.FirstName2).HasComment("ชื่อที่2");

                entity.Property(e => e.FriTimeIn).HasComment("ทำงานวันศุกร เวลาเข้า");

                entity.Property(e => e.FriTimeOut).HasComment("ทำงานวันศุกร เวลาออก");

                entity.Property(e => e.HireDate).HasComment("วันทเริ่มี่จ้าง");

                entity.Property(e => e.HospitalCode).HasComment("รหัสโรงพยาบาลประจำ");

                entity.Property(e => e.IdCardAmphurCode).HasComment("รหัสอำเภทตามบัตร ปชข");

                entity.Property(e => e.IdcardAddress1).HasComment("ที่อยู่ตามบัตร ปขข 1");

                entity.Property(e => e.IdcardAddress2).HasComment("ที่อยู่ตามบัตร ปขข 2");

                entity.Property(e => e.IdcardAmphurName).HasComment("ชื่ออำเภทตามบัตร ปชช");

                entity.Property(e => e.IdcardExpireDate).HasComment("วันหมดอายุของบัตร ปชช");

                entity.Property(e => e.IdcardIssueDate).HasComment("วันออกบัตร ปชช");

                entity.Property(e => e.IdcardNo).HasComment("เลขที่บัตร ปชช");

                entity.Property(e => e.IdcardPostCode).HasComment("รหัสไปรษณีย์ตามบัตร ปชช");

                entity.Property(e => e.IdcardProvinceCode).HasComment("รหัสจังหวัดตามบัตร ปชช");

                entity.Property(e => e.IdcardProvinceName).HasComment("ชื่อจังหวัดตามบัตร ปชช");

                entity.Property(e => e.IdcardTumbonCode).HasComment("รหัสตำบลตามบัตร ปชช");

                entity.Property(e => e.IdcardTumbonName).HasComment("ชื่อตำบลตามบัตร ปชช");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.InOutStatusId).HasComment("สถานะการเข้า ออก");

                entity.Property(e => e.IncomeMethod).HasComment("รูปแบบการรับเงิน 0=โอนเงินเข้าบัญชี  1=เงินสด  2=เช็ค");

                entity.Property(e => e.InsuranceCode).HasComment("รหัสสิทธิ์ที่ได้รับประกันภัย/สุขภาพ/ชีวิต");

                entity.Property(e => e.InsureCode).HasComment("รหัสประกันภัย");

                entity.Property(e => e.IsAccessLogin).HasComment("ยืนยันตัวตนด้วยการระบุ User+ Password โดยไม่ต้องสแกนลายนิ้วมือก็ได้(VetSOR)");

                entity.Property(e => e.IsCalcProvident).HasComment("คำนวณกองทุนสำรองเลี้ยงชีพหรือไม่?");

                entity.Property(e => e.IsCalcProvidentByPercent).HasComment("หน่วยที่จะหักเงินกองทุน Baht , Percent");

                entity.Property(e => e.IsCalcSocial).HasComment("คำนวณประกันสังคมหรือไม่?");

                entity.Property(e => e.IsCanUseWebApp).HasComment("สามารถเข้าใช้งานระบบเว็บได้");

                entity.Property(e => e.IsCheckForPaid).HasComment("สามารถเลือกสินค้าเพื่อรับเงิน");

                entity.Property(e => e.IsDeligent).HasComment("ให้คำนวณเบี้ยขยันหรือไม่?");

                entity.Property(e => e.IsDiscountable).HasComment("สามารถลดได้หรือไม่");

                entity.Property(e => e.IsEmployee).HasComment("เพิ่ม 28/09/2015 เพื่อแยกระหว่าง User ที่เป็นพนักงานจริงและUser ที่ใช้เข้าระบบส่วนรวม (สุภาภรณ์)");

                entity.Property(e => e.IsForeigner).HasComment("เป็นชาวต่างชาติหรือไม่");

                entity.Property(e => e.IsFriday).HasComment("ทำงานวันศุกร์?");

                entity.Property(e => e.IsMonday).HasComment("ทำงานวันจันทร์?");

                entity.Property(e => e.IsMustEnroll).HasComment("ต้องลงเวลาเข้าออก");

                entity.Property(e => e.IsNextDayShift).HasComment("เป็นกะข้ามวันหรือไม่");

                entity.Property(e => e.IsNotShowPrice).HasComment("ซ่อนราคา(ส่วนลด, ต่อหน่วย, รวม)");

                entity.Property(e => e.IsOt).HasComment("คำนวณ OT หรือไม่");

                entity.Property(e => e.IsPayer).HasComment("คนจ่ายเงิน");

                entity.Property(e => e.IsReduceDebt).HasComment("สามารถยกหนี้ให้ลูกค้าได้หรือไม่");

                entity.Property(e => e.IsResign).HasComment("ลาออกแล้วหรือไม่");

                entity.Property(e => e.IsSatday).HasComment("ทำงานวันเสาร์?");

                entity.Property(e => e.IsShift).HasComment("ต้องระบุกะหลัง Login");

                entity.Property(e => e.IsShowStockWarning).HasComment("แสดงหน้าต่างแจ้งเตือนสินค้าใกล้หมด/ใกล้หมดอายุหลังล็อกอิน");

                entity.Property(e => e.IsSunday).HasComment("ทำงานวันอาทิตย์?");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.IsThuday).HasComment("ทำงานวันพฤหัสดี?");

                entity.Property(e => e.IsTueday).HasComment("ทำงานวันอังคาร?");

                entity.Property(e => e.IsUseDiscountByBill).HasComment("คิดส่วนลดท้ายบิล");

                entity.Property(e => e.IsUseDiscountByItem).HasComment("คิดส่วนลดรายตัว");

                entity.Property(e => e.IsUsePasswordDiscountByBill).HasComment("ใช้รหัสผ่านในการคิดส่วนลดท้ายบิล");

                entity.Property(e => e.IsUsePasswordDiscountByItem).HasComment("ใช้รหัสผ่านในการคิดส่วนลดรายตัว");

                entity.Property(e => e.IsWedday).HasComment("ทำงานวันพุธ?");

                entity.Property(e => e.IsWorkQue).HasComment("มีคิวหรือไม่");

                entity.Property(e => e.LastName).HasComment("นามสกุล");

                entity.Property(e => e.LastName2).HasComment("นามาสกุลที่2");

                entity.Property(e => e.LevelCode).HasComment("รหัสระดับพนักงาน");

                entity.Property(e => e.MaxInProgressRequest).HasComment("จำนวน In Progress Request สูงสุด");

                entity.Property(e => e.MaxOpenRequest).HasComment("จำนวน Open Request ที่อนุญาตให้สูงสุด");

                entity.Property(e => e.MinOpenRequest).HasComment("จำนวน Open  Request ต่ำสุดที่ต้องสร้าง");

                entity.Property(e => e.Mobile).HasComment("เบอร์มือถือ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.MonTimeIn).HasComment("ทำงานวันจันทร์ เวลาเข้า");

                entity.Property(e => e.MonTimeOut).HasComment("ทำงานวันจันทร์ เวลาออก");

                entity.Property(e => e.MotherName).HasComment("ชื่อมารดา");

                entity.Property(e => e.NationCode).HasComment("รหัสสัญชาติ");

                entity.Property(e => e.NickName).HasComment("ชื่อเล่น");

                entity.Property(e => e.NotHireDate).HasComment("--- ยกเลิกการใช้ ---");

                entity.Property(e => e.NoteMemo).HasComment("บันทึกส่วนตัวของผู้ใช้งานแต่ละคนเอง เช่น สิ่งที่ต้องทำ");

                entity.Property(e => e.OrderItemTypeId).HasComment("0=ตาราง 1=รายการ");

                entity.Property(e => e.PasswordDiscountByBill).HasComment("รหัสผ่านในการคิดส่วนลดท้ายบิล");

                entity.Property(e => e.PasswordDiscountByItem).HasComment("รหัสผ่านในการคิดส่วนลดรายตัว");

                entity.Property(e => e.PasswordOpenShelf).HasComment("รหัสผ่านในการเปิดลิ้นชัก");

                entity.Property(e => e.PongSakIsHouseKeeper).HasComment("เป็นแม่บ้านใช่หรือไม่?");

                entity.Property(e => e.PongSakOtperDay).HasComment("ชั่วโมงโอทีที่ทำต่อวัน แต่ละคนไม่เท่ากันขึ้นอยู่กับว่าอยู่แผนกไหน");

                entity.Property(e => e.PongSakStaffType).HasComment("ประเภทพนักงานของแพทย์พงศ์ศักดฺ์ 0=พนักงานหน้าร้าน 1=รองผู้จัดการ  2=ผู้จัดการ");

                entity.Property(e => e.PositionCode).HasComment("รหัสประเภทพนักงาน");

                entity.Property(e => e.PostypeId).HasComment("1=Standard, 2= Touchscreen");

                entity.Property(e => e.Priority).HasComment("ลำดับการจัดเรียงของแต่ละพนักงาน(ไม่ควรซ้ำกัน)");

                entity.Property(e => e.ProbationMonth).HasComment("ระยะเวลาทดลองงาน (เดือน)");

                entity.Property(e => e.ProvidentCode).HasComment("Provident code");

                entity.Property(e => e.RaceCode).HasComment("รหัสเชื้อชาติ");

                entity.Property(e => e.ReligionCode).HasComment("รหัสศาสนา");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ResignDate).HasComment("วันที่ลาออก");

                entity.Property(e => e.ResignReasonCode).HasComment("รหัสเหตุผลการออกจากงาน");

                entity.Property(e => e.SatTimeIn).HasComment("ทำงานวันเสาร เวลาเข้า");

                entity.Property(e => e.SatTimeOut).HasComment("ทำงานวันเสาร เวลาออก");

                entity.Property(e => e.SectionCode).HasComment("รหัสฝ่ายงาน");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("เพศ ชาย=M  หญิง=F");

                entity.Property(e => e.ShiftCode1).HasComment("รหัสกะ 1");

                entity.Property(e => e.ShiftCode2).HasComment("รหัสกะ 2");

                entity.Property(e => e.ShiftCode3).HasComment("รหัสกะ 3");

                entity.Property(e => e.ShiftTypeId).HasComment("ประเภทกะ");

                entity.Property(e => e.ShowColor).HasComment("สีประจำพนักงาน");

                entity.Property(e => e.Ssn).HasComment("เลขที่บัตรประกันสังคม");

                entity.Property(e => e.StaffDescription).HasComment("รายละเอียดของพนักงาน");

                entity.Property(e => e.StaffImage).HasComment("รูปภาพพนักงาน");

                entity.Property(e => e.StaffPaymentTypeCode).HasComment("ประเภทพนักงาน รายวัน รายชั่วโมง รายเดือน เหมาจ่าย");

                entity.Property(e => e.StaffTypeId).HasComment("1=แพทย์, 2=พนักงาน, 3=พยาบาล,  4=ช่าง,44=พนักงาน(BackOffice), 99=อื่นๆ");

                entity.Property(e => e.Status).HasComment("Status");

                entity.Property(e => e.SunTimeIn).HasComment("ทำงานวันอาทิตย์ เวลาเข้า");

                entity.Property(e => e.SunTimeOut).HasComment("ทำงานวันอาทิตย์ เวลาออก");

                entity.Property(e => e.TaxNo).HasComment("เลขที่ประจำตัวผู้เสียภาษี");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.ThuTimeIn).HasComment("ทำงานวันพฤหัสดี เวลาเข้า");

                entity.Property(e => e.ThuTimeOut).HasComment("ทำงานวันพฤหัสดี เวลาออก");

                entity.Property(e => e.TitleName2).HasComment("คำนำหน้าชื่อ 2");

                entity.Property(e => e.TotalAmountDeductProvidentFund).HasComment("จำนวนที่จะให้หักเงินกองทุนสำรองเลี้ยงชีพ");

                entity.Property(e => e.TueTimeIn).HasComment("ทำงานวันอังคาร เวลาเข้า");

                entity.Property(e => e.TueTimeOut).HasComment("ทำงานวันอังคาร เวลาออก");

                entity.Property(e => e.UserPassword).HasComment("รหัสผ่าน");

                entity.Property(e => e.UserPincode).HasComment("กำหนดรหัสเฉพาะ เพื่อการลบ การให้ส่วนลด และ การแกไขตามสิทธิ");

                entity.Property(e => e.WedTimeIn).HasComment(" ทำงานวันพุธ เวลาเข้า");

                entity.Property(e => e.WedTimeOut).HasComment("ทำงานวันพุธ เวลาออก");

                entity.Property(e => e.WorkStatusCode).HasComment("รหัสสถานะการทำงาน");

                entity.Property(e => e.WorkTypeId).HasComment("1=Full Time, 2 = PartTime");
            });

            modelBuilder.Entity<MstaffAccess>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.AccessTypeId });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.AccessTypeId).HasComment("สิทธิ์ในการแก้ไข");

                entity.Property(e => e.DiscountByBill).HasComment("ส่วนลดท้ายบิล");

                entity.Property(e => e.DiscountByItem).HasComment("ส่วนลดรายตัว");
            });

            modelBuilder.Entity<MstaffCalendar>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.OrganizationCode, e.SeqId });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้ห้องนี้");

                entity.Property(e => e.SeqId).HasComment("ลำดับ");

                entity.Property(e => e.CalendarName)
                    .IsFixedLength(true)
                    .HasComment("ชื่อของปฏิทิน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.FriTimeIn).HasComment("ทำงานวันศุกร เวลาเข้า");

                entity.Property(e => e.FriTimeOut).HasComment("ทำงานวันศุกร เวลาออก");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsFriday).HasComment("ทำงานวันศุกร์?");

                entity.Property(e => e.IsMonday).HasComment("ทำงานวันจันทร์?");

                entity.Property(e => e.IsSatday).HasComment("ทำงานวันเสาร์?");

                entity.Property(e => e.IsShowAppointment).HasComment("ใช้กำหนดการแสดงชื่อในการนัดหมาย");

                entity.Property(e => e.IsSunday).HasComment("ทำงานวันอาทิตย์?");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.IsThuday).HasComment("ทำงานวันพฤหัสดี?");

                entity.Property(e => e.IsTueday).HasComment("ทำงานวันอังคาร?");

                entity.Property(e => e.IsWedday).HasComment("ทำงานวันพุธ?");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.MonTimeIn).HasComment("ทำงานวันจันทร์ เวลาเข้า");

                entity.Property(e => e.MonTimeOut).HasComment("ทำงานวันจันทร์ เวลาออก");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SatTimeIn).HasComment("ทำงานวันเสาร เวลาเข้า");

                entity.Property(e => e.SatTimeOut).HasComment("ทำงานวันเสาร เวลาออก");

                entity.Property(e => e.SunTimeIn).HasComment("ทำงานวันอาทิตย์ เวลาเข้า");

                entity.Property(e => e.SunTimeOut).HasComment("ทำงานวันอาทิตย์ เวลาออก");

                entity.Property(e => e.ThuTimeIn).HasComment("ทำงานวันพฤหัสดี เวลาเข้า");

                entity.Property(e => e.ThuTimeOut).HasComment("ทำงานวันพฤหัสดี เวลาออก");

                entity.Property(e => e.TueTimeIn).HasComment("ทำงานวันอังคาร เวลาเข้า");

                entity.Property(e => e.TueTimeOut).HasComment("ทำงานวันอังคาร เวลาออก");

                entity.Property(e => e.WedTimeIn).HasComment(" ทำงานวันพุธ เวลาเข้า");

                entity.Property(e => e.WedTimeOut).HasComment("ทำงานวันพุธ เวลาออก");
            });

            modelBuilder.Entity<MstaffCalendarHoliday>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.OrganizationCode, e.SeqId });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้");

                entity.Property(e => e.SeqId).HasComment("ลำดับของพนักงาน");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.HolidayNote).HasComment("หมายเหตุวันหยุด");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.NoWorkDate).HasComment("วันที่หยุด");

                entity.Property(e => e.NoWorkFromTime).HasComment("เวลาที่หยุดจาก");

                entity.Property(e => e.NoWorkToTime).HasComment("เวลาที่หยุดถึง");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.RecurrenceType).HasComment("ประเภทการเกิดขึ้นอีก 1=ครั้งเดียว 2=ทุกวัน , 3=ทุกสัปดาห์ของเดือน 4=ทุกปี");

                entity.Property(e => e.WeekDate).HasComment("เช่น 1 วันจันทร์  ,2 อังคาร ,11 วันจันทร์สัปดาห์แรก");
            });

            modelBuilder.Entity<MstaffGroup>(entity =>
            {
                entity.HasKey(e => new { e.StaffGroupCode, e.CreateByOrgCode })
                    .HasName("PK_DataStaffGroup");

                entity.Property(e => e.StaffGroupCode).HasComment("รหัสกลุ่มสิทธิ์ใช้ระบบ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsCopyDoc).HasComment("คัดลอกเอกสารตัวเอง");

                entity.Property(e => e.IsDeleteDoc).HasComment("ลบเอกสารตัวเอง");

                entity.Property(e => e.IsDeleteOtherDoc).HasComment("ลบเอกสารคนอื่น");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.IsViewOtherDoc).HasComment("ดูเอกสารคนอื่น");

                entity.Property(e => e.StaffGroupName).HasComment("ชื่อกลุ่ม");
            });

            modelBuilder.Entity<MstaffImage>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.StaffImageName).HasComment("ชื่อรูปภาพ");

                entity.Property(e => e.StaffImagePath).HasComment("Path ในการเก็บรูป");
            });

            modelBuilder.Entity<MstaffMap>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");
            });

            modelBuilder.Entity<MstaffOrganization>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.OrganizationCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้ห้องนี้");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentOrgCode).HasComment("รหัสสาขาปัจจุบัน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");
            });

            modelBuilder.Entity<MstaffRight>(entity =>
            {
                entity.HasKey(e => new { e.StaffRightCode, e.CreateByOrgCode, e.SourceProgram });

                entity.Property(e => e.StaffRightCode).HasComment("รหัสสิทธิ์การใช้ระบบ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.SourceProgram).HasComment("ประเภทโปรแกรม");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.RightFlag).HasComment("ตัวเลือกในความสามารถกำหนดสิทธิ");

                entity.Property(e => e.StaffRightName).HasComment("ชื่อสิทธิ์การใช้ระบบ");
            });

            modelBuilder.Entity<MstaffTaxDeduct>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).IsFixedLength(true);
            });

            modelBuilder.Entity<MsubItemGroup>(entity =>
            {
                entity.HasKey(e => new { e.SubItemCode, e.CreateByOrgCode })
                    .HasName("PK_DataSubItemGroup");

                entity.Property(e => e.SubItemCode).HasComment("รหัสกลุ่มย่อยสินค้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsSystem).HasComment("ข้อมูลระบบ");

                entity.Property(e => e.SubItemName).HasComment("ชื่อกลุ่มย่อย");
            });

            modelBuilder.Entity<MsubItemGroupIpd>(entity =>
            {
                entity.HasKey(e => new { e.SubItemGroupCodeIpd, e.CreateByOrgCode, e.ItemGroupCodeIpd });
            });

            modelBuilder.Entity<MsyndromeGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SyndromeGroupCode })
                    .HasName("PK_MICD9CMType");

                entity.Property(e => e.SyndromeGroupCode).HasComment("รหัสกลุ่มหัตถการ/ การรักษา");

                entity.Property(e => e.SyndromeGroupName).HasComment("ชื่อกลุ่มหัตถการ/ การรักษา");

                entity.Property(e => e.SyndromeGroupName2).HasComment("ชื่อกลุ่มหัตถการ/ การรักษา2");
            });

            modelBuilder.Entity<MtaxTable>(entity =>
            {
                entity.HasKey(e => new { e.TaxTableNo, e.CreateByOrgCode });
            });

            modelBuilder.Entity<MtemplateSiteItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TemplateCode, e.InjectionSiteNo });

                entity.Property(e => e.InjectionSiteNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MtimeAttendanceOption>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OrganizationCode })
                    .HasName("PK_MOptionsOnTime");

                entity.Property(e => e.IsShowEnrollOptions).HasComment("แสดงตัวเลือกในการลงเวลา");
            });

            modelBuilder.Entity<MtitleName>(entity =>
            {
                entity.HasKey(e => new { e.TitleCode, e.CreateByOrgCode });

                entity.Property(e => e.TitleCode).HasComment("รหัสคำนำหน้า");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.FromAge).HasComment("อายุเริ่มต้น");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsCheck).HasComment("ตรวจสอบอายุหรือไม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.Sex)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("เพศ");

                entity.Property(e => e.TitleName).HasComment("คำนำหน้าภาษาที่1");

                entity.Property(e => e.TitleName2).HasComment("คำนำหน้าภาษาที่2");

                entity.Property(e => e.ToAge).HasComment("อายุสิ้นสุด");
            });

            modelBuilder.Entity<Mtraining>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TrainingCode });

                entity.Property(e => e.TrainingCode).HasComment("รหัสหัวข้ออบรม");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");

                entity.Property(e => e.Institute).HasComment("สถาบัน");

                entity.Property(e => e.Location).HasComment("สถานที่ดูงาน");

                entity.Property(e => e.Method).HasComment("วิธีการดูงาน");

                entity.Property(e => e.Purpose).HasComment("วัตถุประสงค์");

                entity.Property(e => e.Reason).HasComment("หลักการและเหตุผล");

                entity.Property(e => e.ResponsibleBy).HasComment("ผู้รับผิดชอบโครงการ");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มต้น");

                entity.Property(e => e.TrainingByName).HasComment("วิทยากร");

                entity.Property(e => e.TrainingName).HasComment("หัวข้อการอบรม");
            });

            modelBuilder.Entity<Mtumbon>(entity =>
            {
                entity.HasKey(e => new { e.TumbonCode, e.CreateByOrgCode });

                entity.Property(e => e.TumbonCode).HasComment("รหัสตำบล");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.InActive).HasComment("ยกเลิกการใช้งาน");

                entity.Property(e => e.IsDefault).HasComment("Default ในแสดงทำบัตรใหม่");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.Latitude).HasComment("ค่าพิกัด Latitude");

                entity.Property(e => e.Longitude).HasComment("ค่าพิกัด Longitude");

                entity.Property(e => e.PostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.TumbonName).HasComment("ชื่อตำบล");

                entity.Property(e => e.TumbonName2).HasComment("ชื่อตำบล ภาษาอังกฤษ");
            });

            modelBuilder.Entity<Mvendor>(entity =>
            {
                entity.HasKey(e => new { e.VendorCode, e.CreateByOrgCode, e.VendorTypeId });

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.VendorTypeId).HasComment("รูปแบบองค์กรของผู้จำหน่าย 1สาขาใหญ่/ 2สาขาย่อย/3Agency");

                entity.Property(e => e.AccountCode).HasComment("รหัสผังบัญชี");

                entity.Property(e => e.ApAccountCode).HasComment("เลขที่บัญขีเจ้่าหนี้");

                entity.Property(e => e.ContactMobile).HasComment("เบอร์มือถือผู้ติดต่อ");

                entity.Property(e => e.ContactName).HasComment("ชื่อผู้ติดต่อ");

                entity.Property(e => e.ContactPhone).HasComment("เบอร์โทรศัพท์ผู้ติดต่อ");

                entity.Property(e => e.ContactWeekDay).HasComment("วันที่ติดต่อเป็นประจำ");

                entity.Property(e => e.Credit).HasComment("วงเงินเครดิต");

                entity.Property(e => e.CreditAmount).HasComment("วงเงินอนุมัติ");

                entity.Property(e => e.CreditLine).HasComment("วงเงินอนุมัติ");

                entity.Property(e => e.CustomText1).HasComment("Field พิเศษ 1");

                entity.Property(e => e.CustomText2).HasComment("Field พิเศษ 2");

                entity.Property(e => e.CustomText3).HasComment("Field พิเศษ 3");

                entity.Property(e => e.CustomText4).HasComment("Field พิเศษ 4");

                entity.Property(e => e.CustomText5).HasComment("Field พิเศษ 5");

                entity.Property(e => e.DiscountText).HasComment("ส่วนลดทางการค้า");

                entity.Property(e => e.Email).HasComment("อีเมล์");

                entity.Property(e => e.FaxNo).HasComment("เบอร์ Fax");

                entity.Property(e => e.ImagePath).HasComment("ที่เก็บรูปภาพ");

                entity.Property(e => e.InActive).HasComment("ยกเิลิกการใช้งาน");

                entity.Property(e => e.IncentiveFix).HasComment("อัตราค่าตอบแทนของตัวแทน");

                entity.Property(e => e.IsSystem).HasComment("เป็นข้อมูลระบบ");

                entity.Property(e => e.LastContactDate).HasComment("วันที่ติดต่อล่าสุด");

                entity.Property(e => e.LeadTime).HasComment("ระยะเวลารอรับสินค้า หลังจากสั่งซื้อ");

                entity.Property(e => e.MemberId).HasComment("รหัสสมาชิก");

                entity.Property(e => e.MobileNo).HasComment("เบอร์โทรศัพท์มือถือ");

                entity.Property(e => e.PayRemark).HasComment("บันทึกข้อมูลเงื่อนการจ่ายชำระ เช่น ช่วงวันที่จ่ายเช็ค");

                entity.Property(e => e.PaymentMethodId).HasComment("วิธีการรับชำระ");

                entity.Property(e => e.PaymentTerm).HasComment("ระยะเวลาหนี้");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SaleCode).HasComment("ชื่อพนักงานขาย");

                entity.Property(e => e.SalesBranch).HasComment("สาขา ???");

                entity.Property(e => e.SalesLevel).HasComment("ระดับราคาซื้อ");

                entity.Property(e => e.ShipAddress1).HasComment("ที่อยู่ี่จัดส่ง 1");

                entity.Property(e => e.ShipAddress2).HasComment("ที่อยู่ี่จัดส่ง 2");

                entity.Property(e => e.ShipAmphurCode).HasComment("รหัสอำเภอที่จัดส่ง");

                entity.Property(e => e.ShipAmphurName).HasComment("ชื่ออำเภอที่จัดส่ง");

                entity.Property(e => e.ShipMobile).HasComment("เบอร์มือถือที่จัดส่ง");

                entity.Property(e => e.ShipPostCode).HasComment("รหัสไปรษณีย์ที่จัดส่ง");

                entity.Property(e => e.ShipProvinceCode).HasComment("รหัสจังหวัดที่จัดส่ง");

                entity.Property(e => e.ShipProvinceName).HasComment("ชื่อจังหวัดที่จัดส่ง");

                entity.Property(e => e.ShipTelephone).HasComment("เบอร์โทรศัพท์ที่จัดส่ง");

                entity.Property(e => e.ShipTumbonCode).HasComment("รหัสตำบลที่จัดส่ง");

                entity.Property(e => e.ShipTumbonName).HasComment("ชื่อตำบลที่จัดส่ง");

                entity.Property(e => e.TaxNo).HasComment("เลขประจำตัวผู้เสียภาษี");

                entity.Property(e => e.TaxOrgCode).HasComment("รหัสสาขา (เพื่อการออกภาษี)");

                entity.Property(e => e.TaxOrgName).HasComment("ชื่อสาขา (เพื่อการออกภาษี)");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxTypeId).HasComment("ประเภทภาษีหัก ณ ที่จ่าย 1=ภงด.3  2=ภงด.93 ");

                entity.Property(e => e.TelNo).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.TermsOfPayment).HasComment("เงื่อนไขการชำระเงิน");

                entity.Property(e => e.TransportByName).HasComment("ประเภทการขนส่ง");

                entity.Property(e => e.TransportCode).HasComment("วิธีการขนส่ง");

                entity.Property(e => e.TransportTypeCode).HasComment("วิธีการขนส่ง");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VendorName).HasComment("ชื่อผู้จำหน่าย");

                entity.Property(e => e.VendorTypeCode).HasComment("รหัสประเภทผู้จำหน่าย");

                entity.Property(e => e.Website).HasComment("เว็บไซต์");
            });

            modelBuilder.Entity<MvendorGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.VendorGroupCode });
            });

            modelBuilder.Entity<Mvoucher>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.VoucherLotId })
                    .HasName("PK_VoucherLot");
            });

            modelBuilder.Entity<MvoucherType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.VoucherTypeCode })
                    .HasName("PK_MVourcherType");
            });

            modelBuilder.Entity<MvoucherTypeItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.VoucherTypeCode, e.SeqId })
                    .HasName("PK_MVoucherTypeItem_1");
            });

            modelBuilder.Entity<Mwarehouse>(entity =>
            {
                entity.HasKey(e => new { e.Whcode, e.CreateByOrgCode });

                entity.Property(e => e.Whcode).HasComment("รหัสคลังสินค้า");

                entity.Property(e => e.CurrentAddress1).HasComment("ที่อยู่ 1");

                entity.Property(e => e.CurrentAddress2).HasComment("ที่อยู่ 2");

                entity.Property(e => e.CurrentAmphurCode).HasComment("รหัสอำเภอ");

                entity.Property(e => e.CurrentAmphurName).HasComment("ชื่ออำเภอ");

                entity.Property(e => e.CurrentPostCode).HasComment("รหัสไปรษณีย์");

                entity.Property(e => e.CurrentProvinceCode).HasComment("รหัสจังหวัด");

                entity.Property(e => e.CurrentProvinceName).HasComment("ชื่อจังหวัด");

                entity.Property(e => e.CurrentTumbonCode).HasComment("รหัสตำบล");

                entity.Property(e => e.CurrentTumbonName).HasComment("ชื่อตำบล");

                entity.Property(e => e.Fax).HasComment("เบอร์แฟกซ์");

                entity.Property(e => e.InActive).HasComment("ยกเลิกใช้งาน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้คลังนี้");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Telephone).HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.Whname).HasComment("ชื่อคลังสินค้า");
            });

            modelBuilder.Entity<MwithholdingTaxType>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WithholdingTaxTypeCode })
                    .HasName("PK_MWithholdingType");
            });

            modelBuilder.Entity<MworkInHoliday>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WorkHoliCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.WorkHoliCode).HasComment("รหัสทำงานวันหยุด วันนักขัตฤกษ์");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.Holiday).HasComment("วันที่ทำงาน (วันหยุด / วันนักขัตฤกษ์)");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<MworkTable>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WorkCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.WorkCode).HasComment("รหัสวันทำงาน");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.IsNoneWorkDay).HasComment("ใช่วันหยุดหรือไม่? 0 = วันทำงาน 1 = วันหยุด");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.WorkDay).HasComment("วันทำงานที่กำหนด");

                entity.Property(e => e.WorkPeriod).HasComment("งวด");

                entity.Property(e => e.WorkStaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.WorkYear).HasComment("ปี");
            });

            modelBuilder.Entity<Mworkstation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WorkstationCode });
            });

            modelBuilder.Entity<MxrayItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.XrayItemCode });
            });

            modelBuilder.Entity<OngoingOrder>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.AutoDate).HasComment("วันที่ปรับให้เริ่มสั่งอัติโนมัติ");

                entity.Property(e => e.AutoFromTime).HasComment("สั่งอัตโนมัติเริ่มเช็คตั้งแต่เวลานี้");

                entity.Property(e => e.AutoToTime).HasComment("สั่งอัตโนมัติเช็คถึงแค่เวลานี้");

                entity.Property(e => e.DaysAuto).HasComment("จำนวนวันที่จะให้สั่งอัตโนมัติ");

                entity.Property(e => e.IsAuto).HasComment("เป็นสินค้าที่ให้สั่ง Auto อัติโนมัติหรือไม่");

                entity.Property(e => e.IsOff).HasComment("ยกเลิกการสั่งต่อเนื่องแล้วหรือไม่");

                entity.Property(e => e.OrderByCode).HasComment("รหัสพนักงานที่เริ่มต้นสั่งต่อเนื่อง");

                entity.Property(e => e.OrderDate).HasComment("วันที่เริ่มต้นสั่งต่อเนื่อง");
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OpinionId, e.Vn });

                entity.Property(e => e.OpinionId).HasComment("control no.");

                entity.Property(e => e.Cc).HasComment("อาการเบื้องต้น");

                entity.Property(e => e.Dx).HasComment("การรักษา");

                entity.Property(e => e.Email).HasComment("Email");

                entity.Property(e => e.OpinionAdmitTypeId).HasComment("ความเห็นพักรักษา 0=ไม่ต้อง 1=แนะนำ 2=ควรพัก 3=จำเป็นต้องพัก");

                entity.Property(e => e.OpinionDetail).HasComment("รายละเอียดความคิดเห็น");

                entity.Property(e => e.OpinionOwnerTypeId).HasComment("ความเห็นการยินยอมเจ้าของ 0=ไม่ยินยอม 1=ยินยอม");

                entity.Property(e => e.PostByName).HasComment("ชื่อผู้แสดงความคิดเห็น");

                entity.Property(e => e.ReasonOwner).HasComment("เหตุผลเจ้าของ");

                entity.Property(e => e.RequestTypeId).HasComment("ประเภทข้อเสนอ 1=problem 2=opportunity");

                entity.Property(e => e.Score).HasComment("Score");
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OpportunityId });
            });

            modelBuilder.Entity<OpportunityItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OpportunityId, e.SeqId });
            });

            modelBuilder.Entity<OrganizationDatum>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.TableName });

                entity.Property(e => e.OrganizationCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.TableName).HasComment("ชื่อตาราง");

                entity.Property(e => e.IsSelectFromParentOrg).HasComment("ดึงข้อมูลจากสาขา Field ParentOrgCode หรือไม่");
            });

            modelBuilder.Entity<Pack>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PackNo });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.PackNo).HasComment("เลขที่เบิกบรรจุ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1=Pending 2= Approve 3= Cancel");

                entity.Property(e => e.FromWhcode).HasComment("รหัสคลังจ่าย");

                entity.Property(e => e.PackDate).HasComment("วันที่เบิกบรรจุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสผู้เบิก บรรจุ");

                entity.Property(e => e.ToWhcode).HasComment("รหัสคลังรับ");
            });

            modelBuilder.Entity<PackFromItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PackNo, e.SeqIdto, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.PackNo).HasComment("เลขที่เบิกบรรจุ");

                entity.Property(e => e.SeqIdto).HasComment("ลำดับในการบรรจุ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าที่เบิก");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้าที่เบิก");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่เบิก");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วยที่เบิก");
            });

            modelBuilder.Entity<PackToItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PackNo, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.PackNo).HasComment("เลขที่เบิกบรรจุ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการที่บรรจุ");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้าที่บรรจุ");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้าที่บรรจุ");

                entity.Property(e => e.LotNo).HasComment("Lot ที่บรรจุ");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่บรรจุ");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุน/หน่วย ที่บรรจุ");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วยที่บรรจุ");
            });

            modelBuilder.Entity<PatientAlert>(entity =>
            {
                entity.HasKey(e => new { e.PatientAlertId, e.CreateByOrgCode })
                    .HasName("PK_PatientAlert_1");

                entity.Property(e => e.PatientAlertId)
                    .ValueGeneratedOnAdd()
                    .HasComment("รหัสแจ้งเตือน");

                entity.Property(e => e.AlertDate).HasComment("วันที่แจ้งเตือน");

                entity.Property(e => e.AlertNote).HasComment("ข้อความแจงเตือน");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้แจ้งเตือนนี้");
            });

            modelBuilder.Entity<PayByOther>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.RightCode });

                entity.Property(e => e.NetAmount).HasComment("ยอดที่สามารถนำไปเบิกได้ ");
            });

            modelBuilder.Entity<PayByOthersItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.Vn, e.RightCode });
            });

            modelBuilder.Entity<Pc>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Pccode, e.StaffCode });

                entity.Property(e => e.PcbeginValue).HasComment("ยอดยกมา");

                entity.Property(e => e.PccurrentValue).HasComment("เงินคงเหลือ");

                entity.Property(e => e.Pcvalue).HasComment("วงเงิน");
            });

            modelBuilder.Entity<Pcreimburse>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PcreimburseNo });

                entity.Property(e => e.ReferenceIndex).HasComment("เลขที่รันนิ่งของเล่มเอกสาร  จะได้รู้ว่าเป็นเอกสารของเล่มไหน");
            });

            modelBuilder.Entity<PcreimburseBy>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PcreimburseNo, e.SeqId });
            });

            modelBuilder.Entity<PcreimburseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PcreimburseNo, e.SeqId });
            });

            modelBuilder.Entity<PeriodEnd>(entity =>
            {
                entity.HasKey(e => new { e.PeriodEndId, e.CreateByOrgCode, e.PeriodYear });
            });

            modelBuilder.Entity<PetQue>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.AnimalGid });

                entity.Property(e => e.Vn).HasComment("Visit No.");

                entity.Property(e => e.CallQueDate).HasComment("วัน/เวลาที่เรียกคิว (ระบบหน้าจอ)");

                entity.Property(e => e.CallQueStatusId).HasComment("0-ไม่ได้เรียก, 1-ยังไม่ได้ประกาศ, 2-เรียกประกาศแล้ว");

                entity.Property(e => e.CaseTypeId).HasComment("สถานะ เช่น 1ทั่วไป, 2 ฉุกเฉิน เป็นต้น");

                entity.Property(e => e.CustomerCode).HasComment("HN คนไข้");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.DisplayName).HasComment("ชื่อคนไข้ที่แสดง");

                entity.Property(e => e.EnterQueTime).HasComment("เวลาที่เข้าคิว");

                entity.Property(e => e.ExitQueTime).HasComment("เวลาที่ออกจากคิว");

                entity.Property(e => e.FromQueCode).HasComment("รหัสห้องที่ส่ง");

                entity.Property(e => e.FromQueName).HasComment("ชื่อห้องที่ส่ง");

                entity.Property(e => e.IsFingerPrintScan).HasComment("สแกนลายนิ้วมือแล้ว");

                entity.Property(e => e.IsFinish).HasComment("ยืนยันจากคิวหรือยัง");

                entity.Property(e => e.IsReVn).HasComment("เป็นการเรียก VN กลับมาแก้ไขหรือไม่");

                entity.Property(e => e.IsReceiveMoney).HasComment("รับเงินแล้ว");

                entity.Property(e => e.IsSaveAnimalSickStatistics).HasComment("บันทึกสถิติสัตว์ป่วย (สสป.)");

                entity.Property(e => e.IsSendFollow).HasComment("ส่ง SMS Follow Up หรือยัง");

                entity.Property(e => e.IsSendSms).HasComment("ส่ง SMS ขอบคุณหรือยัง");

                entity.Property(e => e.LockByCode).HasComment("กำลังใช้ข้อมูลโดยใคร");

                entity.Property(e => e.QueCode).HasComment("รหัสห้องปัจจุบัน");

                entity.Property(e => e.QueId).HasComment("ลำดับคิวประจำวัน");

                entity.Property(e => e.QueName).HasComment("ชื่อห้องปัจจุบัน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReserveNo).HasComment("เลขที่ใบจอง");

                entity.Property(e => e.ShowColor).HasComment("สี่ที่ใช้แสดงในคิว");

                entity.Property(e => e.VisitDate).HasComment("วันที่มา");

                entity.Property(e => e.WaitingTime).HasComment("จำนวนเวลาที่รอคอย");
            });

            modelBuilder.Entity<PettyCash>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานผู้ดูแลวงเงิน");

                entity.Property(e => e.PcaccountCode).HasComment("เลขที่บช.เงินสดย่อย");

                entity.Property(e => e.PcbankAccountCode).HasComment("เลขที่บช.ธนาคาร");

                entity.Property(e => e.PclastValue).HasComment("วงเงินคงเหลือ");

                entity.Property(e => e.Pcvalue).HasComment("วงเงินที่ดูแล");
            });

            modelBuilder.Entity<PettyCashItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.SeqId });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานผู้ดูแลวงเงิน");

                entity.Property(e => e.Amount).HasComment("จำนวนเงิน");

                entity.Property(e => e.CreateByCode).HasComment("ผุ้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.ExpenseAccountCode).HasComment("เลขที่บช.ค่าใช้จ่าย");

                entity.Property(e => e.IsConfirm).HasComment("1=ยืนยันเบิกชดเชยวงเงิน");

                entity.Property(e => e.ModByCode).HasComment("ผู้แก้ไขรายการ");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไขรายการ");

                entity.Property(e => e.ReceiverName).HasComment("ผู้รับเงิน");
            });

            modelBuilder.Entity<PharmaRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.SeqId).HasComment("ลำดับใบจัดยาตาม vn");

                entity.Property(e => e.ApplyTypeId).HasComment("รูปแบบการใช้ยา เช่น ภายในสถานที่(OPD), ภายนอกสถานที่(OPD) เป็นต้น");

                entity.Property(e => e.PharmaStatusId).HasComment("สถานะของการจัดยา");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.RequestDate).HasComment("วัน เวลาที่สั่งจัดยา");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่จะใช้ยา");

                entity.Property(e => e.StaffDisplayName).HasComment("ชื่อพนักงานที่จะใช้ยา");

                entity.Property(e => e.Whcode).HasComment("คลัง");
            });

            modelBuilder.Entity<PlanOrder>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.ApproveByCode).HasComment("อนุมัติส่วนลดโดย");

                entity.Property(e => e.ConsultByCode).HasComment("รหัสผู้แนะนำ");

                entity.Property(e => e.DfbyCode).HasComment("รหัสแทพย์ที่ได้ DF");

                entity.Property(e => e.DoByCode).HasComment("คนทำ");

                entity.Property(e => e.Dose1).HasComment("วิธีใช้1 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose1Code).HasComment("รหัสวิธีใช้1");

                entity.Property(e => e.Dose2).HasComment("วิธีใช้2 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose2Code).HasComment("รหัสวิธีใช้2");

                entity.Property(e => e.Dose3).HasComment("วิธีใช้3 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose3Code).HasComment("รหัสวิธีใช้3");

                entity.Property(e => e.Dose4).HasComment("วิธีใช้4 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose4Code).HasComment("รหัสวิธีใช้4");

                entity.Property(e => e.Dose5).HasComment("วิธีใช้5 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose5Code).HasComment("รหัสวิธีใช้5");

                entity.Property(e => e.Dose6).HasComment("วิธีใช้6 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.DoseNote).HasComment("วิธีการให้ยา");

                entity.Property(e => e.DoseText).HasComment("วิธีใช้");

                entity.Property(e => e.IsCalVat).HasComment("คำนวณภาษี");

                entity.Property(e => e.MemberCardNumber).HasComment("เลขที่บัตรสมาชิกที่เกิดขึ้น ณ ตอนที่ซื้อ member ใหม่");

                entity.Property(e => e.MemberCardRenewSeqId).HasComment("สำหรับเก็บ seqID ของ customerMemberCard ที่ต้องการต่ออายุ");

                entity.Property(e => e.MemberCardSeqId).HasComment("เก็บรหัสอ้างอิงจาก CustomerMemberCard.SeqID");

                entity.Property(e => e.OrderByCode).HasComment("รหัสพนักงานที่เริ่มต้นสั่งต่อเนื่อง");

                entity.Property(e => e.PlanTypeId).HasComment("1=แพลนแบบสั่งรายการ 2=แพลนแบบพิมพ์บันทึกเอง");

                entity.Property(e => e.PromotionCode).HasComment("รหัสโปรโมชั่น");

                entity.Property(e => e.PromotionId).HasComment("รหัสบ่งบอกความเป็นโปรโมชั่นเดียวกัน(ไม่ใช่PomotionCode)");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์ที่ใช้กับ สินค้า");

                entity.Property(e => e.SalesByCode).HasComment("รหัสผู้ขายรายการนี้");

                entity.Property(e => e.SpecialNote).HasComment("คำสั่งพิเศษ");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุน/หน่วย เฉลี่ย ตามหน่วยเก็บ");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");
            });

            modelBuilder.Entity<Po>(entity =>
            {
                entity.HasKey(e => new { e.Pono, e.CreateByOrgCode });

                entity.Property(e => e.Pono).HasComment("เลขที่ใบสั่งซื้อ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AddressCode).HasComment("รหัสประเภทที่อยู่ของผู้จำหน่าย");

                entity.Property(e => e.CancelByCode).HasComment("รหัสผู้ยกเลิก");

                entity.Property(e => e.CancelDate).HasComment("วันที่ยกเลิก");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สั่งซื้อ");

                entity.Property(e => e.CreateDate).HasComment("วันที่สั่งซื้อ");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก (Centre II ใช้เป็นสาขา) ");

                entity.Property(e => e.DiscountAmount).HasComment("จำนวนส่วนลด");

                entity.Property(e => e.DiscountAmountForVat).HasComment("ส่วนลดท้ายบิลเฉพาะรายการที่มี vat");

                entity.Property(e => e.DiscountText).HasComment("ส่วนลดเป็นตัวอักษร");

                entity.Property(e => e.DiscountTextForVat).HasComment("อัตราส่วนลดท้ายบิลเฉพาะรายการที่มี vat");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.DueDate).HasComment("วันที่ส่งของ");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II ใช้เป็น แผนก)");

                entity.Property(e => e.IsCancel).HasComment("1=ยกเลิกสถานะใบสั่งซื้อ");

                entity.Property(e => e.IsComplete).HasComment("รับสินค้าครบหรือยัง");

                entity.Property(e => e.IsLock).HasComment("ไม่อนุญาตให้นำ po นี้ไปใช้ เช่น กำลังมีการใช้ PO ใบนี้อยู่");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.PaymentTerm).HasComment("ระยะเวลาหนี้");

                entity.Property(e => e.PoByCode).HasComment("รหัสพนักงานสั่งซื้อ");

                entity.Property(e => e.Podate).HasComment("วันที่สั่งซ์้อ");

                entity.Property(e => e.PotypeId).HasComment("1=สั่งซื้อสินค้า 2=สั่งซื้อสินค้าอื่นๆ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุการสั่งซื้อ");

                entity.Property(e => e.Roremark).HasComment("หมายเหตุจากใบรับสินค้า");

                entity.Property(e => e.SalesBranch).HasComment("--- ยกเลิกการใช้ ---");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่สั่งซื้อ");

                entity.Property(e => e.TermofPayment).HasComment("เงื่อนไขการชำระ");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินรวม");

                entity.Property(e => e.TotalAmountFotVat).HasComment("จำนวนเงินรวมเฉพาะรายการที่มี Vat ก่อนให้ส่วนลดท้ายบิล");

                entity.Property(e => e.TransportByCode).HasComment("รหัสวิธีขนส่ง");

                entity.Property(e => e.UnitName).HasComment("--- ยกเลิกการใช้ ---");

                entity.Property(e => e.VatAmount).HasComment("จำนวนเงิน VAT");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม (VAT)");

                entity.Property(e => e.VatTypeId).HasComment("ไม่คิด แยกนอก รวมใน");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.Whcode).HasComment("รหัสคลังสั่งซื้อ");
            });

            modelBuilder.Entity<PointDetail>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.CustomerGid });

                entity.Property(e => e.CardNumber).HasComment("เลขบัตรสมาชิก");

                entity.Property(e => e.CustomerMemberSeqId).HasComment("เก็บ SeqID ของ MemberCard ที่ได้รับแต้ม");

                entity.Property(e => e.DocNo).IsFixedLength(true);

                entity.Property(e => e.IsCancel).HasComment("มีการยกเลิกการแลกแต้มครั้งนี้");

                entity.Property(e => e.IsFinish).HasComment("เพื่อระบุว่าแต้มนี้ได้รับหรือถูกใช้แล้ว");

                entity.Property(e => e.PointExpireDate).HasComment("วันที่หมดอายุของ Point");

                entity.Property(e => e.PointTypeId).HasComment("รูปแบบการได้รับหรือหักแต้ม 1. เกิดจากการซื้อขาย/รับคืน 2. เกิดจากการแลกแต้ม 3. เกิดจากการยกเลิกบิล");

                entity.Property(e => e.Remark).HasComment("คำอธิบาย");

                entity.Property(e => e.SalesNoFromReturn).HasComment(" เก็บ SalesNo จาก SalesItem ว่ารับคืนมาจาก SalesNo ไหน");

                entity.Property(e => e.SeqIdfromCancelPoint).HasComment("เก็บ SeqIDของการแลกแต้มที่ทำการยกเลิก");

                entity.Property(e => e.TotalPoint).HasComment("จำนวนแต้มคงเหลือในรายการนั้น");

                entity.Property(e => e.UseDiscountAmount).HasComment("ส่วนลดที่ใช้จริงในการใช้เป็นส่วนลดสินค้าและบริการ");

                entity.Property(e => e.UsePointDate).HasComment("วันที่นำคะแนนสะสมรายการนี้ไปใช้เป็นส่วนลด");
            });

            modelBuilder.Entity<Poitem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Pono, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Pono).HasComment("เลขที่ใบสั่งซื้อ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ActualQty).HasComment("จำนวนคงเหลือที่ผู้ใช้เป็นคนกรอก ณ วันที่สั่งซื้อ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentQty).HasComment("ดึงมาจาก WHItem ณ วันที่สั่งซื้อ");

                entity.Property(e => e.DepartmentCode).HasComment("แผนกที่สั่งซื้อสินค้านี้ (centre II เก็บสาขา)");

                entity.Property(e => e.Description).HasComment("คำอธิบายรายการสินค้า เช่นกรณของสินเปลือง ผัก ตะกร้า");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("อัตราส่วนลด");

                entity.Property(e => e.FactionCode).HasComment("ฝ่ายที่สั่งซื้อสินค้านี้ (centre II เก็บแผนก)");

                entity.Property(e => e.IsCalVat).HasComment("คำนวณภาษีหรือไม่");

                entity.Property(e => e.IsFree).HasComment("1=เป็นของแถม");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.PrnoText).HasComment("เลขที่ใบสั่งซื้อทั้งหมด ที่นำมาสั่งซื้อรายการนั้");

                entity.Property(e => e.PrseqId).HasComment("เก็บ SeqID จาก PRItem กรณีที่เป็นการสั่งซื้อจากใบเสนอซื้อ");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่สั่ง");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.Roquantity).HasComment("จำนวนที่รับแล้ว");

                entity.Property(e => e.StockMax).HasComment("ดึงมาจาก WHItem ณ วันที่สั่งซื้อ");

                entity.Property(e => e.StockMin).HasComment("ดึงมาจาก WHItem ณ วันที่สั่งซื้อ");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินรวม");

                entity.Property(e => e.UnitCode).HasComment("หน่วย");

                entity.Property(e => e.UnitCost).HasComment("ราคาต้อหน่วย");

                entity.Property(e => e.UnitName).HasComment("หน่วยสินค้า");
            });

            modelBuilder.Entity<Pr>(entity =>
            {
                entity.HasKey(e => new { e.Prno, e.CreateByOrgCode });

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนกที่เสนอ (centre II เก็บรหัสสาขา)");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่ายที่เสนอ (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.Poremark).HasComment("หมายเหตุจากการนำไปทำ PO");

                entity.Property(e => e.StaffCode).HasComment("พนักงานที่เสนอซื้อ");
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PriceListCode })
                    .HasName("PK_MPriceList");
            });

            modelBuilder.Entity<PriceListItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PriceListCode });
            });

            modelBuilder.Entity<Pritem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Prno, e.SeqId });
            });

            modelBuilder.Entity<ProcessScheduleChange>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ChangeId });
            });

            modelBuilder.Entity<ProgressNote>(entity =>
            {
                entity.HasKey(e => new { e.ProgressId, e.CreateByOrgCode })
                    .HasName("PK_ProgressNote_1");

                entity.Property(e => e.Assistant).HasComment("ผู้ช่วยแพทย์ 1");

                entity.Property(e => e.Assistant2).HasComment("ผู้ช่วยแพทย์ 2");

                entity.Property(e => e.AuditByCode).HasComment("ผู้ตรวจสอบ");

                entity.Property(e => e.BcstypeId).HasComment("ประเภทรูปร่างสัตว์ 0ไม่ระบุ/1ผมมาก/2ผอม/3ปกติ/4อ้วน/5อ้วนมาก");

                entity.Property(e => e.BpressureHigh).HasComment("ความดันโลหิต (สูง)");

                entity.Property(e => e.BpressureLow).HasComment("ความดันโลหิิต (ต่ำ)");

                entity.Property(e => e.Crt).HasComment("ข้อมูล VET");

                entity.Property(e => e.Fecal).HasComment("อุจจาระ");

                entity.Property(e => e.Fluid).HasComment("สารน้ำ");

                entity.Property(e => e.Food).HasComment("อาหารที่ให้ (ยี่ห้อ,ชนิด)");

                entity.Property(e => e.Ga).HasComment("General appearance พฤติกรรมของสัตว์ เช่น จับหางแล้วกัด");

                entity.Property(e => e.Height).HasComment("ส่วนสูง");

                entity.Property(e => e.Hs).HasComment("เสียงหัวใจ");

                entity.Property(e => e.Hydration).HasComment("ข้อมูล VET");

                entity.Property(e => e.Intake).HasComment("สารน้ำเข้า (CC)");

                entity.Property(e => e.IpdchartNoteId).HasComment("เลขที่รันนิ่ง IPDChartNote ");

                entity.Property(e => e.Ls).HasComment("เสียงการหายใจ");

                entity.Property(e => e.Mentation).HasComment("สภาวะทางอารมณ์ของสัตว์");

                entity.Property(e => e.ModifyNote).HasComment("บันทึกการแก้ไข");

                entity.Property(e => e.MucousMembrane).HasComment("ข้อมูล VET");

                entity.Property(e => e.O2sat).HasComment("เก็บค่าออกซิเจนในเลือด");

                entity.Property(e => e.OtherSecretion).HasComment("บันทึกสารคัดหลั่งอื่นๆ");

                entity.Property(e => e.Output).HasComment("สารน้ำออก (CC)");

                entity.Property(e => e.P).HasComment("อัตราการหายใจ");

                entity.Property(e => e.PainScore).HasComment("ค่าความเจ็บปวด");

                entity.Property(e => e.Posture).HasComment("ท่าทางของสัตว์ เช่น เดินเซ ตัวสั่น");

                entity.Property(e => e.PulseTypeId).HasComment("ประเภทการเต้นของหัวใจ 1อ่อน/2ปกติ/3แรง");

                entity.Property(e => e.R).HasComment("อัตราการเต้นของชีพจร");

                entity.Property(e => e.Rate).HasComment("อัตรา");

                entity.Property(e => e.SedationScore).HasComment("ระดับความง่วงซึม 0=ตื่นรู้สึกตัวดี, 1=ง่วงเล็กน้อย, 2=ง่วงซึม, 3=หลับตลอดเวลา");

                entity.Property(e => e.SeqId).HasComment("ลำดับของรอบภายในแต่ละ VN");

                entity.Property(e => e.Temperature).HasComment("อุณหภูมิเซลเซียส");

                entity.Property(e => e.TemperatureF).HasComment("อุณหภูมิฟาเรนไฮน์");

                entity.Property(e => e.Urine).HasComment("ปัสสาวะ");

                entity.Property(e => e.Vomit).HasComment("อาเจียน");

                entity.Property(e => e.Water).HasComment("น้ำที่ให้ (ยี่ห้อ,ชนิด)");

                entity.Property(e => e.Weight).HasComment("น้ำหนัก");
            });

            modelBuilder.Entity<ProjectAllocate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProjectCode });
            });

            modelBuilder.Entity<ProjectAllocateItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProjectCode, e.SeqId });

                entity.Property(e => e.NetAmount).HasComment("ยอดทั้งหมด");

                entity.Property(e => e.RoitemSeqId).HasComment("SeqIDของROItem");

                entity.Property(e => e.Rono).HasComment("เลขที่ใบรับสินค้า");

                entity.Property(e => e.UsedAmount).HasComment("ยอดที่ใช้ได้/ยอดคงเหลือ");
            });

            modelBuilder.Entity<ProjectProcess>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ProcessId });
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode });

                entity.Property(e => e.PromotionCode).HasComment("รหัสโปรโมชั่น");

                entity.Property(e => e.Barcode).HasComment("รหัสบาร์โค๊ด");

                entity.Property(e => e.IsDiscountable).HasComment("เป็นโปรโมชั่นที่สามารถแก้ส่วนลดได้หรือไม่");

                entity.Property(e => e.IsFriday).HasComment("ใช้ได้ในวันศุกร์");

                entity.Property(e => e.IsMonday).HasComment("ใช้ได้ในวันจันทร์");

                entity.Property(e => e.IsOneTimePromotion).HasComment("เป็นส่วนลดที่ใช้ได้ครั้งเดียวต่อคนไข้หนึ่งคน");

                entity.Property(e => e.IsSaturday).HasComment("ใช้ได้ในวันเสาร์");

                entity.Property(e => e.IsSunday).HasComment("ใช้ได้ในวันอาทิตย์");

                entity.Property(e => e.IsThursday).HasComment("ใช้ได้ในวันพฤหัสบดี");

                entity.Property(e => e.IsTuesday).HasComment("ใช้ได้ในวันอังคาร");

                entity.Property(e => e.IsUseWithMember).HasComment("เป็นโปรโมชั่นที่ต้องใช้ร่วมกับบัตรสมาชิก");

                entity.Property(e => e.IsWednesday).HasComment("ใช้ได้ในวันพุธ");

                entity.Property(e => e.MemberCode).HasComment("รหัสสมาชิกที่ใช้ร่วมกับโปรโมชั่นนี้ (คือ รหัสสินค้า) ");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์");
            });

            modelBuilder.Entity<PromotionItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode, e.SeqId });
            });

            modelBuilder.Entity<PromotionItemFree>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode, e.SeqId });
            });

            modelBuilder.Entity<PromotionItemGroup>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode, e.ItemGroupCode, e.ReferenceIndex })
                    .HasName("PK_PromotionItemGroup_1");

                entity.Property(e => e.ReferenceIndex).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PromotionItemSale>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromotionCode, e.SeqId });

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดสุทธิ");

                entity.Property(e => e.DiscountText).HasComment("อัตราส่วนลด");

                entity.Property(e => e.FromPrice).HasComment("ราคาสินค้าก่อนส่วนลด");
            });

            modelBuilder.Entity<QueTracking>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn, e.SeqId });

                entity.Property(e => e.ActionDateTime).HasComment("วันที่และเวลาที่เกิด Action");

                entity.Property(e => e.ActionTypeId).HasComment("รหัสประเภท Action [1-WaitQue, 2-SendQue, 3-CancelQue, 4-ActiveQue, 5-FinishQue]");

                entity.Property(e => e.DifferenceHours).HasComment("จำนวนชั่วโมงที่แตกต่างกับ Action ก่อนหน้า");

                entity.Property(e => e.DifferenceMinutes).HasComment("จำนวนนาทีที่แตกต่างกับ Action ก่อนหน้า");

                entity.Property(e => e.DifferenceSeconds).HasComment("จำนวนวินาทีที่แตกต่างกับ Action ก่อนหน้า");

                entity.Property(e => e.IsAdmit).HasComment("เป็น Action ที่เกิดขึ้นขณะที่สัตว์ป่วย Admit หรือไม่");

                entity.Property(e => e.IsFinish).HasComment("เป็น Action ที่ทำให้จบคิวหรือไม่");

                entity.Property(e => e.QueCode).HasComment("รหัสห้องปัจจุบันที่ทำให้เกิด Action");

                entity.Property(e => e.QueName).HasComment("ชื่อห้องปัจจุบันที่ทำให้เกิด Action");

                entity.Property(e => e.ToQueCode).HasComment("รหัสห้องที่ส่งคิวไป (เฉพาะ Action ส่งคิว)");

                entity.Property(e => e.ToQueName).HasComment("ชื่อห้องที่ส่งคิวไป (เฉพาะ Action ส่งคิว)");
            });

            modelBuilder.Entity<QueryDatum>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.QueryId });
            });

            modelBuilder.Entity<QueryQue>(entity =>
            {
                entity.HasKey(e => new { e.QueryId, e.QueryGid })
                    .HasName("PK_QueryQue_1");

                entity.Property(e => e.StatusId).HasComment("0-Unknow, 1-Success, 2-Falied");
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.HasKey(e => new { e.QuotationNo, e.CreateByOrgCode });

                entity.Property(e => e.AreaCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.ContactCode).HasComment("รหัสผู้ติดต่อ");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("จำนวนส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.DueAmount).HasComment("จำนวนวันกำหนดยืนราคา");

                entity.Property(e => e.OpportunityId).HasComment("รหัส Opportunity");

                entity.Property(e => e.PaymentMethod).HasComment("เงื่อนไขการชำระ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.QuotationDate).HasComment("วันที่เสนอขาย");

                entity.Property(e => e.QuotationStatusCode).HasComment("สถานะใบเสนอราคา");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SalesCode).HasComment("รหัสพนักงานขาย");

                entity.Property(e => e.TermofPayment).HasComment("ระยะเวลาหนี้");

                entity.Property(e => e.TotalAmount).HasComment("ราคารวม");

                entity.Property(e => e.TransportTypeCode).HasComment("รหัสวิธีการส่ง");

                entity.Property(e => e.VatAmount).HasComment("จำนวนเงิน VAT");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม (VAT)");

                entity.Property(e => e.VatTypeId).HasComment("ไม่คิด แยกนอก รวมใน");
            });

            modelBuilder.Entity<QuotationItem>(entity =>
            {
                entity.HasKey(e => new { e.QuotationNo, e.SeqId, e.CreateByOrgCode });

                entity.Property(e => e.QuotationNo).HasComment("เลขที่ใบเสนอขาย");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.IsConfirm).HasComment("ยืนยันหรือยัง");

                entity.Property(e => e.IsFree).HasComment("1=เป็นของแถม");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.NetAmount).HasComment("ยอดรวมหลังภาษี");

                entity.Property(e => e.PromotionTypeId).HasComment("1=ของสั่งที่ได้แถม 2 = ของแถมตามโปรโมชั่น");

                entity.Property(e => e.Quantity).HasComment("จำนวน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SubTotal).HasComment("ยอดรวมหลังส่วนลด");

                entity.Property(e => e.TotalAmount).HasComment("ยอดรวมก่อนส่วนลด/ภาษี");

                entity.Property(e => e.UnitCost).HasComment("ราคาต้อหน่วย");

                entity.Property(e => e.UnitName).HasComment("หน่วยสินค้า");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");

                entity.Property(e => e.VatAmount).HasComment("มูลค่าภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");
            });

            modelBuilder.Entity<ReCall>(entity =>
            {
                entity.HasKey(e => new { e.ReCallId, e.CreateByOrgCode })
                    .HasName("PK_Recall");

                entity.Property(e => e.ReCallId).HasComment("เลขที่การโทร");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AppId).HasComment("เลขที่การนัดหมาย");

                entity.Property(e => e.IpdexpenseDate).HasComment("โทรเพื่อค่าใช้จ่ายวันที่...");

                entity.Property(e => e.ReCallRemark).HasComment("หมายเหตุการโทร");

                entity.Property(e => e.ReCallStaffCode).HasComment("ผู้โทร");

                entity.Property(e => e.ReCallTypeId).HasComment("ประเภทการโทร เช่น โทรติดตามนัด/ โทรทวงหนี้");

                entity.Property(e => e.ReceiverName).HasComment("ชื่อผู้รับสาย");

                entity.Property(e => e.StatusId).HasComment("สถานะการโทรตามนัด เช่น ติดต่อได้, ติดต่อไม่ได้");
            });

            modelBuilder.Entity<RealSalesIncentive>(entity =>
            {
                entity.HasKey(e => new { e.SalesNo, e.SeqId, e.ItemCode, e.StaffCode, e.IncentiveTypeId });

                entity.Property(e => e.SalesNo).HasComment("Ref. to SalesItem.SalesNo");

                entity.Property(e => e.SeqId).HasComment("Ref. to SalseItem.SeqID");

                entity.Property(e => e.Vn).HasComment("Ref. to SalesItem.VN");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReceiptNo });

                entity.Property(e => e.ReceiptNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดท้ายบิล");

                entity.Property(e => e.TaxAmount).HasComment("ภาษีถูกหัก ณ ที่จ่าย");

                entity.Property(e => e.TotalAmount).HasComment("มูลค่าสินค้า");

                entity.Property(e => e.VatRate).HasComment("มูลค่า vat");
            });

            modelBuilder.Entity<ReceiptItem>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptNo, e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.ReceiptNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดรายตัว");

                entity.Property(e => e.DocNo).HasComment("เลขที่ใบแจ้งหนี้ กรณีรายการในใบเสร็จเป็นใบแจ้งหนี้");

                entity.Property(e => e.TaxAmount).HasComment("มูลค่าภาษีถูกหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีถูกหัก ณ ที่จ่าย");

                entity.Property(e => e.TotalAmount).HasComment("มูลค่า ก่อนหักส่วนลด,ถูกหัก ณ ที่จ่าย, Vat");
            });

            modelBuilder.Entity<RecruitEducation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RecruitCode, e.SeqId });
            });

            modelBuilder.Entity<RecruitExperience>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RecruitCode, e.SeqId });
            });

            modelBuilder.Entity<ReferInReferOut>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Vn });

                entity.Property(e => e.IsReferIn).HasComment("ทำการ ReferIn แล้ว");

                entity.Property(e => e.IsReferOut).HasComment("ทำการ ReferOut แล้ว");

                entity.Property(e => e.ReferInDate).HasComment("วันที่ ReferIn");

                entity.Property(e => e.ReferInFrom).HasComment("ReferIn จาก");

                entity.Property(e => e.ReferInRemark).HasComment("หมายเหตุการ ReferIn");

                entity.Property(e => e.ReferInTypeCode).HasComment("ประเภทการ ReferIn");

                entity.Property(e => e.ReferOutDate).HasComment("วันที่ ReferOut");

                entity.Property(e => e.ReferOutRemark).HasComment("หมายเหตุการ ReferOut");

                entity.Property(e => e.ReferOutStatusCode).HasComment("สถานะการ ReferOut");

                entity.Property(e => e.ReferOutTo).HasComment("ReferOut ไปที่");

                entity.Property(e => e.ReferOutTypeCode).HasComment("ประเภทการ ReferOut");
            });

            modelBuilder.Entity<RegisterProgram>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RegisterId });
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasKey(e => new { e.ReminderId, e.CreateByOrgCode });

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุดการแจ้งเตือน");

                entity.Property(e => e.IsUnEndDate).HasComment("ไม่มีวันสิ้นสุด");

                entity.Property(e => e.OrganizationCode).HasComment("สาขาที่ใช้ประกาศนี้");

                entity.Property(e => e.RecurringTypeId).HasComment("รูปบบการทำซ้ำ 0-ครั้งเดียว/ 1-รายสัปดาห์/ 2-รายเดือน/ 3-ทุกสิ้นเดือน/ 4-รายปี");

                entity.Property(e => e.ReminderDayInMonth).HasComment("วันที่แจ้งเตือนในแต่ละเดือน เป็นวันที่");

                entity.Property(e => e.ReminderDayIndex).HasComment("วันที่แจ้งเดือนในรูปแบบ DayIndex, Sunday is 1");

                entity.Property(e => e.ReminderTypeId).HasComment("รูปแบบการแจ้งเดือน 0-ทุกคน/ 1-เฉพาะผู้สร้าง/ 2-เฉพาะพนักงานบางคน");

                entity.Property(e => e.StartDate).HasComment("วันที่ให้เริ่มแจ้งเตือน");
            });

            modelBuilder.Entity<ReminderItem>(entity =>
            {
                entity.HasKey(e => new { e.ReminderId, e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.ResponseTypeId).HasComment("รูปแบบการตอบรับการแจ้งเตือน 0-ยังไม่เห็น/ 1-Yes/ 2-No");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RequestId });

                entity.Property(e => e.AssignByCode).HasComment("รหัสพนักงานที่มอบหมาย");

                entity.Property(e => e.AttachFile)
                    .IsFixedLength(true)
                    .HasComment("แนบไฟลื์");

                entity.Property(e => e.CloseByCode).HasComment("Complete By");

                entity.Property(e => e.Comment1).HasComment("ANALYSE==>OpenionFrom");

                entity.Property(e => e.CostCenterCode).HasComment("CostCenter");

                entity.Property(e => e.DepartmentCode).HasComment("รัหัสแผนก");

                entity.Property(e => e.Financial).HasComment("Financial Potential Loss");

                entity.Property(e => e.ProposedById).HasComment("ประเภทผู้เสนอ 1=พนักงาน 2=ทั่วไป");

                entity.Property(e => e.QuantitativeImpact).HasComment("Non-Quantitative Impact");

                entity.Property(e => e.RequestByName).HasComment("ชื่อผู้เสนอ");

                entity.Property(e => e.RequestTypeId).HasComment("ประเภทข้้อเสนอ 1=problem 2=opportunity");
            });

            modelBuilder.Entity<RequestFixAsset>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RequestId, e.FixAssetCode });
            });

            modelBuilder.Entity<Requirement>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RequirementId });
            });

            modelBuilder.Entity<RequirementChange>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ChangeId });
            });

            modelBuilder.Entity<Reserve>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReserveNo })
                    .HasName("PK_Reserve2");

                entity.Property(e => e.ReserveNo).HasComment("เลขที่ใบรับจอง/ให้บัญชีใช้/เห็นในตั้งค่ารูปแบบเอกสาร");

                entity.Property(e => e.AddReserveAmount).HasComment("เงินมัดจำเพิ่มใน vn นั้น   จะถูกเครียร์เมื่อรับเงิน");

                entity.Property(e => e.AreaCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.CustomerCode).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CustomerName).HasComment("ชื่อลูกค้า");

                entity.Property(e => e.CustomerPono).HasComment("เลขที่ใบสั่งของลูกค้า");

                entity.Property(e => e.CustomerTel).HasComment("เบอร์โทรศัพท์ลูกค้า");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DocNo).HasComment("เลขที่ใบสั่งของลูกค้า");

                entity.Property(e => e.IsExpire).HasComment("0 = ยังไม่หมดอายุ 1=หมดอายุ");

                entity.Property(e => e.PaymentMethod).HasComment("เงื่อนไขชำระหนี้");

                entity.Property(e => e.PaymentTerm).HasComment("ระยะเวลาหนี้");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.QueGroupCode).HasComment("รหัสกลุ่มคิวที่จอง");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReserveDate).HasComment("วันที่รับสั่งจอง");

                entity.Property(e => e.ReserveRefNo).HasComment("เลขที่อ้างอิงกันเองระหว่าง Reserve+ReserveItem");

                entity.Property(e => e.ReserveTypeId).HasComment("ประเภทการรับมัดจำ 0=ปกติ, 1=ฝากเลี้ยง");

                entity.Property(e => e.SaleCode).HasComment("รหัสพนักงานขาย");

                entity.Property(e => e.TotalAmount).HasComment("รวมก่อนหักส่วนลด Cash+Cheque");

                entity.Property(e => e.TransportByCode).HasComment("รหัสการขนส่ง");

                entity.Property(e => e.TransportDate).HasComment("วันที่กำหนดส่งสินค้า");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษี");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษี");
            });

            modelBuilder.Entity<ReserveItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReserveNo, e.SeqId });

                entity.Property(e => e.ReserveNo).HasComment("เลขที่ใบรับจอง");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.DocDate).HasComment("วันที่รับมัดจำในแต่ละครั้ง");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.NetAmount).HasComment("ราคารวมหลังหักส่วนลด");

                entity.Property(e => e.Quantity).HasComment("จำนวนจอง");

                entity.Property(e => e.Remark).HasComment("หมายเหตุการรับมัดจำแต่ละครั้ง (7P)");

                entity.Property(e => e.ReserveRefNo).HasComment("เลขที่อ้างอิงระหว่าง Reserve + ReserverItem เป็นเลขที่ีรันขึ้นมาใหม่ ");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");
            });

            modelBuilder.Entity<ReservePay>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReservePayNo });

                entity.Property(e => e.ReservePayNo).HasComment("เลขที่ใบจ่ายเงินมัดจำ");

                entity.Property(e => e.BankCode).HasComment("รหัสธนาคาร");

                entity.Property(e => e.BranchBankCode).HasComment("รหัสสาขาธนาคาร");

                entity.Property(e => e.CashAmount).HasComment("จำนวนเงินสด");

                entity.Property(e => e.ChequeAmount).HasComment("จำนวนเงินเช็ค");

                entity.Property(e => e.ChequeDate).HasComment("วันที่เช็ค");

                entity.Property(e => e.ChequeNo).HasComment("เลขที่เช็ค");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบกำกับภาษี");

                entity.Property(e => e.IsNotReVat).HasComment("ขอคืนภาษีไม่ได้");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReservePayDate).HasComment("วันที่จ่าย");

                entity.Property(e => e.TaxAmount).HasComment("ภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TotalAmount).HasComment("ราคารวม");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษี");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษี");

                entity.Property(e => e.VendorCode).HasComment("รหัสเจ้าหนี้");
            });

            modelBuilder.Entity<ReservePayItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReservePayNo, e.SeqNo });

                entity.Property(e => e.ReservePayNo).HasComment("เลขที่ใบจ่ายมัดจำ");

                entity.Property(e => e.SeqNo).HasComment("ลำดับรายการ");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.Quantity).HasComment("จำนวนจอง");

                entity.Property(e => e.TotalAmount).HasComment("รวมก่อนหักส่วนลด");

                entity.Property(e => e.UnitCost).HasComment("ราคาทุน/หน่วย");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");
            });

            modelBuilder.Entity<ReturnFromCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnFromCustomerNo });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AreaCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.CashAmount).HasComment("รวมลดเงินสด/มูลค่าหนี้");

                entity.Property(e => e.ChequeAmount).HasComment("รวมลดเช็ค");

                entity.Property(e => e.CreditAmount).HasComment("รวมลดเครดิต");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลุกค้า");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.DownLiabilityId).HasComment("ประเภทการลดหนี้");

                entity.Property(e => e.IsAddVat).HasComment("เป็นการยื่นภาษีมูลค่าเพิ่ม เพิ่มอีก");

                entity.Property(e => e.NetAmount).HasComment("รวมหลัง หัก/รวมภาษี");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReturnDate).HasComment("วันที่รับคืน");

                entity.Property(e => e.SalesCode).HasComment("รหัสพนักงานขาย");

                entity.Property(e => e.SalesNo).HasComment("เลขที่ใบขายปัจจุบัน");

                entity.Property(e => e.TotalAmount).HasComment("ราคารวม");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");

                entity.Property(e => e.VatBaseAmount).HasComment("มูลค่าฐานภาษี");

                entity.Property(e => e.VatChargeId).HasComment("ประเภทภาระภาษี");

                entity.Property(e => e.VatInPeriodId).HasComment("ยื่นภาษีในงวดบัญชีที่");

                entity.Property(e => e.VatRate).HasComment("อัคราภาษี");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษี 1:ไม่คิด 2: แยกนอก 3:รวมใน");

                entity.Property(e => e.Vn).HasComment("VNปัจจุบัน");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ReturnFromCustomerItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnFromCustomerNo, e.SeqId })
                    .HasName("PK_ReturnItem");

                entity.Property(e => e.ReturnFromCustomerNo).HasComment("เลขที่ใบรับคืน");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.NetAmount).HasComment("ราคารวม");

                entity.Property(e => e.PackageId).HasComment("เลขที่ชุดเพื่อบ่งบอกความเป็นชุดเดียวกัน  ในกรณีที่สั่งยาชุดแบบเดียวกัน 2 ครั้งใน 1 บิล");

                entity.Property(e => e.Quantity).HasComment("จำนวนรับคืน");

                entity.Property(e => e.SeqIdFromSalesItem).HasComment("เก็บ SeqID จาก SalesItem ว่ารับคืนมาจาก SeqID เท่าไหร่");

                entity.Property(e => e.SeqIdreturnFromSalesItem).HasComment("เก็บ SeqID ของ SalesItem ที่รายการนี้(รายติดลบนี้)ไปอยู่ที่ SalesItem SeqID เท่าไหร่");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ReturnToVendor>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnToVendorNo });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.ReturnToVendorNo).HasComment("เลขที่ใบคืนสินค้า");

                entity.Property(e => e.CashAmount).HasComment("รวมลดเงินสด/มูลค่าหนี้");

                entity.Property(e => e.ChequeAmount).HasComment("รวมลดเช็ค");

                entity.Property(e => e.CreateByCode).HasComment("ผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้างรายการ");

                entity.Property(e => e.CreditAmount).HasComment("รวมลดเครดิต");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.DownLiabilityId).HasComment("ประเภทการลดหนี้");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบกำกับภาษี");

                entity.Property(e => e.IsAddVat).HasComment("เป็นการยื่นภาษีมูลค่าเพิ่ม เพิ่มอีก");

                entity.Property(e => e.IsNotReVat).HasComment("ขอคืนภาษีไม่ได้");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.RoNo).HasComment("เลขที่ใบรับ");

                entity.Property(e => e.TotalAmount).HasComment("มูลค่าที่ส่งคืนทั้งหมด");

                entity.Property(e => e.VatAmount).HasComment("ภาษี");

                entity.Property(e => e.VatChargeId).HasComment("ประเภทภาระภาษี");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษี");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษี");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<ReturnToVendorItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnToVendorNo, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ReturnToVendorNo).HasComment("เลขที่ใบส่งคืน");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.AccountCode).HasComment("ผังบัญชี");

                entity.Property(e => e.CancelByCode).HasComment("รหัสผู้ยกเลิก");

                entity.Property(e => e.CancelDate).HasComment("วันที่ยกเลิก");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.LotNoE).HasComment("LOT ภายนอก");

                entity.Property(e => e.LotNoI).HasComment("LOT ภายใน");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่ส่งคืน");

                entity.Property(e => e.TotalAmount).HasComment("มูลค่าที่ส่งคืนของแต่ละรายการ");

                entity.Property(e => e.UnitCost).HasComment("ทุนต่อหน่วยในครั้งที่กำลังลดหนี้");

                entity.Property(e => e.UnitName).HasComment("ชื่อหน่วย");

                entity.Property(e => e.UnitPrice).HasComment("ราคาต่อหน่วยที่เคยทำ RO มา");

                entity.Property(e => e.Whcode).HasComment("รหัสคลังที่ตัดออก");
            });

            modelBuilder.Entity<Ro>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Rono });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.Rono).HasComment("เลขที่ใบรับ");

                entity.Property(e => e.Aeamount).HasComment("ยอดมัดจำเจ้าหนี้ที่เอามาใช้กับ RO นี้");

                entity.Property(e => e.Aeno).HasComment("เลขที่ใบจ่ายมัดจำเจ้าหนี้ ที่นำมาใช้กับ RO นี้");

                entity.Property(e => e.CashPayAmount).HasComment("ยอดจ่ายเงินสด");

                entity.Property(e => e.ConstraintMethodId).HasComment("เงื่อนไขหลักในการชำระ (1=ชำระสด, 2=ชำระภายในเดือนถัดไป,3= ชำระภายในจำนวนวันที่ระบ,4= ชำระภายในสิ้นเดือน )");

                entity.Property(e => e.ConstraintPayment).HasComment("ข้อความเงื่อนไขการชำระ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DepartmentCode).HasComment("แผนกที่รับสินค้า");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดท้ายบิลเฉพาะรายการที่ไม่มี Vat");

                entity.Property(e => e.DiscountAmountForVat).HasComment("ส่วนลดท้ายบิลเฉพาะรายการที่มี Vat");

                entity.Property(e => e.DiscountDueDate).HasComment("วันสุดท้ายที่จะได้ส่วนลด");

                entity.Property(e => e.DiscountDueValue).HasComment("มูลค่าส่วนลด(ขึนอยู่กับ discount unit ด้วย)");

                entity.Property(e => e.DiscountText).HasComment("อัตราส่วนลดท้ายบิลเฉพาะรายการที่มี Vat");

                entity.Property(e => e.DiscountTextForVat).HasComment("อัตราส่วนลดท้ายบิลเฉพาะรายการที่มี Vat");

                entity.Property(e => e.DiscountUnitId).HasComment("หน่วยของส่วนลด 0=%  1=บาท");

                entity.Property(e => e.DownAmount).HasComment("จำนวนเงินมัดจำ");

                entity.Property(e => e.DownPayNo).HasComment("เลขที่เงินมัดจำ");

                entity.Property(e => e.DueDate).HasComment("วันครบกำหนดที่ต้องชำระ");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II เก็บรหัสแผนก)");

                entity.Property(e => e.InvoiceDate).HasComment("วันที่ใบกำกับสินค้า");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบกำกับสินค้า");

                entity.Property(e => e.IsAddVat).HasComment("เป็นการยื่นภาษีมูลค่าเพิ่ม เพิ่มอีก");

                entity.Property(e => e.IsBegin).HasComment("1=เป็นรายการยอดยกมารายตัวเมื่อเริ่มใช้โปรแกรม");

                entity.Property(e => e.IsComplete).HasComment("1=สถานะ inv ผ่าน สามารถรับชำระได้");

                entity.Property(e => e.IsLock).HasComment("กำลังใช้ข้อมูลนี้อยู่");

                entity.Property(e => e.IsNotReturnVat).HasComment("ขอคืนภาษีไม่ได้");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.PayAmount).HasComment("มูลค่าที่จ่ายชำระแล้ว");

                entity.Property(e => e.PaymentMethod).HasComment("เงื่อนไขการชำระ");

                entity.Property(e => e.PaymentTerm).HasComment("ระยะเวลาหนี้");

                entity.Property(e => e.Pono).HasComment("เลขที่ใบสั่งซื้อ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.RecurringGroupNo).HasComment("เลขที่ชุดใบบันทึกเอกสารล่วงหน้า");

                entity.Property(e => e.RecurringName).HasComment("ชุดการทำ Recurring ตามที่ User กรอก");

                entity.Property(e => e.RecurringNo).HasComment("เลขที่ใบบันทึกเอกสารล่วงหน้า");

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างอิง");

                entity.Property(e => e.Remark).HasComment("หมายเหตุการรับยา");

                entity.Property(e => e.Rodate).HasComment("วันที่รับสินค้า");

                entity.Property(e => e.RotypeId).HasComment("ประเภทการรับ 1= รับซื้อ,2= รับของแลกเปลี่ยน ,3= รับของทดลอง");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่รับ");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินรวมเฉพาะรายการที่ไม่มี Vat ก่อนให้ส่วนลดท้ายบิล");

                entity.Property(e => e.TotalAmountForVat).HasComment("จำนวนเงินรวมเฉพาะรายการที่มี Vat ก่อนให้ส่วนลดท้ายบิล");

                entity.Property(e => e.TransferFromOrgCode).HasComment("รหัสองค์กรที่โอนสินค้ามา");

                entity.Property(e => e.TransferNo).HasComment("เลขที่ใบโอน");

                entity.Property(e => e.TransportCode).HasComment("รหัสการขนส่ง");

                entity.Property(e => e.VatAmount).HasComment("จำนวนภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatChargeId).HasComment("ประเภทภาระภาษี");

                entity.Property(e => e.VatInPeriodId).HasComment("งวดที่ยื่นภาษี");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิม");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VendorAddressCode).HasComment("รหัสที่อยู่ผู้จำหน่าย");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.Whcode).HasComment("รหัสคลังที่รับ");
            });

            modelBuilder.Entity<Roitem>(entity =>
            {
                entity.HasKey(e => new { e.Rono, e.SeqId, e.CreateByOrgCode });

                entity.Property(e => e.Rono).HasComment("เลขที่ใบรับซื้อ");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CutQty).HasComment("จำนวนที่ตัดสินค้าคงเหลือ");

                entity.Property(e => e.DiscountAmount).HasComment("มูลค่าส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("เงื่อนไขการลด");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.FactionCode).HasComment("รหัสฝ่าย (centre II) เก็บรหัสแผนก");

                entity.Property(e => e.FdalotNo).HasComment("Lot ในการผิลิต");

                entity.Property(e => e.IsCalVat).HasComment("คำนวณภาษีหรือไม่");

                entity.Property(e => e.IsExpense).HasComment("1=ตัดเป็นค่าใช้จ่ายของแผนกที่รับ");

                entity.Property(e => e.IsFree).HasComment("1=เป็นของแถม");

                entity.Property(e => e.IsSales).HasComment("ถููกขายแล้วหรือยัง");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.LocationCode).HasComment("รหัสที่เก็บ");

                entity.Property(e => e.LotNoE).HasComment("Lot ภายนอก");

                entity.Property(e => e.LotNoI).HasComment("Lot ภายใน");

                entity.Property(e => e.Manufacturer).HasComment("เก็บข้อมูลผู้ผลิต");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่รับ");

                entity.Property(e => e.ReturnToVendorQty).HasComment("จำนวนที่ส่งคืนผู้จำหน่าย");

                entity.Property(e => e.Rodate).HasComment("วันที่รับสินค้า");

                entity.Property(e => e.SalesQty).HasComment("จำนวนที่ขายไปแล้ว");

                entity.Property(e => e.SellCost).HasComment("ต้นทุนขาย(เทียบจากต้นทุนซื้อแปลงเป็นต้นทุนขาย)");

                entity.Property(e => e.SerialNo).HasComment("เลข Serial No.");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินรวม");

                entity.Property(e => e.UnitCode).HasComment("รหัสหน่วย");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุน/หน่วย");

                entity.Property(e => e.UnitName).HasComment("หน่วยสินค้า");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง(อ้างอิงถึงแผนกได้)");
            });

            modelBuilder.Entity<RoomTran>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RoomTransId, e.SeqId })
                    .HasName("PK_ReserveRoom");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุด");

                entity.Property(e => e.EndTime).HasComment("เวลาที่สิ้นสุด");

                entity.Property(e => e.PetCareChargeTypeId).HasComment("ประเภทการคิดเงินฝากเลี้ยง 1=ค้างคืน 2=รายวัน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุการจองฝากเลี้ยง");

                entity.Property(e => e.ReserveByCode).HasComment("รหัสพนักงานที่ทำการจอง");

                entity.Property(e => e.RoomTransTypeId).HasComment("'ระบุว่าเป็นประเภทไหน 1=Admit  2=จองกรง");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่ม");

                entity.Property(e => e.StartTime).HasComment("เวลาที่เริ่ม");
            });

            modelBuilder.Entity<SalaryCalc>(entity =>
            {
                entity.HasKey(e => new { e.SalaryCalcId, e.CreateByOrgCode });

                entity.Property(e => e.SalaryCalcId).HasComment("รหัส Running Record");

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.BaseIncome).HasComment("เงินเดือนค่าจ้างที่ใช้ในการคำนวณ (หากเป็นรายเดือน จะเท่ากันกับ BaseSalary)");

                entity.Property(e => e.BaseSalary).HasComment("ฐานเงินเดือนค่าจ้าง ณ งวดประมวลผล");

                entity.Property(e => e.CalcForMonth).HasComment("ประมวลผลประจำเดือน (บางที 1 เดือนประกอบไปด้วยหลายๆ งวด)");

                entity.Property(e => e.CalcPeriod).HasComment("งวดที่คำนวณ");

                entity.Property(e => e.CalcYear).HasComment("ปีที่คำนวณ (ปีทำงาน)");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.IncomeBeforOt).HasComment("รายได้ที่ใช้ในการคำนวณ OT");

                entity.Property(e => e.IncomeBeforProvidentFund).HasComment("รายได้ที่ใช้ในการคำนวณกองทุนสำรองเลี้ยงชีพ (ยังไม่ได้ใช้เผื่ออนาคต)");

                entity.Property(e => e.IncomeBeforSocial).HasComment("รายได้ท่ใช้ในการคำนวณประกันสังคม");

                entity.Property(e => e.IncomeBeforTax).HasComment("รายได้ที่ใช้ในการคำนวณภาษี");

                entity.Property(e => e.IncomeBeforTaxTaxIgnorePeriod).HasComment("รายได้ที่ใช้ในการคำนวณภาษี ที่ไม่ต้องนำไปคูณกับจำนวนงวด ให้มองเป็นเงินก้อนตลอดทั้งปี");

                entity.Property(e => e.IncomeBeforeTaxTaxIgnorePeriod).HasComment("รายได้รวมเพื่อใช้ในการคำนวณภาษีในงวดนี้ซึ่งไม่ต้องนำไปคูณกับจำนวนงวดให้มองเป็นยอดตลอดทั้งปีเลย");

                entity.Property(e => e.IncomeNetAmount).HasComment("รายได้สุทธิที่พนักงานได้รับในงวดนี้");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.PongSakMoneyBank1).HasComment("ยอดเงินที่จะนำเข้าบัญชีที่ 1 ของแพทย์พงศ์ศักดิ์");

                entity.Property(e => e.PongSakMoneyBank2).HasComment("ยอดเงินที่จะนำเข้าบัญชีที่ 2  ของแพทย์พงศ์ศักดิ์");

                entity.Property(e => e.PongSakSalaryOt).HasComment("ยอดเงินค่าจ้างรายวันกับเงิน \r\nOT แต่ละวันของพนักงานแพทย์พงศ์ศักดิ์ไว้คำนวณประกันสงคม");

                entity.Property(e => e.SalaryAndOt).HasComment("ยอดเงินเดือนรวมOT");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.StaffPayType).HasComment("ประเภทพนักงาน ณ งวดที่ประมวลผล");

                entity.Property(e => e.TotalDayForCalc).HasComment("จำนวนวันที่ใช้ในการคำนวณ");

                entity.Property(e => e.TotalDeductForThisPeriod).HasComment("ยอดรวมรายการหักทั้งหมดในงวดนี้");

                entity.Property(e => e.TotalHourForCalc).HasComment("จำนวนชั่วโมงที่ใช้ในการคำนวณ");

                entity.Property(e => e.TotalIncomeForThisPeriod).HasComment("ยอดรวมรายได้ทั้งหมดยังไม่หักในงวดนี้");

                entity.Property(e => e.TotalJobForCalc).HasComment("จำนวนปริมาณงานของพนักงานเหมาจ่าย (เผื่ออนาคต ตอนนี้ยังไม่ใช้)");

                entity.Property(e => e.TotalLeaveDay).HasComment("จำนวนวันที่ลางาน");

                entity.Property(e => e.TotalLeaveHour).HasComment("จำนวนชั่วโมงที่ลางาน");
            });

            modelBuilder.Entity<SalaryCalcItem>(entity =>
            {
                entity.HasKey(e => new { e.SalaryCalcItemId, e.CreateByOrgCode });

                entity.Property(e => e.SalaryCalcItemId).HasComment("รหัส Running Record");

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.InDeCode).HasComment("รหัส รายรับ รายการหัก");

                entity.Property(e => e.InDeDetail).HasComment("อธิบายรายละเอียดที่มาของเงิน");

                entity.Property(e => e.InDeDisplay).HasComment("ชื่อ รายรับ รายการหัก สำหรับแสดง by item");

                entity.Property(e => e.InDeName).HasComment("ชื่อ รายรับ รายการหัก สำหรับแสดงแบบกลุ่ม");

                entity.Property(e => e.IsCalcTax).HasComment("เป็นรายการที่มีการคำนวณภาษีหรือไม่?");

                entity.Property(e => e.IsDeduct).HasComment("ใช่รายการหักหรือไม่? (เอามาด้วย ไม่ต้องเสียเวลา join มาอีกรอบ)");

                entity.Property(e => e.IsIgnorePeriod).HasComment("เป็นรายการที่มีการคำนวณภาษีแบบรายได้ที่ได้รับครั้งเดียวหรือไม่?");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ItemNo).HasComment("ลำดับที่ในรายการ");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.SalaryCalcId).HasComment("รหัส Running Record ของ SalaryCalc");

                entity.Property(e => e.Tag1).HasComment("ฟิลด์ สำรองไว้เก็บรหัสที่จำเป็นต่อการทำงานของโปรแกรม 1 (คล้ายๆ Property Tag ของ Control ต่างๆใน VB)");

                entity.Property(e => e.Tag2).HasComment("ฟิลด์ สำรองไว้เก็บรหัสที่จำเป็นต่อการทำงานของโปรแกรม 2 (คล้ายๆ Property Tag ของ Control ต่างๆใน VB)");

                entity.Property(e => e.TagNum1).HasComment("ฟิลด์ สำรองไว้เก็บตัวเลขที่จำเป็นต่อการทำงานของโปรแกรม 1 (เช่น หากเป็นเงินประกันสังคม จะเก็บเป็นยอดเงินที่นายจ้างจ่ายสมทบ)");

                entity.Property(e => e.TagNum2).HasComment("ฟิลด์ สำรองไว้เก็บตัวเลขที่จำเป็นต่อการทำงานของโปรแกรม 2 (เช่น หากเป็นเงินประกันสังคม จะเก็บเป็นอัตราที่นายจ้างจ่ายสมทบ)");

                entity.Property(e => e.TotalAmount).HasComment("ยอดเงิน");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => new { e.SalesNo, e.CreateByOrgCode })
                    .HasName("PK_Sales_1");

                entity.Property(e => e.SalesNo).HasComment("เลขที่การขาย SalesNo");

                entity.Property(e => e.ApproveByCode).HasComment("อนุมัติส่วนลดโดย");

                entity.Property(e => e.AreaCode).HasComment("รหัสเขตการขาย");

                entity.Property(e => e.CashAmount).HasComment("จำนวนเงินสดรับ");

                entity.Property(e => e.ChargeAmount).HasComment("จำนวนเงินชาร์จ");

                entity.Property(e => e.ChargeText).HasComment("รูปแบบการชาร์จ");

                entity.Property(e => e.ClaimAmount).HasComment("รวมยอดส่งเบิกที่เกิดจากสิทธิ์");

                entity.Property(e => e.ClaimDiscountAmount).HasComment("เก็บยอดส่วนลดที่เบิกกับผู้จ่ายร่วม");

                entity.Property(e => e.CostAmount).HasComment("จำนวนต้นทุนรวม");

                entity.Property(e => e.CouponAmount).HasComment("ยอดชำระด้วย Coupon");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CustomerPoNo).HasComment("เลขที่ใบสั่งซื้อ");

                entity.Property(e => e.CustomerServiceCode).HasComment("รหัสผู้ดูแล");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DebtAmount).HasComment("ยอดค้างในครั้งนี้");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลดสุทธิ");

                entity.Property(e => e.DiscountAmountForVat).HasComment("ส่วนลดสุทธิเฉพาะยอดที่มีภาษี");

                entity.Property(e => e.DiscountFix).HasComment("ส่วนลดแบบเป็นตัวเงิน");

                entity.Property(e => e.DiscountPoint).HasComment("ส่วนลดที่ใช้จากการแลกแต้ม");

                entity.Property(e => e.DiscountText).HasComment("รูปแบบส่วนลด");

                entity.Property(e => e.DiscountTextForVat).HasComment("อัตราส่วนลดเฉพาะยอดที่มีภาษี");

                entity.Property(e => e.DoctorCode).HasComment("รหัสแพทย์");

                entity.Property(e => e.DoctorFee).HasComment("ค่าตรวจแพทย์");

                entity.Property(e => e.DownReceiveAmount).HasComment("จำนวนเงินมััดจำ");

                entity.Property(e => e.DownReceiveNo).HasComment("เลขที่เงิินมััดจำ");

                entity.Property(e => e.DueDate).HasComment("วันกำหนดชำระเงิน");

                entity.Property(e => e.FactionCode).HasComment("รหัสแผนก");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบกำกับภาษี");

                entity.Property(e => e.IsAddVat).HasComment("ยื่นภาษีมูลค่าเพิ่มหรือไม่");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.NetAmountForCalVat).HasComment("ยอดสุทธิที่จะนำไปคำนวณภาษี");

                entity.Property(e => e.NurseCode).HasComment("รหัสพยาบาล");

                entity.Property(e => e.OtherBranchCode).HasComment("รหัสสาขาอื่น");

                entity.Property(e => e.OtherBranchTypeId).HasComment("1=ขายสาขานี้แต่ทำสาขาอื่น, 2=ทำสาขานี้แต่ทำสาขาอื่น");

                entity.Property(e => e.PayDebtAmount).HasComment("ยอดจ่ายค้างหนี้");

                entity.Property(e => e.PaymentTerm).HasComment("เงื่อนไขการชำระเงิน");

                entity.Property(e => e.PeriodId).HasComment("รหัสงวดบัญชี");

                entity.Property(e => e.Poscode).HasComment("รหัสเครื่องจุดขาย");

                entity.Property(e => e.PriceWeight).HasComment("น้ำหนักในการเฉลี่ยราคาสินค้าหลังหักส่วนลดรายตัว/ท้ายบิล ใช้กับ Clinic Pongsak");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Ptcode).HasComment("รหัสผู้ช่วย");

                entity.Property(e => e.ReceiptNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.ReceiveAmount).HasComment("จำนวนเงินที่จ่ายแล้ว");

                entity.Property(e => e.RedeemPoint).HasComment("จำนวนแต้มที่แลก");

                entity.Property(e => e.RedeemPointSeqId).HasComment("สำหรับอ้างอิงว่าเป็นการใช้การแลกแต้มจากโปรแกรม Izpal Member ซึ่งตัดแต้มไปแล้ว");

                entity.Property(e => e.ReduceDebtAmount).HasComment("ยอดยกหนี้");

                entity.Property(e => e.ReferenceIndex).HasComment("เลขที่อ้างอืงการแยกเล่มจาก MDocument");

                entity.Property(e => e.Remark).HasComment("หมายเหตุุ");

                entity.Property(e => e.ReserveAmount).HasComment("รับเงินมัดจำ");

                entity.Property(e => e.ReserveNo).HasComment("เลขที่ใบรับจอง");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิที่ใช้ในครั้งนี้");

                entity.Property(e => e.RightDiscountAmount).HasComment("รวมส่วนลดที่เกิดจากสิทธิ์");

                entity.Property(e => e.RoundingAmount).HasComment("จำนวนปัดเศษไม่เกิน 1");

                entity.Property(e => e.SalesCode).HasComment("รหัสพนักงาน้ขาย");

                entity.Property(e => e.SalesDate).HasComment("วันที่ขาย");

                entity.Property(e => e.SumDiscountAmount).HasComment("ยอดส่วนลดรายตัว");

                entity.Property(e => e.SumSocialDiscountAmount).HasComment("ยอดรวมราคาเบิกได้ (ไม่หักจากยอดราคาสินค้า)");

                entity.Property(e => e.SumTotalAmount).HasComment("ยอดรวมรายตัว");

                entity.Property(e => e.TotalAmount).HasComment("ยอดรวมทั้งหมด");

                entity.Property(e => e.TotalAmountForNonVat).HasComment("ยอดรวมจำนวนเงินที่ไม่คิดVat");

                entity.Property(e => e.TotalAmountForVat).HasComment("ยอดรวมจำนวนเงินที่คิดVat");

                entity.Property(e => e.TransportByCode).HasComment("รหัสวิธีการขนส่ง");

                entity.Property(e => e.VatAmount).HasComment("ยอดภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatChargeId).HasComment("รหัสประเภทภาระภาษี");

                entity.Property(e => e.VatInPeriodId).HasComment("งวดในการยื่นภาษี");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatTypeId).HasComment("ประเภทภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.Vn).HasComment("Visit No.");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<SalesIncentive>(entity =>
            {
                entity.HasKey(e => new { e.SalesNo, e.SeqId, e.StaffCode, e.IncentiveTypeId });

                entity.Property(e => e.SalesNo).HasComment("SalesNo จากตาราง SalesItem");

                entity.Property(e => e.SeqId).HasComment("SeqID ของ SalesItem");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่เป็นผู้ได้รับค่าตอบแทนตามบรรทัดนี้");

                entity.Property(e => e.IncentiveTypeId).HasComment("สำรหับเก็บว่าเป็นค่าตอบแทนชนิดไหน All,Do,Sell,Consult,DF");

                entity.Property(e => e.IncentiveFromFix).HasComment("ค่าตอบแทนสุทธิ ที่คำนวณจากค่าตอบแทนคงที่ (หน่วยบาท)");

                entity.Property(e => e.IncentiveFromRate).HasComment("ค่าตอบแทนสุทธิ ที่คำนวณจากอัตราค่าตอบแทน(หน่วยบาท)");

                entity.Property(e => e.NetBeforeCal).HasComment("ราคาสุทธิของสินค้าที่นำมาคำนวณ (ถ้าไม่ใช่ส่วนกลางจะเป็นยอดสุทธิหักกับค่าตอบแทนส่วนกลางก่อน)");

                entity.Property(e => e.ReceiveTypeId).HasComment("รูปแบบการรับชำระเงิน 1=รับเงินธรรมดา, 2=รับการจ่ายชำระยอดค้าง");

                entity.Property(e => e.RefSalesItemSeqId).HasComment("ลำดับตามตาราง SalesItem");

                entity.Property(e => e.RefSalesNo).HasComment("เลขที่อ้างอิงใบขาย");

                entity.Property(e => e.Vn).HasComment("VN จากตาราง SalesItem");
            });

            modelBuilder.Entity<SalesItem>(entity =>
            {
                entity.HasKey(e => new { e.SalesNo, e.SeqId, e.CreateByOrgCode })
                    .HasName("PK_SalesItem_1");

                entity.Property(e => e.SalesNo).HasComment("เลขที่ใบขาย");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.AppId).HasComment("เลขที่การแจ้งเตือนจากตาราง Appointment ของรายการสินค้านี้");

                entity.Property(e => e.ApplyTypeId).HasComment("เก็บประเภทการสั่ง OPD=100 IPD=200 ผ่าตัด=300 ฝากเลี้ยง=500 POS=900 การเงิน=1000");

                entity.Property(e => e.ApproveByCode).HasComment("อนุมัติส่วนลดโดย");

                entity.Property(e => e.ChargeAmount).HasComment("จำนวนเงินชาร์จ");

                entity.Property(e => e.ChargeText).HasComment("รูปแบบการชาร์จ");

                entity.Property(e => e.ClaimAmount).HasComment("จำนวนเงินส่งเบิก");

                entity.Property(e => e.ClaimDiscountAmount).HasComment("เก็บยอดส่วนลดที่เบิกกับผู้จ่ายร่วม");

                entity.Property(e => e.ConsultByCode).HasComment("รหัสผู้แนะนำ");

                entity.Property(e => e.CostTypeId).HasComment("ประเภทต้นทุน 1 : เฉลี่ย 2 Fifo 3 ไม่คิดต้นทุน 4 อ้างอิง");

                entity.Property(e => e.CourseGroupId).HasComment("เลขที่ชุดคอร์ส");

                entity.Property(e => e.CourseNo).HasComment("เลขที่คอร์ส");

                entity.Property(e => e.CourseSeqId).HasComment("ลำดับที่คอร์สย่อย");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้ขาย");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.CutStockQty).HasComment("จำนวนที่ตัดสต็อก");

                entity.Property(e => e.Cvn).HasComment("Customer Visit No. (เก็บข้อมูลแต่ละครั้งที่ลูกค้ามาเช่น ลูกค้าพาสัตว์มา 3 ตัวพร้อมกัน จะได้ 1 CVN แต่จะได้ 3 VN ของสัตว์เลี้ยง)");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนกที่ขาย");

                entity.Property(e => e.DfbyCode).HasComment("รหัสแทพย์ที่ได้ DF");

                entity.Property(e => e.DiscountAmount).HasComment("ส่วนลด");

                entity.Property(e => e.DiscountText).HasComment("อัตราส่วนลด");

                entity.Property(e => e.DispenseByCode).HasComment("ผู้จัดยา");

                entity.Property(e => e.DoByCode).HasComment("คนทำ");

                entity.Property(e => e.Dose1).HasComment("วิธีใช้1 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose1Code).HasComment("รหัสวิธีใช้1");

                entity.Property(e => e.Dose2).HasComment("วิธีใช้2 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose2Code).HasComment("รหัสวิธีใช้2");

                entity.Property(e => e.Dose3).HasComment("วิธีใช้3 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose3Code).HasComment("รหัสวิธีใช้3");

                entity.Property(e => e.Dose4).HasComment("วิธีใช้4 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose4Code).HasComment("รหัสวิธีใช้4");

                entity.Property(e => e.Dose5).HasComment("วิธีใช้5 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.Dose5Code).HasComment("รหัสวิธีใช้5");

                entity.Property(e => e.Dose6).HasComment("วิธีใช้6 (ตามที่แสดงในหน้าจอโปรแกรม)");

                entity.Property(e => e.DoseText).HasComment("วิธีใช้");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุของยา");

                entity.Property(e => e.FactionCode).HasComment("รหัสแผนก");

                entity.Property(e => e.FixAssetCode).HasComment("รหัสเครื่องมือแพทย์ที่ใช้");

                entity.Property(e => e.FixAssetTime).HasComment("เวลาที่ใช้เครื่องมือแพทย์");

                entity.Property(e => e.Fxremark).HasComment("เหตุผลที่ยอมขายยา FX");

                entity.Property(e => e.HomeCareProgressId).HasComment("เลขที่ HomeCareProgress");

                entity.Property(e => e.IncentiveRate).HasComment("อัตราค่าตอบแทน");

                entity.Property(e => e.IncentiveRateC).HasComment("อัตราค่าตอบแทนส่วนกลาง");

                entity.Property(e => e.IncomeByPurposeTypeId).HasComment("จุดประสงค์ในการขาย");

                entity.Property(e => e.InvoiceNo).HasComment("เลขที่ใบแจ้งหนี้");

                entity.Property(e => e.IsCalVat).HasComment("คำนวณภาษี");

                entity.Property(e => e.IsEarnPoint).HasComment("สินค้าที่ร่วมรายการสะสมแต้ม");

                entity.Property(e => e.IsFree).HasComment("เป็นของแถมหรือไม่");

                entity.Property(e => e.IsFx).HasComment("เป็นรายการที่ FX");

                entity.Property(e => e.IsPaid).HasComment("สถานะการจ่ายเงิน 0-ยัง/ 1-จ่ายแล้ว/ 2-เตรียมจ่าย");

                entity.Property(e => e.IsPay).HasComment("กิน/ฉีดแล้ว/ตรวจสอบรายการแล้ว");

                entity.Property(e => e.IsPost).HasComment("ลงบัญชี");

                entity.Property(e => e.IsPrepare).HasComment("--- ยกเลิกการใช้ ---");

                entity.Property(e => e.IsPrintLabel).HasComment("พิมพ์ฉลากยาหรือไม่");

                entity.Property(e => e.IsPrintOrder).HasComment("พิมพ์ออกใบสั่งยาแล้ว");

                entity.Property(e => e.IsPromotionFree).HasComment("เป็นของแถมที่เกิดจากโปรโมชั่น");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.ItemOrderTypeId).HasComment("ประเภทการสั่งรายการ Rx=1, Tx=2, Lab=3, XRay=4, Preventive=5, Grooming=6, Product=7, Others=8, Petcare=9");

                entity.Property(e => e.ItemPrice).HasComment("ราคาสินค้าที่ถูกตั้งค่าไว้ขณะนั้น");

                entity.Property(e => e.LotNo).HasComment("สำหรับพิมพ์ฉลากยา");

                entity.Property(e => e.MemberCardNumber).HasComment("เลขที่บัตรสมาชิกที่เกิดขึ้น ณ ตอนที่ซื้อ member ใหม่");

                entity.Property(e => e.MemberCardRenewSeqId).HasComment("สำหรับเก็บ seqID ของ customerMemberCard ที่ต้องการต่ออายุ");

                entity.Property(e => e.MemberCardSeqId).HasComment("เก็บรหัสอ้างอิงจาก CustomerMemberCard.SeqID");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินหลังหักภาษี");

                entity.Property(e => e.OngoingTypeId).HasComment("เก็บว่าการสั่งมาจากสั่งธรรมดา(1), สั่งต่อเนื่อง(2), สั่งจากรายการเดิม(3)");

                entity.Property(e => e.OrderQty).HasComment("จำนวนที่สั่ง");

                entity.Property(e => e.PackageId).HasComment("เลขที่ชุดเพื่อบ่งบอกความเป็นชุดเดียวกัน  ในกรณีที่สั่งยาชุดแบบเดียวกัน 2 ครั้งใน 1 บิล");

                entity.Property(e => e.PayDate).HasComment("วันที่กิน/วันที่ฉีด/วันที่ตรวจสอบรายการ");

                entity.Property(e => e.PayIncentiveDate).HasComment("วันที่ต้องจ่ายค่าตอบแทน");

                entity.Property(e => e.PharmaRequestSeqId).HasComment("ลำดับของใบจัดยาตาม VN");

                entity.Property(e => e.PharmaStatusId).HasComment("สถานะการจัดยา 0-ไม่จัดยา, 1-สั่งจัดยา, 2-จัดยาเรียบร้อย, 3-มีการอัพเดท, 4-ยกเลิก");

                entity.Property(e => e.PromotionCode).HasComment("รหัสโปรโมชั่น");

                entity.Property(e => e.PromotionId).HasComment("รหัสบ่งบอกความเป็นโปรโมชั่นเดียวกัน(ไม่ใช่PomotionCode)");

                entity.Property(e => e.PromotionNo).HasComment("เลขที่โปรโมชั่นที่ใช้ (เลขที่คูปองของโปรโมชั่น)");

                entity.Property(e => e.PromotionTypeId).HasComment("1=ของสั่งที่ได้แถม 2 = ของแถมตามโปรโมชั่น");

                entity.Property(e => e.RealAmount).HasComment("ราคาที่เฉลี่ยจาก Sales.PriceWeight ของทั้งบิลใช้กับ Clinic Pongsak");

                entity.Property(e => e.ReceiptNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.ReservePayNo).HasComment("เก็บว่ารายการนี้มาจากการคืนมัดจำหรือไม่");

                entity.Property(e => e.RightCode).HasComment("รหัสสิทธิ์ที่ใช้กับ สินค้า");

                entity.Property(e => e.RightDiscountAmount).HasComment("ส่วนลดสุทธิจากสิทธิ์");

                entity.Property(e => e.RightDiscountRate).HasComment("อัตราส่วนลดจากสิทธิ์");

                entity.Property(e => e.RightNo).HasComment("เลขที่สิทธิ");

                entity.Property(e => e.Round).HasComment("เก็บรอบการรักษา");

                entity.Property(e => e.SalesByCode).HasComment("รหัสผู้ขายรายการนี้");

                entity.Property(e => e.SalesDate).HasComment("วันที่ขาย");

                entity.Property(e => e.SalesTypeId).HasComment("เก็บว่าการสั่งครั้งนี้เป็น แบบสั่งให้ OPD หรือ สั่งให่ IPD---  1=OPD, 2=IPD, ฝากเลี้ยง=3, ขายปลีก=4 , HomeCare=5");

                entity.Property(e => e.SerialNo).HasComment("เลข Serial No. ที่ขาย");

                entity.Property(e => e.SocialDiscountAmount).HasComment("ยอดที่สามารถนำไปเบิกได้ (ไม่ใช่ส่วนลด ไม่มีผลกับยอดรวม มศว.)");

                entity.Property(e => e.SubscriptionDate).HasComment("วันที่สมัครสมาชิก");

                entity.Property(e => e.TaxAmount).HasComment("ภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TaxRate).HasComment("อัตราภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.TotalAmount).HasComment("รวมหลังหักส่วนลด");

                entity.Property(e => e.UnitCode).HasComment("หน่วยสินค้า");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุน/หน่วย เฉลี่ย ตามหน่วยเก็บ");

                entity.Property(e => e.UnitName).HasComment("หน่วยขาย");

                entity.Property(e => e.UnitPrice).HasComment("ราคา/หน่วย");

                entity.Property(e => e.UseQty).HasComment("จำนวนที่คนไข้ใช้ไป");

                entity.Property(e => e.VatAmount).HasComment("ภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VatRate).HasComment("อัตราภาษีมูลค่าเพิ่ม");

                entity.Property(e => e.VendorCode).HasComment("ผู้ผลิต");

                entity.Property(e => e.Vn).HasComment("Visit No.");

                entity.Property(e => e.VoucherCreditLimit).HasComment("เก็บวงเงินของสินค้าประเภทบัตรกำนัล เพื่อบันทึกลง CustomerVoucherItem.CreditLimit");

                entity.Property(e => e.VoucherDiscountAmount).HasComment("ส่วนลดที่เกิดจากบัตรกำนัล เพื่อเอาไว้ใช้ในการรับคืนสินค้าจะได้คืนวงเงินได้ถูก");

                entity.Property(e => e.VoucherDiscountRate).HasComment("อัตราส่วนลดที่เกิดจากบัตรกำนัล");

                entity.Property(e => e.VoucherSeqId).HasComment("เก็บเลข SeqID ของวงเงินของลูกค้าจากตารางCustomerVoucherItem");

                entity.Property(e => e.WaitReturnQty).HasComment("จำนวนสินค้าที่ถูกเลือกเพื่อเตรียมจะรับคืนจากลูกค้า (DrugStore)");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");

                entity.Property(e => e.XrayTypeCode).HasComment("กรณีเป็น X-ray รหัสประเภทการ X-ray");
            });

            modelBuilder.Entity<SalesMember>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SaleMemberCode, e.Vn })
                    .HasName("PK_SaleMember");

                entity.Property(e => e.CardCode).HasComment("รหัสบัตร");

                entity.Property(e => e.CurrentMoney).HasComment("เงินคงเหลือ");

                entity.Property(e => e.CurrentPoint).HasComment("แต้มปัจจุบัน");

                entity.Property(e => e.TotalRecievePoint).HasComment("แต้มที่ได้รับทั้งหมด");

                entity.Property(e => e.TotalRedeemPoint).HasComment("แต้มที่ใช้ทั้งหมด");

                entity.Property(e => e.TotalRefillMoney).HasComment("เงินที่เติมทั้งหมด");

                entity.Property(e => e.TotalUseMoney).HasComment("เงินที่ใช้ทั้งหมด");
            });

            modelBuilder.Entity<SalesMemberItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.SalesMemberCode })
                    .HasName("PK_MemberItem");

                entity.Property(e => e.AddMoney).HasComment("จำนวนเงินที่เพิ่ม");

                entity.Property(e => e.AddPoint).HasComment("จำนวนแต้มที่เพิ่ม");

                entity.Property(e => e.LogTypeId).HasComment("รหัสเหตุการณ์การเก็บแต้มและเงิน");

                entity.Property(e => e.RedeemPoint).HasComment("จำนวนแต้มที่ใช้แลก");

                entity.Property(e => e.UseMoney).HasComment("จำนวนเงินที่ใช้");
            });

            modelBuilder.Entity<SalesPeriod>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PeriodId });

                entity.Property(e => e.PeriodId).HasComment("รหัสรอบบัญชี 1,2,...");

                entity.Property(e => e.CloseTime).HasComment("เวลาปิดรอบ");

                entity.Property(e => e.OpenTime).HasComment("เวลาเปิดรอบบัญชี");

                entity.Property(e => e.PeriodDate).HasComment("วันที่เปิดรอบบัญชี");

                entity.Property(e => e.Poscode).HasComment("รหัสเครื่องเก็บเงิน");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่เปิดรอบบัญชี");

                entity.Property(e => e.StatusId).HasComment("รหัสสถาุนะการเปิดปิดรอบ 1 = Open, 2 = Close");
            });

            modelBuilder.Entity<SpermOvumBank>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DepositNo });

                entity.Property(e => e.DepositNo).HasComment("เลขที่การฝาก");

                entity.Property(e => e.DepositDate).HasComment("วันที่เริ่มฝาก");

                entity.Property(e => e.DepositImage).HasComment("รูปภาพ");

                entity.Property(e => e.DepositNote).HasComment("รายละเอียดการฝาก");

                entity.Property(e => e.DepositTypeId).HasComment("ประเภทการฝาก 1=สเปิร์ม, 2=ไข่");

                entity.Property(e => e.DestroyDate).HasComment("วันที่ทำลาย");

                entity.Property(e => e.DestroyDepositNote).HasComment("รายละเอียดการทำลาย");

                entity.Property(e => e.ExpireDate).HasComment("วันหมดอายุฝาก");

                entity.Property(e => e.Location).HasComment("สถานที่เก็บ");

                entity.Property(e => e.StaffCode).HasComment("ผู้บันทึกฝาก");
            });

            modelBuilder.Entity<Sspreport>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.Icd10code).HasComment("รหัสโรค");

                entity.Property(e => e.Icd9cmcode).HasComment("รหัสอาการ");

                entity.Property(e => e.Icd9cmtypeCode).HasComment("รหัสประเภทการรักษา 1อายุรกรรม/ 2ศัลยกรรม");

                entity.Property(e => e.Month10Amount).HasComment("ยอดรวมเดือนที่ 10");

                entity.Property(e => e.Month11Amount).HasComment("ยอดรวมเดือนที่ 11");

                entity.Property(e => e.Month12Amount).HasComment("ยอดรวมเดือนที่ 12");

                entity.Property(e => e.Month1Amount).HasComment("ยอดรวมเดือนที่ 1");

                entity.Property(e => e.Month2Amount).HasComment("ยอดรวมเดือนที่ 2");

                entity.Property(e => e.Month3Amount).HasComment("ยอดรวมเดือนที่ 3");

                entity.Property(e => e.Month4Amount).HasComment("ยอดรวมเดือนที่ 4");

                entity.Property(e => e.Month5Amount).HasComment("ยอดรวมเดือนที่ 5");

                entity.Property(e => e.Month6Amount).HasComment("ยอดรวมเดือนที่ 6");

                entity.Property(e => e.Month7Amount).HasComment("ยอดรวมเดือนที่ 7");

                entity.Property(e => e.Month8Amount).HasComment("ยอดรวมเดือนที่ 8");

                entity.Property(e => e.Month9Amount).HasComment("ยอดรวมเดือนที่ 9");

                entity.Property(e => e.SpeciesCode).HasComment("รหัสประเภทสัตว์");

                entity.Property(e => e.Summary).HasComment("รวมทั้งปี");

                entity.Property(e => e.SyndromeGroupCode).HasComment("รหัสกลุ่มอาการ");
            });

            modelBuilder.Entity<StaffAdvanceReceive>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvanceReceiveNo });

                entity.Property(e => e.AdvanceReceiveNo).HasComment("เลขที่การรับคืนเงินล่วงหน้า");

                entity.Property(e => e.AdvanceReceiveDate).HasComment("วันที่การรับคืนเงินล่วงหน้า");

                entity.Property(e => e.AdvanceRequestNo).HasComment("เลขที่ใบขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.Amount).HasComment("จำนวนเงินที่คาดว่าจะจ่ายชำระ");

                entity.Property(e => e.InDeCode).HasComment("รหัสรายการหักจากเงินเดือน");

                entity.Property(e => e.LeftPeriod).HasComment("จำนวนงวดที่พนักงานต้องจ่ายคืน โดยเริ่มต้นจากงวด Period ไปจำนวนกี่งวด");

                entity.Property(e => e.PeriodNo).HasComment("เป็นระบุงวดของเงินเดือนที่ต้องการหัก");

                entity.Property(e => e.PeriodYear).HasComment("เป็นการระบะปีของเงินเดือนที่ต้องการหักจ่าย");
            });

            modelBuilder.Entity<StaffAdvanceRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.AdvanceRequestNo });

                entity.Property(e => e.AdvanceRequestNo).HasComment("เลขที่ใบขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.AdvanceRequestDate).HasComment("วันที่ขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.AmountPerPeriod).HasComment("จำนวนเงินที่ต้องชำระต่อหนึ่งงวด ในกรณีที่เลือกหักจากเงินเดือน");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสพนักงานที่อนุมัติ");

                entity.Property(e => e.ApproveDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1.รออนุมัติ 2.อนุมัติ 3.ไม่อนุมัติ");

                entity.Property(e => e.InDeCode).HasComment("รหัสรายการหัก");

                entity.Property(e => e.LeftPeriod).HasComment("จำนวนงวดคงเหลือ (ที่ต้องหัก)");

                entity.Property(e => e.PeriodNo).HasComment("งวดที่เริ่มรับหรือหัก");

                entity.Property(e => e.ReceiveTypeId).HasComment("ประเภทการรับชำระคืน 1.เงินสด 2.หักจากเงินเดือน");

                entity.Property(e => e.RemainAmount).HasComment("ยอดเงืนคงเหลือที่ต้องชำระคืน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่ขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินที่ขอเบิกล่วงหน้า");
            });

            modelBuilder.Entity<StaffBorrowAsset>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BorrowAssetNo });

                entity.Property(e => e.BorrowAssetNo).HasComment("เลขที่เอกสารการถือครองทรัพย์สิน");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสพนักงานที่อนุมัติ");

                entity.Property(e => e.ApproveDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.BorrowAssetDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่ถือครองทรัพย์สิน");
            });

            modelBuilder.Entity<StaffBorrowAssetItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.BorrowAssetNo, e.SeqId });

                entity.Property(e => e.BorrowAssetNo).HasComment("เลขที่เอกสารการถือครองทรัพย์สิน");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่");

                entity.Property(e => e.AssetName).HasComment("ชื่อสินทรัพย์");

                entity.Property(e => e.FinishDate).HasComment("วันที่สิ้นสุดการถือครอง");

                entity.Property(e => e.RegisterNo).HasComment("เลขทะเบียน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.SerialNo).HasComment("Serial Number");
            });

            modelBuilder.Entity<StaffByGroup>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.StaffGroupCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.StaffGroupCode).HasComment("รหัสกลุ่มการใช้ระบบ");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");
            });

            modelBuilder.Entity<StaffCancelPending>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CancelPendingNo });

                entity.Property(e => e.CancelPendingNo).HasComment("เลขที่เอกสารยกเลิกพักงาน");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.CancelPendingDate).HasComment("วันที่ยกเลิก");

                entity.Property(e => e.CancelPendingDetail).HasComment("เหตุผลการยกเลิกพักงาน");

                entity.Property(e => e.PendingNo).HasComment("เลขที่เอกสารพักงาน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<StaffChangeShift>(entity =>
            {
                entity.HasKey(e => new { e.StaffChangeShiftNo, e.CreateByOrgCode });
            });

            modelBuilder.Entity<StaffChildRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ChildRequestNo });

                entity.Property(e => e.ChildRequestNo).HasComment("เลขที่ใบขอเบิกค่าเล่าเรียนบุตร");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสพนักงานที่อนุมัติ");

                entity.Property(e => e.ApproveDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.ChildRequestDate).HasComment("วันที่ขอเบิกค่าเล่าเรียนบุตร");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.InDeId).HasComment("รหัสรายการรายได้");

                entity.Property(e => e.PaymentTypeId).HasComment("ประเภทการจ่าย");

                entity.Property(e => e.RemainAmount).HasComment("จำนวนเงินที่ขอเบิกค่าเล่าเรียนบุตรคงเหลือ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่ขอเบิกค่าเล่าเรียนบุตร");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินที่ขอเบิกค่าเล่าเรียนบุตรทั้งหมด");
            });

            modelBuilder.Entity<StaffChildRequestItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ChildRequestNo, e.SeqId });

                entity.Property(e => e.ChildRequestNo).HasComment("เลขที่ใบขอเบิกค่าเล่าเรียนบุตร");

                entity.Property(e => e.SeqId).HasComment("วันที่ขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.Amount).HasComment("จำนวนเงินที่เบิกได้");

                entity.Property(e => e.BillNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.ChildName).HasComment("ชื่อบุตร");

                entity.Property(e => e.ClassLevel).HasComment("ระดับหารศึกษา");

                entity.Property(e => e.Institute).HasComment("สถาบันการศึกษา");

                entity.Property(e => e.StudyYear).HasComment("ปีการศึกษา");

                entity.Property(e => e.Term).HasComment("ภาคการศึกษา");
            });

            modelBuilder.Entity<StaffContract>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ContractNo });

                entity.Property(e => e.ContractNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.ApproveDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.ApproveDetail).HasComment("หมายเหตุ");

                entity.Property(e => e.ContractDate).HasComment("วันที่ทำสัญญา");

                entity.Property(e => e.ContractDetail).HasComment("รายละเอียด");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุดสัญญา");

                entity.Property(e => e.NextContractDate).HasComment("วันที่ทำสัญญาครั้งต่อไป");

                entity.Property(e => e.Salary).HasComment("อัตราค่าจ้าง");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มต้นสัญญา");

                entity.Property(e => e.StartWorkDate).HasComment("วันที่เริ่มต้นทำงาน");
            });

            modelBuilder.Entity<StaffDiscountLimit>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode, e.SeqId });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.DiscountLimit).HasComment("วงเงินส่วนลดที่ให้ได้ประจำเดือน");

                entity.Property(e => e.ExistingDiscount).HasComment("วงเงินส่วนลดคงเหลือ");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");
            });

            modelBuilder.Entity<StaffEducation>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.SeqId });
            });

            modelBuilder.Entity<StaffExperience>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SeqId, e.StaffCode });

                entity.Property(e => e.PositionName).HasComment("ชื่อตำแหน่ง");

                entity.Property(e => e.SectionName).HasComment("ชื่อฝ่าย");
            });

            modelBuilder.Entity<StaffFamily>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.SeqId });
            });

            modelBuilder.Entity<StaffGroupRight>(entity =>
            {
                entity.HasKey(e => new { e.StaffGroupCode, e.StaffRightCode, e.CreateByOrgCode })
                    .HasName("PK_StaffGroupScreen");

                entity.Property(e => e.StaffGroupCode).HasComment("รหัสกลุ่มผู้ใช้ระบบ");

                entity.Property(e => e.StaffRightCode).HasComment("รหัส Screen");

                entity.Property(e => e.CreateByOrgCode).HasComment("isylsoj;p'ko");

                entity.Property(e => e.IsCanApprove).HasComment("สามาุรถอนุมัติรายการได้หรือไม่");

                entity.Property(e => e.IsCanCancel).HasComment("สามารถยกเลิกรายการได้หรือไม่");

                entity.Property(e => e.IsCanCreate).HasComment("สามารถเพิ่มได้/ไม่");

                entity.Property(e => e.IsCanDelete).HasComment("สามารถลบได้/ไม่");

                entity.Property(e => e.IsCanEdit).HasComment("สามารถแก้ไขได้/ไม่");

                entity.Property(e => e.IsCanPrint).HasComment("สามารถพิมพ์เอกสารได้หรือไม่");

                entity.Property(e => e.IsCanRead).HasComment("สามารถอ่านได้/ไม่");
            });

            modelBuilder.Entity<StaffGuarantee>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.GuaranteeNo });

                entity.Property(e => e.GuaranteeNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.EndDate).HasComment("วันที่สิ้นสุดค้ำประกัน");

                entity.Property(e => e.GuaranteeCashAmount).HasComment("ยอดเงินสดที่ใช้ค้ำประกัน");

                entity.Property(e => e.GuaranteeCurrentAddress1).HasComment("ที่อยู่ 1");

                entity.Property(e => e.GuaranteeCurrentAddress2).HasComment("ที่อยู่ 2");

                entity.Property(e => e.GuaranteeCurrentTelephone).HasComment("โทรศัพท์");

                entity.Property(e => e.GuaranteeDetail).HasComment("รายละเอียดการค้ำประกัน");

                entity.Property(e => e.GuaranteeLimit).HasComment("วงเงินค้ำประกัน");

                entity.Property(e => e.GuaranteeOccupation).HasComment("อาชีพ");

                entity.Property(e => e.GuaranteePosition).HasComment("ตำแหน่ง");

                entity.Property(e => e.GuaranteeRelation).HasComment("ความสัมพันธ์");

                entity.Property(e => e.GuaranteeTypeId).HasComment("บุคคล วงเงิน อื่นๆ");

                entity.Property(e => e.GuaranteeWorkAddress1).HasComment("ที่ทำงาน 1");

                entity.Property(e => e.GuaranteeWorkAddress2).HasComment("ที่ทำงาน 2");

                entity.Property(e => e.GuaranteeWorkTelephone)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("โทรศัพท์");

                entity.Property(e => e.GuaranteeYearlyIncome).HasComment("รายได้ทั้งปี");

                entity.Property(e => e.OtherGuarantee).HasComment("ค้ำประกันอื่นๆ");

                entity.Property(e => e.SpouseGuaranteeName).HasComment("ชื่อคู่สมรัส");

                entity.Property(e => e.SpouseGuaranteeTelephone).HasComment("โทรศัพท์");

                entity.Property(e => e.SpouseGuaranteeWorkAddress1).HasComment("ที่ทำงาน 1");

                entity.Property(e => e.SpouseGuaranteeWorkAddress2).HasComment("ที่ทำงาน 2");

                entity.Property(e => e.SpouseGuaranteeYearlyIncome).HasComment("รายได้ทั้งปี");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.StartDate).HasComment("วันที่เริ่มต้นค้ำประกัน");
            });

            modelBuilder.Entity<StaffIncomeDeductTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.InDeId });

                entity.Property(e => e.InDeId).HasComment("เลขที่รายการรายได้หรือรายการหัก");

                entity.Property(e => e.Amount).HasComment("จำนวนเงินที่ได้ หรือ ที่หัก จากรายการ");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.InDeCode).HasComment("รหัสรายได้ รายการหัก");

                entity.Property(e => e.IsSystem).HasComment("ใช่ฟิล์ดสงวนของโปรแกรมหรือไม่");

                entity.Property(e => e.LeftPeriod).HasComment("จำนวนงวดคงเหลือ (ที่ต้องการ \r\nให้หัก)");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.PeriodNo).HasComment("งวดที่เริ่มรับหรือหัก");

                entity.Property(e => e.PeriodYear).HasComment("ระบุปีของงวดที่จะได้ หรือหักจ่าย");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<StaffInsurance>(entity =>
            {
                entity.Property(e => e.InsuranceNo).IsFixedLength(true);
            });

            modelBuilder.Entity<StaffLateAbsent>(entity =>
            {
                entity.HasKey(e => new { e.StaffLateAbsentId, e.CreateByOrgCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.AbsentCause).HasComment("สาเหตุการขาดงาน");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.LateAbsentDate).HasComment("วันที่สาย-ขาด");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.TotalLateHours).HasComment("จำนวนชั่วโมงที่สาย หากเป็น 0 แสดงว่าเป็นการขาดงาน");
            });

            modelBuilder.Entity<StaffLeave>(entity =>
            {
                entity.HasKey(e => new { e.LeaveId, e.CreateByOrgCode });
            });

            modelBuilder.Entity<StaffLoan>(entity =>
            {
                entity.HasKey(e => new { e.LoanId, e.CreateByOrgCode });

                entity.Property(e => e.LoanId).HasComment("รหัส Records");

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ContractNo).HasComment("เลขที่สัญญากู้");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.DueDate).HasComment("วันสุดท้ายที่หักเงิน (ชำระเงินครบถ้วน)");

                entity.Property(e => e.LoanDate).HasComment("วันที่ระบุในสัญญากู้");

                entity.Property(e => e.LoanYear).HasComment("ค.ศ. ของปีทำการ");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.Remark).HasComment("Izpal Field");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.TotalDeductPerPeriod).HasComment("จำนวนเงินที่จะให้หักในแต่ละงวด");

                entity.Property(e => e.TotalLoan).HasComment("จำนวนหนี้");

                entity.Property(e => e.TotalNetLoan).HasComment("จำนวนหนี้คงเหลือ หลังจากหักเงินแต่ละงวด");
            });

            modelBuilder.Entity<StaffLoanPayment>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LoanPaymentNo });
            });

            modelBuilder.Entity<StaffLoanRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LoanRequestNo });

                entity.Property(e => e.LoanRequestNo).HasComment("เลขที่ใบขอกู้");

                entity.Property(e => e.CurrentDebt).HasComment("หนี้สินปัจจุบัน");

                entity.Property(e => e.DeductDebtPerPeriod).HasComment("หนี้สินที่ถูกหักต่องวด");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.IncomePerPeriod).HasComment("รายได้ปัจจุบันต่องวด");

                entity.Property(e => e.IsUse).HasComment("เป็นข้อมูลที่ใช้งานแล้วหรือไม่");

                entity.Property(e => e.LoanRequestDate).HasComment("วันที่ขอกู้");

                entity.Property(e => e.TotalAmountLoan).HasComment("จำนวนเงินที่ขอกู้");
            });

            modelBuilder.Entity<StaffLoanResult>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.LoanResultNo });
            });

            modelBuilder.Entity<StaffMedicalPayment>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MedicalPaymentNo });

                entity.Property(e => e.MedicalPaymentNo).HasComment("เลขที่ใบจ่ายค่ารักษาพยาบาล");

                entity.Property(e => e.InDeId).HasComment("เลขที่รายการรายได้ หรือรายการหัก");

                entity.Property(e => e.IsPayment).HasComment("สถานะการจ่ายเงิน 1.จ่ายแล้ว, 0.ยังไม่จ่าย");

                entity.Property(e => e.MedicalPaymentDate).HasComment("วันที่จ่ายค่ารักษาพยาบาล");

                entity.Property(e => e.MedicalRequestNo).HasComment("เลขที่ใบขอเบิกค่ารักษาพยาบาล");

                entity.Property(e => e.PaymentAmount).HasComment("จำนวนเงินที่จ่าย");

                entity.Property(e => e.PaymentTypeId).HasComment("ลักษณะการจ่าย 1.เงินสด 2.จ่ายพร้อมเงินเดือน");

                entity.Property(e => e.PeriodNo).HasComment("มีผลต่องวด");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่จ่ายเงิน");
            });

            modelBuilder.Entity<StaffMedicalRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MedicalRequestNo });

                entity.Property(e => e.MedicalRequestNo).HasComment("เลขที่ใบเบิกค่ารักษาพยาบาล");

                entity.Property(e => e.AmountPerPeriod).HasComment("จำนวนเงินที่ต้องจ่ายต่อหนึ่งงวด ในกรณีที่เลือกจ่ายพร้อมเงินเดือน");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสพนักงานที่อนุมัติ");

                entity.Property(e => e.ApproveDate).HasComment("วันที่อนุมัติ");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1.รออนุมัติ 2.อนุมัติ 3.ไม่อนุมัติ");

                entity.Property(e => e.InDeCode).HasComment("รหัสรายได้");

                entity.Property(e => e.LeftPeriod).HasComment("จำนวนงวดที่ต้องจ่ายเงิน โดยเริ่มจาก PeriodNo");

                entity.Property(e => e.MedicalRequestDate).HasComment("วันที่เบิกค่ารักษาพยาบาล");

                entity.Property(e => e.PaymentTypeId).HasComment("ประเภทการจ่าย 1.เงินสด, 2.จ่ายพร้อมเงินเดือน");

                entity.Property(e => e.PeriodNo).HasComment("งวดที่เริ่มจ่ายเงิน");

                entity.Property(e => e.RemainAmount).HasComment("จำนวนเงินที่เบิกค่ารักษาพยาบาลคงเหลือ ที่ยังไม่จ่ายให้แก่พนักงาน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่เบิกค่ารักษาพยาบาล");

                entity.Property(e => e.TotalAmount).HasComment("จำนวนเงินที่เบิกค่ารักษาพยาบาลทั้งหมด");
            });

            modelBuilder.Entity<StaffMedicalRequestItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.MedicalRequestNo, e.SeqId });

                entity.Property(e => e.MedicalRequestNo).HasComment("เลขที่ใบเบิกค่ารักษาพยาบาล");

                entity.Property(e => e.SeqId).HasComment("ลำดับที่");

                entity.Property(e => e.Amount).HasComment("จำนวนเงินที่เบิก");

                entity.Property(e => e.BillDate).HasComment("วันที่ใบเสร็จ");

                entity.Property(e => e.BillNo).HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.Hospital).HasComment("ชื่อโรงพยาบาลที่เข้ารับการรักษา");

                entity.Property(e => e.PatientName).HasComment("ชื่อคนไข้ที่เข้ารับการรักษา");

                entity.Property(e => e.Relation).HasComment("ความสัมพันธ์ระหว่างคนไข้และพนักงาน ในกรณีที่คนไข้ที่เข้ารับการรักษาไม่ได้เป็นพนักงานที่บริษัท");
            });

            modelBuilder.Entity<StaffOt>(entity =>
            {
                entity.HasKey(e => new { e.Otid, e.CreateByOrgCode })
                    .HasName("PK_MStaffOT");

                entity.Property(e => e.Otid).HasComment("รหัส Record");

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModBycode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.Otcode).HasComment("รหัสประเภทการคำนวณเงิน OT");

                entity.Property(e => e.Otdate).HasComment("วันที่ทำ OT");

                entity.Property(e => e.Otperiod).HasComment("OT ของงวดที่");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.Remark).HasComment("Izpal Field");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.TotalHours).HasComment("ชั่วโมงทำงานใช้สำหรับคำนวณเงิน");
            });

            modelBuilder.Entity<StaffOutstanding>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.OutstandingNo });
            });

            modelBuilder.Entity<StaffPending>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PendingNo });

                entity.Property(e => e.PendingNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.DocDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.EndPendingDate).HasComment("วันที่สิ้นสุดการพักงาน");

                entity.Property(e => e.PendingDuration).HasComment("ระยะเวลาพักงาน");

                entity.Property(e => e.PendingReason).HasComment("เหตุผลการพักงาน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReturnDate).HasComment("วันที่กลับมาทำงาน");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.StartPendingDate).HasComment("วันที่เริ่มพักงาน");
            });

            modelBuilder.Entity<StaffPeriod>(entity =>
            {
                entity.HasKey(e => new { e.PeriodNo, e.CreateByOrgCode, e.PeriodYear, e.PeriodTypeId })
                    .HasName("PK_StaffPeriod2");
            });

            modelBuilder.Entity<StaffPongsakIncome>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.RowId });

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.RowId).HasComment("รหัส Record");

                entity.Property(e => e.Amount).HasComment("ยอดเงินที่ได้รับ");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.DateCalc).HasComment("วันที่คำนวณ");

                entity.Property(e => e.IncomeCode).HasComment("รหัสรายได้");

                entity.Property(e => e.IncomeForDate).HasComment("วันที่ได้รับ");

                entity.Property(e => e.IncomePeriod).HasComment("งวดที่ได้รับ");

                entity.Property(e => e.IncomeString).HasComment("คำอธิบายรายได้");

                entity.Property(e => e.IncomeYear).HasComment("ปีการทำงานที่ได้รับ");

                entity.Property(e => e.IsSystem).HasComment("Izpal Field");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<StaffPromote>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PromoteNo });
            });

            modelBuilder.Entity<StaffPunish>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.PunishNo });

                entity.Property(e => e.PunishNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.ApproveByCode).HasComment("รหัสผู้อนุมัติ");

                entity.Property(e => e.ApproveDetail).HasComment("หมายเหตุ");

                entity.Property(e => e.DocDate).HasComment("วันที่เอกสาร");

                entity.Property(e => e.PunishDetail).HasComment("ความผิดทางวินัย");

                entity.Property(e => e.PunishResult).HasComment("ผลที่ได้รับ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<StaffResign>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ResignNo });

                entity.Property(e => e.BaseSalaryCalcTypeId).HasComment("ฐานการคำนวณเงินเดือน 1= ตามฐานเงินเดือน 2 = ตามวันที่ทำงาน");

                entity.Property(e => e.IsCalcLastSalary).HasComment("คำนวณค่าจ้างเดือนสุดท้าย");

                entity.Property(e => e.IsCalcNonSalaryRevenue).HasComment("คำนวณรายได้ไม่ประจำคงเหลือ");

                entity.Property(e => e.Reason).HasComment("สาเหตุการลาออก");

                entity.Property(e => e.ResignDate).HasComment("วันที่ลาออก");

                entity.Property(e => e.ResignTypeId).HasComment("ประเภทการลาออก");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");
            });

            modelBuilder.Entity<StaffReturnAdvance>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnAdvanceNo });

                entity.Property(e => e.ReturnAdvanceNo).HasComment("รหัสใบรับเงินคืน");

                entity.Property(e => e.AdvanceRequestNo).HasComment("รหัสใบขอเบิกเงินล่วงหน้า");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1.รออนุมัติ 2.อนุมัติ 3.ไม่อนุมัติ");

                entity.Property(e => e.InDeId).HasComment("เลขที่รายการรายได้ หรือรายการหัก");

                entity.Property(e => e.IsReturn).HasComment("สถานะขอการรับคืนเงิน 1.จ่ายแล้ว, 0.ยังไม่จ่าย");

                entity.Property(e => e.PeriodNo).HasComment("ระบุงวดที่ใช้คืนว่าเป็นงวดที่เท่าไหร่");

                entity.Property(e => e.ReceieveTypeId).HasComment("ลักษณะการจ่ายคืน 1.เงินสด 2.หักจากเงินเดือน");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.ReturnAdvanceDate).HasComment("วันที่รับเงินคืนเงินจากพนักงาน");

                entity.Property(e => e.ReturnAmount).HasComment("จำนวนเงินที่จ่ายคืน");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่รับเงิน");
            });

            modelBuilder.Entity<StaffReturnLoan>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ReturnLoanNo });
            });

            modelBuilder.Entity<StaffSalary>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffSalaryId });

                entity.Property(e => e.DeduceAmount1).HasComment("จำนวนหัก1");

                entity.Property(e => e.DeduceAmount10).HasComment("จำนวนหัก10");

                entity.Property(e => e.DeduceAmount2).HasComment("จำนวนหัก2");

                entity.Property(e => e.DeduceAmount3).HasComment("จำนวนหัก3");

                entity.Property(e => e.DeduceAmount4).HasComment("จำนวนหัก4");

                entity.Property(e => e.DeduceAmount5).HasComment("จำนวนหัก5");

                entity.Property(e => e.DeduceAmount6).HasComment("จำนวนหัก6");

                entity.Property(e => e.DeduceAmount7).HasComment("จำนวนหัก7");

                entity.Property(e => e.DeduceAmount8).HasComment("จำนวนหัก8");

                entity.Property(e => e.DeduceAmount9).HasComment("จำนวนหัก9");

                entity.Property(e => e.DeduceName1).HasComment("รายการหักๅ");

                entity.Property(e => e.DeduceName10).HasComment("รายการหัก10");

                entity.Property(e => e.DeduceName2).HasComment("รายการหัก2");

                entity.Property(e => e.DeduceName3).HasComment("รายการหัก3");

                entity.Property(e => e.DeduceName4).HasComment("รายการหัก4");

                entity.Property(e => e.DeduceName5).HasComment("รายการหัก5");

                entity.Property(e => e.DeduceName6).HasComment("รายการหัก6");

                entity.Property(e => e.DeduceName7).HasComment("รายการหัก7");

                entity.Property(e => e.DeduceName8).HasComment("รายการหัก8");

                entity.Property(e => e.DeduceName9).HasComment("รายการหัก9");

                entity.Property(e => e.DepartmentId).HasComment("รหัสแผนก");

                entity.Property(e => e.DepartmentName).HasComment("ชื่อแผนก");

                entity.Property(e => e.Idcard).HasComment("บัตรประชาชน");

                entity.Property(e => e.IncomeAmount1).HasComment("จำนวนรายได้1");

                entity.Property(e => e.IncomeAmount10).HasComment("จำนวนรายได้10");

                entity.Property(e => e.IncomeAmount2).HasComment("จำนวนรายได้2");

                entity.Property(e => e.IncomeAmount3).HasComment("จำนวนรายได้3");

                entity.Property(e => e.IncomeAmount4).HasComment("จำนวนรายได้4");

                entity.Property(e => e.IncomeAmount5).HasComment("จำนวนรายได้5");

                entity.Property(e => e.IncomeAmount6).HasComment("จำนวนรายได้6");

                entity.Property(e => e.IncomeAmount7).HasComment("จำนวนรายได้7");

                entity.Property(e => e.IncomeAmount8).HasComment("จำนวนรายได้8");

                entity.Property(e => e.IncomeAmount9).HasComment("จำนวนรายได้9");

                entity.Property(e => e.IncomeName1).HasComment("รายได้1");

                entity.Property(e => e.IncomeName10).HasComment("รายได้10");

                entity.Property(e => e.IncomeName2).HasComment("รายได้2");

                entity.Property(e => e.IncomeName3).HasComment("รายได้3");

                entity.Property(e => e.IncomeName4).HasComment("รายได้4");

                entity.Property(e => e.IncomeName5).HasComment("รายได้5");

                entity.Property(e => e.IncomeName6).HasComment("รายได้6");

                entity.Property(e => e.IncomeName7).HasComment("รายได้7");

                entity.Property(e => e.IncomeName8).HasComment("รายได้8");

                entity.Property(e => e.IncomeName9).HasComment("รายได้9");

                entity.Property(e => e.OtHolidayAmount1).HasComment("จำนวนวันหยุด");

                entity.Property(e => e.OtHolidayAmount2).HasComment("จำนวนวันหยุดนักขัตตะเริก");

                entity.Property(e => e.ParentOrgCode).HasComment("สาขา");

                entity.Property(e => e.Period).HasComment("คาบการทำงาน");

                entity.Property(e => e.SaveByCode).HasComment("รหัสผู้บันทึก");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.TotalAmount).HasComment("รวมรายได้สุดทิ");

                entity.Property(e => e.TotalBeforeTax).HasComment("รวมรายได้ก่อนหักภาษี");

                entity.Property(e => e.TotalForSocialSecurity).HasComment("รวมรายได้สำหรับคิดประกันสังคม");
            });

            modelBuilder.Entity<StaffSkill>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.SeqId });

                entity.Property(e => e.StaffCode).IsFixedLength(true);
            });

            modelBuilder.Entity<StaffTaxTemplate>(entity =>
            {
                entity.HasKey(e => new { e.StaffCode, e.CreateByOrgCode });

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงาน");

                entity.Property(e => e.AmountDonate).HasComment("บริจาคทั่วๆไป");

                entity.Property(e => e.AmountDonateEdu).HasComment("บริจาคเพื่อการศึกษา");

                entity.Property(e => e.AmountDonateSport).HasComment("บริจาคเพื่อการกีฬา");

                entity.Property(e => e.AmountHealthInsure).HasComment("ยอดเบี้ยประกันสุขภาพบิดามารดาผู้มีเงินได้");

                entity.Property(e => e.AmountHealthSpouseInsure).HasComment("ยอดเบี้ยประกันสุขภาพบิดามารดาคู่สมรส");

                entity.Property(e => e.AmountInterestHouse).HasComment("ดอกเบี้ยเงินกู้เพื่อี่อยู่อาศัย");

                entity.Property(e => e.AmountLifeInsure).HasComment("เบี้ยประกันชีวิตผู้มีเงินได้");

                entity.Property(e => e.AmountLifeSpouseInsure).HasComment("เบี้ยประกันชีวิตคู่สมรส");

                entity.Property(e => e.AmountStockLongPeriod).HasComment("ค่าซื้อหน่วยลงทุนหุ้นระยะยาว");

                entity.Property(e => e.AmountStockProvident).HasComment("ค่าซื้อหน่วยลงทุนฯ การเลี้ยงชีพ");

                entity.Property(e => e.CalcMethod).HasComment("0=โสด 1=สมรสคู่ไม่มีเงินได้ 2=สมรสคู่มีเงินได้รวมคำนวณ 3=สมรสคู่มีเงินได้แยกคำนวณ");

                entity.Property(e => e.ChildEdu).HasComment("จำนวนบุตรศึกษา");

                entity.Property(e => e.ChildNotEdu).HasComment("จำนวนบุตรไม่ศึกษา");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.DadIdcard).HasComment("เลขบัตรประชาชนบิดาผู้มีเงินได้");

                entity.Property(e => e.DadIdcardSpouse).HasComment("เลขบัตรประชาชนบิดาคู่สมรส");

                entity.Property(e => e.IncomeFromOldCompany).HasComment("รายได้จากบริษัทเดิม");

                entity.Property(e => e.IncomeFromOldCompanyBak).HasComment("สำรองข้อมูลรายได้จากบริษัทเดิม");

                entity.Property(e => e.IncomeFromOldCompanyIgnorePeriod).HasComment("รายได้จากบริษัทเดิมที่ได้รับเพียงครั้งเดียว เช่น โบนัส เงินรางวัล ฯลฯ");

                entity.Property(e => e.IncomeFromOldCompanyIgnorePeriodBak).HasComment("สำรองรายได้จากบริษัทเดิมที่ได้รับเพียงครั้งเดียว เช่น โบนัส เงินรางวัล \r\nฯลฯ");

                entity.Property(e => e.IncomeSpouse).HasComment("รายได้คู่สมรส กรณีรวมคำนวณภาษี");

                entity.Property(e => e.IsDeductDad).HasComment("ลดหย่อนบิดาหรือไม่");

                entity.Property(e => e.IsDeductDadSpouse).HasComment("ลดหย่อนบิดาคู่สมรสหรือไม่");

                entity.Property(e => e.IsDeductMom).HasComment("ลดหย่อนมารดาหรือไม่");

                entity.Property(e => e.IsDeductMomSpouse).HasComment("ลดหย่อนมารดาคู่สมรสหรือไม่");

                entity.Property(e => e.IsHealthDadInsure).HasComment("ลดหย่อนประกันสุขภาพบิดาผู้มีเงินได้ หรือไม่?");

                entity.Property(e => e.IsHealthDadSpouseInsure).HasComment("ลดหย่อนประกันสุขภาพบิดาคู่สมรส หรือไม่?");

                entity.Property(e => e.IsHealthMomInsure).HasComment("ลดหย่อนประกันสุขภาพมารดาผู้มีเงินได้ หรือไม่?");

                entity.Property(e => e.IsHealthMomSpouseInsure).HasComment("ลดหย่อนประกันสุขภาพมารดาคู่สมรส หรือไม่?");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.MomIdcard).HasComment("เลขบัตรประชาชนมารดาผู้มีเงินได้");

                entity.Property(e => e.MomIdcardSpouse).HasComment("เลขบัตรประชาชนมารดาคู่สมรส");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.SpouseBirthDate).HasComment("วันเกิดคู่สมรส");

                entity.Property(e => e.SpouseIdcard).HasComment("หมายเลขบัตรประชาชนคู่สมรส");

                entity.Property(e => e.SpouseName).HasComment("ชื่อคู่สมรส (ให้ระบุ นาย นาง หรือ ยศ)");

                entity.Property(e => e.SpouseSurname).HasComment("นามสกุลคู่สมรส");

                entity.Property(e => e.SpouseTaxNo).HasComment("หมายเลขประจำตัวผู้เสียภาษีคู่สมรส");

                entity.Property(e => e.TaxFromOldCompany).HasComment("ภาษีจากบริษัทเดิม");

                entity.Property(e => e.TaxFromOldCompanyBak).HasComment("สำรองข้อมูลภาษีจากบริษัทเดิม");
            });

            modelBuilder.Entity<StaffWorkQue>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StaffCode, e.QueCode });
            });

            modelBuilder.Entity<StaffWorkTime>(entity =>
            {
                entity.HasKey(e => new { e.WorkTimesId, e.CreateByOrgCode });

                entity.Property(e => e.ShiftCode).HasComment("รหัสกะทำงาน");

                entity.Property(e => e.WorkFromDate).HasComment("วัน-เวลาทำงานตั้งแต่");

                entity.Property(e => e.WorkToDate).HasComment("วัน-เวลาทำงานสิ้นสุด");
            });

            modelBuilder.Entity<StockCard>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.StockCardId });

                entity.Property(e => e.AverageCost).HasComment("ต้นทุนต่อหน่วยแบบเฉลี่ย ณ ขณะที่เกิดข้อมูลนี้");

                entity.Property(e => e.CreateDate).HasComment("วันเวลาสร้าง Record");

                entity.Property(e => e.CurrentQty).HasComment("จำนวนสินค้าในคลัง หลังที่เกิดข้อมูลนี้");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DocNo).HasComment("เลขที่เอกสาร");

                entity.Property(e => e.DocTypeId).HasComment("ประเภทเอกสาร");

                entity.Property(e => e.Fifocost).HasComment("ต้นทุนต่อหน่วยแบบเข้าก่อนออกก่อน ณ ขณะที่เกิดข้อมูลนี้");

                entity.Property(e => e.FixCost).HasComment("ต้นทุนต่อหน่วยแบบกำหนดเอง ณ ขณะที่เกิดข้อมูลนี้");

                entity.Property(e => e.IsDone).HasComment("สำหรับระบุว่าการ์ดใบนี้ เอาไปเข้าสู่ระบบขายหมดแล้วหรือยัง (ขายและรับเงิน FIFO)");

                entity.Property(e => e.IsFinish).HasComment("สำหรับระบุว่าการ์ดใบนี้ เอาไปเข้าสู่ระบบจองขายหมดแล้วหรือยัง (สั่งขายแต่ยังไม่ได้รับเงิน FIFO)");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.QuantityIn).HasComment("จำนวนนำเข้า");

                entity.Property(e => e.QuantityOut).HasComment("จำนวนนำออก");

                entity.Property(e => e.RefStockCardId).HasComment("เลขที่บัตรสต๊อกอ้างอิง");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารอ้างอิง");

                entity.Property(e => e.ReplaceCost).HasComment("ต้นทุนต่อหน่วยแบบแทนที่ ณ ขณะที่เกิดข้อมูลนี้");

                entity.Property(e => e.SeqId).HasComment("ลำดับอ้างอิงจากเอกสารต้นทาง เช่น ลำดับใน ROItem, ลำดับใน SalesItem เป็นต้น");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนต่อหน่วย ณ ปัจจุบัน  ขึ้นอยู่กับการตั้งค่าโปรแกรมว่าคำนวณต้นทุนแบบใด");

                entity.Property(e => e.Vn).HasComment("เก็บ VN ที่ทำให้เกิดการ์ดใบนี้ หากเป็นกระบวนการที่ไม่เกิด VN ให้เก็บ 0");

                entity.Property(e => e.Whcode).HasComment("รหัสคลัง");
            });

            modelBuilder.Entity<SurgeryEstimate>(entity =>
            {
                entity.HasKey(e => new { e.SurgeryEstimateNo, e.CreateByOrgCode, e.Vn });
            });

            modelBuilder.Entity<SurgeryEstimateItem>(entity =>
            {
                entity.HasKey(e => new { e.SurgeryEstimateNo, e.SeqId, e.CreateByOrgCode });
            });

            modelBuilder.Entity<SurgeryNote>(entity =>
            {
                entity.HasKey(e => new { e.SurgeryId, e.CreateByOrgCode, e.TreatmentTypeId });

                entity.Property(e => e.TreatmentTypeId).HasComment("ประเภทการมารักษา 1=OPD 2=IPD");

                entity.Property(e => e.SurgeryByCode).HasComment("แพทย์ผู้ผ่าตัด");
            });

            modelBuilder.Entity<TempBeginingAccount>(entity =>
            {
                entity.Property(e => e.TempId).ValueGeneratedNever();

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้ที่สร้างข้อมูล");

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้างข้อมูล");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");
            });

            modelBuilder.Entity<ToDo>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.ToDoId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.ToDoId).HasComment("รหัสรายการ");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.Duration).HasComment("ระยะเวลา/วัน");

                entity.Property(e => e.Remark).HasComment("รายละเอียด");
            });

            modelBuilder.Entity<ToSocialWelfare>(entity =>
            {
                entity.HasKey(e => new { e.ToSwcode, e.CreateByOrgCode });

                entity.Property(e => e.ToSwcode).HasComment("Transfer to social welfare");

                entity.Property(e => e.CreateByOrgCode).HasComment("Create by organization code");

                entity.Property(e => e.AccountNo).HasComment("Account");

                entity.Property(e => e.BranchNo).HasComment("Branch");

                entity.Property(e => e.Company).HasComment("Company");

                entity.Property(e => e.CreateByCode).HasComment("Created by code");

                entity.Property(e => e.CreateDate).HasComment("Created date");

                entity.Property(e => e.IdcardNo).HasComment("ID card no");

                entity.Property(e => e.Income).HasComment("Income of employee");

                entity.Property(e => e.ModByCode).HasComment("Modified by code");

                entity.Property(e => e.ModByOrgCode).HasComment("Modified by organization code");

                entity.Property(e => e.ModDate).HasComment("Modified date");

                entity.Property(e => e.Name).HasComment("Name");

                entity.Property(e => e.ParentOrgCode).HasComment("Parent organization code");

                entity.Property(e => e.PayMonth).HasComment("Month of payment");

                entity.Property(e => e.PayYear).HasComment("Year of payment");

                entity.Property(e => e.Sspay).HasComment("Social welfare pay");

                entity.Property(e => e.StaffCode).HasComment("Staff code");

                entity.Property(e => e.TotalSoW).HasComment("Total amount of social welfare");
            });

            modelBuilder.Entity<ToolSummary>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.FixAssetCode });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.FixAssetCode).HasComment("รหัสเครื่องมือ");

                entity.Property(e => e.BeginDate).HasComment("วันเวลาเริ่มจอง");

                entity.Property(e => e.BookByCode).HasComment("รหัสผู้จอง");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้สร้าง");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้าง");

                entity.Property(e => e.CurrentCount).HasComment("ค่าปัจจุบันของเครื่องมือ");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.EndDate).HasComment("วันเวลาสิ้นสุด");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");
            });

            modelBuilder.Entity<TrainingExpense>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TrainingCode, e.SeqId });

                entity.Property(e => e.ExpenseAmount).HasComment("จำนวนเงิน");

                entity.Property(e => e.ExpenseName).HasComment("ค่าใช้จ่าย");
            });

            modelBuilder.Entity<TrainingJoin>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TrainingCode, e.SeqId });
            });

            modelBuilder.Entity<TrainingSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TrainingCode, e.SeqId });

                entity.Property(e => e.FromTime).HasComment("ตั้งแต่เวลา");

                entity.Property(e => e.ToTime).HasComment("ถึงเวลา");

                entity.Property(e => e.Topic).HasComment("เรื่องที่อบรม");

                entity.Property(e => e.TrainingByName).HasComment("วิทยากร");

                entity.Property(e => e.TrainingDate).HasComment("วันที่อบรม");
            });

            modelBuilder.Entity<TrainingStaff>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TrainingCode, e.SeqId });
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.TransferNo });

                entity.Property(e => e.TransferNo).HasComment("เลขที่ใบโอนสินค้า");

                entity.Property(e => e.BranchOrderNo).HasComment("เลขที่ใบเบิกสินค้าจากสาขา");

                entity.Property(e => e.DepartmentCode).HasComment("รหัสแผนก");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร 1= Pending 2= Approve 3= Cancel");

                entity.Property(e => e.FromOrgCode).HasComment("รหัสสาขาที่โอน");

                entity.Property(e => e.FromWhcode).HasComment("รหัสคลังสินค้าที่โอน");

                entity.Property(e => e.NetAmount).HasComment("จำนวนเงินสุทธิ");

                entity.Property(e => e.ProjectCode).HasComment("รหัสโครงการ");

                entity.Property(e => e.Remark).HasComment("หมายเหตุ");

                entity.Property(e => e.StaffCode).HasComment("รหัสพนักงานที่โอน");

                entity.Property(e => e.ToOrgCode).HasComment("รหัสสาขาที่รับโอน");

                entity.Property(e => e.ToWhcode).HasComment("รหัสคลังสินค้าที่รับโอน");

                entity.Property(e => e.TransferDate).HasComment("วันที่โอนสินค้า");

                entity.Property(e => e.TransferShiftsCount).HasComment("กรณีเป็นรอบย่อย ลำดับการโอนของรอบย่อย");

                entity.Property(e => e.TransferShiftsReferenceNo).HasComment("กรณีเป็นรอบย่อย เก็บเลขที่อ้างอิงว่ามาจากรอบหลักไหน");

                entity.Property(e => e.TransferShiftsTypeId).HasComment("รอบการโอน (Centre2) 1=รอบใหญ่1, 2=รอบใหญ่2, 3=รอบย่อย1, 4=รอบย่อย2");

                entity.Property(e => e.TransferTypeId).HasComment("1=คลัง 2 = สาขา");
            });

            modelBuilder.Entity<TransferCourse>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CourseNo });

                entity.Property(e => e.CourseExpire).HasComment("คอร์สหมดอายุหลังจากสั่งคอร์สหลักกี่วัน");

                entity.Property(e => e.CurrentUseQuantity).HasComment("ปริมาณที่ใช้ไปแล้วทั้งหมด (คอร์สปริมาณ)");

                entity.Property(e => e.CustomerName).HasComment("ชื่อลูกค้าเจ้าของคอร์สก่อนที่จะโอน");

                entity.Property(e => e.IsExpire).HasComment("คอร์สหมดอายุแล้ว");

                entity.Property(e => e.OrganizationCode).HasComment("โอนมาจากรหัสสาขาอะไร");

                entity.Property(e => e.OrganizationName).HasComment("โอนมาจากชื่อสาขาอะไร");

                entity.Property(e => e.TotalQuantity).HasComment("ปริมาณทั้งหมด (คอร์สปริมาณ)");
            });

            modelBuilder.Entity<TransferCourseItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.CourseNo, e.SeqId });

                entity.Property(e => e.Quantity).HasComment("ปริมาณที่ใช้ในครั้งนี้ (คอร์สปริมาณ)");
            });

            modelBuilder.Entity<TransferItem>(entity =>
            {
                entity.HasKey(e => new { e.TransferNo, e.SeqId, e.CreateByOrgCode });

                entity.Property(e => e.TransferNo).HasComment("เลขที่ใบโอนสินค้า");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ExpireDate).HasComment("วันที่หมดอายุ");

                entity.Property(e => e.IsExpense).HasComment("เป็นคาใช้จ่ายหรือไม่");

                entity.Property(e => e.ItemCode).HasComment("รหัสสินค้า");

                entity.Property(e => e.ItemName).HasComment("ชื่อสินค้า");

                entity.Property(e => e.LotNoEx).HasComment("เลข Lot จากภายนอกระบบ");

                entity.Property(e => e.LotNoIn).HasComment("เลข Lot ภายในระบบ");

                entity.Property(e => e.Quantity).HasComment("จำนวนที่โอน");

                entity.Property(e => e.UnitCost).HasComment("ต้นทุนสินค้า");

                entity.Property(e => e.UnitName).HasComment("หน่วยสินค้า");
            });

            modelBuilder.Entity<VaccineItem>(entity =>
            {
                entity.HasKey(e => new { e.VaccineItemId, e.CreateByOrgCode });

                entity.Property(e => e.VaccineItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.BatchNo).HasComment("เลขที่ Batch");

                entity.Property(e => e.CustomerGid).HasComment("รหัสลูกค้า");

                entity.Property(e => e.InjectionByCode).HasComment("ผู้ฉีด");

                entity.Property(e => e.InjectionByName).HasComment("ชื่อผู้ฉีด");

                entity.Property(e => e.InjectionDate).HasComment("วันที่ฉีด");

                entity.Property(e => e.InjectionType).HasComment("ชนิดการฉีด ( 1=ฉีดใน รพ. , 2=ฉีดจากนอก รพ.)");

                entity.Property(e => e.NetAmount).HasComment("ราคา");

                entity.Property(e => e.Quantity).HasComment("ปริมาณในการฉีด");

                entity.Property(e => e.RecordByCode).HasComment("ผู้บันทึก");

                entity.Property(e => e.RecordDate).HasComment("วันที่บันทึก");

                entity.Property(e => e.VaccineCode).HasComment("รหัสวัคซีน");

                entity.Property(e => e.VaccineName).HasComment("ชื่อวัคซีน");

                entity.Property(e => e.VaccineProductTypeId).HasComment("ประเภทวัคซีน 0=ไม่ระบุ , 1=MLV , 2=Killed Vaccine");

                entity.Property(e => e.Vn).HasComment("Visit No.");
            });

            modelBuilder.Entity<VatPurchase>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo })
                    .HasName("PK_VatPurchase_1");

                entity.Property(e => e.DocNo).HasComment("เลขที่ใบภาษีซื้อ");

                entity.Property(e => e.AccountPeriod).HasComment("เลขงวด");

                entity.Property(e => e.RefNo).HasComment("เลขที่เอกสารอ้างอิง");

                entity.Property(e => e.RefSeqId).HasComment("ใช้กรณีที่ VP นี้เกิดจาก การใช้จ่ายเงินสดย่อยเพื่อให้เรียงบรรทัดกันถูกต้อง และแก้ไขตรงบรรทัด");

                entity.Property(e => e.RefTypeId).HasComment("รูปแบบเอกสารอ้างอิง");

                entity.Property(e => e.TaxNo).HasComment("เลขประจำตัวผู้เสียภาษี");

                entity.Property(e => e.VendorTypeId).HasComment("รูปแบบองค์กรของผู้จำหน่าย 1สาขาใหญ่/ 2สาขาย่อย");
            });

            modelBuilder.Entity<VatSale>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.DocNo, e.DocTypeId });
            });

            modelBuilder.Entity<VitalSign>(entity =>
            {
                entity.HasKey(e => new { e.Vn, e.CreateByOrgCode });

                entity.Property(e => e.Vn).HasComment("เลขที่ Visit No");

                entity.Property(e => e.CreateByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.Assistant).HasComment("ผู้ช่วยแพทย์ 1");

                entity.Property(e => e.Assistant2).HasComment("ผู้ช่วยแพทย์ 2");

                entity.Property(e => e.BcstypeId).HasComment("ประเภทรูปร่างสัตว์ 0ไม่ระบุ/1ผมมาก/2ผอม/3ปกติ/4อ้วน/5อ้วนมาก");

                entity.Property(e => e.BlindColor).HasComment("ตาบอดสี");

                entity.Property(e => e.BoneDensity).HasComment("มวลกระดูก");

                entity.Property(e => e.BpressureHigh).HasComment("ความดันโลหิต (สูง) ก่อนทำหัตถการหรือความดันเมื่อมาถึง, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.BpressureHigh2).HasComment("ความดันบน หลังทำหัตถการ, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.BpressureLow).HasComment("ความดันโลหิิต (ต่ำ) ก่อนทำหัตถการหรือความดันเมื่อมาถึง, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.BpressureLow2).HasComment("ความดันล่าง หลังทำหัตถการ, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.BreastI).HasComment("รอบอก");

                entity.Property(e => e.BreastO).HasComment("รอบอก");

                entity.Property(e => e.ChieftComplaint).HasComment("อาการเบื้องต้น");

                entity.Property(e => e.ChieftComplaintModByCode).HasComment("คนที่แก้ไข้อาการเบื้องต้นในหน้าประวัติ");

                entity.Property(e => e.ChieftComplaintModDate).HasComment("วันที่แก้ไข้อาการเบื้องต้นในหน้าประวัติ");

                entity.Property(e => e.CreateByCode).HasComment("Izpal Field");

                entity.Property(e => e.CreateDate).HasComment("Izpal Field");

                entity.Property(e => e.Crt).HasComment("ข้อมูล VET");

                entity.Property(e => e.DoctorDiag).HasComment("ผลการวินิจฉัยแพทย์");

                entity.Property(e => e.DoctorDiagModByCode).HasComment("คนที่แก้ไข้วินิจฉัยในหน้าประวัติ");

                entity.Property(e => e.DoctorDiagModDate).HasComment("วันที่แก้ไข้วินิจฉัยในหน้าประวัติ");

                entity.Property(e => e.DoctorNote).HasComment("หมายเหตุแพทย์");

                entity.Property(e => e.DoctorNoteModByCode).HasComment("คนที่แก้ไข้หมายเหตุแพทย์ในหน้าประวัติ");

                entity.Property(e => e.DoctorNoteModDate).HasComment("วันที่แก้ไข้หมายเหตุแพทย์ในหน้าประวัติ");

                entity.Property(e => e.DoctorOrder).HasComment("การรักษา");

                entity.Property(e => e.DoctorOrderModByCode).HasComment("คนที่แก้ไข้การรักษาในหน้าประวัติ");

                entity.Property(e => e.DoctorOrderModDate).HasComment("วันที่แก้ไข้การรักษาในหน้าประวัติ");

                entity.Property(e => e.EyeSightBareL).HasComment("สายตาเอียงด้านซ้าย");

                entity.Property(e => e.EyeSightBareR).HasComment("สายตาเอียงด้านขวา");

                entity.Property(e => e.Fbs).HasComment("น้ำตาล FBS");

                entity.Property(e => e.FinalDiag).HasComment("การวินิจฉัยขั้นสุดท้าย");

                entity.Property(e => e.Ga).HasComment("General appearance พฤติกรรมของสัตว์ เช่น จับหางแล้วกัด");

                entity.Property(e => e.Gt).HasComment("น้ำตาล GT");

                entity.Property(e => e.Height).HasComment("ส่วนสูง, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.Hs).HasComment("เสียงหัวใจ");

                entity.Property(e => e.Hydration).HasComment("ข้อมูล VET");

                entity.Property(e => e.IsAbnormal).HasComment("ผิดปกติหรือไม่");

                entity.Property(e => e.LabNote).HasComment("บันทึกรายการแล็บ");

                entity.Property(e => e.Ls).HasComment("เสียงหายใจ");

                entity.Property(e => e.MedicationNote).HasComment("บันทึกรายการยาที่แพทย์สั่ง");

                entity.Property(e => e.Mentation).HasComment("สภาวะทางอารมณ์ของสัตว์");

                entity.Property(e => e.ModByCode).HasComment("Izpal Field");

                entity.Property(e => e.ModByOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.ModDate).HasComment("Izpal Field");

                entity.Property(e => e.ModifyNote).HasComment("บันทึกการแก้ไข");

                entity.Property(e => e.MucousMembrane).HasComment("ข้อมูล VET");

                entity.Property(e => e.NurseAidCode).HasComment("รหัสพยาบาล");

                entity.Property(e => e.O2sat).HasComment("เก็บค่าออกซิเจนในเลือด");

                entity.Property(e => e.P).HasComment("อัตราการหายใจ, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.PainScore).HasComment("ค่าความเจ็บปวด");

                entity.Property(e => e.ParentOrgCode).HasComment("Izpal Field");

                entity.Property(e => e.PhyExam).HasComment("ตรวจร่างกาย");

                entity.Property(e => e.PhyExam1).HasComment("ตรวจร่างกายที่มาจากการเช็คระบบร่างกาย");

                entity.Property(e => e.Posture).HasComment("ท่าทางของสัตว์ เช่น เดินเซ ตัวสั่น");

                entity.Property(e => e.PulseTypeId).HasComment("ประเภทการเต้นขอ");

                entity.Property(e => e.R).HasComment("อัตราการเต้นของชีพจร, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.RxNote).HasComment("บันทึกรายการยากลับบ้าน");

                entity.Property(e => e.SpecialIns).HasComment("คำสังพิเศษ");

                entity.Property(e => e.SpecialInsModByCode).HasComment("คนที่แก้ไข้คำสังพิเศษในหน้าประวัติ");

                entity.Property(e => e.SpecialInsModDate).HasComment("วันที่แก้ไข้คำสังพิเศษในหน้าประวัติ");

                entity.Property(e => e.Temperature).HasComment("อุณหภูมิเซลเซียส, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.TemperatureF).HasComment("อุณหภูมิฟาเรนไฮน์, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.Triage).HasComment("NU = Normal\r\n UR = Urgent\r\n LU = Less Urgent\r\n EM = Emergency");

                entity.Property(e => e.TxNote).HasComment("บันทึกรายการรักษา");

                entity.Property(e => e.VitalsignHtmldetail).HasComment("ข้อมูลเพิ่มเติม");

                entity.Property(e => e.Waist).HasComment("รอบเอว");

                entity.Property(e => e.Weight).HasComment("น้ำหนัก, -1=ค่าว่าง(\"\")");

                entity.Property(e => e.XrayNote).HasComment("บันทึกรายการเอ็กซ์เรย์");
            });

            modelBuilder.Entity<VoucherDetail>(entity =>
            {
                entity.HasKey(e => new { e.VoucherTypeCode, e.CreateByOrgCode, e.VoucherNo, e.SeqId })
                    .HasName("PK_VoucherDetail_1");

                entity.Property(e => e.VoucherTypeCode).HasComment("ประเภทของคูปองที่ตั้งค่าในโปรแกรม");

                entity.Property(e => e.VoucherNo).HasComment("เลขที่คูปอง (สามารถซ้ำกันได้ในกรณีที่ใช้ร่วมกับ Promotion)");

                entity.Property(e => e.SeqId).HasComment("เป็น SeqID ของ SalesItem");

                entity.Property(e => e.PromotionId).HasComment("บ่งบอกชุดโปรโมชั่นตาม SalesItem");

                entity.Property(e => e.VoucherTypeId).HasComment("ประเภทคูปอง 1=คูปองแทนเงินสด/ 2=คูปองส่วนลด");
            });

            modelBuilder.Entity<Whitem>(entity =>
            {
                entity.HasKey(e => new { e.Whcode, e.CreateByOrgCode, e.ItemCode });
            });

            modelBuilder.Entity<WhitemDaily>(entity =>
            {
                entity.HasKey(e => new { e.Whcode, e.CreateByOrgCode, e.StockDate, e.ItemCode });

                entity.Property(e => e.StockDate).HasComment("วันเดือนปีของยอดคงเหลือ");
            });

            modelBuilder.Entity<WhitemHistory>(entity =>
            {
                entity.HasKey(e => new { e.Whcode, e.CreateByOrgCode, e.StockMonth, e.StockYear, e.ItemCode });

                entity.Property(e => e.StockDate).HasComment("วันเดือนปีของยอดคงเหลือ");
            });

            modelBuilder.Entity<WithholdingTax>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Whtno });

                entity.Property(e => e.Whtno).HasComment("เลขที่ใบหัก ณ ที่จ่าย");

                entity.Property(e => e.DocStatusId).HasComment("สถานะเอกสาร");

                entity.Property(e => e.IsPaid).HasComment("เอกสาร WHT นี้เอาไปทำจ่ายแล้วหรือยัง หากยังไม่ต้องแสดงในรายการภาษีหัก ณ ที่จ่าย");

                entity.Property(e => e.PayAmount).HasComment("ยอดที่ต้องจ่ายก่อนหัก");

                entity.Property(e => e.RefNo).HasComment("เลขที่อ้างอิง");

                entity.Property(e => e.VendorCode).HasComment("รหัสผู้จำหน่าย");

                entity.Property(e => e.Whtamount).HasComment("จำนวนการหักสุทธิจากยอดที่ต้องจ่าย");
            });

            modelBuilder.Entity<WithholdingTaxItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.Whtno, e.SeqId });

                entity.Property(e => e.Whtno).HasComment("เลขที่ใบหัก ณ ที่จ่าย");

                entity.Property(e => e.SeqId).HasComment("ลำดับ");

                entity.Property(e => e.PayAmount).HasComment("ยอดเงินที่ต้องจ่ายก่อนหัก");

                entity.Property(e => e.Whtamount).HasComment("ยอดหักทั้งหมด");

                entity.Property(e => e.Whtrate).HasComment("อัตราการหัก");

                entity.Property(e => e.WhttypeCode).HasComment("รหัสประเภทการหัก");
            });

            modelBuilder.Entity<WorkstationDrive>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WorkstationCode, e.DriveCode });
            });

            modelBuilder.Entity<WorkstationDriver>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.WorkstationCode, e.DriverName });
            });

            modelBuilder.Entity<WorkstationHardware>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.HardwareCode, e.WorkstationCode });
            });

            modelBuilder.Entity<WorkstationSoftware>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.SoftwareCode, e.WorkstationCode });
            });

            modelBuilder.Entity<XrayRequest>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.XrayRequestNo, e.Vn, e.SeqId });

                entity.Property(e => e.OrgDestinationCode).HasComment("สาขาที่ส่ง X-Ray");

                entity.Property(e => e.PositionCode).HasComment("รหัสตำแหน่งที่เอ็กเรย์");

                entity.Property(e => e.PositionName).HasComment("ชื่อตำแหน่งที่เอ็กเรย์");

                entity.Property(e => e.XrayImplementCode).HasComment("ผู้ถ่ายภาพเอ็กซ์เรย์");
            });

            modelBuilder.Entity<XrayRequestItem>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.XrayRequestNo, e.SeqId });

                entity.Property(e => e.Classified)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<XrayResult>(entity =>
            {
                entity.HasKey(e => new { e.CreateByOrgCode, e.XrayRequestNo, e.SeqId });

                entity.Property(e => e.CreateByOrgCode).HasComment("รหัสองค์กร");

                entity.Property(e => e.XrayRequestNo).HasComment("เลขที่ Request Number");

                entity.Property(e => e.SeqId).HasComment("ลำดับรายการ");

                entity.Property(e => e.ClinicalComment).HasComment("ความเห็นทางคลินิก");

                entity.Property(e => e.CreateByCode).HasComment("รหัสผู้ที่สร้างข้อมูล");

                entity.Property(e => e.CreateDate).HasComment("วันที่สร้างข้อมูล");

                entity.Property(e => e.DefaultClinicalComment).HasComment("ค่าจาก PACS ");

                entity.Property(e => e.DefaultResult).HasComment("ผลจากเครื่องเอ็กซ์เรย์(ไม่สามารถแก้ไขได้)");

                entity.Property(e => e.ImageDocId).HasComment("ใช้อ้างอิงในการเก็บรูป (DocItem.DocID)");

                entity.Property(e => e.IsAbnormal).HasComment("0 = ผลปกติ , 1 = ผิดปกติ");

                entity.Property(e => e.IsRead).HasComment("สถานะการอ่านผล 1 ยังไม่อ่าน 2 อ่านแล้ว");

                entity.Property(e => e.IsRepeated).HasComment("1 = ไม่ใช่รายการซ้ำ , 2 = รายการที่สั่งทำซ้ำ");

                entity.Property(e => e.IsStat).HasComment("ระบุสถานะรายการโดย 0 = ไม่เร่งด่วน , 1 = เร่งด่วน");

                entity.Property(e => e.KV).HasComment("kV");

                entity.Property(e => e.MA).HasComment("mA");

                entity.Property(e => e.ModByCode).HasComment("รหัสผู้แก้ไข");

                entity.Property(e => e.ModDate).HasComment("วันที่แก้ไข");

                entity.Property(e => e.PositionCode).HasComment("รหัสตำแหน่งที่เอ็กเรย์");

                entity.Property(e => e.PositionName).HasComment("ชื่อตำแหน่งที่เอ็กเรย์");

                entity.Property(e => e.PositionViewCode).HasComment("รหัสท่าที่เอ็กเรย์ เช่น ท่านอนหงาย ท่านอนคว่ำ");

                entity.Property(e => e.PositionViewName).HasComment("ชื่อท่าที่เอ็กเรย์ เช่น ท่านอนหงาย ท่านอนคว่ำ");

                entity.Property(e => e.ReadByCode).HasComment("รหัสผู้ที่เปิดอ่านผลครั้งแรก");

                entity.Property(e => e.ReasonResend).HasComment("เหตุผลการส่งเอ็กซ์เรย์ใหม่");

                entity.Property(e => e.RefDoc).HasComment("เลขที่เอกสารอ้างอิงจากการอ่านผลฟิล์นอกร.พ.");

                entity.Property(e => e.ReportByCode).HasComment("รหัสผู้ลงผล");

                entity.Property(e => e.ReportDate).HasComment("วันที่ลงผล");

                entity.Property(e => e.RequestByCode).HasComment("รหัสผู้สั่งรายการ");

                entity.Property(e => e.RequestDate).HasComment("วันที่สั่งรายการ");

                entity.Property(e => e.Result).HasComment("ผล");

                entity.Property(e => e.ResultLevel2Name).HasComment("ชื่อผลลำดับ2");

                entity.Property(e => e.StatusWorkId).HasComment("รหัสสถานะรายการ 1 รอคิวอยู่ 2 กำลังทำ 3 ทำเสร็จแล้ว");

                entity.Property(e => e.Thickness).HasComment("ความหนา");

                entity.Property(e => e.Vn).HasComment("เลขที่ Visit Number");

                entity.Property(e => e.XrayOrder).HasComment("คำสั่งเอ็กซ์เรย์");

                entity.Property(e => e.XrayResultCode).HasComment("รหัสผล /สำหรับทำรายงานสถิติ");

                entity.Property(e => e.XrayResultName).HasComment("ชื่อผล Xray สามารถแก้ไขได้");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
