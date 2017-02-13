using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int temperature;
        public string condition;
        public void GetWeather()
        {
            TempGenerator();
            ConditionGenerator();
            Console.WriteLine("The weather for the day is "+temperature+" degrees and "+condition+"");
            Console.ReadLine();
        }

        public int TempGenerator()
        {
            Random rnd = new Random();
            temperature = rnd.Next(55, 100);
            return temperature;
        }

        public void ConditionGenerator()
        {
            int rndCondition;
            Random rnd = new Random();
            rndCondition = rnd.Next(1, 5);
            if(rndCondition == 1)
            {
                condition = "clear and sunny";
            }else if(rndCondition == 2)
            {
                condition = "overcast";
            }else if(rndCondition == 3)
            {
                condition = "rainy";
            }else if(rndCondition == 4)
            {
                condition = "partly cloudy";
            }
        }
    }
}
