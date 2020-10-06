using System;

namespace Delegates
{
    delegate void Operation(int num);
   
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteOperation(2, Double);

            ExecuteOperation(2, Triple);
        }

        static void Double(int num)
        {
            Console.WriteLine("{0} * 2 = {1}", num, num * 2);
        }

        static void Triple(int num)
        {
            Console.WriteLine("{0} * 3 = {1}", num, num * 3);
        }

        static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }

        //static void SayHello(string name)
        //{
        //    Console.WriteLine("Bonjour {0} :-)", name);
        //}

        //static void Test(MyDelegate del)
        //{
        //    del.Invoke("Hugues");
        //}

        //static MyDelegate GiveMeMyDelegate()
        //{
        //    return new MyDelegate(SayHello);
        //}
    }
}
