using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
            while (true)
            {
				Console.Clear();
				double a, b, c;
                try
                {
					Console.WriteLine("Введите первое число");
					a = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите второе число");
					b = double.Parse(Console.ReadLine());
				}
                catch (Exception)
                {
                    Console.WriteLine("Введено неверное число!");
					Console.ReadKey();
					continue;
                }
				Console.WriteLine("Введите операцию");
				string operation = Console.ReadLine();
				switch (operation)
				{
					case "+":
						c = a + b;
						Console.WriteLine("Результат: " + c);
						break;
					case "-":
						c = a - b;
						Console.WriteLine("Результат: " + c);
						break;
					case "*":
						c = a * b;
						Console.WriteLine("Результат: " + c);
						break;
					case "/":
						if (b != 0)
						{
							c = a / b;
							Console.WriteLine("Результат: " + c);
						}
						else
						{
							Console.WriteLine("На ноль делить нельзя!");
						}
						break;
					default:
						Console.WriteLine("Введён неверный символ!");
						break;
				}
				Console.ReadKey();
			}
		}
	}
}
