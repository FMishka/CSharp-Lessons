using System;

namespace Protected
{
    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;

        public void PrintFiels()
        {
            Console.WriteLine("Public = " + publicField);
            Console.WriteLine("Protected = " + protectedField);
            Console.WriteLine("Private = " + privateField);
        }
        public A()
        {
            Console.WriteLine("Class A\n");
            Console.WriteLine("Public = " + publicField);
            Console.WriteLine("Protected = " + protectedField);
            Console.WriteLine("Private = " + privateField);
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("\nClass B\n");
            Console.WriteLine("Public = " + publicField);
            //Console.WriteLine(privateField) - НЕДОСТУПЕН
            Console.WriteLine("Protected = " + protectedField);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine();
            b.PrintFiels();
        }
    }
}
