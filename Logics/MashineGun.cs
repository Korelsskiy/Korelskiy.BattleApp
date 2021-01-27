using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class MashineGun : IWeapon
    {
        public string Title { get; }

        public int Damage { get; }
        public MashineGun(string title)
        {
            Title = title;
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
