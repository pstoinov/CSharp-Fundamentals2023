using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string regexPattern = @"^([$%])([A-Z][a-z]{2,})\1: \[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
        Regex regex = new Regex(regexPattern);

        for (int d = 0; d < n; d++)
        {
            string message = Console.ReadLine();
            Match match = regex.Match(message);

            if (match.Success)
            {
                string tag = match.Groups[2].Value;
                int firstNumber = int.Parse(match.Groups[3].Value);
                int secondNumber = int.Parse(match.Groups[4].Value);
                int thirdNumber = int.Parse(match.Groups[5].Value);

                string decryptedMessage = $"{(char)firstNumber}{(char)secondNumber}{(char)thirdNumber}";
                Console.WriteLine($"{tag}: {decryptedMessage}");
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}