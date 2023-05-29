using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        string output = "";

        while (true)
        {
            string line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                break;
            }

            if (line.Length == 1 && char.IsDigit(line[0]))
            {
                input += line[0];
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            char currentDigit = input[i];
            int mainDigit = int.Parse(currentDigit.ToString());
            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 7 || mainDigit == 9)
            {
                offset += 1;
            }

            int letterIndex = offset + GetDigitLength(mainDigit) - 1;
            char letter = (char)(97 + letterIndex);

            output += letter;
        }
        Console.WriteLine(output);
    }

    static int GetDigitLength(int digit)
    {
        if (digit == 0 || digit == 1)
        {
            return 1;
        }
        else if (digit == 7 || digit == 9)
        {
            return 4;
        }
        else
        {
            return 3;
        }
    }
}
