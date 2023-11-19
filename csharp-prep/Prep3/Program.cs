using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Core Requirements
            int magicNumber = GenerateRandomNumber();
            int guess;
            int attempts = 0;

            Console.WriteLine("Welcome to Guess My Number!");

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                attempts++;

            } while (guess != magicNumber);

            // Stretch Challenge
            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            playAgain = (playAgainResponse == "yes");
        }
    }

    static int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 101); // Generates a random number between 1 and 100
    }
}
