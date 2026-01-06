using System;

class Program
{
    static void Main()
    {
        // 1. Get the word from the user
        Console.Write("Enter word to process: ");
        string input = Console.ReadLine();

        // 2. Set a shift value (3 is the standard Caesar shift)
        int shift = 1;

        // 3. Run the encryption and decryption
        string encrypted = Cipher(input, shift);
        string decrypted = Cipher(encrypted, -shift);

        // 4. Show the results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Step 1 (Original):  {input}");
        Console.WriteLine($"Step 2 (Encrypted): {encrypted}");
        Console.WriteLine($"Step 3 (Decrypted): {decrypted}");

        Console.WriteLine("\nDone! Press any key to close.");
        Console.ReadKey();
    }

    static string Cipher(string text, int shift)
    {
        char[] result = text.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                // Rotate the letter and handle the wrap-around
                int letterPos = result[i] - offset;
                int newPos = (letterPos + shift) % 26;
                if (newPos < 0) newPos += 26;

                result[i] = (char)(newPos + offset);
            }
        }
        return new string(result);
    }
}
