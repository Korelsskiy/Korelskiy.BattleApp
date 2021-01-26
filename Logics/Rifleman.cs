using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class Rifleman : IWarItem
    {
        public string Name { get; }

        public int Health => 100;

        public IWeapon Weapon { get; }

        public Rifleman(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
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
