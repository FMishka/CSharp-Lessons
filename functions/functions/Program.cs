using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static int Sum(int first, int second)
        {
            return first + second;
        }

        static void Sum1(int first, int second)
        {
            Console.WriteLine(first + second);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            int result = Sum(a, b);
            Console.WriteLine("S = " + result);
            a *= 2;
            b *= 2;
            Console.WriteLine("a = " + a + " b = " + b);
            Sum1(a, b);
        }
    }
}
