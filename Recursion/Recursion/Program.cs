using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Foo(int a, int max)
        {
            Console.WriteLine(a);
            if (a >= max)
                return;
            a++;
            Foo(a, max);
        }
        static void PrintArray(int[] array, int count = 0)
        {

            if (count < array.Length)
            {
                Console.WriteLine(array[count++]);
                PrintArray(array, count);
            }
            return;
        }
        static int SumArray(int[] array, int count = 0)
        {
            if (count == array.Length)
                return 0;

            int sum = SumArray(array, count + 1);
            return array[count] + sum;
        }
        static int SumNumb(int number)
        {
            if (number % 10 == 0)
                return 0;
            int sum = SumNumb(number / 10);
            number = number % 10;
            return number + sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тест");
            Foo(0, 10);
            int[] arr = new int[] { 1, 2, 3};
            Console.WriteLine();
            Console.WriteLine("Проверка функции PrintArray");
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("Проверка функции SumArray");
            int sumArray = SumArray(arr);
            Console.WriteLine(sumArray);
            Console.WriteLine();
            Console.WriteLine("Проверка функции SumNumb");
            int numb = SumNumb(561);
            Console.WriteLine(numb);
        }
    }
}
