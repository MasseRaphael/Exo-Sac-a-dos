using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Sac_a_dos
{
    public class Bag
    {
        List<Item> Sac = new List<Item>();

        public void AddItem(Item item)
        {
            Sac.Add(item);
        }

        public void WhatInMyBag()
        {
            IEnumerable<IGrouping<string, Item>> bardat = Sac.GroupBy(i => i.Name);
            foreach (IGrouping<string, Item> b in bardat)
            {
                int count = b.Count();
                Console.WriteLine($"{b.First()} x {count} (valeur: {b.First().Value*count} Gold)");
            }
        }
    }
}
