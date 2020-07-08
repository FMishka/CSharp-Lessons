using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
	class Program
	{
		static void Main(string[] args)
		{
			int h;
			Console.WriteLine("ДЗ 3");
            Console.Write("Введите высоту ");
			h = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < h; i++)
            {
				Console.SetCursorPosition(h - i, i + 2);
                for (int j = 0; j <= i; j++)
                {
					Console.Write("*");
                }
                Console.WriteLine();
            }

		}
	}
}
