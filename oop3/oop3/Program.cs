using System;

namespace oop3
{
    class Animal
    {
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal(string species, string name)
        {
            this.species = species;
            this.name = name;
        }
        public Animal(Animal animal) //Служит для создания копии экземпляра класса
        {
            this.name = animal.name;
            this.species = animal.species;
        }
        private string name;
        private string species;
        public void Rename(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Species: {species}\nName: {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Animal("Cat", "Tom");
            Animal cat2 = new Animal(cat1);
            cat2.Rename("Bars");
            cat1.Print();
            Console.WriteLine();
            cat2.Print();

        }
    }
}
