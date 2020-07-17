using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[3, 4, 5];
            Random randint = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = randint.Next(100);
                    }
                }
            }
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
