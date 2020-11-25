using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            // Знак вопроса создаёт nullable-тип
            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a == null);
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(a ?? 100);
            try
            {
                Console.WriteLine(a.Value);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("null");
            }
            Console.WriteLine(a);

            int? b = 20;
            Console.WriteLine(b.HasValue);
            Console.WriteLine(b == null);
            Console.WriteLine(b.GetValueOrDefault());
            Console.WriteLine(b ?? 100);
            try
            {
                Console.WriteLine(b.Value);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("null");
            }
            Console.WriteLine(b);

            int? result = a + b;
            try
            {
                Console.WriteLine(result.Value);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Result = null");
            }
            Console.WriteLine(a<b);
            Console.WriteLine(a==b);
            Console.WriteLine(a>b);
        }
    }
}
