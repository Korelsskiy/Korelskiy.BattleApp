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
                Console.WriteLine(new string('-', 50));
            }

            Console.ReadKey();

        }

        private static List<ITeam> GetTeams()
        {
            List<ITeam> teams = new List<ITeam>
            {
                new GermanTeam(),
                new SovietTeam()
            };

            return teams;
        }

        private static void DisplayArmyInfo(List<IWarItem> army)
        {
            foreach (ISoldier soldier in army)
            {
                Console.WriteLine($"Боец {soldier.Name} - {soldier.Weapon.Title} [{soldier.Health}]");
            }
        }
    }
}
