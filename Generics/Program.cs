using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int> { Success = true, Data = 6 };

            var helper = new ResultPrinter<int>();

            helper.print(result);
        }

        public class Result<T>
        {
            public bool Success { get; set; }
            public T Data { get; set; }
        }

        public class ResultPrinter<T>
        {
            public void print(Result<T> result)
            {

                Console.WriteLine(result.Success);
                Console.WriteLine(result.Data);
            }
        }
    }
}
