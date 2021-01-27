using System;
using System.Collections.Generic;
using System.Text;

namespace Logics.Units
{
    public class GermanSquad : Squad
    {
        public GermanSquad()
        {
            Name = "Пехотное отделение вермахта";
            Personnel = CreateSquad();
        }
        public override List<Soldier> CreateSquad()
        {
            List<Soldier> soldiers = new List<Soldier>();
            for (int i = 0; i < 8; i++)
            {
                Soldier soldier = new Rifleman("Шутце", $"{DBManager.GermanNames[new Random().Next(0, 14)]} {DBManager.GermanLastNames[new Random().Next(0, 14)]}", "Винтовка Маузера");
                soldiers.Add(soldier);
            }
            soldiers.Add(new MashineGunner("Ефрейтор", $"{ DBManager.GermanNames[new Random().Next(0, 14)]} {DBManager.GermanLastNames[new Random().Next(0, 14)]}", "MG-34"));
            soldiers.Add(new SquadLeader("Унтер-офицер", $"{ DBManager.GermanNames[new Random().Next(0, 14)] } { DBManager.GermanLastNames[new Random().Next(0, 14)]}", "MP-40"));

            return soldiers;
        }
    }
}
