using System;
using System.Linq;
using System.Reflection;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);

            foreach(var type in types)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribut>().Count() > 0);

                foreach(var method in methods)
                {
                    Console.WriteLine($"\t Method : {method.Name}");
                }
            }

            /*
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            
            foreach(var type in types)
            {
                Console.WriteLine($"Type : {type.Name}");

                //Pour récupérer les propriétés 
                var props = type.GetProperties();
                foreach(var prop in props)
                {
                    Console.WriteLine($"\t Propperty : {prop.Name} Property Type : {prop.PropertyType}");
                }

                //Pour récupérer les champs
                var fields = type.GetFields();
                foreach(var field in fields)
                {
                    Console.WriteLine($"\t Field : {field.Name}");
                }

                //Pour récupérer les méthodes
                var methods = type.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine($"\t Method : {method.Name}");
                }

                var sample = new Sample
                {
                    Name = "Hugues",
                    Age = 21
                };

                var sampleType = typeof(Sample); //On pourrait faire sampleType = sample.GetType()

                var nameProperty = sampleType.GetProperty("Name");

                var myMethod = sampleType.GetMethod("MyMethod");

                myMethod.Invoke(sample, null);

                //Console.WriteLine($"Property : {nameProperty.GetValue(sample)}");
            }
            */
        }


        [MyClass]
        public class Sample
        {
            public string Name { get; set; }
            public int Age;


            [MyMethodAttribut]
            public void MyMethod()
            {
                Console.WriteLine("Bonjour le monde");
            }

            public void NoAttributeMethod() { }
        }

        [AttributeUsage(AttributeTargets.Class)]
        public class MyClassAttribute : Attribute { }


        [AttributeUsage(AttributeTargets.Method)]
        public class MyMethodAttribut : Attribute { }


    }
}
