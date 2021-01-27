using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class GermanTeam : ITeam
    {
        public string Name { get; } = "Третий Рейх";

        public List<IWarItem> WarItems { get; set; } = new List<IWarItem>();

        public GermanTeam(DBManager db)
        {
            WarItems.AddRange(GetSquad(db));
        }
        public List<ISoldier> GetSquad(DBManager db)
        {
            List<ISoldier> squad = new List<ISoldier>();
            for (int i = 0; i < 8; i++)
            {
                squad.Add(new Rifleman($"{db.GermanNames[new Random().Next(0, 14)]} {db.GermanLastNames[new Random().Next(0, 14)]}", new Rifle("Винтовка Маузера")));
            }
            squad.Add(new MashineGunner($"{db.GermanNames[new Random().Next(0, 14)]} {db.GermanLastNames[new Random().Next(0, 14)]}", new MashineGun("MG-34")));
            squad.Add(new SquadLeader($"{db.GermanNames[new Random().Next(0, 14)]} {db.GermanLastNames[new Random().Next(0, 14)]}", new PPGun("MP-40")));

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
