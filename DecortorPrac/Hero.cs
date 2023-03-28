using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecortorPrac
{
    public abstract class MainCharacter
    {
        protected internal string Name { get; set; }
        protected internal int Attack { get; set; }
        protected internal int Speed { get; set; }
        protected internal int Health { get; set; }
        protected internal int Armor { get; set; }
    }
}
