using Logics;
using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Rifleman rifleman = new Rifleman("Рядовой Петров", new MosinRifle());

            rifleman.Shoot();

            Console.ReadKey();
        }
    }
}
