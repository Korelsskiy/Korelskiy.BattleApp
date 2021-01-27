using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class MashineGunner : Soldier
    {
        public MashineGunner(string rank, string name, string weaponName)
        {
            Type = "Пулеметчик";
            Rank = rank;
            Name = name;
            Weapon = new MashineGun(weaponName);
            Health = new Random().Next(120, 150);
        }
        public override void Shoot(List<Soldier> potentialVictims)
        {
            throw new NotImplementedException();
        }
    }
}
