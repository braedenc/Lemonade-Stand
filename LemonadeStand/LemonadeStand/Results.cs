using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Results
    {
        
        
        public void DisplayDailyResults(double moneySpent, double moneyMade, double profit)
        {
            Console.WriteLine("You spent "+moneySpent+" on supplies today.");
            Console.WriteLine("You made "+moneyMade+".");
            Console.WriteLine("Your profit for the day is "+profit+".");
            Console.ReadLine();
        }

        public void DisplayEndResults(double totalMoneySpent, double totalMoneyMade, double totalProfit)
        {
            Console.WriteLine("You spent a total of " + totalMoneySpent + " on supplies.");
            Console.WriteLine("All together you made " + totalMoneyMade + ".");
            Console.WriteLine("Your profit for the week is " + totalProfit + ".");
            Console.ReadLine();
        }
    }
}
