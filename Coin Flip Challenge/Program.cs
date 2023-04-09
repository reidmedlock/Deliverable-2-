internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string input = Console.ReadLine();
        
        if (input == "No" || input == "no")
        {
            Console.WriteLine("You are a coward " + name);



        }
        else
        {
            //Console.WriteLine("Heads or Tails?");
            //string answer = Console.ReadLine();



            for (int i = 0; i < 5; i++)
            {

                int coin;
                string userGuess;
                string coinDescription;
                Random rng = new Random();

                Console.Write("Heads or Tails?");
                userGuess = Console.ReadLine();
                //get a random number for coin flip
                coin = rng.Next(0, 2);
                if (coin == 1)
                { coinDescription = "Heads"; }
                else
                {
                    coinDescription = "Tails";
                }

                if ((coin == 0 && userGuess == "Tails") || (coin == 1 && userGuess == "Heads"))
                {
                    Console.WriteLine("Correct {0}", coinDescription);
                }

                else
                {

                    Console.WriteLine("Wrong {0}", coinDescription);

                }
                Console.ReadLine();




            }

        }
    }
}