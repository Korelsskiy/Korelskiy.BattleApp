using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class PPGun : IWeapon
    {
        public string Title { get; }

        public int Damage { get; }

        public PPGun(string title)
        {
            Title = title;
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
