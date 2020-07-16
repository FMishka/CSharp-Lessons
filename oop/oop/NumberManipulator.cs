using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class NumberManipulator
    {
        public int findMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else if (firstNumber < secondNumber)
            {
                return secondNumber;
            }
            else
            {
                return firstNumber;
            }
        }
    }
}
