using System;

class TempConverter
{
    static void Main()
    {
        Console.Write("Enter temperature: ");
        if (!double.TryParse(Console.ReadLine(), out double temp))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Convert to (C)elsius or (F)ahrenheit? ");
        string choice = Console.ReadLine().Trim().ToUpper();

        if (choice == "C")
        {
            double c = (temp - 32) * 5 / 9;
            Console.WriteLine($"{temp}°F = {c:F2}°C");
        }
        else if (choice == "F")
        {
            double f = temp * 9 / 5 + 32;
            Console.WriteLine($"{temp}°C = {f:F2}°F");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
