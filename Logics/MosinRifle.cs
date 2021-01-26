using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class MosinRifle : IWeapon
    {
        public string Title => "Винтовка Мосина";

        public int Damage => 9;

        public void Shoot()
        {
            Console.WriteLine("Mosin Shoot");
        }
    }
}
