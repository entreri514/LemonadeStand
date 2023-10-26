using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player 
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        public PlayerPurchase();
            public static string YN;

            Console.WriteLine("Would you like to make any purchases? <Y/N> ");
            YN=Console.ReadLine;
            if (YN<>"y") YN="n";
        return;
    }
}
