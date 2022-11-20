using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> chars = new List<char>();
            foreach(char c in input)
            {
                if(chars.Count == 0)
                {
                    chars.Add(c);
                }
                if (chars[chars.Count - 1] != c)
                {
                    chars.Add(c);
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin("",chars);
            Console.WriteLine(sb.ToString());
            
        }
    }
}
