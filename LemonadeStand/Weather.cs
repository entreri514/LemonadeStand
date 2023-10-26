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
        
            public Weather(string dayConditions,int dayTemperature)
        {   
            rand=new Random(0);
            roll=rand.Next(3);

            if (roll == 1) dayConditions = "Clear";
            if (roll == 2) dayConditions = "Cloudy";
            if (roll == 3) dayConditions = "Rainy";

            rand = new Random(0);
            dayTemperature = rand.Next(50,90);

            if (rand.Next(100) < 50)

            {
                roll = rand.Next(3);
                if (roll == 1) dayForecastConditions = "Clear";
                if (roll == 2) dayForecastConditions = "Cloudy";
                if (roll == 3) dayForecastConditions = "Rainy";
            }
            else dayForecastConditions = dayConditions;

            if (rand.Next(100) < 50) dayForecastTemperature = dayForecastTemperature - (rand.Next(8));
            else dayForecastTemperature = dayForecastTemperature + (rand.Next(9));
                
        }

    }
}
