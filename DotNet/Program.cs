using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DotNet.DelegateTest;

namespace DotNet
{
    internal class Program
    {
        static FullTimeEmployee fte3 = new FullTimeEmployee("Employee3", 3, 100000);

        static void Main(string[] args)
        {

            // BankBase obj = new CurrentAccount("Raj", 123.02m);
            // Console.WriteLine(obj.CalulateTax());
            // obj = new SavingAccount("Raju", 123.02m);
            //Console.WriteLine(obj.CalulateTax());

            //FullTimeEmployee obj2 = new FullTimeEmployee();
            //Console.WriteLine(obj2.GetDispsName());

            //PartTimeEmployee obj3 = new PartTimeEmployee();
            //Console.WriteLine(obj3.GetDispsName());

            //ExceptionTest exceptionTest = new ExceptionTest();
            //exceptionTest.ExeptionHandling();

            //Test.DisplayName();




            //FullTimeEmployee fte = new FullTimeEmployee("Employee1", 1, 1000);


            // PartTimeEmployee pte = new PartTimeEmployee
            //{
            //    EmployeeID = 2,
            //    Name = "Employee2",
            //    HourlySalary = 10001,
            //};


            //Console.WriteLine(fte.GetDispsName());
            //Console.WriteLine(pte.GetDispsName());
            //Console.Read();


            //GenericBox<int> intBox = new GenericBox<int>();
            //intBox.SetValue(5);
            //GenericBox<string> stringBox = new GenericBox<string>();
            //Console.WriteLine( stringBox.Print("hello"));

            //GenericList<string> genericList = new GenericList<string>();
            //genericList.Add("Blob");
            //genericList.Print();

            //EmployeeOperations operations = new EmployeeOperations();

            //Employee employee = new Employee("Bob", 1);
            //Employee employee2 = new Employee("Ram", 2);
            //Employee employee3 = new Employee("shyam", 3);
            //operations.Add(employee);

            //operations.Get(3);


            List<Employee> employees = new List<Employee>()
            {
                new Employee{ EmployeeID=1, Name= "John", Department = "IT", Salary=5000},
                new Employee{ EmployeeID=2, Name= "Jose martin", Department = "CSE", Salary=6000},
                new Employee{ EmployeeID=3, Name= "Ram kumar", Department = "IT", Salary=7000},
                new Employee{ EmployeeID=4, Name= "Shyam abab", Department = "EEE", Salary=4000},
                new Employee{ EmployeeID=5, Name= "Rama krsihna", Department = "CVIL", Salary=2000},
                new Employee{ EmployeeID=6, Name= "Mike tyson", Department = "ECE", Salary=1000},
                new Employee{ EmployeeID=7, Name= "John marry", Department = "CSE", Salary=5000}
            };

            var result1 = employees.Where(e => e.Department == "IT" && e.Salary > 5000).Select(e => new { employeenumber = e.EmployeeID, e.Name });

            var result2 = employees.Where(e => e.Department == "IT" && e.Salary > 5000);

            //.Select new { employeenumber = e.empid }); 

            var orders = new List<Order>
                            {
                                new Order { CustomerId = 1, Amount = 200 },
                                new Order { CustomerId = 2, Amount = 150 },
                                new Order { CustomerId = 1, Amount = 350 }
                            };

            var customerorders = orders.GroupBy(g => g.CustomerId).Select(s => new
            {
                CustomerId = s.Key,
                Amount = s.Sum(a => a.Amount),
                orders = s.ToList()


            });

            var customers = new List<Customer>
            {
                new Customer{ Id =1, Name="Ram"},
                new Customer{ Id=2, Name= "syam"}
            };

            var customerOrders1 = from c in customers
                                 join o in orders on c.Id equals o.CustomerId
                                 select new { c.Name, o.Amount };



            foreach (var order in customerOrders1)
            {
                Console.WriteLine($" orders is{order.Name}, {order.Amount}, {order.Amount}");
            }


        

            var productIds = new List<int> { 1, 2, 3, 2, 4, 5, 1 };

            var duplictae = productIds.GroupBy(g=>g).Where(w=>w.Count() > 0).Select(w=>w.Key).ToList();


            var employees2 = new List<Employee>
                {
                    new Employee { EmployeeID = 1, Name = "Alice", Department = "IT" },
                    new Employee { EmployeeID = 2, Name = "Bob", Department = "HR" },
                    new Employee { EmployeeID = 3, Name = "Charlie", Department = "IT" },
                    new Employee { EmployeeID = 4, Name = "Alice", Department = "IT" }, // Duplicate by Name+Dept
                    new Employee { EmployeeID = 5, Name = "Bob", Department = "HR" }    // Duplicate by Name+Dept
                };

          //var   duplicateemployees = employees2.GroupBy(e=>e.Name).Where(e=>e.Count()>1).Select(e=>e.Key).ToList();

            var duplicateemployees1 = employees2.GroupBy(e => new { e.Name, e.Department } ).Where(e => e.Count() > 1).Select(e => new { name = e.Key.Name, e.Key.Department,  Count =e.Count()});


            foreach (var order2 in duplicateemployees1)
            {
                Console.WriteLine($" orders2 is{order2.name},{order2.Department} {order2.Count}");
            }

            Console.ReadLine();



            //DelegateTest obj = new DelegateTest();
            //obj.ShowMessage("hello");


            //int x = 10;

            //object obj1 = x; // boxing

            //int y = (int) obj1;// unboxing 


        }




    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Order
    {
        public int CustomerId { get; set; }
        public int Amount { get; set; }
    }

    public static class Test
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        public static void DisplayName()
        {
            Console.WriteLine("test");
        }
    }
}
