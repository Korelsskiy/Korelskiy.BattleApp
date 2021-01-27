using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class SquadLeader : ISoldier
    {
        public string Name { get; }

        public int Health { get; } = 100;
        public string Rank { get; } = "Младший сержант";

        public IWeapon Weapon { get; }
        public SquadLeader(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
            Health = new Random().Next(150, 200);
        }
        public void Destroying()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
