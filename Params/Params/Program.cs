using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i< parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = Sum(1,2,3,6,7,7,7,7,8);
            Console.WriteLine(a);
        }
    }
}
