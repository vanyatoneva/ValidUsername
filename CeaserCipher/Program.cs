using System;
using System.Text;

namespace CeaserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalText = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char c in originalText)
            {
                stringBuilder.Append((char)(c + 3));
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
