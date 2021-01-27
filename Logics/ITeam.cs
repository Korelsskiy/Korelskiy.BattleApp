using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public interface ITeam
    {
        public string Name { get; }
        public List<IWarItem> WarItems { get; }
        public List<ISoldier> GetSquad();
        public void Win();
        public void Lose();
    }
}
