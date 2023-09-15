using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentString = Console.ReadLine();
        int percent = int.Parse(percentString);
        string letter;
        if (percent < 60)
        {
            letter = "F";
        }
        else if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else
        {
            letter = "D";
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, try harder next time.");
        }
    }
}