namespace LemonadeStand
{
    internal class Game
    {
        Player player;
        List<Day> Days;
        int currentDay;


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

        public string PlayerPurchase(string YN)
        {
        Console.WriteLine("Would you like to buy any items today? <y/n> ");
        YN = Console.ReadLine();
            if (YN != "y") YN = "n";
            if (YN == "n") return (YN);





            return (YN);
        }

        public void RunGame()
        { 
    
        }
        RunGame();
        DisplayWelcome();
        PlayerPurchase("");
    }
}
