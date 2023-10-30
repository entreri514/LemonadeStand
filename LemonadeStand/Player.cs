using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
        public void PlayerPurchase()
        {

            string YN="y";
            while (YN=="y")
            { 
            Console.WriteLine("Would you like to buy any items today? <y/n> ");
            string input = Console.ReadLine();
            if (input != "y") input = "n";
            if (input == "n") YN="n";
            if (YN != "n")
                {
                Console.WriteLine("What would you like to purchase ");
                Console.WriteLine("1. Lemons ");
                Console.WriteLine("2. Sugar ");
                Console.WriteLine("3. Ice Cubes ");
                Console.WriteLine("4. Cups ");
                string input2 = Console.ReadLine();
                int entry = int.Parse(input2);
                Store store = new Store();
                Player player = new Player();
                if (entry == 1) store.SellLemons(player);
                if (entry == 2) store.SellSugarCubes(player);
                if (entry == 3) store.SellIceCubes(player);
                if (entry == 4) store.SellCups(player);
                }
            }
            return;
        }
    }
}
