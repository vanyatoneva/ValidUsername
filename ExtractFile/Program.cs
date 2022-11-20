﻿using System;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);
            string[] file = path[path.Length - 1].Split(".");
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}