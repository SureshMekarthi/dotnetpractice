using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class EmployeeOperations
    {
        List<Employee> employeeList;

        public EmployeeOperations()
        {
            employeeList = new List<Employee>();
           
        }


        public void Add(Employee value)
        {
            employeeList.Add(value);
        }

        public void Print()
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.EmployeeID} {employee.Name}");
            }
        }

        public Employee Get(int id)
        {
            Employee result = employeeList.Find(x=>x.EmployeeID ==id);
            // IEnumerable<Employee> result1 = employeeList.Where(x =>x.EmployeeID == id);
            return result;
        }

        public IEnumerable<Employee> GetList(int id)
        {
            //Employee result = employeeList.Find(x => x.EmployeeID == id);
            // IEnumerable<Employee> result1 = employeeList.Where(x =>x.EmployeeID == id);
            IEnumerable<Employee> result1 = from employee in employeeList where employee.EmployeeID == id select employee;
            return result1;
        }
        public IEnumerable<Employee> GetAll()
        {
          //  Employee result = employeeList.Find(x => x.EmployeeID == id);
            IEnumerable<Employee> result1 = employeeList;
            return result1;
        }

        public Employee Update(Employee value)
        {
            Employee employee= employeeList.Find(x=>x.EmployeeID==value.EmployeeID);

            if (employee == null)
            {
                //  return null;
                throw new Exception("employee not found");
            }
            employee.Name = value.Name;
            return employee;
            
        }

        public bool Delete(int id)
        {
            Employee employee = employeeList.Find(x => x.EmployeeID == id);

            if (employee == null)
            {
                //  return null;
               // throw new Exception("employee not found");
               return false;
            }

            employeeList.Remove(employee);
            return true;
        }

    }
}
