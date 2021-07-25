using System;

namespace Explicit_Interface_Implementation
{
    interface IFirstInterface
    {
        void Action();
    }
    interface ISecondInterface
    {
        void Action();
    }

    class FirstSomeClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("Action by FirstClass");
        }
    }
    class SecondSomeClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("Action by first interface");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("Action by second interface");
        }
    }
    class Program
    {
        static void Foo(IFirstInterface first)
        {
            first.Action();
        }
        static void Bar(ISecondInterface second)
        {
            second.Action();
        }
        static void Main(string[] args)
        {
            FirstSomeClass someClass = new FirstSomeClass();
            Foo(someClass);
            Bar(someClass);
            Console.WriteLine();
            SecondSomeClass secondSomeClass = new SecondSomeClass();
            Foo(secondSomeClass);
            Bar(secondSomeClass);
            //Можно так реализовывать в программе
            if (secondSomeClass is IFirstInterface firstInterface)
            {
                firstInterface.Action();
            }
            if (secondSomeClass is ISecondInterface secondInterface)
            {
                secondInterface.Action();
            }
        }
    }
}

