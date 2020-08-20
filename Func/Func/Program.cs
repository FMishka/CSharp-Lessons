using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Значение a = " + a);
                Console.WriteLine("значение b = " + b);
                Console.WriteLine("Результат: " + result);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int c = Sum(1, 2);
            Console.WriteLine(c);
            int c1 = Sum(1, 2, true);
        }
    }
}
