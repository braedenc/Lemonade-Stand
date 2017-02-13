using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;
        public double dailyMoneyMade;

        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            dailyMoneyMade = 0;
        }
        public void SellLemonade()
        {
            wallet.balance += recipe.pricePerCup;
            dailyMoneyMade += recipe.pricePerCup;
            inventory.iceList.RemoveRange(0, recipe.iceCubesPerCup);
            if (recipe.cupsPerPitcher == 0)
            {
                inventory.lemonList.RemoveRange(0, recipe.lemonsPerPitcher);
                inventory.sugarList.RemoveRange(0, recipe.sugarPerPitcher);
                inventory.cupList.RemoveRange(0, 1);
                recipe.cupsPerPitcher += 12;
            }
            else
            {
                recipe.cupsPerPitcher--;
                inventory.cupList.RemoveRange(0, 1);
            }


        }
    }
}
