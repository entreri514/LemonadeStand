namespace LemonadeStand
{
    public class Game
    {
        string dayConditions;
        int dayTemperature;
        Player player=new Player();
        List<Day> Days;
        int currentDay;
        Recipe recipe=new Recipe();
        Inventory inventory=new Inventory();
        Weather weather=new Weather();
        Day day = new Day();
        double paymentCollected;
        
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
                weather.GetWeatherCondition(dayConditions);
                weather.GetWeatherTemperature(dayTemperature);
                weather.DisplayForecast();
                recipe.DisplayRecipe();
                recipe.ChangeRecipe();
                recipe.ChangePrice();
                inventory.DisplayInventory();
                player.PlayerPurchase();
                UserInterface.GetNumberOfPitchers();
                day.CreateCustomers();
                day.CustomerWalkingby(recipe.price);
                paymentCollected = day.customersBought * recipe.price;

                currentDay++;
            }
        }
        
        
        
    }
 }
