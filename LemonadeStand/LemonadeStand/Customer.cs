using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Recipe recipe = new Recipe();
        Wallet wallet = new Wallet();
        Weather weather = new Weather();
        Random rnd = new Random();
        Inventory inventory = new Inventory();
        int buyingFactor;

        public Customer()
        {
            buyingFactor = rnd.Next(1, 11);
        }
        
        public void BuyLemonade()
        {
            wallet.balance += recipe.pricePerCup;
            inventory.iceList.RemoveRange(0, inventory.iceList.Count -recipe.iceCubesPerCup);
            if (recipe.cupsPerPitcher == 0)
            {
                inventory.lemonList.RemoveRange(0, inventory.lemonList.Count -recipe.lemonsPerPitcher);
                inventory.sugarList.RemoveRange(0, inventory.sugarList.Count -recipe.sugarPerPitcher);
            } else
            {
                recipe.cupsPerPitcher--;
            }


        }

        public void WeatherFactor(string condition)
        {
            switch (condition)
            {
                case "clear and sunny":
                    if(buyingFactor  < 10)
                    {
                        BuyLemonade();
                    }
                    break;

                case "overcast":
                    if(buyingFactor < 6)
                    {
                        BuyLemonade();
                    }
                    break;

                case "rainy":
                    if(buyingFactor < 4)
                    {
                        BuyLemonade();
                    }
                    break;

                case "partly cloudy":
                    if(buyingFactor < 8)
                    {
                        BuyLemonade();
                    }
                    break;

            }
        }
    }
}
