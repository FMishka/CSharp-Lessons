using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions1
{
    class Program
    {
        static void PrintStr(string symbols, uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbols);
            }
        }
        static int SearchNumb(int numb, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numb)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //Создание строки
            Console.WriteLine("Введите символы");
            string str = Console.ReadLine();
            Console.WriteLine("Введите количество повторов этих символов");
            uint countStr = uint.Parse(Console.ReadLine());
            PrintStr(str, countStr);
            //Поиск первого индекса элемента
            Console.WriteLine();
            Console.WriteLine("Введите значение элемента");
            int[] myArray = { 2, 3, 4, 6 , 7, 8, 9, 9, 9, 4};
            int number = int.Parse(Console.ReadLine());
            int result = SearchNumb(number, myArray);
            Console.WriteLine(result);
        }
    }
}
