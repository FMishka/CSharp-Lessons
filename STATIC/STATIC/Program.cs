using System;

namespace STATIC
{
    class MyClass
    {
        public int a;
        public static int b;
        private static int c;
        public void Func(int a, int c)
        {
            this.a = a + 2;
            MyClass.c = c * c + 2 * c + 2;
        }
        public void PrintC()
        {
            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass class2 = new MyClass();
            MyClass class1 = new MyClass();
            class1.a = 55;
            MyClass.b = 89;
            class1.Func(2, 23);
            class2.PrintC();
        }
    }
}
