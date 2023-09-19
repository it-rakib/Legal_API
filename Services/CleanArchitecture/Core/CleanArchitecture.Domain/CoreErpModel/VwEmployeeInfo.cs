using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class VwEmployeeInfo
    {
        public long EmpId { get; set; }
        public string EmpCode { get; set; }
        public int PunchNo { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string EmpName { get; set; }
        public string EmpNameBan { get; set; }
        public string JoiningDate { get; set; }
        public string Nidno { get; set; }
        public string BirthCertificateNo { get; set; }
        public int? EmpStatusId { get; set; }
        public string EmpStatusName { get; set; }
        public int? EmpTypeId { get; set; }
        public string EmpTypeName { get; set; }
        public int? DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string DesignationNameBan { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameBan { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddressBan { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public string UnitNameBan { get; set; }
        public string UnitFullName { get; set; }
        public string UnitFullNameBan { get; set; }
        public string UnitAddress { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameBan { get; set; }
        public string DepartmentShortName { get; set; }
        public int? SectionId { get; set; }
        public string SectionName { get; set; }
        public string SectionNameBan { get; set; }
        public int? WingId { get; set; }
        public string WingName { get; set; }
        public string WingNameBan { get; set; }
        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamNameBan { get; set; }
        public int? EmpCategoryId { get; set; }
        public string EmpCategoryName { get; set; }
        public int? PositionId { get; set; }
        public string PositionName { get; set; }
        public int? BloodGroupId { get; set; }
        public int? GenderId { get; set; }
        public int? ReligionId { get; set; }
        public string Bgmeaid { get; set; }
        public string ReligionName { get; set; }
        public string PrevEmpId { get; set; }
        public string PrevPunchNo { get; set; }
        public bool? IsApproved { get; set; }
        public int? JobLocationId { get; set; }
        public string JobLocationName { get; set; }
        public DateTime? ProbationDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? GradeId { get; set; }
        public int? DesignationSpecId { get; set; }
        public string DesignationSpecification { get; set; }
        public string WorkType { get; set; }
        public string DesignationSpecificationBan { get; set; }
    }
}
