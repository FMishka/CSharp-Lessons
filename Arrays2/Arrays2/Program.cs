using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //зубчатые массивы
            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[10];
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(100);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
