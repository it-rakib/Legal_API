using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CoreERPContext : DbContext
    {
        public CoreERPContext()
        {
        }

        public CoreERPContext(DbContextOptions<CoreERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApprovalProcessEmployeeTour> ApprovalProcessEmployeeTours { get; set; }
        public virtual DbSet<ApprovalProcessLeaveRegister> ApprovalProcessLeaveRegisters { get; set; }
        public virtual DbSet<ApprovalProcessOfficialInOut> ApprovalProcessOfficialInOuts { get; set; }
        public virtual DbSet<AttendanceActionStatus> AttendanceActionStatuses { get; set; }
        public virtual DbSet<AttendanceDailyAttendance> AttendanceDailyAttendances { get; set; }
        public virtual DbSet<AttendanceDailyAttendanceBak> AttendanceDailyAttendanceBaks { get; set; }
        public virtual DbSet<AttendanceDailyAttendanceCompliance> AttendanceDailyAttendanceCompliances { get; set; }
        public virtual DbSet<AttendanceDailyAttendanceThird> AttendanceDailyAttendanceThirds { get; set; }
        public virtual DbSet<AttendanceDailyPunchRecord> AttendanceDailyPunchRecords { get; set; }
        public virtual DbSet<AttendanceDailyPunchRecord2022> AttendanceDailyPunchRecord2022s { get; set; }
        public virtual DbSet<AttendanceEmployeeInMaternity> AttendanceEmployeeInMaternities { get; set; }
        public virtual DbSet<AttendanceEmployeeRosterDetail> AttendanceEmployeeRosterDetails { get; set; }
        public virtual DbSet<AttendanceEmployeeShift> AttendanceEmployeeShifts { get; set; }
        public virtual DbSet<AttendanceEmployeeTour> AttendanceEmployeeTours { get; set; }
        public virtual DbSet<AttendanceEmployeeWeekOff> AttendanceEmployeeWeekOffs { get; set; }
        public virtual DbSet<AttendanceEmployeeWeekOffAlt> AttendanceEmployeeWeekOffAlts { get; set; }
        public virtual DbSet<AttendanceForceAbsent> AttendanceForceAbsents { get; set; }
        public virtual DbSet<AttendanceForceStopAllowance> AttendanceForceStopAllowances { get; set; }
        public virtual DbSet<AttendanceForceWeeklyOff> AttendanceForceWeeklyOffs { get; set; }
        public virtual DbSet<AttendanceForceWeeklyOffAll> AttendanceForceWeeklyOffAlls { get; set; }
        public virtual DbSet<AttendanceGeneralDuty> AttendanceGeneralDuties { get; set; }
        public virtual DbSet<AttendanceGeneralDutyAll> AttendanceGeneralDutyAlls { get; set; }
        public virtual DbSet<AttendanceGraceTime> AttendanceGraceTimes { get; set; }
        public virtual DbSet<AttendanceGraceTimeByDevice> AttendanceGraceTimeByDevices { get; set; }
        public virtual DbSet<AttendanceLatePermission> AttendanceLatePermissions { get; set; }
        public virtual DbSet<AttendanceLeaveRegister> AttendanceLeaveRegisters { get; set; }
        public virtual DbSet<AttendanceLockDay> AttendanceLockDays { get; set; }
        public virtual DbSet<AttendanceNonPunchEmployee> AttendanceNonPunchEmployees { get; set; }
        public virtual DbSet<AttendanceOfficialInOut> AttendanceOfficialInOuts { get; set; }
        public virtual DbSet<AttendanceOtadjustment> AttendanceOtadjustments { get; set; }
        public virtual DbSet<AttendanceProcessQueue> AttendanceProcessQueues { get; set; }
        public virtual DbSet<AttendanceProcessSetupOt> AttendanceProcessSetupOts { get; set; }
        public virtual DbSet<AttendanceProcessSetupWo> AttendanceProcessSetupWos { get; set; }
        public virtual DbSet<AttendanceRamadanUnitWiseShift> AttendanceRamadanUnitWiseShifts { get; set; }
        public virtual DbSet<AttendanceStatus> AttendanceStatuses { get; set; }
        public virtual DbSet<AttendanceTerminalInformation> AttendanceTerminalInformations { get; set; }
        public virtual DbSet<AttendanceUnitWiseShift> AttendanceUnitWiseShifts { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<CanteenTokenPrintHistory> CanteenTokenPrintHistories { get; set; }
        public virtual DbSet<ClearanceApprovalAccess> ClearanceApprovalAccesses { get; set; }
        public virtual DbSet<ClearanceParticular> ClearanceParticulars { get; set; }
        public virtual DbSet<CommonAdjustmentType> CommonAdjustmentTypes { get; set; }
        public virtual DbSet<CommonBank> CommonBanks { get; set; }
        public virtual DbSet<CommonBloodGroup> CommonBloodGroups { get; set; }
        public virtual DbSet<CommonBoard> CommonBoards { get; set; }
        public virtual DbSet<CommonBranch> CommonBranches { get; set; }
        public virtual DbSet<CommonCompany> CommonCompanies { get; set; }
        public virtual DbSet<CommonCountry> CommonCountries { get; set; }
        public virtual DbSet<CommonCurrency> CommonCurrencies { get; set; }
        public virtual DbSet<CommonDegree> CommonDegrees { get; set; }
        public virtual DbSet<CommonDepartment> CommonDepartments { get; set; }
        public virtual DbSet<CommonDesignation> CommonDesignations { get; set; }
        public virtual DbSet<CommonDesignationGrade> CommonDesignationGrades { get; set; }
        public virtual DbSet<CommonDesignationGroup> CommonDesignationGroups { get; set; }
        public virtual DbSet<CommonDesignationSpecification> CommonDesignationSpecifications { get; set; }
        public virtual DbSet<CommonDistrict> CommonDistricts { get; set; }
        public virtual DbSet<CommonDivision> CommonDivisions { get; set; }
        public virtual DbSet<CommonEmploymentCategory> CommonEmploymentCategories { get; set; }
        public virtual DbSet<CommonEmploymentStatus> CommonEmploymentStatuses { get; set; }
        public virtual DbSet<CommonEmploymentType> CommonEmploymentTypes { get; set; }
        public virtual DbSet<CommonGadgetType> CommonGadgetTypes { get; set; }
        public virtual DbSet<CommonGender> CommonGenders { get; set; }
        public virtual DbSet<CommonGrade> CommonGrades { get; set; }
        public virtual DbSet<CommonInOut> CommonInOuts { get; set; }
        public virtual DbSet<CommonJobBand> CommonJobBands { get; set; }
        public virtual DbSet<CommonJobLocation> CommonJobLocations { get; set; }
        public virtual DbSet<CommonLeaveType> CommonLeaveTypes { get; set; }
        public virtual DbSet<CommonLineCategory> CommonLineCategories { get; set; }
        public virtual DbSet<CommonMaritalStatus> CommonMaritalStatuses { get; set; }
        public virtual DbSet<CommonMotherCompany> CommonMotherCompanies { get; set; }
        public virtual DbSet<CommonNationality> CommonNationalities { get; set; }
        public virtual DbSet<CommonPaymentMode> CommonPaymentModes { get; set; }
        public virtual DbSet<CommonPosition> CommonPositions { get; set; }
        public virtual DbSet<CommonRelationship> CommonRelationships { get; set; }
        public virtual DbSet<CommonReligion> CommonReligions { get; set; }
        public virtual DbSet<CommonRosterShift> CommonRosterShifts { get; set; }
        public virtual DbSet<CommonSection> CommonSections { get; set; }
        public virtual DbSet<CommonShift> CommonShifts { get; set; }
        public virtual DbSet<CommonShiftDtl> CommonShiftDtls { get; set; }
        public virtual DbSet<CommonShiftType> CommonShiftTypes { get; set; }
        public virtual DbSet<CommonTeam> CommonTeams { get; set; }
        public virtual DbSet<CommonThana> CommonThanas { get; set; }
        public virtual DbSet<CommonTour> CommonTours { get; set; }
        public virtual DbSet<CommonUnit> CommonUnits { get; set; }
        public virtual DbSet<CommonUnitType> CommonUnitTypes { get; set; }
        public virtual DbSet<CommonWeekOff> CommonWeekOffs { get; set; }
        public virtual DbSet<CommonWing> CommonWings { get; set; }
        public virtual DbSet<CommonZone> CommonZones { get; set; }
        public virtual DbSet<ConferenceEvent> ConferenceEvents { get; set; }
        public virtual DbSet<ConferenceEventParticipate> ConferenceEventParticipates { get; set; }
        public virtual DbSet<ConferenceRoom> ConferenceRooms { get; set; }
        public virtual DbSet<DesignationAllFactory> DesignationAllFactories { get; set; }
        public virtual DbSet<EldeductionDate> EldeductionDates { get; set; }
        public virtual DbSet<EmailSend> EmailSends { get; set; }
        public virtual DbSet<EmpLateMail> EmpLateMails { get; set; }
        public virtual DbSet<EmployeeClearanceD> EmployeeClearanceDs { get; set; }
        public virtual DbSet<EmployeeClearanceM> EmployeeClearanceMs { get; set; }
        public virtual DbSet<EmployeeContractInfo> EmployeeContractInfos { get; set; }
        public virtual DbSet<EmployeeHistoryLogCategoryChange> EmployeeHistoryLogCategoryChanges { get; set; }
        public virtual DbSet<EmployeeHistoryLogIncrement> EmployeeHistoryLogIncrements { get; set; }
        public virtual DbSet<EmployeeHistoryLogIncrementB> EmployeeHistoryLogIncrementBs { get; set; }
        public virtual DbSet<EmployeeHistoryLogIncrementBakHk> EmployeeHistoryLogIncrementBakHks { get; set; }
        public virtual DbSet<EmployeeHistoryLogJobLocation> EmployeeHistoryLogJobLocations { get; set; }
        public virtual DbSet<EmployeeHistoryLogPromotion> EmployeeHistoryLogPromotions { get; set; }
        public virtual DbSet<EmployeeHistoryLogTaxation> EmployeeHistoryLogTaxations { get; set; }
        public virtual DbSet<EmployeeHistoryLogTransfer> EmployeeHistoryLogTransfers { get; set; }
        public virtual DbSet<EmployeeIncrementInfo> EmployeeIncrementInfos { get; set; }
        public virtual DbSet<EmployeeIncrementInfoB> EmployeeIncrementInfoBs { get; set; }
        public virtual DbSet<EmployeeIncrementInfoBakHk> EmployeeIncrementInfoBakHks { get; set; }
        public virtual DbSet<EmployeeIncrementProposal> EmployeeIncrementProposals { get; set; }
        public virtual DbSet<EmployeeJobConfirmation> EmployeeJobConfirmations { get; set; }
        public virtual DbSet<EmployeePromotionInfo> EmployeePromotionInfos { get; set; }
        public virtual DbSet<EmployeeTransferInfo> EmployeeTransferInfos { get; set; }
        public virtual DbSet<FactoryCompany> FactoryCompanies { get; set; }
        public virtual DbSet<FactoryDepartment> FactoryDepartments { get; set; }
        public virtual DbSet<FactoryDesignation> FactoryDesignations { get; set; }
        public virtual DbSet<FactorySection> FactorySections { get; set; }
        public virtual DbSet<FactoryUnit> FactoryUnits { get; set; }
        public virtual DbSet<FinalSattlementPayable> FinalSattlementPayables { get; set; }
        public virtual DbSet<FinalSattlementPayableCompliance> FinalSattlementPayableCompliances { get; set; }
        public virtual DbSet<FinalSattlementPayableThird> FinalSattlementPayableThirds { get; set; }
        public virtual DbSet<ForgorPassword> ForgorPasswords { get; set; }
        public virtual DbSet<GetAllEmp> GetAllEmps { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<HolidayAllocateEmployeeWise> HolidayAllocateEmployeeWises { get; set; }
        public virtual DbSet<HolidayAllocateReligionWise> HolidayAllocateReligionWises { get; set; }
        public virtual DbSet<HolidayDetail> HolidayDetails { get; set; }
        public virtual DbSet<HrmMode> HrmModes { get; set; }
        public virtual DbSet<HrmModeByUser> HrmModeByUsers { get; set; }
        public virtual DbSet<HrmModeSetup> HrmModeSetups { get; set; }
        public virtual DbSet<HumanResourceApproverDetail> HumanResourceApproverDetails { get; set; }
        public virtual DbSet<HumanResourceAuthorizedManpower> HumanResourceAuthorizedManpowers { get; set; }
        public virtual DbSet<HumanResourceAuthorizedManpowerLog> HumanResourceAuthorizedManpowerLogs { get; set; }
        public virtual DbSet<HumanResourceEmployeeBasic> HumanResourceEmployeeBasics { get; set; }
        public virtual DbSet<HumanResourceEmployeeBasicThird> HumanResourceEmployeeBasicThirds { get; set; }
        public virtual DbSet<HumanResourceEmployeeContact> HumanResourceEmployeeContacts { get; set; }
        public virtual DbSet<HumanResourceEmployeeDrivingLicense> HumanResourceEmployeeDrivingLicenses { get; set; }
        public virtual DbSet<HumanResourceEmployeeEducation> HumanResourceEmployeeEducations { get; set; }
        public virtual DbSet<HumanResourceEmployeeJobStatus> HumanResourceEmployeeJobStatuses { get; set; }
        public virtual DbSet<HumanResourceEmployeeNominee> HumanResourceEmployeeNominees { get; set; }
        public virtual DbSet<HumanResourceEmployeePassport> HumanResourceEmployeePassports { get; set; }
        public virtual DbSet<HumanResourceEmployeePhoto> HumanResourceEmployeePhotos { get; set; }
        public virtual DbSet<HumanResourceEmployeeReference> HumanResourceEmployeeReferences { get; set; }
        public virtual DbSet<HumanResourceEmployeeSeparation> HumanResourceEmployeeSeparations { get; set; }
        public virtual DbSet<HumanResourceEmployeeTraining> HumanResourceEmployeeTrainings { get; set; }
        public virtual DbSet<IdcardRegistration> IdcardRegistrations { get; set; }
        public virtual DbSet<InTransitProcess> InTransitProcesses { get; set; }
        public virtual DbSet<IncrementType> IncrementTypes { get; set; }
        public virtual DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public virtual DbSet<LeaveAllocationBak> LeaveAllocationBaks { get; set; }
        public virtual DbSet<LeaveAllocationMaster> LeaveAllocationMasters { get; set; }
        public virtual DbSet<LeaveApproverUnitPermission> LeaveApproverUnitPermissions { get; set; }
        public virtual DbSet<LeaveDeduction> LeaveDeductions { get; set; }
        public virtual DbSet<LeaveDeductionType> LeaveDeductionTypes { get; set; }
        public virtual DbSet<LetterPrintHistory> LetterPrintHistories { get; set; }
        public virtual DbSet<LoanType> LoanTypes { get; set; }
        public virtual DbSet<LogCompanyNameChange> LogCompanyNameChanges { get; set; }
        public virtual DbSet<LogUnitNameChange> LogUnitNameChanges { get; set; }
        public virtual DbSet<OgranogramApplicationsApproval> OgranogramApplicationsApprovals { get; set; }
        public virtual DbSet<OrgAssignDepartmentToDepartmentHead> OrgAssignDepartmentToDepartmentHeads { get; set; }
        public virtual DbSet<OrganizationOrganogram> OrganizationOrganograms { get; set; }
        public virtual DbSet<OutOfLayOffEmployeeList> OutOfLayOffEmployeeLists { get; set; }
        public virtual DbSet<PaAppraisalComment> PaAppraisalComments { get; set; }
        public virtual DbSet<PaBehaviorFactor> PaBehaviorFactors { get; set; }
        public virtual DbSet<PaFactorDescription> PaFactorDescriptions { get; set; }
        public virtual DbSet<PaJdDescription> PaJdDescriptions { get; set; }
        public virtual DbSet<PaMaster> PaMasters { get; set; }
        public virtual DbSet<PaOvarallRating> PaOvarallRatings { get; set; }
        public virtual DbSet<PaPerformanceEvaluation> PaPerformanceEvaluations { get; set; }
        public virtual DbSet<PaProbationRecommendation> PaProbationRecommendations { get; set; }
        public virtual DbSet<PaPromotionRecommendation> PaPromotionRecommendations { get; set; }
        public virtual DbSet<PaReDesignatedRecommendation> PaReDesignatedRecommendations { get; set; }
        public virtual DbSet<PaRecommendationComment> PaRecommendationComments { get; set; }
        public virtual DbSet<PaRecommendationMaster> PaRecommendationMasters { get; set; }
        public virtual DbSet<PaSalaryAdjustment> PaSalaryAdjustments { get; set; }
        public virtual DbSet<PaySlipOpen> PaySlipOpens { get; set; }
        public virtual DbSet<PayrollAllowanceByDesGroup> PayrollAllowanceByDesGroups { get; set; }
        public virtual DbSet<PayrollAnnualLeavePayment> PayrollAnnualLeavePayments { get; set; }
        public virtual DbSet<PayrollBasicSalaryInfoLog> PayrollBasicSalaryInfoLogs { get; set; }
        public virtual DbSet<PayrollCostHead> PayrollCostHeads { get; set; }
        public virtual DbSet<PayrollCurrencyConversion> PayrollCurrencyConversions { get; set; }
        public virtual DbSet<PayrollDistanceAllowance> PayrollDistanceAllowances { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalary> PayrollEmployeeBasicSalaries { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalaryB> PayrollEmployeeBasicSalaryBs { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalaryDetail> PayrollEmployeeBasicSalaryDetails { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalaryDetailsB> PayrollEmployeeBasicSalaryDetailsBs { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalaryDetailsNew> PayrollEmployeeBasicSalaryDetailsNews { get; set; }
        public virtual DbSet<PayrollEmployeeBasicSalaryDetailsNewB> PayrollEmployeeBasicSalaryDetailsNewBs { get; set; }
        public virtual DbSet<PayrollEmployeeLoan> PayrollEmployeeLoans { get; set; }
        public virtual DbSet<PayrollEmployeeLoanInstallment> PayrollEmployeeLoanInstallments { get; set; }
        public virtual DbSet<PayrollEmployeePayrollAdjustment> PayrollEmployeePayrollAdjustments { get; set; }
        public virtual DbSet<PayrollEmployeePayrollAdjustmentTemp> PayrollEmployeePayrollAdjustmentTemps { get; set; }
        public virtual DbSet<PayrollEmployeePf> PayrollEmployeePfs { get; set; }
        public virtual DbSet<PayrollEmployeePfdeduction> PayrollEmployeePfdeductions { get; set; }
        public virtual DbSet<PayrollEmployeeTaxation> PayrollEmployeeTaxations { get; set; }
        public virtual DbSet<PayrollEmployeeWiseAllowance> PayrollEmployeeWiseAllowances { get; set; }
        public virtual DbSet<PayrollEmployeeWiseAllowanceB> PayrollEmployeeWiseAllowanceBs { get; set; }
        public virtual DbSet<PayrollEmployeeWiseAllowanceDX> PayrollEmployeeWiseAllowanceDXes { get; set; }
        public virtual DbSet<PayrollEmployeeWiseAllowanceMX> PayrollEmployeeWiseAllowanceMXes { get; set; }
        public virtual DbSet<PayrollFestivalBonu> PayrollFestivalBonus { get; set; }
        public virtual DbSet<PayrollFormula> PayrollFormulas { get; set; }
        public virtual DbSet<PayrollFormulaStructure> PayrollFormulaStructures { get; set; }
        public virtual DbSet<PayrollGradeWiseAllowanceD> PayrollGradeWiseAllowanceDs { get; set; }
        public virtual DbSet<PayrollGradeWiseAllowanceM> PayrollGradeWiseAllowanceMs { get; set; }
        public virtual DbSet<PayrollHourlySalary> PayrollHourlySalaries { get; set; }
        public virtual DbSet<PayrollMailSendStatus> PayrollMailSendStatuses { get; set; }
        public virtual DbSet<PayrollMaternityPay> PayrollMaternityPays { get; set; }
        public virtual DbSet<PayrollMonthlyArear> PayrollMonthlyArears { get; set; }
        public virtual DbSet<PayrollMonthlyArearCompliance> PayrollMonthlyArearCompliances { get; set; }
        public virtual DbSet<PayrollMonthlyArearThird> PayrollMonthlyArearThirds { get; set; }
        public virtual DbSet<PayrollMonthlyPayrollStop> PayrollMonthlyPayrollStops { get; set; }
        public virtual DbSet<PayrollMonthlySalary> PayrollMonthlySalaries { get; set; }
        public virtual DbSet<PayrollMonthlySalaryAdvance> PayrollMonthlySalaryAdvances { get; set; }
        public virtual DbSet<PayrollMonthlySalaryAdvanceCompliance> PayrollMonthlySalaryAdvanceCompliances { get; set; }
        public virtual DbSet<PayrollMonthlySalaryAdvanceThird> PayrollMonthlySalaryAdvanceThirds { get; set; }
        public virtual DbSet<PayrollMonthlySalaryAdvancebak> PayrollMonthlySalaryAdvancebaks { get; set; }
        public virtual DbSet<PayrollMonthlySalaryBak> PayrollMonthlySalaryBaks { get; set; }
        public virtual DbSet<PayrollMonthlySalaryCompliance> PayrollMonthlySalaryCompliances { get; set; }
        public virtual DbSet<PayrollMonthlySalarySampleJanuary> PayrollMonthlySalarySampleJanuaries { get; set; }
        public virtual DbSet<PayrollMonthlySalarySupplementary> PayrollMonthlySalarySupplementaries { get; set; }
        public virtual DbSet<PayrollMonthlySalarySupplementaryApr> PayrollMonthlySalarySupplementaryAprs { get; set; }
        public virtual DbSet<PayrollMonthlySalaryThird> PayrollMonthlySalaryThirds { get; set; }
        public virtual DbSet<PayrollPayrollStopType> PayrollPayrollStopTypes { get; set; }
        public virtual DbSet<PayrollSalaryHead> PayrollSalaryHeads { get; set; }
        public virtual DbSet<PayrollType> PayrollTypes { get; set; }
        public virtual DbSet<PmsReviewOrganogram> PmsReviewOrganograms { get; set; }
        public virtual DbSet<PmsReviewShedule> PmsReviewShedules { get; set; }
        public virtual DbSet<PmsReviewerRating> PmsReviewerRatings { get; set; }
        public virtual DbSet<ProcessLock> ProcessLocks { get; set; }
        public virtual DbSet<RDepDesignation> RDepDesignations { get; set; }
        public virtual DbSet<RDeptSection> RDeptSections { get; set; }
        public virtual DbSet<RSecWing> RSecWings { get; set; }
        public virtual DbSet<RUnitDept> RUnitDepts { get; set; }
        public virtual DbSet<RWingTeam> RWingTeams { get; set; }
        public virtual DbSet<Ramadan> Ramadans { get; set; }
        public virtual DbSet<RecruitmentCandidate> RecruitmentCandidates { get; set; }
        public virtual DbSet<RecruitmentVacancy> RecruitmentVacancies { get; set; }
        public virtual DbSet<ReportDailyOperationCost> ReportDailyOperationCosts { get; set; }
        public virtual DbSet<SignalRChatDetail> SignalRChatDetails { get; set; }
        public virtual DbSet<TaxYear> TaxYears { get; set; }
        public virtual DbSet<TaxationAllowedInvestment> TaxationAllowedInvestments { get; set; }
        public virtual DbSet<TaxationEmployeeInvestment> TaxationEmployeeInvestments { get; set; }
        public virtual DbSet<TaxationInvestmentSchedule> TaxationInvestmentSchedules { get; set; }
        public virtual DbSet<TaxationTaxPayableBeforeInvestment> TaxationTaxPayableBeforeInvestments { get; set; }
        public virtual DbSet<TaxationTaxPayeeCategory> TaxationTaxPayeeCategories { get; set; }
        public virtual DbSet<TaxationTaxYear> TaxationTaxYears { get; set; }
        public virtual DbSet<TempAlPayment> TempAlPayments { get; set; }
        public virtual DbSet<TempAllowance> TempAllowances { get; set; }
        public virtual DbSet<TempDistanceAllowance> TempDistanceAllowances { get; set; }
        public virtual DbSet<TempElpay> TempElpays { get; set; }
        public virtual DbSet<TempIncrement> TempIncrements { get; set; }
        public virtual DbSet<TempMobilebillDeduction> TempMobilebillDeductions { get; set; }
        public virtual DbSet<TempPabx> TempPabxes { get; set; }
        public virtual DbSet<TempPfdeduction> TempPfdeductions { get; set; }
        public virtual DbSet<TempPunchRecord> TempPunchRecords { get; set; }
        public virtual DbSet<TempTaxInfo> TempTaxInfos { get; set; }
        public virtual DbSet<TempTrn> TempTrns { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test1> Test1s { get; set; }
        public virtual DbSet<UnitWiseLetterAcceptPermission> UnitWiseLetterAcceptPermissions { get; set; }
        public virtual DbSet<UserCompanyPermission> UserCompanyPermissions { get; set; }
        public virtual DbSet<UserDepartmentPermission> UserDepartmentPermissions { get; set; }
        public virtual DbSet<UserSectionPermission> UserSectionPermissions { get; set; }
        public virtual DbSet<UserTeamPermission> UserTeamPermissions { get; set; }
        public virtual DbSet<UserUnitPermission> UserUnitPermissions { get; set; }
        public virtual DbSet<UserWingPermission> UserWingPermissions { get; set; }
        public virtual DbSet<ViewEmpNoFromHoff> ViewEmpNoFromHoffs { get; set; }
        public virtual DbSet<VwEmployeeContact> VwEmployeeContacts { get; set; }
        public virtual DbSet<VwEmployeeEff> VwEmployeeEffs { get; set; }
        public virtual DbSet<VwEmployeeInfo> VwEmployeeInfos { get; set; }
        public virtual DbSet<VwEmployeeInfoDetail> VwEmployeeInfoDetails { get; set; }
        public virtual DbSet<VwPabxinfo> VwPabxinfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApprovalProcessEmployeeTour>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApprovalProcess_EmployeeTour");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Sdid).HasColumnName("SDId");
            });

            modelBuilder.Entity<ApprovalProcessLeaveRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApprovalProcess_LeaveRegister");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Lrid).HasColumnName("LRId");

                entity.Property(e => e.Lrpid).HasColumnName("LRPId");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<ApprovalProcessOfficialInOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApprovalProcess_OfficialInOut");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ioid).HasColumnName("IOId");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceActionStatus>(entity =>
            {
                entity.HasKey(e => e.ActionStatusId)
                    .HasName("PK_Attendance.LeaveStatus");

                entity.ToTable("Attendance_ActionStatus");

                entity.Property(e => e.ActionStatusId).ValueGeneratedNever();

                entity.Property(e => e.ActionStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AttendanceDailyAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_DailyAttendance");

                entity.HasIndex(e => new { e.WorkDay, e.EmpId }, "_dta_index_Attendance.DailyAttendance_5_985770569__K9_K1");

                entity.HasIndex(e => new { e.EmpId, e.WorkDay }, "_dta_index_Attendance_DailyAttendance_c_6_1313439753__K1_K9")
                    .IsClustered();

                entity.Property(e => e.AttStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.InDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InDeviceID");

                entity.Property(e => e.InRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LunchInTime).HasColumnType("datetime");

                entity.Property(e => e.LunchOutTime).HasColumnType("datetime");

                entity.Property(e => e.OtHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OutDeviceID");

                entity.Property(e => e.OutRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceDailyAttendanceBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_DailyAttendance_Bak");

                entity.Property(e => e.AttStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.InDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InDeviceID");

                entity.Property(e => e.InRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LunchInTime).HasColumnType("datetime");

                entity.Property(e => e.LunchOutTime).HasColumnType("datetime");

                entity.Property(e => e.OtHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OutDeviceID");

                entity.Property(e => e.OutRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceDailyAttendanceCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_DailyAttendanceCompliance");

                entity.HasIndex(e => new { e.WorkDay, e.EmpId }, "_dta_index_Attendance_DailyAttendanceCompli_6_1386540073__K9_K1");

                entity.Property(e => e.AttStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.InDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InDeviceID");

                entity.Property(e => e.InRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LunchInTime).HasColumnType("datetime");

                entity.Property(e => e.LunchOutTime).HasColumnType("datetime");

                entity.Property(e => e.OtHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OutDeviceID");

                entity.Property(e => e.OutRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceDailyAttendanceThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_DailyAttendanceThird");

                entity.HasIndex(e => new { e.EmpId, e.WorkDay }, "_dta_index_Attendance_DailyAttendanceThird_6_1754541384__K1_K9");

                entity.Property(e => e.AttStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.InDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InDeviceID");

                entity.Property(e => e.InRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LunchInTime).HasColumnType("datetime");

                entity.Property(e => e.LunchOutTime).HasColumnType("datetime");

                entity.Property(e => e.OtHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OutDeviceID");

                entity.Property(e => e.OutRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceDailyPunchRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Attendance_DailyPunchRecord");

                entity.HasIndex(e => new { e.PunchTime, e.PunchNo }, "_dta_index_Attendance.DailyPunchRecord_5_978818549__K2_K1_3");

                entity.HasIndex(e => e.DoorMode, "_dta_index_Attendance.DailyPunchRecord_5_978818549__K4");

                entity.HasIndex(e => new { e.PunchNo, e.PunchTime }, "_dta_index_Attendance.DailyPunchRecord_c_5_978818549__K1_K2")
                    .IsClustered();

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DoorMode).HasComment("0=In Mood,1= Out Mood");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.PunchTime).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AttendanceDailyPunchRecord2022>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Attendance_DailyPunchRecord2022");

                entity.HasIndex(e => new { e.PunchNo, e.PunchTime }, "_dta_index_Attendance.DailyPunchRecord_2022_K1_K2")
                    .IsClustered();

                entity.HasIndex(e => new { e.PunchTime, e.PunchNo }, "_dta_index_Attendance.DailyPunchRecord_2022_K2_K1");

                entity.HasIndex(e => e.DoorMode, "_dta_index_Attendance.DailyPunchRecord_2022_K4");

                entity.HasIndex(e => new { e.DoorMode, e.PunchNo, e.PunchTime, e.InActive }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K5_K2_K3_K8");

                entity.HasIndex(e => new { e.DoorMode, e.PunchTime, e.PunchNo, e.InActive }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K5_K3_K2_K8");

                entity.HasIndex(e => new { e.DoorMode, e.InActive, e.PunchNo, e.PunchTime, e.DeviceNo }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K5_K8_K2_K3_K4");

                entity.HasIndex(e => e.InActive, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K8");

                entity.HasIndex(e => new { e.InActive, e.PunchNo, e.PunchTime, e.DeviceNo }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K8_K2_K3_K4");

                entity.HasIndex(e => new { e.InActive, e.PunchTime, e.PunchNo }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K8_K3_K2");

                entity.HasIndex(e => new { e.InActive, e.PunchTime, e.PunchNo, e.DeviceNo }, "_dta_index_Attendance_DailyPunchRecord2022_6_1808113582__K8_K3_K2_K4");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DoorMode).HasComment("0=In Mood,1= Out Mood");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.PunchLocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PunchTime).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("((100))");
            });

            modelBuilder.Entity<AttendanceEmployeeInMaternity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_EmployeeInMaternity");

                entity.Property(e => e.FromDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceEmployeeRosterDetail>(entity =>
            {
                entity.HasKey(e => e.RosterId)
                    .HasName("PK_Attendance_EmployeeRoster");

                entity.ToTable("Attendance_EmployeeRosterDetails");

                entity.HasIndex(e => new { e.EmpId, e.WorkDay }, "_dta_index_Attendance_EmployeeRosterDetails_6_1522156518__K2_K3_4");

                entity.Property(e => e.RosterId).HasColumnName("RosterID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceEmployeeShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_EmployeeShift");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceEmployeeTour>(entity =>
            {
                entity.HasKey(e => e.Sdid)
                    .HasName("PK_Attendance.EmployeeTour");

                entity.ToTable("Attendance_EmployeeTour");

                entity.HasIndex(e => new { e.TourId, e.EmpId, e.StartDate, e.EndDate, e.Status, e.IsDeleted }, "_dta_index_Attendance_EmployeeTour_6_781297893__K3_K2_K4_K5_K9_K11");

                entity.Property(e => e.Sdid).HasColumnName("SDId");

                entity.Property(e => e.AcknowledgedDate).HasColumnType("date");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.IsManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOutOfPolicy).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TourId).HasColumnName("TourID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceEmployeeWeekOff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_EmployeeWeekOff");

                entity.HasIndex(e => new { e.IsDelete, e.EmpId, e.StartDate }, "_dta_index_Attendance_EmployeeWeekOff_6_1001822681__K5_K1_K3_2");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceEmployeeWeekOffAlt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_EmployeeWeekOffAlt");

                entity.Property(e => e.Wodate)
                    .HasColumnType("date")
                    .HasColumnName("WODate");
            });

            modelBuilder.Entity<AttendanceForceAbsent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_ForceAbsent");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.TillDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceForceStopAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_ForceStopAllowance");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StopWo).HasColumnName("StopWO");

                entity.Property(e => e.WorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceForceWeeklyOff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_ForceWeeklyOff");

                entity.HasIndex(e => new { e.EmpId, e.IsActive, e.CurrentHoliday, e.AlterHoliday }, "_dta_index_Attendance_ForceWeeklyOff_6_665157515__K1_K8_K2_K3_4");

                entity.HasIndex(e => new { e.EmpId, e.IsActive, e.CurrentHoliday, e.AlterHoliday, e.Tmood }, "_dta_index_Attendance_ForceWeeklyOff_c_6_665157515__K1_K8_K2_K3_K7")
                    .IsClustered();

                entity.Property(e => e.AlterHoliday).HasColumnType("date");

                entity.Property(e => e.Cmood).HasColumnName("CMood");

                entity.Property(e => e.CurrentHoliday).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWo).HasColumnName("IsWO");

                entity.Property(e => e.Omood)
                    .IsRequired()
                    .HasColumnName("OMood")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Sl)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SL");

                entity.Property(e => e.Tmood).HasColumnName("TMood");
            });

            modelBuilder.Entity<AttendanceForceWeeklyOffAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_ForceWeeklyOffAll");

                entity.Property(e => e.AlterHoliday).HasColumnType("date");

                entity.Property(e => e.Cmood).HasColumnName("CMood");

                entity.Property(e => e.CurrentHoliday).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Omood)
                    .IsRequired()
                    .HasColumnName("OMood")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Sl)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sl");

                entity.Property(e => e.Tmood).HasColumnName("TMood");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<AttendanceGeneralDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_GeneralDuty");

                entity.HasIndex(e => new { e.WorkDay, e.EmpId }, "_dta_index_Attendance_GeneralDuty_c_6_276300144__K2_K1")
                    .IsClustered();

                entity.Property(e => e.Cmood).HasColumnName("CMood");

                entity.Property(e => e.Cwo).HasColumnName("CWo");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Omood).HasColumnName("OMood");

                entity.Property(e => e.Owo).HasColumnName("OWo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Tmood).HasColumnName("TMood");

                entity.Property(e => e.Two).HasColumnName("TWo");

                entity.Property(e => e.WorkDay).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceGeneralDutyAll>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.WorkDay });

                entity.ToTable("Attendance_GeneralDutyAll");

                entity.Property(e => e.WorkDay).HasColumnType("date");

                entity.Property(e => e.Cmood).HasColumnName("CMood");

                entity.Property(e => e.Cwo).HasColumnName("CWo");

                entity.Property(e => e.Omood).HasColumnName("OMood");

                entity.Property(e => e.Owo).HasColumnName("OWo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Tmood).HasColumnName("TMood");

                entity.Property(e => e.Two).HasColumnName("TWo");
            });

            modelBuilder.Entity<AttendanceGraceTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_GraceTime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceGraceTimeByDevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_GraceTimeByDevice");

                entity.Property(e => e.ControllerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ControllerID");

                entity.Property(e => e.DoorMode).HasComment("0=In,1=Out");

                entity.Property(e => e.Sl)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sl");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceLatePermission>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.WorkDay });

                entity.ToTable("Attendance_LatePermission");

                entity.Property(e => e.WorkDay).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceLeaveRegister>(entity =>
            {
                entity.HasKey(e => e.Lrid)
                    .HasName("PK__Attendan__770D1E7729A9AB5A");

                entity.ToTable("Attendance_LeaveRegister");

                entity.HasIndex(e => new { e.EmpId, e.Status, e.LeaveId, e.StartDate, e.EndDate }, "_dta_index_Attendance.LeaveRegister_5_160719625__K3_K11_K4_K5_K6");

                entity.HasIndex(e => new { e.EmpId, e.Status, e.StartDate, e.EndDate, e.IsDeleted, e.LeaveId, e.Lrid }, "_dta_index_Attendance_LeaveRegister_6_2031398356__K3_K11_K5_K6_K19_K4_K1_8");

                entity.Property(e => e.Lrid).HasColumnName("LRId");

                entity.Property(e => e.AcknowledgedDate).HasColumnType("date");

                entity.Property(e => e.Attachment).HasColumnType("image");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteReason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lrpid).HasColumnName("LRPId");

                entity.Property(e => e.NoOfDays).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceLockDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_LockDays");
            });

            modelBuilder.Entity<AttendanceNonPunchEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Attendance_NonPunchEmployee");

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AttendanceOfficialInOut>(entity =>
            {
                entity.HasKey(e => e.Ioid);

                entity.ToTable("Attendance_OfficialInOut");

                entity.HasIndex(e => new { e.InOutDate, e.EmpId, e.Status, e.TypeId, e.IsDeleted, e.EndTime, e.StartTime }, "_dta_index_Attendance_OfficialInOut_6_11915164__K4_K2_K10_K3_K16_K6_K5");

                entity.Property(e => e.Ioid).HasColumnName("IOId");

                entity.Property(e => e.AcknowledgedDate).HasColumnType("date");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteReason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.InOutDate).HasColumnType("date");

                entity.Property(e => e.IsManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOutOfPolicy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceOtadjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_OTAdjustment");

                entity.HasIndex(e => new { e.EmpId, e.AdjustmentTo }, "_dta_index_Attendance_OTAdjustment_6_1725353311__K2_K4_3_5");

                entity.HasIndex(e => new { e.EmpId, e.WorkDate }, "_dta_index_Attendance_OTAdjustment_c_6_1725353311__K2_K3")
                    .IsClustered();

                entity.Property(e => e.AdjustmentTo).HasColumnType("date");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttendanceProcessQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_Process_Queue");

                entity.Property(e => e.Dbname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DBName");

                entity.Property(e => e.IsProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.Property(e => e.PunchDate).HasColumnType("date");

                entity.Property(e => e.QueueId).ValueGeneratedOnAdd();

                entity.Property(e => e.QueuedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AttendanceProcessSetupOt>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.SalaryMonth, e.SalaryYear })
                    .HasName("PK_Attendance_ProcessSetup");

                entity.ToTable("Attendance_ProcessSetupOT");

                entity.Property(e => e.Othour).HasColumnName("OTHour");
            });

            modelBuilder.Entity<AttendanceProcessSetupWo>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.WorkDay })
                    .HasName("PK_AttendanceProcessSetupWO");

                entity.ToTable("Attendance_ProcessSetupWO");

                entity.Property(e => e.WorkDay).HasColumnType("date");

                entity.Property(e => e.Wothour).HasColumnName("WOTHour");
            });

            modelBuilder.Entity<AttendanceRamadanUnitWiseShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_RamadanUnitWiseShift");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Ifbreak).HasColumnName("IFBreak");

                entity.Property(e => e.Iobreak).HasColumnName("IOBreak");

                entity.Property(e => e.Lhbreak).HasColumnName("LHBreak");

                entity.Property(e => e.Ntbreak).HasColumnName("NTBreak");

                entity.Property(e => e.RamadanShiftId).HasColumnName("RamadanShiftID");

                entity.Property(e => e.Shbreak).HasColumnName("SHBreak");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.Sl)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SL");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<AttendanceStatus>(entity =>
            {
                entity.HasKey(e => e.AttStatusId);

                entity.ToTable("Attendance_Status");

                entity.Property(e => e.AttStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttStatusShort)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GraphColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceTerminalInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_TerminalInformation");

                entity.Property(e => e.ControllerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ControllerID");

                entity.Property(e => e.DevId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DevID");

                entity.Property(e => e.DeviceModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasComment("LocationID=JobLocationID");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<AttendanceUnitWiseShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_UnitWiseShift");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("AuditTrail");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditDesc).IsUnicode(false);

                entity.Property(e => e.AuditTask)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EmpIds).IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MacAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RowDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CanteenTokenPrintHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.TokenNo, e.TokenPrintDate });

                entity.ToTable("Canteen_TokenPrintHistory");

                entity.Property(e => e.TokenNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenPrintDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCancel).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ClearanceApprovalAccess>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("ClearanceApprovalAccess");

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.EffectDate).HasColumnType("date");
            });

            modelBuilder.Entity<ClearanceParticular>(entity =>
            {
                entity.HasKey(e => e.ParticularId)
                    .HasName("PK_ClearancePerticular");

                entity.ToTable("ClearanceParticular");

                entity.Property(e => e.ClearingAuthority)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParticularName)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonAdjustmentType>(entity =>
            {
                entity.HasKey(e => e.AdjustmentTypeId)
                    .HasName("PK_Common_DeductionType");

                entity.ToTable("Common_AdjustmentType");

                entity.Property(e => e.AdjustmentTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonBank>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("Common_Bank");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonBloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId)
                    .HasName("PK_Common.BloodGroup");

                entity.ToTable("Common_BloodGroup");

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonBoard>(entity =>
            {
                entity.HasKey(e => e.BoardId)
                    .HasName("PK_Common.Board");

                entity.ToTable("Common_Board");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.BoardName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.ToTable("Common_Branch");

                entity.Property(e => e.AccountFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_Common.Company");

                entity.ToTable("Common_Company");

                entity.HasIndex(e => e.CompanyShortName, "IX_Common_Company")
                    .IsUnique();

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressBan).HasMaxLength(250);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNameBan).HasMaxLength(100);

                entity.Property(e => e.CompanyShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<CommonCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_Common.Country");

                entity.ToTable("Common_Country");

                entity.HasIndex(e => e.CountryName, "IX_Common_Country")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("Common_Currency");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CommonDegree>(entity =>
            {
                entity.HasKey(e => e.DegreeId)
                    .HasName("PK_Common.Degree");

                entity.ToTable("Common_Degree");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeFullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_Common.Department");

                entity.ToTable("Common_Department");

                entity.HasIndex(e => e.DepartmentName, "IX_Common_Department")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNameBan).HasMaxLength(150);

                entity.Property(e => e.DepartmentShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PK_Common.Designation");

                entity.ToTable("Common_Designation");

                entity.HasIndex(e => e.DesignationName, "IX_Common.Designation")
                    .IsUnique();

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesGroupId).HasColumnName("DesGroupID");

                entity.Property(e => e.DesignationName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationNameBan).HasMaxLength(150);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GadgetTypeId).HasComment("1=Gadget , 2=Non Gadget");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType).HasMaxLength(150);
            });

            modelBuilder.Entity<CommonDesignationGrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Common_DesignationGrade");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            });

            modelBuilder.Entity<CommonDesignationGroup>(entity =>
            {
                entity.HasKey(e => e.DesGroupId)
                    .HasName("PK_Common.DesignationGroup");

                entity.ToTable("Common_DesignationGroup");

                entity.Property(e => e.DesGroupId).HasColumnName("DesGroupID");

                entity.Property(e => e.DesGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonDesignationSpecification>(entity =>
            {
                entity.HasKey(e => e.DesignationSpecId)
                    .HasName("PK_Common_DegSpecification");

                entity.ToTable("Common_DesignationSpecification");

                entity.Property(e => e.DesignationSpecification)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DesignationSpecificationBan).HasMaxLength(100);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonDistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_Common.District");

                entity.ToTable("Common_District");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictNameBan).HasMaxLength(50);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK_Common.Division");

                entity.ToTable("Common_Division");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonEmploymentCategory>(entity =>
            {
                entity.HasKey(e => e.EmpCategoryId)
                    .HasName("PK_Common.EmploymentCategory");

                entity.ToTable("Common_EmploymentCategory");

                entity.Property(e => e.EmpCategoryId).HasColumnName("EmpCategoryID");

                entity.Property(e => e.EmpCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCategoryNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonEmploymentStatus>(entity =>
            {
                entity.HasKey(e => e.EmpStatusId)
                    .HasName("PK_Common.EmploymentStatus");

                entity.ToTable("Common_EmploymentStatus");

                entity.Property(e => e.EmpStatusId).HasColumnName("EmpStatusID");

                entity.Property(e => e.EmpStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatusNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonEmploymentType>(entity =>
            {
                entity.HasKey(e => e.EmpTypeId)
                    .HasName("PK_Common.EmploymentType");

                entity.ToTable("Common_EmploymentType");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.EmpTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTypeNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonGadgetType>(entity =>
            {
                entity.HasKey(e => e.GadgetTypeId);

                entity.ToTable("Common_GadgetType");

                entity.Property(e => e.GadgetTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonGender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("PK_Common.Gender");

                entity.ToTable("Common_Gender");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenderNameBan).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonGrade>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("Common_Grade");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommonInOut>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__CommonInOut");

                entity.ToTable("Common_InOut");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonJobBand>(entity =>
            {
                entity.HasKey(e => e.JobBandId);

                entity.ToTable("Common_JobBand");

                entity.Property(e => e.JobBandName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonJobLocation>(entity =>
            {
                entity.HasKey(e => e.JobLocationId);

                entity.ToTable("Common_JobLocation");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobLocationAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocationNameBan).HasMaxLength(50);

                entity.Property(e => e.JobLocationShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonLeaveType>(entity =>
            {
                entity.HasKey(e => e.LeaveId)
                    .HasName("PK__Common.L__796DB959B4B63FD8");

                entity.ToTable("Common_LeaveType");

                entity.Property(e => e.AllowPct)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((100.00))");

                entity.Property(e => e.BasicPct)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((100.00))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LeaveName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyAllocations).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.YearlyAllocations).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<CommonLineCategory>(entity =>
            {
                entity.HasKey(e => e.LineCategoryId);

                entity.ToTable("Common_LineCategory");

                entity.Property(e => e.LineCategoryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId)
                    .HasName("PK_Common.MaritalStatus");

                entity.ToTable("Common_MaritalStatus");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaritalStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonMotherCompany>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_Common.MotherCompany");

                entity.ToTable("Common_MotherCompany");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonNationality>(entity =>
            {
                entity.HasKey(e => e.NationalityId)
                    .HasName("PK_Common.Nationality");

                entity.ToTable("Common_Nationality");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonPaymentMode>(entity =>
            {
                entity.HasKey(e => e.PaymentModeId);

                entity.ToTable("Common_PaymentMode");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentModeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("Common_Position");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("Common_Relationship");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonReligion>(entity =>
            {
                entity.HasKey(e => e.ReligionId)
                    .HasName("PK_Common.Religion");

                entity.ToTable("Common_Religion");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReligionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonRosterShift>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK_Common.RosterShift");

                entity.ToTable("Common_RosterShift");

                entity.Property(e => e.ShiftId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShiftID");

                entity.Property(e => e.ChangeOverShiftId).HasColumnName("ChangeOverShiftID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.IfterTime).HasColumnType("datetime");

                entity.Property(e => e.IsLunch).HasDefaultValueSql("((0))");

                entity.Property(e => e.NightBreakFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightBreakTill).HasColumnType("datetime");

                entity.Property(e => e.NightTime).HasColumnType("datetime");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.ParentShiftId).HasColumnName("ParentShiftID");

                entity.Property(e => e.RamadanShiftId).HasColumnName("RamadanShiftID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SheriBreakFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SheriBreakTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftAbsent).HasColumnType("datetime");

                entity.Property(e => e.ShiftEarly).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftIn).HasColumnType("datetime");

                entity.Property(e => e.ShiftLastPunch).HasColumnType("datetime");

                entity.Property(e => e.ShiftLate).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftOut).HasColumnType("datetime");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TiffinTime).HasColumnType("datetime");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.Workday).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommonSection>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK__Common.Section");

                entity.ToTable("Common_Section");

                entity.HasIndex(e => e.SectionName, "IX_Common_Section")
                    .IsUnique();

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.LineCategory)
                    .HasDefaultValueSql("((0))")
                    .HasComment("If this section is a Line then Line Category= StandardLine=1,MiniLine=2");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNameBan).HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonShift>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK_Common.Shift");

                entity.ToTable("Common_Shift");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.AppShiftId).HasColumnName("AppShiftID");

                entity.Property(e => e.ChangeOverShiftId).HasColumnName("ChangeOverShiftID");

                entity.Property(e => e.Ee)
                    .HasColumnName("EE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Exl)
                    .HasColumnName("EXL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IfterTime).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLunch).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRamadanShift).HasDefaultValueSql("((0))");

                entity.Property(e => e.NightBreakFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightBreakTill).HasColumnType("datetime");

                entity.Property(e => e.NightTime).HasColumnType("datetime");

                entity.Property(e => e.Nop)
                    .HasColumnName("NOP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentShiftId).HasColumnName("ParentShiftID");

                entity.Property(e => e.RamadanShiftId).HasColumnName("RamadanShiftID");

                entity.Property(e => e.SheriBreakFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SheriBreakTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftAbsent).HasColumnType("datetime");

                entity.Property(e => e.ShiftEarly).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftIn).HasColumnType("datetime");

                entity.Property(e => e.ShiftLastPunch).HasColumnType("datetime");

                entity.Property(e => e.ShiftLate).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftOut).HasColumnType("datetime");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftType).HasComment("1=General,2=8 Hour Shift ,3=12 hr shift");

                entity.Property(e => e.TiffinTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommonShiftDtl>(entity =>
            {
                entity.HasKey(e => new { e.ShiftId, e.UnitId, e.HrmmodeId, e.EffectDate })
                    .HasName("PK__Common_S__C0A838E1230DF095");

                entity.ToTable("Common_Shift_Dtl");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.HrmmodeId).HasColumnName("HRMModeId");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.ChangeOverShiftId).HasColumnName("ChangeOverShiftID");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.IfterTime).HasColumnType("datetime");

                entity.Property(e => e.NightBreakFrom).HasColumnType("datetime");

                entity.Property(e => e.NightBreakTill).HasColumnType("datetime");

                entity.Property(e => e.NightIncentiveTime).HasColumnType("datetime");

                entity.Property(e => e.NightTime).HasColumnType("datetime");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.ParentShiftId).HasColumnName("ParentShiftID");

                entity.Property(e => e.SheriBreakFrom).HasColumnType("datetime");

                entity.Property(e => e.SheriBreakTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftAbsent).HasColumnType("datetime");

                entity.Property(e => e.ShiftEarly).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftIfterTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftIn).HasColumnType("datetime");

                entity.Property(e => e.ShiftLastPunch).HasColumnType("datetime");

                entity.Property(e => e.ShiftLate).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchFrom).HasColumnType("datetime");

                entity.Property(e => e.ShiftLunchTill).HasColumnType("datetime");

                entity.Property(e => e.ShiftOut).HasColumnType("datetime");

                entity.Property(e => e.ShiftShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiffinTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommonShiftType>(entity =>
            {
                entity.HasKey(e => e.ShiftTypeId)
                    .HasName("PK_Common.ShiftType");

                entity.ToTable("Common_ShiftType");

                entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");

                entity.Property(e => e.ShiftTypeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK_Commom.Team");

                entity.ToTable("Common_Team");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.LineCategory)
                    .HasDefaultValueSql("((0))")
                    .HasComment("If this section is a Line then Line Category= StandardLine=1,MiniLine=2");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonThana>(entity =>
            {
                entity.HasKey(e => e.ThanaId)
                    .HasName("PK_Common.Thana");

                entity.ToTable("Common_Thana");

                entity.Property(e => e.ThanaId).HasColumnName("ThanaID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ThanaName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ThanaNameBan).HasMaxLength(150);
            });

            modelBuilder.Entity<CommonTour>(entity =>
            {
                entity.HasKey(e => e.TourId)
                    .HasName("PK__Common.T__604CEA10B69FB927");

                entity.ToTable("Common_Tour");

                entity.Property(e => e.TourId).HasColumnName("TourID");

                entity.Property(e => e.TourName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TourShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK_Common.Unit");

                entity.ToTable("Common_Unit");

                entity.HasIndex(e => e.UnitName, "IX_Common_Unit")
                    .IsUnique();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Dmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DMCode");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHrmunit).HasColumnName("IsHRMUnit");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitFullName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitFullNameBan).HasMaxLength(250);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNameBan).HasMaxLength(150);

                entity.Property(e => e.UnitShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeId).HasComment("");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<CommonUnitType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Common_UnitType");

                entity.Property(e => e.UnitTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonWeekOff>(entity =>
            {
                entity.HasKey(e => e.WeekOffId);

                entity.ToTable("Common_WeekOff");

                entity.Property(e => e.WeekOffId).ValueGeneratedNever();

                entity.Property(e => e.WeekOffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommonWing>(entity =>
            {
                entity.HasKey(e => e.WingId)
                    .HasName("PK_Common.Wing");

                entity.ToTable("Common_Wing");

                entity.HasIndex(e => e.WingName, "IX_Common_Wing")
                    .IsUnique();

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.LineCategory)
                    .HasDefaultValueSql("((0))")
                    .HasComment("If this section is a Line then Line Category= StandardLine=1,MiniLine=2");

                entity.Property(e => e.WingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WingNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<CommonZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId);

                entity.ToTable("Common_Zone");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneNameBangla).HasMaxLength(50);
            });

            modelBuilder.Entity<ConferenceEvent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ConferenceEvent");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ConferenceEvents)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConferenceEvent_ConferenceRoom");
            });

            modelBuilder.Entity<ConferenceEventParticipate>(entity =>
            {
                entity.HasKey(e => e.EventParticipateId)
                    .HasName("PK__EventPar__BF542BD3165B1C72");

                entity.ToTable("ConferenceEventParticipate");

                entity.Property(e => e.EventParticipateId).HasColumnName("EventParticipateID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.ConferenceEventParticipates)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventPart__EmpID__157CADAF");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.ConferenceEventParticipates)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventPart__Event__14888976");
            });

            modelBuilder.Entity<ConferenceRoom>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PK__Conferen__328639396E2B1B0D");

                entity.ToTable("ConferenceRoom");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoomName).HasMaxLength(100);

                entity.Property(e => e.RoomNo).HasMaxLength(10);
            });

            modelBuilder.Entity<DesignationAllFactory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DesignationAllFactory");

                entity.Property(e => e.DesigGroup)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesigType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EldeductionDate>(entity =>
            {
                entity.HasKey(e => new { e.HolidayId, e.WeekOffDay, e.DeductionDate });

                entity.ToTable("ELDeductionDate");

                entity.Property(e => e.DeductionDate).HasColumnType("date");

                entity.Property(e => e.Dmonth).HasColumnName("DMonth");

                entity.Property(e => e.Dyear).HasColumnName("DYear");

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<EmailSend>(entity =>
            {
                entity.HasKey(e => e.SendId);

                entity.ToTable("EmailSend");

                entity.Property(e => e.EmailSendDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.IsEmailInvalid).HasDefaultValueSql("((0))");

                entity.Property(e => e.MailQueueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpLateMail>(entity =>
            {
                entity.HasKey(e => e.SendMailId);

                entity.ToTable("EmpLateMail");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmailAddress).HasMaxLength(150);

                entity.Property(e => e.EmailSendDate).HasColumnType("datetime");

                entity.Property(e => e.EmpCode).HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.MailQueueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeClearanceD>(entity =>
            {
                entity.HasKey(e => new { e.ClearanceId, e.ParticularId });

                entity.ToTable("EmployeeClearanceD");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeClearanceM>(entity =>
            {
                entity.HasKey(e => e.ClearanceId);

                entity.ToTable("EmployeeClearanceM");

                entity.Property(e => e.ClearStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClearanceDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeContractInfo>(entity =>
            {
                entity.HasKey(e => new { e.ContractId, e.EmpId, e.ContractStartDate })
                    .HasName("PK_Employee_CategoryChange");

                entity.ToTable("Employee_ContractInfo");

                entity.Property(e => e.ContractId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContractStartDate).HasColumnType("date");

                entity.Property(e => e.ContractEndDate).HasColumnType("date");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FixAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistoryLogCategoryChange>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_CategoryChange");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistoryLogIncrement>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_Increment");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistoryLogIncrementB>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_Increment_B");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistoryLogIncrementBakHk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeHistoryLog_IncrementBakHk");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LogID");

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistoryLogJobLocation>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_JobLocation_ChangeLog");

                entity.ToTable("EmployeeHistoryLog_JobLocation");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmployeeHistoryLogPromotion>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_Promotion");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeHistoryLogTaxation>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_Taxation");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeHistoryLogTransfer>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmployeeHistoryLog_Transfer");

                entity.HasIndex(e => new { e.TransferId, e.EmpId }, "_dta_index_EmployeeHistoryLog_Transfer_6_837630077__K10_K2_5_6_7_8_9");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeIncrementInfo>(entity =>
            {
                entity.HasKey(e => e.IncrementId)
                    .HasName("PK_EmployeeIncrement");

                entity.ToTable("Employee_IncrementInfo");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeIncrementInfoB>(entity =>
            {
                entity.HasKey(e => e.IncrementId)
                    .HasName("PK_EmployeeIncrement_B");

                entity.ToTable("Employee_IncrementInfo_B");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeIncrementInfoBakHk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee_IncrementInfoBakHk");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncrementId).ValueGeneratedOnAdd();

                entity.Property(e => e.NewGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.PreviousSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeIncrementProposal>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.ProposedDate });

                entity.ToTable("Employee_Increment_Proposal");

                entity.Property(e => e.ProposedDate).HasColumnType("date");

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.CurrentBasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.IncrementPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LockedDate).HasColumnType("datetime");

                entity.Property(e => e.NewGrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PbasicSalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PBasicSalary");

                entity.Property(e => e.PhouseRent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PHouseRent");

                entity.Property(e => e.PincrementAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PIncrementAmount");

                entity.Property(e => e.PrevIncrementAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrevIncrementEffectDate).HasColumnType("date");

                entity.Property(e => e.PrevSpecialIncrementAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrevSpecialIncrementEffectDate).HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeJobConfirmation>(entity =>
            {
                entity.HasKey(e => e.ConfirmationId);

                entity.ToTable("Employee_JobConfirmation");

                entity.HasIndex(e => e.EmpId, "IX_Employee_JobConfirmation")
                    .IsUnique();

                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmployeePromotionInfo>(entity =>
            {
                entity.HasKey(e => e.PromotionId);

                entity.ToTable("Employee_PromotionInfo");

                entity.Property(e => e.Benefit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeTransferInfo>(entity =>
            {
                entity.HasKey(e => e.TransferId);

                entity.ToTable("Employee_TransferInfo");

                entity.HasIndex(e => new { e.EmpId, e.EffectDate }, "_dta_index_Employee_TransferInfo_6_773629849__K3_K2_1");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactoryCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("Factory_Company");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactoryDepartment>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.UnitId, e.CompanyId });

                entity.ToTable("Factory_Department");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactoryDesignation>(entity =>
            {
                entity.HasKey(e => new { e.DesignationId, e.UnitId, e.CompanyId });

                entity.ToTable("Factory_Designation");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactorySection>(entity =>
            {
                entity.HasKey(e => new { e.SectionId, e.UnitId, e.CompanyId });

                entity.ToTable("Factory_Section");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactoryUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("Factory_Unit");

                entity.Property(e => e.UnitId).ValueGeneratedNever();

                entity.Property(e => e.UnitName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinalSattlementPayable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinalSattlementPayable");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Elamount).HasColumnName("ELAmount");

                entity.Property(e => e.Elbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ELBalance");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.ProvidentFundAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SalaryPaidCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salaryPaidCompany");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SuspensionPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnpaidSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<FinalSattlementPayableCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinalSattlementPayableCompliance");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Elamount).HasColumnName("ELAmount");

                entity.Property(e => e.Elbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ELBalance");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.ProvidentFundAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SalaryPaidCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salaryPaidCompany");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SuspensionPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnpaidSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<FinalSattlementPayableThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinalSattlementPayableThird");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Elamount).HasColumnName("ELAmount");

                entity.Property(e => e.Elbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ELBalance");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.ProvidentFundAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SalaryPaidCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salaryPaidCompany");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SuspensionPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnpaidSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<ForgorPassword>(entity =>
            {
                entity.HasKey(e => e.EmpCode);

                entity.ToTable("ForgorPassword");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPassword)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetAllEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetAllEmp");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(61)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HolidayAllocateEmployeeWise>(entity =>
            {
                entity.HasKey(e => new { e.HolidayId, e.EmpId })
                    .HasName("PK_HolidayAllocateEmpWise");

                entity.ToTable("HolidayAllocateEmployeeWise");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HolidayAllocateReligionWise>(entity =>
            {
                entity.HasKey(e => new { e.HolidayId, e.ReligionId, e.UnitId, e.DepartmentId });

                entity.ToTable("HolidayAllocateReligionWise");

                entity.Property(e => e.BonusEffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HolidayDetail>(entity =>
            {
                entity.HasKey(e => new { e.HolidayId, e.HolidayDate, e.UnitId, e.EmpTypeId });

                entity.HasIndex(e => new { e.IsDoublePayment, e.HolidayDate, e.EmpTypeId, e.UnitId }, "_dta_index_HolidayDetails_6_953874565__K6_K2_K5_K4");

                entity.Property(e => e.HolidayDate).HasColumnType("date");
            });

            modelBuilder.Entity<HrmMode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK_HRM_Mode_1");

                entity.ToTable("HRM_Mode");

                entity.Property(e => e.ModeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmModeByUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_HRMModeByUser");

                entity.ToTable("HRM_Mode_ByUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HrmmodeId).HasColumnName("HRMModeId");
            });

            modelBuilder.Entity<HrmModeSetup>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK_HRM_Mode");

                entity.ToTable("HRM_Mode_Setup");

                entity.Property(e => e.UnitId).ValueGeneratedNever();

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HrmmodeId).HasColumnName("HRMModeId");
            });

            modelBuilder.Entity<HumanResourceApproverDetail>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("HumanResource_ApproverDetails");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourceAuthorizedManpower>(entity =>
            {
                entity.HasKey(e => e.AuthorizeId);

                entity.ToTable("HumanResource_AuthorizedManpower");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HumanResourceAuthorizedManpowerLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResource_AuthorizedManpower_log");

                entity.Property(e => e.AuthorizeId).HasColumnName("AuthorizeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.PreEntryDate).HasColumnType("datetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<HumanResourceEmployeeBasic>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_HumanResource.EmployeeBasic_1");

                entity.ToTable("HumanResource_EmployeeBasic");

                entity.HasIndex(e => e.EmpCode, "_dta_index_HumanResource.EmployeeBasic_5_1394820031__K2_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.EmpCode, e.EmpId }, "_dta_index_HumanResource_EmployeeBasic_6_592825274__K2_K1");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Bgmeaid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BGMEAID");

                entity.Property(e => e.BirthCertificateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpCategoryId).HasColumnName("EmpCategoryID");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatusId)
                    .HasColumnName("EmpStatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalSubmitDate).HasColumnType("date");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InsertUserID");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCompOtfixed).HasColumnName("IsCompOTFixed");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MothersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameBan).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.Nidno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIDNo");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.PrevEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevEmpID");

                entity.Property(e => e.PrevPunchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProbationDate).HasColumnType("date");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.RollBackDate).HasColumnType("datetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TitleBan).HasMaxLength(50);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<HumanResourceEmployeeBasicThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResource_EmployeeBasicThird");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<HumanResourceEmployeeContact>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_HumanResource.EmployeeContact");

                entity.ToTable("HumanResource_EmployeeContact");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.BusStop).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailOffice).HasMaxLength(50);

                entity.Property(e => e.EmergContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pabx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PABX");

                entity.Property(e => e.PerDistrictId).HasColumnName("PerDistrictID");

                entity.Property(e => e.PerDivisionId).HasColumnName("PerDivisionID");

                entity.Property(e => e.PerPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerPostOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerPostOfficeBan).HasMaxLength(50);

                entity.Property(e => e.PerRoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerRoadBan).HasMaxLength(50);

                entity.Property(e => e.PerThanaId).HasColumnName("PerThanaID");

                entity.Property(e => e.PerVillage).IsUnicode(false);

                entity.Property(e => e.PerVillageBan).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreDistrictId).HasColumnName("PreDistrictID");

                entity.Property(e => e.PreDivisionId).HasColumnName("PreDivisionID");

                entity.Property(e => e.PrePostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrePostOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrePostOfficeBan).HasMaxLength(50);

                entity.Property(e => e.PreRoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreRoadBan).HasMaxLength(50);

                entity.Property(e => e.PreThanaId).HasColumnName("PreThanaID");

                entity.Property(e => e.PreVillage)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreVillageBan)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelationWith)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialMediaId)
                    .HasMaxLength(50)
                    .HasColumnName("SocialMediaID");
            });

            modelBuilder.Entity<HumanResourceEmployeeDrivingLicense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResource_EmployeeDrivingLicense");

                entity.Property(e => e.DauthorityCountryId).HasColumnName("DAuthorityCountryID");

                entity.Property(e => e.DexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("DExpireDate");

                entity.Property(e => e.DissueDate)
                    .HasColumnType("date")
                    .HasColumnName("DIssueDate");

                entity.Property(e => e.DrivingLicense).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<HumanResourceEmployeeEducation>(entity =>
            {
                entity.ToTable("HumanResource_EmployeeEducation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Institute)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutOf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourceEmployeeJobStatus>(entity =>
            {
                entity.ToTable("HumanResource_EmployeeJobStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAddress).IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Position)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TotalDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourceEmployeeNominee>(entity =>
            {
                entity.HasKey(e => new { e.NomineeId, e.EmpId })
                    .HasName("PK_HumanResource_EmployeeNominee_1");

                entity.ToTable("HumanResource_EmployeeNominee");

                entity.HasIndex(e => new { e.EmpId, e.RelationshipId, e.NomineeName }, "IX_HumanResource_EmployeeNominee")
                    .IsUnique();

                entity.Property(e => e.NomineeId).ValueGeneratedOnAdd();

                entity.Property(e => e.BirthRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NID");

                entity.Property(e => e.NomineeName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourceEmployeePassport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResource_EmployeePassport");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PassportNo).HasMaxLength(50);

                entity.Property(e => e.PauthorityCountryId).HasColumnName("PAuthorityCountryID");

                entity.Property(e => e.PexpireDate)
                    .HasColumnType("date")
                    .HasColumnName("PExpireDate");

                entity.Property(e => e.PissueDate)
                    .HasColumnType("date")
                    .HasColumnName("PIssueDate");
            });

            modelBuilder.Entity<HumanResourceEmployeePhoto>(entity =>
            {
                entity.ToTable("HumanResource_EmployeePhoto");

                entity.HasIndex(e => e.EmpId, "IX_HumanResource.EmployeePhoto")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnType("image");
            });

            modelBuilder.Entity<HumanResourceEmployeeReference>(entity =>
            {
                entity.ToTable("HumanResource_EmployeeReference");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TelePhoneNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResourceEmployeeSeparation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HumanResource_EmployeeSeparation");

                entity.HasIndex(e => new { e.EmpId, e.IsActive }, "_dta_index_HumanResource_EmployeeSeparation_c_6_1353107911__K1_K10")
                    .IsClustered();

                entity.Property(e => e.AcceptDate).HasColumnType("date");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpStatusId).HasColumnName("EmpStatusID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SubmissionDate).HasColumnType("date");
            });

            modelBuilder.Entity<HumanResourceEmployeeTraining>(entity =>
            {
                entity.ToTable("HumanResource_EmployeeTraining");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Institute)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<IdcardRegistration>(entity =>
            {
                entity.HasKey(e => e.IdcardRegNo);

                entity.ToTable("IDCardRegistration");

                entity.Property(e => e.IdcardRegNo).HasColumnName("IDCardRegNo");

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.EmergContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactAddress)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhoto).HasColumnType("image");

                entity.Property(e => e.EmpSignature).HasColumnType("image");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NID");
            });

            modelBuilder.Entity<InTransitProcess>(entity =>
            {
                entity.ToTable("InTransitProcess");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QueueOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<IncrementType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("IncrementType");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveAllocation>(entity =>
            {
                entity.HasKey(e => e.LeaveAllocationDtlId);

                entity.ToTable("LeaveAllocation");

                entity.HasIndex(e => new { e.EmpId, e.LeaveId, e.LeaveYear }, "IX_LeaveAllocation")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IsCarriedOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.OthersDeduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<LeaveAllocationBak>(entity =>
            {
                entity.HasKey(e => e.LeaveAllocationDtlId);

                entity.ToTable("LeaveAllocation_Bak");

                entity.Property(e => e.IsCarriedOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.OthersDeduction).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LeaveAllocationMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LeaveAllocationMaster");

                entity.Property(e => e.ActionDate).HasColumnType("date");

                entity.Property(e => e.EmpCategoryId).HasColumnName("EmpCategoryID");

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.WorkingDaysForPerLeave).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.YearlyAllocation).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<LeaveApproverUnitPermission>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.UnitId });

                entity.ToTable("LeaveApproverUnitPermission");
            });

            modelBuilder.Entity<LeaveDeduction>(entity =>
            {
                entity.HasKey(e => e.DedId);

                entity.ToTable("LeaveDeduction");

                entity.Property(e => e.DedId).HasColumnName("DedID");

                entity.Property(e => e.Dleave)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("DLeave");

                entity.Property(e => e.Dmonth).HasColumnName("DMonth");

                entity.Property(e => e.DtypeId)
                    .HasColumnName("DTypeId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dyear).HasColumnName("DYear");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<LeaveDeductionType>(entity =>
            {
                entity.HasKey(e => e.DtypeId);

                entity.ToTable("LeaveDeductionType");

                entity.Property(e => e.DtypeId).HasColumnName("DTypeId");

                entity.Property(e => e.DtypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DTypeName");
            });

            modelBuilder.Entity<LetterPrintHistory>(entity =>
            {
                entity.HasKey(e => e.PrintId);

                entity.ToTable("LetterPrintHistory");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LetterPrintDate).HasColumnType("date");
            });

            modelBuilder.Entity<LoanType>(entity =>
            {
                entity.ToTable("LoanType");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<LogCompanyNameChange>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.CompanyName, e.StartDate, e.EndDate })
                    .HasName("PK_CompanyNameChangeLog");

                entity.ToTable("Log_CompanyNameChange");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LogUnitNameChange>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.UnitName, e.StartDate, e.EndDate })
                    .HasName("PK_UnitNameChangeLog");

                entity.ToTable("Log_UnitNameChange");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OgranogramApplicationsApproval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ogranogram_ApplicationsApproval");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OrgAssignDepartmentToDepartmentHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Org_AssignDepartmentToDepartmentHead");
            });

            modelBuilder.Entity<OrganizationOrganogram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Organization_Organogram");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");
            });

            modelBuilder.Entity<OutOfLayOffEmployeeList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OutOfLayOffEmployeeList");

                entity.Property(e => e.Empcode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("empcode");

                entity.Property(e => e.Sp).HasColumnName("SP");
            });

            modelBuilder.Entity<PaAppraisalComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_AppraisalComment");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.CommentDate).HasColumnType("date");

                entity.Property(e => e.CommenterDesignationId).HasColumnName("CommenterDesignationID");

                entity.Property(e => e.CommenterType).HasMaxLength(150);
            });

            modelBuilder.Entity<PaBehaviorFactor>(entity =>
            {
                entity.HasKey(e => e.FactorId);

                entity.ToTable("PA_BehaviorFactor");

                entity.Property(e => e.FactorId).HasColumnName("FactorID");

                entity.Property(e => e.FactorDescription).HasMaxLength(250);

                entity.Property(e => e.SubDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<PaFactorDescription>(entity =>
            {
                entity.HasKey(e => e.FactorDescriptionId);

                entity.ToTable("PA_FactorDescription");

                entity.Property(e => e.FactorDescriptionId).HasColumnName("FactorDescriptionID");

                entity.Property(e => e.BehaviorFactorId).HasColumnName("BehaviorFactorID");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<PaJdDescription>(entity =>
            {
                entity.HasKey(e => e.JddescriptionId);

                entity.ToTable("PA_JD_Description");

                entity.Property(e => e.JddescriptionId).HasColumnName("JDDescriptionID");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Jddescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("JDDescription");
            });

            modelBuilder.Entity<PaMaster>(entity =>
            {
                entity.HasKey(e => e.AppraisalMasterId);

                entity.ToTable("PA_Master");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewPeriodFrom).HasColumnType("date");

                entity.Property(e => e.ReviewPeriodTo).HasColumnType("date");
            });

            modelBuilder.Entity<PaOvarallRating>(entity =>
            {
                entity.HasKey(e => e.RatingId);

                entity.ToTable("PA_OvarallRating");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EvaluationComment).HasMaxLength(250);

                entity.Property(e => e.EvaluationType).HasMaxLength(100);

                entity.Property(e => e.EvalutionId).HasColumnName("EvalutionID");
            });

            modelBuilder.Entity<PaPerformanceEvaluation>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_PA_CommonPerformanceEvaluation");

                entity.ToTable("PA_PerformanceEvaluation");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDescription).HasMaxLength(500);

                entity.Property(e => e.RatingName).HasMaxLength(100);
            });

            modelBuilder.Entity<PaProbationRecommendation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_ProbationRecommendation");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<PaPromotionRecommendation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_PromotionRecommendation");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PromotedDesignationId).HasColumnName("PromotedDesignationID");
            });

            modelBuilder.Entity<PaReDesignatedRecommendation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_ReDesignatedRecommendation");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PromotedDesignationId).HasColumnName("PromotedDesignationID");
            });

            modelBuilder.Entity<PaRecommendationComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_RecommendationComment");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CommentDate).HasColumnType("date");

                entity.Property(e => e.CommenterDesignationId).HasColumnName("CommenterDesignationID");

                entity.Property(e => e.CommenterType).HasMaxLength(150);
            });

            modelBuilder.Entity<PaRecommendationMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_RecommendationMaster");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<PaSalaryAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA_SalaryAdjustment");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AppraisalMasterId).HasColumnName("AppraisalMasterID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SalaryAdjustmentType).HasMaxLength(150);
            });

            modelBuilder.Entity<PaySlipOpen>(entity =>
            {
                entity.ToTable("PaySlipOpen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PayrollAllowanceByDesGroup>(entity =>
            {
                entity.HasKey(e => e.AllowanceByDesGroupId)
                    .HasName("PK_Payroll.AllowanceByDesGroup");

                entity.ToTable("Payroll_AllowanceByDesGroup");

                entity.Property(e => e.AllowanceByDesGroupId).HasColumnName("AllowanceByDesGroupID");

                entity.Property(e => e.DesGroupId).HasColumnName("DesGroupID");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.HolidayPayRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarPayRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LunchPayRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightPayRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinPayRate).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollAnnualLeavePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_AnnualLeave_Payment");

                entity.Property(e => e.BalanceDay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PayableDay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollBasicSalaryInfoLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_BasicSalaryInfo_Log");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollCostHead>(entity =>
            {
                entity.HasKey(e => e.CostHeadId);

                entity.ToTable("Payroll_CostHead");

                entity.Property(e => e.CostHeadName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollCurrencyConversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_CurrencyConversion");

                entity.Property(e => e.ConId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ConID");

                entity.Property(e => e.ConversionRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            });

            modelBuilder.Entity<PayrollDistanceAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_DistanceAllowance");

                entity.Property(e => e.AllowanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllowanceRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PayableDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnPaid).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalary>(entity =>
            {
                entity.HasKey(e => new { e.SalaryId, e.EmpId });

                entity.ToTable("Payroll_Employee_BasicSalary");

                entity.HasIndex(e => e.EmpId, "_dta_index_Payroll_Employee_BasicSalary_6_1540916561__K2_11");

                entity.Property(e => e.SalaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CurrentSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalaryB>(entity =>
            {
                entity.HasKey(e => new { e.SalaryId, e.EmpId });

                entity.ToTable("Payroll_Employee_BasicSalary_B");

                entity.Property(e => e.SalaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CurrentSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalaryDetail>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.EffectDate, e.SalaryHeadId });

                entity.ToTable("Payroll_Employee_BasicSalary_Details");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalaryDetailsB>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.EffectDate, e.SalaryHeadId });

                entity.ToTable("Payroll_Employee_BasicSalary_Details_B");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalaryDetailsNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_Employee_BasicSalary_DetailsNew");

                entity.Property(e => e.AttBonus)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasicSalary)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConveyanceAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistanceAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EffectFrom).HasColumnType("date");

                entity.Property(e => e.FestivalHoliday)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HouseRent)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IftarAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LunchSubsidy)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedicalAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscellaneous)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightIncentiveAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OthersAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TiffinAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransportCost)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WeekOffAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollEmployeeBasicSalaryDetailsNewB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_Employee_BasicSalary_DetailsNew_B");

                entity.Property(e => e.AttBonus)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasicSalary)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConveyanceAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DistanceAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EffectFrom).HasColumnType("date");

                entity.Property(e => e.FestivalHoliday)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HouseRent)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IftarAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LunchSubsidy)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedicalAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscellaneous)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightIncentiveAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OthersAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TiffinAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransportCost)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WeekOffAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollEmployeeLoan>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("Payroll_EmployeeLoan");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanDate).HasColumnType("date");

                entity.Property(e => e.PaymentStartDate).HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<PayrollEmployeeLoanInstallment>(entity =>
            {
                entity.HasKey(e => e.InstallmentId);

                entity.ToTable("Payroll_EmployeeLoanInstallment");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstallmentDate).HasColumnType("date");

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PrincipalAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayrollEmployeePayrollAdjustment>(entity =>
            {
                entity.HasKey(e => e.AdjustmentId);

                entity.ToTable("Payroll_EmployeePayrollAdjustment");

                entity.HasIndex(e => new { e.EmpId, e.SalaryYear, e.SalaryMonth }, "IX_Payroll_EmployeePayrollAdjustment");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollEmployeePayrollAdjustmentTemp>(entity =>
            {
                entity.HasKey(e => e.AdjustmentId);

                entity.ToTable("Payroll_EmployeePayrollAdjustment_Temp");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollEmployeePf>(entity =>
            {
                entity.HasKey(e => e.EmpPfid);

                entity.ToTable("Payroll_EmployeePF");

                entity.Property(e => e.EmpPfid).HasColumnName("EmpPFId");

                entity.Property(e => e.ClosedDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.IsClosed).HasDefaultValueSql("((0))");

                entity.Property(e => e.PffixedAmount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PFFixedAmount");

                entity.Property(e => e.PfmembershipDate)
                    .HasColumnType("date")
                    .HasColumnName("PFMembershipDate");

                entity.Property(e => e.Pfpercentage)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PFPercentage");
            });

            modelBuilder.Entity<PayrollEmployeePfdeduction>(entity =>
            {
                entity.HasKey(e => e.Pfid);

                entity.ToTable("Payroll_EmployeePFDeduction");

                entity.Property(e => e.Pfid).HasColumnName("PFId");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PfamountComp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFAmountComp");

                entity.Property(e => e.PfamountEmp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFAmountEmp");

                entity.Property(e => e.TerminalId).HasMaxLength(150);
            });

            modelBuilder.Entity<PayrollEmployeeTaxation>(entity =>
            {
                entity.HasKey(e => e.TaxId)
                    .HasName("PK_Paroll_EmployeeTaxation");

                entity.ToTable("Payroll_EmployeeTaxation");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaxAmountComp)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxAmountEmp)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TerminalId).HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollEmployeeWiseAllowance>(entity =>
            {
                entity.HasKey(e => new { e.AllowanceId, e.EmpId, e.CostHeadId, e.EffectiveDate });

                entity.ToTable("Payroll_EmployeeWiseAllowance");

                entity.Property(e => e.AllowanceId).ValueGeneratedOnAdd();

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.AllowanceRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollEmployeeWiseAllowanceB>(entity =>
            {
                entity.HasKey(e => new { e.AllowanceId, e.EmpId, e.CostHeadId, e.EffectiveDate });

                entity.ToTable("Payroll_EmployeeWiseAllowance_B");

                entity.Property(e => e.AllowanceId).ValueGeneratedOnAdd();

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.AllowanceRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollEmployeeWiseAllowanceDX>(entity =>
            {
                entity.HasKey(e => new { e.AllowanceId, e.CostHeadId })
                    .HasName("PK_Payroll_EmpWiseAllowanceD_1");

                entity.ToTable("Payroll_EmployeeWiseAllowanceD_x");

                entity.Property(e => e.AllowanceRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayrollEmployeeWiseAllowanceMX>(entity =>
            {
                entity.HasKey(e => e.AllowanceId)
                    .HasName("PK_Payroll_EmpeWiseCostHead");

                entity.ToTable("Payroll_EmployeeWiseAllowanceM_x");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollFestivalBonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_FestivalBonus");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BonusAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BonusDate).HasColumnType("date");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollFormula>(entity =>
            {
                entity.HasKey(e => e.FormulaId)
                    .HasName("PK_Paroll_Formula");

                entity.ToTable("Payroll_Formula");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormulaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollFormulaStructure>(entity =>
            {
                entity.HasKey(e => e.Fsid)
                    .HasName("PK_Payroll_FormulaStructure_1");

                entity.ToTable("Payroll_FormulaStructure");

                entity.HasIndex(e => new { e.FormulaId, e.SalaryHeadId }, "IX_Payroll_FormulaStructure")
                    .IsUnique();

                entity.Property(e => e.Fsid).HasColumnName("FSId");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormulaStatement)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollGradeWiseAllowanceD>(entity =>
            {
                entity.HasKey(e => new { e.AllowanceId, e.CostHeadId })
                    .HasName("PK_Payroll_GradeWiseAllowanceD_1");

                entity.ToTable("Payroll_GradeWiseAllowanceD");

                entity.Property(e => e.AllowanceRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayrollGradeWiseAllowanceM>(entity =>
            {
                entity.HasKey(e => e.AllowanceId)
                    .HasName("PK_Payroll_GradeWiseCostHead");

                entity.ToTable("Payroll_GradeWiseAllowanceM");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollHourlySalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_HourlySalary");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.DaySalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.HourlySalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalHourPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalWorkingHour).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollMailSendStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MailSendStatus");
            });

            modelBuilder.Entity<PayrollMaternityPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MaternityPay");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInstDate).HasColumnType("datetime");

                entity.Property(e => e.FirstInstdate).HasColumnType("datetime");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstallmentPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3AdvancePay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3ArearPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3BillPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3BonusPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3SalaryDate).HasColumnType("datetime");

                entity.Property(e => e.Last3SalaryPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Last3SupplePay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastPayBasic).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastPayGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastSalaryDate).HasColumnType("datetime");

                entity.Property(e => e.Lrid).HasColumnName("LRID");

                entity.Property(e => e.MtlreturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MTLReturnDate");

                entity.Property(e => e.MtltrackId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MTLTrackID");

                entity.Property(e => e.NetPayPerInst).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PerDayPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Stamp).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Total112DaysPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Total3MonthPay).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollMonthlyArear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlyArear");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BancAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrentGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lodays).HasColumnName("LODays");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.PrevGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollMonthlyArearCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlyArearCompliance");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BancAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrentGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lodays).HasColumnName("LODays");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.PrevGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollMonthlyArearThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlyArearThird");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BancAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurrentGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncrementAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lodays).HasColumnName("LODays");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.PrevGross).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<PayrollMonthlyPayrollStop>(entity =>
            {
                entity.HasKey(e => e.PayrollStopId);

                entity.ToTable("Payroll_MonthlyPayrollStop");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsOpen).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StopDate).HasColumnType("date");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollMonthlySalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalary");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MiscAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("'R' For Regular,'N' For New Join,'M' for Maternity ");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UnionSub).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryAdvance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryAdvance");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryAdvanceCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryAdvanceCompliance");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryAdvanceThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryAdvanceThird");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryAdvancebak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryAdvancebak");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalary_Bak");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryCompliance");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MiscAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UnionSub).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalarySampleJanuary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalary_Sample_January");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MiscAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnionSub).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalarySupplementary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalarySupplementary");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MiscAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnionSub).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalarySupplementaryApr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalarySupplementary_Apr");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour).HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollMonthlySalaryThird>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payroll_MonthlySalaryThird");

                entity.Property(e => e.AbsentDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdvanceDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AllowancePayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AttBonus).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BasicPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.ConveyanceAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ee).HasColumnName("EE");

                entity.Property(e => e.El).HasColumnName("EL");

                entity.Property(e => e.Exl).HasColumnName("EXL");

                entity.Property(e => e.FestivalHolidaysAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FestivalHolidaysRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.FoodingAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossPayable).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HolidayRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.IftarRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KeyAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LateDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LayOffPayAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Lo).HasColumnName("LO");

                entity.Property(e => e.LoanDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Loded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LODed");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LunchRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Lwa).HasColumnName("LWA");

                entity.Property(e => e.Lwaded)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LWADed");

                entity.Property(e => e.Lwp).HasColumnName("LWP");

                entity.Property(e => e.MedicalAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MiscAllowance)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.MobileAllowance).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.NetPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightIncentiveRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.NightRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nop).HasColumnName("NOP");

                entity.Property(e => e.Otamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTAmount");

                entity.Property(e => e.OthersAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Othour)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTHour");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.Penalti).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pfded)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PFDed");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryMood)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Spl).HasColumnName("SPL");

                entity.Property(e => e.StampFee).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxDedCom).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TiffinRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.TotalPayment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UnionSub).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Wo).HasColumnName("WO");
            });

            modelBuilder.Entity<PayrollPayrollStopType>(entity =>
            {
                entity.HasKey(e => e.StopTypeId)
                    .HasName("PK_Payroll_SalaryStopType");

                entity.ToTable("Payroll_PayrollStopType");

                entity.Property(e => e.StopTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollSalaryHead>(entity =>
            {
                entity.HasKey(e => e.SalaryHeadId);

                entity.ToTable("Payroll_SalaryHead");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalaryHead)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Payroll_Type");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PmsReviewOrganogram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMS_ReviewOrganogram");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InActiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReviewerType).HasMaxLength(50);
            });

            modelBuilder.Entity<PmsReviewShedule>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.ReviewMonth, e.ReviewYear })
                    .HasName("PK_PMS_ReviewShedule_1");

                entity.ToTable("PMS_ReviewShedule");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ReviewDate).HasColumnType("date");
            });

            modelBuilder.Entity<PmsReviewerRating>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.ReviewerEmpId, e.ReviewMonth, e.ReviewYear })
                    .HasName("PK_PMS_ReviewerRating_1");

                entity.ToTable("PMS_ReviewerRating");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.RatingName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProcessLock>(entity =>
            {
                entity.ToTable("ProcessLock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lmonth).HasColumnName("LMonth");

                entity.Property(e => e.LockDate).HasColumnType("date");

                entity.Property(e => e.Lyear).HasColumnName("LYear");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<RDepDesignation>(entity =>
            {
                entity.HasKey(e => e.DepDesignationId)
                    .HasName("PK_R.DepDesignation");

                entity.ToTable("R_DepDesignation");

                entity.Property(e => e.DepDesignationId).HasColumnName("DepDesignationID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.UdepId).HasColumnName("UDepID");
            });

            modelBuilder.Entity<RDeptSection>(entity =>
            {
                entity.HasKey(e => e.DsecId)
                    .HasName("PK__R.DeptSection");

                entity.ToTable("R_DeptSection");

                entity.Property(e => e.DsecId).HasColumnName("DSecID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.UdepId).HasColumnName("UDepID");
            });

            modelBuilder.Entity<RSecWing>(entity =>
            {
                entity.HasKey(e => e.SwingId);

                entity.ToTable("R_SecWing");

                entity.HasIndex(e => new { e.DsecId, e.WingId }, "IX_R_SecWing");

                entity.Property(e => e.SwingId).HasColumnName("SWingID");

                entity.Property(e => e.DsecId).HasColumnName("DSecID");

                entity.Property(e => e.WingId).HasColumnName("WingID");
            });

            modelBuilder.Entity<RUnitDept>(entity =>
            {
                entity.HasKey(e => e.UdepId)
                    .HasName("PK_R.UnitDept");

                entity.ToTable("R_UnitDept");

                entity.Property(e => e.UdepId).HasColumnName("UDepID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<RWingTeam>(entity =>
            {
                entity.HasKey(e => e.WteamId)
                    .HasName("PK__R.WingTeam");

                entity.ToTable("R_WingTeam");

                entity.Property(e => e.WteamId).HasColumnName("WTeamID");

                entity.Property(e => e.SwingId).HasColumnName("SWingID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");
            });

            modelBuilder.Entity<Ramadan>(entity =>
            {
                entity.ToTable("Ramadan");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IfterTime).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<RecruitmentCandidate>(entity =>
            {
                entity.HasKey(e => e.CandidateId);

                entity.ToTable("Recruitment_Candidate");

                entity.Property(e => e.AppliedDate).HasColumnType("date");

                entity.Property(e => e.CandidateName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResumePath)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Stage).HasComment("0=Application Received, 1=ShortListed, 2=Interview, 3=Job Offer, 4=Hired, 5=Rejected");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecruitmentVacancy>(entity =>
            {
                entity.HasKey(e => e.VacancyId);

                entity.ToTable("Recruitment_Vacancy");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobDescription).IsUnicode(false);

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobRef)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.PublishedDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0=Published, 1=UnPublished,3=Closed");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDailyOperationCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_DailyOperationCost");

                entity.HasIndex(e => new { e.EmpId, e.WorkDay }, "_dta_index_Report_DailyOperationCost_6_531637087__K1_K21");

                entity.Property(e => e.AttStatus)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ComOtamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("ComOTAmount");

                entity.Property(e => e.ComOtemp).HasColumnName("ComOTEmp");

                entity.Property(e => e.ComOthours)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("ComOTHours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Conveyance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DayPay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Exotamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXOTAmount");

                entity.Property(e => e.Exotemp).HasColumnName("EXOTEmp");

                entity.Property(e => e.Exothours)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXOTHours");

                entity.Property(e => e.Food).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HoliDayAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayAllow).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HolidayEmp).HasColumnName("HOlidayEmp");

                entity.Property(e => e.HouseRent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IftarAllow).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IfterAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IsNightIncentive).HasDefaultValueSql("((0))");

                entity.Property(e => e.LunchAllow).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LunchAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Medical).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAllow).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NightIncentive)
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.NightIncentiveEmp).HasDefaultValueSql("((0))");

                entity.Property(e => e.NightincentiveAmount)
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Other).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Otrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTRate");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.Stuff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAllow).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TiffinAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalOtamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TotalOTAmount");

                entity.Property(e => e.TotalOtemp).HasColumnName("TotalOTEmp");

                entity.Property(e => e.TotalOthours)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TotalOTHours");

                entity.Property(e => e.Wages).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeekOffAllowance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeekOffAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkDay).HasColumnType("date");

                entity.Property(e => e.WorkDurationStuff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkDurationTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkDurationWorker).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Worker).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<SignalRChatDetail>(entity =>
            {
                entity.HasKey(e => e.ChatId);

                entity.ToTable("SignalR_ChatDetails");

                entity.Property(e => e.ChatMessage).IsUnicode(false);

                entity.Property(e => e.MessageTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TaxYear>(entity =>
            {
                entity.ToTable("TaxYear");

                entity.Property(e => e.TaxYearId).ValueGeneratedNever();

                entity.Property(e => e.Eyear).HasColumnName("EYear");

                entity.Property(e => e.Syear).HasColumnName("SYear");
            });

            modelBuilder.Entity<TaxationAllowedInvestment>(entity =>
            {
                entity.HasKey(e => new { e.AllowInvestmentId, e.TaxYearId })
                    .HasName("PK_Payroll_AllowedInvestment");

                entity.ToTable("Taxation_AllowedInvestment");

                entity.Property(e => e.AllowInvestmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxAllowedInvestmentAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxCreditRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxableIncomePer).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TaxationEmployeeInvestment>(entity =>
            {
                entity.HasKey(e => e.InvestmentId)
                    .HasName("PK_Payroll_EmployeeInvestment");

                entity.ToTable("Taxation_EmployeeInvestment");

                entity.Property(e => e.InvestmentAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TaxationInvestmentSchedule>(entity =>
            {
                entity.HasKey(e => e.InvestmentTypeId)
                    .HasName("PK_Payroll_InvestmentType");

                entity.ToTable("Taxation_InvestmentSchedule");

                entity.Property(e => e.InvestmentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestmentTypeName).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaxationTaxPayableBeforeInvestment>(entity =>
            {
                entity.HasKey(e => e.TaxPayableId)
                    .HasName("PK_Payroll_TaxPayableBeforeInvestment");

                entity.ToTable("Taxation_TaxPayableBeforeInvestment");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TaxationTaxPayeeCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_Payroll_TaxPayeeCategory");

                entity.ToTable("Taxation_TaxPayeeCategory");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxationTaxYear>(entity =>
            {
                entity.HasKey(e => e.TaxYearId)
                    .HasName("PK_Payroll_TaxYear");

                entity.ToTable("Taxation_TaxYear");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiscalYear)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempAlPayment>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.LeaveYear });

                entity.ToTable("Temp_AL_Payment");

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableDays).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TempAllowance>(entity =>
            {
                entity.HasKey(e => new { e.EmpCode, e.CostHeadId, e.EffectDate });

                entity.ToTable("Temp_Allowance");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectDate).HasColumnType("date");

                entity.Property(e => e.AllowanceAmt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TempDistanceAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDistanceAllowance");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProcess).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TempElpay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempELPay");

                entity.Property(e => e.ActionDate).HasColumnType("date");

                entity.Property(e => e.DataProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductDay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Elyear).HasColumnName("ELYear");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .HasColumnName("EMPCode");
            });

            modelBuilder.Entity<TempIncrement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_increment");

                entity.Property(e => e.Currentgross).HasColumnName("currentgross");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.EffectDate)
                    .HasColumnType("date")
                    .HasColumnName("effectDate");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empcode");

                entity.Property(e => e.Increment).HasColumnName("increment");

                entity.Property(e => e.Prevgross).HasColumnName("prevgross");
            });

            modelBuilder.Entity<TempMobilebillDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Mobilebill_Deduction");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Tk).HasColumnName("TK");
            });

            modelBuilder.Entity<TempPabx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Pabx");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pabx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PABX");
            });

            modelBuilder.Entity<TempPfdeduction>(entity =>
            {
                entity.HasKey(e => e.EmpCode);

                entity.ToTable("Temp_PFDeduction");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Pfamount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PFAmount");
            });

            modelBuilder.Entity<TempPunchRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempPunchRecord");

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Manually)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PunchTime).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempTaxInfo>(entity =>
            {
                entity.HasKey(e => e.EmpCode);

                entity.ToTable("Temp_TaxInfo");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmtComp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmtEmp).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TempTrn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Trn");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime1).HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test1");

                entity.Property(e => e.Aacode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aacode");
            });

            modelBuilder.Entity<UnitWiseLetterAcceptPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UnitWiseLetterAcceptPermission");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UserCompanyPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId });

                entity.ToTable("UserCompanyPermission");
            });

            modelBuilder.Entity<UserDepartmentPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId, e.UnitId, e.DepartmentId });

                entity.ToTable("UserDepartmentPermission");
            });

            modelBuilder.Entity<UserSectionPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId, e.UnitId, e.DepartmentId, e.SectionId });

                entity.ToTable("UserSectionPermission");
            });

            modelBuilder.Entity<UserTeamPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId, e.UnitId, e.DepartmentId, e.SectionId, e.WingId, e.TeamId });

                entity.ToTable("UserTeamPermission");
            });

            modelBuilder.Entity<UserUnitPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId, e.UnitId });

                entity.ToTable("UserUnitPermission");
            });

            modelBuilder.Entity<UserWingPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyId, e.UnitId, e.DepartmentId, e.SectionId, e.WingId });

                entity.ToTable("UserWingPermission");
            });

            modelBuilder.Entity<ViewEmpNoFromHoff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewEMpNoFromHoff");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");
            });

            modelBuilder.Entity<VwEmployeeContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmployeeContact");

                entity.Property(e => e.BusStop).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailOffice).HasMaxLength(50);

                entity.Property(e => e.EmergContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmergContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pabx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PABX");

                entity.Property(e => e.PerDistrictId).HasColumnName("PerDistrictID");

                entity.Property(e => e.PerDistrictName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerDistrictNameBan).HasMaxLength(50);

                entity.Property(e => e.PerDivisionId).HasColumnName("PerDivisionID");

                entity.Property(e => e.PerDivisionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerDivisionNameBan).HasMaxLength(50);

                entity.Property(e => e.PerPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerPostOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerPostOfficeBan).HasMaxLength(50);

                entity.Property(e => e.PerRoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerRoadBan).HasMaxLength(50);

                entity.Property(e => e.PerThanaId).HasColumnName("PerThanaID");

                entity.Property(e => e.PerThanaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PerThanaNameBan).HasMaxLength(150);

                entity.Property(e => e.PerVillage).IsUnicode(false);

                entity.Property(e => e.PerVillageBan).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreDistrictId).HasColumnName("PreDistrictID");

                entity.Property(e => e.PreDistrictName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreDistrictNameBan).HasMaxLength(50);

                entity.Property(e => e.PreDivisionId).HasColumnName("PreDivisionID");

                entity.Property(e => e.PreDivisionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreDivisionNameBan).HasMaxLength(50);

                entity.Property(e => e.PrePostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrePostOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrePostOfficeBan).HasMaxLength(50);

                entity.Property(e => e.PreRoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreRoadBan).HasMaxLength(50);

                entity.Property(e => e.PreThanaId).HasColumnName("PreThanaID");

                entity.Property(e => e.PreThanaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PreThanaNameBan).HasMaxLength(150);

                entity.Property(e => e.PreVillage).IsUnicode(false);

                entity.Property(e => e.PreVillageBan).HasMaxLength(50);

                entity.Property(e => e.RelationWith)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialMediaId)
                    .HasMaxLength(50)
                    .HasColumnName("SocialMediaID");
            });

            modelBuilder.Entity<VwEmployeeEff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmployeeEff");

                entity.Property(e => e.EmpEff).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmployeeInfo");

                entity.Property(e => e.Bgmeaid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BGMEAID");

                entity.Property(e => e.BirthCertificateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressBan).HasMaxLength(250);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNameBan).HasMaxLength(100);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNameBan).HasMaxLength(150);

                entity.Property(e => e.DepartmentShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationNameBan).HasMaxLength(150);

                entity.Property(e => e.DesignationSpecification).HasMaxLength(100);

                entity.Property(e => e.DesignationSpecificationBan).HasMaxLength(100);

                entity.Property(e => e.EmpCategoryId).HasColumnName("EmpCategoryID");

                entity.Property(e => e.EmpCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNameBan).HasMaxLength(101);

                entity.Property(e => e.EmpStatusId).HasColumnName("EmpStatusID");

                entity.Property(e => e.EmpStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.EmpTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.JobLocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nidno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIDNo");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrevEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevEmpID");

                entity.Property(e => e.PrevPunchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProbationDate).HasColumnType("date");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNameBan).HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamNameBan).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitFullName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitFullNameBan).HasMaxLength(250);

                entity.Property(e => e.UnitName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNameBan).HasMaxLength(150);

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WingNameBan).HasMaxLength(50);

                entity.Property(e => e.WorkType).HasMaxLength(150);
            });

            modelBuilder.Entity<VwEmployeeInfoDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmployeeInfoDetails");

                entity.Property(e => e.Bgmeaid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BGMEAID");

                entity.Property(e => e.BirthCertificateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoardName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNameBan).HasMaxLength(100);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNameBan).HasMaxLength(150);

                entity.Property(e => e.DepartmentShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationNameBan).HasMaxLength(150);

                entity.Property(e => e.DesignationSpecification).HasMaxLength(100);

                entity.Property(e => e.EmpAge).HasMaxLength(107);

                entity.Property(e => e.EmpAge2).HasMaxLength(107);

                entity.Property(e => e.EmpCategoryId).HasColumnName("EmpCategoryID");

                entity.Property(e => e.EmpCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNameBan).HasMaxLength(101);

                entity.Property(e => e.EmpStatusId).HasColumnName("EmpStatusID");

                entity.Property(e => e.EmpStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");

                entity.Property(e => e.EmpTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FathersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenderNameBan).HasMaxLength(50);

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(29, 4)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InsertUserID");

                entity.Property(e => e.Isfixed).HasColumnName("isfixed");

                entity.Property(e => e.JobLocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasMaxLength(4000);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MaritalStatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusNameBan).HasMaxLength(50);

                entity.Property(e => e.MothersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nidno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIDNo");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrevEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrevEmpID");

                entity.Property(e => e.PrevPunchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProbationDate).HasColumnType("date");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNameBan).HasMaxLength(50);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamNameBan).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNameBan).HasMaxLength(150);

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WingNameBan).HasMaxLength(50);
            });

            modelBuilder.Entity<VwPabxinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_PABXInfo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailOffice)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.JobLocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pabx)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PABX");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WingId).HasColumnName("WingID");

                entity.Property(e => e.WingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
