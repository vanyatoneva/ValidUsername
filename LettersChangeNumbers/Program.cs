using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputStrings = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                ToList();
            decimal totalResult = 0.00m;
            foreach(string inputString in inputStrings)
            {
                char firstLetter = inputString[0];
                char lastLetter = inputString[inputString.Length - 1];
                int num = int.Parse(inputString.Substring(1, inputString.Length - 2));
                totalResult += changeNumber(firstLetter, num, lastLetter);
            }
            Console.WriteLine($"{totalResult:f2}");
        }

        static decimal changeNumber(char firstLetter, int number, char lastLetter)
        {
            decimal result = 0.00m;
            if(firstLetter >= 65 && firstLetter <= 90)
            {
                int position = firstLetter - 64;
                result = (decimal)number / (decimal)position;
            }
            else if(firstLetter >= 97 && firstLetter <= 122)
            {
                int position = firstLetter - 96;
                result = (decimal)number * (decimal)position;
            }
            if (lastLetter >= 65 && lastLetter <= 90)
            {
                int position = lastLetter - 64;
                result -= position;
            }
            else if (lastLetter >= 97 && lastLetter <= 122)
            {
                int position = lastLetter - 96;
                result += position;
            }
            return result;
        }
    }
}
