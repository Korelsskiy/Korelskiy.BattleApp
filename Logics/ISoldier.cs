using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public interface ISoldier : IWarItem
    {
        public int Health { get; }
    }
}
