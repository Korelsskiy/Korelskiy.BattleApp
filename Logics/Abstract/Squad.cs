using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public abstract class Squad : WarItem
    {
        public abstract List<Soldier> CreateSquad();
        public virtual void DisplayInConsole()
        {
            foreach (var item in Personnel)
            {
                Console.WriteLine($"{item.Rank} {item.Name} - {item.Weapon.Title}({item.Health})");
            }
        }
    }
}
