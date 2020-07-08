using System;
using System.Globalization;
using System.Linq;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 21, 12, 773, 54, 35, 16};
			int[] result = myArray.OrderBy(i => i).ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
		} 
	}
}