using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[3] { 1, 2, 3};
            int[] myArray1 = null;
            Console.WriteLine("Кол-во элементов в первом массиве: " + (myArray?.Length ?? 0));
            Console.WriteLine("Кол-во элементов в первом массиве: " + (myArray1?.Length ?? 0));
        }
    }
}
