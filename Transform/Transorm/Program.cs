using System;

namespace Transorm
{
    class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            double a = 5.3;
            float b = (float)a;
            Foo(b);
            int aa = 257;
            //Расширяющее преобразование
            float bb = aa;
            byte q = (byte)aa;
            bool w = Convert.ToBoolean(a);

            float first = 2.5f;
            int second = 4;

            int result = (int)(second +first);
            result = second + (int)first;
        }
    }
}
