using System;

namespace StaticConstructor
{
    class Class
    {
        public Class()
        {
            Console.WriteLine("Конструктор");
        }
        static Class() //Всегд выполняется только один раз. Всегда вызывается первым.
        {
            Console.WriteLine("Статический конструктор");
        }
        static public void Test()
        {
            Console.WriteLine("Test!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class.Test();

        }
    }
}
