using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double max, mid, min;

        if (num1 >= num2 && num1 >= num3)
        {
            max = num1;
            if (num2 >= num3)
            {
                mid = num2;
                min = num3;
            }
            else
            {
                mid = num3;
                min = num2;
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            max = num2;
            if (num1 >= num3)
            {
                mid = num1;
                min = num3;
            }
            else
            {
                mid = num3;
                min = num1;
            }
        }
        else 
        {
            max = num3;
            if (num1 >= num2)
            {
                mid = num1;
                min = num2;
            }
            else
            {
                mid = num2;
                min = num1;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(mid);
        Console.WriteLine(min);
    }
}
