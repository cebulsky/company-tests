using System.Collections.Generic;

namespace HRApp
{
    public interface ICompany
    {
        void AddEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        string GetCompanyName();
    }
}