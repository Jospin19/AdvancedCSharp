using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;

            foreach(var t in types)
            {
                /*
                 * Cette liste d'instruction va grace a la propriété Name de la classe Type (GetTypes revoie Type et on utilise Type.Name)
                 * Récupérer le nom de toutes les classes qui sont décoées avec la classe SampleAttribute
                 * */
                Console.WriteLine(t.Name);

                foreach(var p in t.GetProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }

        [AttributeUsage(AttributeTargets.Class )]
        public class SampleAttribute : Attribute
        {
            public string Name { get; set; }
            public int Version { get; set; }

        }


        [Sample(Name = "Hugues", Version = 2)]
        public class Test
        {
            public int IntValue { get; set; }

            public void Method()
            {

            }
        }

        public class NoAttribute
        {
          
        }
    }
}
