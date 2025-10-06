using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class LinqOperations
    {
        List<Employee> employees;
        public LinqOperations()
        {
            employees = new List<Employee>()
            {
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=5000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=6000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=7000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=4000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=2000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=1000},
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=5000}
            };
        }
    }
}
