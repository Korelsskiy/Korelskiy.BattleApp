using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class SovietTeam : ITeam
    {
        public string Name { get; } = "СССР";

        public List<IWarItem> WarItems { get; set; } = new List<IWarItem>();
        public SovietTeam(DBManager db)
        {
            WarItems.AddRange(GetSquad(db));
        }
        public List<ISoldier> GetSquad(DBManager db)
        {
            List<ISoldier> squad = new List<ISoldier>();
            for (int i = 0; i < 8; i++)
            {
                squad.Add(new Rifleman($"{db.USSRNames[new Random().Next(0, 14)]} {db.USSRLastNames[new Random().Next(0, 14)]}", new Rifle("Винтовка Мосина")));
            }
            squad.Add(new MashineGunner($"{db.USSRNames[new Random().Next(0, 14)]} {db.USSRLastNames[new Random().Next(0, 14)]}", new MashineGun("ДП-27")));
            squad.Add(new SquadLeader($"{db.USSRNames[new Random().Next(0, 14)]} {db.USSRLastNames[new Random().Next(0, 14)]}", new PPGun("ППД-40")));

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
