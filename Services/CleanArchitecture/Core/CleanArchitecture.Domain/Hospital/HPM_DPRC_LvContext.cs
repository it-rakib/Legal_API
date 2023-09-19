using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Merchandising.Domain.Hospital
{
    public partial class HPM_DPRC_LvContext : DbContext
    {
        public HPM_DPRC_LvContext()
        {
        }

        public HPM_DPRC_LvContext(DbContextOptions<HPM_DPRC_LvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccReceiptPayment> AccReceiptPayments { get; set; }
        public virtual DbSet<Adddistrict> Adddistricts { get; set; }
        public virtual DbSet<Adddivision> Adddivisions { get; set; }
        public virtual DbSet<Addunion> Addunions { get; set; }
        public virtual DbSet<Addupazila> Addupazilas { get; set; }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<AdmissionExt> AdmissionExts { get; set; }
        public virtual DbSet<AltPatient> AltPatients { get; set; }
        public virtual DbSet<AltPatientTransaction> AltPatientTransactions { get; set; }
        public virtual DbSet<AltPatientTransactionDoctor> AltPatientTransactionDoctors { get; set; }
        public virtual DbSet<AppCurrentValue> AppCurrentValues { get; set; }
        public virtual DbSet<AppReport> AppReports { get; set; }
        public virtual DbSet<AppReportSetting> AppReportSettings { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<AreaInfo> AreaInfos { get; set; }
        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
        public virtual DbSet<AssetIssue> AssetIssues { get; set; }
        public virtual DbSet<AssetIssueSubWeb> AssetIssueSubWebs { get; set; }
        public virtual DbSet<AssetIssueWeb> AssetIssueWebs { get; set; }
        public virtual DbSet<AssetReceived> AssetReceiveds { get; set; }
        public virtual DbSet<AssetReceivedSubWeb> AssetReceivedSubWebs { get; set; }
        public virtual DbSet<AssetReceivedWeb> AssetReceivedWebs { get; set; }
        public virtual DbSet<AssetService> AssetServices { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttnImport> AttnImports { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankBook> BankBooks { get; set; }
        public virtual DbSet<BedCabin> BedCabins { get; set; }
        public virtual DbSet<BedCabinTransection> BedCabinTransections { get; set; }
        public virtual DbSet<BedCategory> BedCategories { get; set; }
        public virtual DbSet<BedCategorySlNo> BedCategorySlNos { get; set; }
        public virtual DbSet<CanteenCategory> CanteenCategories { get; set; }
        public virtual DbSet<CanteenChallan> CanteenChallans { get; set; }
        public virtual DbSet<CanteenChallanSub> CanteenChallanSubs { get; set; }
        public virtual DbSet<CanteenCustomerType> CanteenCustomerTypes { get; set; }
        public virtual DbSet<CanteenDebtor> CanteenDebtors { get; set; }
        public virtual DbSet<CanteenDebtorLedger> CanteenDebtorLedgers { get; set; }
        public virtual DbSet<CanteenKitchen> CanteenKitchens { get; set; }
        public virtual DbSet<CanteenKitchenSub> CanteenKitchenSubs { get; set; }
        public virtual DbSet<CanteenProduct> CanteenProducts { get; set; }
        public virtual DbSet<CanteenRecipe> CanteenRecipes { get; set; }
        public virtual DbSet<CanteenRecipeDetail> CanteenRecipeDetails { get; set; }
        public virtual DbSet<CanteenSale> CanteenSales { get; set; }
        public virtual DbSet<CanteenSalesReturn> CanteenSalesReturns { get; set; }
        public virtual DbSet<CanteenSalesSub> CanteenSalesSubs { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardTransaction> CardTransactions { get; set; }
        public virtual DbSet<CashBook> CashBooks { get; set; }
        public virtual DbSet<CashMemo> CashMemos { get; set; }
        public virtual DbSet<CashMemoDinvestigation> CashMemoDinvestigations { get; set; }
        public virtual DbSet<CashMemoInvestRefComm> CashMemoInvestRefComms { get; set; }
        public virtual DbSet<CashMemoInvestigation> CashMemoInvestigations { get; set; }
        public virtual DbSet<CashMemoOt> CashMemoOts { get; set; }
        public virtual DbSet<CashMemoReturn> CashMemoReturns { get; set; }
        public virtual DbSet<CashMemoSub> CashMemoSubs { get; set; }
        public virtual DbSet<CashMemoSubDinvestigation> CashMemoSubDinvestigations { get; set; }
        public virtual DbSet<CashMemoSubInvestigation> CashMemoSubInvestigations { get; set; }
        public virtual DbSet<CashMemoSubOt> CashMemoSubOts { get; set; }
        public virtual DbSet<CashMemoSubReturn> CashMemoSubReturns { get; set; }
        public virtual DbSet<CentralCashCollection> CentralCashCollections { get; set; }
        public virtual DbSet<CentralCashCollectionHead> CentralCashCollectionHeads { get; set; }
        public virtual DbSet<CentralCashCollectionModule> CentralCashCollectionModules { get; set; }
        public virtual DbSet<Checkinouttime> Checkinouttimes { get; set; }
        public virtual DbSet<ChequeRegistration> ChequeRegistrations { get; set; }
        public virtual DbSet<ComboValue> ComboValues { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }
        public virtual DbSet<CorporateClient> CorporateClients { get; set; }
        public virtual DbSet<CorporateClientDiscount> CorporateClientDiscounts { get; set; }
        public virtual DbSet<CovidreportCategory> CovidreportCategories { get; set; }
        public virtual DbSet<DeathCertificate> DeathCertificates { get; set; }
        public virtual DbSet<DefaultPrescriptionTemplate> DefaultPrescriptionTemplates { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentCategory> DepartmentCategories { get; set; }
        public virtual DbSet<DischargeInfo> DischargeInfos { get; set; }
        public virtual DbSet<DischargeInfoMedicine> DischargeInfoMedicines { get; set; }
        public virtual DbSet<DischargeInfoTemplate> DischargeInfoTemplates { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<DoctorAdvice> DoctorAdvices { get; set; }
        public virtual DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual DbSet<DoctorRickSchedule> DoctorRickSchedules { get; set; }
        public virtual DbSet<DoctorsProfile> DoctorsProfiles { get; set; }
        public virtual DbSet<DoctorsReferalPercentageDetail> DoctorsReferalPercentageDetails { get; set; }
        public virtual DbSet<DoseRoute> DoseRoutes { get; set; }
        public virtual DbSet<DoseShedule> DoseShedules { get; set; }
        public virtual DbSet<DoseTime> DoseTimes { get; set; }
        public virtual DbSet<DoseTime1> DoseTimes1 { get; set; }
        public virtual DbSet<DuePayment> DuePayments { get; set; }
        public virtual DbSet<DuePaymentPharmacy> DuePaymentPharmacies { get; set; }
        public virtual DbSet<EmployeeHoliday> EmployeeHolidays { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public virtual DbSet<EmployeeLeaveV1> EmployeeLeaveV1s { get; set; }
        public virtual DbSet<EmployeeSalaryStracture> EmployeeSalaryStractures { get; set; }
        public virtual DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public virtual DbSet<Financialyear> Financialyears { get; set; }
        public virtual DbSet<GeneralLedger> GeneralLedgers { get; set; }
        public virtual DbSet<GenericGroup> GenericGroups { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupPermission> GroupPermissions { get; set; }
        public virtual DbSet<HaematologyLabel> HaematologyLabels { get; set; }
        public virtual DbSet<HeadAna> HeadAnas { get; set; }
        public virtual DbSet<HeadAntiDsdn> HeadAntiDsdns { get; set; }
        public virtual DbSet<HeadBiochemistry> HeadBiochemistries { get; set; }
        public virtual DbSet<HeadCytopathology> HeadCytopathologies { get; set; }
        public virtual DbSet<HeadHaematology> HeadHaematologies { get; set; }
        public virtual DbSet<HeadHaematologyAll> HeadHaematologyAlls { get; set; }
        public virtual DbSet<HeadHaematologySub> HeadHaematologySubs { get; set; }
        public virtual DbSet<HeadImmunology> HeadImmunologies { get; set; }
        public virtual DbSet<HeadMicrobiology> HeadMicrobiologies { get; set; }
        public virtual DbSet<HeadPleuralFluid> HeadPleuralFluids { get; set; }
        public virtual DbSet<HeadProthomBin> HeadProthomBins { get; set; }
        public virtual DbSet<HeadSemenAnalysis> HeadSemenAnalyses { get; set; }
        public virtual DbSet<HeadSerological> HeadSerologicals { get; set; }
        public virtual DbSet<HeadStool> HeadStools { get; set; }
        public virtual DbSet<HeadUrine> HeadUrines { get; set; }
        public virtual DbSet<Housekeepissue> Housekeepissues { get; set; }
        public virtual DbSet<Housekeepissuedetail> Housekeepissuedetails { get; set; }
        public virtual DbSet<HouskeepReceive> HouskeepReceives { get; set; }
        public virtual DbSet<HouskeepReceiveSub> HouskeepReceiveSubs { get; set; }
        public virtual DbSet<HrDepartment> HrDepartments { get; set; }
        public virtual DbSet<HrDesignation> HrDesignations { get; set; }
        public virtual DbSet<HrHoliday> HrHolidays { get; set; }
        public virtual DbSet<ImagingModule> ImagingModules { get; set; }
        public virtual DbSet<ImagingTemplate> ImagingTemplates { get; set; }
        public virtual DbSet<ImmunologicalTest> ImmunologicalTests { get; set; }
        public virtual DbSet<IncomeGroup> IncomeGroups { get; set; }
        public virtual DbSet<InvestigationModule> InvestigationModules { get; set; }
        public virtual DbSet<InvestigationPackage> InvestigationPackages { get; set; }
        public virtual DbSet<InvestigationReportHeader> InvestigationReportHeaders { get; set; }
        public virtual DbSet<InvestigationReturn> InvestigationReturns { get; set; }
        public virtual DbSet<InvestigationSampleCollection> InvestigationSampleCollections { get; set; }
        public virtual DbSet<InvestigationSubPackage> InvestigationSubPackages { get; set; }
        public virtual DbSet<IpdDepartment> IpdDepartments { get; set; }
        public virtual DbSet<IpdDiscount> IpdDiscounts { get; set; }
        public virtual DbSet<IpdReferral> IpdReferrals { get; set; }
        public virtual DbSet<IssueDepartment> IssueDepartments { get; set; }
        public virtual DbSet<JvBook> JvBooks { get; set; }
        public virtual DbSet<LabCheckedBy> LabCheckedBies { get; set; }
        public virtual DbSet<LabConsultTran> LabConsultTrans { get; set; }
        public virtual DbSet<LabConsultantModule> LabConsultantModules { get; set; }
        public virtual DbSet<LabConsultent> LabConsultents { get; set; }
        public virtual DbSet<LabImage> LabImages { get; set; }
        public virtual DbSet<LabInventory> LabInventories { get; set; }
        public virtual DbSet<LabInventoryBalance> LabInventoryBalances { get; set; }
        public virtual DbSet<LabInventoryIssue> LabInventoryIssues { get; set; }
        public virtual DbSet<LabInventoryIssueSub> LabInventoryIssueSubs { get; set; }
        public virtual DbSet<LabInventorySub> LabInventorySubs { get; set; }
        public virtual DbSet<LastLogin> LastLogins { get; set; }
        public virtual DbSet<LeaveAvail> LeaveAvails { get; set; }
        public virtual DbSet<LeaveAvailType> LeaveAvailTypes { get; set; }
        public virtual DbSet<LeaveAvailV1> LeaveAvailV1s { get; set; }
        public virtual DbSet<MedicalCertificate> MedicalCertificates { get; set; }
        public virtual DbSet<MedicineAdjustChallan> MedicineAdjustChallans { get; set; }
        public virtual DbSet<MedicineAdjustChallanSub> MedicineAdjustChallanSubs { get; set; }
        public virtual DbSet<MedicineCustomer> MedicineCustomers { get; set; }
        public virtual DbSet<MedicineCustomerBankPayment> MedicineCustomerBankPayments { get; set; }
        public virtual DbSet<MedicineCustomerLedger> MedicineCustomerLedgers { get; set; }
        public virtual DbSet<MedicineCustomerPayment> MedicineCustomerPayments { get; set; }
        public virtual DbSet<MedicineDepartment> MedicineDepartments { get; set; }
        public virtual DbSet<MedicineIndent> MedicineIndents { get; set; }
        public virtual DbSet<MedicineIndentSub> MedicineIndentSubs { get; set; }
        public virtual DbSet<MedicineIssue> MedicineIssues { get; set; }
        public virtual DbSet<MedicineIssueSub> MedicineIssueSubs { get; set; }
        public virtual DbSet<MedicinePurchaseRequisition> MedicinePurchaseRequisitions { get; set; }
        public virtual DbSet<MedicinePurchaseRequisitionSub> MedicinePurchaseRequisitionSubs { get; set; }
        public virtual DbSet<MedicinePurchaseRequisitionSupplier> MedicinePurchaseRequisitionSuppliers { get; set; }
        public virtual DbSet<MedicinePurchaseRequisitionSupplierSub> MedicinePurchaseRequisitionSupplierSubs { get; set; }
        public virtual DbSet<MedicineReceivingChallan> MedicineReceivingChallans { get; set; }
        public virtual DbSet<MedicineReceivingChallanSub> MedicineReceivingChallanSubs { get; set; }
        public virtual DbSet<MedicineRequisition> MedicineRequisitions { get; set; }
        public virtual DbSet<MedicineRequisitionSub> MedicineRequisitionSubs { get; set; }
        public virtual DbSet<MedicineReturn> MedicineReturns { get; set; }
        public virtual DbSet<MedicineReturnSub> MedicineReturnSubs { get; set; }
        public virtual DbSet<MedicineStore> MedicineStores { get; set; }
        public virtual DbSet<MedicineStoreBalance> MedicineStoreBalances { get; set; }
        public virtual DbSet<MedicineType> MedicineTypes { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<MoneyReceipt> MoneyReceipts { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<OpdOtReg> OpdOtRegs { get; set; }
        public virtual DbSet<OpdOtRegCollection> OpdOtRegCollections { get; set; }
        public virtual DbSet<OpdOtRegistration> OpdOtRegistrations { get; set; }
        public virtual DbSet<OpdTicket> OpdTickets { get; set; }
        public virtual DbSet<OpeningBalance> OpeningBalances { get; set; }
        public virtual DbSet<OperationAsst> OperationAssts { get; set; }
        public virtual DbSet<OperationImage> OperationImages { get; set; }
        public virtual DbSet<OperationList> OperationLists { get; set; }
        public virtual DbSet<OperationNote> OperationNotes { get; set; }
        public virtual DbSet<OperationProcedure> OperationProcedures { get; set; }
        public virtual DbSet<OperationVideo> OperationVideos { get; set; }
        public virtual DbSet<OrganismIsolatedValue> OrganismIsolatedValues { get; set; }
        public virtual DbSet<PackageRecord> PackageRecords { get; set; }
        public virtual DbSet<ParticularsBalanceHead> ParticularsBalanceHeads { get; set; }
        public virtual DbSet<ParticularsHead> ParticularsHeads { get; set; }
        public virtual DbSet<ParticularsMasterHead> ParticularsMasterHeads { get; set; }
        public virtual DbSet<ParticularsSubHead> ParticularsSubHeads { get; set; }
        public virtual DbSet<PathologyGroupHead> PathologyGroupHeads { get; set; }
        public virtual DbSet<PathologyReportHead> PathologyReportHeads { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAna> PatientAnas { get; set; }
        public virtual DbSet<PatientAntiD> PatientAntiDs { get; set; }
        public virtual DbSet<PatientAptt> PatientAptts { get; set; }
        public virtual DbSet<PatientBhCg> PatientBhCgs { get; set; }
        public virtual DbSet<PatientBiochemistry> PatientBiochemistries { get; set; }
        public virtual DbSet<PatientBloodCrossMatching> PatientBloodCrossMatchings { get; set; }
        public virtual DbSet<PatientCovid> PatientCovids { get; set; }
        public virtual DbSet<PatientCytopathology> PatientCytopathologies { get; set; }
        public virtual DbSet<PatientDischarge1> PatientDischarge1s { get; set; }
        public virtual DbSet<PatientHaematology> PatientHaematologies { get; set; }
        public virtual DbSet<PatientHaemotologyDetail> PatientHaemotologyDetails { get; set; }
        public virtual DbSet<PatientImaging> PatientImagings { get; set; }
        public virtual DbSet<PatientImmunology> PatientImmunologies { get; set; }
        public virtual DbSet<PatientImmunulogyDetail> PatientImmunulogyDetails { get; set; }
        public virtual DbSet<PatientLab> PatientLabs { get; set; }
        public virtual DbSet<PatientMicrobiology> PatientMicrobiologies { get; set; }
        public virtual DbSet<PatientMicrobiologyDetail> PatientMicrobiologyDetails { get; set; }
        public virtual DbSet<PatientMicrobiologyMicroscopy> PatientMicrobiologyMicroscopies { get; set; }
        public virtual DbSet<PatientMt> PatientMts { get; set; }
        public virtual DbSet<PatientObservation> PatientObservations { get; set; }
        public virtual DbSet<PatientObservationMedicine> PatientObservationMedicines { get; set; }
        public virtual DbSet<PatientPackageTransaction> PatientPackageTransactions { get; set; }
        public virtual DbSet<PatientPathologyResult> PatientPathologyResults { get; set; }
        public virtual DbSet<PatientPayment> PatientPayments { get; set; }
        public virtual DbSet<PatientPleuralFluid> PatientPleuralFluids { get; set; }
        public virtual DbSet<PatientProthomBin> PatientProthomBins { get; set; }
        public virtual DbSet<PatientProthomBinNew> PatientProthomBinNews { get; set; }
        public virtual DbSet<PatientRelation> PatientRelations { get; set; }
        public virtual DbSet<PatientSemenAnalysis> PatientSemenAnalyses { get; set; }
        public virtual DbSet<PatientSemenAnalysisDefault> PatientSemenAnalysisDefaults { get; set; }
        public virtual DbSet<PatientSemenAnalysisV1> PatientSemenAnalysisV1s { get; set; }
        public virtual DbSet<PatientSerological> PatientSerologicals { get; set; }
        public virtual DbSet<PatientSerumElectrolyte> PatientSerumElectrolytes { get; set; }
        public virtual DbSet<PatientStool> PatientStools { get; set; }
        public virtual DbSet<PatientStoolV1> PatientStoolV1s { get; set; }
        public virtual DbSet<PatientTransaction> PatientTransactions { get; set; }
        public virtual DbSet<PatientTransactionDoctor> PatientTransactionDoctors { get; set; }
        public virtual DbSet<PatientTransactionDoctorBalance> PatientTransactionDoctorBalances { get; set; }
        public virtual DbSet<PatientTuberculin> PatientTuberculins { get; set; }
        public virtual DbSet<PatientUrine> PatientUrines { get; set; }
        public virtual DbSet<PatientUrineV1> PatientUrineV1s { get; set; }
        public virtual DbSet<PatientXrayImage> PatientXrayImages { get; set; }
        public virtual DbSet<PaymentsDetail> PaymentsDetails { get; set; }
        public virtual DbSet<PharmacyDuePayment> PharmacyDuePayments { get; set; }
        public virtual DbSet<PharmacyDuePaymentTemp> PharmacyDuePaymentTemps { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionInvestigation> PrescriptionInvestigations { get; set; }
        public virtual DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        public virtual DbSet<PrescriptionPhyosiotherapy> PrescriptionPhyosiotherapies { get; set; }
        public virtual DbSet<PrescriptionRecord> PrescriptionRecords { get; set; }
        public virtual DbSet<PrintHistory> PrintHistories { get; set; }
        public virtual DbSet<PromotionOfficerInfo> PromotionOfficerInfos { get; set; }
        public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public virtual DbSet<PurchaseRequestDetail> PurchaseRequestDetails { get; set; }
        public virtual DbSet<Rack> Racks { get; set; }
        public virtual DbSet<ReferralCategory> ReferralCategories { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<ReportHead> ReportHeads { get; set; }
        public virtual DbSet<ReportMarginSetting> ReportMarginSettings { get; set; }
        public virtual DbSet<SalaryDisbursement> SalaryDisbursements { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<ServiceCategorySub> ServiceCategorySubs { get; set; }
        public virtual DbSet<ServiceCategorySubDinvestigation> ServiceCategorySubDinvestigations { get; set; }
        public virtual DbSet<ServiceGroup> ServiceGroups { get; set; }
        public virtual DbSet<SettingCmiSm> SettingCmiSms { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<Smsbalance> Smsbalances { get; set; }
        public virtual DbSet<Smslog> Smslogs { get; set; }
        public virtual DbSet<Speciman> Specimen { get; set; }
        public virtual DbSet<StoreChallan> StoreChallans { get; set; }
        public virtual DbSet<StoreChallanSub> StoreChallanSubs { get; set; }
        public virtual DbSet<StoreIssue> StoreIssues { get; set; }
        public virtual DbSet<StoreIssueSub> StoreIssueSubs { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }
        public virtual DbSet<StoreProductCategory> StoreProductCategories { get; set; }
        public virtual DbSet<StoreProductNew> StoreProductNews { get; set; }
        public virtual DbSet<StoreRequest> StoreRequests { get; set; }
        public virtual DbSet<StoreRequestDetail> StoreRequestDetails { get; set; }
        public virtual DbSet<StoreReturn> StoreReturns { get; set; }
        public virtual DbSet<StoreReturnSub> StoreReturnSubs { get; set; }
        public virtual DbSet<StoreReturnSupplier> StoreReturnSuppliers { get; set; }
        public virtual DbSet<StoreReturnSupplierSub> StoreReturnSupplierSubs { get; set; }
        public virtual DbSet<StoreSupplierPayment> StoreSupplierPayments { get; set; }
        public virtual DbSet<SubLedger> SubLedgers { get; set; }
        public virtual DbSet<SupplierBankPayment> SupplierBankPayments { get; set; }
        public virtual DbSet<SupplierLedger> SupplierLedgers { get; set; }
        public virtual DbSet<SupplierPayment> SupplierPayments { get; set; }
        public virtual DbSet<SupplierPharmacy> SupplierPharmacies { get; set; }
        public virtual DbSet<SupplierStore> SupplierStores { get; set; }
        public virtual DbSet<SystemSubHead> SystemSubHeads { get; set; }
        public virtual DbSet<TblAddTime> TblAddTimes { get; set; }
        public virtual DbSet<TblCc> TblCcs { get; set; }
        public virtual DbSet<TblDiagnosis> TblDiagnoses { get; set; }
        public virtual DbSet<TblHo> TblHos { get; set; }
        public virtual DbSet<TblOccupation> TblOccupations { get; set; }
        public virtual DbSet<TblOe> TblOes { get; set; }
        public virtual DbSet<TblPaymentMode> TblPaymentModes { get; set; }
        public virtual DbSet<TblRoleDetail> TblRoleDetails { get; set; }
        public virtual DbSet<TblRoleMaster> TblRoleMasters { get; set; }
        public virtual DbSet<TblTaskMaster> TblTaskMasters { get; set; }
        public virtual DbSet<TblUnit> TblUnits { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblYear> TblYears { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<TempService> TempServices { get; set; }
        public virtual DbSet<TicketType> TicketTypes { get; set; }
        public virtual DbSet<TmpAttnTable> TmpAttnTables { get; set; }
        public virtual DbSet<TmpBuyRate> TmpBuyRates { get; set; }
        public virtual DbSet<TmpBuyRateZ> TmpBuyRateZs { get; set; }
        public virtual DbSet<TmpEmpSal> TmpEmpSals { get; set; }
        public virtual DbSet<TmpIssueRate> TmpIssueRates { get; set; }
        public virtual DbSet<TmpIssueRateZ> TmpIssueRateZs { get; set; }
        public virtual DbSet<TmpNumber> TmpNumbers { get; set; }
        public virtual DbSet<Tmptrial> Tmptrials { get; set; }
        public virtual DbSet<TreatmentSheetMedicine> TreatmentSheetMedicines { get; set; }
        public virtual DbSet<TreatmentSheetMedicineSub> TreatmentSheetMedicineSubs { get; set; }
        public virtual DbSet<TreatmentSheetMedicineUsed> TreatmentSheetMedicineUseds { get; set; }
        public virtual DbSet<Tube> Tubes { get; set; }
        public virtual DbSet<Upzilla> Upzillas { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<VServiceCategory> VServiceCategories { get; set; }
        public virtual DbSet<Village> Villages { get; set; }
        public virtual DbSet<VisitingTime> VisitingTimes { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }
        public virtual DbSet<WorkShiftEmployee> WorkShiftEmployees { get; set; }
        public virtual DbSet<WorkingShift> WorkingShifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=202.22.203.92;Initial Catalog=HPM_DPRC_Lv; User Id=sa; password=w23eW@#E;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccReceiptPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_ReceiptPayment");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PayBank).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReBank).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReBankRemark).HasMaxLength(250);

                entity.Property(e => e.ReCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Adddistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adddistricts");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lat)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("lat");

                entity.Property(e => e.Lon)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("lon");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Adddivision>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adddivisions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Addunion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("addunions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpazillaId).HasColumnName("upazilla_id");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Addupazila>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("addupazilas");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Admission>(entity =>
            {
                entity.ToTable("Admission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Admission_Date");

                entity.Property(e => e.AdmissionFee)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Admission_Fee");

                entity.Property(e => e.AdmittedBy).HasColumnName("Admitted_By");

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_year");

                entity.Property(e => e.Ambulance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BarCodeImage).HasColumnType("image");

                entity.Property(e => e.BedAdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Bed_Admission_Date");

                entity.Property(e => e.BedCabinCatId).HasColumnName("Bed_Cabin_Cat_ID");

                entity.Property(e => e.BedCabinId).HasColumnName("Bed_Cabin_ID");

                entity.Property(e => e.BillGeneratedBy).HasColumnName("Bill_Generated_By");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.Due)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsAdmitted).HasColumnName("Is_Admitted");

                entity.Property(e => e.IsPackage)
                    .HasColumnName("Is_Package")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReferred).HasColumnName("Is_Referred");

                entity.Property(e => e.MpoId).HasColumnName("MPO_ID");

                entity.Property(e => e.OpdPackage).HasColumnName("OPD_Package");

                entity.Property(e => e.OtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OT_Date");

                entity.Property(e => e.Outcome).HasMaxLength(50);

                entity.Property(e => e.Paid)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_Category");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientReceivedBy).HasColumnName("Patient_Received_By");

                entity.Property(e => e.PatientReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Patient_Received_Date");

                entity.Property(e => e.ReferredBy).HasColumnName("Referred_By");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Release_Date");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AdmissionExt>(entity =>
            {
                entity.ToTable("Admission_Ext");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Food).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Charge");
            });

            modelBuilder.Entity<AltPatient>(entity =>
            {
                entity.ToTable("Alt_Patients");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Admission_Date");

                entity.Property(e => e.Advance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.MobileAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Mobile_Amount");

                entity.Property(e => e.MobileBankingName)
                    .HasMaxLength(50)
                    .HasColumnName("Mobile_Banking_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Net_Amount");

                entity.Property(e => e.NoOfPrint).HasColumnName("No_of_Print");

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatientCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_Category");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Release_Date");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AltPatientTransaction>(entity =>
            {
                entity.ToTable("Alt_Patient_Transaction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.ServiceRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Rate");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<AltPatientTransactionDoctor>(entity =>
            {
                entity.ToTable("Alt_Patient_Transaction_Doctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AltPatientTransactionId).HasColumnName("Alt_Patient_Transaction_ID");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AppCurrentValue>(entity =>
            {
                entity.ToTable("App_Current_Values");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegNoValue).HasColumnName("RegNo_Value");
            });

            modelBuilder.Entity<AppReport>(entity =>
            {
                entity.ToTable("App_Reports");

                entity.HasIndex(e => e.Identifire, "UK_App_Reports")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Identifire)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AppReportSetting>(entity =>
            {
                entity.ToTable("App_Report_Settings");

                entity.HasIndex(e => new { e.ReportId, e.Settings }, "UK_App_Settings_Report")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.Settings).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.AppReportSettings)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_App_Settings_Report_App_Reports");
            });

            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.ToTable("App_Settings");

                entity.HasIndex(e => e.Name, "UK_App_Settings")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AreaInfo>(entity =>
            {
                entity.ToTable("Area_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaCode).HasColumnName("Area_Code");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.ToTable("Asset_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AssetIssue>(entity =>
            {
                entity.ToTable("Asset_Issue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetId).HasColumnName("Asset_ID");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.FloorNo)
                    .HasMaxLength(50)
                    .HasColumnName("Floor_No");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.IssueDepartment).HasColumnName("Issue_Department");

                entity.Property(e => e.IssueNo).HasMaxLength(10);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.TagNo).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AssetIssueSubWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Issue_Sub_Web");

                entity.Property(e => e.AssetId)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Asset_ID");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CostPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IssueNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AssetIssueWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Issue_Web");

                entity.Property(e => e.FloorNo)
                    .HasMaxLength(50)
                    .HasColumnName("Floor_No");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDepartment).HasColumnName("Issue_Department");

                entity.Property(e => e.IssueNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TagNo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AssetReceived>(entity =>
            {
                entity.ToTable("Asset_Received");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetId).HasColumnName("Asset_ID");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.BillNo).HasMaxLength(50);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("date")
                    .HasColumnName("Exp_Date");

                entity.Property(e => e.GrnNo).HasColumnName("GRN_NO");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_No");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .HasColumnName("PONo");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VatRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AssetReceivedSubWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Received_Sub_Web");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Expire).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VatRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AssetReceivedWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Asset_Received_Web");

                entity.Property(e => e.ChallanDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_No");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.PoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PO_Date");

                entity.Property(e => e.PoNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PO_No");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<AssetService>(entity =>
            {
                entity.ToTable("Asset_Service");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetId)
                    .HasMaxLength(50)
                    .HasColumnName("Asset_ID");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CostAccumulate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cost_Accumulate");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepAccumulate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Dep_Accumulate");

                entity.Property(e => e.DepRate).HasColumnName("Dep_Rate");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttendanceStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Attendance_Status");

                entity.Property(e => e.AttnDate)
                    .HasColumnType("date")
                    .HasColumnName("Attn_Date");

                entity.Property(e => e.ImportId).HasColumnName("Import_ID");

                entity.Property(e => e.InTime).HasColumnName("In_Time");

                entity.Property(e => e.LateBy).HasColumnName("Late_By");

                entity.Property(e => e.OutTime).HasColumnName("Out_Time");

                entity.Property(e => e.ShiftInTime).HasColumnName("Shift_In_Time");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("User_ID");

                entity.Property(e => e.WorkDuration).HasColumnName("Work_Duration");
            });

            modelBuilder.Entity<AttnImport>(entity =>
            {
                entity.ToTable("Attn_Import");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttnDate)
                    .HasColumnType("date")
                    .HasColumnName("Attn_Date");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OBalance)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("O_Balance");
            });

            modelBuilder.Entity<BankBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bank_Book");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<BedCabin>(entity =>
            {
                entity.ToTable("Bed_Cabin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.IsAllocated).HasColumnName("Is_Allocated");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BedCabinTransection>(entity =>
            {
                entity.ToTable("Bed_Cabin_Transection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BedCabinId).HasColumnName("Bed_Cabin_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientTransactionId).HasColumnName("Patient_Transaction_ID");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");
            });

            modelBuilder.Entity<BedCategory>(entity =>
            {
                entity.ToTable("Bed_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmissionFee)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Admission_Fee");

                entity.Property(e => e.BedCabinCategoryNameId).HasColumnName("Bed_Cabin_Category_NameID");

                entity.Property(e => e.Food).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IpdDeptId).HasColumnName("IPD_Dept_ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.Specification).HasMaxLength(200);
            });

            modelBuilder.Entity<BedCategorySlNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bed_Category_SlNo");

                entity.Property(e => e.BedCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Bed_Category_Name");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CanteenCategory>(entity =>
            {
                entity.ToTable("Canteen_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CanteenChallan>(entity =>
            {
                entity.ToTable("Canteen_Challan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_No");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<CanteenChallanSub>(entity =>
            {
                entity.ToTable("Canteen_Challan_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<CanteenCustomerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CanteenCustomerType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CanteenDebtor>(entity =>
            {
                entity.ToTable("Canteen_Debtor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CanteenDebtorLedger>(entity =>
            {
                entity.ToTable("Canteen_Debtor_Ledger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebtorId).HasColumnName("Debtor_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<CanteenKitchen>(entity =>
            {
                entity.ToTable("Canteen_Kitchen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.Unit).HasMaxLength(150);
            });

            modelBuilder.Entity<CanteenKitchenSub>(entity =>
            {
                entity.ToTable("Canteen_Kitchen_Sub");

                entity.Property(e => e.KitchenId).HasColumnName("kitchenId");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<CanteenProduct>(entity =>
            {
                entity.ToTable("Canteen_Products");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.IsKitchenItem).HasColumnName("IsKitchen_Item");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReorderLevel).HasColumnName("Reorder_Level");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<CanteenRecipe>(entity =>
            {
                entity.ToTable("Canteen_Recipe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Unit).HasMaxLength(150);
            });

            modelBuilder.Entity<CanteenRecipeDetail>(entity =>
            {
                entity.ToTable("Canteen_Recipe_Details");

                entity.Property(e => e.CostRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<CanteenSale>(entity =>
            {
                entity.ToTable("Canteen_Sales");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer_Type");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.NetPayable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Paid).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.TokenNo)
                    .HasMaxLength(5)
                    .HasColumnName("Token_No");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<CanteenSalesReturn>(entity =>
            {
                entity.ToTable("Canteen_Sales_Return");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CanteenSalesSub>(entity =>
            {
                entity.ToTable("Canteen_Sales_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.Charge)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("charge");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CardTransaction>(entity =>
            {
                entity.ToTable("Card_Transaction");

                entity.Property(e => e.CardNumber).HasMaxLength(50);

                entity.Property(e => e.Charge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CashBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cash_Book");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<CashMemo>(entity =>
            {
                entity.ToTable("Cash_Memo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount");

                entity.Property(e => e.BufferStore).HasColumnName("Buffer_Store");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerPointAmtRedeem).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CustomerPointEarn).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CustomerPointRedeem).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ddate)
                    .HasColumnType("datetime")
                    .HasColumnName("DDate");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IndentId).HasColumnName("IndentID");

                entity.Property(e => e.IsCredit).HasColumnName("Is_Credit");

                entity.Property(e => e.IsPackage).HasColumnName("Is_Package");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("Is_Paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileBankName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfPrint).HasColumnName("No_of_Print");

                entity.Property(e => e.Paid)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PaidBy).HasColumnName("Paid_By");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Sender).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TranxNo).HasMaxLength(5);
            });

            modelBuilder.Entity<CashMemoDinvestigation>(entity =>
            {
                entity.ToTable("Cash_Memo_DInvestigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.AgeDay).HasColumnName("age_day");

                entity.Property(e => e.AgeMonth).HasColumnName("age_month");

                entity.Property(e => e.AgeYear).HasColumnName("age_year");

                entity.Property(e => e.Bed).HasMaxLength(10);

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.Ddate)
                    .HasColumnType("date")
                    .HasColumnName("DDate");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.NoOfPrint).HasColumnName("No_of_Print");

                entity.Property(e => e.Paid).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .HasColumnName("Patient_Name");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(1)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.PoSerial).HasColumnName("PO_Serial");

                entity.Property(e => e.QdoctorId).HasColumnName("QDoctorID");

                entity.Property(e => e.RefId)
                    .HasMaxLength(16)
                    .HasColumnName("Ref_Id");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<CashMemoInvestRefComm>(entity =>
            {
                entity.HasKey(e => e.CashMemoInvRefId);

                entity.ToTable("Cash_Memo_InvestRefComm");

                entity.Property(e => e.CashMemoInvRefId).HasColumnName("Cash_Memo_InvRefID");

                entity.Property(e => e.CashMemoId).HasColumnName("Cash_Memo_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Payment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.QdoctorId).HasColumnName("QDoctor_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<CashMemoInvestigation>(entity =>
            {
                entity.ToTable("Cash_Memo_Investigation");

                entity.HasIndex(e => e.QdoctorId, "IX_Cash_Memo_Investigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.AgeDay).HasColumnName("age_day");

                entity.Property(e => e.AgeMonth).HasColumnName("age_month");

                entity.Property(e => e.AgeYear1).HasColumnName("age_year");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.BarCode).HasColumnType("image");

                entity.Property(e => e.Bed).HasMaxLength(10);

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount");

                entity.Property(e => e.CancelledBy).HasColumnName("Cancelled_By");

                entity.Property(e => e.CancelledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cancelled_Date");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.CorporateClientId).HasColumnName("Corporate_Client_ID");

                entity.Property(e => e.Ddate)
                    .HasColumnType("datetime")
                    .HasColumnName("DDate");

                entity.Property(e => e.DeliveryStatus).HasColumnName("Delivery_Status");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.InvestigationPackageId).HasColumnName("Investigation_Package_ID");

                entity.Property(e => e.IsPackage)
                    .HasColumnName("Is_Package")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileBankName).HasMaxLength(50);

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .HasColumnName("NID");

                entity.Property(e => e.NoOfPrint).HasColumnName("No_of_Print");

                entity.Property(e => e.Paid).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .HasColumnName("Patient_Name");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(1)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.PpNo)
                    .HasMaxLength(50)
                    .HasColumnName("PP_NO");

                entity.Property(e => e.QdoctorId).HasColumnName("QDoctor_ID");

                entity.Property(e => e.ReferredSs)
                    .HasMaxLength(100)
                    .HasColumnName("Referred_SS");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Report_Delivery_Date");

                entity.Property(e => e.Sender).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransNo).HasMaxLength(50);
            });

            modelBuilder.Entity<CashMemoOt>(entity =>
            {
                entity.ToTable("Cash_Memo_OT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.Bed).HasMaxLength(10);

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Ot).HasColumnName("OT");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .HasColumnName("Patient_Name");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(1)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<CashMemoReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cash_Memo_Return");

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount");

                entity.Property(e => e.BufferStore).HasColumnName("Buffer_Store");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerPointAmtRedeem).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CustomerPointEarn).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CustomerPointRedeem).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ddate)
                    .HasColumnType("datetime")
                    .HasColumnName("DDate");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IndentId).HasColumnName("IndentID");

                entity.Property(e => e.IsCredit).HasColumnName("Is_Credit");

                entity.Property(e => e.IsPackage).HasColumnName("Is_Package");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Paid).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaidBy).HasColumnName("Paid_By");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PatientType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<CashMemoSub>(entity =>
            {
                entity.ToTable("Cash_Memo_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CashMemoSubDinvestigation>(entity =>
            {
                entity.ToTable("Cash_Memo_Sub_DInvestigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("service_category_id");

                entity.Property(e => e.Slno).HasColumnName("SLNo");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vat");
            });

            modelBuilder.Entity<CashMemoSubInvestigation>(entity =>
            {
                entity.ToTable("Cash_Memo_Sub_Investigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Damount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DAmount");

                entity.Property(e => e.DisAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DisRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Drate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DRate");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReportDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Report_Delivery_Date");

                entity.Property(e => e.Slno).HasColumnName("SLNo");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TestStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<CashMemoSubOt>(entity =>
            {
                entity.ToTable("Cash_Memo_Sub_OT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<CashMemoSubReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cash_Memo_Sub_Return");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CentralCashCollection>(entity =>
            {
                entity.ToTable("Central_Cash_Collection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.ModuleFlag).HasColumnName("Module_Flag");

                entity.Property(e => e.ReferenceId).HasColumnName("Reference_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransDateCl)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date_CL");
            });

            modelBuilder.Entity<CentralCashCollectionHead>(entity =>
            {
                entity.ToTable("Central_Cash_Collection_Head");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceCategoryId).HasColumnName("service_category_id");

                entity.Property(e => e.VoucherHeadId).HasColumnName("Voucher_Head_ID");
            });

            modelBuilder.Entity<CentralCashCollectionModule>(entity =>
            {
                entity.ToTable("Central_Cash_Collection_Module");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Checkinouttime>(entity =>
            {
                entity.ToTable("Checkinouttime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.SensorId).HasColumnName("SensorID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ChequeRegistration>(entity =>
            {
                entity.ToTable("Cheque_Registration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cheque_Date");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.EnteredBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Entered_By");

                entity.Property(e => e.PayTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Pay_To");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<ComboValue>(entity =>
            {
                entity.ToTable("Combo_Values");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyInfo>(entity =>
            {
                entity.ToTable("Company_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasColumnName("logo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Others).HasMaxLength(200);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<CorporateClient>(entity =>
            {
                entity.ToTable("Corporate_Clients");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CorporateClientDiscount>(entity =>
            {
                entity.ToTable("Corporate_Client_Discount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CorporateClientId).HasColumnName("Corporate_Client_ID");

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Discount_Percentage");
            });

            modelBuilder.Entity<CovidreportCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COVIDReportCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Report).HasMaxLength(250);
            });

            modelBuilder.Entity<DeathCertificate>(entity =>
            {
                entity.ToTable("DeathCertificate");

                entity.Property(e => e.DeathCertificateId).HasColumnName("DeathCertificateID");

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ContributoryCod).HasColumnName("ContributoryCOD");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeathTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Death_Time");

                entity.Property(e => e.ImmediateCod).HasColumnName("ImmediateCOD");

                entity.Property(e => e.LegalCategorization).HasMaxLength(50);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.UnderlyingCod).HasColumnName("UnderlyingCOD");
            });

            modelBuilder.Entity<DefaultPrescriptionTemplate>(entity =>
            {
                entity.ToTable("DefaultPrescriptionTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.MedicalHistory).HasColumnName("Medical_History");

                entity.Property(e => e.Pprocedure).HasColumnName("PProcedure");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentCategoryId).HasColumnName("Department_Category_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DepartmentCategory>(entity =>
            {
                entity.ToTable("Department_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DischargeInfo>(entity =>
            {
                entity.ToTable("Discharge_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bp)
                    .HasMaxLength(50)
                    .HasColumnName("BP");

                entity.Property(e => e.Cardiovascularsystem)
                    .HasMaxLength(50)
                    .HasColumnName("cardiovascularsystem");

                entity.Property(e => e.Centralnervoussystem)
                    .HasMaxLength(50)
                    .HasColumnName("centralnervoussystem");

                entity.Property(e => e.Consultantlist).HasColumnName("consultantlist");

                entity.Property(e => e.Coursehospital).HasColumnName("coursehospital");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DischargeTime).HasColumnType("datetime");

                entity.Property(e => e.Dischargecondition).HasColumnName("dischargecondition");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Hpe).HasColumnName("HPE");

                entity.Property(e => e.Nextreporteddate).HasColumnType("datetime");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.ProcedureDate).HasColumnType("datetime");

                entity.Property(e => e.ProcedureFindings).HasColumnName("Procedure_Findings");

                entity.Property(e => e.Pulse).HasMaxLength(50);

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Respiratorysystem)
                    .HasMaxLength(50)
                    .HasColumnName("respiratorysystem");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<DischargeInfoMedicine>(entity =>
            {
                entity.ToTable("Discharge_Info_Medicine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DaysFor).HasMaxLength(50);

                entity.Property(e => e.DischargeInfoId).HasColumnName("Discharge_Info_ID");

                entity.Property(e => e.Dose).HasMaxLength(200);

                entity.Property(e => e.DozeTime)
                    .HasMaxLength(200)
                    .HasColumnName("Doze_Time");

                entity.Property(e => e.Remarks).HasMaxLength(75);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<DischargeInfoTemplate>(entity =>
            {
                entity.ToTable("Discharge_Info_Template");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TemplateName).HasMaxLength(50);
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Disease");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedById).HasColumnName("Created_By_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.District1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("District");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Division");

                entity.Property(e => e.Division1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Division");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<DoctorAdvice>(entity =>
            {
                entity.ToTable("Doctor_Advice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdvShortCode)
                    .HasMaxLength(50)
                    .HasColumnName("Adv_Short_Code");

                entity.Property(e => e.AppFor)
                    .HasMaxLength(50)
                    .HasColumnName("App_For");

                entity.Property(e => e.Details).HasMaxLength(500);
            });

            modelBuilder.Entity<DoctorAppointment>(entity =>
            {
                entity.ToTable("Doctor_Appointment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_year");

                entity.Property(e => e.AppoinmentTime)
                    .HasMaxLength(100)
                    .HasColumnName("Appoinment_Time");

                entity.Property(e => e.AppointmentFor)
                    .HasMaxLength(300)
                    .HasColumnName("Appointment_For");

                entity.Property(e => e.ApptDate)
                    .HasColumnType("date")
                    .HasColumnName("Appt_Date");

                entity.Property(e => e.ApptSlno).HasColumnName("Appt_SLNO");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_No");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsRegistrd)
                    .HasColumnName("Is_Registrd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PoSerial).HasColumnName("PO_Serial");

                entity.Property(e => e.QdoctorId).HasColumnName("QDoctor_ID");

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<DoctorRickSchedule>(entity =>
            {
                entity.ToTable("DoctorRickSchedule");

                entity.Property(e => e.DoctorRickScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("DoctorRickScheduleID");

                entity.Property(e => e.DayName).HasMaxLength(150);

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            });

            modelBuilder.Entity<DoctorsProfile>(entity =>
            {
                entity.ToTable("Doctors_Profile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasColumnName("Area_Code");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Temporary')");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BmaReg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BMA_Reg");

                entity.Property(e => e.BmdRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BMD_Rate");

                entity.Property(e => e.CdoplerRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CDopler_Rate");

                entity.Property(e => e.ColonosRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Colonos_Rate");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.CtscanRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTScan_Rate");

                entity.Property(e => e.CtscanRate10k)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTScan_Rate10k");

                entity.Property(e => e.CtscanRate7k)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTScan_Rate7k");

                entity.Property(e => e.CturoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTUro_Rate");

                entity.Property(e => e.Degree2).HasMaxLength(150);

                entity.Property(e => e.DoctorCode)
                    .HasMaxLength(50)
                    .HasColumnName("Doctor_Code");

                entity.Property(e => e.EcgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECG_Rate");

                entity.Property(e => e.Echo2dRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECHO2D_Rate");

                entity.Property(e => e.EchoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECHO_Rate");

                entity.Property(e => e.EegRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EEG_Rate");

                entity.Property(e => e.EflowRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EFlow_Rate");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndosRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Endos_Rate");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.EttRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ETT_Rate");

                entity.Property(e => e.MriRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRI_Rate");

                entity.Property(e => e.OpeningBalance)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Opening_Balance");

                entity.Property(e => e.OpgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OPG_Rate");

                entity.Property(e => e.PathoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Patho_Rate")
                    .HasDefaultValueSql("((0.50))");

                entity.Property(e => e.PoSerial).HasColumnName("PO_Serial");

                entity.Property(e => e.ReferralCategoryId).HasColumnName("Referral_Category_ID");

                entity.Property(e => e.Room).HasMaxLength(10);

                entity.Property(e => e.SmsDoctorName)
                    .HasMaxLength(100)
                    .HasColumnName("smsDoctor_Name");

                entity.Property(e => e.SpPathoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SP_Patho_Rate")
                    .HasDefaultValueSql("((0.50))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TicketTypeId).HasColumnName("Ticket_Type_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.UsgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("USG_Rate")
                    .HasDefaultValueSql("((0.25))");

                entity.Property(e => e.XrayRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("XRay_Rate")
                    .HasDefaultValueSql("((0.29))");
            });

            modelBuilder.Entity<DoctorsReferalPercentageDetail>(entity =>
            {
                entity.ToTable("Doctors_Referal_Percentage_Details");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorsId).HasColumnName("Doctors_Id");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PercentageLs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PercentageLS");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("Service_Category_Id");

                entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
            });

            modelBuilder.Entity<DoseRoute>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("Dose_Route");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.RouteName).HasMaxLength(50);
            });

            modelBuilder.Entity<DoseShedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dose_Shedule");

                entity.Property(e => e.Dozefor).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(550);
            });

            modelBuilder.Entity<DoseTime>(entity =>
            {
                entity.ToTable("Dose_Time");

                entity.Property(e => e.DoseTime1)
                    .HasMaxLength(150)
                    .HasColumnName("DoseTime");

                entity.Property(e => e.Interval).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DoseTime1>(entity =>
            {
                entity.HasKey(e => e.DoseStartTimeId);

                entity.ToTable("DoseTimes");

                entity.Property(e => e.DoseStartTimeId).HasColumnName("DoseStartTimeID");

                entity.Property(e => e.TimeName).HasMaxLength(50);
            });

            modelBuilder.Entity<DuePayment>(entity =>
            {
                entity.ToTable("Due_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.CurrentDue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Current_Due");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<DuePaymentPharmacy>(entity =>
            {
                entity.ToTable("Due_Payment_Pharmacy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Current_Due");

                entity.Property(e => e.DiscountBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_By");

                entity.Property(e => e.DueDiscount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Discount");

                entity.Property(e => e.DuePaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Due_Paid");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(10)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.HasOne(d => d.Memo)
                    .WithMany(p => p.DuePaymentPharmacies)
                    .HasForeignKey(d => d.MemoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Due_Payment_Pharmacy_Cash_Memo");
            });

            modelBuilder.Entity<EmployeeHoliday>(entity =>
            {
                entity.ToTable("Employee_Holiday");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("date")
                    .HasColumnName("Holiday_Date");

                entity.Property(e => e.HolidayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Holiday_Type");
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.ToTable("Employee_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcNo)
                    .HasMaxLength(50)
                    .HasColumnName("AC_No");

                entity.Property(e => e.Arrear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AttendanceMediaId)
                    .HasMaxLength(50)
                    .HasColumnName("Attendance_Media_ID");

                entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BloodGroup).HasMaxLength(50);

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.Deduction)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Education).HasColumnType("ntext");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.Experiance).HasColumnType("ntext");

                entity.Property(e => e.FatherName).HasMaxLength(250);

                entity.Property(e => e.FinancialBenifit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gffund)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GFFund");

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HouseRent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("House_Rent");

                entity.Property(e => e.InActiveStatus).HasMaxLength(150);

                entity.Property(e => e.InactiveDate).HasColumnType("date");

                entity.Property(e => e.IncrementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Increment_Date");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining_Date");

                entity.Property(e => e.Medical).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonthlySalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MotherName).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .HasColumnName("NID");

                entity.Property(e => e.PayScale)
                    .HasMaxLength(50)
                    .HasColumnName("Pay_Scale");

                entity.Property(e => e.PermanentDistrict).HasColumnName("Permanent_District");

                entity.Property(e => e.PermanentDivision).HasColumnName("Permanent_Division");

                entity.Property(e => e.PermanentPo).HasColumnName("Permanent_PO");

                entity.Property(e => e.PermanentPs).HasColumnName("Permanent_PS");

                entity.Property(e => e.PermanentVillage).HasColumnName("Permanent_Village");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PresentDistrict).HasColumnName("Present_District");

                entity.Property(e => e.PresentDivision).HasColumnName("Present_Division");

                entity.Property(e => e.PresentPo).HasColumnName("Present_PO");

                entity.Property(e => e.PresentPs).HasColumnName("Present_PS");

                entity.Property(e => e.PresentVillage).HasColumnName("Present_Village");

                entity.Property(e => e.Profession).HasColumnType("ntext");

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalaryAdjustment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sopuse)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Special).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TimeIn).HasColumnName("Time_In");

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");

                entity.Property(e => e.Washing).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkShiftId).HasColumnName("WorkShiftID");
            });

            modelBuilder.Entity<EmployeeLeave>(entity =>
            {
                entity.ToTable("Employee_Leave");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("Leave_Date");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Leave_Type");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<EmployeeLeaveV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee_Leave_V1");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("Leave_Date");

                entity.Property(e => e.LeaveTypeId).HasColumnName("Leave_Type_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<EmployeeSalaryStracture>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeSalaryStracture");

                entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Conveyance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Medical).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Special).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<EmployeeShift>(entity =>
            {
                entity.ToTable("Employee_Shift");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppliedFrom)
                    .HasColumnType("date")
                    .HasColumnName("Applied_From");

                entity.Property(e => e.AppliedTo)
                    .HasColumnType("date")
                    .HasColumnName("Applied_To");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Offday)
                    .HasColumnName("offday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeIn).HasColumnName("Time_In");

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.WorkingShiftId).HasColumnName("WorkingShiftID");
            });

            modelBuilder.Entity<Financialyear>(entity =>
            {
                entity.HasKey(e => e.FnYearId)
                    .HasName("PK_financialyear");

                entity.ToTable("Financialyear");

                entity.Property(e => e.FnYearId).HasColumnName("fnYearID");

                entity.Property(e => e.Financialyear1)
                    .HasMaxLength(50)
                    .HasColumnName("financialyear");

                entity.Property(e => e.FnEnddate)
                    .HasColumnType("date")
                    .HasColumnName("fn_enddate");

                entity.Property(e => e.FnStartdate)
                    .HasColumnType("date")
                    .HasColumnName("fn_startdate");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GeneralLedger>(entity =>
            {
                entity.ToTable("General_Ledger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<GenericGroup>(entity =>
            {
                entity.ToTable("Generic_Group");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GroupPermission>(entity =>
            {
                entity.ToTable("Group_Permission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");
            });

            modelBuilder.Entity<HaematologyLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HaematologyLabel");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Label1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Label2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MemoId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result2)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadAna>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Head_ANA");

                entity.Property(e => e.Cov)
                    .HasMaxLength(20)
                    .HasColumnName("COV");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(50)
                    .HasColumnName("SampleOD");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadAntiDsdn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Head_AntiDSDNS");

                entity.Property(e => e.Cov)
                    .HasMaxLength(20)
                    .HasColumnName("COV");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(50)
                    .HasColumnName("SampleOD");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadBiochemistry>(entity =>
            {
                entity.ToTable("Head_Biochemistry");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadCytopathology>(entity =>
            {
                entity.ToTable("Head_Cytopathology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<HeadHaematology>(entity =>
            {
                entity.ToTable("Head_Haematology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Iscalculate).HasColumnName("iscalculate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(500)
                    .HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<HeadHaematologyAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Head_Haematology_All");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iscalculate).HasColumnName("iscalculate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(500)
                    .HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<HeadHaematologySub>(entity =>
            {
                entity.ToTable("Head_Haematology_sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HeadImmunology>(entity =>
            {
                entity.ToTable("Head_Immunology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(350)
                    .HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadMicrobiology>(entity =>
            {
                entity.ToTable("Head_Microbiology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HeadPleuralFluid>(entity =>
            {
                entity.ToTable("Head_PleuralFluid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ReferanceRange).HasMaxLength(100);

                entity.Property(e => e.Result).HasMaxLength(100);

                entity.Property(e => e.Units).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadProthomBin>(entity =>
            {
                entity.ToTable("Head_ProthomBin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadSemenAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Head_Semen_analysis");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DefaultResult)
                    .HasMaxLength(20)
                    .HasColumnName("Default_Result");

                entity.Property(e => e.GroupHeadId).HasColumnName("Group_Head_ID");

                entity.Property(e => e.GroupSubHeadName)
                    .HasMaxLength(50)
                    .HasColumnName("Group_Sub_head_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            });

            modelBuilder.Entity<HeadSerological>(entity =>
            {
                entity.ToTable("Head_Serological");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(200)
                    .HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<HeadStool>(entity =>
            {
                entity.ToTable("Head_Stool");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.DefaultResult)
                    .HasMaxLength(20)
                    .HasColumnName("Default_Result");

                entity.Property(e => e.GroupHeadId).HasColumnName("Group_Head_ID");

                entity.Property(e => e.GroupSubHeadName)
                    .HasMaxLength(50)
                    .HasColumnName("Group_Sub_head_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            });

            modelBuilder.Entity<HeadUrine>(entity =>
            {
                entity.ToTable("Head_Urine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DefaultResult)
                    .HasMaxLength(20)
                    .HasColumnName("Default_Result");

                entity.Property(e => e.GroupHeadId).HasColumnName("Group_Head_ID");

                entity.Property(e => e.GroupSubHeadName)
                    .HasMaxLength(50)
                    .HasColumnName("Group_Sub_head_Name");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            });

            modelBuilder.Entity<Housekeepissue>(entity =>
            {
                entity.ToTable("Housekeepissue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("entered_by");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssueNo).HasMaxLength(50);

                entity.Property(e => e.IssueToPerson).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);
            });

            modelBuilder.Entity<Housekeepissuedetail>(entity =>
            {
                entity.ToTable("Housekeepissuedetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("buy_rate");

                entity.Property(e => e.IssueId).HasColumnName("Issue_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<HouskeepReceive>(entity =>
            {
                entity.ToTable("HouskeepReceive");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .HasColumnName("Entered_By");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.IssueDepartment).HasColumnName("Issue_Department");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<HouskeepReceiveSub>(entity =>
            {
                entity.ToTable("HouskeepReceive_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.HouskeepReceiveId).HasColumnName("HouskeepReceive_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HrDepartment>(entity =>
            {
                entity.ToTable("HR_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialCategory).HasColumnName("Special_Category");
            });

            modelBuilder.Entity<HrDesignation>(entity =>
            {
                entity.ToTable("HR_Designation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrHoliday>(entity =>
            {
                entity.ToTable("HR_Holiday");

                entity.Property(e => e.HrHolidayId).HasColumnName("HR_HolidayID");

                entity.Property(e => e.CauseofHoliday).HasMaxLength(50);

                entity.Property(e => e.Holiday).HasColumnType("date");
            });

            modelBuilder.Entity<ImagingModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imaging_Module");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ImagingTemplate>(entity =>
            {
                entity.ToTable("Imaging_Template");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasColumnType("ntext");

                entity.Property(e => e.LabModuleId).HasColumnName("Lab_Module_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ImmunologicalTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Immunological_Tests");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncomeGroup>(entity =>
            {
                entity.ToTable("Income_Group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Group_Name");
            });

            modelBuilder.Entity<InvestigationModule>(entity =>
            {
                entity.ToTable("Investigation_Module");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.ReportHeader).HasMaxLength(250);
            });

            modelBuilder.Entity<InvestigationPackage>(entity =>
            {
                entity.ToTable("Investigation_Package");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<InvestigationReportHeader>(entity =>
            {
                entity.ToTable("Investigation_Report_Header");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckedById).HasColumnName("CheckedBy_ID");

                entity.Property(e => e.ConsultantId).HasColumnName("Consultant_ID");

                entity.Property(e => e.InvestigationModuleId).HasColumnName("Investigation_Module_ID");

                entity.Property(e => e.MechineText)
                    .HasMaxLength(500)
                    .HasColumnName("Mechine_Text");
            });

            modelBuilder.Entity<InvestigationReturn>(entity =>
            {
                entity.ToTable("Investigation_Return");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubId).HasColumnName("Sub_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<InvestigationSampleCollection>(entity =>
            {
                entity.ToTable("Investigation_Sample_Collection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarCodeImage).HasColumnType("image");

                entity.Property(e => e.CashMemoSubInvestigationId).HasColumnName("Cash_Memo_Sub_Investigation_ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.IsPrint)
                    .HasColumnName("Is_Print")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReportDelivery).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReportDone)
                    .HasColumnName("IsReport_Done")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUrgent)
                    .HasColumnName("Is_Urgent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SampleCollected).HasColumnName("Sample_Collected");

                entity.Property(e => e.SampleCollectedBy).HasColumnName("Sample_Collected_By");

                entity.Property(e => e.SampleCollectionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Sample_Collection_Date");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<InvestigationSubPackage>(entity =>
            {
                entity.ToTable("Investigation_Sub_Package");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PackageId).HasColumnName("Package_ID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            });

            modelBuilder.Entity<IpdDepartment>(entity =>
            {
                entity.ToTable("IPD_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IpdDiscount>(entity =>
            {
                entity.ToTable("IPD_Discount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountDoctor)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Discount_Doctor");

                entity.Property(e => e.DiscountDoctorBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Doctor_By");

                entity.Property(e => e.DiscountHospital)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Discount_Hospital");

                entity.Property(e => e.DiscountHospitalBy)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_Hospital_By");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<IpdReferral>(entity =>
            {
                entity.ToTable("IPD_Referral");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<IssueDepartment>(entity =>
            {
                entity.ToTable("Issue_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JvBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JV_Book");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<LabCheckedBy>(entity =>
            {
                entity.ToTable("Lab_Checked_By");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasMaxLength(60);
            });

            modelBuilder.Entity<LabConsultTran>(entity =>
            {
                entity.ToTable("Lab_Consult_Trans");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckedBy).HasColumnName("Checked_By");

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.CommentsHead).HasMaxLength(15);

                entity.Property(e => e.ConsultentId).HasColumnName("Consultent_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.ModuleFlag).HasColumnName("Module_Flag");

                entity.Property(e => e.Specimen).HasMaxLength(50);

                entity.Property(e => e.TestMethod)
                    .HasMaxLength(500)
                    .HasColumnName("Test_Method");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.HasOne(d => d.Consultent)
                    .WithMany(p => p.LabConsultTrans)
                    .HasForeignKey(d => d.ConsultentId)
                    .HasConstraintName("FK_Lab_Consult_Trans_Lab_Consultent");
            });

            modelBuilder.Entity<LabConsultantModule>(entity =>
            {
                entity.HasKey(e => e.LabModuleId);

                entity.ToTable("LabConsultantModule");

                entity.Property(e => e.LabModuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("LabModuleID");

                entity.Property(e => e.ModuleName).HasMaxLength(50);
            });

            modelBuilder.Entity<LabConsultent>(entity =>
            {
                entity.ToTable("Lab_Consultent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Degree).HasMaxLength(250);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Institution).HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.Others).HasMaxLength(250);

                entity.Property(e => e.Signature).HasColumnType("image");

                entity.Property(e => e.Title1).HasMaxLength(50);

                entity.Property(e => e.Title2).HasMaxLength(50);
            });

            modelBuilder.Entity<LabImage>(entity =>
            {
                entity.ToTable("Lab_Image");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LabImage1)
                    .HasColumnType("image")
                    .HasColumnName("LabImage");

                entity.Property(e => e.MemoId).HasColumnName("MemoID");
            });

            modelBuilder.Entity<LabInventory>(entity =>
            {
                entity.ToTable("Lab_Inventory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.InventoryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Inventory_Date");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<LabInventoryBalance>(entity =>
            {
                entity.ToTable("Lab_Inventory_Balance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NoOfTestBalance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<LabInventoryIssue>(entity =>
            {
                entity.ToTable("Lab_Inventory_Issue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue_Date");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<LabInventoryIssueSub>(entity =>
            {
                entity.ToTable("Lab_Inventory_Issue_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InventoryIssueId).HasColumnName("Inventory_Issue_ID");

                entity.Property(e => e.NoOfTest).HasColumnName("No_Of_Test");

                entity.Property(e => e.NoOfWastage).HasColumnName("No_Of_Wastage");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(200);
            });

            modelBuilder.Entity<LabInventorySub>(entity =>
            {
                entity.ToTable("Lab_Inventory_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LabInventoryId).HasColumnName("Lab_Inventory_ID");

                entity.Property(e => e.NoOfTest).HasColumnName("No_Of_Test");

                entity.Property(e => e.PackSize)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Pack_Size");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.Unit).HasMaxLength(10);
            });

            modelBuilder.Entity<LastLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LastLogin");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Logdate)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("logdate");

                entity.Property(e => e.MacAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveAvail>(entity =>
            {
                entity.ToTable("Leave_Avail");

                entity.HasIndex(e => new { e.EmployeeId, e.Year }, "IX_Leave_Avail")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cl)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("CL");

                entity.Property(e => e.El)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("EL");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.Fl)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("FL");

                entity.Property(e => e.MatL).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Ml)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ML");
            });

            modelBuilder.Entity<LeaveAvailType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Leave_Avail_Type");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeaveAvailV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Leave_Avail_V1");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("Leave_Type_ID");
            });

            modelBuilder.Entity<MedicalCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Medical_Certificate");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineAdjustChallan>(entity =>
            {
                entity.ToTable("Medicine_Adjust_Challan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.ReceAdjust)
                    .HasMaxLength(10)
                    .HasColumnName("Rece_adjust")
                    .IsFixedLength();

                entity.Property(e => e.RefDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Ref_Date");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ref_No");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineAdjustChallanSub>(entity =>
            {
                entity.ToTable("Medicine_Adjust_Challan_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("date")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<MedicineCustomer>(entity =>
            {
                entity.ToTable("Medicine_Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AreaId).HasColumnName("Area_ID");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineCustomerBankPayment>(entity =>
            {
                entity.ToTable("Medicine_Customer_Bank_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bank).HasMaxLength(100);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.CustomerPaymentId).HasColumnName("Customer_Payment_ID");
            });

            modelBuilder.Entity<MedicineCustomerLedger>(entity =>
            {
                entity.ToTable("Medicine_Customer_Ledger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerPaymentId).HasColumnName("Customer_Payment_ID");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesId).HasColumnName("Sales_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineCustomerPayment>(entity =>
            {
                entity.ToTable("Medicine_Customer_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CollectedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Collected_by");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.MedicineCustomerId).HasColumnName("Medicine_Customer_ID");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("Payment_Mode");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineDepartment>(entity =>
            {
                entity.ToTable("Medicine_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MedicineIndent>(entity =>
            {
                entity.ToTable("Medicine_Indent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillNo).HasColumnName("Bill_No");

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsPackage).HasColumnName("Is_Package");

                entity.Property(e => e.IsPending).HasColumnName("Is_Pending");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineIndentSub>(entity =>
            {
                entity.ToTable("Medicine_Indent_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Delivery).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeliveryBy)
                    .HasMaxLength(50)
                    .HasColumnName("Delivery_By");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Delivery_DT");

                entity.Property(e => e.IndentNo).HasColumnName("Indent_No");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Used).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Used_By");

                entity.Property(e => e.UsedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Used_DT");
            });

            modelBuilder.Entity<MedicineIssue>(entity =>
            {
                entity.ToTable("Medicine_Issue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineIssueSub>(entity =>
            {
                entity.ToTable("Medicine_Issue_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(50)
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.IssueNo).HasColumnName("Issue_No");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<MedicinePurchaseRequisition>(entity =>
            {
                entity.ToTable("Medicine_Purchase_Requisition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicinePurchaseRequisitionSub>(entity =>
            {
                entity.ToTable("Medicine_Purchase_Requisition_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastMonthSale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Month_Sale");

                entity.Property(e => e.LastPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Price");

                entity.Property(e => e.OrderQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurReqNo).HasColumnName("Pur_Req_No");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<MedicinePurchaseRequisitionSupplier>(entity =>
            {
                entity.ToTable("Medicine_Purchase_Requisition_Supplier");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgSaleConsiderQuantity).HasColumnName("AvgSale_Consider_Quantity");

                entity.Property(e => e.AvgSalesConsiderDays).HasColumnName("AvgSales_Consider_Days");

                entity.Property(e => e.DeliveredBy).HasMaxLength(250);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.RequsitionBy).HasMaxLength(250);

                entity.Property(e => e.SaleConsiderQuantity).HasColumnName("Sale_Consider_Quantity");

                entity.Property(e => e.SalesConsiderDays).HasColumnName("Sales_Consider_Days");

                entity.Property(e => e.StockConsiderDays).HasColumnName("Stock_Consider_Days");

                entity.Property(e => e.StockConsiderQuantity).HasColumnName("Stock_Consider_Quantity");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicinePurchaseRequisitionSupplierSub>(entity =>
            {
                entity.ToTable("Medicine_Purchase_Requisition_Supplier_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgSaleConsiderQuantity).HasColumnName("AvgSale_Consider_Quantity");

                entity.Property(e => e.AvgSalesConsiderDays).HasColumnName("AvgSales_Consider_Days");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastMonthSale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Month_Sale");

                entity.Property(e => e.LastPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Price");

                entity.Property(e => e.OrderQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurReqNo).HasColumnName("Pur_Req_No");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RequiredQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleConsiderQuantity).HasColumnName("Sale_Consider_Quantity");

                entity.Property(e => e.SalesConsiderDays).HasColumnName("Sales_Consider_Days");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.StockConsiderDays).HasColumnName("Stock_Consider_Days");

                entity.Property(e => e.StockConsiderQuantity).HasColumnName("Stock_Consider_Quantity");
            });

            modelBuilder.Entity<MedicineReceivingChallan>(entity =>
            {
                entity.ToTable("Medicine_Receiving_Challan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_No");

                entity.Property(e => e.IsPaid)
                    .HasColumnName("Is_Paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_Type");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<MedicineReceivingChallanSub>(entity =>
            {
                entity.ToTable("Medicine_Receiving_Challan_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.Bonus).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("date")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.MedicinePurchaseRequisitionId).HasColumnName("Medicine_Purchase_Requisition_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VatRate).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<MedicineRequisition>(entity =>
            {
                entity.ToTable("Medicine_Requisition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CounterFrom).HasColumnName("Counter_From");

                entity.Property(e => e.CounterTo).HasColumnName("Counter_To");

                entity.Property(e => e.DeliveredBy).HasColumnName("Delivered_By");

                entity.Property(e => e.DeliveredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Delivered_Date");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineRequisitionSub>(entity =>
            {
                entity.ToTable("Medicine_Requisition_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DelQuantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Del_Quantity");

                entity.Property(e => e.ReqNo).HasColumnName("Req_No");

                entity.Property(e => e.ReqQuantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Req_Quantity");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<MedicineReturn>(entity =>
            {
                entity.ToTable("Medicine_Return");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<MedicineReturnSub>(entity =>
            {
                entity.ToTable("Medicine_Return_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.MedicineReturnId).HasColumnName("Medicine_Return_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<MedicineStore>(entity =>
            {
                entity.ToTable("Medicine_Store");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBufferStore).HasColumnName("Is_Buffer_Store");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MedicineStoreBalance>(entity =>
            {
                entity.ToTable("Medicine_Store_Balance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("date")
                    .HasColumnName("Expire_Date");

                entity.Property(e => e.MedicineReceivingChallanSubId).HasColumnName("Medicine_Receiving_Challan_Sub_ID");

                entity.Property(e => e.MedicineStoreId).HasColumnName("Medicine_Store_ID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            });

            modelBuilder.Entity<MedicineType>(entity =>
            {
                entity.ToTable("Medicine_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Typ).HasMaxLength(5);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MoneyReceipt>(entity =>
            {
                entity.ToTable("Money_Receipt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Against)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bkashamount).HasColumnType("money");

                entity.Property(e => e.CardAmount).HasColumnType("money");

                entity.Property(e => e.Cardname).HasMaxLength(50);

                entity.Property(e => e.Cashamount)
                    .HasColumnType("money")
                    .HasColumnName("cashamount");

                entity.Property(e => e.Chequeamount)
                    .HasColumnType("money")
                    .HasColumnName("chequeamount");

                entity.Property(e => e.Chequeno)
                    .HasMaxLength(50)
                    .HasColumnName("chequeno");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasColumnName("note");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.ToTable("Nurse");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OpdOtReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OPD_OT_Reg");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Paid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<OpdOtRegCollection>(entity =>
            {
                entity.ToTable("OPD_OT_Reg_collection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Netpayable)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netpayable");

                entity.Property(e => e.OpdOtRegNo).HasColumnName("OPD_OT_RegNo");

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<OpdOtRegistration>(entity =>
            {
                entity.ToTable("OPD_OT_Registration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_Year");

                entity.Property(e => e.Anesthetist).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ApptSlno).HasColumnName("Appt_SLNO");

                entity.Property(e => e.Asstfee1).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Asstfee2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Asstfee3).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Bedno).HasMaxLength(50);

                entity.Property(e => e.Billno).HasColumnName("billno");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Gas).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Machine).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Medicine)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("medicine");

                entity.Property(e => e.Monitor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Otcharge)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("OTCharge");

                entity.Property(e => e.Others).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Package).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Paid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.Pow)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POW");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Reg_Date");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("roomno");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.StaffRef).HasMaxLength(50);

                entity.Property(e => e.Surgeon).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Vat).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OpdTicket>(entity =>
            {
                entity.ToTable("OPD_Ticket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_Year");

                entity.Property(e => e.ApptSlno).HasColumnName("Appt_SLNO");

                entity.Property(e => e.BkashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Bkash_Amount");

                entity.Property(e => e.CardAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Card_Amount");

                entity.Property(e => e.CardName)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CashAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cash_Amount");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Cheque_Amount");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CorporateClientId).HasColumnName("Corporate_Client_ID");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Opd).HasColumnName("OPD");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .HasColumnName("PatientID");

                entity.Property(e => e.QdoctorId).HasColumnName("QDoctor_ID");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketRate)
                    .HasMaxLength(50)
                    .HasColumnName("Ticket_Rate");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Upzillaid).HasColumnName("upzillaid");

                entity.Property(e => e.Vat).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Villageid).HasColumnName("villageid");
            });

            modelBuilder.Entity<OpeningBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OpeningBalance");

                entity.Property(e => e.BankOpening).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CashOpening).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OpeningDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OperationAsst>(entity =>
            {
                entity.ToTable("Operation_Asst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            });

            modelBuilder.Entity<OperationImage>(entity =>
            {
                entity.ToTable("Operation_Image");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperationId).HasColumnName("Operation_ID");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<OperationList>(entity =>
            {
                entity.ToTable("Operation_List");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anaesthesia)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Drug).HasMaxLength(500);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Operation_Date");

                entity.Property(e => e.OtSlNo).HasColumnName("OT_SL_NO");

                entity.Property(e => e.Otdone)
                    .HasColumnName("OTDone")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otprocedure).HasColumnName("OTProcedure");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<OperationNote>(entity =>
            {
                entity.ToTable("Operation_Note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anaesthesia).HasMaxLength(500);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Indication).HasMaxLength(500);

                entity.Property(e => e.Operation).HasMaxLength(500);

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Operation_Date");

                entity.Property(e => e.ProcedureAndFindings).HasColumnName("Procedure_And_Findings");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<OperationProcedure>(entity =>
            {
                entity.ToTable("Operation_Procedures");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("Service_Category_ID");
            });

            modelBuilder.Entity<OperationVideo>(entity =>
            {
                entity.ToTable("Operation_Video");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperationId).HasColumnName("Operation_ID");

                entity.Property(e => e.Video).IsRequired();
            });

            modelBuilder.Entity<OrganismIsolatedValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Organism_Isolated_Values");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackageRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Package_Record");

                entity.Property(e => e.PatientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Patient_Type");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<ParticularsBalanceHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Particulars_Balance_Head");

                entity.Property(e => e.BsHeadId).HasColumnName("BS_Head_ID");

                entity.Property(e => e.BsHeadName)
                    .HasMaxLength(50)
                    .HasColumnName("BS_Head_Name");
            });

            modelBuilder.Entity<ParticularsHead>(entity =>
            {
                entity.ToTable("Particulars_Head");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.FaDeptId).HasColumnName("FA_Dept_ID");

                entity.Property(e => e.HeadType).HasColumnName("Head_Type");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OBalance)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("O_Balance");

                entity.Property(e => e.Opwdv)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("OPWDV");

                entity.Property(e => e.SystemHeadType).HasColumnName("System_Head_Type");
            });

            modelBuilder.Entity<ParticularsMasterHead>(entity =>
            {
                entity.ToTable("Particulars_Master_Head");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcSlNo).HasColumnName("AC_SlNo");

                entity.Property(e => e.ActypeId).HasColumnName("ACType_ID");

                entity.Property(e => e.BalanceSheetHeadId).HasColumnName("Balance_Sheet_HeadID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ParticularsSubHead>(entity =>
            {
                entity.ToTable("Particulars_SubHead");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParticularsHeadId).HasColumnName("Particulars_HeadID");

                entity.Property(e => e.SubHead).HasMaxLength(50);
            });

            modelBuilder.Entity<PathologyGroupHead>(entity =>
            {
                entity.ToTable("Pathology_Group_Head");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PathologyReportHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pathology_Report_Head");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NormalRange).HasColumnName("Normal_Range");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_Year");

                entity.Property(e => e.BarCodeImage).HasColumnType("image");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(10)
                    .HasColumnName("Blood_Group");

                entity.Property(e => e.CareOf)
                    .HasMaxLength(50)
                    .HasColumnName("Care_Of");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.CorporateClientId).HasColumnName("CorporateClientID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .HasColumnName("Father_Name");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.PatientCatId).HasColumnName("Patient_Cat_ID");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PermanentDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("Permanent_District");

                entity.Property(e => e.PermanentPo)
                    .HasMaxLength(100)
                    .HasColumnName("Permanent_PO");

                entity.Property(e => e.PermanentPs)
                    .HasMaxLength(100)
                    .HasColumnName("Permanent_PS");

                entity.Property(e => e.PermanentVillage)
                    .HasMaxLength(200)
                    .HasColumnName("Permanent_Village");

                entity.Property(e => e.PresentDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("Present_District");

                entity.Property(e => e.PresentPo)
                    .HasMaxLength(100)
                    .HasColumnName("Present_PO");

                entity.Property(e => e.PresentPs)
                    .HasMaxLength(100)
                    .HasColumnName("Present_PS");

                entity.Property(e => e.PresentVillage)
                    .HasMaxLength(200)
                    .HasColumnName("Present_Village");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientAna>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_ANA");

                entity.Property(e => e.Cov)
                    .HasMaxLength(50)
                    .HasColumnName("COV");

                entity.Property(e => e.HeadServiceId).HasColumnName("Head_ServiceID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(50)
                    .HasColumnName("SampleOD");
            });

            modelBuilder.Entity<PatientAntiD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_AntiDS");

                entity.Property(e => e.Cov)
                    .HasMaxLength(50)
                    .HasColumnName("COV");

                entity.Property(e => e.HeadServiceId).HasColumnName("Head_ServiceID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(50)
                    .HasColumnName("SampleOD");
            });

            modelBuilder.Entity<PatientAptt>(entity =>
            {
                entity.ToTable("Patient_APTT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Control).HasMaxLength(50);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Patients).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientBhCg>(entity =>
            {
                entity.ToTable("Patient_BhCG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.TotalBhCg)
                    .HasMaxLength(50)
                    .HasColumnName("Total_BhCG");
            });

            modelBuilder.Entity<PatientBiochemistry>(entity =>
            {
                entity.ToTable("Patient_Biochemistry");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeadBiochemistryId).HasColumnName("Head_Biochemistry_ID");

                entity.Property(e => e.HeadName).HasMaxLength(250);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(250);

                entity.HasOne(d => d.Memo)
                    .WithMany(p => p.PatientBiochemistries)
                    .HasForeignKey(d => d.MemoId)
                    .HasConstraintName("FK_Patient_Biochemistry_Cash_Memo_Investigation");
            });

            modelBuilder.Entity<PatientBloodCrossMatching>(entity =>
            {
                entity.ToTable("Patient_Blood_Cross_Matching");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DonorAge)
                    .HasMaxLength(50)
                    .HasColumnName("Donor_Age");

                entity.Property(e => e.DonorBloodGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Donor_Blood_Group");

                entity.Property(e => e.DonorName)
                    .HasMaxLength(100)
                    .HasColumnName("Donor_Name");

                entity.Property(e => e.DonorRhFactor)
                    .HasMaxLength(50)
                    .HasColumnName("Donor_Rh_Factor");

                entity.Property(e => e.DonorSex)
                    .HasMaxLength(50)
                    .HasColumnName("Donor_Sex");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.PatientBloodGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_Blood_Group");

                entity.Property(e => e.PatientRhFactor)
                    .HasMaxLength(50)
                    .HasColumnName("Patient_Rh_Factor");
            });

            modelBuilder.Entity<PatientCovid>(entity =>
            {
                entity.ToTable("Patient_Covid");

                entity.Property(e => e.PatientCovidId).HasColumnName("PatientCovidID");

                entity.Property(e => e.CovidResult)
                    .HasMaxLength(50)
                    .HasColumnName("Covid_Result");

                entity.Property(e => e.Covidcategory).HasColumnName("covidcategory");

                entity.Property(e => e.DateReport)
                    .HasColumnType("date")
                    .HasColumnName("Date_Report");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.MethodTest)
                    .HasMaxLength(50)
                    .HasColumnName("Method_Test");

                entity.Property(e => e.Qrcode)
                    .HasColumnType("image")
                    .HasColumnName("QRCode");

                entity.Property(e => e.TestKitUsed).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientCytopathology>(entity =>
            {
                entity.ToTable("Patient_Cytopathology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Appearance).HasMaxLength(50);

                entity.Property(e => e.AtypicalCell)
                    .HasMaxLength(50)
                    .HasColumnName("Atypical_Cell");

                entity.Property(e => e.Colour).HasMaxLength(50);

                entity.Property(e => e.Lymphocyte).HasMaxLength(50);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Monocyte).HasMaxLength(50);

                entity.Property(e => e.Neutrophil).HasMaxLength(50);

                entity.Property(e => e.RedBloodCell)
                    .HasMaxLength(50)
                    .HasColumnName("Red_Blood_Cell");

                entity.Property(e => e.Volume).HasMaxLength(50);

                entity.Property(e => e.WhiteBloodCell)
                    .HasMaxLength(50)
                    .HasColumnName("White_Blood_Cell");
            });

            modelBuilder.Entity<PatientDischarge1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Discharge1");

                entity.Property(e => e.Advice).HasColumnType("ntext");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LabModuleId).HasColumnName("Lab_Module_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.ReportHeader)
                    .HasMaxLength(200)
                    .HasColumnName("Report_Header");

                entity.Property(e => e.Result).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<PatientHaematology>(entity =>
            {
                entity.ToTable("Patient_Haematology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeadHaematologyId).HasColumnName("Head_Haematology_ID");

                entity.Property(e => e.HeadName)
                    .HasMaxLength(100)
                    .HasColumnName("Head_Name");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(200);
            });

            modelBuilder.Entity<PatientHaemotologyDetail>(entity =>
            {
                entity.ToTable("Patient_Haemotology_Detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Advice1).HasMaxLength(500);

                entity.Property(e => e.Advice2).HasMaxLength(500);

                entity.Property(e => e.Basophils)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasophilsAb)
                    .HasMaxLength(20)
                    .HasColumnName("BasophilsAB");

                entity.Property(e => e.BleedingTime)
                    .HasMaxLength(20)
                    .HasColumnName("Bleeding_Time");

                entity.Property(e => e.Ch)
                    .HasMaxLength(20)
                    .HasColumnName("CH");

                entity.Property(e => e.Chcm)
                    .HasMaxLength(20)
                    .HasColumnName("CHCM");

                entity.Property(e => e.CirculatingEosinophils)
                    .HasMaxLength(20)
                    .HasColumnName("Circulating_Eosinophils");

                entity.Property(e => e.ClottingTime)
                    .HasMaxLength(20)
                    .HasColumnName("Clotting_Time");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.Eosinophils)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EosinophilsAb)
                    .HasMaxLength(20)
                    .HasColumnName("EosinophilsAB");

                entity.Property(e => e.Esr)
                    .HasMaxLength(20)
                    .HasColumnName("ESR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Haemoglobin).HasMaxLength(20);

                entity.Property(e => e.HctPcv)
                    .HasMaxLength(20)
                    .HasColumnName("HCT_PCV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hdw)
                    .HasMaxLength(20)
                    .HasColumnName("HDW");

                entity.Property(e => e.IctForMalaria)
                    .HasMaxLength(20)
                    .HasColumnName("ICT_for_Malaria");

                entity.Property(e => e.Luc)
                    .HasMaxLength(20)
                    .HasColumnName("LUC");

                entity.Property(e => e.Lucab)
                    .HasMaxLength(20)
                    .HasColumnName("LUCAB");

                entity.Property(e => e.Lymphocytes)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LymphocytesAb)
                    .HasMaxLength(20)
                    .HasColumnName("LymphocytesAB");

                entity.Property(e => e.MalarialParasites)
                    .HasMaxLength(20)
                    .HasColumnName("Malarial_Parasites");

                entity.Property(e => e.Mch)
                    .HasMaxLength(20)
                    .HasColumnName("MCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mchc)
                    .HasMaxLength(20)
                    .HasColumnName("MCHC");

                entity.Property(e => e.Mcv)
                    .HasMaxLength(20)
                    .HasColumnName("MCV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Monocytes)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonocytesAb)
                    .HasMaxLength(20)
                    .HasColumnName("MonocytesAB");

                entity.Property(e => e.Mpv)
                    .HasMaxLength(20)
                    .HasColumnName("MPV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Neutrophils)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeutrophilsAb)
                    .HasMaxLength(20)
                    .HasColumnName("NeutrophilsAB");

                entity.Property(e => e.Nrbc)
                    .HasMaxLength(20)
                    .HasColumnName("NRBC");

                entity.Property(e => e.Nrbcab)
                    .HasMaxLength(20)
                    .HasColumnName("NRBCAB");

                entity.Property(e => e.Pct)
                    .HasMaxLength(50)
                    .HasColumnName("PCT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pdw)
                    .HasMaxLength(50)
                    .HasColumnName("PDW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Platelets)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Plts)
                    .HasMaxLength(100)
                    .HasColumnName("PLTs");

                entity.Property(e => e.Rbc)
                    .HasMaxLength(20)
                    .HasColumnName("RBC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbcs)
                    .HasMaxLength(250)
                    .HasColumnName("RBCs");

                entity.Property(e => e.Rdw)
                    .HasMaxLength(20)
                    .HasColumnName("RDW");

                entity.Property(e => e.Reticulocytes)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wbcs)
                    .HasMaxLength(250)
                    .HasColumnName("WBCs");

                entity.Property(e => e.WhiteBloodCells)
                    .HasMaxLength(20)
                    .HasColumnName("White_Blood_Cells");
            });

            modelBuilder.Entity<PatientImaging>(entity =>
            {
                entity.ToTable("Patient_Imaging");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LabModuleId).HasColumnName("Lab_Module_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.NoOfPrint).HasColumnName("No_of_Print");

                entity.Property(e => e.ReportHeader)
                    .HasMaxLength(200)
                    .HasColumnName("Report_Header");

                entity.Property(e => e.Result).HasColumnType("ntext");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<PatientImmunology>(entity =>
            {
                entity.ToTable("Patient_Immunology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CutOffValue)
                    .HasMaxLength(50)
                    .HasColumnName("Cut_Off_Value");

                entity.Property(e => e.HeadImmunologyId).HasColumnName("Head_Immunology_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Opinion).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(100);

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(100)
                    .HasColumnName("Sample_OD");
            });

            modelBuilder.Entity<PatientImmunulogyDetail>(entity =>
            {
                entity.ToTable("Patient_Immunulogy_Detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CutOffValue)
                    .HasMaxLength(50)
                    .HasColumnName("Cut_Off_Value");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Opinion).HasMaxLength(50);

                entity.Property(e => e.SampleOd)
                    .HasMaxLength(50)
                    .HasColumnName("Sample_OD");

                entity.Property(e => e.TestName).HasColumnName("Test_Name");
            });

            modelBuilder.Entity<PatientLab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Lab");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LabModuleId).HasColumnName("Lab_Module_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.ReportHeader)
                    .HasMaxLength(200)
                    .HasColumnName("Report_Header");

                entity.Property(e => e.Result).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<PatientMicrobiology>(entity =>
            {
                entity.ToTable("Patient_Microbiology");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColonyCount)
                    .HasMaxLength(100)
                    .HasColumnName("Colony_Count");

                entity.Property(e => e.ColonyCountB)
                    .HasMaxLength(100)
                    .HasColumnName("Colony_CountB");

                entity.Property(e => e.HeadMicrobiologyId).HasColumnName("Head_Microbiology_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.OrganismIsolated)
                    .HasMaxLength(100)
                    .HasColumnName("Organism_Isolated");

                entity.Property(e => e.OrganismIsolatedB)
                    .HasMaxLength(100)
                    .HasColumnName("Organism_IsolatedB");

                entity.Property(e => e.ResultA)
                    .HasMaxLength(1)
                    .HasColumnName("Result_A");

                entity.Property(e => e.ResultB)
                    .HasMaxLength(1)
                    .HasColumnName("Result_B");

                entity.Property(e => e.ResultC)
                    .HasMaxLength(1)
                    .HasColumnName("Result_C");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.UrineCulture1)
                    .HasMaxLength(200)
                    .HasColumnName("Urine_Culture_1");
            });

            modelBuilder.Entity<PatientMicrobiologyDetail>(entity =>
            {
                entity.ToTable("Patient_Microbiology_Detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColonyCount)
                    .HasMaxLength(100)
                    .HasColumnName("Colony_Count");

                entity.Property(e => e.ColonyCountB)
                    .HasMaxLength(100)
                    .HasColumnName("Colony_CountB");

                entity.Property(e => e.IsGrowth).HasColumnName("Is_Growth");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.OrganismIsolated)
                    .HasMaxLength(100)
                    .HasColumnName("Organism_Isolated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrganismIsolatedB)
                    .HasMaxLength(100)
                    .HasColumnName("Organism_IsolatedB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Specimen).HasMaxLength(50);

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.TestMethod)
                    .HasMaxLength(500)
                    .HasColumnName("Test_Method");

                entity.Property(e => e.UrineCulture1)
                    .HasMaxLength(200)
                    .HasColumnName("Urine_Culture_1");

                entity.Property(e => e.UrineCulture2)
                    .HasMaxLength(100)
                    .HasColumnName("Urine_Culture_2");
            });

            modelBuilder.Entity<PatientMicrobiologyMicroscopy>(entity =>
            {
                entity.ToTable("Patient_Microbiology_Microscopy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Afb).HasColumnName("AFB");

                entity.Property(e => e.GramsStain).HasColumnName("Grams_Stain");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<PatientMt>(entity =>
            {
                entity.ToTable("Patient_MT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfInoculation)
                    .HasColumnType("date")
                    .HasColumnName("Date_Of_Inoculation");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(100)
                    .HasColumnName("Normal_Range");

                entity.Property(e => e.ReadingTime)
                    .HasMaxLength(10)
                    .HasColumnName("Reading_Time");

                entity.Property(e => e.Result).HasMaxLength(100);
            });

            modelBuilder.Entity<PatientObservation>(entity =>
            {
                entity.ToTable("Patient_Observation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Advise).HasMaxLength(500);

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.ObservationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Observation_Date");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientObservationMedicine>(entity =>
            {
                entity.ToTable("Patient_Observation_Medicine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DozeTime)
                    .HasMaxLength(200)
                    .HasColumnName("Doze_Time");

                entity.Property(e => e.Interval).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ObservationId).HasColumnName("Observation_ID");

                entity.Property(e => e.Remarks).HasMaxLength(75);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<PatientPackageTransaction>(entity =>
            {
                entity.ToTable("Patient_Package_Transaction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IpdDeptId).HasColumnName("IPD_Dept_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.ServiceRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Rate");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientPathologyResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Pathology_Result");

                entity.Property(e => e.HeadName).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.PathologyHeadId).HasColumnName("Pathology_Head_ID");

                entity.Property(e => e.Result).HasMaxLength(250);
            });

            modelBuilder.Entity<PatientPayment>(entity =>
            {
                entity.ToTable("Patient_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IsHospitalPayment).HasColumnName("IS_Hospital_Payment");

                entity.Property(e => e.MrId).HasColumnName("MR_ID");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientPleuralFluid>(entity =>
            {
                entity.ToTable("Patient_PleuralFluid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ada)
                    .HasMaxLength(20)
                    .HasColumnName("ADA");

                entity.Property(e => e.Afzstain)
                    .HasMaxLength(20)
                    .HasColumnName("AFZStain");

                entity.Property(e => e.Basophils).HasMaxLength(20);

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.DegeneratedCells).HasMaxLength(20);

                entity.Property(e => e.Deposit).HasMaxLength(20);

                entity.Property(e => e.DifferentialCount).HasMaxLength(20);

                entity.Property(e => e.Eosinophils).HasMaxLength(20);

                entity.Property(e => e.Glucose).HasMaxLength(20);

                entity.Property(e => e.GramStain).HasMaxLength(20);

                entity.Property(e => e.Ldh)
                    .HasMaxLength(20)
                    .HasColumnName("LDH");

                entity.Property(e => e.LeucocytesCount).HasMaxLength(20);

                entity.Property(e => e.Lymphocytes).HasMaxLength(20);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Monocytes).HasMaxLength(20);

                entity.Property(e => e.Neutrophils).HasMaxLength(20);

                entity.Property(e => e.OthersEpithelialCells).HasMaxLength(20);

                entity.Property(e => e.Quantity).HasMaxLength(20);

                entity.Property(e => e.RedBloodCells).HasMaxLength(20);

                entity.Property(e => e.TotalProtein).HasMaxLength(20);

                entity.Property(e => e.Volume).HasMaxLength(20);
            });

            modelBuilder.Entity<PatientProthomBin>(entity =>
            {
                entity.ToTable("Patient_Prothom_Bin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Control).HasMaxLength(50);

                entity.Property(e => e.Inr)
                    .HasMaxLength(50)
                    .HasColumnName("INR");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.PIndex)
                    .HasMaxLength(50)
                    .HasColumnName("P_Index");

                entity.Property(e => e.Pt)
                    .HasMaxLength(50)
                    .HasColumnName("PT");

                entity.Property(e => e.Ratio).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientProthomBinNew>(entity =>
            {
                entity.ToTable("Patient_Prothom_Bin_New");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeadServiceId).HasColumnName("Head_ServiceID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Relation");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<PatientSemenAnalysis>(entity =>
            {
                entity.ToTable("Patient_Semen_Analysis");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivelyMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Actively_Motile");

                entity.Property(e => e.ClumpingSperm)
                    .HasMaxLength(50)
                    .HasColumnName("Clumping_Sperm");

                entity.Property(e => e.Colour).HasMaxLength(50);

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.EpithelialCells)
                    .HasMaxLength(50)
                    .HasColumnName("Epithelial_Cells");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.MethodOfCollection)
                    .HasMaxLength(100)
                    .HasColumnName("Method_Of_Collection");

                entity.Property(e => e.MorphologyAbnormal)
                    .HasMaxLength(50)
                    .HasColumnName("Morphology_Abnormal");

                entity.Property(e => e.MorphologyNormal)
                    .HasMaxLength(50)
                    .HasColumnName("Morphology_Normal");

                entity.Property(e => e.NonMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Non_Motile");

                entity.Property(e => e.Odour).HasMaxLength(50);

                entity.Property(e => e.PusCells)
                    .HasMaxLength(50)
                    .HasColumnName("Pus_Cells");

                entity.Property(e => e.Rbc)
                    .HasMaxLength(50)
                    .HasColumnName("RBC");

                entity.Property(e => e.Reaction).HasMaxLength(50);

                entity.Property(e => e.ReducedMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Reduced_Motile");

                entity.Property(e => e.SpermCount)
                    .HasMaxLength(100)
                    .HasColumnName("Sperm_Count");

                entity.Property(e => e.TimeOfCollection)
                    .HasMaxLength(50)
                    .HasColumnName("Time_Of_Collection");

                entity.Property(e => e.TimeOfExamination)
                    .HasMaxLength(50)
                    .HasColumnName("Time_Of_Examination");

                entity.Property(e => e.Viscosity).HasMaxLength(50);

                entity.Property(e => e.Volume).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientSemenAnalysisDefault>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Semen_Analysis_Default");

                entity.Property(e => e.ActivelyMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Actively_Motile");

                entity.Property(e => e.ClumpingSperm)
                    .HasMaxLength(50)
                    .HasColumnName("Clumping_Sperm");

                entity.Property(e => e.Colour).HasMaxLength(50);

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.EpithelialCells)
                    .HasMaxLength(50)
                    .HasColumnName("Epithelial_Cells");

                entity.Property(e => e.MethodOfCollection)
                    .HasMaxLength(100)
                    .HasColumnName("Method_Of_Collection");

                entity.Property(e => e.MorphologyAbnormal)
                    .HasMaxLength(50)
                    .HasColumnName("Morphology_Abnormal");

                entity.Property(e => e.MorphologyNormal)
                    .HasMaxLength(50)
                    .HasColumnName("Morphology_Normal");

                entity.Property(e => e.NonMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Non_Motile");

                entity.Property(e => e.Odour).HasMaxLength(50);

                entity.Property(e => e.PusCells)
                    .HasMaxLength(50)
                    .HasColumnName("Pus_Cells");

                entity.Property(e => e.Rbc)
                    .HasMaxLength(50)
                    .HasColumnName("RBC");

                entity.Property(e => e.Reaction).HasMaxLength(50);

                entity.Property(e => e.ReducedMotile)
                    .HasMaxLength(50)
                    .HasColumnName("Reduced_Motile");

                entity.Property(e => e.SpermCount)
                    .HasMaxLength(100)
                    .HasColumnName("Sperm_Count");

                entity.Property(e => e.TimeOfCollection)
                    .HasMaxLength(50)
                    .HasColumnName("Time_Of_Collection");

                entity.Property(e => e.TimeOfExamination)
                    .HasMaxLength(50)
                    .HasColumnName("Time_Of_Examination");

                entity.Property(e => e.Viscosity).HasMaxLength(50);

                entity.Property(e => e.Volume).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientSemenAnalysisV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Semen_Analysis_V1");

                entity.Property(e => e.HeadName).HasMaxLength(250);

                entity.Property(e => e.HeadSemenAlalysisId).HasColumnName("Head_Semen_Alalysis_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(250);
            });

            modelBuilder.Entity<PatientSerological>(entity =>
            {
                entity.ToTable("Patient_Serological");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeadSerologicalId).HasColumnName("Head_Serological_ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(100);
            });

            modelBuilder.Entity<PatientSerumElectrolyte>(entity =>
            {
                entity.ToTable("Patient_Serum_Electrolytes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Chloride).HasMaxLength(50);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Potassium).HasMaxLength(50);

                entity.Property(e => e.Sodium).HasMaxLength(50);

                entity.Property(e => e.TotalCarbondioxide)
                    .HasMaxLength(50)
                    .HasColumnName("Total_Carbondioxide");
            });

            modelBuilder.Entity<PatientStool>(entity =>
            {
                entity.ToTable("Patient_Stool");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnkylostomaDuodenale)
                    .HasMaxLength(20)
                    .HasColumnName("Ankylostoma_duodenale");

                entity.Property(e => e.AscarisLumbricoides)
                    .HasMaxLength(20)
                    .HasColumnName("Ascaris_lumbricoides");

                entity.Property(e => e.Blood).HasMaxLength(20);

                entity.Property(e => e.CharcotLeydenCrystals)
                    .HasMaxLength(20)
                    .HasColumnName("Charcot_Leyden_Crystals");

                entity.Property(e => e.Colour).HasMaxLength(20);

                entity.Property(e => e.Consistency).HasMaxLength(20);

                entity.Property(e => e.EColi)
                    .HasMaxLength(20)
                    .HasColumnName("E_coli");

                entity.Property(e => e.EColi1)
                    .HasMaxLength(20)
                    .HasColumnName("E_coli1");

                entity.Property(e => e.EHistolytica)
                    .HasMaxLength(20)
                    .HasColumnName("E_histolytica");

                entity.Property(e => e.EHistolytica1)
                    .HasMaxLength(20)
                    .HasColumnName("E_histolytica1");

                entity.Property(e => e.EnterobiusVemicularis)
                    .HasMaxLength(20)
                    .HasColumnName("Enterobius_vemicularis");

                entity.Property(e => e.EpithelialCells)
                    .HasMaxLength(20)
                    .HasColumnName("Epithelial_Cells");

                entity.Property(e => e.FatGlobules)
                    .HasMaxLength(20)
                    .HasColumnName("Fat_Globules");

                entity.Property(e => e.GiardiaLamblia)
                    .HasMaxLength(20)
                    .HasColumnName("Giardia_lamblia");

                entity.Property(e => e.GiardiaLamblia1)
                    .HasMaxLength(20)
                    .HasColumnName("Giardia_lamblia1");

                entity.Property(e => e.HymenolepisNana)
                    .HasMaxLength(20)
                    .HasColumnName("Hymenolepis_nana");

                entity.Property(e => e.Macrophages).HasMaxLength(20);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Mucus).HasMaxLength(20);

                entity.Property(e => e.Mucus1).HasMaxLength(20);

                entity.Property(e => e.MuscleFibers)
                    .HasMaxLength(20)
                    .HasColumnName("Muscle_Fibers");

                entity.Property(e => e.OccultBloodTest)
                    .HasMaxLength(20)
                    .HasColumnName("Occult_Blood_Test");

                entity.Property(e => e.Odour).HasMaxLength(20);

                entity.Property(e => e.PusCells)
                    .HasMaxLength(20)
                    .HasColumnName("Pus_Cells");

                entity.Property(e => e.Rbcs)
                    .HasMaxLength(20)
                    .HasColumnName("RBCs");

                entity.Property(e => e.Reaction).HasMaxLength(20);

                entity.Property(e => e.ReducingSubstance)
                    .HasMaxLength(20)
                    .HasColumnName("Reducing_Substance");

                entity.Property(e => e.Starch).HasMaxLength(20);

                entity.Property(e => e.TrichurisTrichiura)
                    .HasMaxLength(20)
                    .HasColumnName("Trichuris_trichiura");

                entity.Property(e => e.VegetableCells)
                    .HasMaxLength(20)
                    .HasColumnName("Vegetable_Cells");

                entity.Property(e => e.YeastCells)
                    .HasMaxLength(20)
                    .HasColumnName("Yeast_Cells");
            });

            modelBuilder.Entity<PatientStoolV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Stool_V1");

                entity.Property(e => e.HeadName).HasMaxLength(250);

                entity.Property(e => e.HeadStoolId).HasColumnName("Head_Stool_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(250);
            });

            modelBuilder.Entity<PatientTransaction>(entity =>
            {
                entity.ToTable("Patient_Transaction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IpdDeptId).HasColumnName("IPD_Dept_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.ServiceRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Service_Rate");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientTransactionDoctor>(entity =>
            {
                entity.ToTable("Patient_Transaction_Doctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.Particulars).HasMaxLength(50);

                entity.Property(e => e.PatientTransactionId).HasColumnName("Patient_Transaction_ID");

                entity.Property(e => e.Payment).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PatientTransactionDoctorBalance>(entity =>
            {
                entity.ToTable("Patient_Transaction_Doctor_Balance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            });

            modelBuilder.Entity<PatientTuberculin>(entity =>
            {
                entity.ToTable("Patient_Tuberculin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail).HasMaxLength(200);

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Opinion).HasMaxLength(200);

                entity.Property(e => e.ReadingDate)
                    .HasColumnType("date")
                    .HasColumnName("Reading_Date");

                entity.Property(e => e.Result).HasMaxLength(200);
            });

            modelBuilder.Entity<PatientUrine>(entity =>
            {
                entity.ToTable("Patient_Urine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Albumin).HasMaxLength(20);

                entity.Property(e => e.AmorphousPhosphate)
                    .HasMaxLength(20)
                    .HasColumnName("Amorphous_Phosphate");

                entity.Property(e => e.Appearance).HasMaxLength(20);

                entity.Property(e => e.Bacteria).HasMaxLength(20);

                entity.Property(e => e.Blood).HasMaxLength(20);

                entity.Property(e => e.CalciumOxalate)
                    .HasMaxLength(20)
                    .HasColumnName("Calcium_Oxalate");

                entity.Property(e => e.CellularCasts)
                    .HasMaxLength(20)
                    .HasColumnName("Cellular_Casts");

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.EpithelialCells)
                    .HasMaxLength(20)
                    .HasColumnName("Epithelial_cells");

                entity.Property(e => e.ExcessOfPhosphate)
                    .HasMaxLength(20)
                    .HasColumnName("Excess_of_phosphate");

                entity.Property(e => e.GranularCasts)
                    .HasMaxLength(20)
                    .HasColumnName("Granular_Casts");

                entity.Property(e => e.HyalineCasts)
                    .HasMaxLength(20)
                    .HasColumnName("Hyaline_Casts");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.MucusThreads)
                    .HasMaxLength(20)
                    .HasColumnName("Mucus_Threads");

                entity.Property(e => e.PusCells)
                    .HasMaxLength(20)
                    .HasColumnName("Pus_cells");

                entity.Property(e => e.Quantity).HasMaxLength(20);

                entity.Property(e => e.Rbc)
                    .HasMaxLength(20)
                    .HasColumnName("RBC");

                entity.Property(e => e.Reaction).HasMaxLength(20);

                entity.Property(e => e.Sediment).HasMaxLength(20);

                entity.Property(e => e.SpecificGravity)
                    .HasMaxLength(20)
                    .HasColumnName("Specific_gravity");

                entity.Property(e => e.Spermatozoa).HasMaxLength(20);

                entity.Property(e => e.SugarRs)
                    .HasMaxLength(20)
                    .HasColumnName("Sugar_RS");

                entity.Property(e => e.TrichomonasVaginalis)
                    .HasMaxLength(20)
                    .HasColumnName("Trichomonas_Vaginalis");

                entity.Property(e => e.TriplePhosphate)
                    .HasMaxLength(20)
                    .HasColumnName("Triple_Phosphate");

                entity.Property(e => e.UricAcid)
                    .HasMaxLength(20)
                    .HasColumnName("Uric_Acid");

                entity.Property(e => e.Urobilinogen).HasMaxLength(20);

                entity.Property(e => e.Xxxx)
                    .HasMaxLength(20)
                    .HasColumnName("xxxx");

                entity.Property(e => e.Yeast).HasMaxLength(20);
            });

            modelBuilder.Entity<PatientUrineV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Urine_V1");

                entity.Property(e => e.HeadName).HasMaxLength(250);

                entity.Property(e => e.HeadUrineId).HasColumnName("Head_Urine_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.Result).HasMaxLength(250);
            });

            modelBuilder.Entity<PatientXrayImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_XRay_Image");

                entity.Property(e => e.DocImage).HasColumnType("image");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("MemoID");

                entity.Property(e => e.XrayId).HasColumnName("XrayID");
            });

            modelBuilder.Entity<PaymentsDetail>(entity =>
            {
                entity.ToTable("Payments_Details");

                entity.Property(e => e.Bkash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Card).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CardName)
                    .HasMaxLength(150)
                    .HasColumnName("Card_Name");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(150)
                    .HasColumnName("Card_No");

                entity.Property(e => e.Cash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(150)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.CurrentDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Current_Due");

                entity.Property(e => e.EnterdBy).HasColumnName("Enterd_By");

                entity.Property(e => e.MemoNo).HasColumnName("Memo_No");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Date");
            });

            modelBuilder.Entity<PharmacyDuePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pharmacy_Due_Payment");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId)
                    .HasMaxLength(50)
                    .HasColumnName("Memo_Id");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("Payment_Mode");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PharmacyDuePaymentTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pharmacy_Due_PaymentTemp");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemoId)
                    .HasMaxLength(50)
                    .HasColumnName("Memo_Id");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("Payment_Mode");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.ToTable("Prescription");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_Year");

                entity.Property(e => e.Anaemai).HasMaxLength(50);

                entity.Property(e => e.AppointmentFor).HasMaxLength(150);

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(10)
                    .HasColumnName("Blood_Group");

                entity.Property(e => e.Bmi)
                    .HasMaxLength(10)
                    .HasColumnName("BMI");

                entity.Property(e => e.Bp)
                    .HasMaxLength(20)
                    .HasColumnName("BP");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_No");

                entity.Property(e => e.DoctorAdvices).HasMaxLength(500);

                entity.Property(e => e.DozeTime)
                    .HasMaxLength(100)
                    .HasColumnName("Doze_Time");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hip).HasMaxLength(10);

                entity.Property(e => e.Ho)
                    .HasMaxLength(100)
                    .HasColumnName("HO");

                entity.Property(e => e.Jaundice).HasMaxLength(50);

                entity.Property(e => e.MedicalHistory).HasColumnName("Medical_History");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NextVisit).HasColumnType("datetime");

                entity.Property(e => e.Oe).HasColumnName("OE");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.Pprocedure).HasColumnName("PProcedure");

                entity.Property(e => e.Prem).HasMaxLength(10);

                entity.Property(e => e.Pulse).HasMaxLength(20);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefId)
                    .HasMaxLength(50)
                    .HasColumnName("Ref_Id");

                entity.Property(e => e.ReferredBy).HasColumnName("Referred_By");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Restp).HasMaxLength(20);

                entity.Property(e => e.ServiceId).HasColumnName("Service_Id");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Temperature).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.VisitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Visit_Date");

                entity.Property(e => e.VisitNo).HasColumnName("Visit_No");

                entity.Property(e => e.Waist).HasMaxLength(10);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PrescriptionInvestigation>(entity =>
            {
                entity.ToTable("Prescription_Investigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PrescriptionId).HasColumnName("Prescription_ID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<PrescriptionMedicine>(entity =>
            {
                entity.ToTable("Prescription_Medicine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DaysFor).HasMaxLength(50);

                entity.Property(e => e.DozeTime)
                    .HasMaxLength(200)
                    .HasColumnName("Doze_Time");

                entity.Property(e => e.Interval).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrescriptionId).HasColumnName("Prescription_ID");

                entity.Property(e => e.RouteId)
                    .HasMaxLength(50)
                    .HasColumnName("RouteID");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<PrescriptionPhyosiotherapy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prescription_Phyosiotherapy");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PrescriptionId).HasColumnName("Prescription_ID");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<PrescriptionRecord>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("PrescriptionRecord");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.DocImage).HasColumnType("image");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(11)
                    .HasColumnName("Patient_ID");

                entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");
            });

            modelBuilder.Entity<PrintHistory>(entity =>
            {
                entity.ToTable("Print_History");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Print_Date");

                entity.Property(e => e.PrintedBy).HasColumnName("Printed_By");
            });

            modelBuilder.Entity<PromotionOfficerInfo>(entity =>
            {
                entity.ToTable("Promotion_Officer_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addesss).HasMaxLength(150);

                entity.Property(e => e.BmdRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BMD_Rate");

                entity.Property(e => e.CdoplerRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CDopler_Rate");

                entity.Property(e => e.ColonosRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Colonos_Rate");

                entity.Property(e => e.CtscanRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTScan_Rate");

                entity.Property(e => e.CturoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CTUro_Rate");

                entity.Property(e => e.EcgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECG_Rate");

                entity.Property(e => e.Echo2dRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECHO2D_Rate");

                entity.Property(e => e.EchoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ECHO_Rate");

                entity.Property(e => e.EegRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EEG_Rate");

                entity.Property(e => e.EflowRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EFlow_Rate");

                entity.Property(e => e.EndosRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Endos_Rate");

                entity.Property(e => e.EttRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ETT_Rate");

                entity.Property(e => e.Incentiverate).HasColumnName("incentiverate");

                entity.Property(e => e.MriRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MRI_Rate");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.OpgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OPG_Rate");

                entity.Property(e => e.PathoRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Patho_Rate");

                entity.Property(e => e.UsgRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("USG_Rate");

                entity.Property(e => e.XrayRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("XRay_Rate");
            });

            modelBuilder.Entity<PurchaseRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Request");

                entity.Property(e => e.EnterdBy).HasColumnName("Enterd_By");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.ReqBy).HasMaxLength(50);

                entity.Property(e => e.ReqNo)
                    .HasMaxLength(50)
                    .HasColumnName("Req_No");

                entity.Property(e => e.RequestDepartment).HasColumnName("Request_Department");

                entity.Property(e => e.RequestFrom).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.StoreRequestId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StoreRequestID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<PurchaseRequestDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Request_Detail");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IssuedQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.StoreRequestDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StoreRequestDetailID");

                entity.Property(e => e.StoreRequestId).HasColumnName("StoreRequestID");
            });

            modelBuilder.Entity<Rack>(entity =>
            {
                entity.Property(e => e.RackId).HasColumnName("RackID");

                entity.Property(e => e.RackNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ReferralCategory>(entity =>
            {
                entity.ToTable("Referral_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgeDay).HasColumnName("Age_Day");

                entity.Property(e => e.AgeMonth).HasColumnName("Age_Month");

                entity.Property(e => e.AgeYear).HasColumnName("Age_year");

                entity.Property(e => e.AlcoholicValue)
                    .HasMaxLength(150)
                    .HasColumnName("Alcoholic_Value");

                entity.Property(e => e.Asthma).HasMaxLength(150);

                entity.Property(e => e.BarCodeImage).HasColumnType("image");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(10)
                    .HasColumnName("Blood_Group");

                entity.Property(e => e.Bmi)
                    .HasMaxLength(10)
                    .HasColumnName("BMI");

                entity.Property(e => e.Bp)
                    .HasMaxLength(20)
                    .HasColumnName("BP");

                entity.Property(e => e.Cardiac).HasMaxLength(150);

                entity.Property(e => e.CareOf)
                    .HasMaxLength(50)
                    .HasColumnName("Care_Of");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Copd).HasMaxLength(150);

                entity.Property(e => e.CounsellorComment)
                    .HasMaxLength(500)
                    .HasColumnName("Counsellor_Comment");

                entity.Property(e => e.CovidOthers).HasMaxLength(150);

                entity.Property(e => e.CovidSymtopDate).HasColumnType("date");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.Diabetic).HasMaxLength(150);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.DoctorComment)
                    .HasMaxLength(500)
                    .HasColumnName("Doctor_Comment");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.DrugAllergy)
                    .HasMaxLength(150)
                    .HasColumnName("Drug_Allergy");

                entity.Property(e => e.Due).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyName)
                    .HasMaxLength(150)
                    .HasColumnName("Emergency_Name");

                entity.Property(e => e.EmergencyPhone)
                    .HasMaxLength(50)
                    .HasColumnName("Emergency_Phone");

                entity.Property(e => e.EmergencyRelationship)
                    .HasMaxLength(150)
                    .HasColumnName("Emergency_Relationship");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.FamilyHistory)
                    .HasMaxLength(500)
                    .HasColumnName("Family_History");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .HasColumnName("Father_Name");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hip).HasMaxLength(10);

                entity.Property(e => e.Hypertension).HasMaxLength(150);

                entity.Property(e => e.IsAsthma).HasColumnName("Is_Asthma");

                entity.Property(e => e.IsCardiac).HasColumnName("Is_Cardiac");

                entity.Property(e => e.IsCopd).HasColumnName("Is_Copd");

                entity.Property(e => e.IsDiabetic).HasColumnName("Is_Diabetic");

                entity.Property(e => e.IsDrugAllergy).HasColumnName("Is_Drug_Allergy");

                entity.Property(e => e.IsHypertention).HasColumnName("Is_Hypertention");

                entity.Property(e => e.IsSmoking).HasColumnName("Is_Smoking");

                entity.Property(e => e.IsThyroid).HasColumnName("Is_Thyroid");

                entity.Property(e => e.MaritalStatus).HasMaxLength(150);

                entity.Property(e => e.MedicalHistory)
                    .HasMaxLength(500)
                    .HasColumnName("Medical_History");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .HasColumnName("NID");

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.OpdPackage)
                    .HasColumnName("OPD_Package")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OT_Date");

                entity.Property(e => e.Others).HasMaxLength(200);

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Passport).HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Permanent_Address");

                entity.Property(e => e.PermanentDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("Permanent_District")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PermanentDivision).HasColumnName("Permanent_Division");

                entity.Property(e => e.PermanentPo)
                    .HasMaxLength(100)
                    .HasColumnName("Permanent_PO");

                entity.Property(e => e.PermanentPs)
                    .HasMaxLength(100)
                    .HasColumnName("Permanent_PS");

                entity.Property(e => e.PermanentVillage)
                    .HasMaxLength(200)
                    .HasColumnName("Permanent_Village");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PoSerial).HasColumnName("PO_Serial");

                entity.Property(e => e.Prem).HasMaxLength(10);

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(250)
                    .HasColumnName("Present_Address");

                entity.Property(e => e.PresentDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("Present_District");

                entity.Property(e => e.PresentDivision).HasColumnName("Present_Division");

                entity.Property(e => e.PresentPo)
                    .HasMaxLength(100)
                    .HasColumnName("Present_PO");

                entity.Property(e => e.PresentPs)
                    .HasMaxLength(100)
                    .HasColumnName("Present_PS");

                entity.Property(e => e.PresentVillage)
                    .HasMaxLength(200)
                    .HasColumnName("Present_Village");

                entity.Property(e => e.Pulse).HasMaxLength(20);

                entity.Property(e => e.ReferredPerson)
                    .HasMaxLength(200)
                    .HasColumnName("Referred_Person");

                entity.Property(e => e.Religion).HasMaxLength(150);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RenalValue)
                    .HasMaxLength(150)
                    .HasColumnName("Renal_Value");

                entity.Property(e => e.ResponsibleContact)
                    .HasMaxLength(50)
                    .HasColumnName("Responsible_Contact");

                entity.Property(e => e.ResponsiblePerson)
                    .HasMaxLength(50)
                    .HasColumnName("Responsible_Person");

                entity.Property(e => e.ResponsibleRelation)
                    .HasMaxLength(50)
                    .HasColumnName("Responsible_Relation");

                entity.Property(e => e.Restp).HasMaxLength(20);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Smoking).HasMaxLength(150);

                entity.Property(e => e.Temperature).HasMaxLength(10);

                entity.Property(e => e.Thyroid).HasMaxLength(150);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Waist).HasMaxLength(10);

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReportHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportHead");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ReportHeadId).HasMaxLength(250);

                entity.Property(e => e.ReportHeadName).HasMaxLength(250);

                entity.Property(e => e.ReportName).HasMaxLength(250);
            });

            modelBuilder.Entity<ReportMarginSetting>(entity =>
            {
                entity.ToTable("Report_Margin_Settings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BottomMargin).HasColumnName("Bottom_Margin");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeftMargin).HasColumnName("Left_Margin");

                entity.Property(e => e.RightMargin).HasColumnName("Right_Margin");

                entity.Property(e => e.TopMargin).HasColumnName("Top_Margin");
            });

            modelBuilder.Entity<SalaryDisbursement>(entity =>
            {
                entity.ToTable("Salary_Disbursement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DA");

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Department).HasMaxLength(150);

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.Designation).HasMaxLength(200);

                entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");

                entity.Property(e => e.DisbursementMonth)
                    .HasColumnType("date")
                    .HasColumnName("Disbursement_Month");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(100)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EnterBy).HasColumnName("Enter_By");

                entity.Property(e => e.HouseRent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("House_Rent");

                entity.Property(e => e.Medical).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.Special).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Date");

                entity.Property(e => e.Washing).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.DisAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GenericId).HasColumnName("Generic_ID");

                entity.Property(e => e.InvestigationModuleId).HasColumnName("Investigation_Module_ID");

                entity.Property(e => e.Ipdrate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPDRate");

                entity.Property(e => e.IsVatApp).HasColumnName("Is_VAT_App");

                entity.Property(e => e.MedFor)
                    .HasMaxLength(50)
                    .HasColumnName("Med_For");

                entity.Property(e => e.RackNo).HasMaxLength(50);

                entity.Property(e => e.ReOrderLevel)
                    .HasColumnName("Re_Order_Level")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.Specimen).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceCategory>(entity =>
            {
                entity.ToTable("Service_Category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DoctorsPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GroupSubId).HasColumnName("Group_Sub_ID");

                entity.Property(e => e.InvestigationSlno).HasColumnName("Investigation_SLNO");

                entity.Property(e => e.IsPercentage).HasColumnName("Is_Percentage");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.SubId).HasColumnName("Sub_ID");
            });

            modelBuilder.Entity<ServiceCategorySub>(entity =>
            {
                entity.ToTable("Service_Category_Sub");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("Service_Category_ID");

                entity.Property(e => e.SubCategoryId).HasColumnName("Sub_Category_ID");
            });

            modelBuilder.Entity<ServiceCategorySubDinvestigation>(entity =>
            {
                entity.ToTable("Service_Category_Sub_DInvestigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChildCategoryId).HasColumnName("Child_Category_ID");

                entity.Property(e => e.MasterCategoryId).HasColumnName("Master_Category_ID");
            });

            modelBuilder.Entity<ServiceGroup>(entity =>
            {
                entity.ToTable("Service_Group");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentServiceId).HasColumnName("Parent_Service_ID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<SettingCmiSm>(entity =>
            {
                entity.HasKey(e => e.CmiSmsId);

                entity.ToTable("setting_cmi_sms");

                entity.Property(e => e.CmiSmsId).HasColumnName("cmi_sms_ID");

                entity.Property(e => e.CmiAdminNo)
                    .HasMaxLength(50)
                    .HasColumnName("cmi_admin_no");

                entity.Property(e => e.CmiSmsText).HasColumnName("cmi_sms_text");

                entity.Property(e => e.CmiSmsYes)
                    .HasColumnName("cmi_sms_yes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PadmissionAdminNo)
                    .HasMaxLength(50)
                    .HasColumnName("padmission_admin_no");

                entity.Property(e => e.PadmissionSmsYes)
                    .HasColumnName("padmission_sms_yes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PadmissionText).HasColumnName("padmission_text");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sex");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Smsbalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSBalance");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.ToTable("SMSLogs");

                entity.Property(e => e.SmsLogId).HasColumnName("SmsLogID");

                entity.Property(e => e.AreaName).HasMaxLength(550);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.MemoId).HasColumnName("Memo_ID");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RefferedBy).HasMaxLength(50);

                entity.Property(e => e.SenderMobileNo).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("User_Name");
            });

            modelBuilder.Entity<Speciman>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<StoreChallan>(entity =>
            {
                entity.ToTable("Store_Challan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChallanDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_No");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<StoreChallanSub>(entity =>
            {
                entity.ToTable("Store_Challan_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Expire).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VatRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StoreIssue>(entity =>
            {
                entity.ToTable("Store_Issue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IndentNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IssueDepartment).HasColumnName("Issue_Department");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<StoreIssueSub>(entity =>
            {
                entity.ToTable("Store_Issue_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.IssueNo).HasColumnName("Issue_No");

                entity.Property(e => e.IssueRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Reqestedqty)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("reqestedqty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.ToTable("Store_Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.RackNo).HasMaxLength(30);

                entity.Property(e => e.ReOrderLevel).HasColumnName("Re_Order_Level");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<StoreProductCategory>(entity =>
            {
                entity.ToTable("Store_Product_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StoreProductNew>(entity =>
            {
                entity.ToTable("Store_Product_New");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.ManufacturBy)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MatrixDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Matrix_Description");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.RackNo).HasMaxLength(30);

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sale_Rate");

                entity.Property(e => e.StockType).HasColumnName("Stock_Type");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WholeSale).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StoreRequest>(entity =>
            {
                entity.ToTable("Store_Request");

                entity.Property(e => e.StoreRequestId).HasColumnName("StoreRequestID");

                entity.Property(e => e.EnterdBy).HasColumnName("Enterd_By");

                entity.Property(e => e.IsIssued).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.ReqBy).HasMaxLength(50);

                entity.Property(e => e.ReqNo)
                    .HasMaxLength(50)
                    .HasColumnName("Req_No");

                entity.Property(e => e.RequestDepartment).HasColumnName("Request_Department");

                entity.Property(e => e.RequestFrom).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<StoreRequestDetail>(entity =>
            {
                entity.ToTable("Store_Request_Detail");

                entity.Property(e => e.StoreRequestDetailId).HasColumnName("StoreRequestDetailID");

                entity.Property(e => e.IssuedQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.StoreRequestId).HasColumnName("StoreRequestID");
            });

            modelBuilder.Entity<StoreReturn>(entity =>
            {
                entity.ToTable("Store_Return");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IssueNo).HasColumnName("Issue_No");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.ReturnNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Return_No");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<StoreReturnSub>(entity =>
            {
                entity.ToTable("Store_Return_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnId).HasColumnName("Return_ID");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<StoreReturnSupplier>(entity =>
            {
                entity.ToTable("Store_Return_Supplier");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.IssueNo).HasColumnName("Issue_No");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.ReturnNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Return_No");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<StoreReturnSupplierSub>(entity =>
            {
                entity.ToTable("Store_Return_Supplier_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnId).HasColumnName("Return_ID");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<StoreSupplierPayment>(entity =>
            {
                entity.ToTable("StoreSupplier_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("Payment_Mode");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<SubLedger>(entity =>
            {
                entity.ToTable("Sub_Ledger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.Particulers).HasMaxLength(250);

                entity.Property(e => e.SubLedgerHeadId).HasColumnName("Sub_Ledger_Head_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<SupplierBankPayment>(entity =>
            {
                entity.ToTable("Supplier_Bank_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("Cheque_No");

                entity.Property(e => e.SupplierPaymentId).HasColumnName("Supplier_Payment_ID");
            });

            modelBuilder.Entity<SupplierLedger>(entity =>
            {
                entity.ToTable("Supplier_Ledger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.SupplierPaymentId).HasColumnName("Supplier_Payment_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<SupplierPayment>(entity =>
            {
                entity.ToTable("Supplier_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("Payment_Mode");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<SupplierPharmacy>(entity =>
            {
                entity.ToTable("Supplier_Pharmacy");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<SupplierStore>(entity =>
            {
                entity.ToTable("Supplier_Store");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<SystemSubHead>(entity =>
            {
                entity.ToTable("System_Sub_Head");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CoyId).HasColumnName("Coy_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NoteSlno).HasColumnName("Note_SLNo");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.SystemHeadId).HasColumnName("System_Head_ID");
            });

            modelBuilder.Entity<TblAddTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_AddTime");

                entity.Property(e => e.Endtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("endtime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Latetime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("latetime");

                entity.Property(e => e.Starttime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("starttime");
            });

            modelBuilder.Entity<TblCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CC");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDiagnosis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Diagnosis");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_HO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOccupation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Occupation");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_OE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPaymentMode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Payment_Mode");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<TblRoleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_role_detail");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.TaskId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TblRoleMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_role_master");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_name");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<TblTaskMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_task_master");

                entity.Property(e => e.ForAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOR_ALL");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parentID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("task_name");

                entity.Property(e => e.Text)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<TblUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Unit");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_USER");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CircleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIRCLE_ID");

                entity.Property(e => e.DivisionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIVISION_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_PASSWORD");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.ZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<TblYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Year");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("year");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining_Date");

                entity.Property(e => e.MechineId).HasColumnName("Mechine_ID");
            });

            modelBuilder.Entity<TempService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_Service");

                entity.Property(e => e.DisAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Test_ID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Test_Name");

                entity.Property(e => e.VatAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.ToTable("Ticket_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TmpAttnTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpAttnTable");

                entity.Property(e => e.AttendanceStatus)
                    .HasMaxLength(1)
                    .HasColumnName("Attendance_Status");

                entity.Property(e => e.AttnDate).HasColumnType("date");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LateBy).HasColumnName("Late_By");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.SensorId)
                    .HasMaxLength(10)
                    .HasColumnName("SensorID");

                entity.Property(e => e.ShiftInTime).HasColumnName("Shift_In_Time");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkDuration).HasColumnName("Work_Duration");
            });

            modelBuilder.Entity<TmpBuyRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpBuyRate");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<TmpBuyRateZ>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpBuyRateZ");

                entity.Property(e => e.BuyRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Buy_Rate");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<TmpEmpSal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpEmpSal");

                entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DA");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.DesignationName).HasMaxLength(50);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.HouseRent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("House_Rent");

                entity.Property(e => e.Medical).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Special).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TA");

                entity.Property(e => e.Washing).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TmpIssueRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpIssueRate");

                entity.Property(e => e.IssueRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<TmpIssueRateZ>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpIssueRateZ");

                entity.Property(e => e.IssueRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<TmpNumber>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tmptrial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmptrial");

                entity.Property(e => e.BalanceTotal).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.BsHeadId).HasColumnName("BS_Head_ID");

                entity.Property(e => e.BsHeadName)
                    .HasMaxLength(50)
                    .HasColumnName("BS_Head_Name");

                entity.Property(e => e.CreditTotal).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.DebitTotal).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MasterHead).HasMaxLength(50);

                entity.Property(e => e.NoteSlno).HasColumnName("Note_SLNo");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.SubHead)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TreatmentSheetMedicine>(entity =>
            {
                entity.ToTable("TreatmentSheetMedicine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.EnteredBy).HasColumnName("Entered_By");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_No");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<TreatmentSheetMedicineSub>(entity =>
            {
                entity.ToTable("TreatmentSheetMedicine_Sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Delivered).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeliveryBy)
                    .HasMaxLength(50)
                    .HasColumnName("Delivery_By");

                entity.Property(e => e.DeliveryDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Delivery_DT");

                entity.Property(e => e.DoseStartTimeId).HasColumnName("DoseStartTimeID");

                entity.Property(e => e.DoseTimeId).HasColumnName("Dose_Time_ID");

                entity.Property(e => e.IndentNo).HasColumnName("Indent_No");

                entity.Property(e => e.MedicineTypeId).HasColumnName("Medicine_Type_ID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");
            });

            modelBuilder.Entity<TreatmentSheetMedicineUsed>(entity =>
            {
                entity.ToTable("TreatmentSheetMedicine_Used");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckedBy).HasMaxLength(50);

                entity.Property(e => e.CheckedDate).HasColumnType("datetime");

                entity.Property(e => e.Dose).HasMaxLength(50);

                entity.Property(e => e.IndentNo).HasColumnName("Indent_No");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.Slno).HasColumnName("SLNO");

                entity.Property(e => e.Used).HasMaxLength(50);

                entity.Property(e => e.UsedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Used_By");

                entity.Property(e => e.UsedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Used_DT");
            });

            modelBuilder.Entity<Tube>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tube");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Upzilla>(entity =>
            {
                entity.ToTable("Upzilla");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("User_Group");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<VServiceCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Service_Category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsPercentage).HasColumnName("Is_Percentage");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

                entity.Property(e => e.ParentCategoryName).HasMaxLength(200);

                entity.Property(e => e.ServiceCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Service_Charge");

                entity.Property(e => e.SubId).HasColumnName("Sub_id");
            });

            modelBuilder.Entity<Village>(entity =>
            {
                entity.HasKey(e => e.Villid);

                entity.ToTable("village");

                entity.Property(e => e.Villid).HasColumnName("villid");

                entity.Property(e => e.Upzillaid).HasColumnName("upzillaid");

                entity.Property(e => e.Villname)
                    .HasMaxLength(150)
                    .HasColumnName("villname");
            });

            modelBuilder.Entity<VisitingTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VisitingTime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.VisitingTime1).HasColumnName("VisitingTime");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.ToTable("Voucher");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.CoyId)
                    .HasColumnName("Coy_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EnteredBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Entered_By");

                entity.Property(e => e.IsPosted).HasColumnName("Is_Posted");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TranType).HasMaxLength(10);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<VoucherDetail>(entity =>
            {
                entity.ToTable("Voucher_Detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.ParentHeadId).HasColumnName("Parent_Head_ID");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.SubLedgerHeadId).HasColumnName("Sub_Ledger_Head_ID");

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Voucher_NO");
            });

            modelBuilder.Entity<WorkShiftEmployee>(entity =>
            {
                entity.ToTable("WorkShiftEmployee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.MonthDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkingShift>(entity =>
            {
                entity.ToTable("Working_Shift");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GeneralShift).HasDefaultValueSql("((0))");

                entity.Property(e => e.InTime).HasColumnName("In_Time");

                entity.Property(e => e.IsNightShift).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OutTime).HasColumnName("Out_Time");

                entity.Property(e => e.ShiftDept).HasColumnName("Shift_Dept");

                entity.Property(e => e.Shifting).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
