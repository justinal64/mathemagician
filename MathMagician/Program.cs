﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine(""); // I choose which way to have the user enter a method
            // Think about, 'Ho wwill the user pick a command?'
            // Is it better to modify the original question? Make it more useful?


            string command = Console.ReadLine();
            // Once I have the command, how do I check if it's a valid command?


            // When should you actually create an instance of your number class? 
            Console.WriteLine("How many should I print?");

            string howMany = Console.ReadLine();

            // When do I check if the "How Many" response is too big?
            // If they enter a number > 30, how do I respond and exit the program?

            Console.WriteLine($"Cool, I'm going to print {command} {howMany} numbers.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
