using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class MashineGunner : ISoldier
    {
        public string Name { get; }

        public int Health { get; } = 100;
        public string Rank { get; } = "Рядовой пулеметчик";

        public IWeapon Weapon { get; }

        public MashineGunner(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
            Health = new Random().Next(120, 150);
        }
        public void Destroying()
        {
            Console.WriteLine($"{Name}: I'm killed.");
        }

        public void Shoot()
        {
            Weapon.Shoot();
        }
    }
}
