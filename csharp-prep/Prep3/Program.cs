using System;

class Program
{
    static void Main(string[] args)
    {
        string wantToPlay = "yes";
        while (wantToPlay == "yes")
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            int numberOfGuesses=0;

            string repeat = "yes";
            while (repeat == "yes")
            {
                Console.Write("What is your guess?");
                string userInput2 = Console.ReadLine();
                int guess = int.Parse(userInput2);

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                    repeat = "yes";
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                    repeat = "yes";
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    repeat = "no";
                }
                numberOfGuesses += 1;
            }
            Console.WriteLine($"The number of your guesses is {numberOfGuesses}.");

            Console.Write("Do you want to play again (yes/no)?");
            string userInput3 = Console.ReadLine();
            wantToPlay = userInput3;
        }
    }
}