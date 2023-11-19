using System;

class Program
{
    static void Main()
    {
        // Core Requirements
        Console.Write("Enter your grade percentage: ");
        double percentage = double.Parse(Console.ReadLine());

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}.");
        }
        else
        {
            Console.WriteLine($"Keep working hard! You got a {letter}. Better luck next time.");
        }

        // Stretch Challenge
        int lastDigit = (int)(percentage % 10);
        string sign = "";

        if (letter == "A")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letter == "A" && (sign == "+" || sign == "-"))
        {
            Console.WriteLine("A grades can only be A, not A+ or A-.");
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            Console.WriteLine("F grades cannot have a sign.");
        }
        else
        {
            Console.WriteLine($"Your final grade is: {letter}{sign}");
        }
        Console.WriteLine($"Hit Enter to close the program.");
        Console.ReadLine();

    }
    
}
