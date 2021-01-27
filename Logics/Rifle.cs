using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class Rifle : IWeapon
    {
        public string Title { get; }

        public int Damage { get; }
        public Rifle(string title)
        {
            Title = title;
        }

        public void Shoot()
        {
            Console.WriteLine("Mosin Shoot");
        }
    }
}
