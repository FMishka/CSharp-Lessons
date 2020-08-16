using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out0
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        //Переменной "array" нужно задать какое-то значение
        static void Zero(out int[] array, int len)
        {
            array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = 0;
            }
        }
        //Переменной "array" необязательно задавать значение
        static void Rise(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            PrintArray(myArray);
            Rise(ref myArray);
            PrintArray(myArray);
            int[] myArray1;
            int[] myArray2 = new int[10];
            Zero(out myArray1, 14);
            Zero(out myArray2, 15);
            Console.WriteLine("Массив 1");
            PrintArray(myArray1);
            Console.WriteLine("Массив 2");
            PrintArray(myArray2);
        }
    }
}
