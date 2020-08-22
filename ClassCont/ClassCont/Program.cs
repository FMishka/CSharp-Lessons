using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivanov;
//"Псевдоним" для пространства имён "Petrovich"
using P = Petrovich.Petr;

namespace ClassCont
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ivanov.Ivan.Name());
            Console.WriteLine(Ivanov.Petr.Name());
            //Сокращение название класса на строке 7
            Console.WriteLine(P.Name());
            //Работает из-за строки 6
            Console.WriteLine(Ivan.Name());
            Console.WriteLine(Petr.Name());
            Console.WriteLine();
            Console.WriteLine(Oleg.Name.FullName());
        }
    }
}
//Пример
//Приписка "internal" означает, что классы видны только в одном проекте (если на его месте ничего нет, то считается что по умолчанию стоит internal)
namespace Ivanov
{
    internal static class Ivan
    {
        public static string Name()
        {
            return "Иванов Иван";
        }
    }

    public static class Petr
    {
        public static string Name()
        {
            return "Иванов Пётр";
        }
    }
}

namespace Petrovich
{
    public static class Petr
    {
        public static string Name()
        {
            return "Петрович Пётр";
        }
    }
}