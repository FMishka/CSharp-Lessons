using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Program
    {
        //Почему-то когда вызываю функцию "printSpec" выводятся значения, которые были заданы при первом вызове, 
        //но если посмотреть работу в отладчике, то всё отлично работает

        static void Main(string[] args)
        {
            Human man = new Human();
            man.initSpec();
            man.Name = "Том";
            man.Sex = "Мужчина";
            man.Age = 22;
            Console.WriteLine("Имя: " + man.Name);
            Console.WriteLine("Пол: " + man.Sex);
            Console.WriteLine("Возраст: " + man.Age);
            Console.WriteLine();
            man.printSpec();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Driver driver = new Driver();
            driver.initSpec();
            driver.Name = "Толя";
            driver.Sex = "Мужчина";
            driver.Age = 37;
            driver.printSpec();
            driver.checkInt();
            driver.Drive();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            driver.initSpec();
            driver.printSpec();
        }
    }
}
