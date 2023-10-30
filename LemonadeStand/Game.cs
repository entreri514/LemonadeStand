namespace LemonadeStand
{
    public class Game
    {
        Player player;
        List<Day> Days;
        int currentDay;
        Recipe recipe;
        Inventory inventory;
        public Game()
        {
            
        }



        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to LemonadeStand!/n");
            Console.WriteLine("You start off with $20.00 and an inventory/n");
            Console.WriteLine("You have a week to make or break your business!/n");
            Console.WriteLine("Good luck!!");

        }                
       public void RunGame()
        {
            currentDay = 1;
            DisplayWelcome();
            while (currentDay < 8)
            {
                recipe.DisplayRecipe();
                recipe.ChangeRecipe();
                player.PlayerPurchase();
                inventory.DisplayInventory();
            }
        }
        
        
        
    }
 }
