using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySort
{
    class Program
    {
        static void BoobleSort(ref int[] array)
        {
            int space;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        space = array[j];
                        array[j] = array[i];
                        array[i] = space;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Пузарьковый метод сортировки
            int[] myArray = new int[12];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(10);
            }
            BoobleSort(ref myArray);
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
