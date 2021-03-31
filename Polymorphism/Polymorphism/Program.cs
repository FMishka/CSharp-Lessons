using System;

namespace Polymorphism
{
    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Едет обычная машина");
        }
    }
    class SportCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Едет спортивная машина");
        }
    }
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new SportCar());
        }
    }
}
