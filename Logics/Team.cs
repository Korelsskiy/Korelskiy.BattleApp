using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class Team : ITeam
    {
        public string Name { get; }

        public List<IWarItem> WarItems { get; }

        public void Lose()
        {
            Console.WriteLine($"Team {this.Name} loose");
        }

        public void Win()
        {
            Console.WriteLine($"Team {this.Name} win");
        }
    }
}
