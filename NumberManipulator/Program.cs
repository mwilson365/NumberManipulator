﻿using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num * num + 14 - 3);
        }
    }
}
