using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
        
    {
        public string dayForecastConditions,dayConditions;
        public int dayForecastTemperature,dayTemperature;
        public int roll;
        public Random rand;

        public Weather()
        {

        }
            public string GetWeatherCondition(string dayConditions)
        { 
            rand=new Random(0);
            roll=rand.Next(3);

            if (roll == 1) dayForecastConditions = "Clear";
            if (roll == 2) dayForecastConditions = "Cloudy";
            if (roll == 3) dayForecastConditions = "Rainy";

            

            if (rand.Next(100) < 50)

            {
                roll = rand.Next(3);
                if (roll == 1) dayConditions = "Clear";
                if (roll == 2) dayConditions = "Cloudy";
                if (roll == 3) dayConditions = "Rainy";
            }
            else { dayConditions = dayForecastConditions; }

            
            
            return (dayConditions);
        }
        public int GetWeatherTemperature(int dayTemperature)
        {
            rand = new Random(0);
            dayForecastTemperature = rand.Next(50, 90);

            if (rand.Next(100) < 50) dayTemperature = dayForecastTemperature - (rand.Next(9));
            else { dayTemperature = dayForecastTemperature + (rand.Next(9)); }
            return (dayTemperature);
        }
        public void DisplayForecast()
        {
            Console.WriteLine("Forecast for today: /n");
            Console.WriteLine(dayForecastTemperature + " ," + dayForecastConditions);
        }
    }
}
