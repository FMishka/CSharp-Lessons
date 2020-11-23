using System;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            a++; // переполнение через верхнюю границу
            Console.WriteLine(a);
            int b = int.MinValue;
            b--; // переполнение через верхнюю границу
            Console.WriteLine(b);
            byte v = 0;
            try
            {
                v = checked((byte)(v - 1)); // проверка на переполнение
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение!");
            }
            // можно и так проверять
            checked
            {

            }
            // если во всём проекте влючена проверка на переполнение, то этот фрагмент не проверяется
            unchecked
            {

            }
            double first = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(first));
            double second = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(second));
            double third = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(third));

            decimal aa = decimal.MaxValue;
            decimal bb = decimal.MaxValue;
            try
            {
                decimal cc = unchecked(aa + bb); // всегда будет переполнение
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение!");
            }
            
        }
    }
}
