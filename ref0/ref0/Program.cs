using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref0
{
    class Program
    {
        static void test(ref int a)
        {
            a = -5;
        }
        static void test1(int[] arr)
        {
            arr = null;
        }
        static void test2(ref int[] arr)
        {
            arr = null;
        }
        /// <summary>
        /// Возвращает ссылочное значение
        /// </summary>
        /// <param name="arr"></param>
        static ref int test3(ref int[] arr)
        {
            return ref arr[1];
        }

        static void Main(string[] args)
        {
            int a = 2;
            test(ref a);
            Console.WriteLine(a);
            int[] myArray = new int[3] { 1, 2, 3 };
            int[] myArray1 = new int[3] { 4, 5, 6 };
            test1(myArray);
            test2(ref myArray1);
            Console.WriteLine(myArray?.Length ?? 0);
            Console.WriteLine(myArray1?.Length ?? 0);
            //Ссылочная локальная переменная
            int[] myArray2 = new int[3] { 7, 8, 9 };
            ref int b = ref myArray2[0];
            b = 11111;
            ref int c = ref test3(ref myArray2);
            c = 1324;

            Console.WriteLine("b = " + b);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
