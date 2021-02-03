using System;

namespace Structures
{
    struct User // Отличается от класса способом хранения, то есть это значимый тип и хранится в стеке
    {
        public string name; //Нельзя объявить здесь
        public int age; //Нельзя объявить здесь

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintUser()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user;
            user.name = "Иван";
            user.age = 19;
            user.PrintUser();

            User user1 = new User("Артём", 18);
            user1.PrintUser();

            User user2 = new User { name = "Владислав", age = 17 };
            user2.PrintUser();

            Int32 a = new Int32();
            a = 5;
            Console.WriteLine(a);
        }
    }
}
