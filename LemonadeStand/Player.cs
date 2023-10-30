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
        public string PlayerPurchase()
        {
            string YN;
            Console.WriteLine("Would you like to buy any items today? <y/n> ");
            YN = Console.ReadLine();
            if (YN != "y") YN = "n";
            if (YN == "n") return (YN);

            Console.WriteLine("What would you like to purchase /n");
            Console.WriteLine("1. Lemons/n");
            Console.WriteLine("2. Sugar/n");
            Console.WriteLine("3. Ice Cubes/n");
            Console.WriteLine("4. Cups/n");
            string input = Console.ReadLine();
            int entry = int.Parse(input);
            Store store = new Store();
            Player player = new Player();
            if (entry == 1) store.SellLemons(player);
            if (entry == 2) store.SellSugarCubes(player);
            if (entry == 3) store.SellIceCubes(player);
            if (entry == 4) store.SellCups(player);

                return (YN);
        }
    }
}
