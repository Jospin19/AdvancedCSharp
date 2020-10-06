using System;

namespace MethodesDExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "Hugues", Age = 21 };

            var p2 = new Person { Name = "Jean", Age = 21 };

            p.SayHello(p2);
        }
    }

    public static class MyExtensions
    {
        public static void SayHello(this Person person, Person person2)
        {
            Console.WriteLine($"{person.Name} say hello to {person2.Name}");
        }
    }
}
