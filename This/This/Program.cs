using System;

namespace This
{
    class Human
    {
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Human(string name, int age, string gender) : this(name, age)
        {
            this.gender = gender;
        }
        private string name;
        private int age;
        private string gender;
        public void PrintHuman()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nGender: {gender}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human man = new Human("Misha", 18, "Man");
            man.PrintHuman();
        }
    }
}
