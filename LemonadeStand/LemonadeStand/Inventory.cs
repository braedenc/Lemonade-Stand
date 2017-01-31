using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Ice> iceList;
        public List<Lemons> lemonList;
        public List<Cups> cupList;
        public List<Sugar> sugarList;
        public Inventory()
        {
            iceList = new List<Ice>();
            lemonList = new List<Lemons>();
            cupList = new List<Cups>();
            sugarList = new List<Sugar>();
        }
        public string InventoryReport()
        {
            string report = "Ice cubes: \t\t[" + (iceList.Count) + "]" + "\nLemons: \t\t[" + (lemonList.Count) + "]" + "\nCups: \t\t[" + (cupList.Count) + "]" + "\nCups of Sugar: \t\t[" + (sugarList.Count) + "]";
            return report;
            
        }
    }
}
