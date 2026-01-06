using System;

class NumberGuessing
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear();
            Console.WriteLine("===== Number Guessing Game =====");

            // Range selection
            Console.Write("Enter minimum number: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter maximum number: ");
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int numberToGuess = rand.Next(min, max + 1);

            int attempts = 0;
            int maxAttempts = 5;
            int userGuess = 0;

            Console.WriteLine($"\nGuess the number between {min} and {max}");
            Console.WriteLine($"You have {maxAttempts} attempts.\n");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                    continue;
                }

                attempts++;

                if (userGuess < numberToGuess)
                    Console.WriteLine("Too low!");
                else if (userGuess > numberToGuess)
                    Console.WriteLine("Too high!");
                else
                {
                    Console.WriteLine($"\n🎉 Correct! You guessed it in {attempts} attempts.");
                    break;
                }

                Console.WriteLine($"Attempts left: {maxAttempts - attempts}\n");
            }

            if (userGuess != numberToGuess)
            {
                Console.WriteLine($"\n❌ Game Over! The correct number was {numberToGuess}");
            }

            // Play again option
            Console.Write("\nDo you want to play again? (Y/N): ");
            string choice = Console.ReadLine().Trim().ToUpper();

            playAgain = (choice == "Y");
        }

        Console.WriteLine("\nThanks for playing!");
    }
}
