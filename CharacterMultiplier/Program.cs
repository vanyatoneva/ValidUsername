using System;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(MultiplyStrings(userInput[0], userInput[1]));
        }

        static long MultiplyStrings(string s1, string s2)
        {
            long result = 0;
            int shortestLength = Math.Min(s1.Length, s2.Length);
            for(int i = 0; i < shortestLength; i++)
            {
                result += s1[i] * s2[i];
            }
            string longestOne = s1.Length > s2.Length ? s1.Substring(shortestLength) : s2.Substring(shortestLength);
            for(int i = 0; i < longestOne.Length; i++)
            {
                result += longestOne[i];
            }
            return result;
        }
    }
}
