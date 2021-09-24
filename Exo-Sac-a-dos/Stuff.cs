using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Sac_a_dos
{
    public class Stuff : Item
    {
        public List<Misc> Scrap;

        public Stuff(string name, string type, int value, List<Misc> scrap) : base(name, type, value)
        {
            Scrap = scrap;
        }

        public List<Misc> Recycle()
        {
            return Scrap;
        }
    }
}
