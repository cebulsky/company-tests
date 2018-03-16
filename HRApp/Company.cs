using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    public class Company : ICompany
    {
        private readonly string _name;
        private readonly List<Employee> _employees;

        public Company(string name)
        {
            _name = name;
            _employees = new List<Employee>();
        }

        public string GetCompanyName()
        {
            return _name;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public List<Employee> GetAllEmployees(Department department)
        {
            return _employees.Where(e=>e.Department==department).ToList();
        }

        public Employee GetEmployeeByName(string firstName, string lastName)
        {
            return _employees.First(e => e.FirstName == firstName && e.LastName == lastName);
        }
    }
}
