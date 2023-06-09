using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            object maxValue = GetMax(type, value1, value2);
            Console.WriteLine(maxValue);
        }

        static object GetMax(string type, string value1, string value2)
        {
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(value1);
                    int num2 = int.Parse(value2);
                    return Math.Max(num1, num2);

                case "char":
                    char char1 = char.Parse(value1);
                    char char2 = char.Parse(value2);
                    return (char)Math.Max(char1, char2);

                case "string":
                    return string.Compare(value1, value2) >= 0 ? value1 : value2;

                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }
}