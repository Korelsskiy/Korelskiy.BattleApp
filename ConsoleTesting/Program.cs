using Logics;
using System;
using System.Collections.Generic;

namespace ConsoleTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in GetTeams())
            {
                Console.WriteLine($"Команда: {item.Name}");
                DisplayArmyInfo(item.WarItems);
                Console.WriteLine(new string('-', 60));
            }

            Console.ReadKey();

        }

        private static List<ITeam> GetTeams()
        {
            DBManager db = new DBManager();
            List<ITeam> teams = new List<ITeam>
            {
                new GermanTeam(db),
                new SovietTeam(db)
            };

            return teams;
        }

        private static void DisplayArmyInfo(List<IWarItem> army)
        {
            foreach (ISoldier soldier in army)
            {
                Console.WriteLine($"{soldier.Rank} {soldier.Name} - {soldier.Weapon.Title} [{soldier.Health}]");
            }
        }
    }
}
