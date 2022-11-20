using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> validUserNames = usernames.Where(x => IsValidUsername(x)).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, validUserNames));
        }

        public static bool IsValidUsername(string s)
        {
            if (s.Length < 3 || s.Length > 16) return false;
            foreach(char c in s)
            {
                if (!(char.IsLetterOrDigit(c) || c == '-' || c == '_')){
                    return false;
                }
            }

            return true;
        }
    }

    
}
