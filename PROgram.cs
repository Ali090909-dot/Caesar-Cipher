using System;

class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Age Calculator!");
        
        // Ask user for date of birth
        Console.Write("Enter your birth year (e.g., 2000): ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth month (1-12): ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth day (1-31): ");
        int birthDay = int.Parse(Console.ReadLine());

        // Get today's date
        DateTime today = DateTime.Today;
        DateTime birthDate;

        try
        {
            birthDate = new DateTime(birthYear, birthMonth, birthDay);
        }
        catch
        {
            Console.WriteLine("Invalid date entered!");
            return;
        }

        // Calculate age
        int age = today.Year - birthDate.Year;

        if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
        {
            age--; // Birthday has not occurred yet this year
        }

        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
