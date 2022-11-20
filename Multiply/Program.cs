using System;
using System.Text;

namespace Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder sb = new StringBuilder();
            if(multiplier == 0 || bigNum == "0")
            {
                Console.WriteLine("0");
                return;
            }
            for(int i = bigNum.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNum[i].ToString());
                int mult = currentDigit * multiplier + reminder;
                sb.Insert(0, (mult % 10).ToString());
                reminder = mult / 10;
            }
            if(reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
