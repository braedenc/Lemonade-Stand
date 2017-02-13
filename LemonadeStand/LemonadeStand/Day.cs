using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather dailyWeather;
        public List<Customer> listOfCustomers;
        public Results results;
        public double thisDayMoneySpent;
        public double thisDayMoneyMade;
        public double thisDayProfit;

        public Day()
        {
            listOfCustomers = new List<Customer>();
            dailyWeather = new Weather();
            results = new Results();
        }
        public void StartDay(Player player, Store store)
        {
            Console.Clear();
            dailyWeather.GetWeather();
            thisDayMoneySpent = store.StoreMenu();
            player.recipe.GetRecipe();
            Console.WriteLine("Press any button to start your day and see how you did!");
            Console.ReadLine();
            GetDailyCustomers();
            player.inventory.SellLemonadeToCustomer(listOfCustomers, player, dailyWeather);
            thisDayMoneyMade = player.dailyMoneyMade;
            thisDayProfit = GetDailyProfit(thisDayMoneySpent, thisDayMoneyMade);
            results.DisplayDailyResults(thisDayMoneySpent, thisDayMoneyMade, thisDayProfit);
            store.dailyMoneySpent = 0;
            player.dailyMoneyMade = 0;

        }

        public void GetDailyCustomers()
        {
            for(int i = 0; i < dailyWeather.temperature; i++)
            {
                Customer customer = new Customer();
                listOfCustomers.Add(customer);
            }
        }
        
        public double GetDailyProfit(double moneySpent, double moneyMade)
        {
            double dailyProfit = moneyMade - moneySpent;
            return dailyProfit;
        }

        public double GetDailyMoneySpent()
        {
            double dailyMoneySpent = thisDayMoneySpent;
            return dailyMoneySpent;
        }

        public double GetDailyMoneyMade()
        {
            double dailyMoneyMade = thisDayMoneyMade;
            return dailyMoneyMade;
        }

    }
}
