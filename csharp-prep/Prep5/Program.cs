using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static string DisplayWelcome()
        {
            string message = "Welcome to the Program!";
            return message;
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        
        static void DisplayResult(string name, int number)
        {
        Console.WriteLine($"{name}, the square of your number is {number}.");
        }

        Console.WriteLine(DisplayWelcome());
        string name = PromptUserName();
        int x= PromptUserNumber();
        int number = SquareNumber(x);
        DisplayResult(name,number);
    }
}