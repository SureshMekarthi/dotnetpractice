//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNet
//{
//    private class Person
//    {
//        public string firstName;
//        public string lastName;
//        public Person(string firstName, string lastName)
//        {
//            this.firstName = firstName;
//            //this.lastName = lastName;
//        }

//        //public string FirstName { get { return firstName; } }
//        //public string LastName { get { return lastName; } }

//        //public virtual string FullNAme(string firstName, string lastName)
//        //{
//        //    return firstName + " " + lastName;
//        //}
//        //public void EditFirstName(string firstName)
//        //{
//        //    this.firstName=firstName; 
//        //}
//        //public void  EditLastName(string lastName)
//        //{
//        //    this.lastName=lastName;
//        //}

//        private string _name;

//        public string Name {
//            get { return _name; }
//            set { _name = value; }
//        }
//        public string FirstName { get; set; }

//        public string FirstName1;

//        public static Person operator +(Person a, Person b)
//        {
//            return new Person("Suresh", "Mek");
//        }

//    }
//    internal class Student: Person
//    {
       
//        public int age;
//        public Student(int age, string firstName, string lastName) : base(firstName, lastName)
//        {
//            this.age = age;
//        }

//        //public override string FullNAme(string firstName, string lastName)
//        //{
//        //    return "Mr."+firstName + " " + lastName;
//        //}

//        //public string StudentName()
//        //{ 
//        //    var fullName = base.FullNAme(firstName, lastName);
//        //    return "Mr."+fullName;
//        //}

//        public void StudentClass()
//        {
//            Console.WriteLine("StudentName");
//        }
//    }


//    public class Animal
//    {
//        public void Speak() => Console.WriteLine("Animal sound");
//    }

//    public class Dog : Animal
//    {
//        public void Bark() => Console.WriteLine("Dog barks");
//    }

//}
