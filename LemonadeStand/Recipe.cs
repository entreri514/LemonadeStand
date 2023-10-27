using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = .25;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }
        public void ChangeRecipe()
        {
            string YN;
            Console.WriteLine("Would you like to change the recipe for today? <y or n>");
            YN = Console.ReadLine();
            if (YN != "y") return;
            Console.WriteLine("Enter number of lemons: ");
            string input = Console.ReadLine();
            numberOfLemons = int.Parse(input);
            Console.WriteLine("Enter number of sugar cubes: ");
            input = Console.ReadLine();
            numberOfSugarCubes = int.Parse(input);
            Console.WriteLine("Enter number of ice cubes: ");
            input = Console.ReadLine();
            numberOfIceCubes = int.Parse(input);
            return;
        }
        public void ChangePrice()
        {
            Console.WriteLine("Enter today's price: ");
            string input=Console.ReadLine();
            price = double.Parse(input);

        }
    }   
}
