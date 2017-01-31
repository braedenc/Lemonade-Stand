using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day: Weather
    {
        Weather dailyWeather = new Weather();
        Recipe recipe = new Recipe();
        List<Customer> listOfCustomers = new List<Customer>();
        public void StartDay()
        {
            
            dailyWeather.GetWeather();
            recipe.GetRecipe();
            GetDailyCustomers();



        }

        public void GetDailyCustomers()
        {
            for(int i = 0; i < dailyWeather.temperature; i++)
            {
                Customer customer = new Customer();
                listOfCustomers.Add(customer);
            }
        }


    }
}
