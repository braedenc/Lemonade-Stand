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
        public void StartGame()
        {
            Console.WriteLine("Welcome to the lemonade stand game! You have no supplies, to start you will have to buy some supplies from the store.");
            Console.ReadLine();
            store.StoreMenu();
            
            
            
        }
        
    }
}
