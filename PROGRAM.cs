using System;

class MadLibs
{
    static void Main()
    {
        Console.WriteLine("Welcome to Mad Libs Game!");
        Console.WriteLine("You'll be asked to enter words to create a funny story.");
        Console.WriteLine();

        // Ask for words
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        Console.Write("Enter a place: ");
        string place = Console.ReadLine();

        Console.Write("Enter a noun: ");
        string noun = Console.ReadLine();

        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();

        Console.Write("Enter an adjective: ");
        string adjective = Console.ReadLine();

        Console.Write("Enter an animal: ");
        string animal = Console.ReadLine();

        // Create the story
        string story = $@"
Once upon a time, {name} went to {place}.
There, {name} saw a {adjective} {noun} that could {verb}.
Suddenly, a {animal} appeared and everyone laughed.
It was the most unforgettable day of {name}'s life!
";

        // Show the story
        Console.WriteLine();
        Console.WriteLine("Here's your Mad Libs story:");
        Console.WriteLine(story);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
