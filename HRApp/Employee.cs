using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    public class Employee
    {
        public Department Department { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(Department department, string firstName, string lastName, int age, decimal salary)
        {
            Department = department;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            throw new NotImplementedException();
        }
    }
}
