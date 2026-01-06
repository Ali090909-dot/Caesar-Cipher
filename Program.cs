using System;

class RockPaperScissors
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random rand = new Random();
        string playAgain = "y"; // Initialize with "y" so the loop can start

        do
        {
            Console.Write("Enter rock, paper, or scissors: ");
            string userChoice = Console.ReadLine().Trim().ToLower();

            if (!Array.Exists(choices, c => c == userChoice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            string computerChoice = choices[rand.Next(0, 3)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
                Console.WriteLine("It's a draw!");
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
                Console.WriteLine("You win!");
            else
                Console.WriteLine("Computer wins!");

            // Ask to play again
            do
            {
                Console.Write("Play again? (y/n): ");
                playAgain = Console.ReadLine().Trim().ToLower();
            } while (playAgain != "y" && playAgain != "n");

        } while (playAgain == "y");

        Console.WriteLine("Thanks for playing!");
    }
}
