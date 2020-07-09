using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int countStr, countCol;
			Console.WriteLine("Введите число столбцов");
			countCol = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите число строк");
			countStr = int.Parse(Console.ReadLine());
			int[,] myArray = new int[countStr, countCol];
			if (countCol == countStr)
			{
				for (int i = 0; i < countStr; i++)
				{
					for (int j = 0; j < countCol; j++)
					{
						if ((i == j) || (i + j == countStr-1))
						{
							myArray[i, j] = 1;
						}
						else
						{
							myArray[i, j] = 0;
						}
					}
				}
			}
			else
			{
                for (int i = 0; i < countStr; i++)
                {
                    for (int j = 0; j < countCol; j++)
                    {
						myArray[i, j] = j+1;
                    }
                }
			}
			for (int i = 0; i < countStr; i++)
			{
				for (int j = 0; j < countCol; j++)
				{
					Console.Write(myArray[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
