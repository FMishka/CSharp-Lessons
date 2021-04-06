using System;

namespace AbstractClass
{
    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void Info()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Урон = {Damage}");
        }
    }
    class Gun : Weapon
    {
        public override int Damage { get { return 10; } }
        public override void Fire()
        {
            Console.WriteLine("*Выстрел из пушки*");
        }
    }
    class Bow : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("*Выстрел из лука*");
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(Weapon weapon)
        {
            weapon.Info();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new Bow() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
            }
        }
    }
}
