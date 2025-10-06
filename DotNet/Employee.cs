using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string Department { get; set; } = string.Empty;
        public double Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(string name, int employeeId)
        {
            this.Name = name;
            this.EmployeeID = employeeId;
        }
       
    }
    
    public class FullTimeEmployee : Employee 
    {
        public double Salary { get; set; }

        public FullTimeEmployee(string name, int employeeId, double salary) : base(name, employeeId)
        {
            this.Name=name;
            this.Salary = salary;
        }

    }

    public class PartTimeEmployee : Employee
    {
       

        public double HourlySalary { get; set; }

        public PartTimeEmployee()
        {
        }
    }

    public static class EmployeeExtention
    {
        public static string GetDispsName(this Employee emp)
        {
            return $"{emp.EmployeeID}: {emp.Name}";
        }
    }
}
