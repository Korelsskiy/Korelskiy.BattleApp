using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public abstract class Soldier
    {
        public string Type { get; set; }
        public string Rank { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; set; }
        public Weapon Weapon { get; protected set; }
        public abstract void Shoot(List<Soldier> potentialVictims);
    }
}
