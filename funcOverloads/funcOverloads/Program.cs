using System;

namespace funcOverloads
{
    class Program
    {
        /// <summary>
        /// Функция, которая суммирует два целых числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Функция, которая суммирует два дробных числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a1, b1, result1;
            double a2, b2, result2;
            Random rand = new Random();
            a1 = rand.Next(10);
            a2 = rand.NextDouble();
            b1 = rand.Next(10);
            b2 = rand.NextDouble();
            result2 = Sum(a2, b2);
            result1 = Sum(a1, b1);
            Console.WriteLine("1: " + result1 + " 2: " + result2);
        }
    }
}
