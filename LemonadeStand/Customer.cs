using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        Day day=new Day();
        public Customer(Day.Customer.customers);
        double willingToPay;

        public Customer()
        {
            Random rand = new Random();
            willingToPay = rand.Next(20, 50) / 100;

                     

        }

        public bool WillBuyLemonade(double price)
        {

            return willingToPay >= price;

        }
    }
}
