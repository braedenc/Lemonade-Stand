using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Inventory inventory = new Inventory();
        Store store = new Store();
        Day newDay = new Day();
        Rules rules = new Rules();
        public void StartGame()
        {
            rules.DisplayRules();
            
            store.StoreMenu();
            newDay.StartDay();
            
            
            
        }
        
    }
}
