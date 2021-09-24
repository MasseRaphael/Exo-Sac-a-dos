using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Sac_a_dos
{
    class Program
    {
        static void Main()
        {
            Bag Sac = new Bag();
            Misc Sapphire = new Misc("Sapphire", "gemme", 150);
            Misc Diamond = new Misc("Diamant", "Matériau", 500);
            Misc Iron = new Misc("Minerai de fer", "Matériau", 50);
            Misc Wood = new Misc("Baton", "Matériau", 50);
            Stuff Sword = new Stuff("Epée", "arme", 150, new List<Misc>
            {
                Iron,
                Iron,
                Iron,
                Wood
            });

            Stuff EpicSword = new Stuff("Epée Epique", "arme", 3000, new List<Misc>
            {
                Diamond,
                Diamond,
                Iron,
                Wood
            });

            Sac.AddItem(Sapphire);
            Sac.AddItem(Sapphire);
            Sac.AddItem(Diamond);
            Sac.AddItem(Iron);
            Sac.AddItem(Iron);
            Sac.AddItem(Iron);
            Sac.AddItem(Iron);
            Sac.AddItem(Iron);
            Sac.AddItem(Sword);
            Sac.AddItem(EpicSword);

            Sac.WhatInMyBag();



        }
    }
}
