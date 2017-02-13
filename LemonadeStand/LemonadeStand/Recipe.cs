using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int iceCubesPerCup;
        public double pricePerCup;
        public int cupsPerPitcher = 12;
        public void GetRecipe()
        {
            GetLemonsPerPitcher();
            GetSugarPerPitcher();
            GetIcePerCup();
            SetPricePerCup();
        }

        public int GetLemonsPerPitcher()
        {
            Console.WriteLine("How many lemons would you like to use when making each pitcher?");
            lemonsPerPitcher = Int32.Parse(Console.ReadLine());
            return lemonsPerPitcher;
        }

        public int GetSugarPerPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to use in each pitcher?");
            sugarPerPitcher = Int32.Parse(Console.ReadLine());
            return sugarPerPitcher;
        }

        public int GetIcePerCup()
        {
            Console.WriteLine("How many ice cubes would you like to put in each cup?");
            iceCubesPerCup = Int32.Parse(Console.ReadLine());
            return iceCubesPerCup;
        }

        public double SetPricePerCup()
        {
            Console.WriteLine("What would you like to set as the price for a cup today?");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }
    }
}
