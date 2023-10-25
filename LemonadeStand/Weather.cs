using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
        
    {
        public string dayConditions;
        public int dayTemperature;
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
            dayTemperature = rand.Next(40) + 50;
            
          }

    }
}
