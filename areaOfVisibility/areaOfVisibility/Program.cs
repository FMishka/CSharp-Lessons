using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfVisibility
{
    class Program
    {
        static int test = 12;
        static void Test()
        {
            int test = 13;
            Console.WriteLine(test);
        }

        int a = 555;
        static int g = 123;
        static void Main(string[] args)
        {
            Program test = new Program();
            int b = test.a;
            Console.WriteLine(b);
            Console.WriteLine(g);
            Test();
        }
    }
}
