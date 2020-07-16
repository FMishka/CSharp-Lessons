using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поиск максимума
            int firstNumber, secondNumber;
            Console.WriteLine("Введите первое число");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            secondNumber = int.Parse(Console.ReadLine());
            NumberManipulator numb = new NumberManipulator();
            Console.WriteLine(numb.findMax(firstNumber, secondNumber));
            //Объявление человека
            Human man = new Human();
            man.Name = "Tom";
            man.Age = 21;
            Console.WriteLine("Name: " + man.Name + "\nAge: " + man.Age.ToString());

        }
    }
}
