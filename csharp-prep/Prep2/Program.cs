using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = grade % 10;
        string sign;
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign ="";
        }

        if (grade >= 97 || grade < 60)
        {
            sign ="";
        }
        Console.WriteLine($"Your grade letter is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the course.");
            Console.WriteLine("Congratulation to your success!!!");
        }
        else
        {
            Console.WriteLine("Sorry, You failed the course.");
            Console.WriteLine("We encourage you to retake the course for a good grade in the future.");
        }
    }
}