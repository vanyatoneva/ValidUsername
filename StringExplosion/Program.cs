using System;
using System.Linq;
using System.Text;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int charsToRemove = 0;
            foreach(char c in input)
            {
                //abv>1>1>2>2asdasd
                if (charsToRemove > 0 && c != '>')
                {
                    charsToRemove--;
                    input = input.Substring(1);
                    continue;
                }
                if (charsToRemove == 0 || c == '>')
                {
                    sb.Append(c);
                }
                if (c == '>')
                {
                    charsToRemove += int.Parse(input[input.IndexOf(c) + 1].ToString());
                }
                input = input.Substring(1);
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
