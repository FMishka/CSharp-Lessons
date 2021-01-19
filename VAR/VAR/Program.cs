using System;
using System.Linq;

namespace VAR
{
    class Program
    {
        static int Sum(int a, int b)
        {
            var result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            var test = new {text = "Text", number = 23 };
            Console.WriteLine(test.GetType());


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = from i in numbers where i > 5 select i; //Использовав Linq

            foreach(var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            var a = Sum(5, 7);
        }
    }
}
