using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // Wait for user to press Enter before exiting
        Console.WriteLine($"Hit Enter to close the program {firstName}.");
        Console.ReadLine();
    }
}
