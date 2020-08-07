using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        //Test (Example)
        class Human
        {
            public int Age { get; set; }
            public string Sex { get; set; }
            public string Name { get; set; }

            public void SayHello()
            {
                Console.WriteLine("Привет");
            }
        }
        class Driver : Human
        {
            public void Drive()
            {
                Console.WriteLine("Едем, едем");
            }
        }
        static void Main(string[] args)
        {
            Driver man = new Driver();
            man.Age = 47;
            man.Sex = "Male";
            man.Name = "Доплаёп";

            Console.WriteLine(man.Name);
            Console.WriteLine(man.Age);
            Console.WriteLine(man.Sex);
            man.SayHello();
            man.Drive();
            //upcast
            Human man1 = man;
            //downcast
            Driver boozer = (Driver)man1;
            bool isBoozer = man is Driver;

            if (isBoozer)
            {
                Driver boozer1 = (Driver)man;
            }

            if (man is Driver boozer4)
            {
                boozer4.Drive();
            }

            Driver boozer3 = man as Driver;
            if (boozer3 != null)
            {
                boozer3.Drive();
            }
        }
    }
}
