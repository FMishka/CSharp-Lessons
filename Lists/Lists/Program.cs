using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Списки
            List<int> myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(myList[1]);
            //Кортежи
            var tuple = (10, 11, "23");
            Console.WriteLine(tuple);
            var tuple1 = (first:10, second:11, third:"23");
            Console.WriteLine(tuple1.first);
            var (name, number) = ("Jhon", 123);
            Console.WriteLine(name);
        }
    }
}
