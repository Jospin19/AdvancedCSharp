using System;

namespace AnonymousAndLambda
{
    //delegate void Operation(int num);

    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> Double = new Func<int, int>(delegate (int num) { return num * 2; });

            //Action<int> Double = new Action<int>(delegate (int num) { Console.WriteLine("{0} * 2 = {1}", num, num * 2); });

            //Operation op = delegate (int num) { Console.WriteLine("{0} * 2 = {1}", num, num * 2); };

            //Operation op = (int num) => { Console.WriteLine("{0} * 2 = {1}", num, num * 2); }; ======Lambda======


            Action<int> op = new Action<int>((num) => { Console.WriteLine("{0} * 2 = {1}", num, num * 2); });
            //Action<int> op1 = (num) => { Console.WriteLine("{0} * 2 = {1}", num, num * 2); };
            op(2);
        }

        //static void Double(int num)
        //{
        //    Console.WriteLine("{0} * 2 = {1}", num, num * 2);
        //}
    }
}
