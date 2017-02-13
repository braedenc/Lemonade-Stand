using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random rnd = new Random();
        public int buyingFactor;
        public int buyingFactor2;
        

        public Customer()
        {
            buyingFactor = rnd.Next(1, 11);
            buyingFactor2 = rnd.Next(1, 21);
        }
        
        public void BuyLemonade(string condition, Player player)
        {
            bool priceFactor = PriceFactor(player.recipe.pricePerCup);
            bool weatherFactor = WeatherFactor(condition);
            if(weatherFactor == true && priceFactor == true)
            {
                player.SellLemonade();
            }
        }

        public bool PriceFactor(double price)
        {
            bool value = false;
            if (price <= 0.10)
            {
                value = true;
                return value;
            } else if (price > 0.10 && price <= 0.20 && buyingFactor2 < 20)
            {
                value = true;
                return value;
            } else if (price > 0.20 && price <= 0.34 && buyingFactor2 < 18)
            {
                value = true;
                return value;
            } else if (price > 0.34 && price <= 0.50 && buyingFactor2 < 13)
            {

            } else if (price > 0.50 && buyingFactor2 < 6)
            {
                value = true;
                return value;
            }
            return value;
        }
        public bool WeatherFactor(string condition)
        {
            bool value = false;
            switch (condition)
            {
                case "clear and sunny":
                    if(buyingFactor  < 10)
                    {
                        value = true;
                        return value;
                    }
                    return value;

                case "overcast":
                    if(buyingFactor < 6)
                    {
                        value = true;
                        return value;
                    }
                    return value;

                case "rainy":
                    if(buyingFactor < 4)
                    {
                        value = true;
                        return value;
                    }
                    return value;

                case "partly cloudy":
                    if(buyingFactor < 8)
                    {
                        value = true;
                        return value;
                    }
                    return value;

            }
            return value;
        }
    }
}
