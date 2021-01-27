using System;
using System.Collections.Generic;
using System.Text;

namespace Logics.Units
{
    public class SovietSquad : Squad
    {
        public SovietSquad()
        {
            Name = "Пехотное отделение РККА";
            Personnel = CreateSquad();
        }
        public override List<Soldier> CreateSquad()
        {
            List<Soldier> soldiers = new List<Soldier>();
            for (int i = 0; i < 8; i++)
            {
                Soldier soldier = new Rifleman("Рядовой", $"{DBManager.USSRNames[new Random().Next(0, 14)]} {DBManager.USSRLastNames[new Random().Next(0, 14)]}", "Винтовка Мосина");
                soldiers.Add(soldier);
            }
            soldiers.Add(new MashineGunner("Ефрейтор", $"{ DBManager.USSRNames[new Random().Next(0, 14)]} {DBManager.USSRLastNames[new Random().Next(0, 14)]}", "ДП-27"));
            soldiers.Add(new SquadLeader("Младший сержант", $"{ DBManager.USSRNames[new Random().Next(0, 14)] } { DBManager.USSRLastNames[new Random().Next(0, 14)]}", "ППД-40"));

            return soldiers;
        }

    }
}
