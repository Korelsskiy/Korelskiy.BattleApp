using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class Rifleman : ISoldier
    {
        public string Name { get; }

        public int Health { get; } = 100;

        public IWeapon Weapon { get; }

        public string Rank { get; } = "Рядовой стрелок";

        public Rifleman(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
            Health = new Random().Next(80, 120);
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
