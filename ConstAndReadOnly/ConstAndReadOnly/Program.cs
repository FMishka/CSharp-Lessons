using System;

namespace ConstAndReadOnly
{
    class SomeClass
    {
        public const int a = 15; // Неявно статическое поле. Объявляется сразу
        public readonly int b; // Объявляется только в конструкторе
        public static readonly int bb; // Явно стаатическое поле.
        public SomeClass()
        {
            b = 14;
        }
        static SomeClass()
        {
            bb = 13;
        }
        public static void PrintA()
        {
            Console.WriteLine(a);
        }
        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var arg = new SomeClass();
            SomeClass.PrintA();
            Console.WriteLine(SomeClass.bb);
            arg.PrintB();
        }
    }
}
