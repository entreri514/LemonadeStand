﻿using LemonadeStand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{ 
    internal class Day
    {
        public List<Customer> customers;
        int customersBought;


        public Day()
        {
            customers = new List<Customer>();
        }

        Weather weather = new Weather();
        public void StartDay()
        {

        }           


        public void CreateCustomers(int numOfCustomers = 25)
        {   
            for (int i = 0; i < numOfCustomers; i++)
            {   
            customers.Add(new Customer());
            }
        }       
        public void CustomerWalkingby(double lemonadePrice)
        {
            int customersBought = 0;

            foreach (Customer customer in customers)
            { 
            
                if (customer.WillBuyLemonade(lemonadePrice))
                {
                Console.WriteLine("A customer bought lemonade.");

                customersBought++;
                
                }
                else
                {
                Console.WriteLine("A customer walked away.");
        
                }
                
            }
            
        }
    }
 }
