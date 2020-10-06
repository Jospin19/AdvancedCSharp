using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var People = new List<Person>
            {
                new Person {FirstName = "NSSO", LastName = "Hugues", Age = 21},
                new Person {FirstName = "EKEME", LastName = "Hugues", Age = 22},
                new Person {FirstName = "Tiomo", LastName = "Leticia", Age = 18},
                new Person {FirstName = "Charlie", LastName = "Leticia", Age = 22},
                new Person {FirstName = "Bidja", LastName = "Salomon", Age = 19}
            };

            var result = from p in People
                         where p.LastName == "Hugues"
                         select new { FName = p.FirstName, LName = p.LastName};

            foreach (var p in result)
                Console.WriteLine($"{p.FName} {p.LName}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }

}
