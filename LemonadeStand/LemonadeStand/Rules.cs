using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Rules
    {
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the lemonade stand game!");
            Console.WriteLine("\nRules: \n  You will have one week to make as much money possible at your lemonade stand. \n  You will start off with $20. \n   At the beginning of each you will be told the weather for that day and given the chance to buy supplies from the store and change your recipe.");
            Console.WriteLine("\nYou have no supplies, to start you will have to buy some supplies from the store.");
            Console.ReadLine();
        }
    }
}
