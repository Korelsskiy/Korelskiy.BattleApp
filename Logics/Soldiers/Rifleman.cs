using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class Rifleman : Soldier
    {
        public Rifleman(string rank, string name, string weaponName)
        {
            Type = "Стрелок";
            Rank = rank;
            Name = name;
            Weapon = new Rifle(weaponName);
            Health = new Random().Next(80, 120);
        }
        public override void Shoot(List<Soldier> potentialVictims)
        {
            throw new NotImplementedException();
        }
    }
}
