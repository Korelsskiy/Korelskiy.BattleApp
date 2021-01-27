using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class GermanTeam : ITeam
    {
        public string Name { get; } = "Третий Рейх";

        public List<IWarItem> WarItems { get; set; } = new List<IWarItem>();

        public GermanTeam()
        {
            WarItems.AddRange(GetSquad());
        }
        public List<ISoldier> GetSquad()
        {
            List<ISoldier> squad = new List<ISoldier>();
            for (int i = 0; i < 8; i++)
            {
                squad.Add(new Rifleman($"Стрелок{i}", new Rifle("Винтовка Маузера")));
            }
            squad.Add(new MashineGunner("Пулеметчик", new MashineGun("MG-34")));
            squad.Add(new SquadLeader("Командир отделения", new PPGun("MP-40")));

            return squad;
        }

        public void Lose()
        {
            throw new NotImplementedException();
        }

        public void Win()
        {
            throw new NotImplementedException();
        }
    }
}
