using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Sac_a_dos
{
    public abstract class Item
    {
        public string Name;
        public string Type;
        public int Value;

        public Item(string name, string type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
