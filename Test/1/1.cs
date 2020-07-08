using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine();
            string tri = "";
            int h;
            Console.Write("Введите высоту: ");
            h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                tri += "+";
                Console.Write(tri);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < h; i++)
            {
                for (int j = h; j > i;j--)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            tri = "";
            string spaces;
            for (int i = 0; i < h; i++)
            {
                tri += "+";
                spaces = "";
                for (int j = -1 - i; j > -h; j--)
                {
                   spaces += " ";
                }
                Console.Write(spaces + tri);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            spaces = "";
            for (int i = 0; i < h; i++)
            {
                tri = "";
                for (int j = 0 + i; j < h; j++)
                {
                    tri += "+";
                }
                Console.Write(spaces + tri);
                Console.WriteLine();
                spaces += " ";
            }
        }
	}
}
