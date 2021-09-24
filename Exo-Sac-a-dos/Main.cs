using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Sac_a_dos
{
    class void Main()
    {
        Bag Sac = new Bag();
        Misc Sapphire = new Misc("Sapphire", "gemme", 150);
        Misc Diamond = new Misc("Diamant", "Matériau", 500);
        Misc Fer = new Misc("Minerai de fer", "Matériau", 50);
        Misc Wood = new Misc("Baton", "Matériau", 50);
        Stuff Sword = new Stuff("Epée", "arme", 150, new List<Misc>
        {
            Fer,
            Fer,
            Fer,
            Wood
        });
    }
}
