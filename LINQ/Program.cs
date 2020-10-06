using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
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

            //var result = from c in sample
            //             where c == 'a' || c == 'o' || c == 'u'
            //             orderby c ascending //descending
            //             //goupby : we have to group something by something else (Doit être la dernière instruction)
            //             group c by c;
            //             //select c;

            var result = from p in People
                         orderby p.FirstName
                         //where p.Age < 30 && p.LastName == "Hugues"
                         group p by p.LastName;
                         //select p;

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " : " + item.Count());

                foreach (var p in item)
                    Console.WriteLine($"\t {p.FirstName} {p.LastName}");
            }
                //Console.WriteLine($"{p.FirstName} {p.LastName}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
