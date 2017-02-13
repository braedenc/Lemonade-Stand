using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player;
        Store store;
        Day newDay;
        Rules rules;
        Results results;
        int numberOfDays;
        public double totalMoneySpent;
        public double totalMoneyMade;
        public double totalProfit;
        public Game()
        {
            player = new Player();
            store = new Store(player);
            rules = new Rules();
            results = new Results();
            numberOfDays = 7;
        }
        public void StartGame()
        {
            rules.DisplayRules();

            for (int i = 1; i <= numberOfDays; i++)
            {
                newDay = new Day();
                newDay.StartDay(player, store);
                totalMoneySpent += newDay.GetDailyMoneySpent();
                totalMoneyMade += newDay.GetDailyMoneyMade();
                totalProfit += newDay.GetDailyProfit(newDay.thisDayMoneySpent, newDay.thisDayMoneyMade);
            }

            results.DisplayEndResults(totalMoneySpent, totalMoneyMade, totalProfit);
        }
        
    }
}
