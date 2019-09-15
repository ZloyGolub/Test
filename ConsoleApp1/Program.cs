using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Employee("Tom", "Smith", "Microsoft");
            tom.Display();      // Tom Smith работает в Microsoft
            Console.ReadKey();

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
        {
            Company = company;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
        }
    }
}
