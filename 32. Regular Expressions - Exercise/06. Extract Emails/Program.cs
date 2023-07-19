using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailsReg = new Regex(@" (?<user>(?:[A-Za-z0-9]+)[._-]?[A-Za-z0-9]+)@(?<host>(?:[A-Za-z0-9]+(\.|-))*[A-Za-z0-9]+\.[A-Za-z]+)");
            var text = Console.ReadLine();
            var matchCollection = emailsReg.Matches(text);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
