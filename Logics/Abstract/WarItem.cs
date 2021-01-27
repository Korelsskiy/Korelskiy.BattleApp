using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public abstract class WarItem
    {
        public string Name { get; protected set; }
        public List<Soldier> Personnel { get; protected set; }
    }
}
