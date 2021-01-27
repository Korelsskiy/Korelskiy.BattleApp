using Logics;
using Logics.Units;
using System;
using System.Collections.Generic;

namespace ConsoleTesting
{
    public class Program
    {
        private DBManager db = new DBManager();
        static void Main(string[] args)
        {
            List<Squad> battleTeams = GetTeams();

            foreach (var item in battleTeams)
            {
                Console.WriteLine($"Команда: {item.Name}");
                item.DisplayInConsole();
                Console.WriteLine(new string('-', 60));
            }

            Console.ReadKey();

        }

        private static List<Squad> GetTeams()
        {
            List<Squad> teams = new List<Squad>
            {
                new GermanSquad(),
                new SovietSquad()
            };

            return teams;
        }

    }
}
