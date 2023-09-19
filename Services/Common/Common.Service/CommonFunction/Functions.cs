using System.Collections.Generic;
using System.Linq;

namespace Common.Service.CommonFunction
{
    public class Functions
    {
        public static string GetCompanyName(List<CompanyNameByIdVm> companies, int? id)
        {
            return companies.FirstOrDefault(f => f.CompanyId == id).CompanyName.ToString();
        }
        public static string GetUserName(List<UserNameByIdVm> userInfos, long? userId)
        {
            return userInfos.Where(f => f.UserId == userId).FirstOrDefault().UserName;
        }

        public static string GetEmpName(List<UserNameByIdVm> Employee, long? EmpId)
        {
            return Employee.Where(j => j.EmpId == EmpId).FirstOrDefault().UserName;
            //return x.Name;
        }
        public static string GetModelName(List<ModelParentVm> modelInfos, int? parentId)
        {
            return modelInfos.Where(f => f.Id == parentId).FirstOrDefault().Name;
        }

        public static string GetCategoryName(List<CategoryParentVm> categoryInfos, int? parentCategoryId)
        {
            return categoryInfos.Where(f => f.Id == parentCategoryId).FirstOrDefault().Name;
        }

        public static string GetAttributName(List<AttributeParentVm> attributeInfos, int? parentId)
        {
            return attributeInfos.Where(f => f.Id == parentId).FirstOrDefault().Name;
        }

    }
}
