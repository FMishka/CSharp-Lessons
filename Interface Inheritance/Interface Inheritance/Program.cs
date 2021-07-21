using System;

namespace Interface_Inheritance
{
    interface IWeapon
    {
        void Fire();
    }

    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon weapon)
        {
            weapon.Throw();
        }
    }

    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("*Выстрел из пушки*");
        }
    }

    class Pistol : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("*Выстрел из пистолета*");
        }
    }

    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine("*Атака ножом*");
        }

        public void Throw()
        {
            Console.WriteLine("*Кидание ножа*");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] inventory = { new Gun(), new Pistol(), new Knife()};
            foreach (var item in inventory)
            {
                player.Fire(item);
            }
            player.Throw(new Knife());
        }
    }
}
