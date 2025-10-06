using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class Genericclasses
    {
        Dictionary<int, string> employees;
        HashSet<string> counties;
        public Genericclasses() 
        {
            employees = new Dictionary<int, string>();
            counties= new HashSet<string>();


        }

        public void AddDictionary()
        {
            employees.Add(1, "BOB");
            employees.Add(2, "John");
            employees.Add(3, "Shyam");
            employees[4] = "Ram";
        }

        public void PrintDictionary(int value)
        {
            if (employees.ContainsKey(value))
            {
                Console.WriteLine(employees[value]);
            }
        }

        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"EmpID:{employee.Key}, Empname :{employee.Value}  ");
            }
        }

        public void RemoveEmployee(int value)
        {

            if (employees.ContainsKey(value))
            {
                employees.Remove(value);
            }
        }

        public void RemoveEmployeeByValue(string value)
        {

            var keyassociateValue = employees.FirstOrDefault(x=>x.Value == value).Key;
            employees.Remove(keyassociateValue);
            
        }

        public void AddHashSet()
        {
            counties.Add("USA");
            counties.Add("India");
            counties.Add("UK");
        }

        public void AccessHashset(string value)
        {   
            if (counties.Contains(value))
            {
                Console.WriteLine(value);
            }
        }

        public void RemoveHashset(string value)
        {
            if (counties.Contains(value))
            {
               counties.Remove(value);
            }
        }


    }
}
