﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Palindrome_using_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check if is a Palindrome : \n");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine("{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine("{name} is not Palindrome");
            }
            Console.Read();
        }
    }
}
