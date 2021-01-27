using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class SquadLeader : Soldier
    {
        public SquadLeader(string rank, string name, string weaponName)
        {
            Type = "Командир отделения";
            Rank = rank;
            Name = name;
            Weapon = new SubmashineGun(weaponName);
            Health = new Random().Next(150, 200);
        }
        public override void Shoot(List<Soldier> potentialVictims)
        {
            throw new NotImplementedException();
        }
    }
}
