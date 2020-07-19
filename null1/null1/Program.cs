using System;

namespace null1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оператор "??=" не работает на .NET Framework 4.7.2
            string str = null;
            str ??= string.Empty;
            Console.WriteLine(str.Length);
            string str1 = "text";
            str1 ??= string.Empty;
            Console.WriteLine(str1.Length);
        }
    }
}
