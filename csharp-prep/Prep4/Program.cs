using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> listOfNumbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            listOfNumbers.Add(number);
        }
        listOfNumbers.RemoveAt(listOfNumbers.Count-1);
        Console.WriteLine($"The sum is: {listOfNumbers.Sum()}");
        Console.WriteLine($"The average is: {listOfNumbers.Average()}");
        Console.WriteLine($"The largest number is: {listOfNumbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {listOfNumbers.Where(x => x > 0).Min()}");
        
        listOfNumbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in listOfNumbers)
        {
            Console.WriteLine(sortedNumber);
        }
    }
}